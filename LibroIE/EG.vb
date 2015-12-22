Option Strict Off
Option Explicit On
Friend Class EGForm
    Inherits System.Windows.Forms.Form
    Public reg As Double = 0
    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
        TEGNumero.Text = ""
        TEGMonto.Text = ""
        Me.Close()
    End Sub

    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
        Dim primerafecha As Date
        Dim prifecha As Date
        Dim ultimafecha As Date
        Dim existe As Short
        Dim existe2 As Short
        Dim mesgestion As Date

        If (TEGNumero.Text <> "") And (TEGMonto.Text <> "") Then

            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)

            If ((Month(TEGFecha.Value) < Month(mesgestion)) And (Year(TEGFecha.Value) < Year(mesgestion))) Or ((Year(TEGFecha.Value) < Year(mesgestion))) Or ((Month(TEGFecha.Value) <= Month(mesgestion)) And (Year(TEGFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TEGFecha.Value, CDbl(TEGNumero.Text), "EG", existe)
                If (existe = 0) Then
                    rstentrar = MainDSO.Tables("TblLibroIE").NewRow
                    rstentrar("IdBK") = codi
                    rstentrar("fecha") = SQLDate(TEGFecha.Value)
                    rstentrar("NoCredito") = 0
                    rstentrar("NoRecibo") = TEGNumero.Text
                    rstentrar("CI") = "----------"
                    rstentrar("codope") = "EG"
                    rstentrar("Descripcion") = "Otros Egresos"
                    rstentrar("Ingreso") = 0
                    rstentrar("Egreso") = CDbl(TEGMonto.Text)
                    rstentrar("Saldo") = ThisBanko("SaldoBk")
                    LibroAdd(rstentrar)
                    TEGNumero.Text = ""
                    TEGMonto.Text = ""
                    fechas = Fcod(fechaU, ncod)
                    TEGNumero.Text = CStr(ncod)
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub TEGMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TEGMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TEGMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TEGMonto.Leave
        If (TEGMonto.Text <> "") Then
            TEGMonto.Text = VB6.Format(CDec(TEGMonto.Text), "###,###.00")
        End If
    End Sub

    Private Sub TEGNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TEGNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TEGFecha.Focus()
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

    Private Sub EGForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TEGFecha.Value, ncod)
        TEGNumero.Text = ncod
    End Sub
End Class