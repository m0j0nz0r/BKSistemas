Option Strict Off
Option Explicit On

Friend Class UR
    Inherits System.Windows.Forms.Form
    Public reg As Double = 0
   
    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        TURNumero.Text = ""
        TURMonto.Text = ""
        Me.Close()
    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim mesgestion As Date
        Dim row As DataRow

        ' ADD RECORD
        If (TURNumero.Text <> "") And (TURMonto.Text <> "") Then
            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TURFecha.Value) < Month(mesgestion)) And (Year(TURFecha.Value) < Year(mesgestion))) Or ((Year(TURFecha.Value) < Year(mesgestion))) Or ((Month(TURFecha.Value) <= Month(mesgestion)) And (Year(TURFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TURFecha.Value, CDbl(TURNumero.Text), "UR", existe)
                If (existe = 0) Then
                    row = MainDSO.Tables("TblLibroIE").NewRow
                    row("IdReg") = TURNumero.Text
                    row("IdBK") = codi
                    row("fecha") = SQLDate(TURFecha.Value)
                    row("NoCredito") = 0
                    row("NoRecibo") = TURNumero.Text
                    row("CI") = "----------"
                    row("codope") = "UR"
                    row("Descripcion") = "Ganancias Repartidas"
                    row("Ingreso") = 0
                    row("Egreso") = CDbl(TURMonto.Text)
                    row("Saldo") = ThisBanko("SaldoBk")
                    LibroAdd(row)
                    fechas = Fcod(fechaU, ncod)
                    TURNumero.Text = CStr(ncod)
                    TURMonto.Text = ""
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub TURMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TURMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TURMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TURMonto.Leave
        If (TURMonto.Text <> "") Then
            TURMonto.Text = VB6.Format(CDec(TURMonto.Text), "###,###.00")
        End If
    End Sub

    Private Sub TURNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TURNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TURFecha.Focus()
        Else
            If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
                KeyAscii = 0
            End If

        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub UR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TURFecha.Value, ncod)
        TURNumero.Text = ncod
    End Sub
End Class