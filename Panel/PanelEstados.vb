Public Class PanelEstados

    Private Handling As Boolean = False
    Private Sub PanelEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblEstadosBindingSource.DataSource = MainDSO.Tables("TblEstados")
        TblPaisesBindingSource.DataSource = MainDSO.Tables("TblPaises")
    End Sub

    Private Sub PIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PIDComboBox.SelectedIndexChanged
        If Not Handling Then
            Handling = True
            TblEstadosBindingSource.Current("PID") = PIDComboBox.SelectedValue
            Handling = False
        End If
    End Sub

    Private Sub TblEstadosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TblEstadosBindingSource.CurrentItemChanged
        If Not Handling Then
            Handling = True
            PIDComboBox.SelectedValue = TblEstadosBindingSource.Current("PID")
            Handling = False
        End If
    End Sub

    Private Sub TblEstadosDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TblEstadosDataGridView.DataError
        DataGridViewErrorHandler(sender, e)
    End Sub

    Private Sub PanelEstados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TblEstadosBindingSource.EndEdit()
    End Sub
End Class