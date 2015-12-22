Public Class PanelMunicipios
    Private States As DataView
    Private StatesTbl As MainDS.TblEstadosDataTable
    Private Handling = False

    Private Sub PanelMunicipios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        States = New DataView(MainDSO.TblEstados)
        StatesTbl = MainDSO.TblEstados.Copy
        TblEstadosBindingSource.DataSource = States
        TblMunicipiosBindingSource.DataSource = MainDSO.Tables("TblMunicipios")
        NombreComboBox.DataSource = MainDSO.TblPaises
        NombreComboBox.ValueMember = "ID"
        NombreComboBox.DisplayMember = "Nombre"

        EIDComboBox.DataSource = StatesTbl
        EIDComboBox.ValueMember = "ID"
        EIDComboBox.DisplayMember = "Nombre"

    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreComboBox.SelectedIndexChanged
        If NombreComboBox.SelectedValue.GetType.Equals(GetType(Integer)) Then
            StatesTbl.DefaultView.RowFilter = "PID='" & NombreComboBox.SelectedValue & "'"
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles EIDComboBox.SelectedValueChanged
        If Not Handling And EIDComboBox.SelectedValue.GetType.Equals(GetType(Integer)) Then
            Handling = True
            If Not TblMunicipiosBindingSource.Current Is Nothing Then
                TblMunicipiosBindingSource.Current("EID") = EIDComboBox.SelectedValue
            End If
            Handling = False
        End If
    End Sub

    Private Sub TblMunicipiosBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles TblMunicipiosBindingSource.CurrentItemChanged
        If Not Handling And EIDComboBox.SelectedValue.GetType.Equals(GetType(Integer)) Then
            Handling = True
            EIDComboBox.SelectedValue = TblMunicipiosBindingSource.Current("EID")
            Handling = False
        End If
    End Sub

    Private Sub TblMunicipiosDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TblMunicipiosDataGridView.DataError
        DataGridViewErrorHandler(sender, e)
    End Sub
End Class