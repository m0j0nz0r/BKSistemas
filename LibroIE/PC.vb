Option Strict Off
Option Explicit On
Friend Class PC
    Inherits System.Windows.Forms.Form

    Public Sub RecalcularFiadores(NoCredito As Double, bCOR As Integer)
        Dim fiadores As New DataView
        Dim credito As MainDS.TblCreditoRow = MainDSO.Tables("TblCredito").Rows.Find({ThisBanko("CodBK"), NoCredito})
        Dim cont As Double = 0
        fiadores.Table = MainDSO.Tables("TblFiadores")
        fiadores.RowFilter = "NoCredito='" & NoCredito & "'"
        fiador1 = CStr(0)
        fiador2 = CStr(0)
        Dim CapFiadores As Double = System.Math.Round((credito("Saldo") * ThisBanko("GarantiaFiador")) / (100 * ThisBanko("Val_nominal")), 0)
        For Each r As DataRowView In fiadores
            cont = r("CapsGarantia") + CONNUEVO.CalcCapsDisp(r("CI")) 'Disponibles para este credito
            If (CapFiadores < 1) Then
                If ((bCOR = 1) And (CDbl(fiador1) = 0)) Then
                    fiador1 = r("CI")
                Else
                    If ((bCOR = 1) And (CDbl(fiador2) = 0) And (CDbl(fiador1) <> 0)) Then
                        fiador2 = r("CI")
                    End If
                End If
                'r.Delete()
                r("CapsGarantia") = 0
                r("porcentajegarantizado") = 0
                cont = 0
            Else
                If (cont >= CapFiadores) Then 'si necesarios <= disponibles entonces garantizados = necesarios
                    r("CapsGarantia") = CapFiadores
                Else
                    r("CapsGarantia") = cont
                End If
                r("porcentajegarantizado") = System.Math.Round(((r("CapsGarantia") * ThisBanko("Val_nominal")) * 100) / credito("Saldo"), 2)
            End If
            CapFiadores = CapFiadores - r("CapsGarantia")
            'Redefinir el risego del credito.
        Next

    End Sub
    Private Sub Command32_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command32.Click
        Dim codi2 As String
        Dim rstCred As DataRow
        Dim rstFiadores As New DataView
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim mesgestion As Date


        If (TPCNumero.Text <> "") And (TPCCredito.Text <> "") And (TPCMonto.Text <> "") Then

            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TPCFecha.Value) < Month(mesgestion)) And (Year(TPCFecha.Value) < Year(mesgestion))) Or ((Year(TPCFecha.Value) < Year(mesgestion))) Or ((Month(TPCFecha.Value) <= Month(mesgestion)) And (Year(TPCFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TPCFecha.Value, CDbl(TPCNumero.Text), "PC", existe)
                If (existe = 0) Then
                    If MainDSO.Tables("TblCredito").Rows.Contains({codi, TPCCredito.Text.Trim}) Then
                        rstCred = MainDSO.Tables("TblCredito").Rows.Find({codi, TPCCredito.Text.Trim})
                        If rstCred("IdOp") = 0 Then
                            If ((System.Math.Round(rstCred("Saldo"), 2) - CDbl(TPCMonto.Text)) < 0) Then
                                MsgBox("Error. El Monto de la cuota es MAYOR al saldo del Credito")
                            Else
                                With rstentrar
                                    codi2 = TPCCredito.Text
                                End With

                                'Se actualizan los datos en la tabla de creditos
                                If (((rstCred("Saldo")) - CDbl(TPCMonto.Text)) < 1) Then
                                    corsaldo = CDbl(TPCMonto.Text)
                                    rstCred("Saldo") = 0
                                    rstCred("Cancelado") = 1
                                    rstCred("FechaCancela") = SQLDate(TPCFecha.Value)
                                Else
                                    rstCred("Saldo") = rstCred("Saldo") - CDbl(TPCMonto.Text)
                                End If

                                'Actualizo la tabla de fiadores

                                RecalcularFiadores(TPCCredito.Text, COR)

                                Dim row As DataRow = MainDSO.Tables("TblLibroIE").NewRow

                                'Registra la Operacion en el Libro IE
                                row("IdBK") = codi
                                row("fecha") = SQLDate(TPCFecha.Value)
                                row("NoCredito") = codi2
                                row("NoRecibo") = TPCNumero.Text
                                row("CI") = Trim(Label87.Text)
                                row("codope") = "PC"
                                row("Descripcion") = "Pago de Cuotas"
                                row("Ingreso") = CDbl(TPCMonto.Text)
                                row("Egreso") = 0
                                row("Saldo") = ThisBanko("SaldoBk")
                                LibroAdd(row)

                                TPCNumero.Text = ""
                                TPCCredito.Text = ""
                                TPCMonto.Text = ""
                                Label85.Visible = False
                                Label86.Visible = False
                                Label87.Visible = False
                                Label88.Visible = False
                                Label89.Visible = False
                                fechas = Fcod(fechaU, ncod)
                                TPCNumero.Text = CStr(ncod)
                                TPCCredito.Items.Clear()

                                Dim credito As New DataView
                                credito.Table = MainDSO.Tables("TblCredito")
                                credito.RowFilter = "Saldo>0"
                                credito.Sort = "NoCredito"
                                For Each r As DataRowView In credito
                                    TPCCredito.Items.Add(r("NoCredito"))
                                Next
                            End If
                        Else
                            MsgBox("ERROR: Verique el Numero de Credito. NO EXISTE")
                        End If
                    Else
                        MsgBox("ERROR: Verique el Numero de Credito. NO EXISTE")
                    End If
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub Command33_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command33.Click
        Label85.Visible = False
        Label86.Visible = False
        Label87.Visible = False
        Label88.Visible = False
        Label89.Visible = False
        TPCCredito.Text = ""
        TPCMonto.Text = ""
        Me.Close()

    End Sub

    Private Sub TPCCredito_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TPCCredito.SelectedIndexChanged
        Dim rstnombre As DataRow
        Dim codigo As String
        codigo = codi
        Dim credito As New DataView
        credito.Table = MainDSO.Tables("TblCredito")
        credito.RowFilter = "IdOp=0 AND NoCredito='" + TPCCredito.Text.Trim + "'"
        If credito.Count > 0 Then
            rstnombre = MainDSO.Tables("TblSocios").Rows.Find(credito(0)("VCI"))
            Label85.Text = "Nombres: " + rstnombre("Nombres")
            Label88.Text = "Acciones: " & Str(rstnombre("cap"))
            Label89.Text = "Saldo: " & VB6.Format(credito(0)("Saldo"), "###,##0.00")
            Label87.Text = rstnombre("CI")
            Label85.Visible = True
            Label86.Visible = True
            Label87.Visible = True
            Label88.Visible = True
            Label89.Visible = True
            If (COR = 1) Then
                TPCMonto.Text = VB6.Format(credito(0)("Saldo"), "###,##0.00")
            End If
        Else
            Label85.Visible = False
            Label86.Visible = False
            Label87.Visible = False
            Label88.Visible = False
            Label89.Visible = False
        End If
    End Sub

    Private Sub TPCCredito_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TPCCredito.KeyPress
    End Sub

    Private Sub TPCMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TPCMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TPCMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TPCMonto.Leave
        If (TPCMonto.Text <> "") Then
            TPCMonto.Text = VB6.Format(CDec(TPCMonto.Text), "###,##0.00")
        End If
    End Sub

    Private Sub TPCNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TPCNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TPCFecha.Focus()
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

    Private Sub PC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TPCFecha.Value, ncod)
        TPCNumero.Text = ncod
        Dim v As New DataView
        v.Table = MainDSO.Tables("TblCredito")
        v.Sort = "NoCredito"
        v.RowFilter = "Saldo>0"
        With TPCCredito.Items
            .Clear()
            For Each r As DataRowView In v
                .Add(r("NoCredito"))
            Next
        End With
        TPCMonto.Enabled = (COR = 0)
    End Sub
End Class