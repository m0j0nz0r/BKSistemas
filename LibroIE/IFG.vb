Option Strict Off
Option Explicit On
Friend Class IFG
    Inherits System.Windows.Forms.Form
    Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click
        TIFGNumero.Text = ""
        TIFGMonto.Text = ""
        Me.Close()
    End Sub

    Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command11.Click
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim TIFGFechita As Date
        Dim mesgestion As Date

        If (TIFGNumero.Text <> "") And (TIFGMonto.Text <> "") Then
            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TIFGFecha.Value) < Month(mesgestion)) And (Year(TIFGFecha.Value) < Year(mesgestion))) Or ((Year(TIFGFecha.Value) < Year(mesgestion))) Or ((Month(TIFGFecha.Value) <= Month(mesgestion)) And (Year(TIFGFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                TIFGFechita = TIFGFecha.Value
                existe2 = BuscaLibro(TIFGFechita, CDbl(TIFGNumero.Text), "IFG", existe)
                If (existe = 0) Then
                    rstentrar = MainDSO.Tables("TblLibroIE").NewRow
                    'Se actualiza el Saldo en la tabla de Bankos
                    ThisBanko("SAFGASTOS") = ThisBanko("SAFGASTOS") + CDbl(TIFGMonto.Text)
                    Label2.Text = "Total: " & VB6.Format(ThisBanko("SAFGASTOS"), "###,##0.00")
                    'Registra la Operacion en el Libro IE
                    rstentrar("IdBK") = codi
                    rstentrar("fecha") = SQLDate(TIFGFecha.Value)
                    rstentrar("NoCredito") = 0
                    rstentrar("NoRecibo") = TIFGNumero.Text
                    rstentrar("CI") = "----------"
                    rstentrar("codope") = "IFG1"
                    rstentrar("Descripcion") = "Ingresos al Fondo de Gastos"
                    rstentrar("Ingreso") = CDbl(TIFGMonto.Text)
                    rstentrar("Egreso") = 0
                    rstentrar("Saldo") = ThisBanko("SaldoBk")
                    LibroAdd(rstentrar)
                    TIFGNumero.Text = ""
                    TIFGMonto.Text = ""
                    fechas = Fcod(fechaU, ncod)
                    TIFGNumero.Text = CStr(ncod)
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub IFG_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Total: " & VB6.Format(ThisBanko("SAFGASTOS"), "###,##0.00")
        Fcod(TIFGFecha.Value, ncod)
        TIFGNumero.Text = ncod
    End Sub

    Private Sub TIFGMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TIFGMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            Command11.Focus()
        Else
            If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TIFGMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TIFGMonto.Leave
        If (TIFGMonto.Text <> "") Then
            TIFGMonto.Text = VB6.Format(CDec(TIFGMonto.Text), "###,##0.00")
        End If
    End Sub

    Private Sub TIFGNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TIFGNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TIFGFecha.Focus()
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
End Class