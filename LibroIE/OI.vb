Option Strict Off
Option Explicit On
Friend Class OI
	Inherits System.Windows.Forms.Form
 
    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
        TIONumero.Text = ""
        TIOMonto.Text = ""
        Me.Close()
    End Sub

    Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
        Dim primerafecha As Date
        Dim prifecha As Date
        Dim ultimafecha As Date
        Dim existe As Short
        Dim existe2 As Short
        Dim mesgestion As Date

        If (TIONumero.Text <> "") And (TIOMonto.Text <> "") Then
            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TIOFecha.Value) < Month(mesgestion)) And (Year(TIOFecha.Value) < Year(mesgestion))) Or ((Year(TIOFecha.Value) < Year(mesgestion))) Or ((Month(TIOFecha.Value) <= Month(mesgestion)) And (Year(TIOFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TIOFecha.Value, CDbl(TIONumero.Text), "OI", existe)
                If (existe = 0) Then
                    'Registra la Operacion en el Libro IE
                    rstentrar = MainDSO.Tables("TblLibroIE").NewRow
                    rstentrar("IdBK") = codi
                    rstentrar("fecha") = SQLDate(TIOFecha.Value)
                    rstentrar("NoCredito") = 0
                    rstentrar("NoRecibo") = TIONumero.Text
                    rstentrar("CI") = "----------"
                    rstentrar("codope") = "OI"
                    rstentrar("Descripcion") = "Otros Ingresos Repartibles"
                    rstentrar("Ingreso") = CDbl(TIOMonto.Text)
                    rstentrar("Egreso") = 0
                    rstentrar("Saldo") = ThisBanko("SaldoBk")
                    LibroAdd(rstentrar)
                    TIONumero.Text = ""
                    TIOMonto.Text = ""
                    fechas = Fcod(fechaU, ncod)
                    TIONumero.Text = CStr(ncod)
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe Completar todos los Datos")
        End If

    End Sub
	
	Private Sub TIOMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TIOMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TIOMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TIOMonto.Leave
		If (TIOMonto.Text <> "") Then
			TIOMonto.Text = VB6.Format(CDec(TIOMonto.Text), "###,##0.00")
		End If
	End Sub
	
	Private Sub TIONumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TIONumero.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			TIOFecha.Focus()
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

    Private Sub OI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TIOFecha.Value, ncod)
        TIONumero.Text = ncod
    End Sub
End Class