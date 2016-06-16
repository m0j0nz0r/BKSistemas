Option Strict Off
Option Explicit On
Friend Class CONNUEVO
    Inherits System.Windows.Forms.Form


    Private Function CheckFiadoresDuplicados() As Boolean
        Dim retval As Boolean = (TCONFiador1.Text <> TCONFIador2.Text) Or (TCONFiador1.Text = "") Or (TCONFIador2.Text = "")
        If Not retval Then
            MsgBox("Los Fiadores no pueden ser Iguales cambielos y guarde nuevamente")
        End If
        Return retval
    End Function
    Private Function CheckEmptyFields() As Boolean
        Dim retval As Boolean = (TCONNumero.Text <> "") And (TCONMonto.Text <> "") And (TCONCedula.Text <> "") And (TTasaOR.Text <> "") And (TTasaMO.Text <> "") And (TCONTipoC.Text <> "") And (TCONFrecuencia.Text <> "")
        If Not retval Then
            MsgBox("Debe llenar todos los campos...")
        End If
        Return retval
    End Function
    Private Function CheckSocioFiador() As Boolean
        Dim retval As Boolean = (TCONFiador1.Text <> TCONCedula.Text) Or (TCONFIador2.Text <> TCONCedula.Text)
        If Not retval Then
            MsgBox("Los Fiadores no pueden iguales al Socio cambielos y guarde nuevamente")
        End If
        Return retval
    End Function
    Private Function CheckFiador(cedula As String) As Integer
        If cedula = "" Then
            Return 0
        Else
            If MainDSO.TblSocios.Rows.Contains(cedula) Then
                If MainDSO.TblSocios.FindByCI(cedula).Estatus = 1 Then
                    Return 0
                End If
            End If
        End If
        MsgBox("El Fiador con la cedula " & cedula & " no esta registrado o esta RETIRADO verifique la Cedula")
        Return 1
    End Function
    Private Function CheckPendingCredit(Cedula As String) As Double
        Dim view As New DataView
        Dim retval As Double
        view.Table = MainDSO.TblCredito
        view.RowFilter = "VCI='" & Cedula & "' AND IdOp=0"
        If view.Count = 0 Then
            retval = 0
        Else
            retval = CDbl(MainDSO.TblCredito.Compute("SUM(Saldo)", "VCI = '" & Cedula & "' AND IdOp=0"))
        End If

        If retval > 0 Then
            MsgBox("El Socio con cedula: " & Cedula & ", tiene un credito con Saldo Pendiente no puede otorgar un Nuevo Credito.!")
        End If
        Return retval
    End Function
    Private Function CheckSocio(cedula As String, ByRef row As MainDS.TblSociosRow) As Boolean
        Dim retval As Boolean = False
        If MainDSO.TblSocios.Rows.Contains(cedula) Then
            row = MainDSO.TblSocios.FindByCI(cedula)
            If row.Estatus = 1 Then retval = True
        End If
        If Not retval Then MsgBox("Socio CI: " & cedula & ", no Registrado o se encuentra RETIRADO Verifique la Cedula ")
        Return retval
    End Function
    Private Function CheckMaxAmount(monto As Double) As Boolean
        Dim retval As Boolean = ThisBanko.MontoMaximo >= monto
        If Not retval Then MsgBox("EL Monto para el Otorgamiento supera el Monto Maximo establecido en el reglamento")
        Return retval
    End Function
    Private Function CapsLeft(ByRef caps As Double, ByRef mr As String) As Boolean
        Dim retval As Boolean = False
            If (caps <= 0) Then
                If (MsgBox("IMPORTANTE" & vbCrLf & "Socio es Fiador de otro(s) Crédito(s) y no le quedan Acciones suficientes para garantizar su propio crédito", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema") = 6) Then
                    mr = "AR"
                Else
                    retval = True
            End If
        End If
        Return retval
    End Function
    Private Function CapsAvail(ByRef garantia As Double,
                               ByRef caps As Double) As Boolean
        Dim retval = False
        garantia = ((caps * ThisBanko("Val_nominal")) / (CDbl(TCONMonto.Text)) * 100)
        If (garantia < ThisBanko("Caps-Creditos")) Then
            If (MsgBox("IMPORTANTE" & vbCrLf & "El Socio no tiene Acciones disponibles suficientes (Es decir, Acciones que posee - Acciones que ha comprometido como Fiador) para cumplir con la Relación Acciones-Créditos que establece el Reglamento Desea registrar crédito de todos modos? (S/N)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema") <> MsgBoxResult.Yes) Then
                retval = True
            End If
        End If
        Return retval
    End Function

    Public Function GetRiesgo(credito As MainDS.TblCreditoRow) As String
        Dim Garantizado As Double = 0
        Dim retval As String = ""
        Garantizado += CalcCapsDisp(credito.VCI)
        Dim Fiadores As New DataView
        Fiadores.Table = MainDSO.TblFiadores
        Fiadores.RowFilter = "NoCredito='" & credito.NoCredito & "'"
        If Fiadores.Count > 0 Then
            Garantizado += Fiadores(0)("CapsGarantia")
            If Fiadores.Count > 1 Then
                Garantizado += Fiadores(1)("CapsGarantia")
            End If
        End If
        Dim GarantiaNecesaria As Double = (credito.MontoCred / ThisBanko.Val_nominal) * (ThisBanko.GarantiaFiador + ThisBanko._Caps_Creditos) / 100
        If Garantizado >= GarantiaNecesaria Then
            retval = "BR"
        ElseIf Garantizado >= GarantiaNecesaria * 0.75 Then
            retval = "MR"
        Else
            retval = "AR"
        End If
        Return retval
    End Function
    Public Function CapsGarantia(cedula As String) As Double
        Dim retval As Double = 0
        Dim Fiadores As New DataView
        Fiadores.Table = MainDSO.TblFiadores
        Fiadores.RowFilter = "NOT (Observacion LIKE '%Anulado%') AND CI ='" & cedula & "'"

        If Fiadores.Count > 0 Then
            For Each r As DataRowView In Fiadores
                retval += Double.Parse(r("CapsGarantia"))
            Next
        End If

        Return retval
    End Function
    Public Function CalcCapsDisp(cedula As String) As Double
        Dim retval As Double = 0
        If Not MainDSO.TblSocios.Rows.Contains(cedula) Then
            MsgBox("El socio CI: " & cedula & "no existe o está retirado.")
            Return 0
        End If
        Dim rstcapsFiador1 As MainDS.TblSociosRow = MainDSO.TblSocios.FindByCI(cedula)

        Dim Credito As New DataView
        Credito.Table = MainDSO.Tables("TblCredito")
        Credito.RowFilter = "IdOp=0 AND Saldo > 0 AND VCI = '" & cedula & "'"
        If Credito.Count > 0 Then
            Dim rstFiador As DataRow
            Dim capscomprometidos As Double

            rstFiador = Credito.Item(0).Row
            capscomprometidos = System.Math.Round((rstFiador("Saldo") * ThisBanko("Caps-Creditos")) / (100 * ThisBanko("Val_nominal")), 0)
            retval = rstcapsFiador1("cap") - capscomprometidos
        Else
            retval = rstcapsFiador1("cap")
        End If

        retval -= CapsGarantia(cedula)

        Return retval
    End Function
    Private Function Fiador(ByRef capsfiador As Double,
                       ByRef capsrequeridosfiador As Double,
                       ByRef garantiasuficiente As Double,
                       ByVal ncredito As Double,
                       ByRef capsfiador1 As Double,
                       ByRef porcentajegarantizado1 As Double,
                       cedula As String) As Boolean

        capsfiador = CalcCapsDisp(cedula)

        If (capsfiador < capsrequeridosfiador) Then
            garantiasuficiente = 0
        Else
            capsfiador = capsrequeridosfiador
            garantiasuficiente = 1
        End If

        If (capsfiador <= 0) Then
            If (MsgBox("IMPORTANTE" & vbCrLf & "Fiador con cedula " & cedula & " tiene crédito pendiente por pagar o es fiador de otro(s) crédito(s) y tiene todas sus acciones comprometidos, por ahora no puede ser Fiador de otro crédito ¿Desea registrar crédito sin Fiador? (S/N)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema") <> MsgBoxResult.Yes) Then
                Return True
            End If
        Else
            If (garantiasuficiente = 0 And capsfiador1 > 0) Then
                If (MsgBox("IMPORTANTE" & vbCrLf & "Garantia de Socio, Fiador1 y Fiador2 NO SUFICIENTES, Desea registrar credito con garantia insuficiente (S/N)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema") <> MsgBoxResult.Yes) Then
                    Return True
                End If
            End If
        End If

        capsfiador1 = capsfiador

        If (capsfiador > 0) Then
            porcentajegarantizado1 = System.Math.Round(((capsfiador * ThisBanko("Val_nominal")) * 100) / (CDbl(TCONMonto.Text)), 2)
            Dim row As DataRow = MainDSO.Tables("TblFiadores").NewRow()
            row("CodBk") = codi
            row("CI") = cedula
            row("NoCredito") = ncredito
            row("CapsGarantia") = capsfiador
            row("porcentajegarantizado") = System.Math.Round(((capsfiador * ThisBanko("Val_nominal")) * 100) / (CDbl(TCONMonto.Text)), 2)
            If (garantiasuficiente = 0) Then
                row("Observacion") = "No tiene las Garantias Suficientes"
            Else
                row("Observacion") = ""
            End If

            MainDSO.Tables("TblFiadores").Rows.Add(row)
        Else
            porcentajegarantizado1 = 0
            capsfiador = 0
        End If
        Return False
    End Function
    Private Function GetCapsGarantiaTotal(CI As String) As Double
        Dim FiadoresView As New DataView
        Dim retval As Double
        FiadoresView.Table = MainDSO.Tables("TblFiadores")
        FiadoresView.RowFilter = "CI='" & CI & "'"
        If FiadoresView.Count > 0 Then
            retval = CDbl(MainDSO.Tables("TblFiadores").Compute("SUM(CapsGarantia)", "CI ='" & CI & "'"))
        Else
            retval = 0
        End If
        Return retval
    End Function
   
    Private Sub Command34_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command34.Click
        Dim porgarantiafiador As Double
        Dim rstCreditoNew As DataRow
        Dim rstFiador As Double = 0
        Dim rstSoc As MainDS.TblSociosRow = Nothing
        Dim RstEquivalenteClase As DataRow
        Dim caps As Double
        Dim resp As Short
        Dim marcariezgo As String = ""
        Dim garantia As Double
        Dim capsrequeridosfiador As Double
        Dim garantiasuficiente As Double
        Dim capsfiador As Double
        Dim ncredito As Double
        Dim primerafecha As Date
        Dim prifecha As Date
        Dim ultimafecha As Date
        Dim existe As Short
        Dim existe2 As Short
        Dim mesgestion As Date
        Dim porcentajegarantizado1 As Double
        Dim porcentajegarantizado2 As Double
        Dim capsfiador1 As Double

        If CheckEmptyFields() And
            CheckFiadoresDuplicados() And
            CheckSocioFiador() And
            CheckSocio(TCONCedula.Text, rstSoc) And
            CheckPendingCredit(TCONCedula.Text) = 0 And
            CheckFiador(TCONFiador1.Text) + CheckFiador(TCONFIador2.Text) = 0 And
            CheckMaxAmount(CDbl(TCONMonto.Text)) Then

            If (CONFecha.Value >= CONFechaVence.Value) Then
                MsgBox("La Fecha de Otorgamiento no debe ser mayor a la Fecha de Vencimiento. Verifique las Fechas")
            Else
                primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
                If ((Month(CONFecha.Value) < Month(mesgestion)) And (Year(CONFecha.Value) < Year(mesgestion))) Or ((Year(CONFecha.Value) < Year(mesgestion))) Or ((Month(CONFecha.Value) <= Month(mesgestion)) And (Year(CONFecha.Value) = Year(mesgestion))) Then
                    MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
                Else
                    existe2 = BuscaLibro(CONFecha.Value, CDbl(TCONNumero.Text), "CON", existe)
                    If (existe = 0) Then
                        Dim nfiadores As Integer = 0
                        rstFiador = GetCapsGarantiaTotal(TCONCedula.Text)

                        ncredito = CDbl(NumCredito.Text)

                        caps = rstSoc("cap")

                        If rstFiador > 0 Then caps -= rstFiador

                        If CapsLeft(caps, marcariezgo) Then Exit Sub

                        If CapsAvail(garantia, caps) Then Exit Sub

                        porgarantiafiador = ThisBanko("Caps-Creditos") + ThisBanko("GarantiaFiador")
                        capsrequeridosfiador = (CDbl(TCONMonto.Text) * ThisBanko("GarantiaFiador")) / (100 * ThisBanko("Val_nominal"))
                        garantiasuficiente = 0

                        If ((garantia > 100) Or (garantia = 100)) Then
                            garantiasuficiente = 1
                            MsgBox("Este crédito no requiere Fiador, los Caps del Socio son suficiente garantía")
                        Else
                            If (TCONFiador1.Text = "") Then
                                If MsgBox("IMPORTANTE" & vbCrLf & "No hay Fiador y los Acciones del Socio no garantizan el Crédito. ¿Desea registrar crédito sin Fiador? (S/N)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema") <> MsgBoxResult.Yes Then
                                    Exit Sub
                                End If
                            Else
                                'Modulo de Fiadores con el Fiador N° 1
                                Fiador(capsfiador, capsrequeridosfiador, garantiasuficiente, ncredito, capsfiador1, porcentajegarantizado1, TCONFiador1.Text)
                                nfiadores = 1
                            End If
                        End If


                        If (garantiasuficiente = 0) Then
                            capsrequeridosfiador = capsrequeridosfiador - capsfiador
                            If (TCONFIador2.Text = "") Then
                                resp = MsgBox("IMPORTANTE" & vbCrLf & "No hay  Segundo Fiador y las Acciones del Socio + Acciones de Fiador 1 no garantizan el Crédito. ¿Desea registrar crédito sin Fiador 2? (S/N)", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema")
                                If (resp <> MsgBoxResult.Yes) Then
                                    If MainDSO.TblFiadores.Rows.Contains({codi, ncredito, TCONFiador1.Text}) Then
                                        MainDSO.TblFiadores.Rows.Find({codi, ncredito, TCONFiador1.Text}).Delete()
                                    End If
                                    Exit Sub
                                End If
                            Else
                                'Modulo de Fiadores 2
                                Fiador(capsfiador, capsrequeridosfiador, garantiasuficiente, ncredito, capsfiador1, porcentajegarantizado2, TCONFIador2.Text)
                                nfiadores = 2
                            End If
                        Else
                            If (TCONFIador2.Text <> "") Then
                                MsgBox("No se Requiere un Segundo Fiador,   sus datos serán descartados")
                            End If
                        End If

                        'Registro de la Operacion en el Libro de IE
                        'Se actualiza el Saldo en la tabla de Bankos
                        ThisBanko("SaldoBk") = ThisBanko("SaldoBk") - CDbl(TCONMonto.Text)

                       
                        'Se agrega el credito en la tabla de creditos
                        rstCreditoNew = MainDSO.Tables("TblCredito").NewRow

                        rstCreditoNew("VBk") = codi
                        rstCreditoNew("VCI") = TCONCedula.Text
                        rstCreditoNew("fecha") = SQLDate(CONFecha.Value)
                        rstCreditoNew("MontoCred") = CDbl(TCONMonto.Text)
                        rstCreditoNew("Saldo") = CDbl(TCONMonto.Text)
                        rstCreditoNew("NoCredito") = ncredito
                        'Se guarda la clase de credito
                        rstCreditoNew("Clase") = TCONTipoC.Text.Split(" | ")(0)
                        'Antes de Guardar la clase de credito se debe buscar su equivalente de tipo de credito
                        Dim view As New DataView
                        view.Table = MainDSO.Tables("TblClaseCredito")
                        view.RowFilter = "CodClase = '" & TCONTipoC.Text.Split(" | ")(0) & "'"
                        RstEquivalenteClase = view.Item(0).Row
                        rstCreditoNew("tipo") = RstEquivalenteClase.Item("TipoCreidito")
                        rstCreditoNew("TasaIO") = TTasaOR.Text
                        rstCreditoNew("TasaMO") = TTasaMO.Text
                        rstCreditoNew("Riezgo") = marcariezgo
                        rstCreditoNew("Fechavence") = SQLDate(CONFechaVence.Value)
                        rstCreditoNew("Sexo") = rstSoc("Sexo")
                        rstCreditoNew("IdOp") = 0
                        If (TCONFrecuencia.Text = "Semanal") Then
                            rstCreditoNew("frecuencia") = 7
                        Else
                            If (TCONFrecuencia.Text = "Quincenal") Then
                                rstCreditoNew("frecuencia") = 15
                            Else
                                rstCreditoNew("frecuencia") = 30
                            End If
                        End If
                        rstCreditoNew("Riezgo") = GetRiesgo(rstCreditoNew)

                        MainDSO.Tables("TblCredito").Rows.Add(rstCreditoNew)

                        'Registra la Operacion en el Libro IE
                        Dim row As DataRow = MainDSO.Tables("TblLibroIE").NewRow
                        row("IdBK") = codi
                        row("fecha") = SQLDate(CONFecha.Value)
                        row("NoCredito") = ncredito
                        row("NoRecibo") = TCONNumero.Text
                        row("CI") = TCONCedula.Text
                        If (COR = 1) Then
                            row("CodOpe") = "COR"
                        Else
                            row("CodOpe") = "CON"
                        End If
                        row("Descripcion") = "Otorgamiento de Credito"
                        row("Ingreso") = 0
                        row("Egreso") = CDbl(TCONMonto.Text)
                        row("Saldo") = ThisBanko("SaldoBk")
                        LibroAdd(row)
                        TCONNumero.Text = ""
                        TCONMonto.Text = ""
                        TCONCedula.Text = ""
                        TCONFiador1.Text = ""
                        TCONFIador2.Text = ""
                        TTasaOR.Text = ""
                        TTasaMO.Text = ""
                        TCONTipoC.Text = ""
                        TCONFrecuencia.Text = ""
                        Label38.Visible = False
                        Label39.Visible = False
                        Label41.Visible = False
                        Label42.Visible = False
                        Label100.Visible = False
                        Label108.Visible = False
                        fechas = Fcod(fechaU, ncod)
                        TCONNumero.Text = CStr(ncod)
                        NumCredito.Text = CStr(CDbl(NumCredito.Text) + 1)
                    End If
                    End If
            End If
        End If
    End Sub

    Private Sub Command35_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command35.Click
        TCONNumero.Text = ""
        TCONMonto.Text = ""
        TCONCedula.Text = ""
        TCONFiador1.Text = ""
        TCONFIador2.Text = ""
        TTasaOR.Text = ""
        TTasaMO.Text = ""
        TCONTipoC.Text = ""
        TCONFrecuencia.Text = ""
        Label38.Visible = False
        Label39.Visible = False
        Label41.Visible = False
        Label42.Visible = False
        Me.Close()
    End Sub

    Private Sub NumCredito_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles NumCredito.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TCONMonto.Focus()
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
    Private Sub FillCedula(cedula As String, ByRef label1 As Label, ByRef label2 As Label)
        If MainDSO.Tables("TblSocios").Rows.Contains(cedula) Then
            Dim i As DataRow = MainDSO.Tables("TblSocios").Rows.Find(cedula)
            label1.Text = "Nombre: " + i("Nombres")
            label2.Text = "Acciones: " & Str(i("cap"))
            label1.Visible = True
            label2.Visible = True
        Else
            label1.Visible = False
            label2.Visible = False
        End If

    End Sub
    Private Sub TCONCedula_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TCONCedula.SelectedIndexChanged
        FillCedula(TCONCedula.Text, Label38, Label39)
    End Sub


    Private Sub TCONFiador1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TCONFiador1.SelectedIndexChanged
        FillCedula(TCONFiador1.Text, Label41, Label100)
    End Sub


    Private Sub TCONFIador2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TCONFIador2.SelectedIndexChanged
        FillCedula(TCONFIador2.Text, Label42, Label108)
    End Sub


    Private Sub TCONFrecuencia_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCONFrecuencia.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            CONFechaVence.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TCONMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCONMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TCONMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TCONMonto.Leave
        If (TCONMonto.Text <> "") Then
            TCONMonto.Text = VB6.Format(CDec(TCONMonto.Text), "###,###.00")
        End If

    End Sub

    Private Sub TCONNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCONNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            CONFecha.Focus()
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

    Private Sub TCONTipoC_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TCONTipoC.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TCONFrecuencia.Focus()
        Else
            KeyAscii = 0
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TTasaMO_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TTasaMO.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TCONTipoC.Focus()
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

    Private Sub TTasaOR_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TTasaOR.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TTasaMO.Focus()
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

    Private Sub CONNUEVO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AutoCompleteCedulas As New AutoCompleteStringCollection
        Dim Socios As New DataView
        Socios.Table = MainDSO.Tables("TblSocios")
        Socios.RowFilter = "Estatus=1"
        Socios.Sort = "CI"
        For Each r As DataRowView In Socios
            AutoCompleteCedulas.Add(r("CI"))
        Next
        TCONCedula.AutoCompleteCustomSource = AutoCompleteCedulas
        TCONFiador1.AutoCompleteCustomSource = AutoCompleteCedulas
        TCONFIador2.AutoCompleteCustomSource = AutoCompleteCedulas

        Fcod(CONFecha.Value, ncod) 'Fecha y numero de operacion
        TCONNumero.Text = ncod
        Dim creditos As New DataView          'numero de credito 
        creditos.Table = MainDSO.Tables("TblCredito")
        creditos.Sort = "NoCredito DESC"
        If creditos.Count > 0 Then
            NumCredito.Text = creditos(0)("NoCredito") + 1
        Else
            NumCredito.Text = 1
        End If

        TCONTipoC.Items.Clear()
        For Each r As MainDS.TblClaseCreditoRow In MainDSO.TblClaseCredito.Rows
            TCONTipoC.Items.Add(r.CodClase & " | " & r.Descripcion)
        Next

        For Each r As DataRowView In Socios
            TCONCedula.Items.Add((r("CI")))
            TCONFiador1.Items.Add((r("CI")))
            TCONFIador2.Items.Add((r("CI")))
        Next

        'Se cargan los Intereses Ordinarios en los Combos
        TTasaOR.Items.Add(ThisBanko("TasaIO1"))
        TTasaOR.Items.Add(ThisBanko("TasaIO2"))

        'Se cargan los Intereses de Mora
        TTasaMO.Items.Add(ThisBanko("TasaM1"))
        TTasaMO.Items.Add(ThisBanko("TasaM2"))

    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs)

    End Sub
End Class