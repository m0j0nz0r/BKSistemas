Public Class ProfileConfig
    Public isLoading As Boolean = True
    Private filter As String = ""
    Private Sub ProfileConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblProfilesBindingSource.DataSource = MainDSO.Tables("TblProfiles")
        If ComboBox1.Items.Count > 0 Then ComboBox1_SelectedIndexChanged(sender, e)
    End Sub
    Private Sub CheckChild(n As TreeNode, state As Boolean)
        For Each node As TreeNode In n.Nodes
            node.Checked = state
            If node.Nodes.Count > 0 Then CheckChild(node, state)
        Next
    End Sub
    Private Sub CheckParents(node As TreeNode)
        If node.Parent IsNot Nothing Then
            node.Parent.Checked = True
            CheckParents(node.Parent)
        End If
    End Sub

    Private Sub CheckFamily(node As TreeNode)
        If node.Nodes.Count > 0 Then
            CheckChild(node, node.Checked)
        End If
        If node.Checked Then
            CheckParents(node)
        End If

    End Sub
    Private Sub TreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterCheck
        If e.Action <> TreeViewAction.Unknown Then
            CheckFamily(e.Node)
            HasChanged = True
        End If
    End Sub

    Private LastID As Integer = -1
    Private HasChanged As Boolean = False
    Private Sub SaveNode(ID As Integer, var As String, val As String)
        If MainDSO.Tables("TblUserConfig").Rows.Contains({ID, var}) Then
            MainDSO.Tables("TblUserConfig").Rows.Find({ID, var})("val") = val
        Else
            MainDSO.Tables("TblUserConfig").Rows.Add({ID, var, val})
        End If
    End Sub
    Private Sub SaveChanges(ID As Integer, node As TreeNode)
        'Save filter
        SaveNode(ID, "FilterStatus", lblFilterStatus.Text)
        SaveNode(ID, "FilterCode", filter)
        SaveNode(ID, "ForceSelect", IIf(ckForceSelect.Checked, "1", "0"))
        'Save tree
        SaveNode(ID, node.Name, IIf(node.Checked, "1", "0"))
        For Each n As TreeNode In node.Nodes
            SaveChanges(ID, n)
        Next
    End Sub

    Private Function FindChild(name As String, base As TreeNode) As TreeNode()
        Dim retval As TreeNode()
        If base.Name = name Then
            Return {base}
        ElseIf base.Nodes.Count > 0 Then
            retval = base.Nodes.Find(name, True)
            If retval.Length = 0 Then
                For Each n As TreeNode In base.Nodes
                    retval = FindChild(name, n)
                    If retval.Length > 0 Then Return retval
                Next
                Return {}
            Else
                Return retval
            End If
        End If
        Return {}
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ID As Integer = CInt(ComboBox1.SelectedValue)
        If HasChanged And LastID >= 0 Then 'Save
            SaveChanges(LastID, TreeView1.TopNode)
            HasChanged = False
        End If
        'Load
        If MainDSO.Tables("TblProfiles").Rows.Count > 0 Then
            If MainDSO.Tables("TblProfiles").Rows.Contains(ID) Then
                isLoading = True
                Dim view As New DataView
                view.Table = MainDSO.Tables("TblUserConfig")
                view.RowFilter = "ID=" & ID
                TreeView1.TopNode.Checked = False
                CheckFamily(TreeView1.TopNode)
                For Each r As DataRowView In view
                    If r("var") = "FilterStatus" Then
                        lblFilterStatus.Text = r("val")
                    ElseIf r("var") = "FilterCode" Then
                        filter = r("val")
                    ElseIf r("var") = "ForceSelect" Then
                        ckForceSelect.Checked = (r("val") = "1")
                    Else
                        Dim nodes As TreeNode() = TreeView1.Nodes.Find(r("var"), True)
                        If nodes.Length > 0 Then
                            nodes(0).Checked = (r("val") = "1")
                            If nodes.Length > 1 Then
                                Dim list As String = ""
                                For Each n As TreeNode In nodes
                                    list = list & n.Name & vbNewLine
                                Next
                                MsgBox("Se ha encontrado un error. Contacte un administrador con la siguiente información:" & vbNewLine &
                                       "ID=" & ID & vbNewLine &
                                       "var=" & r("var") & vbNewLine &
                                       list)
                            End If
                        End If
                    End If
                Next
                isLoading = False
            End If
        End If

        LastID = ID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strdlg As New StringDlg
        strdlg.LblPrompt.Text = "Escriba el nombre del nuevo perfil."
        If strdlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If strdlg.StringValue.Text.Trim = "" Then
                MsgBox("Debe proporcionar un nombre para el nuevo perfil...", MsgBoxStyle.Critical)
            Else
                Dim view As New DataView
                view.Table = MainDSO.Tables("TblProfiles")
                view.Sort = "ID DESC"
                Dim TopId As Integer
                If view.Count > 0 Then
                    TopId = view(0)("ID")
                Else : TopId = 1
                End If

                MainDSO.Tables("TblProfiles").Rows.Add({TopId + 1, strdlg.StringValue.Text.Trim})
            End If
        End If
    End Sub

    Private Sub ProfileConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If HasChanged And LastID >= 0 Then SaveChanges(LastID, TreeView1.TopNode)
    End Sub

    Private Sub lblFilterStatus_Click(sender As Object, e As EventArgs) Handles lblFilterStatus.Click
        Dim f As New FilterDlg
        f.ShowDialog()
        If f.DialogResult = Windows.Forms.DialogResult.OK Then
            filter = f.Filter
            lblFilterStatus.Text = f.Estado
            HasChanged = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ckForceSelect_CheckedChanged(sender As Object, e As EventArgs) Handles ckForceSelect.CheckedChanged
        If Not isLoading Then
            HasChanged = True
        End If
    End Sub

    Private Sub ProfileConfig_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        isLoading = False
    End Sub
End Class