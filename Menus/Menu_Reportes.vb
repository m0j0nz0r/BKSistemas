Option Strict Off
Option Explicit On
Friend Class Menu_Reportes
    Inherits System.Windows.Forms.Form
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnFiadores.Click
        Dim rpt As New RptFiadores
        rpt.ShowDialog()
    End Sub

    Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnRendimiento.Click
        Dim FechaRendimiento As New FechaRendimiento
        FechaRendimiento.ShowDialog()
    End Sub

    Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnFondo.Click
        Dim rpt As New RptFondo
        rpt.ShowDialog()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnSociosActivos.Click
        Dim rpt As New RptSocios
        rpt.ShowDialog()
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnGestion.Click
        Dim Gestion As New Gestion
        Gestion.ShowDialog()
    End Sub

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnBalance.Click
        Dim Balance As New Balance
        Balance.ShowDialog()
    End Sub

    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        Me.Close()
    End Sub

    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnVencidos.Click
        Dim Fecha As New Fecha
        Fecha.CFecha.Value = Now
        Fecha.ShowDialog()
    End Sub

    Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnLibroIE.Click
        Dim Fecha3 As New Fecha3
        Fecha3.Fecha1.Value = Now
        Fecha3.Fecha2.Value = Now
        Fecha3.ShowDialog()
    End Sub

    Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnVigentes.Click
        Dim Fecha2 As New Fecha2
        Fecha2.Fecha.Value = Now
        Fecha2.ShowDialog()

    End Sub

    Private Sub Menu_Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DynamicPermits Then
            BtnSociosActivos.Visible = (FindPermit(tuser, "PanelReportesSociosActivos") = "1") And ForceSelect
            LblSociosActivos.Visible = BtnSociosActivos.Visible
            BtnGestion.Visible = (FindPermit(tuser, "PanelReportesGestion") = "1") And ForceSelect
            LblGestion.Visible = BtnGestion.Visible
            BtnBalance.Visible = (FindPermit(tuser, "PanelReportesBalance") = "1") And ForceSelect
            LblBalance.Visible = BtnBalance.Visible
            BtnFiadores.Visible = (FindPermit(tuser, "PanelReportesFiadores") = "1") And ForceSelect
            LblFiadores.Visible = BtnFiadores.Visible
            BtnVencidos.Visible = (FindPermit(tuser, "PanelReportesCreditosVencidos") = "1") And ForceSelect
            LblVencidos.Visible = BtnVencidos.Visible
            BtnVigentes.Visible = (FindPermit(tuser, "PanelReportesCreditosVigentes") = "1") And ForceSelect
            LblVigentes.Visible = BtnVigentes.Visible
            BtnLibroIE.Visible = (FindPermit(tuser, "PanelReportesLibroIE") = "1") And ForceSelect
            LblLibroIE.Visible = BtnLibroIE.Visible
            BtnRendimiento.Visible = (FindPermit(tuser, "PanelReportesRendimiento") = "1") And ForceSelect
            LblRendimiento.Visible = BtnRendimiento.Visible
            BtnFondo.Visible = (FindPermit(tuser, "PanelReporteFondoProteccion") = "1") And ForceSelect
            LblFondo.Visible = BtnBalance.Visible
        End If
    End Sub
End Class
