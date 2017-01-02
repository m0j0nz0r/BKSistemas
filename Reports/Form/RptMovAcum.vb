Public Class RptMovAcum
    Public filter As String = ""
    Public Estado As String
    Private Sub RptMovAcum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rstBanko As New DataView(MainDSO.TblBanko)
        Dim socios As New DataView(MainDSO.TblSocios)
        Dim creditos As New DataView(MainDSO.TblCredito)
        Dim gestion As New DataView(MainDSO.Gestion)
        Dim rstmovnew As MainDS.MovAcumuladoRow

        'Se buscan los bankos que pertenezcan a ese Estado
        rstBanko.RowFilter = filter

        'borra el contenido de la tabla para generar un nuevo reporte
        MainDSO.MovAcumulado.Rows.Clear()

        'Se busca el ultimo registro de la gestion que corresponda a los Bankos encontrados para ese Estado
        For Each r As DataRowView In rstBanko
            socios.RowFilter = "Estatus=1 AND CodBk='" & r("CodBk") & "'"
            creditos.RowFilter = "VBK='" & r("CodBk") & "' AND IdOp=0"
            gestion.RowFilter = "codBK='" & r("CodBk") & "'"
            gestion.Sort = "idgestion DESC"
            If socios.Count > 0 Then
                rstmovnew = MainDSO.MovAcumulado.NewRow
                rstmovnew.BanKo = r("CodBk") & " | " & r("NombreBk")
                rstmovnew.NTS = socios.Count
                rstmovnew.NTSM = MainDSO.TblSocios.Compute("Count(CI)", socios.RowFilter & " AND (Sexo='M' OR Sexo='m')")
                rstmovnew.NTSF = MainDSO.TblSocios.Compute("Count(CI)", socios.RowFilter & " AND (Sexo='F' OR Sexo='f')")
                rstmovnew.NTCAPS = MainDSO.TblSocios.Compute("Sum(cap)", socios.RowFilter)
                rstmovnew.NTCRED = creditos.Count
                If creditos.Count > 0 Then
                    rstmovnew.MCRED = MainDSO.TblCredito.Compute("Sum(MontoCred)", creditos.RowFilter)
                Else
                    rstmovnew.MCRED = 0
                End If
                If gestion.Count > 0 Then
                    rstmovnew.CIERRE = gestion(0)("FCorte")
                End If
                MainDSO.MovAcumulado.Rows.Add(rstmovnew)
            End If
        Next
        'Se manda a mostrar el reporte con los resultados del rst
        If MainDSO.MovAcumulado.Rows.Count > 0 Then
            Dim view As New DataView
            view.Table = MainDSO.MovAcumulado
            view.Sort = "Banko"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", Estado))
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", view.ToTable))
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Else
            MsgBox("No Existe nada que mostrar para el Estado seleccionado")
        End If
    End Sub
End Class