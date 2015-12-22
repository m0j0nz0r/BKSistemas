Option Strict Off
Option Explicit On
Friend Class FechaRendimiento
	Inherits System.Windows.Forms.Form
	Private Sub Combo1_Change()
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim rpt As New RptRendimiento
        rpt.CFecha1 = Date.Parse(Fecha1.Text)
        rpt.CFecha2 = Date.Parse(Fecha2.Text)
        rpt.ShowDialog()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub Fecha1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Fecha1.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            Fecha2.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Fecha2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Fecha2.KeyPress
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

    Private Sub FechaRendimiento_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim rstLibro As New DataView
        Dim codigo As String
        codigo = codi
        rstLibro.Table = MainDSO.Tables("Gestion")
        rstLibro.Sort = "FCorte"
        For Each r As DataRowView In rstLibro
            Fecha1.Items.Add(r("FCorte"))
            Fecha2.Items.Add(r("FCorte"))
        Next
    End Sub
End Class