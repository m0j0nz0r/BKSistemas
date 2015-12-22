Public Class RptFiadores

    Private Sub RptFiadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tbl As New DataTable("Table1")
        tbl.Columns.Add("Nombres", GetType(String))
        tbl.Columns.Add("CI", GetType(String))
        tbl.Columns.Add("NoCredito", GetType(Integer))
        tbl.Columns.Add("cap", GetType(Integer))
        tbl.Columns.Add("CapsGarantia", GetType(Double))
        tbl.Columns.Add("porcentajegarantizado", GetType(Double))
        Dim fiadores As New DataView
        fiadores.Table = MainDSO.TblFiadores
        fiadores.RowFilter = "CapsGarantia>0 AND NOT (Observacion LIKE '%Anulado%')"
        Dim socios As New DataView
        socios.Table = MainDSO.TblSocios
        socios.RowFilter = "Estatus=1"
        For Each r As DataRowView In fiadores
            Dim s As DataRow = socios.ToTable.Select("CI='" & r("CI") & "'")(0)
            If r("CapsGarantia") > 0 Then
                tbl.Rows.Add({s("Nombres"), r("CI"), r("NoCredito"), s("cap"), r("CapsGarantia"), r("porcentajegarantizado")})
            End If
        Next
        Dim v As New DataView
        v.Table = tbl
        v.Sort = "CI"
        tbl = v.ToTable
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", ThisBanko("NombreBk").ToString))
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", tbl))
        
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class