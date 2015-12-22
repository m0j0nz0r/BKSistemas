Public Class RptConsolidado
    Public estado As String
    Private Sub RptConsolidado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", MainDSO.Tables("RptConsolidado")))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", estado))
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class