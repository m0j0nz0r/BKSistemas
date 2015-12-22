Option Strict Off
Option Explicit On
Friend Class Menu_RptFinancieros
    Inherits System.Windows.Forms.Form
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnConsolidado.Click
        Dim filterDlg As New FilterDlg
        filterDlg.ShowDialog()
        If filterDlg.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim rpt As New Consolidado
            rpt.Estado = filterDlg.Estado
            rpt.Filter = filterDlg.Filter
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnTipo.Click
        Dim filterDlg As New FilterDlg
        filterDlg.ShowDialog()
        If filterDlg.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim rpt As New RptClasifCreditoxClase
            rpt.field = "Tipo"
            rpt.Estado = filterDlg.Estado
            rpt.Filter = filterDlg.Filter
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        Me.Close()
    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnClase.Click
        Dim filterDlg As New FilterDlg
        filterDlg.ShowDialog()
        If filterDlg.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim rpt As New RptClasifCreditoxClase
            rpt.field = "CodClase"
            rpt.Estado = filterDlg.Estado
            rpt.Filter = filterDlg.Filter
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnAcum.Click
        Dim filterDlg As New FilterDlg
        filterDlg.ShowDialog()
        If filterDlg.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim rpt As New RptMovAcum
            rpt.Estado = filterDlg.Estado
            rpt.filter = filterDlg.Filter
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub Menu_RptFinancieros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DynamicPermits Then
            BtnTipo.Visible = (FindPermit(tuser, "ReportesFinancierosCreditoxTipo") = "1")
            LblTipo.Visible = (FindPermit(tuser, "ReportesFinancierosCreditoxTipo") = "1")
            BtnClase.Visible = (FindPermit(tuser, "ReportesFinancierosCreditoxClase") = "1")
            LblClase.Visible = (FindPermit(tuser, "ReportesFinancierosCreditoxClase") = "1")
            BtnAcum.Visible = (FindPermit(tuser, "ReportesFinancierosMovimientoAcumulado") = "1")
            LblAcum.Visible = (FindPermit(tuser, "ReportesFinancierosMovimientoAcumulado") = "1")
            BtnConsolidado.Visible = (FindPermit(tuser, "ReportesFinancierosConsolidado") = "1")
            LblConsolidado.Visible = (FindPermit(tuser, "ReportesFinancierosConsolidado") = "1")
        End If
    End Sub
End Class