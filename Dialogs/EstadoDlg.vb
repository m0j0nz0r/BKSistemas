Public Class EstadoDlg
    Public Property Prompt As String
    Public Property ID As Integer = -1
    Public Property Again As Boolean = False
    Public Property Pais As Integer = -1
    Private view As DataView
    Private Sub ProyectoDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view = New DataView(MainDSO.TblEstados)
        If Pais >= 0 Then
            view.RowFilter = "PID=" & Pais
        End If
        setBindingSource(ProyectList, view, TblEstadosBindingSource)
        Label1.Text = Prompt
        AddEstado.Visible = FindPermit(tuser, "PanelConfigEstados") = "1"
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
            If vbYes <> MsgBox("Está seguro que desea cerrar la ventana sin escoger un estado? si lo hace el banko no será importado.", MsgBoxStyle.YesNo) Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddEstado.Click
        Dim f As New PanelEstados
        f.ShowDialog()
    End Sub
End Class