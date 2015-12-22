Option Strict Off
Option Explicit On
Friend Class VCC
    Inherits System.Windows.Forms.Form
    Private Nuevo As Integer
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim rstSoc As DataRow
		Dim cod As String
		Dim codigo As String
        Dim Socios As New CrearSocio
		Dim primerafecha As Date
		Dim prifecha As Date
		Dim ultimafecha As Date
		Dim existe As Short
		Dim existe2 As Short
		Dim mesgestion As Date
		If (TNumero.Text <> "") And (TCedula.Text <> "") And (TMonto.Text <> "") Then
			
			primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
			
            If ((Month(TFecha.Value) < Month(mesgestion)) And (Year(TFecha.Value) < Year(mesgestion))) Or ((Year(TFecha.Value) < Year(mesgestion))) Or ((Month(TFecha.Value) <= Month(mesgestion)) And (Year(TFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else

                If ((CDbl(TMonto.Text)) Mod ThisBanko("Val_nominal") = 0 And ((CDbl(TMonto.Text)) > 0)) Then

                    existe2 = BuscaLibro(TFecha.Value, CDbl(TNumero.Text), "VC", existe)
                    If (existe = 0) Then

                        'Verificar si el Socio existe o es nuevo
                        cod = TCedula.Text
                        codigo = codi
                        'Verifica si consiguio el socio
                        If MainDSO.Tables("TblSocios").Rows.Contains(cod) Then
                            rstSoc = MainDSO.Tables("TblSocios").Rows.Find(cod)
                            If (rstSoc("Estatus") = 1) Then
                                rstentrar = MainDSO.Tables("TblLibroIE").NewRow

                                'Registra la Operacion en el Libro IE
                                rstentrar("IdReg") = TNumero.Text
                                rstentrar("IdBK") = codi
                                rstentrar("fecha") = TFecha.Value
                                rstentrar("NoCredito") = 0
                                rstentrar("NoRecibo") = TNumero.Text
                                rstentrar("CI") = Trim(cod)
                                rstentrar("codope") = "VC"
                                rstentrar("Descripcion") = "Venta de Certificados"
                                rstentrar("Ingreso") = CDbl(TMonto.Text)
                                rstentrar("Egreso") = 0
                                rstentrar("Saldo") = ThisBanko("SaldoBk")

                                LibroAdd(rstentrar)

                                rstSoc("cap") = (CDbl(TMonto.Text) / ThisBanko("Val_nominal")) + rstSoc("cap")
                                If Nuevo = 1 Or rstSoc.IsNull("FIngreso") Then
                                    rstSoc("FIngreso") = TFecha.Value
                                End If

                                TNumero.Text = ""
                                TCedula.Text = ""
                                TMonto.Text = ""
                                Label58.Visible = False
                                Label1.Visible = False
                                Label2.Visible = False
                                fechas = Fcod(fechaU, ncod)
                                TNumero.Text = CStr(ncod)
                                Nuevo = 0

                            Else
                                MsgBox("NO se le puede vender Certificados a un Socio Retirado")
                            End If
                        Else
                            MsgBox("El socio no Existe pasara al modo Agregar Nuevo Socio")
                            cedula = TCedula.Text
                            Nuevo = 1
                            Socios.ShowDialog()
                        End If
                    Else
                        MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                    End If

                Else
                    MsgBox("Hay un error en el monto de la Venta de Certificados Reviselo")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim resp As Short
        Dim codigo As String
        codigo = codi
        If (Nuevo = 1) Then
            resp = MsgBox("ERROR" & vbCrLf & "No se permite registrar un Socio Nuevo sin Venderle Acciones. Si desea continuar el socio sera eliminado para que lo cargue posteriormente", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema")
            If (resp = 6) Then
                If MainDSO.Tables("TblSocios").Rows.Contains(TCedula.Text) Then
                    MainDSO.Tables("TblSocios").Rows.Find(TCedula.Text).Delete()
                End If
                TNumero.Text = ""
                TCedula.Text = ""
                TMonto.Text = ""
                TFecha.Value = Now
                Label58.Visible = False
                Label1.Visible = False
                Label2.Visible = False
                Me.Close()
            End If
        Else
            TNumero.Text = ""
            TCedula.Text = ""
            TMonto.Text = ""
            Label58.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Me.Close()
        End If

    End Sub

    Private Sub TCedula_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TCedula.SelectedIndexChanged
        Dim rstnombre As DataRow
        Dim rsttotalcap As Double = 0
        Dim codigo As String
        codigo = codi
        For Each r As DataRow In MainDSO.Tables("TblSocios").Rows
            rsttotalcap += CDbl(r("cap"))
        Next
        If MainDSO.Tables("TblSocios").Rows.Contains(TCedula.Text) Then
            rstnombre = MainDSO.Tables("TblSocios").Rows.Find(TCedula.Text)
            Label58.Text = "Nombre: " + rstnombre("Nombres")
            Label1.Text = "Acciones: " & Str(rstnombre("cap"))
            If rstnombre("cap") = 0 Then
                Label2.Text = "% Acciones: 0"
            Else
                Label2.Text = "% Acciones: " & VB6.Format((rstnombre("cap") * 100) / rsttotalcap, "###,##0.00")
            End If
            Label58.Visible = True
            Label1.Visible = True
            Label2.Visible = True
        Else
            Label58.Visible = False
            Label1.Visible = False
            Label2.Visible = False
        End If
    End Sub

	
	Private Sub TMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TMonto.Leave
		If (TMonto.Text <> "") Then
			TMonto.Text = VB6.Format(CDec(TMonto.Text), "###,##0.00")
		End If
	End Sub
	
	Private Sub TNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TNumero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			TFecha.Focus()
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

    Private Sub VCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TFecha.Value, ncod)
        TNumero.Text = ncod
        Dim v As New DataView
        v.Table = MainDSO.Tables("TblSocios")
        v.RowFilter = "Estatus=1"
        v.Sort = "CI"
        With TCedula.Items
            .Clear()
            For Each r As DataRowView In v
                .Add(r("CI"))
            Next
        End With
    End Sub
End Class