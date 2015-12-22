Option Strict Off
Option Explicit On
Friend Class GBK
    Inherits System.Windows.Forms.Form
    Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command12.Click
        TGBKNumero.Text = ""
        TGBKMonto.Text = ""
        Me.Close()
    End Sub

    Private Sub Command13_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command13.Click
        Dim SFG As Double
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim numerogbk As Double
        Dim mesgestion As Date
        Dim row As MainDS.TblLibroIERow = MainDSO.Tables("TblLibroIE").NewRow
        If (TGBKNumero.Text <> "") And (TGBKMonto.Text <> "") Then
            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TGBKFecha.Value) < Month(mesgestion)) And (Year(TGBKFecha.Value) < Year(mesgestion))) Or ((Year(TGBKFecha.Value) < Year(mesgestion))) Or ((Month(TGBKFecha.Value) <= Month(mesgestion)) And (Year(TGBKFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TGBKFecha.Value, CDbl(TGBKNumero.Text), "GBK1", existe)
                If (existe = 0) Then
                    numerogbk = CDbl(TGBKNumero.Text)

                    row("IdBK") = codi
                    row("fecha") = SQLDate(TGBKFecha.Value)
                    row("NoCredito") = 0
                    row("NoRecibo") = numerogbk
                    row("CI") = "----------"
                    row("Ingreso") = 0
                    row("Saldo") = ThisBanko("SaldoBk")

                    SFG = ThisBanko("SAFGASTOS") - CDbl(TGBKMonto.Text)

                    If (SFG <= 0) Then
                        MsgBox("El Saldo no es suficiente para realizar el Egreso, se egresara del Fondo lo que hay en Saldo y el resto se hara por otros Egresos")
                        If (ThisBanko("SAFGASTOS") > 0) Then
                            row("codope") = "GBK1"
                            row("Descripcion") = "Gastos del Bankomunal (Egreso Fondo Gastos)"
                            row("Egreso") = ThisBanko("SAFGASTOS")

                            ThisBanko("SAFGASTOS") = 0

                            LibroAdd(row)

                            row = MainDSO.Tables("TblLibroIE").NewRow
                            row("IdBK") = codi
                            row("fecha") = SQLDate(TGBKFecha.Value)
                            row("NoCredito") = 0
                            row("NoRecibo") = numerogbk + 1
                            row("CI") = "----------"
                            row("Ingreso") = 0
                            row("Saldo") = ThisBanko("SaldoBk")
                        End If

                        row("codope") = "EG"
                        row("Descripcion") = "Otros Egresos (Gastos Fondo Gastos)"
                        row("Egreso") = ((CDbl(TGBKMonto.Text)) - ThisBanko("SAFGASTOS"))
                    Else
                        row("codope") = "GBK1"
                        row("Descripcion") = "Gastos del Bankomunal (Egreso Fondo Gastos)"
                        row("Egreso") = CDbl(TGBKMonto.Text)
                        ThisBanko("SAFGASTOS") = SFG
                    End If
                    TGBKNumero.Text = ""
                    TGBKMonto.Text = ""
                    fechas = Fcod(fechaU, ncod)
                    TGBKNumero.Text = CStr(ncod)
                    Label2.Text = "Total: " & VB6.Format(ThisBanko("SAFGASTOS"), "###,##0.00")
                    LibroAdd(row)

                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If
    End Sub

    Private Sub GBK_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Total: " & VB6.Format(ThisBanko("SAFGASTOS"), "###,##0.00")
        Fcod(TGBKFecha.Value, ncod)
        TGBKNumero.Text = ncod
    End Sub

    Private Sub TGBKMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TGBKMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            Command13.Focus()
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

    Private Sub TGBKMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TGBKMonto.Leave
        If (TGBKMonto.Text <> "") Then
            TGBKMonto.Text = VB6.Format(CDec(TGBKMonto.Text), "###,###.00")
        End If

    End Sub

    Private Sub TGBKNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TGBKNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TGBKFecha.Focus()
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