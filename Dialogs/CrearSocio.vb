Option Strict Off
Option Explicit On
Friend Class CrearSocio
    Inherits System.Windows.Forms.Form

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim codigo As String
        Dim rstsocnuevo As MainDS.TblSociosRow
        If (TCedula.Text <> "") And (TNombre.Text <> "") And (TTelefono.Text <> "") And (CSexo.Text <> "") Then
            'Agregar un nuevo socio con todos los datos
            codigo = codi
            If Not MainDSO.Tables("TblSocios").Rows.Contains(TCedula.Text) Then
                rstsocnuevo = MainDSO.Tables("TblSocios").NewRow
                rstsocnuevo("CodBk") = codigo
                rstsocnuevo("CI") = TCedula.Text
                rstsocnuevo("Nombres") = TNombre.Text
                rstsocnuevo("FNace") = TFNacimiento.Value
                rstsocnuevo("Telefono") = TTelefono.Text
                If CSexo.Text = "Femenino" Then
                    rstsocnuevo("Sexo") = "F"
                Else
                    rstsocnuevo("Sexo") = "M"
                End If
                If (TEmail.Text <> "") Then
                    rstsocnuevo("email") = TEmail.Text
                End If
                If (TOcupacion.Text <> "") Then
                    rstsocnuevo("Profesion") = TOcupacion.Text
                End If
                If (TDireccion.Text <> "") Then
                    rstsocnuevo("Direccion") = TDireccion.Text
                End If
                rstsocnuevo("cap") = 0
                rstsocnuevo("AcumMoras") = 0
                rstsocnuevo("Deuda") = 0
                rstsocnuevo("CapLiq") = 0
                rstsocnuevo.FIngreso = Date.Now
                rstsocnuevo("Estatus") = 1
                MainDSO.Tables("TblSocios").Rows.Add(rstsocnuevo)

            Else
                MsgBox("ERROR: No puede guardar este socio crearia valores duplicados")
            End If
            Me.Close()
        Else
            MsgBox(" Debe completar todos los Datos Requeridos")
        End If
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub CSexo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles CSexo.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TOcupacion.Focus()
        Else
            KeyAscii = 0
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Socios_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        TCedula.Text = cedula
        TFNacimiento.Value = Now

        'TNombre.SetFocus
    End Sub

    Private Sub TDireccion_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TDireccion.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            CSexo.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TEmail_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TEmail.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TDireccion.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TNombre_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TFNacimiento.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TOcupacion_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TOcupacion.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            Command1.Focus()
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub TTelefono_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TTelefono.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If (KeyAscii = 13) Then
            TEmail.Focus()
        End If

        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
End Class