Option Strict Off
Option Explicit On
Friend Class DON
    Inherits System.Windows.Forms.Form
    Private Sub Command16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command16.Click
        TDONNumero.Text = ""
        TDONMonto.Text = ""
        Me.Close()
    End Sub

    Private Sub Command17_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command17.Click
        Dim primrafecha As Date
        Dim ultimafecha As Date
        Dim primerafecha As Date
        Dim existe As Short
        Dim existe2 As Short
        Dim mesgestion As Date

        If (TDONNumero.Text <> "") And (TDONMonto.Text <> "") Then
            primerafecha = fechaLIE(primrafecha, ultimafecha, mesgestion)
            If ((Month(DONFecha.Value) < Month(mesgestion)) And (Year(DONFecha.Value) < Year(mesgestion))) Or ((Year(DONFecha.Value) < Year(mesgestion))) Or ((Month(DONFecha.Value) <= Month(mesgestion)) And (Year(DONFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(DONFecha.Value, CDbl(TDONNumero.Text), "DO1", existe)
                If (existe = 0) Then
                    'Registra la Operacion en el Libro IE
                    rstentrar = MainDSO.Tables("TblLibroIE").NewRow
                    rstentrar("IdBK") = codi
                    rstentrar("fecha") = SQLDate(DONFecha.Value)
                    rstentrar("NoCredito") = 0
                    rstentrar("NoRecibo") = TDONNumero.Text
                    rstentrar("CI") = "----------"
                    rstentrar("codope") = "IFG1"
                    rstentrar("Descripcion") = "Donacion en Efectivo"
                    rstentrar("Ingreso") = CDbl(TDONMonto.Text)
                    rstentrar("Egreso") = 0
                    rstentrar("Saldo") = ThisBanko("SaldoBk")
                    LibroAdd(rstentrar)
                    fechas = Fcod(fechaU, ncod)
                    TDONNumero.Text = CStr(ncod)
                    TDONMonto.Text = ""
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub TDONMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TDONMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TDONMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TDONMonto.Leave
        If (TDONMonto.Text <> "") Then
            TDONMonto.Text = VB6.Format(CDec(TDONMonto.Text), "###,###.00")
        End If
    End Sub

    Private Sub TDONNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TDONNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            DONFecha.Focus()
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

    Private Sub DON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(DONFecha.Value, ncod)
        TDONNumero.Text = ncod
    End Sub
End Class