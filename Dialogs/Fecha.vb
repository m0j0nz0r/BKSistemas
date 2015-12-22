Option Strict Off
Option Explicit On
Friend Class Fecha
    Inherits System.Windows.Forms.Form
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim rpt As New RptCreditosVencidos
        rpt.CFecha = CFecha.Value
        rpt.ShowDialog()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub Fecha_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        CFecha.Value = Now
    End Sub
End Class