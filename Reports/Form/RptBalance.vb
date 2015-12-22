Public Class RptBalance
    Public cuadre As Boolean = False
    Public CFecha As Date
    Private Sub RptBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim codigo As String
        codigo = codi
        Dim Gestion As DataTable
        If cuadre Then
            Gestion = MainDSO.Tables("gestiontemp")
        Else
            Gestion = MainDSO.Tables("Gestion")
            Dim fi As New Date(CFecha.Year, CFecha.Month, 1)
            Dim ff As New Date(CFecha.Year, CFecha.Month, Date.DaysInMonth(CFecha.Year, CFecha.Month))
            Gestion = (From row In Gestion Where row("Finicio") >= fi AndAlso row("Finicio") <= ff).CopyToDataTable()

        End If
        If Gestion.Rows.Count > 0 Then
            Dim rstLibro As DataRow = Gestion.Rows(0)
            Dim rstBanko As DataRow = ThisBanko
            Dim rpt As Microsoft.Reporting.WinForms.LocalReport
            Dim params As New Microsoft.Reporting.WinForms.ReportParameterCollection()
            rpt = ReportViewer1.LocalReport
            rpt.DataSources.Clear()
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", ThisBanko("NombreBk").ToString))
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("mes", MonthName(CFecha.Month)))
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("ValNominal", CDbl(ThisBanko("Val_Nominal"))))
            rpt.SetParameters(params)
            rpt.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", Gestion))
        End If
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class