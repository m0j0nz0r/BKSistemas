Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Balance
	Inherits System.Windows.Forms.Form
	Private Sub CFecha_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles CFecha.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			Command1.Focus()
		Else
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        If (CFecha.Text <> "") Then
            Dim rpt As New RptBalance
            rpt.CFecha = CDate(CFecha.Text)
            rpt.ShowDialog()
        End If
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub Balance_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim Gestion As New DataView
        Gestion.Table = MainDSO.Tables("Gestion")
        Gestion.Sort = "FCorte"
        For Each r As DataRowView In Gestion
            CFecha.Items.Add(r("FCorte"))
        Next
    End Sub
End Class