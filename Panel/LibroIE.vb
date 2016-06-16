Option Strict Off
Option Explicit On
Friend Class LibroIE
    Inherits System.Windows.Forms.Form
    Private DataSource As DataView
    Private Sub ResetForm()
        CCreditos.Text = ""
        COtrosIE.Text = ""
        FondoGastos.Text = ""
        COtrasOp.Text = ""
        Saldototal.Text = ThisBanko.SaldoBk
    End Sub
    Private Sub CCertificados_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CCertificados.SelectedIndexChanged
        Dim f As Form
        If (CCertificados.Text = "UR   Ganancias Repartidas") Then
            f = New UR
        ElseIf (CCertificados.Text = "VC   Venta de Acciones") Then
            f = New VCC
        ElseIf (CCertificados.Text = "LC   Liquidacion de Acciones") Then
            f = New LC
        Else 'CCertificados.Text = "RET Retiro de Socios"
            f = New RET
        End If
        f.ShowDialog()
        ResetForm()
    End Sub

    Private Sub CCertificados_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles CCertificados.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            CCreditos.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub CCreditos_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CCreditos.SelectedIndexChanged
        Dim f As Form
        If (CCreditos.Text = "OR   Intereses Ordinarios") Then
            f = New ORD
        ElseIf (CCreditos.Text = "MO   Intereses de Mora") Then
            f = New MO
        ElseIf (CCreditos.Text = "RI   Reintegro de Intereses") Then
            f = New RI
        ElseIf (CCreditos.Text = "PC   Pago de Cuotas") Then
            COR = 0
            f = New PC
        ElseIf (CCreditos.Text = "COR  Refinanciamiento") Then
            COR = 1
            f = New PC
        ElseIf (CCreditos.Text = "PDP  Pago de Deuda Pendiente") Then
            f = New PDP
        Else ' (CCreditos.Text = "CON  Otorgamiento de Creditos") 
            f = New CONNUEVO
        End If
        f.ShowDialog()
        ResetForm()
    End Sub

    Private Sub CCreditos_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles CCreditos.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            COtrosIE.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub COtrasOp_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles COtrasOp.SelectedIndexChanged
        Dim f As Form
        If (COtrasOp.Text = "DO   Donaciones") Then
            f = New DON
        Else '(COtrasOp.Text = "BA    Bienes Adquiridos") Then
            f = New BA
        End If
        f.ShowDialog()
        ResetForm()
    End Sub

    Private Sub COtrasOp_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles COtrasOp.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            CCertificados.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub COtrosIE_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles COtrosIE.SelectedIndexChanged
        Dim f As Form
        If (COtrosIE.Text = "OI   Otros Ingresos") Then
            f = New OI
        Else ' (COtrosIE.Text = "EG  Otros Egresos") Then
            f = New EGForm
        End If
        f.ShowDialog()
        ResetForm()
    End Sub

    Private Sub COtrosIE_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles COtrosIE.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            FondoGastos.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub FondoGastos_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FondoGastos.SelectedIndexChanged
        Dim f As Form
        If (FondoGastos.Text = "IFG  Ingreso al Fondo") Then
            f = New IFG
        Else ' (FondoGastos.Text = "GBK  Gastos del Bankomunal") Then
            f = New GBK
        End If
        f.ShowDialog()
        ResetForm()
    End Sub

    Private Sub FondoGastos_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles FondoGastos.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            COtrasOp.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub LibroIE_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim fmt As String
        Dim codigo As String
        codigo = codi
        COR = 0
        DataSource = New DataView
        DataSource.Table = MainDSO.TblLibroIE
        DataSource.RowFilter = "Bloqueo=0"
        DataSource.Sort = "Fecha DESC, NoRecibo DESC, IdReg DESC"
        'Carga el Codigo y el Nombre del Banko
        LCodBk.Text = "::: " & codigo & " " + ThisBanko.NombreBk
        nominal = 10
        'Carga el Libro de Ingreso y Egreso
        fmt = "###,##0.00"
        Libro.DataSource = DataSource
        Libro.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFFF)

        Libro.Columns(0).Visible = False
        Libro.Columns(1).Visible = False
        Libro.Columns(2).Visible = False
        Libro.Columns(3).Width = VB6.TwipsToPixelsX(1300) 'Fecha +300
        Libro.Columns(4).Width = VB6.TwipsToPixelsX(1500) 'No Credito +200
        Libro.Columns(5).Width = VB6.TwipsToPixelsX(1300) 'No Ope. +300
        Libro.Columns(6).Width = VB6.TwipsToPixelsX(1300) 'CI
        Libro.Columns(7).Width = VB6.TwipsToPixelsX(1300) 'Cod. Op +300
        Libro.Columns(8).Width = VB6.TwipsToPixelsX(3000) 'Descripcion
        Libro.Columns(9).Width = VB6.TwipsToPixelsX(1500) 'Ingreso
        Libro.Columns(9).DefaultCellStyle.Format = fmt
        Libro.Columns(10).Width = VB6.TwipsToPixelsX(1500)
        Libro.Columns(10).DefaultCellStyle.Format = fmt
        Libro.Columns(11).Width = VB6.TwipsToPixelsX(1500)
        Libro.Columns(11).DefaultCellStyle.Format = fmt
        Libro.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Libro.Columns(3).HeaderText = "Fecha Op."
        Libro.Columns(4).HeaderText = "No Credito"
        Libro.Columns(5).HeaderText = "No Ope."
        Libro.Columns(6).HeaderText = "CI"
        Libro.Columns(7).HeaderText = "Cod. Op"
        Libro.Columns(8).HeaderText = "Descripcion"
        Libro.Columns(9).HeaderText = "Ingreso"
        Libro.Columns(10).HeaderText = "Egreso"
        Libro.Columns(11).HeaderText = "Saldo"
        Libro.Columns(12).Visible = False
        Libro.Columns(13).Visible = True
        Libro.Columns(13).HeaderText = "Anular Op."
        Libro.Columns(13).ToolTipText = "Para anular un registro, ubicar la línea del registro a eliminar  y dar click con botón derecho del mouse"
        Libro.ColumnHeadersDefaultCellStyle.Font = New Font(Libro.ColumnHeadersDefaultCellStyle.Font.FontFamily, 11, FontStyle.Bold)
        Saldototal.Text = ThisBanko.SaldoBk

        MarkAnulados()
        If My.Settings.DynamicPermits Then
            SetPermits()
        Else
            CCertificados.Items.Add("VC   Venta de Acciones")
            CCertificados.Items.Add("LC   Liquidacion de Acciones")
            CCertificados.Items.Add("UR   Ganancias Repartidas")
            CCertificados.Items.Add("RET  Retiro de Socios")
            CCreditos.Items.Add("OR   Intereses Ordinarios")
            CCreditos.Items.Add("MO   Intereses de Mora")
            CCreditos.Items.Add("RI   Reintegro de Intereses")
            CCreditos.Items.Add("PC   Pago de Cuotas")
            CCreditos.Items.Add("CON  Otorgamiento de Creditos")
            CCreditos.Items.Add("PDP  Pago de Deuda Pendiente")
            CCreditos.Items.Add("COR  Refinanciamiento")
            COtrosIE.Items.Add("OI   Otros Ingresos")
            COtrosIE.Items.Add("EG   Otros Egresos")
            FondoGastos.Items.Add("IFG  Ingreso al Fondo")
            FondoGastos.Items.Add("GBK  Gastos del Bankomunal")
            COtrasOp.Items.Add("DO   Donaciones")
            COtrasOp.Items.Add("BA   Bienes Adquiridos")
        End If
    End Sub

    Private Sub MarkAnulados()
        Try
            For Each row As DataGridViewRow In Libro.Rows
                If Not IsDBNull(row.Cells(13).Value) Then
                    For Each cell As DataGridViewCell In row.Cells
                        cell.Style.BackColor = IIf(row.Cells(13).Value = 1, Color.Red, Color.White)
                    Next
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub SetPermits()
        If FindPermit(tuser, "LibroIEAcciones") = "1" Then
            CCertificados.Visible = True
            Label1.Visible = True
            If FindPermit(tuser, "LibroIEAccionesVenta") = "1" Then
                CCertificados.Items.Add("VC   Venta de Acciones")
            End If
            If FindPermit(tuser, "LibroIEAccionesLiq") = "1" Then
                CCertificados.Items.Add("LC   Liquidacion de Acciones")
            End If
            If FindPermit(tuser, "LibroIEAccionesGanancias") = "1" Then
                CCertificados.Items.Add("UR   Ganancias Repartidas")
            End If
            If FindPermit(tuser, "LibroIEAccionesRetiro") = "1" Then
                CCertificados.Items.Add("RET  Retiro de Socios")
            End If
        Else
            CCertificados.Visible = False
            Label1.Visible = False
        End If
        If FindPermit(tuser, "LibroIECreditos") = "1" Then
            CCreditos.Visible = True
            Label47.Visible = True
            If FindPermit(tuser, "LibroIECreditosIntOrd") = "1" Then
                CCreditos.Items.Add("OR   Intereses Ordinarios")
            End If
            If FindPermit(tuser, "LibroIECreditosIntMora") = "1" Then
                CCreditos.Items.Add("MO   Intereses de Mora")
            End If
            If FindPermit(tuser, "LibroIECreditosReintegro") = "1" Then
                CCreditos.Items.Add("RI   Reintegro de Intereses")
            End If
            If FindPermit(tuser, "LibroIECreditosPagoCuota") = "1" Then
                CCreditos.Items.Add("PC   Pago de Cuotas")
            End If
            If FindPermit(tuser, "LibroIECreditosOtorgamiento") = "1" Then
                CCreditos.Items.Add("CON  Otorgamiento de Creditos")
            End If
            If FindPermit(tuser, "LibroIECreditosPagoDeuda") = "1" Then
                CCreditos.Items.Add("PDP  Pago de Deuda Pendiente")
            End If
            If FindPermit(tuser, "LibroIECreditosRefinanciamiento") = "1" Then
                CCreditos.Items.Add("COR  Refinanciamiento")
            End If
        Else
            CCreditos.Visible = False
            Label47.Visible = False
        End If
        If FindPermit(tuser, "LibroIEOtrosIE") = "1" Then
            COtrosIE.Visible = True
            Label12.Visible = True
            If FindPermit(tuser, "LibroIEOtrosIEIngresos") = "1" Then
                COtrosIE.Items.Add("OI   Otros Ingresos")
            End If
            If FindPermit(tuser, "LibroIEOtrosIEEgresos") = "1" Then
                COtrosIE.Items.Add("EG   Otros Egresos")
            End If
        Else
            COtrosIE.Visible = False
            Label12.Visible = False
        End If
        If FindPermit(tuser, "LibroIEFondo") = "1" Then
            FondoGastos.Visible = True
            Label19.Visible = True
            If FindPermit(tuser, "LibroIEFondoIngreso") = "1" Then
                FondoGastos.Items.Add("IFG  Ingreso al Fondo")
            End If
            If FindPermit(tuser, "LibroIEFondoGasto") = "1" Then
                FondoGastos.Items.Add("GBK  Gastos del Bankomunal")
            End If
        Else
            FondoGastos.Visible = False
            Label19.Visible = False
        End If
        If FindPermit(tuser, "LibroIEOtrasOp") = "1" Then
            COtrasOp.Visible = True
            Label26.Visible = True
            If FindPermit(tuser, "LibroIEOtrasOpDonaciones") = "1" Then
                COtrasOp.Items.Add("DO   Donaciones")
            End If
            If FindPermit(tuser, "LibroIEOtrasOpBienes") = "1" Then
                COtrasOp.Items.Add("BA   Bienes Adquiridos")
            End If
        Else
            CCertificados.Visible = False
            Label26.Visible = False
        End If

    End Sub
    Private Sub Command3_Click(sender As Object, e As EventArgs) Handles Command3.Click
        Close()
    End Sub

    Private Sub Libro_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Libro.CellMouseClick
        If Libro.SelectedCells.Count > 0 Then
            Dim LibroRow As DataRow = MainDSO.TblLibroIE.Rows.Find({Libro.SelectedCells(2).Value, Libro.SelectedCells(3).Value, Libro.SelectedCells(5).Value, Libro.SelectedCells(7).Value})
            Libro.ContextMenuStrip = ContextMenuStrip1
        Else
            Libro.ContextMenuStrip = Nothing
        End If
    End Sub
    Sub AnularRegistro(IdBK As String, Fecha As Date, NoRecibo As Integer, CodOpe As String)

        Dim LibroRow As MainDS.TblLibroIERow = MainDSO.TblLibroIE.Rows.Find({IdBK, Fecha, NoRecibo, CodOpe})
        Dim oldval As Integer = 0
        If LibroRow.IsAnuladoNull Then
            LibroRow.Anulado = 1
        Else
            oldval = LibroRow.Anulado
            LibroRow.Anulado = IIf(LibroRow.Anulado = 1, 0, 1)
        End If
        Dim record As MainDS.TblAnulacionesRow = MainDSO.TblAnulaciones.NewRow
        record.IdBK = LibroRow.IdBK
        record.Fecha = LibroRow.Fecha
        record.NoRecibo = LibroRow.NoRecibo
        record.CodOpe = LibroRow.CodOpe
        record.User = user
        record.User = uPassword
        record._Date = DateTime.Now
        If Libro.SelectedCells(13).Value = 0 Then
            record.Accion = "Deshacer anulacion"
        Else
            record.Accion = "Anular"
        End If
        LibroSaldo(0)
        Saldototal.Text = ThisBanko.SaldoBk

        'anula registros en otras tablas
        Dim sign As Integer = IIf(oldval = 0, -1, 1) 'negativo si se está anulando.
        Select Case CodOpe
            Case "IFG1"
                If LibroRow.Descripcion = "Ingresos al Fondo de Gastos" Then
                    ThisBanko.SAFGASTOS = ThisBanko.SAFGASTOS + (sign * LibroRow.Ingreso)
                End If
            Case "GBK1"
                ThisBanko.SAFGASTOS = ThisBanko.SAFGASTOS - (sign * LibroRow.Egreso)
            Case "PDP"
                Dim credito As MainDS.TblCreditoRow = MainDSO.TblCredito.Rows.Find({codi, LibroRow.NoCredito})
                Dim monto As Double = LibroRow.Ingreso
                Dim pdpsaldo As Double = credito.Saldo - sign * monto
                If credito.Saldo > 0 Then
                    If (pdpsaldo = 0) Then
                        credito.Saldo = 0
                        credito.Cancelado = 1
                        credito.incobrable = 0
                        credito.deuda = 0
                        credito.FechaCancela = LibroRow.Fecha
                        MainDSO.TblSocios.FindByCI(credito.VCI).Deuda = 0
                    Else
                        credito.deuda = pdpsaldo
                        MainDSO.TblSocios.FindByCI(credito.VCI).Deuda = pdpsaldo
                    End If
                Else
                    credito.Saldo = pdpsaldo
                    credito.Cancelado = 0
                    credito.deuda = pdpsaldo
                    MainDSO.TblSocios.FindByCI(credito.VCI).Deuda = pdpsaldo
                End If
            Case "CON"
                Dim credito As MainDS.TblCreditoRow = MainDSO.TblCredito.Rows.Find({codi, LibroRow.NoCredito})
                credito.IdOp = LibroRow.Anulado
                PC.RecalcularFiadores(credito.NoCredito, False)
                Dim lview As New DataView
                lview.Table = MainDSO.TblFiadores
                lview.RowFilter = "NoCredito='" & LibroRow.NoCredito & "'"
                For Each r As DataRowView In lview
                    If oldval = 0 Then 'anulando
                        If r("Observacion") = "" Then
                            r("Observacion") = "Anulado"
                        Else
                            r("Observacion") = "-Anulado-"
                        End If
                    Else
                        If r("Observacion") = "Anulado" Then
                            r("Observacion") = ""
                        Else
                            r("Observacion") = "No tiene las Garantias Suficientes"
                        End If
                    End If
                Next
            Case "COR"
                Dim credito As MainDS.TblCreditoRow = MainDSO.TblCredito.Rows.Find({codi, LibroRow.NoCredito})
                credito.IdOp = LibroRow.Anulado
                Dim lview As New DataView
                lview.Table = MainDSO.TblFiadores
                lview.RowFilter = "NoCredito='" & LibroRow.NoCredito & "'"
                For Each r As DataRowView In lview
                    If oldval = 0 Then 'anulando
                        If r("Observacion") = "" Then
                            r("Observacion") = "Anulado"
                        Else
                            r("Observacion") = "-Anulado-"
                        End If
                    Else
                        If r("Observacion") = "Anulado" Then
                            r("Observacion") = ""
                        Else
                            r("Observacion") = "No tiene las Garantias Suficientes"
                        End If
                    End If
                Next
            Case "VC"
                Dim socio As MainDS.TblSociosRow = MainDSO.TblSocios.Rows.Find(LibroRow.CI)
                socio.cap = socio.cap + sign * (CDbl(LibroRow.Ingreso / ThisBanko.Val_nominal))
            Case "PC"
                'Tabla creditos
                Dim credito As MainDS.TblCreditoRow = MainDSO.TblCredito.Rows.Find({ThisBanko.CodBk, _
                                                                                    LibroRow.NoCredito})
                credito.Saldo = credito.Saldo - sign * LibroRow.Ingreso
                credito.Cancelado = IIf(credito.Saldo < 1, 1, 0)
                credito.incobrable = 0
                credito.deuda = 0
                If credito.Cancelado = 0 And _
                    LibroRow.Descripcion.Contains("Ret.") And _
                    oldval = 1 Then
                    credito.incobrable = 1
                    credito.deuda = credito.Saldo
                    credito.Saldo = 0
                    credito.FechaCancela = Nothing
                End If
                'Tabla fiadores
                PC.RecalcularFiadores(credito.NoCredito, 0)


            Case "LC"
                Dim socio As MainDS.TblSociosRow = MainDSO.TblSocios.Rows.Find(LibroRow.CI)
                Dim caps As Double = sign * (CDbl(LibroRow.Egreso / ThisBanko.Val_nominal))
                socio.cap = socio.cap - caps
                socio.CapLiq = socio.CapLiq + caps

                'Recalcula fiadores.
                Dim creditos As New Generic.List(Of String) 'crear lista de creditos en los que el socio es fiador
                Dim fiadores As New DataView
                fiadores.Table = MainDSO.TblFiadores
                fiadores.RowFilter = "CI='" & socio.CI & "'"
                For Each r As DataRowView In fiadores
                    If Not creditos.Contains(r("NoCredito")) Then
                        creditos.Add(r("NoCredito"))
                    End If
                Next

                'recalcular fiadores por cada credito siempre que el saldo del credito sea > 0
                Dim credito As MainDS.TblCreditoRow
                For Each c As String In creditos
                    credito = MainDSO.TblCredito.Rows.Find({codi, c})
                    If credito.Saldo > 0 And credito.IdOp = 0 Then
                        PC.RecalcularFiadores(c, False)
                        credito.Riezgo = CONNUEVO.GetRiesgo(credito) 'Recalcula el riesgo del crédito.
                    End If
                Next

                'definir si el socio está activo o no.
                If LibroRow.Descripcion.Contains("Ret.") Then
                    If oldval = 0 Then
                        socio.Estatus = 1
                        socio.Fretiro = Nothing
                    ElseIf socio.Deuda < 1 Then
                        socio.Estatus = 2
                        socio.Fretiro = LibroRow.Fecha
                    Else
                        socio.Estatus = 3
                        socio.Fretiro = LibroRow.Fecha
                    End If
                End If
        End Select

        'anula los demás registros del mismo recibo
        Dim view As New DataView
        view.Table = MainDSO.TblLibroIE
        view.RowFilter = "IdBK='" & IdBK & "' AND NoRecibo='" & NoRecibo & "' AND Anulado='" & oldval & "'"
        If view.Count > 0 Then
            AnularRegistro(view(0)("IdBK"), view(0)("Fecha"), view(0)("NoRecibo"), view(0)("CodOpe"))
        End If

        'Si es un Retiro, anula todos los registros del retiro y reactiva al socio.
        'el Socio es reactivado cuando se anula el LC del retiro.
        If LibroRow.Descripcion.Contains("Ret.") Then
            view.RowFilter = "IdBK='" & LibroRow.IdBK & "' AND CI='" & LibroRow.CI & "' AND Anulado='" & oldval & "' AND Descripcion LIKE 'Ret.%'"
            If view.Count > 0 Then
                AnularRegistro(view(0)("IdBK"), view(0)("Fecha"), view(0)("NoRecibo"), view(0)("CodOpe"))
            End If
        End If
        MarkAnulados()
    End Sub
    Private Sub AnularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularToolStripMenuItem.Click
        If Libro.SelectedCells.Count > 0 Then
            AnularRegistro(Libro.SelectedCells(2).Value, Libro.SelectedCells(3).Value, Libro.SelectedCells(5).Value, Libro.SelectedCells(7).Value)
        Else
            MsgBox("Debe seleccionar un registro...")
        End If
        Libro.ClearSelection()
        ResetForm()
    End Sub

    Private Sub Libro_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Libro.CellFormatting
        If e.ColumnIndex = 13 Then
            Me.Libro.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = Me.Libro.Columns(e.ColumnIndex).ToolTipText
        End If
    End Sub
End Class