Option Strict Off
Option Explicit On
Friend Class MO
    Inherits System.Windows.Forms.Form
    Public reg As Double
    Public moexiste As Short
 
    Private Sub Command28_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command28.Click
        Dim rstCreditos As DataRow
        Dim rstNumCreditos As New DataView
        Dim rstTipoCredito As New DataView
        Dim rstnombres As New DataView
        Dim rstnombre As DataRow
        If (COR = 1) Then
            Dim form As New CONNUEVO
            rstNumCreditos.Table = MainDSO.Tables("TblCredito")
            rstNumCreditos.Sort = "NoCredito"
            rstTipoCredito.Table = MainDSO.Tables("TipoCredito")
            rstTipoCredito.Sort = "DescripClase"
            rstnombres.Table = MainDSO.Tables("TblSocios")
            rstnombres.RowFilter = "Estatus=1"
            rstnombres.Sort = "CI"

            'se verifica si hay fiador

            If (CDbl(fiador1) <> 0) Then
                If MainDSO.Tables("TblSocios").Rows.Contains(fiador1) Then
                    rstnombre = MainDSO.Tables("TblSocios").Rows.Find(fiador1)
                    Form.Label41.Text = "Nombre: " + rstnombre("Nombres")
                    Form.Label100.Text = "Acciones: " & Str(rstnombre("cap"))
                    Form.Label41.Visible = True
                    Form.Label100.Visible = True
                    Form.TCONFiador1.Text = fiador1
                End If
            End If

            If (CDbl(fiador2) <> 0) Then
                If MainDSO.Tables("TblSocios").Rows.Contains(fiador2) Then
                    rstnombre = MainDSO.Tables("TblSocios").Rows.Find(fiador2)
                    Form.Label42.Text = "Nombre: " + rstnombre("Nombres")
                    Form.Label108.Text = "Acciones: " & Str(rstnombre("cap"))
                    Form.Label42.Visible = True
                    Form.Label108.Visible = True
                    Form.TCONFIador2.Text = fiador2
                End If
            End If

            For Each r As DataRowView In rstnombres
                form.TCONCedula.Items.Add((r("CI")))
                form.TCONFiador1.Items.Add((r("CI")))
                form.TCONFIador2.Items.Add((r("CI")))
            Next

            For Each r As DataRowView In rstTipoCredito
                form.TCONTipoC.Items.Add((r("Clase")))
            Next


            rstTasas = ThisBanko

            'Se cargan los Intereses Ordinarios en los Combos
            Form.TTasaOR.Items.Add(rstTasas("TasaIO1"))
            Form.TTasaOR.Items.Add(rstTasas("TasaIO2"))


            Dim credito As New DataView
            credito.Table = MainDSO.Tables("TblCredito")
            credito.RowFilter = "NoCredito='" + TMOCredito.Text + "'"
            credito.Sort = "NoCredito"
            rstCreditos = credito(0).Row
            If (rstCreditos("TasaIO") <> "") Then
                Form.TTasaMO.Text = rstCreditos("TasaIO")
            End If
            If (rstCreditos("TasaMO") <> "") Then
                Form.TTasaOR.Text = rstCreditos("TasaMO")
            End If

            If (rstCreditos("frecuencia") <> "") Then
                If (rstCreditos("frecuencia") = 7) Then
                    Form.TCONFrecuencia.Text = "Semanal"
                Else
                    If (rstCreditos("frecuencia") = 15) Then
                        Form.TCONFrecuencia.Text = "Quincenal"
                    Else
                        Form.TCONFrecuencia.Text = "Mensual"
                    End If
                End If
            End If

            'Se cargan los Intereses de Mora
            Form.TTasaMO.Items.Add(rstTasas("TasaM1"))
            Form.TTasaMO.Items.Add(rstTasas("TasaM2"))
            Form.NumCredito.Text = rstNumCreditos(rstNumCreditos.Count - 1)("NoCredito").Value + 1

            fechas = Fcod(fechaU, ncod)
            Form.CONFecha.Value = fechaU
            Form.TCONNumero.Text = CStr(ncod)
            Form.TCONCedula.Enabled = False





            Form.TCONCedula.Text = rstCreditos("VCI")
            rstnombre = MainDSO.Tables("TblSocios").Rows.Find(rstCreditos.Item("VCI"))

            Form.Label38.Text = "Nombre: " + rstnombre("Nombres")
            Form.Label39.Text = "Acciones: " & Str(rstnombre("cap"))
            Form.Label38.Visible = True
            Form.Label39.Visible = True

            Form.TCONMonto.Text = VB6.Format(corsaldo, "###,##0.00")
            If (rstCreditos("Clase") <> "") Then
                form.TCONTipoC.Text = rstCreditos("Clase")
            End If
            Form.Text = "::: BKSistema - COR :::"
            Me.Close()
            Form.ShowDialog()
            Exit Sub

        End If
        TMONumero.Text = ""
        TMOCredito.Text = ""
        TMOMonto.Text = ""
        Label65.Visible = False
        Label66.Visible = False
        Label67.Visible = False
        Label68.Visible = False
        Label70.Visible = False
        Me.Close()
    End Sub

    Private Sub Command29_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command29.Click
        Dim rstCreditos As DataRow
        Dim rstNumCreditos As New DataView
        Dim rstTipoCredito As New DataView
        Dim rstnombres As New DataView
        Dim rstnombre As DataRow
        Dim codi2 As String
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim mesgestion As Date

        If (TMONumero.Text <> "") And (TMOCredito.Text <> "") And (TMOMonto.Text <> "") Then
            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TMOFecha.Value) < Month(mesgestion)) And (Year(TMOFecha.Value) < Year(mesgestion))) Or ((Year(TMOFecha.Value) < Year(mesgestion))) Or ((Month(TMOFecha.Value) <= Month(mesgestion)) And (Year(TMOFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TMOFecha.Value, CDbl(TMONumero.Text), "MO", existe)
                If (existe = 0) Then
                    If (moexiste = 0) Then
                        rstentrar = MainDSO.Tables("TblLibroIE").NewRow
                        With rstentrar
                            codi2 = TMOCredito.Text
                            'Registra la Operacion en el Libro IE
                            rstentrar("IdBK") = codi
                            rstentrar("fecha") = SQLDate(TMOFecha.Value)
                            rstentrar("NoCredito") = codi2
                            rstentrar("NoRecibo") = TMONumero.Text
                            rstentrar("CI") = Trim(Label66.Text)
                            rstentrar("codope") = "MO"
                            rstentrar("Descripcion") = "Intereses de Mora"
                            rstentrar("Ingreso") = CDbl(TMOMonto.Text)
                            rstentrar("Egreso") = 0
                            rstentrar("Saldo") = ThisBanko("SaldoBk")
                            LibroAdd(rstentrar)

                            'CORRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
                            If (COR = 1) Then
                                Dim form As New CONNUEVO
                                rstNumCreditos.Table = MainDSO.Tables("TblCredito")
                                rstNumCreditos.Sort = "NoCredito"



                                rstTipoCredito.Table = MainDSO.Tables("TipoCredito")
                                rstTipoCredito.Sort = "DescripClase"


                                rstnombres.Table = MainDSO.Tables("TblSocios")
                                rstnombres.RowFilter = "Estatus=1"
                                rstnombres.Sort = "CI"

                                'se verifica si hay fiador

                                If (CDbl(fiador1) <> 0) Then
                                    If MainDSO.Tables("TblSocios").Rows.Contains(fiador1) Then
                                        rstnombre = MainDSO.Tables("TblSocios").Rows.Find(fiador1)
                                        form.Label41.Text = "Nombre: " + rstnombre("Nombres")
                                        form.Label100.Text = "Acciones: " & Str(rstnombre("cap"))
                                        form.Label41.Visible = True
                                        form.Label100.Visible = True
                                        form.TCONFiador1.Text = fiador1

                                    End If
                                End If

                                If (CDbl(fiador2) <> 0) Then
                                    If MainDSO.Tables("TblSocios").Rows.Contains(fiador2) Then
                                        rstnombre = MainDSO.Tables("TblSocios").Rows.Find(fiador2)
                                        form.Label42.Text = "Nombre: " + rstnombre("Nombres")
                                        form.Label108.Text = "Acciones: " & Str(rstnombre("cap"))
                                        form.Label42.Visible = True
                                        form.Label108.Visible = True
                                        form.TCONFIador2.Text = fiador2
                                    End If
                                End If

                                For Each r As DataRowView In rstnombres
                                    form.TCONCedula.Items.Add((r("CI")))
                                    form.TCONFiador1.Items.Add((r("CI")))
                                    form.TCONFIador2.Items.Add((r("CI")))
                                Next

                                For Each r As DataRowView In rstTipoCredito
                                    form.TCONTipoC.Items.Add((r("Clase")))
                                Next

                                rstTasas = ThisBanko



                                'Se cargan los Intereses Ordinarios en los Combos
                                form.TTasaOR.Items.Add(rstTasas("TasaIO1"))
                                form.TTasaOR.Items.Add(rstTasas("TasaIO2"))


                                Dim credito As New DataView
                                credito.Table = MainDSO.Tables("TblCredito")
                                credito.RowFilter = "NoCredito='" + TMOCredito.Text + "'"
                                credito.Sort = "NoCredito"
                                rstCreditos = credito(0).Row
                                If (rstCreditos("TasaIO") <> "") Then
                                    form.TTasaMO.Text = rstCreditos("TasaIO")
                                End If
                                If (rstCreditos("TasaMO") <> "") Then
                                    form.TTasaOR.Text = rstCreditos("TasaMO")
                                End If

                                If (rstCreditos("frecuencia") <> "") Then
                                    If (rstCreditos("frecuencia") = 7) Then
                                        form.TCONFrecuencia.Text = "Semanal"
                                    Else
                                        If (rstCreditos("frecuencia") = 15) Then
                                            form.TCONFrecuencia.Text = "Quincenal"
                                        Else
                                            form.TCONFrecuencia.Text = "Mensual"
                                        End If
                                    End If
                                End If

                                'Se cargan los Intereses de Mora
                                form.TTasaMO.Items.Add(rstTasas("TasaM1"))
                                form.TTasaMO.Items.Add(rstTasas("TasaM2"))
                                form.NumCredito.Text = rstNumCreditos(rstNumCreditos.Count - 1)("NoCredito") + 1

                                fechas = Fcod(fechaU, ncod)
                                form.CONFecha.Value = fechaU
                                form.TCONNumero.Text = CStr(ncod)
                                form.TCONCedula.Enabled = False





                                form.TCONCedula.Text = rstCreditos("VCI")

                                rstnombre = MainDSO.Tables("TblSocios").Rows.Find(rstCreditos("VCI"))
                                form.Label38.Text = "Nombre: " + rstnombre("Nombres")
                                form.Label39.Text = "Acciones: " & Str(rstnombre("cap"))
                                form.Label38.Visible = True
                                form.Label39.Visible = True

                                form.TCONMonto.Text = VB6.Format(corsaldo, "###,##0.00")
                                If (rstCreditos("Clase") <> "") Then
                                    form.TCONTipoC.Text = rstCreditos("Clase")
                                End If
                                form.Text = "::: BKSistema - COR :::"
                                Me.Close()
                                form.ShowDialog()
                                Exit Sub

                            End If
                            TMONumero.Text = ""
                            TMOCredito.Text = ""
                            TMOMonto.Text = ""
                            Label65.Visible = False
                            Label66.Visible = False
                            Label67.Visible = False
                            Label68.Visible = False
                            Label70.Visible = False
                            fechas = Fcod(fechaU, ncod)
                            TMONumero.Text = CStr(ncod)
                        End With
                    Else
                        MsgBox("ERROR: El Credito no Existe. Verifique el N° de Credito")
                    End If
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los campos")
        End If

    End Sub

    Private Sub TMOCredito_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TMOCredito.SelectedIndexChanged
        Dim rstnombre, rstnombre2 As DataRow
        Dim codigo As String
        codigo = codi
        If MainDSO.Tables("TblCredito").Rows.Contains({ThisBanko("CodBk"), TMOCredito.Text.Trim}) Then
            rstnombre = MainDSO.Tables("TblCredito").Rows.Find({ThisBanko("CodBK"), TMOCredito.Text.Trim})
            rstnombre2 = MainDSO.Tables("TblSocios").Rows.Find(rstnombre("VCI"))
            Label65.Text = "Nombres: " + rstnombre2("Nombres")
            Label67.Text = "Acciones: " & Str(rstnombre2("cap"))
            Label68.Text = "Saldo:" & Str(rstnombre("Saldo"))
            Label66.Text = Str(rstnombre2("CI"))
            Label65.Visible = True
            Label66.Visible = True
            Label67.Visible = True
            Label68.Visible = True
            Label70.Visible = True
            moexiste = 0
        Else
            Label65.Visible = False
            Label66.Visible = False
            Label67.Visible = False
            Label68.Visible = False
            Label70.Visible = False
            moexiste = 1
        End If
    End Sub


    Private Sub TMOMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TMOMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TMOMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TMOMonto.Leave
        If (TMOMonto.Text <> "") Then
            TMOMonto.Text = VB6.Format(CDec(TMOMonto.Text), "###,##0.00")
        End If

    End Sub

    Private Sub TMONumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TMONumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TMOFecha.Focus()
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

    Private Sub MO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TMOFecha.Value, ncod)
        TMONumero.Text = ncod
        Dim v As New DataView
        v.Table = MainDSO.Tables("TblCredito")
        v.Sort = "NoCredito"
        With TMOCredito.Items
            .Clear()
            For Each r As DataRowView In v
                .Add(r("NoCredito"))
            Next
        End With

    End Sub
End Class