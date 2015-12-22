Public Class RptMovi
    Public SocCedu As String = ""
    Private Sub RptMovi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rstcreditosvence As New DataView
        Dim rstSoc As DataRow
        If (SocCedu <> "") Then
            'Consulta los datos del socio. recoge el nombre
            rstSoc = MainDSO.Tables("TblSocios").Rows.Find(SocCedu)

            'Se calculan los Creditos Vencidos
            rstcreditosvence.Table = MainDSO.Tables("TblLibroIE")
            rstcreditosvence.RowFilter = "Anulado=0 and CI='" + SocCedu + "'"
            rstcreditosvence.Sort = "Fecha ASC, NoRecibo ASC"

            'Se manda a mostrar el reporte con los resultados del rst
            If rstcreditosvence.Count > 0 Then
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", rstcreditosvence))
                Dim params As New System.Collections.Generic.List(Of Microsoft.Reporting.WinForms.ReportParameter)
                params.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", ThisBanko("NombreBk").ToString))
                params.Add(New Microsoft.Reporting.WinForms.ReportParameter("Nombre", rstSoc("Nombres").ToString))
                ReportViewer1.LocalReport.SetParameters(params)
                ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Else
                MsgBox("No hay ningun movimiento en el Libro asociado a esta cedula")
            End If
        Else
            MsgBox("Debe seleccionar un Socio de la Lista para visualizar sus Movimientos")
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class