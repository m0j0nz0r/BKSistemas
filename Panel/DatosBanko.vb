Option Strict Off
Option Explicit On
Friend Class DatosBanko
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Close()
	End Sub
	
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnGuardar.Click
        Dim rstentrar As DataRow
        rstentrar = ThisBanko

        If (TPRF.Text <> "") And (TPRPxM.Text <> "") And (TPRGxR.Text <> "") And (TTasaIO1.Text <> "") And (TTasaIO2.Text <> "") And (TTasaMora1.Text <> "") And (TTasaMora2.Text <> "") And (TMMaximo.Text <> "") And (TGarant_Fiador.Text <> "") And (TPlazo.Text <> "") Then
            rstentrar.Item("PRFG") = TPRF.Text
            rstentrar.Item("PRI") = TPRPxM.Text
            rstentrar.Item("PRGR") = TPRGxR.Text
            rstentrar.Item("TasaIO1") = CDbl(TTasaIO1.Text)
            rstentrar.Item("TasaIO2") = CDbl(TTasaIO2.Text)
            rstentrar.Item("TasaM1") = CDbl(TTasaMora1.Text)
            rstentrar.Item("TasaM2") = CDbl(TTasaMora2.Text)
            rstentrar.Item("MontoMaximo") = CDbl(TMMaximo.Text)
            rstentrar.Item("Caps-Creditos") = TCaps_Creditos.Text
            rstentrar.Item("GarantiaFiador") = TGarant_Fiador.Text
            rstentrar.Item("Plazo") = CDbl(TPlazo.Text)
            rstentrar.Item("PRFP") = CDbl(PRFP.Text)
            MsgBox("Registro Actualizado Exitosamente..!!")
        Else
            MsgBox("ERROR: No puede dejar ningun campo vacio complete los valores")
        End If
    End Sub

    Private Sub DatosBanko_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim rstVC As Double = 0
        Dim rstLC As Double = 0
        Dim rstZCON As Double = 0
        Dim rstqCON As Double = 0
        Dim codigo As String

        BtnGuardar.Enabled = FindPermit(tuser, "DatosBankoGuardar")

        codigo = Trim(codi)
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblSocios")
        view.RowFilter = "Estatus=1"
        For Each r As DataRowView In view
            rstVC += IIf(r.Row.IsNull("cap"), 0, r("cap"))
        Next
        view.Table = MainDSO.Tables("TblLibroIE")
        view.RowFilter = "CodOpe = 'LC' or CodOpe = 'LCC' and Anulado=0"
        For Each r As DataRowView In view
            rstLC += IIf(r.Row.IsNull("Egreso"), 0, r("Egreso"))
        Next
        view.RowFilter = "CodOpe = 'CON'"
        For Each r As DataRowView In view
            If Not r.Row.IsNull("Egreso") Then
                rstZCON += r("Egreso")
                rstqCON += 1
            End If
        Next
        Dim municipio As MainDS.TblMunicipiosRow = MainDSO.Tables("TblMunicipios").Rows.Find(ThisBanko.Item("Municipio"))
        Dim estado As MainDS.TblEstadosRow = MainDSO.Tables("TblEstados").Rows.Find(municipio("EID"))
        Dim pais As MainDS.TblPaisesRow = MainDSO.Tables("TblPaises").Rows.Find(estado("PID"))

        txtnombre.Text = ThisBanko.Item("NombreBk")
        txtcodigo.Text = ThisBanko.Item("CodBk")
        txtestado.Text = estado("Nombre")
        txtmunicipio.Text = municipio("Municipios")
        TxtFecha.Text = ThisBanko.Item("FechaI")
        TPRF.Text = ThisBanko.Item("PRFG")
        TPRPxM.Text = ThisBanko.Item("PRI")
        TPRGxR.Text = ThisBanko.Item("PRGR")
        If (rstVC <> 0) Then
            TCAPS.Text = rstVC
        Else
            TCAPS.Text = CStr(0)
        End If
        If (rstZCON <> 0) Then
            TZCON.Text = VB6.Format(rstZCON, "###,##0.00")
        Else
            TZCON.Text = CStr(0)
        End If
        If (rstqCON <> 0) Then
            TQCON.Text = rstqCON
        Else
            TQCON.Text = CStr(0)
        End If
        TxtPais.Text = pais("Nombre")
        TxtMoneda.Text = ThisBanko.Item("Moneda")
        TxtVal_cap.Text = ThisBanko.Item("Val_nominal")
        TTasaIO1.Text = ThisBanko.Item("TasaIO1")
        TTasaIO2.Text = ThisBanko.Item("TasaIO2")
        TTasaMora1.Text = ThisBanko.Item("TasaM1")
        TTasaMora2.Text = ThisBanko.Item("TasaM2")
        TMMaximo.Text = ThisBanko.Item("MontoMaximo")
        TCaps_Creditos.Text = ThisBanko.Item("Caps-Creditos")
        TGarant_Fiador.Text = ThisBanko.Item("GarantiaFiador")
        TPlazo.Text = ThisBanko.Item("Plazo")
        PRFP.Text = ThisBanko.Item("PRFP")
    End Sub

    Private Sub TCaps_Creditos_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCaps_Creditos.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TMMaximo.Focus()
        Else
            If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TCAPS_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCAPS.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        KeyAscii = 0
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Text2_KeyPress(ByRef KeyAscii As Short)
        If (KeyAscii = 13) Then
            TTasaIO1.Focus()
        Else
            If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
                KeyAscii = 0
            End If
        End If
    End Sub

    Private Sub TGarant_Fiador_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TGarant_Fiador.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TPRF.Focus()
        Else
            If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TMMaximo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TMMaximo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TTasaMora1.Focus()
        Else
            If ((KeyAscii < 44) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TPlazo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TPlazo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TTasaIO1.Focus()
        Else
            If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TPRF_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TPRF.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TPRPxM.Focus()
        Else
            If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TPRGxR_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TPRGxR.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            BtnGuardar.Focus()
        Else
            If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
                KeyAscii = 0
            End If
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	Private Sub TPRPxM_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TPRPxM.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			TPRGxR.Focus()
		Else
			If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
				KeyAscii = 0
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TQCON_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TQCON.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TTasaIO1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TTasaIO1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			TTasaIO2.Focus()
		Else
			If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
				KeyAscii = 0
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TTasaIO2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TTasaIO2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			TCaps_Creditos.Focus()
		Else
			If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
				KeyAscii = 0
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TTasaMora1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TTasaMora1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			TTasaMora2.Focus()
		Else
			If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
				KeyAscii = 0
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TTasaMora2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TTasaMora2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			TGarant_Fiador.Focus()
		Else
			If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
				KeyAscii = 0
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtcodigo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtestado_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtestado.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtFecha_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtFecha.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtMoneda_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoneda.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub txtmunicipio_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtmunicipio.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtNombre_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtPais_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtPais.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtVal_cap_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtVal_cap.TextChanged
		Dim KeyAscii As Object
		KeyAscii = 0
	End Sub
	
	Private Sub TxtVal_cap_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtVal_cap.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TZCON_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TZCON.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		KeyAscii = 0
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class