Option Strict Off
Option Explicit On
Friend Class Menu_Socios
    Inherits System.Windows.Forms.Form
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnSocios.Click
        Dim PanelSocios As New PanelSocios
        PanelSocios.ShowDialog()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnProtegidos.Click
        Dim Beneficiario As New PanelBeneficiario
        Beneficiario.ShowDialog()
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        gest = 0
        Me.Close()
    End Sub

    Private Sub Menu2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        gest = 0
        If My.Settings.DynamicPermits Then
            BtnSocios.Visible = (FindPermit(tuser, "PanelSociosSocios") = "1")
            LblSocios.Visible = BtnSocios.Visible
            BtnProtegidos.Visible = (FindPermit(tuser, "PanelSociosProtegidos") = "1")
            LblProtegidos.Visible = BtnProtegidos.Visible
        End If
    End Sub
End Class