Option Strict Off
Option Explicit On
Friend Class Fecha3
	Inherits System.Windows.Forms.Form
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim rpt As New RptLibroIE
        rpt.CFechaI = Fecha1.Value
        rpt.CFechaF = Fecha2.Value
        rpt.ShowDialog()
    End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
End Class