Public Class RptFondo

    Private Sub RptFondo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rstsocios As New DataView
        With rstsocios
            .Table = MainDSO.Tables("TblSocios")
            .RowFilter = "Estatus = 1 AND AcumMoras = 1"
            .Sort = "Nombres"
        End With
        Dim tbl As DataTable = rstsocios.ToTable
        If rstsocios.Count > 0 Then
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("TblSocios", tbl))
            Dim param As New Microsoft.Reporting.WinForms.ReportParameter("Bankomunal", ThisBanko("NombreBk").ToString())
            Dim p As New Microsoft.Reporting.WinForms.ReportParameterCollection()
            p.Add(param)
            param = New Microsoft.Reporting.WinForms.ReportParameter("Activos", False)
            p.Add(param)
            Try
                ReportViewer1.LocalReport.SetParameters(p)
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0} \nTrace:{1}", ex.Message, ex.StackTrace))
            End Try
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Else
            MsgBox("No existen registros para mostar...")
        End If
    End Sub
End Class