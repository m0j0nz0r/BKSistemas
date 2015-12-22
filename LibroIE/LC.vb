Option Strict Off
Option Explicit On
Friend Class LC
    Inherits System.Windows.Forms.Form

    Public Function LiquidarAcciones(IdReg As Integer, Fecha As Date, Socio As String, Monto As Double, Desc As String) As Boolean
        Dim RstSocio As MainDS.TblSociosRow = MainDSO.TblSocios.FindByCI(Socio)

        Dim LCaps As Double = Monto / ThisBanko.Val_nominal
        If RstSocio Is Nothing Then
            Return False
        Else
            'Se actualizan los datos del socio.
            RstSocio.cap = RstSocio.cap - LCaps
            RstSocio.CapLiq = RstSocio.CapLiq + LCaps
            'Verifica que sus caps no estén garantizando un crédito.
            Dim CapsFiador As Double = CONNUEVO.CapsGarantia(Socio)
            Dim CapsDisponibles As Double = CONNUEVO.CalcCapsDisp(Socio)
            If CapsDisponibles < 0 Then
                Dim CapsNecesarios As Double = CapsDisponibles * -1
                If CapsFiador > 0 Then
                    If vbYes <> MsgBox("El socio está liquidando acciones que están garantizando otros créditos en calidad de fiador. ¿Seguro que desea continuar?", MsgBoxStyle.YesNo) Then
                        Return False
                    End If
                    If CapsNecesarios > CapsFiador Then
                        If vbYes <> MsgBox("El socio está liquidando acciones que están garantizando su propio crédito.", MsgBoxStyle.YesNo) Then
                            Return False
                        End If
                    End If
                End If

                
                'Recalcular riesgo del crédito.
                Dim Creditos As New Generic.List(Of String)
                Dim view As New DataView
                view.Table = MainDSO.TblFiadores
                view.RowFilter = "CI='" & Socio & "'"
                For Each r As DataRowView In view
                    If Not Creditos.Contains(r("NoCredito")) Then
                        Creditos.Add(r("NoCredito"))
                    End If
                Next
                Dim creditorow As MainDS.TblCreditoRow
                For Each r As String In Creditos
                    creditorow = MainDSO.TblCredito.Rows.Find({codi, r})
                    If creditorow.Saldo > 0 And creditorow.IdOp = 0 Then
                        PC.RecalcularFiadores(CDbl(r), False)
                        creditorow.Riezgo = CONNUEVO.GetRiesgo(creditorow)
                    End If
                Next
            End If


            rstentrar = MainDSO.Tables("TblLibroIE").NewRow
            rstentrar("IdReg") = IdReg
            rstentrar("IdBK") = codi
            rstentrar("fecha") = SQLDate(Fecha)
            rstentrar("NoCredito") = 0
            rstentrar("NoRecibo") = IdReg
            rstentrar("CI") = Socio
            rstentrar("codope") = "LC"
            rstentrar("Descripcion") = Desc
            rstentrar("Ingreso") = 0
            rstentrar("Egreso") = Monto
            rstentrar("Saldo") = ThisBanko("SaldoBk")

            LibroAdd(rstentrar)

        End If
        Return True
    End Function
    Private Sub Command24_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command24.Click
        Dim LCaps As Double
        Dim cod As String
        Dim primerafecha As Date
        Dim prifecha As Date
        Dim ultimafecha As Date
        Dim existe As Short
        Dim existe2 As Short
        Dim mesgestion As Date


        If ((TLCNumero.Text <> "") And (TLCCedula.Text <> "") And (TLCMonto.Text <> "")) Then

            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TLCFecha.Value) < Month(mesgestion)) And (Year(TLCFecha.Value) < Year(mesgestion))) Or ((Year(TLCFecha.Value) < Year(mesgestion))) Or ((Month(TLCFecha.Value) <= Month(mesgestion)) And (Year(TLCFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                If ((CDbl(TLCMonto.Text)) Mod ThisBanko("Val_nominal") = 0) Then
                    existe2 = BuscaLibro(TLCFecha.Value, CDbl(TLCNumero.Text), "LC", existe)
                    If (existe = 0) Then
                        cod = TLCCedula.Text.Trim
                        'Se Calcula el Numero de Caps que se Liquidaran
                        LCaps = CDbl(TLCMonto.Text) / ThisBanko("Val_nominal")
                        'Se verifica si el socio puede liquidar esa cantidad de caps
                        RstSocio = MainDSO.Tables("TblSocios").Rows.Find(cod)
                        If RstSocio("Estatus") = "1" Then
                            If (RstSocio("cap") = LCaps) Then
                                MsgBox("Si el socio está liquidando todos sus Acciones, se debe realizar una operación de Retiro, Código de Op. = RET")
                            Else
                                If (RstSocio("cap") < LCaps) Then
                                    MsgBox("ERROR: No se pueden Liquidar mas Acciones de los que posee el Socio ")
                                Else
                                    LiquidarAcciones(TLCNumero.Text, TLCFecha.Value, cod, CDbl(TLCMonto.Text), "Liquidacion de Certificados")
                                    'Se realiza el registro de egreso en el Libro de I/E
                                    TLCNumero.Text = ""
                                    TLCCedula.Text = ""
                                    TLCMonto.Text = ""
                                    Label59.Visible = False
                                    Label1.Visible = False
                                    fechas = Fcod(fechaU, ncod)
                                    TLCNumero.Text = CStr(ncod)
                                End If
                            End If
                        Else
                            MsgBox("El Socio no Existe o Esta Retirado. No se puede Liquidar Los Certificados. Verifique la Cedula")
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

    Private Sub Command25_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command25.Click
        TLCNumero.Text = ""
        TLCCedula.Text = ""
        TLCMonto.Text = ""
        Label59.Visible = False
        Label1.Visible = False
        Me.Close()
    End Sub

    Private Sub TLCCedula_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TLCCedula.SelectedIndexChanged
        Dim rstnombre As DataRow
        If MainDSO.Tables("TblSocios").Rows.Contains(TLCCedula.Text) Then
            rstnombre = MainDSO.Tables("TblSocios").Rows.Find(TLCCedula.Text)
            Label59.Text = "Nombre: " + rstnombre("Nombres")
            Label1.Text = "Acciones: " & Str(rstnombre("cap"))
            Label59.Visible = True
            Label1.Visible = True
        Else
            Label59.Visible = False
            Label1.Visible = False
        End If
    End Sub

    Private Sub TLCMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TLCMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TLCMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TLCMonto.Leave
        If (TLCMonto.Text <> "") Then
            TLCMonto.Text = VB6.Format(CDec(TLCMonto.Text), "###,###.00")
        End If
    End Sub

    Private Sub TLCNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TLCNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TLCFecha.Focus()
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

    Private Sub LC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TLCFecha.Value, ncod)
        TLCNumero.Text = ncod
        Dim v As New DataView
        v.Table = MainDSO.Tables("TblSocios")
        v.RowFilter = "Estatus=1"
        v.Sort = "CI"
        With TLCCedula.Items
            .Clear()
            For Each r As DataRowView In v
                .Add(r("CI"))
            Next
        End With
    End Sub
End Class