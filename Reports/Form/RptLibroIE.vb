Public Class RptLibroIE

    Public CFechaI As Date
    Public CFechaF As Date
    Private Sub RptLibroIE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rstBanko As DataRow

        'Consulta los datos generales del Banko
        rstBanko = ThisBanko
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblLibroIE")
        view.RowFilter = "Fecha >= #" & Format(CFechaI, "yyyy-MM-dd") & "# AND Fecha <= #" & Format(CFechaF, "yyyy/MM/dd") & "#"
        view.Sort = "Fecha ASC, NoRecibo ASC, IdReg ASC"
        Dim tbl As DataTable = view.ToTable
        'Se manda a mostrar el reporte con los resultados del rst
        If view.Count > 0 Then
            ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", ThisBanko("NombreBk").ToString))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", tbl))
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Else
            MsgBox("No hay ningun Movimiento que mostrar para esas fechas")
            Close()
        End If
    End Sub
End Class