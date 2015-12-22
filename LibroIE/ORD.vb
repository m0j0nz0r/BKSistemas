Option Strict Off
Option Explicit On
Friend Class ORD
    Inherits System.Windows.Forms.Form
    Public orexiste As Short
 
 
    Private Sub Command26_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command26.Click
        Dim rstCreditos As DataRow
        Dim codi2 As String
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim mesgestion As Date

        If (TORNumero.Text <> "") And (CORCredito.Text <> "") And (TORMonto.Text <> "") Then
            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TORFecha.Value) < Month(mesgestion)) And (Year(TORFecha.Value) < Year(mesgestion))) Or ((Year(TORFecha.Value) < Year(mesgestion))) Or ((Month(TORFecha.Value) <= Month(mesgestion)) And (Year(TORFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TORFecha.Value, CDbl(TORNumero.Text), "OR", existe)
                If (existe = 0) Then
                    If (orexiste = 0) Then
                        rstentrar = MainDSO.Tables("TblLibroIE").NewRow
                        codi2 = CORCredito.Text
                        'Registra la Operacion en el Libro IE
                        rstentrar("IdBK") = codi
                        rstentrar("fecha") = SQLDate(TORFecha.Value)
                        rstentrar("NoCredito") = codi2
                        rstentrar("NoRecibo") = TORNumero.Text
                        rstentrar("CI") = Trim(Label64.Text)
                        rstentrar("codope") = "OR"
                        rstentrar("Descripcion") = "Intereses Ordinarios"
                        rstentrar("Ingreso") = CDbl(TORMonto.Text)
                        rstentrar("Egreso") = 0
                        rstentrar("Saldo") = ThisBanko("SaldoBk")
                        LibroAdd(rstentrar)

                        If COR = 1 Then
                            Me.Close()
                            Exit Sub 'Just in case.
                        End If
                        If False Then 'if cor = 1 (unnecesary as it's handled by LibroAdd)
                            Dim cred As DataRow = MainDSO.Tables("TblCredito").Rows.Find({codi, CORCredito.Text})
                            Dim form As New MO
                            rstCreditos = MainDSO.Tables("TblSocios").Rows.Find(cred("VCI"))
                            form.Label65.Text = "Nombres: " + rstCreditos("Nombres")
                            form.Label67.Text = "Acciones: " & Str(rstCreditos("cap"))
                            form.Label68.Text = "Saldo:" & Str(cred("Saldo"))
                            form.Label66.Text = Str(rstCreditos("CI"))
                            form.Label65.Visible = True
                            form.Label66.Visible = True
                            form.Label67.Visible = True
                            form.Label68.Visible = True
                            form.Label70.Visible = True
                            fechas = Fcod(fechaU, ncod)
                            form.TMOFecha.Value = fechaU
                            form.TMONumero.Text = CStr(ncod)
                            form.TMOCredito.Text = CORCredito.Text
                            form.TMOCredito.Enabled = False
                            Me.Close()
                            form.ShowDialog()
                            Exit Sub
                        End If

                        TORNumero.Text = ""
                        CORCredito.Text = ""
                        TORMonto.Text = ""
                        fechas = Fcod(fechaU, ncod)
                        TORNumero.Text = CStr(ncod)
                        Label32.Visible = False
                        Label62.Visible = False
                        Label63.Visible = False
                        Label64.Visible = False
                        Label69.Visible = False
                    Else
                        MsgBox("ERROR: El Credito no Existe. Verifique el N° de Credito")
                    End If
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub Command27_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command27.Click
        Dim rstCreditos As DataRow
        If False Then 'COR = 1, unnecesary. Handled by LibroAdd
            Dim cred As DataRow = MainDSO.Tables("TblCredito").Rows.Find({codi, CORCredito.Text})
            Dim form As New MO
            rstCreditos = MainDSO.Tables("TblSocios").Rows.Find(cred("VCI"))
            form.Label65.Text = "Nombres: " + rstCreditos("Nombres")
            form.Label67.Text = "Acciones: " & Str(rstCreditos("cap"))
            form.Label68.Text = "Saldo:" & Str(cred("Saldo"))
            form.Label66.Text = Str(rstCreditos("CI"))
            form.Label65.Visible = True
            form.Label66.Visible = True
            form.Label67.Visible = True
            form.Label68.Visible = True
            form.Label70.Visible = True
            fechas = Fcod(fechaU, ncod)
            form.TMOFecha.Value = fechaU
            form.TMONumero.Text = CStr(ncod)
            form.TMOCredito.Text = CORCredito.Text
            form.TMOCredito.Enabled = False
            Me.Close()
            form.ShowDialog()
            Exit Sub
        End If
        TORNumero.Text = ""
        TORMonto.Text = ""
        CORCredito.Text = ""
        Label32.Visible = False
        Label62.Visible = False
        Label63.Visible = False
        Label64.Visible = False
        Label69.Visible = False
        Me.Close()
    End Sub

    Private Sub CORCredito_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CORCredito.SelectedIndexChanged
        Dim rstnombre As DataRow
        Dim codigo As String
        codigo = codi
        If MainDSO.Tables("TblCredito").Rows.Contains({codi, CORCredito.Text.Trim}) Then
            Dim cred As DataRow = MainDSO.Tables("TblCredito").Rows.Find({codi, CORCredito.Text.Trim})
            If cred("IdOp") = 0 Then
                rstnombre = MainDSO.Tables("TblSocios").Rows.Find(cred("VCI"))
                Label32.Text = "Nombres: " + rstnombre("Nombres")
                Label62.Text = "Acciones: " & Str(rstnombre("cap"))
                Label63.Text = "Saldo: " & VB6.Format(cred("Saldo"), "###,##0.00")
                Label64.Text = Str(rstnombre("CI"))
                Label32.Visible = True
                Label62.Visible = True
                Label63.Visible = True
                Label64.Visible = True
                Label69.Visible = True
                orexiste = 0
            Else

                Label32.Visible = False
                Label62.Visible = False
                Label63.Visible = False
                Label64.Visible = False
                Label69.Visible = False
                orexiste = 1
            End If
        Else
            Label32.Visible = False
            Label62.Visible = False
            Label63.Visible = False
            Label64.Visible = False
            Label69.Visible = False
            orexiste = 1
        End If

    End Sub

    Private Sub TORMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TORMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TORMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TORMonto.Leave
        If (TORMonto.Text <> "") Then
            TORMonto.Text = VB6.Format(CDec(TORMonto.Text), "###,##0.00")
        End If
    End Sub

    Private Sub TORNumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TORNumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TORFecha.Focus()
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

    Private Sub ORD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TORFecha.Value, ncod)
        TORNumero.Text = ncod
        Dim v As New DataView
        v.Table = MainDSO.Tables("TblCredito")
        v.Sort = "NoCredito"
        With CORCredito.Items
            .Clear()
            For Each r As DataRowView In v
                .Add(r("NoCredito"))
            Next
        End With
    End Sub
End Class