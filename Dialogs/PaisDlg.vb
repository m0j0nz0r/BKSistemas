Public Class PaisDlg
    Public Property Prompt As String
    Public Property ID As Integer = -1
    Public Property Again As Boolean = False
    Private Sub ProyectoDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblPaisesBindingSource.DataSource = MainDSO.TblPaises
        Label1.Text = Prompt
        AddPais.Visible = FindPermit(tuser, "PanelConfigPaises")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ProyectList.SelectedValue Is Nothing Then
            ID = ProyectList.SelectedValue
        End If
        Again = ChkAgain.Checked
        Close()
    End Sub

    Private Sub ProyectoDlg_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ID < 0 Then
            If vbYes <> MsgBox("Está seguro que desea cerrar la ventana sin escoger un país? si lo hace el banko no será importado.", MsgBoxStyle.YesNo) Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub AddPais_Click(sender As Object, e As EventArgs) Handles AddPais.Click
        Dim f As New PanelPaises
        f.ShowDialog()
    End Sub
End Class