Option Strict Off
Option Explicit On
Friend Class PanelBeneficiario
    Inherits System.Windows.Forms.Form
    Dim SocCedrid As String
    Dim benef As Short

    Private Sub CCedulas_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CCedulas.SelectedIndexChanged
        Dim rstSoc As MainDS.TblSociosRow
        Dim rstBenef As DataRow
        Dim codigo As String
        Socios.Text = ""
        SocCedrid = CCedulas.Text
        codigo = codi


        rstSoc = MainDSO.Tables("TblSocios").Rows.Find(SocCedrid)

        TCedula.Text = rstSoc("CI")
        TNombre.Text = rstSoc("Nombres")
        TCAPS.Text = rstSoc("cap")
        If (Not rstSoc.IsNull("CapLiq")) Then
            TCAPSL.Text = rstSoc("CapLiq")
        End If
        If (Not rstSoc.IsNull("FIngreso")) Then
            TFecha.Text = rstSoc.FIngreso.ToString("dd/MM/yyyy")
        End If
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblBenef")
        view.RowFilter = "VinSocio='" + SocCedrid + "'"
        If view.Count > 0 Then
            rstBenef = view(0).Row
            TB1Nombres.Text = rstBenef("NombresB")
            TB1Cedula.Text = rstBenef("CIB")
            If (rstBenef("Oficio") <> "") Then
                TB1Oficio.Text = rstBenef("Oficio")
            End If
            TB1FechaNace.Value = rstBenef("FechaNace")
            If (rstBenef("Direccion") <> "") Then
                TB1Direccion.Text = rstBenef("Direccion")
            End If
            If (rstBenef("Parentesco") <> "") Then
                TB1Parentesco.Text = rstBenef("Parentesco")
            End If
            TB1Sexo.Text = rstBenef("Sexo")
            benef = 2
            Modif1.CheckState = False
            Elim1.CheckState = False
            Modif1.Enabled = True
            Elim1.Enabled = True
            If view.Count > 1 Then
                rstBenef = view(1).Row
                TB2Nombres.Text = rstBenef("NombresB")
                TB2Cedula.Text = rstBenef("CIB")
                If (rstBenef("Oficio") <> "") Then
                    TB2Oficio.Text = rstBenef("Oficio")
                End If

                TB2FechaNace.Value = rstBenef("FechaNace")
                If (rstBenef("Direccion") <> "") Then
                    TB2Direccion.Text = rstBenef("Direccion")
                End If
                If (rstBenef("Parentesco") <> "") Then
                    TB2Parentesco.Text = rstBenef("Parentesco")
                End If
                TB2Sexo.Text = rstBenef("Sexo")
                benef = 0
                Modif2.CheckState = False
                Elim2.CheckState = False
                Modif2.Enabled = True
                Elim2.Enabled = True
            Else
                TB2Nombres.Text = ""
                TB2Cedula.Text = ""
                TB2Oficio.Text = ""
                TB2Direccion.Text = ""
                TB2Sexo.Text = ""
                TB2Parentesco.Text = ""
                TB2Nombres.Enabled = False
                TB2Cedula.Enabled = False
                TB2Oficio.Enabled = False
                TB2Direccion.Enabled = False
                TB2Sexo.Enabled = False
                TB2Parentesco.Enabled = False
                TB2FechaNace.Enabled = False
                BtnGuardar.Enabled = False
                Modif2.CheckState = False
                Elim2.CheckState = False
                Modif2.Enabled = False
                Elim2.Enabled = False
                TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            End If
        Else
            TB1Nombres.Text = ""
            TB1Cedula.Text = ""
            TB1Oficio.Text = ""
            TB1Direccion.Text = ""
            TB1Sexo.Text = ""
            TB1Parentesco.Text = ""
            TB2Nombres.Text = ""
            TB2Cedula.Text = ""
            TB2Oficio.Text = ""
            TB2Direccion.Text = ""
            TB2Sexo.Text = ""
            TB2Parentesco.Text = ""
            benef = 1
            TB1Nombres.Enabled = False
            TB1Cedula.Enabled = False
            TB1Oficio.Enabled = False
            TB1Direccion.Enabled = False
            TB1Sexo.Enabled = False
            TB1Parentesco.Enabled = False
            TB1FechaNace.Enabled = False
            TB2Nombres.Enabled = False
            TB2Cedula.Enabled = False
            TB2Oficio.Enabled = False
            TB2Direccion.Enabled = False
            TB2Sexo.Enabled = False
            TB2Parentesco.Enabled = False
            TB2FechaNace.Enabled = False
            BtnGuardar.Enabled = False
            Modif2.CheckState = False
            Elim2.CheckState = False
            Modif2.Enabled = False
            Elim2.Enabled = False
            Modif1.CheckState = False
            Elim1.CheckState = False
            Modif1.Enabled = False
            Elim1.Enabled = False
            TB1Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            'TB1FechaNace.BackColor = &HC0C0C0
            TB1Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            'TB1FechaNace.BackColor = &HC0C0C0
            TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
        End If

    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnNuevo.Click
        If (Socios.Text <> "") Or (CCedulas.Text <> "") Then
            If (benef = 1) Then
                ' Frame3.Enabled = True
                TB1Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB1Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB1Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB1Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB1Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB1Nombres.Enabled = True
                TB1Cedula.Enabled = True
                TB1Oficio.Enabled = True
                TB1Direccion.Enabled = True
                TB1Sexo.Enabled = True
                TB1Parentesco.Enabled = True
                BtnGuardar.Enabled = True
                TB1FechaNace.Enabled = True
                'benef = 1
            Else
                If (benef = 2) Then
                    ' Frame4.Enabled = True
                    TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                    TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                    TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                    'TB2FechaNace.BackColor = &HC0C0C0
                    TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                    TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                    TB2Nombres.Enabled = True
                    TB2Cedula.Enabled = True
                    TB2Oficio.Enabled = True
                    TB2Direccion.Enabled = True
                    TB2Sexo.Enabled = True
                    TB2Parentesco.Enabled = True
                    TB2FechaNace.Enabled = True
                    BtnGuardar.Enabled = True
                    'benef = 2
                Else
                    MsgBox("ERROR: Solo se permiten dos Beneficiarios por Socio")
                    benef = 0
                End If
            End If
        Else
            MsgBox("Debe Seleccionar un Socio para agregarle un Beneficiario")
        End If
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        Me.Close()
    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        Nuevo.Visible = False
    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnGuardar.Click
        Dim rstBenef As MainDS.TblBenefRow
        Dim rstbenef2 As MainDS.TblBenefRow
        Dim cisoc As String
        Dim codigo As String
        Dim diferencia As Double
        codigo = codi
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblBenef")
        view.RowFilter = "VinSocio='" + TCedula.Text + "'"

        If (Modif1.CheckState = True) Then
            If view.Count > 0 Then
                cisoc = view(0)("CIB")
                view.RowFilter = "CIB='" + cisoc + "'"
                rstbenef2 = view(0).Row
            Else
                rstbenef2 = view.Table.NewRow
            End If
            If (TB1Nombres.Text <> "") And (TB1Cedula.Text <> "") And (TB1Sexo.Text <> "") Then
                diferencia = DateDiff(Microsoft.VisualBasic.DateInterval.Year, TB1FechaNace.Value, Now, FirstDayOfWeek.Monday)
                If (diferencia < 70) Then
                    rstbenef2("VinSocio") = TCedula.Text
                    rstbenef2("NombresB") = TB1Nombres.Text
                    rstbenef2("CIB") = TB1Cedula.Text
                    rstbenef2("FechaNace") = TB1FechaNace.Value
                    If (TB1Direccion.Text <> "") Then
                        rstbenef2("Direccion") = TB1Direccion.Text
                    End If
                    If (TB1Oficio.Text <> "") Then
                        rstbenef2("Oficio") = TB1Oficio.Text
                    End If
                    If (TB1Parentesco.Text <> "") Then
                        rstbenef2("Parentesco") = TB1Parentesco.Text
                    End If
                    rstbenef2("Sexo") = TB1Sexo.Text
                    rstbenef2("CodBk") = codi

                    TB1Nombres.Enabled = False
                    TB1Cedula.Enabled = False
                    TB1Oficio.Enabled = False
                    TB1Direccion.Enabled = False
                    TB1Sexo.Enabled = False
                    TB1Parentesco.Enabled = False
                    BtnGuardar.Enabled = False
                    Modif1.Enabled = True
                    Modif1.CheckState = False
                    Elim1.CheckState = False
                    Elim1.Enabled = False
                    TB1Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                    TB1Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                    TB1Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                    'TB1FechaNace.BackColor = &HC0C0C0
                    TB1Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                    TB1Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)

                    MsgBox("El Beneficiario se Actualizado Exitosamente")
                Else
                    MsgBox("ERROR: El Beneficiario no debe ser Mayor de 70 Años")
                End If
            Else
                MsgBox("ERROR: Debe completar los datos")
            End If
        Else
            If (Modif2.CheckState = True) Then
                If view.Count > 1 Then
                    cisoc = view(1)("CIB").Value
                    view.RowFilter = "CIB='" + cisoc + "'"
                End If
                rstbenef2 = view(0).Row
                If (TB2Nombres.Text <> "") And (TB2Cedula.Text <> "") And (TB2Sexo.Text <> "") Then
                    diferencia = DateDiff(Microsoft.VisualBasic.DateInterval.Year, TB2FechaNace.Value, Now, FirstDayOfWeek.Monday)
                    If (diferencia < 70) Then
                        rstbenef2("VinSocio") = TCedula.Text
                        rstbenef2("NombresB") = TB2Nombres.Text
                        rstbenef2("CIB") = TB2Cedula.Text
                        rstbenef2("FechaNace") = TB2FechaNace.Value
                        If (TB2Direccion.Text <> "") Then
                            rstbenef2("Direccion") = TB2Direccion.Text
                        End If
                        If (TB2Oficio.Text <> "") Then
                            rstbenef2("Oficio") = TB2Oficio.Text
                        End If
                        If (TB2Parentesco.Text <> "") Then
                            rstbenef2("Parentesco") = TB2Parentesco.Text
                        End If
                        rstbenef2("Sexo") = TB2Sexo.Text
                        rstbenef2("CodBk") = codi

                        TB2Nombres.Enabled = False
                        TB2Cedula.Enabled = False
                        TB2Oficio.Enabled = False
                        TB2Direccion.Enabled = False
                        TB2Sexo.Enabled = False
                        TB2Parentesco.Enabled = False

                        Modif2.Enabled = True
                        Modif2.CheckState = False
                        BtnGuardar.Enabled = False
                        TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                        TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                        TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                        'TB1FechaNace.BackColor = &HC0C0C0
                        TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                        TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)

                        MsgBox("El Beneficiario se Actualizado Exitosamente")
                    Else
                        MsgBox("ERROR: El Beneficiario no debe ser Mayor de 70 Años")
                    End If
                Else
                    MsgBox("ERROR: Debe completar los datos")
                End If

            Else
                If (benef = 1) Then
                    If (TB1Nombres.Text <> "") And (TB1Cedula.Text <> "") And (TB1Sexo.Text <> "") Then
                        diferencia = DateDiff(Microsoft.VisualBasic.DateInterval.Year, TB1FechaNace.Value, Now, FirstDayOfWeek.Monday)
                        If (diferencia < 70) Then
                            view.RowFilter = "CIB='" + TB1Cedula.Text + "'"
                            If view.Count = 0 Then
                                rstBenef = view.Table.NewRow
                                rstBenef("VinSocio") = TCedula.Text
                                rstBenef("NombresB") = TB1Nombres.Text
                                rstBenef("CIB") = TB1Cedula.Text
                                rstBenef("FechaNace") = TB1FechaNace.Value
                                If (TB1Direccion.Text <> "") Then
                                    rstBenef("Direccion") = TB1Direccion.Text
                                End If
                                If (TB1Oficio.Text <> "") Then
                                    rstBenef("Oficio") = TB1Oficio.Text
                                End If
                                If (TB1Parentesco.Text <> "") Then
                                    rstBenef("Parentesco") = TB1Parentesco.Text
                                End If
                                rstBenef("Sexo") = TB1Sexo.Text
                                rstBenef("CodBk") = codi
                                benef = 2
                                TB1Nombres.Enabled = False
                                TB1Cedula.Enabled = False
                                TB1Oficio.Enabled = False
                                TB1Direccion.Enabled = False
                                TB1Sexo.Enabled = False
                                TB1Parentesco.Enabled = False
                                BtnGuardar.Enabled = False
                                MsgBox("El Beneficiario se registro Exitosamente")
                                Modif1.Enabled = True
                                Elim2.Enabled = True
                            Else
                                MsgBox("El Beneficiario ya se encuentra registrado")
                            End If
                        Else
                            MsgBox("ERROR: El Beneficiario no debe ser Mayor de 70 Años")
                        End If
                    Else
                        MsgBox("ERROR: Debe completar los datos")
                    End If
                End If
            End If
            If (benef = 2) Then
                If (TB2Nombres.Text <> "") And (TB2Cedula.Text <> "") And (TB2Sexo.Text <> "") Then
                    diferencia = DateDiff(Microsoft.VisualBasic.DateInterval.Year, TB2FechaNace.Value, Now, FirstDayOfWeek.Monday)
                    If (diferencia < 70) Then
                        view.RowFilter = "CIB='" + TB2Cedula.Text + "'"
                        If view.Count = 0 Then
                            rstBenef = view.Table.NewRow
                            rstBenef("VinSocio") = TCedula.Text
                            rstBenef("NombresB") = TB2Nombres.Text
                            rstBenef("CIB") = TB2Cedula.Text
                            rstBenef("FechaNace") = TB2FechaNace.Value
                            If (TB2Direccion.Text <> "") Then
                                rstBenef("Direccion") = TB2Direccion.Text
                            End If
                            If (TB2Oficio.Text <> "") Then
                                rstBenef("Oficio") = TB2Oficio.Text
                            End If
                            If (TB2Parentesco.Text <> "") Then
                                rstBenef("Parentesco") = TB2Parentesco.Text
                            End If
                            rstBenef("Sexo") = TB2Sexo.Text
                            rstBenef("CodBk") = codi
                            benef = 0
                            TB2Nombres.Enabled = False
                            TB2Cedula.Enabled = False
                            TB2Oficio.Enabled = False
                            TB2Direccion.Enabled = False
                            TB2Sexo.Enabled = False
                            TB2Parentesco.Enabled = False
                            BtnGuardar.Enabled = False
                            MsgBox("El Beneficiario se registro Exitosamente")
                            Modif2.Enabled = True
                            Elim2.Enabled = True
                        Else
                            MsgBox("El Beneficiario ya se encuentra registrado")

                        End If
                    Else
                        MsgBox("ERROR: El Beneficiario no debe ser Mayor de 70 Años")
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub Elim1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Elim1.CheckStateChanged
        Dim rstelimb As DataRow
        Dim resp As Short
        If (Elim1.CheckState = 1) Then
            resp = MsgBox("IMPORTANTE" & vbCrLf & "Realmente desea Eliminar el Beneficiario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema")
            If resp = 6 Then
                Dim view As New DataView
                view.Table = MainDSO.Tables("TblBenef")
                view.RowFilter = "CIB='" + TB1Cedula.Text + "'"
                rstelimb = view(0).Row
                rstelimb.Delete()
                TB1Nombres.Text = ""
                TB1Cedula.Text = ""
                TB1Oficio.Text = ""
                TB1Direccion.Text = ""
                TB1Sexo.Text = ""
                TB1Parentesco.Text = ""
                benef = 1
                TB1Nombres.Enabled = False
                TB1Cedula.Enabled = False
                TB1Oficio.Enabled = False
                TB1Direccion.Enabled = False
                TB1Sexo.Enabled = False
                TB1Parentesco.Enabled = False
                TB1FechaNace.Enabled = False
                ' Mod1 = False
                ' Elim1 = False
                Modif1.Enabled = False
                Elim1.Enabled = False
                TB1Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB1Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB1Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB1Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB1Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                MsgBox("El Beneficiario fue Eliminado Exitosamente...!")
            Else
                Elim1.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End If
    End Sub

    Private Sub Elim2_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Elim2.CheckStateChanged
        Dim rstelimb As DataRow
        Dim resp As Short
        If (Elim2.CheckState = 1) Then
            resp = MsgBox("IMPORTANTE" & vbCrLf & "Realmente desea Eliminar el Beneficiario?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema")
            If resp = 6 Then
                Dim view As New DataView
                view.Table = MainDSO.Tables("TblBenef")
                view.RowFilter = "CIB='" + TB2Cedula.Text + "'"
                rstelimb = view(0).Row
                rstelimb.Delete()
                TB2Nombres.Text = ""
                TB2Cedula.Text = ""
                TB2Oficio.Text = ""
                TB2Direccion.Text = ""
                TB2Sexo.Text = ""
                TB2Parentesco.Text = ""
                benef = 2
                TB2Nombres.Enabled = False
                TB2Cedula.Enabled = False
                TB2Oficio.Enabled = False
                TB2Direccion.Enabled = False
                TB2Sexo.Enabled = False
                TB2Parentesco.Enabled = False
                TB2FechaNace.Enabled = False
                ' Mod2 = False
                ' Elim2 = False
                ' Mod2.Enabled = False
                Elim2.Enabled = False
                TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                MsgBox("El Beneficiario fue Eliminado Exitosamente...!")
            Else
                Elim2.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End If
    End Sub

    Private Sub Beneficiario_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If My.Settings.DynamicPermits Then
            BtnNuevo.Enabled = (FindPermit(tuser, "PanelSociosProtegidosNuevo") = "1")
            BtnGuardar.Enabled = (FindPermit(tuser, "PanelSociosProtegidosGuardar") = "1")
        End If

        Dim rstSoc As New DataView
        Dim codigo As String
        codigo = codi
        rstSoc.Table = MainDSO.Tables("TblSocios")
        rstSoc.RowFilter = "Estatus=1"
        rstSoc.Sort = "Nombres"
        For Each r As DataRowView In rstSoc
            Socios.Items.Add(r("CI") + " | " + r("Nombres"))
        Next
        rstSoc.Sort = "CI"
        For Each r As DataRowView In rstSoc
            CCedulas.Items.Add(r("CI"))
        Next
        TB1Nombres.Enabled = False
        TB1Cedula.Enabled = False
        TB1Oficio.Enabled = False
        TB1Direccion.Enabled = False
        TB1Sexo.Enabled = False
        TB1Parentesco.Enabled = False
        TB1FechaNace.Enabled = False
        TB2Nombres.Enabled = False
        TB2Cedula.Enabled = False
        TB2Oficio.Enabled = False
        TB2Direccion.Enabled = False
        TB2Sexo.Enabled = False
        TB2Parentesco.Enabled = False
        TB2FechaNace.Enabled = False
        BtnGuardar.Enabled = False
        Modif1.CheckState = False
        Modif2.CheckState = False
        Elim1.CheckState = False
        Elim2.CheckState = False
        Modif1.Enabled = False
        Modif2.Enabled = False
        Elim1.Enabled = False
        Elim2.Enabled = False
    End Sub

    Private Sub Modif1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Modif1.CheckStateChanged
        If (Modif1.CheckState = 1) Then
            If (benef = 2) Or (benef = 0) Then
                TB1Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB1Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB1Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB1Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB1Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB1Nombres.Enabled = True
                TB1Cedula.Enabled = True
                TB1Oficio.Enabled = True
                TB1Direccion.Enabled = True
                TB1Sexo.Enabled = True
                TB1Parentesco.Enabled = True
                TB1FechaNace.Enabled = True
                BtnGuardar.Enabled = True
                TB2Nombres.Enabled = False
                TB2Cedula.Enabled = False
                TB2Oficio.Enabled = False
                TB2Direccion.Enabled = False
                TB2Sexo.Enabled = False
                TB2Parentesco.Enabled = False
                TB2FechaNace.Enabled = False
                TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                Modif2.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        Else
            TB1Nombres.Enabled = False
            TB1Cedula.Enabled = False
            TB1Oficio.Enabled = False
            TB1Direccion.Enabled = False
            TB1Sexo.Enabled = False
            TB1Parentesco.Enabled = False
            If (Modif1.CheckState = 0) And (Modif2.CheckState = 0) Then
                BtnGuardar.Enabled = False
            End If
            TB1FechaNace.Enabled = False
            TB1Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            'TB1FechaNace.BackColor = &HC0C0C0
            TB1Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
        End If

    End Sub

    Private Sub Modif2_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Modif2.CheckStateChanged
        If (Modif2.CheckState = 1) Then
            If (benef = 0) Then
                TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
                TB2Nombres.Enabled = True
                TB2Cedula.Enabled = True
                TB2Oficio.Enabled = True
                TB2Direccion.Enabled = True
                TB2Sexo.Enabled = True
                TB2Parentesco.Enabled = True
                BtnGuardar.Enabled = True
                TB2FechaNace.Enabled = True
                TB1Nombres.Enabled = False
                TB1Cedula.Enabled = False
                TB1Oficio.Enabled = False
                TB1Direccion.Enabled = False
                TB1Sexo.Enabled = False
                TB1Parentesco.Enabled = False
                TB1FechaNace.Enabled = False
                TB1Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB1Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB1Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB1Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB1Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                Modif1.CheckState = False
            End If
        Else
            TB2Nombres.Enabled = False
            TB2Cedula.Enabled = False
            TB2Oficio.Enabled = False
            TB2Direccion.Enabled = False
            TB2Sexo.Enabled = False
            TB2Parentesco.Enabled = False
            If (Modif1.CheckState = 0) And (Modif2.CheckState = 0) Then
                BtnGuardar.Enabled = False
            End If
            TB2FechaNace.Enabled = False
            TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            'TB1FechaNace.BackColor = &HC0C0C0
            TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
        End If

    End Sub

    Private Sub Socios_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Socios.SelectedIndexChanged
        Dim rstSoc As DataRow
        Dim rstBenef As DataRow
        Dim codigo As String
        Dim Cred() As String
        CCedulas.Text = ""
        Cred = Split(Socios.Text, " ")
        SocCedrid = Cred(0)
        codigo = codi
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblBenef")
        view.RowFilter = "VinSocio='" + SocCedrid + "'"
        rstSoc = MainDSO.Tables("TblSocios").Rows.Find(SocCedrid)

        TCedula.Text = rstSoc("CI")
        TNombre.Text = rstSoc("Nombres")
        TCAPS.Text = rstSoc("cap")
        If (Not rstSoc.IsNull("CapLiq")) Then
            TCAPSL.Text = rstSoc("CapLiq")
        End If
        If (Not rstSoc.IsNull("FIngreso")) Then
            TFecha.Text = rstSoc("FIngreso")
        End If
        If view.Count > 0 Then
            rstBenef = view(0).Row
            TB1Nombres.Text = rstBenef("NombresB")
            TB1Cedula.Text = rstBenef("CIB")
            If (rstBenef("Oficio") <> "") Then
                TB1Oficio.Text = rstBenef("Oficio")
            End If
            TB1FechaNace.Value = rstBenef("FechaNace")
            If (rstBenef("Direccion") <> "") Then
                TB1Direccion.Text = rstBenef("Direccion")
            End If
            If (rstBenef("Parentesco") <> "") Then
                TB1Parentesco.Text = rstBenef("Parentesco")
            End If
            TB1Sexo.Text = rstBenef("Sexo")
            benef = 2
            Modif1.CheckState = False
            Elim1.CheckState = False
            Modif1.Enabled = True
            Elim1.Enabled = True
            If view.Count > 1 Then
                rstBenef = view(1).Row
                TB2Nombres.Text = rstBenef("NombresB")
                TB2Cedula.Text = rstBenef("CIB")
                If (rstBenef("Oficio") <> "") Then
                    TB2Oficio.Text = rstBenef("Oficio")
                End If

                TB2FechaNace.Value = rstBenef("FechaNace")
                If (rstBenef("Direccion") <> "") Then
                    TB2Direccion.Text = rstBenef("Direccion")
                End If
                If (rstBenef("Parentesco") <> "") Then
                    TB2Parentesco.Text = rstBenef("Parentesco")
                End If
                TB2Sexo.Text = rstBenef("Sexo")
                benef = 0
                Modif2.CheckState = False
                Elim2.CheckState = False
                Modif2.Enabled = True
                Elim2.Enabled = True
            Else
                TB2Nombres.Text = ""
                TB2Cedula.Text = ""
                TB2Oficio.Text = ""
                TB2Direccion.Text = ""
                TB2Sexo.Text = ""
                TB2Parentesco.Text = ""
                TB2Nombres.Enabled = False
                TB2Cedula.Enabled = False
                TB2Oficio.Enabled = False
                TB2Direccion.Enabled = False
                TB2Sexo.Enabled = False
                TB2Parentesco.Enabled = False
                TB2FechaNace.Enabled = False
                BtnGuardar.Enabled = False
                Modif2.CheckState = False
                Elim2.CheckState = False
                Modif2.Enabled = False
                Elim2.Enabled = False
                TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                'TB1FechaNace.BackColor = &HC0C0C0
                TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            End If
        Else
            TB1Nombres.Text = ""
            TB1Cedula.Text = ""
            TB1Oficio.Text = ""
            TB1Direccion.Text = ""
            TB1Sexo.Text = ""
            TB1Parentesco.Text = ""
            TB2Nombres.Text = ""
            TB2Cedula.Text = ""
            TB2Oficio.Text = ""
            TB2Direccion.Text = ""
            TB2Sexo.Text = ""
            TB2Parentesco.Text = ""
            benef = 1
            TB1Nombres.Enabled = False
            TB1Cedula.Enabled = False
            TB1Oficio.Enabled = False
            TB1Direccion.Enabled = False
            TB1Sexo.Enabled = False
            TB1Parentesco.Enabled = False
            TB1FechaNace.Enabled = False
            TB2Nombres.Enabled = False
            TB2Cedula.Enabled = False
            TB2Oficio.Enabled = False
            TB2Direccion.Enabled = False
            TB2Sexo.Enabled = False
            TB2Parentesco.Enabled = False
            TB2FechaNace.Enabled = False
            BtnGuardar.Enabled = False
            Modif2.CheckState = False
            Elim2.CheckState = False
            Modif2.Enabled = False
            Elim2.Enabled = False
            Modif1.CheckState = False
            Elim1.CheckState = False
            Modif1.Enabled = False
            Elim1.Enabled = False
            TB1Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            'TB1FechaNace.BackColor = &HC0C0C0
            TB1Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB1Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Nombres.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Cedula.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Oficio.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            'TB1FechaNace.BackColor = &HC0C0C0
            TB2Direccion.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
            TB2Parentesco.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
        End If

    End Sub

    Private Sub Socios_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Socios.KeyPress
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

    Private Sub TB1Cedula_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TB1Cedula.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TB1Sexo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TB1Sexo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TB2Cedula_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TB2Cedula.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TB2Sexo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TB2Sexo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TCAPS_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCAPS.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TCAPSL_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCAPSL.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TCedula_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCedula.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TFecha_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TFecha.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TNombre_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
End Class