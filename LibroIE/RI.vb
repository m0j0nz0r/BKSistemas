Option Strict Off
Option Explicit On
Friend Class RI
    Inherits System.Windows.Forms.Form
    
    Private Sub Command80_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command80.Click
        Dim codi2 As String
        Dim prifecha As Date
        Dim primerafecha As Date
        Dim ultimafecha As Date
        Dim existe2 As Short
        Dim existe As Short
        Dim mesgestion As Date

        If (TRINumero.Text <> "") And (TRICredito.Text <> "") And (TRIMonto.Text <> "") Then
            primerafecha = fechaLIE(prifecha, ultimafecha, mesgestion)
            If ((Month(TRIFecha.Value) < Month(mesgestion)) And (Year(TRIFecha.Value) < Year(mesgestion))) Or ((Year(TRIFecha.Value) < Year(mesgestion))) Or ((Month(TRIFecha.Value) <= Month(mesgestion)) And (Year(TRIFecha.Value) = Year(mesgestion))) Then
                MsgBox("No puede registrar una operacion en un Mes Cerrado. Verifique la Fecha")
            Else
                existe2 = BuscaLibro(TRIFecha.Value, CDbl(TRINumero.Text), "RI", existe)
                If (existe = 0) Then
                    rstentrar = MainDSO.Tables("TblLibroIE").NewRow
                    codi2 = TRICredito.Text
                    'Registra la Operacion en el Libro IE
                    rstentrar("IdBK") = codi
                    rstentrar("fecha") = SQLDate(TRIFecha.Value)
                    rstentrar("NoCredito") = codi2
                    rstentrar("NoRecibo") = TRINumero.Text
                    rstentrar("CI") = Trim(Label92.Text)
                    rstentrar("codope") = "RI"
                    rstentrar("Descripcion") = "Reintegro de Intereses"
                    rstentrar("Ingreso") = 0
                    rstentrar("Egreso") = CDbl(TRIMonto.Text)
                    rstentrar("Saldo") = ThisBanko("SaldoBk")
                    LibroAdd(rstentrar)
                    TRINumero.Text = ""
                    TRICredito.Text = ""
                    TRIMonto.Text = ""
                    fechas = Fcod(fechaU, ncod)
                    TRINumero.Text = CStr(ncod)
                    Label90.Visible = False
                    Label91.Visible = False
                    Label92.Visible = False
                    Label93.Visible = False
                    Label94.Visible = False
                Else
                    MsgBox("ERROR: Verique la Fecha o el Numero de Operacion el Siguiente registro crearia valores duplicados en el Libro IE")
                End If
            End If
        Else
            MsgBox("Debe completar todos los Datos")
        End If

    End Sub

    Private Sub Command81_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command81.Click
        TRINumero.Text = ""
        TRICredito.Text = ""
        TRIMonto.Text = ""
        Label90.Visible = False
        Label91.Visible = False
        Label92.Visible = False
        Label93.Visible = False
        Label94.Visible = False
        Me.Close()

    End Sub

    Private Sub TRICredito_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TRICredito.SelectedIndexChanged
        Dim rstnombre As DataRow
        Dim codigo As String
        codigo = codi
        Dim creditos As New DataView
        creditos.Table = MainDSO.Tables("TblCredito")
        creditos.RowFilter = "IdOp=0 AND NoCredito = " & CDbl(TRICredito.Text)
        If creditos.Count > 0 Then
            If MainDSO.Tables("TblSocios").Rows.Contains(creditos(0)("VCI")) Then
                rstnombre = MainDSO.Tables("TblSocios").Rows.Find(creditos(0)("VCI"))
                Label90.Text = "Nombres: " + rstnombre("Nombres")
                Label94.Text = "Acciones: " & Str(rstnombre("cap"))
                Label93.Text = "Saldo:" & VB6.Format(creditos(0)("Saldo"), "###,##0.00")
                Label92.Text = rstnombre("CI")
                Label90.Visible = True
                Label91.Visible = True
                Label92.Visible = True
                Label93.Visible = True
                Label94.Visible = True
            Else
                Label90.Visible = False
                Label91.Visible = False
                Label92.Visible = False
                Label93.Visible = False
                Label94.Visible = False
            End If
        End If
    End Sub

    Private Sub TRIMonto_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRIMonto.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If ((KeyAscii < 48) Or (KeyAscii > 57)) And (KeyAscii <> 8) And (KeyAscii <> 44) Then
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TRIMonto_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TRIMonto.Leave
        If (TRIMonto.Text <> "") Then
            TRIMonto.Text = VB6.Format(CDec(TRIMonto.Text), "###,###.00")
        End If
    End Sub

    Private Sub TRINumero_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TRINumero.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TRIFecha.Focus()
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

    Private Sub RI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fcod(TRIFecha.Value, ncod)
        TRINumero.Text = ncod
        Dim v As New DataView
        v.Table = MainDSO.Tables("TblCredito")
        v.Sort = "NoCredito"
        With TRICredito.Items
            .Clear()
            For Each r As DataRowView In v
                .Add(r("NoCredito"))
            Next
        End With

    End Sub
End Class