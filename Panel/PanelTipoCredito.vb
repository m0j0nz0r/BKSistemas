Public Class PanelTipoCredito

    Private Sub PanelTipoCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoCreditoBindingSource.DataSource = MainDSO.Tables("TipoCredito")
    End Sub
End Class