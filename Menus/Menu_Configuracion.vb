Option Strict Off
Option Explicit On
Friend Class Menu_Configuracion
    Inherits System.Windows.Forms.Form

    Private Sub Menu_Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnProyectos.Visible = (FindPermit(tuser, "PanelConfigProyectos") = "1")
        LblProyectos.Visible = BtnProyectos.Visible
        BtnPaises.Visible = (FindPermit(tuser, "PanelConfigPaises") = "1")
        LblPaises.Visible = BtnPaises.Visible
        BtnEstados.Visible = (FindPermit(tuser, "PanelConfigEstados") = "1")
        LblEstados.Visible = BtnEstados.Visible
        BtnMunicipios.Visible = (FindPermit(tuser, "PanelConfigMunicipios") = "1")
        LblMunicipios.Visible = BtnMunicipios.Visible
        BtnUsuarios.Visible = (FindPermit(tuser, "PanelConfigUsuarios") = "1")
        LblUsuarios.Visible = BtnUsuarios.Visible
        BtnTipoCredito.Visible = (FindPermit(tuser, "PanelConfigTipoCredito") = "1")
        LblTipoCredito.Visible = BtnTipoCredito.Visible
        BtnClaseCredito.Visible = (FindPermit(tuser, "PanelConfigClaseCredito") = "1")
        LblClaseCredito.Visible = BtnClaseCredito.Visible
        BtnOpciones.Visible = (FindPermit(tuser, "PanelConfigOpciones") = "1")
        LblOpciones.Visible = BtnClaseCredito.Visible
        'BtnClasifCreditos.Visible = (FindPermit(tuser, "PanelConfigClasifCredito") = "1")
        BtnClasifCreditos.Visible = False
        LblClasifCreditos.Visible = BtnClasifCreditos.Visible
        BtnFondo.Visible = (FindPermit(tuser, "") = "1")
        LblFondo.Visible = BtnFondo.Visible
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnMunicipios_Click(sender As Object, e As EventArgs) Handles BtnMunicipios.Click
        Dim f As New PanelMunicipios
        f.ShowDialog()
    End Sub

    Private Sub BtnProyectos_Click(sender As Object, e As EventArgs) Handles BtnProyectos.Click
        Dim f As New PanelProyectos
        f.ShowDialog()
    End Sub

    Private Sub BtnPaises_Click(sender As Object, e As EventArgs) Handles BtnPaises.Click
        Dim f As New PanelPaises
        f.ShowDialog()
    End Sub

    Private Sub BtnEstados_Click(sender As Object, e As EventArgs) Handles BtnEstados.Click
        Dim f As New PanelEstados
        f.ShowDialog()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Dim f As New PanelUsuarios
        f.ShowDialog()
    End Sub

    Private Sub BtnTipoCredito_Click(sender As Object, e As EventArgs) Handles BtnTipoCredito.Click
        Dim f As New PanelTipoCredito
        f.ShowDialog()
    End Sub

    Private Sub BtnClaseCredito_Click(sender As Object, e As EventArgs) Handles BtnClaseCredito.Click
        Dim f As New PanelClaseCredito
        f.ShowDialog()
    End Sub

    Private Sub BtnClasifCreditos_Click(sender As Object, e As EventArgs) Handles BtnClasifCreditos.Click
        Dim f As New PanelClasifCredito
        f.ShowDialog()
    End Sub

    Private Sub BtnOpciones_Click(sender As Object, e As EventArgs) Handles BtnOpciones.Click
        Dim f As New Opciones
        f.ShowDialog()
    End Sub
End Class
