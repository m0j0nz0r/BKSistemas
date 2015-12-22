Public Class RptCreditosActivos
    Public CFecha As Date
    Private Sub RptCreditosActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tbl As New DataTable("Table1")
        tbl.Columns.Add("Nombres", GetType(String))
        tbl.Columns.Add("CI", GetType(String))
        tbl.Columns.Add("NoCredito", GetType(Integer))
        tbl.Columns.Add("Fecha", GetType(Date))
        tbl.Columns.Add("FechaVence", GetType(Date))
        tbl.Columns.Add("MontoCred", GetType(Double))
        tbl.Columns.Add("Saldo", GetType(Double))
        tbl.Columns.Add("IdOp", GetType(Byte))

        For Each r As DataRow In MainDSO.Tables("TblCredito").Rows
            Dim s As DataRow = MainDSO.Tables("TblSocios").Rows.Find(r("VCI"))
            tbl.Rows.Add({s("Nombres"), r("VCI"), r("NoCredito"), r("Fecha"), r("FechaVence"), r("MontoCred"), r("Saldo"), r("IdOp")})
        Next
        Dim v As New DataView
        v.Table = tbl
        v.Sort = "FechaVence"
        v.RowFilter = "FechaVence > #" & Format(CFecha, "yyyy-MM-dd") & "# AND Saldo > 0 AND IdOp=0"
        tbl = v.ToTable
        If tbl.Rows.Count > 0 Then
            ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", ThisBanko("NombreBk").ToString))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", tbl))
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Else
            MsgBox("No hay ningun Credito Vigente para mostrar")
            Close()
        End If
    End Sub
End Class