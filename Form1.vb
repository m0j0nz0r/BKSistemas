Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each t As DataTable In MainDSO.Tables
            ToolStripComboBox1.Items.Add(t.TableName)
        Next
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        ClaseCreditoDataGridView.DataSource = MainDSO.Tables(ToolStripComboBox1.Text)
    End Sub
End Class