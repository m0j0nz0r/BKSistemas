Public Class PanelProyectos

    Private Sub PanelProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblProyectosBindingSource.DataSource = MainDSO.Tables("TblProyectos")
        'TblProyectosDataGridView.DataSource = TblProyectosBindingSource.DataSource
    End Sub

    Private Sub TblProyectosDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TblProyectosDataGridView.DataError
        DataGridViewErrorHandler(sender, e)
    End Sub
End Class