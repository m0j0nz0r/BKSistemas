Public Class PanelPaises

    Private Sub PanelPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblPaisesBindingSource.DataSource = MainDSO.Tables("TblPaises")
        'TblPaisesDataGridView.DataSource = MainDSO.Tables("TblPaises")
    End Sub

    Private Sub TblPaisesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TblPaisesDataGridView.DataError
        DataGridViewErrorHandler(sender, e)
    End Sub
End Class