Public Class RptClasifCreditoxClase
    Public Filter, Estado As String

    Public field As String
    Private Sub RptClasifCreditoxClase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rstBanko As New DataView
        Dim rstmovacumuladoh As New DataTable
        Dim rstmovacumuladom As New DataTable

        Dim tbl As String = "TipoCredito"
        Dim desc As String = "DescripClase"
        Dim credfield As String = "Tipo"
        If field = "CodClase" Then
            tbl = "TblClaseCredito"
            desc = "Descripcion"
            credfield = "Clase"
        End If

        rstBanko.Table = MainDSO.Tables("TblBanko")
        rstBanko.RowFilter = Filter

        'borra el contenido de la tabla para generar un nuevo reporte
        MainDSO.Tables("ClasifCreditos").Rows.Clear()

        'Se inicilizan todas las variables contenedoras de los resultados

        rstmovacumuladoh.Columns.Add("Clase", GetType(String))
        rstmovacumuladoh.Columns.Add("total", GetType(Double))
        rstmovacumuladoh.Columns.Add("t", GetType(Integer))
        rstmovacumuladoh.PrimaryKey = {rstmovacumuladoh.Columns("Clase")}
        rstmovacumuladom = rstmovacumuladoh.Clone
        For Each r As DataRowView In rstBanko
            Dim credito As New DataView
            credito.Table = MainDSO.Tables("TblCredito")
            credito.RowFilter = "VBK='" & r("CodBk") & "' AND IdOp=0"
            For Each c As DataRowView In credito
                If c(credfield) <> "" Then
                    If c("sexo").ToString.ToUpper = "M" Then
                        With rstmovacumuladoh
                            If .Rows.Contains(c(credfield)) Then
                                Dim row As DataRow = .Rows.Find(c(credfield))
                                row("total") += c("MontoCred")
                                row("t") += IIf(c.Row.IsNull("VBK"), 0, 1)
                            Else
                                .Rows.Add(c(credfield), c("MontoCred"), IIf(c.Row.IsNull("VBK"), 0, 1))
                            End If
                        End With
                    Else
                        With rstmovacumuladom
                            If .Rows.Contains(c(credfield)) Then
                                Dim row As DataRow = .Rows.Find(c(credfield))
                                row("total") += c("MontoCred")
                                row("t") += IIf(c.Row.IsNull("VBK"), 0, 1)
                            Else
                                .Rows.Add(c(credfield), c("MontoCred"), IIf(c.Row.IsNull("VBK"), 0, 1))
                            End If
                        End With
                    End If
                End If
            Next

        Next
        'Se almacen los registros encontrados de los creditos masculinos
        For Each x As DataRow In rstmovacumuladoh.Rows
            If MainDSO.Tables("ClasifCreditos").Rows.Contains(x("Clase")) Then
                Dim row As DataRow = MainDSO.Tables("ClasifCreditos").Rows.Find(x("Clase"))
                If row.IsNull("NTCM") Then row("NTCM") = 0
                If row.IsNull("NTSM") Then row("NTSM") = 0
                row("NTCM") += x("total")
                row("NTSM") += x("t")
            Else
                Dim row As DataRow = MainDSO.Tables("ClasifCreditos").NewRow
                row("NTCM") = x("total")
                row("NTSM") = x("t")
                row("CodTipo") = x("Clase")
                row("Descripcion") = MainDSO.Tables(tbl).Rows.Find(x("Clase"))(desc)
                MainDSO.Tables("ClasifCreditos").Rows.Add(row)
            End If
        Next


        'Se almacen los registros encontrados de los creditos femeninos
        For Each x As DataRow In rstmovacumuladom.Rows
            If MainDSO.Tables("ClasifCreditos").Rows.Contains(x("Clase")) Then
                Dim row As DataRow = MainDSO.Tables("ClasifCreditos").Rows.Find(x("Clase"))
                If row.IsNull("NTCF") Then row("NTCF") = 0
                If row.IsNull("NTSF") Then row("NTSF") = 0
                row("NTCF") += x("total")
                row("NTSF") += x("t")
            Else
                Dim row As DataRow = MainDSO.Tables("ClasifCreditos").NewRow
                row("NTCF") = x("total")
                row("NTSF") = x("t")
                row("CodTipo") = x("Clase")
                row("Descripcion") = MainDSO.Tables(tbl).Rows.Find(x("Clase"))(desc)
                MainDSO.Tables("ClasifCreditos").Rows.Add(row)
            End If
        Next

        'Se manda a mostrar el reporte con los resultados del rst
        If MainDSO.Tables("ClasifCreditos").Rows.Count > 0 Then
            ReportViewer1.LocalReport.DataSources.Clear()
            Dim params As New Microsoft.Reporting.WinForms.ReportParameterCollection()
            'params.Add(New Microsoft.Reporting.WinForms.ReportParameter("NombreBk", NBk))
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("Estado", Estado))
            Dim clase As Boolean = (credfield = "Clase")
            params.Add(New Microsoft.Reporting.WinForms.ReportParameter("Clase", clase))
            ReportViewer1.LocalReport.SetParameters(params)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Main", MainDSO.Tables("ClasifCreditos")))
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Else
            MsgBox("No existe nada que mostrar con los parametros seleccionados")
        End If
    End Sub
End Class