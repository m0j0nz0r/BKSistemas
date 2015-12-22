Option Strict Off
Option Explicit On
Friend Class Clave
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim i As Object
        Dim cadn, aux As String
		Dim cont As Short
		cont = 0
        cadn = ""
        aux = ""
		If (TLicencia.Text <> "") Then
			Dim textasciis(Len(TLicencia.Text)) As String
			For i = 1 To Len(TLicencia.Text)
				If Asc(Mid(TLicencia.Text, i, 1)) = 45 Then
					textasciis(cont) = Chr(CInt(cadn))
					aux = aux & Chr(CInt(cadn))
					cadn = ""
					cont = cont + 1
				Else
					cadn = cadn & (Mid(TLicencia.Text, i, 1))
					If i = Len(TLicencia.Text) And cadn <> "" Then
						textasciis(cont) = Chr(CInt(cadn))
						aux = aux & Chr(CInt(cadn))
					End If
				End If
			Next i
			Call EncryptStringDec((TSerial.Text), aux, 2)
		Else
			MsgBox("Clave *** NO AUTORIZADA***. " & vbCrLf & "Debe Introducir el Numero de la Licencia")
		End If
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
	Private Sub Clave_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim rstultimafecha As DataRow
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblLibroIE")
        view.Sort = "IdReg"
        rstultimafecha = view(view.Count - 1).Row
        TSerial.Text = rstultimafecha("IdReg")
		TCodBK.Text = codi
	End Sub
	
	Private Sub TLicencia_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TLicencia.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii >= 48) And (KeyAscii <= 57) Or (KeyAscii = 13) Or (KeyAscii = 8) Or (KeyAscii = 45) Then
			If (KeyAscii = 13) Then
				Command1.Focus()
			End If
		Else
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class