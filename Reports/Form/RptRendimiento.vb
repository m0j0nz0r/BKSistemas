Public Class RptRendimiento
    Public CFecha1 As Date
    Public CFecha2 As Date
    Private Sub RptRendimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rstgest As New DataView
        'Consulta los datos generales del Banko
        rstgest.Table = MainDSO.Tables("Gestion")
        rstgest.RowFilter = "FCorte >= #" & Format(CFecha1, "yyyy-MM-dd") & "# AND FCorte <= #" & Format(CFecha2, "yyyy-MM-dd") & "#"
        rstgest.Sort = "FCorte"
        'Se manda a mostrar el reporte con los resultados del rst
        If rstgest.Count > 0 Then
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", rstgest))
            ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", ThisBanko("NombreBk").ToString))
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Else
            MsgBox("No se encontro nada para poder mostrar")
            Close()
        End If
    End Sub
End Class