Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Gestion
    Inherits System.Windows.Forms.Form
    Private Sub Command2_Click()
        Me.Close()
    End Sub

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
            Dim rpt As New RptGestion

            If (Date.TryParse(CFecha.Text, rpt.CFecha)) Then
                rpt.ShowDialog()
            Else
                MsgBox("Error de fecha")
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim view As New DataView
        view.Table = MainDSO.Tables("Gestion")
        view.Sort = "FCorte"
        For Each r As DataRowView In view
            CFecha.Items.Add(r("FCorte"))
        Next

    End Sub

    Private Sub Gestion_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub
End Class