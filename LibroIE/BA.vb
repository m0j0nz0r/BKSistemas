Option Strict Off
Option Explicit On
Friend Class BA
    Inherits System.Windows.Forms.Form
    Private Sub Command18_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command18.Click
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim mesgestion As Date

        If ((TBANumero.Text <> "") And (TBATipo.Text <> "") And (TBAMonto.Text <> "")) Then
            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TBAFecha.Value) < Month(mesgestion)) And (Year(TBAFecha.Value) < Year(mesgestion))) Or ((Year(TBAFecha.Value) < Year(mesgestion))) Or ((Month(TBAFecha.Value) <= Month(mesgestion)) And (Year(TBAFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TBAFecha.Value, CDbl(TBANumero.Text), "BA", existe)

                If (existe = 0) Then
                    Dim row As DataRow = MainDSO.Tables("TblLibroIE").NewRow

                    If (TBATipo.Text = "1 Propio") Then
                        row("fecha") = SQLDate(TBAFecha.Value)

                        'Registra la Operacion en el Libro IE
                        row("IdBK") = codi
                        row("NoCredito") = 0
                        row("NoRecibo") = TBANumero.Text
                        row("CI") = "----------"
                        row("codope") = "BA"
                        row("Descripcion") = "Bien Adquirido Propio"
                        row("Ingreso") = 0
                        row("Egreso") = CDbl(TBAMonto.Text)
                        row("Saldo") = ThisBanko("SaldoBk")
                        LibroAdd(row)

                        'Registra la Contrapartida
                        row = MainDSO.Tables("TblLibroIE").NewRow
                        row("IdBK") = codi
                        row("fecha") = SQLDate(TBAFecha.Value)
                        row("NoCredito") = 0
                        row("NoRecibo") = TBANumero.Text
                        row("CI") = "----------"
                        row("codope") = "DO2"
                        row("Descripcion") = "Donacion en Equip."
                        row("Ingreso") = CDbl(TBAMonto.Text)
                        row("Egreso") = 0
                        row("Saldo") = ThisBanko("SaldoBk")
                        LibroAdd(row)
                    Else
                        'Registra la Operacion en el Libro IE
                        row("IdBK") = codi
                        row("fecha") = SQLDate(TBAFecha.Value)
                        row("NoCredito") = 0
                        row("NoRecibo") = TBANumero.Text
                        row("CI") = "----------"
                        row("codope") = "BA"
                        row("Descripcion") = "Bien Adquirido en Comodato"
                        row("Ingreso") = 0
                        row("Egreso") = CDbl(TBAMonto.Text)
                        row("Saldo") = ThisBanko("SaldoBk")
                        LibroAdd(row)
                        'Se registra la contrapartida
                        row = MainDSO.Tables("TblLibroIE").NewRow
                        row("IdBK") = codi
                        row("fecha") = SQLDate(TBAFecha.Value)
                        row("NoCredito") = 0
                        row("NoRecibo") = CDbl(TBANumero.Text)
                        row("CI") = "----------"
                        row("codope") = "ICP"
                        row("Descripcion") = "Ingreso a Cuentar x Pagar"
                        row("Ingreso") = CDbl(TBAMonto.Text)
                        row("Egreso") = 0
                        row("Saldo") = ThisBanko("SaldoBk")
                        LibroAdd(row)

                    End If
                        TBATipo.Text = ""
                        TBAMonto.Text = ""
                        fechas = Fcod(fechaU, ncod)
                        TBANumero.Text = CStr(ncod)
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los datos")
        End If

    End Sub

    Private Sub Command19_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command19.Click
        TBANumero.Text = ""
        TBATipo.Text = ""
        TBAMonto.Text = ""
        Me.Close()
        'BA.Visible = False
        'CCertificados.Text = ""
        'CCreditos.Text = ""
        'COtrosIE.Text = ""
        'FondoGastos.Text = ""
        'COtrasOp.Text = ""

    End Sub

    Private Sub TBAMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TBAMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            Command18.Focus()
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

    Private Sub TBAMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TBAMonto.Leave
        If (TBAMonto.Text <> "") Then
            TBAMonto.Text = VB6.Format(CDec(TBAMonto.Text), "###,###.00")
        End If
    End Sub

    Private Sub TBANumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TBANumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TBAFecha.Focus()
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

    Private Sub TBATipo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TBATipo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TBAMonto.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub BA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TBAFecha.Value, ncod)
        TBANumero.Text = ncod
    End Sub
End Class