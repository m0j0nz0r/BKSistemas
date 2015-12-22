Public Class Test

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As DatabaseWebConnection = New DatabaseWebConnection("http://www.fundefir.org/BKSistema/interface.php")
        Dim Adapter As New DatabaseWebAdapter()
        Dim table As String = "tblUsuario"
        Adapter.TableMappings.Add(table, table)
        conn.Open()
        Dim command As New DatabaseWebCommand("SELECT * FROM tblUsuario", conn)
        command.CommandType = CommandType.Text
        Adapter.SelectCommand = command
        Dim DS As DataSet = New DataSet()
        Adapter.Fill(DS)
        DataGridView1.DataSource = DS.Tables(table)

    End Sub
End Class