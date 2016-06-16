Public Class RptSocios

    Private Sub RptViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblSocios")
        view.Sort = "Nombres"
        view.RowFilter = "Estatus=1 AND (Sexo='M' OR Sexo='m')"
        Dim TotalHombres = view.Count
        view.RowFilter = "Estatus=1 AND (Sexo='F' OR Sexo='f')"
        Dim TotalMujeres = view.Count
        view.RowFilter = "Estatus=1"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("TblSocios", view.ToTable()))
        Dim p As New Microsoft.Reporting.WinForms.ReportParameterCollection()
        Dim param As New Microsoft.Reporting.WinForms.ReportParameter("Bankomunal", ThisBanko("NombreBk").ToString())
        p.Add(param)
        param = New Microsoft.Reporting.WinForms.ReportParameter("Activos", True)
        p.Add(param)
        param = New Microsoft.Reporting.WinForms.ReportParameter("TotalHombres", TotalHombres.ToString)
        p.Add(param)
        param = New Microsoft.Reporting.WinForms.ReportParameter("TotalMujeres", TotalMujeres.ToString)
        p.Add(param)
        Try
            ReportViewer1.LocalReport.SetParameters(p)
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0} \nTrace:{1}", ex.Message, ex.StackTrace))
        End Try
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class