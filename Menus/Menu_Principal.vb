Option Strict Off
Option Explicit On
Friend Class Menu_Principal
    Inherits System.Windows.Forms.Form

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnDatosBanko.Click
        Dim DatosBanko As New DatosBanko
        DatosBanko.ShowDialog()

    End Sub

    Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnNewBk.Click
        Dim CrearBK As New CrearBK
        CrearBK.TxtFecha.Value = Now
        CrearBK.ShowDialog()
    End Sub

    Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnTablas.Click
        Dim f As New Menu_Configuracion
        f.ShowDialog()
    End Sub

    Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnClasifCred.Click
        Dim f As New Form1
        f.ShowDialog()
    End Sub

    Private Sub Command13_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnRptFinancieros.Click
        Dim Menu5 As New Menu_RptFinancieros
        Menu5.ShowDialog()
    End Sub

    'Private Sub Command14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command14.Click
    '	Dim tITULO As Object
    '	Dim micadena As Object
    '	Dim conn As Object

    '	'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
    '	'UPGRADE_ISSUE: Procesar object was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
    '	Dim Procesar As New Procesar
    '	If Not Dir("c:\procesar\bksistema_datos.mdb") = "" Then
    '		'Unload Menu1

    '		' miConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\procesar\bksistema_datos.mdb;" _
    '		''    & " User ID=fundefir;Password=saida007;Jet OLEDB:System database=C:\GestorBankomunal\CJGH.MDW"
    '		conn = CreateObject("ADODB.Connection")
    '		'UPGRADE_WARNING: Couldn't resolve default property of object conn.Open. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		conn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\procesar\bksistema_datos.mdb;Jet OLEDB:Database")
    '		rs = CreateObject("ADODB.Recordset")
    '		With Cn
    '			'UPGRADE_WARNING: Couldn't resolve default property of object conn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			.ConnectionString = conn
    '			.ConnectionTimeout = 10
    '			.Open()
    '		End With
    '		rs.Open("tblbanko", Cn, 1, 3, ADODB.CommandTypeEnum.adCmdTable)
    '		'UPGRADE_WARNING: Couldn't resolve default property of object Procesar.LstBankos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		Procesar.LstBankos.ColumnCount = 2
    '		'Procesar.LstBankos.Width = "4000"
    '		'UPGRADE_WARNING: Couldn't resolve default property of object Procesar.LstBankos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '           'Procesar.LstBankos.ColumnWidths = "7 cm;2 cm"
    '		If rs.RecordCount > 0 Then
    '			'Procesar.LstBankos.RowSourceType = "value list" '"Lista de valores"
    '			Do While Not rs.EOF
    '				'If micadena = "" Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object micadena. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				micadena = UCase(rs.Fields("CodBk").Value) & "," & UCase(rs.Fields("NombreBK").Value)
    '				'UPGRADE_WARNING: Couldn't resolve default property of object micadena. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				'UPGRADE_WARNING: Couldn't resolve default property of object Procesar.LstBankos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                   'Procesar.LstBankos.AddItem(Replace(micadena, ",", vbTab))
    '				'micadena = UCase(rs!CodBk)
    '				'Else
    '				'    micadena = micadena & "," & UCase(rs!CodBk) & "," & UCase(rs!NombreBK)
    '				' micadena = micadena & " " & UCase(rs!CodBk)
    '				'End If
    '				rs.MoveNext()
    '			Loop 
    '		End If
    '		rs.Close()
    '		Cn.Close()
    '		'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '		Cn = Nothing
    '		'Procesar.LstBankos.RowSource = micadena
    '		'Procesar.LstBankos.AddItem micadena

    '		'UPGRADE_WARNING: Couldn't resolve default property of object Procesar.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '           'Procesar.Show(VB6.FormShowConstants.Modal)
    '           Procesar.Show()

    '	Else
    '		'UPGRADE_WARNING: Couldn't resolve default property of object tITULO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		MsgBox("No hay base de datos en la carpeta para procesar", MsgBoxStyle.Critical, tITULO)
    '	End If

    'End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnLibroIE.Click
        Dim LibroIE As New LibroIE
        ' Unload Menu1
        LibroIE.ShowDialog()
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnDatosCreditos.Click
        Dim PanelCredito As New PanelCredito
        PanelCredito.ShowDialog()

    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnPanelSocios.Click
        Dim Menu2 As New Menu_Socios
        Menu2.ShowDialog()

    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnCuadreCierre.Click
        Dim Menu3 As New Menu_Cuadre_Cierre
        Menu3.ShowDialog()
    End Sub

    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnVolver.Click
        Dim Autentificacion As New Autentificacion
        Dim adapter As New DatabaseWebAdapter()
        adapter.Update(MainDSO)
        tuser = 0
        logged = False
        Autentificacion.Show()
        Close()
    End Sub

    Private Sub Frame1_DragDrop(ByRef Source As System.Windows.Forms.Control, ByRef X As Single, ByRef Y As Single)

    End Sub

    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnPanelRpt.Click
        Dim Menu4 As New Menu_Reportes
        Menu4.ShowDialog()

    End Sub

    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnBackup.Click
        Dim DS As New MainDS
        Dim adapter As New DatabaseWebAdapter()
        Dim conn As New DatabaseWebConnection(My.Settings.ConnectionString)
        Dim dlg As New Form
        Dim pb As New ProgressBar()
        Dim lbl As New Label
        lbl.Text = "Descargando respaldo..."
        GetTableList(DS)
        ShowProgressBar(dlg, pb, lbl)
        pb.Maximum = DS.Tables.Count - 1
        Dim file As IO.StreamWriter
        Dim openfileDlg As New SaveFileDialog
        openfileDlg.Filter = "Respaldo BkSistema (*.bks)|*.bks"
        openfileDlg.AddExtension = True
        openfileDlg.Title = "Seleccionar el directorio donde desea respaldar la Data"
        openfileDlg.ShowDialog()
        dlg.Show()
        For Each t As DataTable In DS.Tables
            adapter.SelectCommand = New DatabaseWebCommand("SELECT * FROM " + t.TableName, conn)
            adapter.Fill(DS)
            lbl.Text = "Descargando respaldo...[" & pb.Value + 1 & "/" & DS.Tables.Count & "]"
            pb.PerformStep()
        Next
        dlg.Close()
        Try
            file = My.Computer.FileSystem.OpenTextFileWriter(openfileDlg.FileName, False)
            file.Write(JsonConvert.SerializeObject(DS))
            file.Close()
            MessageBox.Show("Respaldo exitoso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnProfiles.Click
        Dim f As New ProfileConfig
        f.ShowDialog()
    End Sub

    Private Sub Menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        logged = True
            BtnDatosBanko.Visible = (FindPermit(tuser, "DatosBanko") = "1")
            LblDatosBanko.Visible = BtnDatosBanko.Visible
            BtnLibroIE.Visible = (FindPermit(tuser, "LibroIE") = "1")
            LblLibroIE.Visible = BtnLibroIE.Visible
            BtnDatosCreditos.Visible = (FindPermit(tuser, "DatosCreditos") = "1")
            LblDatosCreditos.Visible = BtnDatosCreditos.Visible
            BtnPanelSocios.Visible = (FindPermit(tuser, "PanelSocios") = "1")
            LblPanelSocios.Visible = BtnPanelSocios.Visible
            BtnCuadreCierre.Visible = (FindPermit(tuser, "CuadreCierre") = "1")
            LblCuadreCierre.Visible = BtnCuadreCierre.Visible
            BtnPanelRpt.Visible = (FindPermit(tuser, "PanelReportes") = "1")
            LblPanelRpt.Visible = BtnPanelRpt.Visible
            'BtnVolver.Visible = (FindPermit(tuser, "Volver") = "1")
            'LblVolver.Visible = BtnVolver.Visible
            BtnBackup.Visible = (FindPermit(tuser, "Respaldo") = "1")
            LblBackup.Visible = BtnBackup.Visible
            BtnProfiles.Visible = (FindPermit(tuser, "Perfiles") = "1")
            LblProfiles.Visible = BtnProfiles.Visible
            BtnNewBk.Visible = (FindPermit(tuser, "CrearBk") = "1")
            LblNewBk.Visible = BtnNewBk.Visible
            BtnTablas.Visible = (FindPermit(tuser, "Tablas") = "1")
            LblTablas.Visible = BtnTablas.Visible
            BtnClasifCred.Visible = (FindPermit(tuser, "ClaseCreditos") = "1")
            LblClasifCred.Visible = BtnClasifCred.Visible
            BtnRptFinancieros.Visible = (FindPermit(tuser, "ReportesFinancieros") = "1")
            LblRptFinancieros.Visible = BtnRptFinancieros.Visible
            BtnProcesar.Visible = (FindPermit(tuser, "Procesar") = "1")
            LblProcesar.Visible = BtnProcesar.Visible
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TestDs As New MainDS
        Dim SumTime As Double = 0
        Dim Exectime As DateTime
        For i As Integer = 1 To 10
            Debug.WriteLine(i)
            Exectime = Now
            LoadOnline(TestDs)
            SumTime += (Now - Exectime).TotalSeconds
            Debug.WriteLine(SumTime / (i))
            TestDs.Clear()
        Next
        MsgBox(SumTime / 10 & " Segundos en promedio.")
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles LblClasifCred.Click

    End Sub

    Private Sub BtnProcesar_Click(sender As Object, e As EventArgs) Handles BtnProcesar.Click
        Dim frm As New Procesar
        frm.ShowDialog()
    End Sub
End Class