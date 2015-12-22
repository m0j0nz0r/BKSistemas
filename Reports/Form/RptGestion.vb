Public Class RptGestion
    Public CFecha As Date
    Public t As DataTable
    Public cuadre As Boolean = False
    Private Sub RptGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ZRICBNETA As Double
        Dim rstLibro As DataRow
        Dim Fecha As Date
        Dim dia As String
        Dim mes As String
        Dim ano As String
        Dim codigo As String
        Dim safgastos As Double
        Dim MFC As Double
        Dim CFC As Double
        Dim mesletra As String
        Dim Finicio As Date
        If (CFecha <> CDate(Nothing)) Then
            codigo = codi
            Fecha = CFecha
            Finicio = Fecha
            dia = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Day, Fecha))
            mes = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Month, Fecha))
            ano = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Year, Fecha))
            'Dim view As New DataView
            Dim table As DataTable
            If cuadre Then
                table = MainDSO.Tables("gestiontemp")
            Else
                table = MainDSO.Tables("Gestion")
                Dim fi As New Date(Fecha.Year, Fecha.Month, 1)
                Dim ff As New Date(Fecha.Year, Fecha.Month, Date.DaysInMonth(Fecha.Year, Fecha.Month))
                table = (From row In table Where row("Finicio") >= fi AndAlso row("Finicio") <= ff).CopyToDataTable()
            End If
            rstLibro = table.Rows(0)
            'Mostrar encabezado en el Reporte
            mesletra = StrConv(MonthName(mes), VbStrConv.ProperCase)



            'Encabezado del Reporte de Gestion
            Dim params As New Microsoft.Reporting.WinForms.ReportParameterCollection()
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", ThisBanko("NombreBk").ToString))
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("FCorte", CFecha))
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("Mes", mesletra))


            safgastos = System.Math.Round(rstLibro("ZIFG1ACUM") - rstLibro("ZGBK1ACUM"), 2)
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("safgastos", VB6.Format(safgastos, "###,##0.00")))
            nominal = ThisBanko("Val_nominal")

            ZRICBNETA = rstLibro("ZRICBACUM") - rstLibro("ZICBACUM")
            MFC = System.Math.Round(((rstLibro("ZVCACUM") - rstLibro("ZLCACUM")) * nominal) + ZRICBNETA + rstLibro("ZMONTOGNORep") + safgastos, 2)
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("MFC", VB6.Format(MFC, "###,##0.00")))

            'Porcentaje de Colocacion del Fondo para Creditos
            CFC = System.Math.Round(((MFC - rstLibro("DECIERRE")) * 100) / MFC, 2)
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("CFC", VB6.Format(CFC, "###,##0.00")))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(params)
            Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", table))
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Else
            MsgBox("No se ha seleccionado una fecha!")
        End If
    End Sub
End Class