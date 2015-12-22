Public Class PanelUsuarios
    Private Handling As Boolean = False
    Private Sub PanelUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblBankoBindingSource.DataSource = MainDSO.Tables("TblBanko")
        TblProfilesBindingSource.DataSource = MainDSO.Tables("TblProfiles")
        TblUsuarioBindingSource.DataSource = MainDSO.Tables("TblUsuario")
    End Sub

    Private Sub CBPerfil_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBPerfil.SelectedValueChanged
        If Not Handling Then
            Handling = True
            If Not TblUsuarioBindingSource.Current Is Nothing Then
                TblUsuarioBindingSource.Current("TipoUser") = CBPerfil.SelectedValue
            End If
            Handling = False
        End If
    End Sub

    Private Sub CBBanko_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBBanko.SelectedValueChanged
        If Not Handling Then
            Handling = True
            If Not TblUsuarioBindingSource.Current Is Nothing Then
                TblUsuarioBindingSource.Current("Bk") = CBBanko.SelectedValue
            End If
            Handling = False
        End If
    End Sub

    Private Sub TblUsuarioBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles TblUsuarioBindingSource.CurrentItemChanged
        If Not Handling Then
            Handling = True
            CBPerfil.SelectedValue = TblUsuarioBindingSource.Current("TipoUser")
            CBBanko.SelectedValue = TblUsuarioBindingSource.Current("Bk")
            Handling = False
        End If
    End Sub
End Class