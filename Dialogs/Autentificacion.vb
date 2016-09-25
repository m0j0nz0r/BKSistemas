Option Strict Off
Option Explicit On
Friend Class Autentificacion
	Inherits System.Windows.Forms.Form
	'Variables Publicas del Sistema
	'Public codi As String
    Private estadosView As New DataView
    Private municipiosView As New DataView
    Private bankos As New DataView
	Private Sub bk_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles bk.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			Command1.Focus()
		Else
			KeyAscii = 0
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub clave_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles clave.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			bk.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
    Private Function LicenseValidate() As Long
        Dim conn As New DatabaseWebConnection(My.Settings.ConnectionString)
        Dim res As Long = 0
        Dim cedu As String()
        cedu = Split(bk.Text, "|")
        codi = cedu(0).Trim
        If HaveInternetConnection() Then
            Dim command As New DatabaseWebCommand("SELECT * FROM TblLibroIE WHERE IdBk = '" & codi & "' ORDER BY Fecha,NoRecibo,IdReg", conn)
            Dim Adapter As New DatabaseWebAdapter()
            'Dim DS As New DataSet
            Adapter.SelectCommand = command
            Adapter.Fill(MainDSO)
            command = New DatabaseWebCommand("SELECT * FROM TblTope", conn)
            Adapter.SelectCommand = command
            Adapter.Fill(MainDSO)
        End If
        Dim Libro As DataTable = MainDSO.Tables("TblLibroIE")
        Dim Top As DataTable = MainDSO.Tables("TblTope")

        If (Libro.Rows.Count > 0) Then
            Dim ultimaFecha As DataRow = Libro.Rows(Libro.Rows.Count - 1)
            Dim tope As DataRow = Top.Rows(0)
            res = DateDiff(Microsoft.VisualBasic.DateInterval.Day, Date.Parse(tope.Item("tope")), Date.Parse(ultimaFecha("fecha")))
        End If
        Return res
    End Function

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim conn As New DatabaseWebConnection(My.Settings.ConnectionString)
        Dim Adapter As DatabaseWebAdapter = New DatabaseWebAdapter()
        Dim rstUser As DatabaseWebCommand = Nothing
        Dim Menu1 As New Menu_Principal
        Dim clave1 As New Clave
        Dim cedu() As String
        Dim view As New DataView
        If ((usuario.Text <> "") And (clave.Text <> "")) Then
            user = LCase(usuario.Text)
            uPassword = LCase(clave.Text)
            If HaveInternetConnection() Then
                rstUser = New DatabaseWebCommand("SELECT * FROM tblUsuario WHERE Usuario = '" & user & "' and clave = '" & uPassword & "'", conn)
                Adapter.SelectCommand = rstUser
                Adapter.Fill(MainDSO)
            End If
            view.Table = MainDSO.Tables("tblUsuario")
            view.RowFilter = "Usuario='" & user & "' AND clave='" & uPassword & "'"
            If (view.Count > 0) Then
                tuser = CInt(view(0)("TipoUser"))
                If HaveInternetConnection() Then
                    rstUser.CommandText = "SELECT * FROM TblUserConfig WHERE ID = '" & tuser & "'"
                    Adapter.Fill(MainDSO)
                End If
                CurrentUserPermits = MainDSO.TblUserconfig.Copy
                If CurrentUserPermits.Rows.Contains({tuser, "ForceSelect"}) Then
                    ForceSelect = (FindPermit(tuser, "ForceSelect") = "1")
                    FilterCode = FindPermit(tuser, "FilterCode")
                    Dim bankos As New DataView(MainDSO.TblBanko)
                    bankos.RowFilter = FilterCode
                    Dim byFilter As Integer = bankos.Count
                    If ForceSelect Then
                        cedu = Split(bk.Text, "|")
                        codi = cedu(0).Trim
                    End If
                    If byFilter > 0 And ForceSelect And view(0)("bk") <> "" Then
                        byFilter = 0
                        For Each r As DataRowView In bankos
                            If r("CodBk") = view(0)("bk") Then
                                byFilter = 1
                                Exit For
                            End If
                        Next
                        If byFilter > 0 Then
                            byFilter = IIf(view(0)("bk") = codi, 1, 0)
                        End If
                    End If
                    If byFilter <= 0 Then
                        MsgBox("Usted no tiene los permisos necesarios para acceder a esta data.")
                    ElseIf ForceSelect And bk.Text.Trim = "" Then
                        MsgBox("Debe seleccionar un bankomunal de la lista.")
                    Else
                        Menu1.Show()
                        Me.Close()
                    End If
                Else
                    MsgBox("Error en la configuración de permisos para este usuario.")
                End If
            Else
                MsgBox("Usuario no Autorizado intente de nuevo")
            End If
        Else
            MsgBox("Debe completar el usuario la clave y seleccionar el Bankomunal")
        End If
    End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
    Private Sub Autentificacion_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        logged = False
        Debug.WriteLine(My.Settings.SaveData)
        If HaveInternetConnection() Then
            Try
                Dim conn As DatabaseWebConnection
                conn = New DatabaseWebConnection(My.Settings.ConnectionString)
                Dim DS As New DataSet()
                Dim Adapter As New DatabaseWebAdapter()
                Adapter.SelectCommand = New DatabaseWebCommand("SELECT * FROM TblPaises", conn)
                Adapter.Fill(MainDSO)
                Adapter.SelectCommand = New DatabaseWebCommand("SELECT * FROM TblEstados", conn)
                Adapter.Fill(MainDSO)
                Adapter.SelectCommand = New DatabaseWebCommand("SELECT * FROM TblMunicipios", conn)
                Adapter.Fill(MainDSO)
                Adapter.SelectCommand = New DatabaseWebCommand("SELECT * FROM TblBanko ORDER BY CodBK", conn)
                Adapter.Fill(MainDSO)
            Catch ex As Exception
                MessageBox.Show(ex.Message + ex.StackTrace)
                Me.Close()
            End Try
        Else
            MsgBox("No se detectó conección a internet... ingresando en modo offline.")
            LoadOffline(MainDSO)
        End If
        estadosView.Table = MainDSO.TblEstados
        municipiosView.Table = MainDSO.TblMunicipios
        codi = ""
        TblPaisesBindingSource.DataSource = MainDSO.TblPaises
        TblEstadosBindingSource.DataSource = estadosView
        TblMunicipiosBindingSource.DataSource = municipiosView
        UpdateBankos()
    End Sub
    Private Sub UpdateBankos()
        Dim view As New DataView, filter As String = "Municipio=" & municipio.SelectedValue
        view.Table = MainDSO.TblBanko
        view.Sort = "CodBk"
        If filter.Length > 10 Then
            view.RowFilter = filter
        End If
        bk.Items.Clear()
        For Each row As DataRowView In view
            bk.Items.Add(row.Item("CodBK") + " | " + row.Item("NombreBk"))
        Next
    End Sub
	Private Sub usuario_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles usuario.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (KeyAscii = 13) Then
			clave.Focus()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
    End Sub

    Private Sub pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pais.SelectedIndexChanged
        Dim filter As String = "PID=" & pais.SelectedValue
        If filter.Length > 4 Then
            estadosView.RowFilter = filter
        End If
        Debug.WriteLine(filter)
    End Sub

    Private Sub estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles estado.SelectedIndexChanged
        Dim filter As String = "EID=" & estado.SelectedValue
        If filter.Length > 4 Then
            municipiosView.RowFilter = "EID=" & estado.SelectedValue
        End If
        Debug.WriteLine(filter)
    End Sub

    Private Sub municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles municipio.SelectedIndexChanged
        Debug.WriteLine(municipio.SelectedValue)
        UpdateBankos()
    End Sub
End Class