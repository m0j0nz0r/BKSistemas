Public Class Opciones

    Private Sub SetValues()
        LblLoad.Text = IIf(My.Settings.AsyncLoading, "Carga Paralela", "Carga en Serie")
        LblOffline.Text = IIf(My.Settings.Offline, "Modo Offline", "Modo Online")
        LblFile.Text = "Archivo: " & My.Settings.SaveData
    End Sub
    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetValues()
        LblOffline.Visible = FindPermit(tuser, "PanelConfigOpcionesOffline") = "1"
        BtnOffline.Visible = LblLoad.Visible
        LblLoad.Visible = FindPermit(tuser, "PanelConfigOpcionesLoad") = "1"
        BtnLoad.Visible = LblLoad.Visible
        LblFile.Visible = FindPermit(tuser, "PanelConfigOpcionesFile") = "1"
        BtnFile.Visible = LblLoad.Visible
    End Sub

    Private Sub BtnOffline_Click(sender As Object, e As EventArgs) Handles BtnOffline.Click
        My.Settings.Offline = Not My.Settings.Offline
        My.Settings.Save()
        SetValues()
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        My.Settings.AsyncLoading = Not My.Settings.AsyncLoading
        My.Settings.Save()
        SetValues()
    End Sub

    Private Sub BtnFile_Click(sender As Object, e As EventArgs) Handles BtnFile.Click
        Dim rst As DialogResult
        Dim openfileDlg As New SaveFileDialog
        openfileDlg.Filter = "Respaldo BkSistema (*.bks)|*.bks"
        openfileDlg.AddExtension = True
        openfileDlg.Title = "Seleccionar el directorio donde desea respaldar la Data"
        rst = openfileDlg.ShowDialog()
        If rst = DialogResult.OK Then
            My.Settings.SaveData = openfileDlg.FileName
            My.Settings.Save()
        End If
    End Sub
End Class