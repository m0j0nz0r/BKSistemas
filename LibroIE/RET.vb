Option Strict Off
Option Explicit On
'Imports Microsoft.VisualBasic.PowerPacks
Friend Class RET
    Inherits System.Windows.Forms.Form
    Private Function LibroNew() As DataRow
        Dim row As DataRow
        row = MainDSO.Tables("TblLibroIE").NewRow
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblLibroIE")
        view.Sort = "IdReg"
        row("IdReg") = CInt(view(view.Count - 1)("IdReg")) + 1
        row("IdBK") = codi
        row("fecha") = SQLDate(TRETFecha.Value)
        row("NoCredito") = 0
        row("CI") = CRETSocios.Text
        row("Saldo") = ThisBanko("SaldoBk")
        fechas = Fcod(fechaU, ncod)
        row("NoRecibo") = ncod
        Return row
    End Function
    Private Sub Command30_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command30.Click
        Dim cod As String = CRETSocios.Text.Trim
        Dim resp As Short = 0
        Dim rstCred As DataRow
        Dim Libro As New DataView
        Dim ok As Boolean = False
        Libro.Table = MainDSO.Tables("TblLibroIE")
        Libro.Sort = "Fecha,NoRecibo,IdReg"
        Dim row As DataRow
        RstSocio = Nothing
        RstSocio = MainDSO.TblSocios.FindByCI(cod)
        If RstSocio Is Nothing Then
            MsgBox("Error: Socio no existe...")
            Exit Sub
        End If
        Dim fechap, fechau, mes As Date
        fechaLIE(fechap, fechau, mes)
        mes = mes.AddDays(Date.DaysInMonth(mes.Year, mes.Month) - mes.Day)
        If TRETFecha.Value <= mes Then
            MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Exit Sub
        End If

        If (TRETLCNumero.Text <> "") And
            (TRETLCMonto.Text <> "") Then
            If ((TRETPCMonto.Text <> "") And (TRETPCNumero.Text <> "")) Then
                If (CDbl(Label81.Text) < CDbl(TRETPCMonto.Text)) Then
                    MsgBox("ERROR: El monto del Pago de la Cuota no debe ser Mayor al Saldo")
                    Exit Sub
                End If
            End If
            Dim view As New DataView
            If TRETPCMonto.Text = "" Then
                TRETPCMonto.Text = CStr(0)
            End If
            If (CDbl(TRETPCMonto.Text) <> CDbl(Label81.Text)) Then
                resp = MsgBox("OJO" & vbCrLf & "El Credito tiene un saldo MAYOR a Cero (0). Desea pasar el credito a incobrable?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema")
                If resp <> vbYes Then
                    MsgBox("Si no desea pasar a incobrables debe cancelar en su totalidad el saldo del credito")
                    Exit Sub
                End If
            End If

            'Operaciones comunes.
            'Se registra un LC
            ok = LC.LiquidarAcciones(CInt(TRETLCNumero.Text), TRETFecha.Value, cod, CDbl(TRETLCMonto.Text), "Ret. Liquidacion total Certif.")
            If Not ok Then Exit Sub

            If (TRETURMonto.Text = "") Then
                TRETURMonto.Text = CStr(0)
            End If
            If (CDbl(TRETURMonto.Text) > 0) Then
                'Se registra un UR
                row = LibroNew()
                row("codope") = "UR"
                row("Descripcion") = "Ret. Ganancias Repartidas"
                row("Ingreso") = 0
                row("Egreso") = (CDbl(TRETURMonto.Text))
                LibroAdd(row)
            End If

            If (TRETIFGMonto.Text = "") Then
                TRETIFGMonto.Text = CStr(0)
            End If

            If (CDbl(TRETIFGMonto.Text) > 0) Then

                'Se registra un IFG
                row = LibroNew()
                row("codope") = "IFG1"
                row("Descripcion") = "Ret. Ganancias Retenidas"
                row("Ingreso") = (CDbl(TRETIFGMonto.Text))
                row("Egreso") = 0
                LibroAdd(row)
                ThisBanko("SAFGASTOS") = ThisBanko("SAFGASTOS") + CDbl(TRETIFGMonto.Text)

            End If


            'Se Actualiza el total de Socios
            RstSocio("cap") = 0
            RstSocio.FRetiro = TRETFecha.Value
            RstSocio("Estatus") = 2

            'si el socio Tiene deuda
            If (CDbl(Label81.Text) <> 0) Then
                If CDbl(TRETPCMonto.Text = CDbl(Label81.Text) Or resp = vbYes) Then
                    'Se registra un PC
                    row = LibroNew()
                    row("codope") = "PC"
                    row("Descripcion") = "Ret. Pago de Cuotas"
                    row("Ingreso") = (CDbl(TRETPCMonto.Text))
                    row("Egreso") = 0
                    row("NoCredito") = Label80.Text
                    LibroAdd(row)
                    'Se registra un OR
                    If (TRETIOMonto.Text = "") Then
                        TRETIOMonto.Text = CStr(0)
                    End If
                    If CDbl(TRETIOMonto.Text) > 0 Then
                        row = LibroNew()
                        row("codope") = "OR"
                        row("Descripcion") = "Ret. Pago de OR"
                        row("Ingreso") = (CDbl(TRETIOMonto.Text))
                        row("Egreso") = 0
                        row("NoCredito") = Label80.Text
                        LibroAdd(row)
                    End If
                    If (TRETMOMonto.Text = "") Then
                        TRETMOMonto.Text = CStr(0)
                    End If
                    If CDbl(TRETMOMonto.Text) > 0 Then
                        'Se registra un MO
                        row = LibroNew()
                        row("codope") = "MO"
                        row("Descripcion") = "Ret. Int. de Mora"
                        row("Ingreso") = (CDbl(TRETMOMonto.Text))
                        row("Egreso") = 0
                        row("NoCredito") = Label80.Text
                        LibroAdd(row)
                    End If

                    'Se verifica si el socio puede Liquidar los CAPS por que no tiene deuda
                    view.Table = MainDSO.Tables("TblCredito")
                    view.RowFilter = "IdOp=0 AND Saldo>0 AND VCI='" & cod & "'"
                    Dim x As Double = 0
                    If view.Count > 0 Then
                        rstCred = view(0).Row
                        x = rstCred("Saldo") - CDbl(TRETPCMonto.Text)
                        rstCred("Saldo") = 0
                        If x > 0 Then
                            rstCred("incobrable") = 1
                            rstCred("Deuda") = x
                            RstSocio("deuda") = x
                            RstSocio("Estatus") = 3
                        End If
                        rstCred("FechaCancela") = SQLDate(TRETFecha.Value)
                        rstCred("Cancelado") = 1
                    End If
                    fechas = Fcod(fechaU, ncod)
                    TRETLCNumero.Text = CStr(ncod)
                End If
            End If

            fechas = Fcod(fechaU, ncod)
            TRETLCNumero.Text = CStr(ncod)
            Label79.Visible = False
            Label77.Visible = False
            Label78.Visible = False
            Label80.Visible = False
            Label81.Visible = False
            Label57.Visible = False
            Label1.Visible = False
            TRETPCMonto.Text = ""
            TRETPCNumero.Text = ""
            TRETIOMonto.Text = ""
            TRETMOMonto.Text = ""
            TRETIONumero.Text = ""
            TRETMONumero.Text = ""
            TRETLCMonto.Text = ""
            TRETIFGMonto.Text = ""
            TRETIFGNumero.Text = ""
            TRETURMonto.Text = ""
            TRETURNumero.Text = ""
            CRETSocios.Text = ""
            view.Table = MainDSO.Tables("TblSocios")
            view.RowFilter = "Estatus = 1"
            view.Sort = "CI"
            CRETSocios.Items.Clear()

            For Each r As DataRowView In view
                CRETSocios.Items.Add(r("CI"))
            Next
        Else
            MsgBox("ERROR: Debe Llenar todos los campos")
        End If

    End Sub

    Private Sub Command31_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command31.Click
        TRETFecha.Value = Now
        CRETSocios.Items.Clear()
        Label77.Visible = False
        Label78.Visible = False
        Label79.Visible = False
        Label80.Visible = False
        Label81.Visible = False
        Me.Close()
    End Sub
    Private Sub CRETSocios_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CRETSocios.SelectedIndexChanged
        Dim credito As New DataView
        Dim socios As New DataView
        credito.Table = MainDSO.Tables("TblCredito")
        Dim cod As String
        cod = CRETSocios.Text
        credito.RowFilter = "VCI ='" & cod & "' AND VBK='" & codi & "' AND Saldo > 0 AND IdOp=0"
        socios.Table = MainDSO.Tables("TblSocios")
        socios.RowFilter = "CI = '" + cod + "' AND CodBk='" + codi + "'"

        If credito.Count > 0 Then
            Label79.Text = "Acciones: " & Str(socios(0)("cap"))
            Label77.Text = "Nombres: " + socios(0)("Nombres")
            Label78.Text = "Cedula: " + socios(0)("CI")
            Label80.Text = Str(credito(0)("NoCredito"))
            Label81.Text = VB6.Format(credito(0)("Saldo"), "###,##0.00")
            TRETLCMonto.Text = VB6.Format(CDec(socios(0)("cap") * ThisBanko("Val_nominal")), "###,##0.00")
            Label79.Visible = True
            Label77.Visible = True
            Label78.Visible = True
            Label80.Visible = True
            Label81.Visible = True
            Label57.Visible = True
            Label1.Visible = True
            TRETPCNumero.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)
            TRETPCNumero.Enabled = True
            TRETPCMonto.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)
            TRETPCMonto.Enabled = True
            TRETIONumero.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)
            TRETIONumero.Enabled = True
            TRETIOMonto.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)
            TRETIOMonto.Enabled = True
            TRETMONumero.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)
            TRETMONumero.Enabled = True
            TRETMOMonto.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)
            TRETMOMonto.Enabled = True
        Else
            Label79.Text = "Acciones: " & Str(socios(0)("cap"))
            Label77.Text = "Nombres: " + socios(0)("Nombres")
            Label78.Text = "Cedula: " + socios(0)("CI")
            Label80.Text = "N/A"
            Label81.Text = "0,00"
            TRETLCMonto.Text = VB6.Format(CDec(socios(0)("cap") * ThisBanko("Val_nominal")), "###,##0.00")
            Label79.Visible = True
            Label77.Visible = True
            Label78.Visible = True
            Label80.Visible = True
            Label81.Visible = True
            Label57.Visible = True
            Label1.Visible = True
            TRETPCMonto.Text = ""
            'TRETPCNumero.Text = ""
            TRETIOMonto.Text = ""
            TRETMOMonto.Text = ""
            'TRETIONumero.Text = ""
            'TRETMONumero.Text = ""
            TRETPCNumero.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
            TRETPCNumero.Enabled = False
            TRETPCMonto.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
            TRETPCMonto.Enabled = False
            TRETIONumero.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
            TRETIONumero.Enabled = False
            TRETIOMonto.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
            TRETIOMonto.Enabled = False
            TRETMONumero.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
            TRETMONumero.Enabled = False
            TRETMOMonto.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
            TRETMOMonto.Enabled = False
        End If
    End Sub


	Private Sub CRETSocios_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CRETSocios.Leave
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblSocios")
        view.RowFilter = "CodBk = '" & codi & "' AND CI='" & CRETSocios.Text & "'"
        If (view.Count = 0) Then
            MsgBox("ERROR. Socio no Existe o esta retirado verifique la cedula")
        End If
	End Sub
	
	Private Sub TRETIFGMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETIFGMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETIFGMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TRETIFGMonto.Leave
		If (TRETIFGMonto.Text <> "") Then
			TRETIFGMonto.Text = VB6.Format(CDec(TRETIFGMonto.Text), "###,##0.00")
		End If
	End Sub
	
	Private Sub TRETIFGNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETIFGNumero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETIOMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETIOMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETIOMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TRETIOMonto.Leave
		If (TRETIOMonto.Text <> "") Then
			TRETIOMonto.Text = VB6.Format(CDec(TRETIOMonto.Text), "###,##0.00")
		End If
	End Sub
	
	Private Sub TRETIONumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETIONumero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETLCMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETLCMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETLCNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETLCNumero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETMOMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETMOMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETMOMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TRETMOMonto.Leave
		If (TRETMOMonto.Text <> "") Then
			TRETMOMonto.Text = VB6.Format(CDec(TRETMOMonto.Text), "###,##0.00")
		End If
	End Sub
	
	Private Sub TRETMONumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETMONumero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETPCMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETPCMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETPCMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TRETPCMonto.Leave
		If (TRETPCMonto.Text <> "") Then
			TRETPCMonto.Text = VB6.Format(CDec(TRETPCMonto.Text), "###,##0.00")
		End If
	End Sub
	
	Private Sub TRETPCNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETPCNumero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETURMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETURMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TRETURMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TRETURMonto.Leave
		If (TRETURMonto.Text <> "") Then
			TRETURMonto.Text = VB6.Format(CDec(TRETURMonto.Text), "###,##0.00")
		End If
	End Sub
	
	Private Sub TRETURNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRETURNumero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub

    Private Sub RET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RstSocio As New DataView
        RstSocio.Table = MainDSO.Tables("TblSocios")
        RstSocio.Sort = "CI"
        RstSocio.RowFilter = "Estatus=1"
        fechas = Fcod(fechaU, ncod)
        TRETFecha.Value = fechaU
        TRETLCNumero.Text = CStr(ncod)
        TRETURNumero.Text = ncod + 1
        TRETIFGNumero.Text = ncod + 2
        TRETPCNumero.Text = ncod + 3
        TRETIONumero.Text = ncod + 4
        TRETMONumero.Text = ncod + 5
        CRETSocios.Items.Clear()
        For Each r As DataRowView In RstSocio
            CRETSocios.Items.Add(r("CI"))
        Next

    End Sub
End Class