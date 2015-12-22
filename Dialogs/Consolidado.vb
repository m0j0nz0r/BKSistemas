Public Class Consolidado
    Public Filter As String
    Public Estado As String
    Private Sub Consolidado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BankoView As New DataView
        BankoView.Table = MainDSO.Tables("TblBanko")
        BankoView.RowFilter = Filter
        Dim GestionView As New DataView
        GestionView.Table = MainDSO.Tables("Gestion")
        Dim f As String = ""
        For Each r As DataRowView In BankoView
            f = f & "codBK='" & r("CodBK") & "' OR "
        Next
        If f <> "" Then
            f = f.Substring(0, f.Length - 4)
        End If
        Debug.WriteLine(f)
        GestionView.RowFilter = f
        For Each r As DataRowView In GestionView
            If Not CAno.Items.Contains(CDate(r("FCorte")).Year.ToString) Then
                CAno.Items.Add(CDate(r("FCorte")).Year.ToString)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k As Boolean = True


        Dim view As New DataView
        view.Table = MainDSO.Tables("Gestion")
        If CAno.Text <> "" Then
            view.RowFilter = "FCorte <=#" & CAno.Text & "-12-31#"
        End If

        Dim bk As New DataView
        bk.Table = MainDSO.Tables("TblBanko")
        bk.RowFilter = Filter

        If bk.Count > 0 Then
            Dim filter As String = IIf(view.RowFilter = "", "", view.RowFilter & " AND ") & "(codBK='" & bk(0)("CodBk") & "'"
            For i As Integer = 1 To bk.Count - 2
                filter = filter & " OR codBK='" & bk(i)("CodBk") & "'"
            Next
            filter = filter & " OR codBK='" & bk(bk.Count - 1)("CodBk") & "')"
            view.RowFilter = filter
        Else
            MsgBox("No hay registros para mostrar...")
            k = False
        End If
        If view.Count > 0 And k Then
            Dim row As DataRow = MainDSO.Tables("RptConsolidado").NewRow
            row("SociosM") = 0
            row("SociosF") = 0
            row("CAPS") = 0
            row("TotalCreditos") = 0
            row("MontoCreditos") = 0
            row("Ganancias") = 0
            Dim bankos As New Collection
            For Each r As DataRowView In view
                row("SociosM") += r("NTSMACUM") - r("NTSMRACUM")
                row("SociosF") += r("NTSFACUM") - r("NTSFRACUM")
                row("CAPS") += r("ZVCACUM") - r("ZLCACUM")
                row("TotalCreditos") += r("qCONACUM") + r("qCORACUM")
                row("MontoCreditos") += r("ZCONACUM") + r("ZCORACUM")
                row("Ganancias") += r("ZGestionMNetoACUM")
                If Not bankos.Contains(r("codBK")) Then
                    bankos.Add(r("codBK"), r("codBK"))
                End If
            Next
            row("CantdeBk") = bankos.Count
            For Each x As Object In bankos
                Debug.WriteLine(x)
            Next
            MainDSO.Tables("RptConsolidado").Rows.Clear()
            MainDSO.Tables("RptConsolidado").Rows.Add(row)
            Dim rpt As New RptConsolidado
            rpt.estado = Estado
            rpt.ShowDialog()
        Else
            If k Then MsgBox("No hay registros para mostrar ese año...")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class