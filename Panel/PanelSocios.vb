Option Strict Off
Option Explicit On
Friend Class PanelSocios
	Inherits System.Windows.Forms.Form
	Private Sub CCedulas_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CCedulas.SelectedIndexChanged
        Dim rstSoc As MainDS.TblSociosRow
        Dim rsttotalcap As Double
		Dim codigo As String
		Dim SocCedu As String
		codigo = codi
		SocCedu = CCedulas.Text
        CSocios.Text = ""
        rstSoc = MainDSO.Tables("TblSocios").Rows.Find(SocCedu)
        rsttotalcap = 0
        For Each r As DataRow In MainDSO.Tables("TblSocios").Rows
            rsttotalcap += CDbl(r("cap"))
        Next


        If (rstSoc("cap") > 0) Then
            PorcentajeCaps.Text = VB6.Format((rstSoc("cap") * 100) / rsttotalcap, "###,##0.00")
        End If

        If (Not rstSoc.IsNull("CI")) Then
            TCedula.Text = rstSoc("CI")
        End If
        If (Not rstSoc.IsNull("Nombres")) Then
            TNombre.Text = rstSoc("Nombres")
        End If
        If (Not rstSoc.IsNull("FNace")) Then
                TFNacimiento.Text = rstSoc("FNace")
        Else
            TFNacimiento.Text = ""
        End If
        If (Not rstSoc.IsNull("Telefono")) Then
            TTelefono.Text = rstSoc("Telefono")
        Else
            TTelefono.Text = ""
        End If
        If (Not rstSoc.IsNull("FIngreso")) Then
                TFIngreso.Text = rstSoc.FIngreso.ToString("dd/MM/yyyy")
        End If
        If (Not rstSoc.IsNull("FRetiro")) Then
                TFRetiro.Text = rstSoc.Fretiro.ToString("dd/MM/yyyy")
        Else
            TFRetiro.Text = ""
        End If
        If (rstSoc("cap") > 0) Then
            TNCaps.Text = rstSoc("cap")
        End If
        If (Not rstSoc.IsNull("Sexo")) Then
            If ((rstSoc("Sexo") = "F") Or (rstSoc("Sexo") = "f")) Then
                CSexo.Text = "Femenino"
            Else
                CSexo.Text = "Masculino"
            End If
        End If
        If (rstSoc("AcumMoras") = 1) Then
            Option1.Checked = True
            Option2.Checked = False
        Else
            Option2.Checked = True
            Option1.Checked = False
        End If

        If (Not rstSoc.IsNull("email")) Then
            TEmail.Text = rstSoc("email")
        Else
            TEmail.Text = ""
        End If
        If (Not rstSoc.IsNull("Profesion")) Then
            TOcupacion.Text = rstSoc("Profesion")
        Else
            TOcupacion.Text = ""
        End If
        If (rstSoc.IsNull("Estatus")) Then
            If (rstSoc("Estatus") = 1) Then
                TEstatus.Text = "Activo"
                Estatus.CheckState = System.Windows.Forms.CheckState.Checked
                Estatus.Enabled = False
            Else
                If (rstSoc("Estatus") = 2) Then
                    TEstatus.Text = "Retirado Voluntario"
                    Estatus.CheckState = System.Windows.Forms.CheckState.Unchecked
                    Estatus.Enabled = True
                Else
                    If (rstSoc("Estatus") = 3) Then
                        TEstatus.Text = "Retirado con Deuda"
                        Estatus.CheckState = System.Windows.Forms.CheckState.Unchecked
                        Estatus.Enabled = True
                    Else
                        TEstatus.Text = "Retirado Deuda Pagada"
                        Estatus.CheckState = System.Windows.Forms.CheckState.Unchecked
                        Estatus.Enabled = True
                    End If
                End If
            End If
        End If
        If (rstSoc("Deuda") > 0) Then
            TDeuda.Text = VB6.Format(rstSoc("Deuda"), "###,##0.00")
        Else
            TDeuda.Text = ""
        End If
        If (rstSoc("CapLiq") > 0) Then
            TLiquidados.Text = rstSoc("CapLiq")
        Else
            TLiquidados.Text = ""
        End If
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim RstSocio As DataRow
        Dim cedulavieja As String
        Dim codigo As String
        Dim cedu() As String
        Dim SocCedu As String
        If (Estatus.CheckState = 1) Then
            codigo = codi
            If ((TNombre.Text <> "") Or (TFNacimiento.Text <> "")) Then
                If (CCedulas.Text <> "") Then
                    SocCedu = CCedulas.Text
                Else
                    cedu = Split(CSocios.Text, " ")
                    SocCedu = cedu(0)
                End If
                RstSocio = MainDSO.Tables("TblSocios").Rows.Find(SocCedu)
                If (TNombre.Text <> "") Then
                    RstSocio("Nombres") = TNombre.Text
                End If
                If (TFNacimiento.Text <> "") Then
                    RstSocio("FNace") = TFNacimiento.Text
                End If
                If (TTelefono.Text <> "") Then
                    RstSocio("Telefono") = TTelefono.Text
                End If
                If CSexo.Text = "Femenino" Then
                    RstSocio("Sexo") = "F"
                Else
                    RstSocio("Sexo") = "M"
                End If
                If (TOcupacion.Text <> "") Then
                    RstSocio("Profesion") = TOcupacion.Text
                End If
                If Option1.Checked = True Then
                    RstSocio("AcumMoras") = 1
                Else
                    RstSocio("AcumMoras") = 0
                End If
                If (TEmail.Text <> "") Then
                    RstSocio("email") = TEmail.Text
                End If
                cedulavieja = RstSocio("CI")
                If (RstSocio("CI") <> TCedula.Text) Then

                    'Se Actuliza la CI en la Tabla de Socios
                    RstSocio("CI") = TCedula.Text

                    'Se Actualiza la CI en el Libro IE
                    Dim libro As New DataView
                    libro.Table = MainDSO.Tables("TblLibroIE")
                    libro.RowFilter = "CI='" + cedulavieja + "'"
                    For Each r As DataRowView In libro
                        r("CI") = TCedula.Text
                    Next

                    libro.Table = MainDSO.Tables("TblCredito")
                    libro.RowFilter = "VCI='" + cedulavieja + "'"

                    For Each r As DataRowView In libro
                        r("VCI") = TCedula.Text
                    Next

                    libro.Table = MainDSO.Tables("TblFiadores")
                    libro.RowFilter = "CI='" + cedulavieja + "'"

                    For Each r As DataRowView In libro
                        r("CI") = TCedula.Text
                    Next

                    libro.Table = MainDSO.Tables("TblBenef")
                    libro.RowFilter = "VinSocio='" + cedulavieja + "'"

                    For Each r As DataRowView In libro
                        r("VinSocio") = TCedula.Text
                    Next

                End If
                MsgBox("REGISTRO ACTUALIZADO")
            End If
        Else
            MsgBox("Error: No puede Actualizar los datos por que el socio NO ESTA ACTIVO")
        End If
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnMovimientos.Click
        Dim rpt As New RptMovi
        If CCedulas.Text <> "" Then
            rpt.SocCedu = CCedulas.Text
            rpt.ShowDialog()
        ElseIf CSocios.Text <> "" Then
            Dim cedu() As String
            cedu = Split(CSocios.Text, " | ")
            rpt.SocCedu = cedu(0)
            For Each i As String In cedu
                Debug.WriteLine(i)
            Next
            rpt.ShowDialog()
        Else
            MsgBox("Debe seleccionar un Socio de la Lista para visualizar sus Movimientos")
        End If
    End Sub

    Private Sub CSocios_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CSocios.SelectedIndexChanged
        Dim rstSoc As MainDS.TblSociosRow
        Dim rsttotalcap As Integer
        Dim codigo As String
        Dim cedu() As String
        Dim SocCedu As String
        codigo = codi
        cedu = Split(CSocios.Text, " ")
        SocCedu = cedu(0)
        CCedulas.Text = ""
        rstSoc = MainDSO.Tables("TblSocios").Rows.Find(SocCedu)
        rsttotalcap = 0
        For Each r As DataRow In MainDSO.Tables("TblSocios").Rows
            rsttotalcap += CInt(r("cap"))
        Next


        If (rstSoc("cap") > 0) Then
                PorcentajeCaps.Text = VB6.Format((rstSoc("cap") * 100) / rsttotalcap, "###,##0.00")
        End If

        If (Not rstSoc.IsNull("CI")) Then
            TCedula.Text = rstSoc("CI")
        End If
        If (Not rstSoc.IsNull("Nombres")) Then
            TNombre.Text = rstSoc("Nombres")
        End If
        If (Not rstSoc.IsNull("FNace")) Then
            TFNacimiento.Text = CDate(rstSoc("FNace")).ToString("dd-MM-yyyy")
        Else
            TFNacimiento.Text = ""
        End If
        If (Not rstSoc.IsNull("Telefono")) Then
            TTelefono.Text = rstSoc("Telefono")
        Else
            TTelefono.Text = ""
        End If
        If (Not rstSoc.IsNull("FIngreso")) Then
            TFIngreso.Text = rstSoc.FIngreso.ToString("dd/MM/yyyy")
        End If
        If (Not rstSoc.IsNull("FRetiro")) Then
            TFRetiro.Text = rstSoc.Fretiro.ToString("dd/MM/yyyy")
        Else
            TFRetiro.Text = ""
        End If
        If (rstSoc("cap") > 0) Then
            TNCaps.Text = rstSoc("cap")
        End If
        If (Not rstSoc.IsNull("Sexo")) Then
            If ((rstSoc("Sexo") = "F") Or (rstSoc("Sexo") = "f")) Then
                CSexo.Text = "Femenino"
            Else
                CSexo.Text = "Masculino"
            End If
        End If
        If (Not rstSoc.IsNull("email")) Then
            TEmail.Text = rstSoc("email")
        Else
            TEmail.Text = ""
        End If

        If (rstSoc("AcumMoras") = 1) Then
            Option1.Checked = True
            Option2.Checked = False
        Else
            Option2.Checked = True
            Option1.Checked = False
        End If


        If (Not rstSoc.IsNull("Profesion")) Then
            TOcupacion.Text = rstSoc("Profesion")
        Else
            TOcupacion.Text = ""
        End If
        If (Not rstSoc.IsNull("Estatus")) Then
            If (rstSoc("Estatus") = 1) Then
                TEstatus.Text = "Activo"
                Estatus.CheckState = System.Windows.Forms.CheckState.Checked
                Estatus.Enabled = False
            Else
                If (rstSoc("Estatus") = 2) Then
                    TEstatus.Text = "Retirado Voluntario"
                    Estatus.CheckState = System.Windows.Forms.CheckState.Unchecked
                    Estatus.Enabled = True
                Else
                    If (rstSoc("Estatus") = 3) Then
                        TEstatus.Text = "Retirado con Deuda"
                        Estatus.CheckState = System.Windows.Forms.CheckState.Unchecked
                        Estatus.Enabled = True
                    Else
                        TEstatus.Text = "Ret. Deuda Pagada"
                        Estatus.CheckState = System.Windows.Forms.CheckState.Unchecked
                        Estatus.Enabled = True
                    End If
                End If
            End If
        End If
        If (rstSoc("Deuda") > 0) Then
            TDeuda.Text = VB6.Format(rstSoc("Deuda"), "###,##0.00")
        Else
            TDeuda.Text = ""
        End If
        If (rstSoc("CapLiq") > 0) Then
            TLiquidados.Text = rstSoc("CapLiq")
        Else
            TLiquidados.Text = ""
        End If
    End Sub

    Private Sub CSocios_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles CSocios.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            CCedulas.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Estatus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Estatus.CheckStateChanged
        Dim resp As Object
        Dim RstSocioAct As DataRow
        Dim codigo As String
        Dim cedu() As String
        Dim SocCedu As String
        If (TEstatus.Text <> "Activo") Then
            If (Estatus.Enabled = True) Then
                If (Estatus.CheckState = 1) Then
                    codigo = codi
                    If (CSocios.Text <> "") Then
                        cedu = Split(CSocios.Text, " ")
                        SocCedu = cedu(0)
                    Else
                        SocCedu = CCedulas.Text
                    End If
                    If TDeuda.Text = "" Then
                        TDeuda.Text = CStr(0)
                    End If
                    If (CDbl(TDeuda.Text) > 0) Then
                        resp = MsgBox("IMPORTANTE" & vbCrLf & "Desea Activar un Socio con Deuda", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema")
                        If (resp = 6) Then
                            RstSocioAct = MainDSO.Tables("TblSocios").Rows.Find(SocCedu)
                            RstSocioAct("Estatus") = 1
                            RstSocioAct("FIngreso") = System.DBNull.Value
                            RstSocioAct("FRetiro") = System.DBNull.Value
                            TEstatus.Text = "Activo"
                            TFIngreso.Text = ""
                            TFRetiro.Text = ""
                            Estatus.Enabled = False
                            MsgBox("Socio Activado. Recuerde que tiene que Venderle Certificados")
                        Else
                            Estatus.CheckState = System.Windows.Forms.CheckState.Unchecked
                        End If
                    Else
                        resp = MsgBox("IMPORTANTE" & vbCrLf & "Desea Activar el Socio", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema")
                        If (resp = 6) Then
                            RstSocioAct = MainDSO.Tables("TblSocios").Rows.Find(SocCedu)
                            RstSocioAct("Estatus") = 1
                            RstSocioAct("FIngreso") = System.DBNull.Value
                            RstSocioAct("FRetiro") = System.DBNull.Value
                            TEstatus.Text = "Activo"
                            TFIngreso.Text = ""
                            TFRetiro.Text = ""
                            Estatus.Enabled = False
                            MsgBox("Socio Activado. Recuerde que tiene que Venderle Certificados")
                        Else
                            Estatus.CheckState = System.Windows.Forms.CheckState.Unchecked
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PanelSocios_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If My.Settings.DynamicPermits Then
            BtnMovimientos.Enabled = (FindPermit(tuser, "PanelSociosSociosMovimientos") = "1")
        End If
        Dim rstSoc As New DataView
        rstSoc.Table = MainDSO.Tables("TblSocios")
        rstSoc.Sort = "Nombres"
        Dim codigo As String
        codigo = codi
        For Each r As DataRowView In rstSoc
            CSocios.Items.Add(r("CI") + " | " + r("Nombres"))
        Next

        Estatus.Enabled = False
        rstSoc.Sort = "CI"
        For Each r As DataRowView In rstSoc
            CCedulas.Items.Add(r("CI"))
        Next
        Estatus.Enabled = False
    End Sub
End Class