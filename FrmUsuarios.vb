Public Class FrmUsuarios

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblUsuarioBindingSource.DataSource = MainDSO.Tables("TblUsuario")
    End Sub
End Class