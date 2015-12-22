Option Strict Off
Option Explicit On
Friend Class PDP
    Inherits System.Windows.Forms.Form
    Public NoCred As Double
    Private Sub Command32_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command32.Click
        Dim rstCred As DataRow
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim pdpsaldo As Double
        Dim mesgestion As Date

        If (TPDPNumero.Text <> "") And (TPDPCredito.Text <> "") And (TPDPMonto.Text <> "") Then

            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TPDPFecha.Value) < Month(mesgestion)) And (Year(TPDPFecha.Value) < Year(mesgestion))) Or ((Year(TPDPFecha.Value) < Year(mesgestion))) Or ((Month(TPDPFecha.Value) <= Month(mesgestion)) And (Year(TPDPFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TPDPFecha.Value, CDbl(TPDPNumero.Text), "PDP", existe)
                If (existe = 0) Then
                    If MainDSO.Tables("TblCredito").Rows.Contains({codi, TPDPCredito.Text}) Then
                        rstCred = MainDSO.Tables("TblCredito").Rows.Find({codi, TPDPCredito.Text})
                        'Se actualizan los datos en la tabla de creditos
                        pdpsaldo = rstCred.Item("TblCredito.deuda").Value - CDbl(TPDPMonto.Text)
                        If (pdpsaldo < 0) Then
                            MsgBox("ERROR: El monto es Mayor a la Deuda del credito")
                            Exit Sub
                        Else
                            If (pdpsaldo = 0) Then
                                rstCred("Saldo") = 0
                                rstCred("Cancelado") = 1
                                rstCred("Incobrable") = 0
                                rstCred("FechaCancela") = SQLDate(TPDPFecha.Value)
                                rstCred("Deuda") = 0
                                'rstCred("Estatus") = 4
                                MainDSO.Tables("TblSocios").Rows.Find(rstCred("VCI"))("saldo") = 0
                                'rstCred.Item("TblSocios.deuda").Value = 0
                            Else
                                rstCred("Deuda") = pdpsaldo
                                MainDSO.Tables("TblSocios").Rows.Find(rstCred("VCI"))("saldo") = pdpsaldo
                            End If
                        End If
                        'Registra la Operacion en el Libro IE
                        rstentrar = MainDSO.Tables("TblLibroIE").NewRow
                        rstentrar("IdBK") = codi
                        rstentrar("fecha") = SQLDate(TPDPFecha.Value)
                        rstentrar("NoCredito") = TPDPCredito.Text
                        rstentrar("NoRecibo") = TPDPNumero.Text
                        rstentrar("CI") = Trim(Label87.Text)
                        rstentrar("CodOpe") = "PDP"
                        rstentrar("Descripcion") = "Pago de Deuda Pendiente"
                        rstentrar("Ingreso") = CDbl(TPDPMonto.Text)
                        rstentrar("Egreso") = 0
                        rstentrar("Saldo") = ThisBanko("SaldoBk").Value
                        LibroAdd(rstentrar)
                        TPDPNumero.Text = ""
                        TPDPCredito.Text = ""
                        TPDPMonto.Text = ""
                        Label85.Visible = False
                        Label86.Visible = False
                        Label87.Visible = False
                        Label88.Visible = False
                        Label89.Visible = False
                        fechas = Fcod(fechaU, ncod)
                        TPDPNumero.Text = CStr(ncod)
                    Else
                        MsgBox("ERROR: El Credito Seleccionado no tiene Deuda Pendiente o No Existe. Verifique el Numero")
                    End If

                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub Command33_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command33.Click
        Me.Close()
        Label85.Visible = False
        Label86.Visible = False
        Label87.Visible = False
        Label88.Visible = False
        Label89.Visible = False
        TPDPCredito.Text = ""
        TPDPMonto.Text = ""
    End Sub

    Private Sub TPDPCredito_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TPDPCredito.SelectedIndexChanged
        Dim rstnombre, cred As DataRow
        Dim codigo As String
        codigo = codi
        cred = MainDSO.Tables("TblCredito").Rows.Find({codi, TPDPCredito.Text})
        If MainDSO.Tables("TblSocios").Rows.Contains(cred("VCI")) Then
            rstnombre = MainDSO.Tables("TblSocios").Rows.Find(cred("VCI"))
            Label85.Text = "Nombres: " + rstnombre("Nombres")
            Label88.Text = "Acciones: " & Str(rstnombre("cap"))
            Label89.Text = "Deuda: " & VB6.Format(cred("Deuda"), "###,##0.00")
            Label87.Text = rstnombre("CI")
            TPDPMonto.Text = VB6.Format(cred("Deuda"), "###,##0.00")
            Label85.Visible = True
            Label86.Visible = True
            Label87.Visible = True
            Label88.Visible = True
            Label89.Visible = True
        Else
            Label85.Visible = False
            Label86.Visible = False
            Label87.Visible = False
            Label88.Visible = False
            Label89.Visible = False
            TPDPMonto.Text = ""
        End If
    End Sub

	Private Sub TPDPMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TPDPMonto.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TPDPMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TPDPMonto.Leave
		If (TPDPMonto.Text <> "") Then
			TPDPMonto.Text = VB6.Format(CDec(TPDPMonto.Text), "###,##0.00")
		End If
	End Sub

    Private Sub PDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TPDPFecha.Value, ncod)
        TPDPNumero.Text = ncod
        Dim v As New DataView
        v.Table = MainDSO.Tables("TblCredito")
        v.Sort = "NoCredito"
        v.RowFilter = "incobrable=1"
        With TPDPCredito.Items
            .Clear()
            For Each r As DataRowView In v
                .Add(r("NoCredito"))
            Next
        End With
    End Sub
End Class