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
        tuser = 0
        SaveData()
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