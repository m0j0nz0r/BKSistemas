Option Strict Off
Option Explicit On
Friend Class PanelCredito
    Inherits System.Windows.Forms.Form

    Private Sub FillFormData(NoCredito As Double)
        Dim SocCedrid As Double
        Dim fmt As String
        Dim rstCre2 As DataTable
        Dim cedfiador1 As String = ""
        Dim cedfiador2 As String
        SocCedrid = NoCredito
        Dim libro As New DataView
        libro.Table = MainDSO.Tables("TblLibroIE")
        libro.RowFilter = "NoCredito='" & SocCedrid & "' and Anulado=0"
        libro.Sort = "Fecha,NoRecibo,IdReg"
        Dim fiadores As New DataView
        fiadores.Table = MainDSO.Tables("TblFiadores")
        fiadores.RowFilter = "CapsGarantia>0 AND NoCredito=" & SocCedrid
        Dim socios As New DataView
        socios.Table = MainDSO.Tables("TblSocios")

        If fiadores.Count > 0 Then
            cedfiador1 = fiadores(0)("CI")

            'busca registro de fiador 1 en tabla de socios
            socios.RowFilter = "Estatus=1 AND CI=" & cedfiador1

            If socios.Count > 0 Then
                Dim CapsGarantia As Double = 0
                Dim CapsDisponibles As Double = 0
                CapsDisponibles = CONNUEVO.CalcCapsDisp(cedfiador1)
                CapsGarantia = CONNUEVO.CapsGarantia(cedfiador1)
                Label9.Text = "Nombre: " + socios(0)("Nombres")
                Label10.Text = "Cedula: " + socios(0)("CI")
                Label11.Text = "Accion.garantia: " & Math.Round(CapsGarantia, 0)
                Label20.Text = "Accion.Disponibles: " & Math.Round(CapsDisponibles, 0)
                If Not fiadores(0).Row.IsNull("porcentajegarantizado") Then
                    Label16.Text = "% Garantia: " & Math.Round(fiadores(0)("porcentajegarantizado"), 0)
                Else
                    Label16.Text = "% Garantia: "
                End If
                Label9.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                Label16.Visible = True
                Label20.Visible = True
                If fiadores.Count > 1 Then
                    cedfiador2 = fiadores(1)("CI")
                    socios.RowFilter = "Estatus=1 AND CI=" & cedfiador2
                    If socios.Count > 0 Then
                        Label12.Text = "Nombre: " + socios(0)("Nombres")
                        Label13.Text = "Cedula: " & Str(fiadores(1)("CI"))
                        Label15.Text = "Accion.garantia: " & Math.Round(fiadores(1)("CapsGarantia"), 0)


                        CapsGarantia = CONNUEVO.CapsGarantia(cedfiador2)

                        Label21.Text = "Accion.Disponibles: " & Math.Round(CONNUEVO.CalcCapsDisp(cedfiador2), 0)

                        If (Not fiadores(1).Row.IsNull("porcentajegarantizado")) Then
                            Label17.Text = "% Garantia: " & Math.Round(fiadores(1)("porcentajegarantizado"), 0)
                        Else
                            Label17.Text = "% Garantia: "
                        End If
                        Label12.Visible = True
                        Label13.Visible = True
                        Label15.Visible = True
                        Label17.Visible = True
                        Label21.Visible = True
                    Else
                        Label12.Visible = False
                        Label13.Visible = False
                        Label15.Visible = False
                        Label17.Visible = False
                        Label21.Visible = False
                    End If
                End If
            Else
                Label9.Visible = False
                Label10.Visible = False
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label15.Visible = False
                Label16.Visible = False
                Label17.Visible = False
                Label20.Visible = False
                Label21.Visible = False
            End If
        End If

        Dim credito As New DataView
        credito.Table = MainDSO.Tables("TblCredito")
        credito.RowFilter = "IdOp=0 AND NoCredito='" & SocCedrid.ToString & "'"
        Socios.RowFilter = "CI='" & credito(0)("VCI").ToString & "'"
        TCedula.Text = Socios(0)("CI").ToString
        TNombre.Text = Socios(0)("Nombres").ToString
        TMonto.Text = VB6.Format(CDec(credito(0)("MontoCred").ToString), "###,##0.00")
        TSaldo.Text = VB6.Format(CDec(credito(0)("Saldo").ToString), "###,##0.00")
        If Not credito(0).Row.IsNull("Riezgo") Then
            TClase.Text = credito(0)("Riezgo").ToString
        Else
            TClase.Text = ""
        End If
        If Not credito(0).Row.IsNull("FechaVence") Then
            TVencimiento.Text = CDate(credito(0)("FechaVence")).ToString("dd/MM/yyyy")
        End If
        If Not credito(0).Row.IsNull("TasaIO") Then
            TIntOrd.Text = credito(0)("TasaIO").ToString
        Else
            TIntOrd.Text = ""
        End If
        If Not credito(0).Row.IsNull("TasaMO") Then
            TIntMora.Text = credito(0)("TasaMO").ToString
        Else
            TIntMora.Text = ""
        End If

        'Se Muestran los Movimientos de ese Credito Seleccionado
        'rstCre2=.Open("SELECT Fecha, NoRecibo, CodOpe, Ingreso, Egreso FROM TblLibroIE WHERE IdBK = '" & codigo & "' AND NoCredito = " & SocCedrid & " ORDER BY Fecha,NoRecibo,IdReg")
        rstCre2 = New DataTable("TblLibroIE")
        rstCre2.Columns.Add("Fecha")
        rstCre2.Columns.Add("NoRecibo")
        rstCre2.Columns.Add("CodOpe")
        rstCre2.Columns.Add("Ingreso")
        rstCre2.Columns.Add("Egreso")

        For Each r As DataRowView In libro
            rstCre2.Rows.Add(r("Fecha"), r("NoRecibo"), r("CodOpe"), r("Ingreso"), r("Egreso"))
        Next

        DataGrid1.DataSource = rstCre2
        fmt = "###,##0.00"
        DataGrid1.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)
        DataGrid1.Columns(0).Width = VB6.TwipsToPixelsX(1000)
        DataGrid1.Columns(1).Width = VB6.TwipsToPixelsX(1200)
        DataGrid1.Columns(2).Width = VB6.TwipsToPixelsX(1200)
        DataGrid1.Columns(3).Width = VB6.TwipsToPixelsX(1300)
        DataGrid1.Columns(4).Width = VB6.TwipsToPixelsX(1300)
        DataGrid1.Columns(3).DefaultCellStyle.Format = fmt
        DataGrid1.Columns(4).DefaultCellStyle.Format = fmt
        DataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGrid1.Columns(0).HeaderText = "Fecha"
        DataGrid1.Columns(1).HeaderText = "No Op."
        DataGrid1.Columns(2).HeaderText = "Cod. Op"
        DataGrid1.Columns(3).HeaderText = "Ingreso"
        DataGrid1.Columns(4).HeaderText = "Egreso"
        DataGrid1.ColumnHeadersDefaultCellStyle.Font = New Font(DataGrid1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 11, FontStyle.Bold)

    End Sub

    Private Sub CCedula_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CCedula.SelectedIndexChanged
        Dim codigo As String
        Dim SocCedrid As Double
        CCredito.Text = ""
        codigo = codi
        SocCedrid = CDbl(CCedula.Text)

        Dim credito As New DataView
        credito.Table = MainDSO.Tables("TblCredito")
        credito.RowFilter = "IdOp=0 AND VCI = '" & SocCedrid & "'"
        If status.CheckState = 0 Then
            credito.RowFilter += " AND Saldo>0"
        End If
        SocCedrid = credito(0)("NoCredito")
        FillFormData(SocCedrid)

    End Sub

    Private Sub CCedula_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles CCedula.KeyPress
    End Sub

    Private Sub CCredito_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CCredito.SelectedIndexChanged
        Dim codigo As String
        Dim Cred() As String
        Dim SocCedrid As String
        CCedula.Text = ""
        codigo = codi
        Cred = Split(CCredito.Text, " ")
        SocCedrid = Cred(0)
        FillFormData(SocCedrid)

    End Sub

    Private Sub Check1_Click()

    End Sub

    Private Sub CCredito_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles CCredito.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Combo1_Change()

    End Sub

    Private Sub Combo1_Click()
        Dim codigo As String
        Dim Cred() As String
        Dim SocCedrid As String
        codigo = codi
        Cred = Split(CCredito.Text, " ")
        SocCedrid = Cred(1)
        FillFormData(SocCedrid)
    End Sub

    Private Sub Combo1_KeyPress(ByRef KeyAscii As Short)
        Dim codigo As String
        Dim Cred() As String
        Dim SocCedrid As String
        codigo = codi
        Cred = Split(CCredito.Text, " ")
        SocCedrid = Cred(1)
        FillFormData(SocCedrid)
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Me.Close()
    End Sub
    Private Sub FillComboBoxes(paid As Boolean)
        CCredito.Items.Clear()
        CCedula.Items.Clear()
        TNombre.Text = ""
        TCedula.Text = ""
        TMonto.Text = ""
        TVencimiento.Text = ""
        TClase.Text = ""
        TSaldo.Text = ""
        TIntOrd.Text = ""
        TIntMora.Text = ""
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label20.Visible = False
        Label21.Visible = False

        Dim codigo As String
        Dim credito As New DataView
        Dim socios As New DataView
        credito.Table = MainDSO.Tables("TblCredito")
        credito.Sort = "NoCredito"
        Dim filter As String = "IdOp=0 AND " & IIf(paid, "Saldo=0", "Saldo>0")
        credito.RowFilter = filter
        socios.Table = MainDSO.Tables("TblSocios")
        Dim table As DataTable = socios.ToTable()
        table.PrimaryKey = {table.Columns("CI")}
        codigo = codi
        For Each r As DataRowView In credito
            If table.Rows.Contains(r("VCI")) Then
                Dim s As DataRow = table.Rows.Find(r("VCI"))
                CCredito.Items.Add(r("NoCredito").ToString + " | " + s("Nombres").ToString)
                CCedula.Items.Add(s("CI").ToString)
            End If
        Next
    End Sub
    Private Sub PanelCredito_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        FillComboBoxes(False)
    End Sub

    Private Sub status_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles status.CheckStateChanged
        FillComboBoxes(status.Checked)
    End Sub
End Class