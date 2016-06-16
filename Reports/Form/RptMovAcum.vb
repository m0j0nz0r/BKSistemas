Public Class RptMovAcum
    Public filter As String = ""
    Public Estado As String
    Private Sub RptMovAcum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rstBanko As New DataView
        Dim rstmovacumulado As New DataView
        Dim rstmovnew As DataRow
        Dim Libro As New DataView
        Dim cuadre As New Cuadre

        Libro.Table = MainDSO.Tables("TblLibroIE")

        'Se buscan los bankos que pertenezcan a ese Estado
        rstBanko.Table = MainDSO.Tables("TblBanko")
        rstBanko.RowFilter = filter

        'borra el contenido de la tabla para generar un nuevo reporte

        MainDSO.Tables("MovAcumulado").Rows.Clear()
        'Se busca el ultimo registro de la gestion que corresponda a los Bankos encontrados para ese Estado
        rstmovacumulado.Table = MainDSO.Tables("Gestion")

        For Each r As DataRowView In rstBanko
            Debug.WriteLine("Begin: " & r("CodBk"))
            'Debug.WriteLine("Gestion count: " & rstmovacumulado.Count.ToString & " ID: " & rstmovacumulado(0)("idgestion"))
            cuadre.Calculate()
            Libro.RowFilter = "IdBK='" & r("CodBk") & "'"
            rstmovacumulado.RowFilter = "codBK='" & r("CodBk") & "'"
            rstmovacumulado.Sort = "idgestion DESC"
            If rstmovacumulado.Count > 0 Then
                rstmovnew = MainDSO.Tables("MovAcumulado").NewRow
                rstmovnew("Banko") = r("NombreBk")
                rstmovnew("NTSM") = rstmovacumulado(0)("NTSMACUM") - rstmovacumulado(0)("NTSMRACUM")
                rstmovnew("NTSF") = rstmovacumulado(0)("NTSFACUM") - rstmovacumulado(0)("NTSFRACUM")
                rstmovnew("NTS") = rstmovnew("NTSM") + rstmovnew("NTSF")
                rstmovnew("NTCAPS") = rstmovacumulado(0)("ZVCACUM") - rstmovacumulado(0)("ZLCACUM")
                rstmovnew("NTCRED") = rstmovacumulado(0)("qCONACUM") + rstmovacumulado(0)("qCORACUM")
                rstmovnew("CIERRE") = rstmovacumulado(0)("FCorte")
                'check this
                Dim zconacum As Double = 0
                Dim zcoracum As Double = 0
                For Each q As DataRowView In rstmovacumulado
                    zconacum += q("ZCON")
                    zcoracum += q("ZCOR")
                Next
                Debug.WriteLine("ZCOR: " & zconacum & " | ZCON: " & zcoracum & "| Total: " & (zconacum + zcoracum))
                Debug.WriteLine("ZCOR: " & rstmovacumulado(0)("ZCONACUM") & " | ZCON: " & rstmovacumulado(0)("ZCORACUM") & "| Total: " & (rstmovacumulado(0)("ZCONACUM") + rstmovacumulado(0)("ZCORACUM")))
                rstmovnew("MCRED") = rstmovacumulado(0)("ZCONACUM") + rstmovacumulado(0)("ZCORACUM")
                MainDSO.Tables("MovAcumulado").Rows.Add(rstmovnew)
                MainDSO.Tables("Gestion").Rows.Remove(rstmovacumulado(0).Row)
                Debug.WriteLine("Gestion count: " & rstmovacumulado.Count.ToString & " ID: " & rstmovacumulado(0)("idgestion"))
            Else
                Debug.WriteLine("Skipped: " & r("CodBk"))
            End If
        Next
        'Se manda a mostrar el reporte con los resultados del rst
        If MainDSO.Tables("MovAcumulado").Rows.Count > 0 Then
            Dim view As New DataView
            view.Table = MainDSO.Tables("MovAcumulado")
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