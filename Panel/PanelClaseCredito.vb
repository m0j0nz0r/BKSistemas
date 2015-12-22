Public Class PanelClaseCredito
    Private Handling As Boolean = False

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If Not Handling Then
            Handling = True
            If Not TblClaseCreditoBindingSource.Current Is Nothing Then
                TblClaseCreditoBindingSource.Current("TipoCreidito") = ComboBox1.SelectedValue
            End If
            Handling = False
        End If
    End Sub

    Private Sub TblClaseCreditoBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles TblClaseCreditoBindingSource.CurrentItemChanged
        If Not Handling Then
            Handling = True
            ComboBox1.SelectedValue = TblClaseCreditoBindingSource.Current("TipoCreidito")
            Handling = False
        End If
    End Sub

    Private Sub PanelClaseCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblClaseCreditoBindingSource.DataSource = MainDSO.Tables("TblClaseCredito")
        TipoCreditoBindingSource.DataSource = MainDSO.Tables("TipoCredito")
    End Sub
End Class