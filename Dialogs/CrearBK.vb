Option Strict Off
Option Explicit On

Imports System.IO

Friend Class CrearBK
    Inherits System.Windows.Forms.Form
    Private pview As DataView
    Private eview As DataView
    Private mview As DataView
    Private updating As Boolean = False
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim codigo As String
        codigo = txtcodigo.Text
        If (codigo <> "") Then
            If Not MainDSO.Tables("TblBanko").Rows.Contains(codigo) Then
                If (txtcodigo.Text <> "") And (txtnombre.Text <> "") And (TxtMoneda.Text <> "") And (TxtFecha.Value <> "01/01/01") And (TxtVal_cap.Text <> "") And (TxtPais.Text <> "") And (txtestado.Text <> "") And (txtmunicipio.Text <> "") Then
                    With MainDSO.Tables("TblBanko")
                        Dim row As DataRow = .NewRow()
                        If (txtcodigo.Text <> "") Then
                            row.Item("CodBk") = txtcodigo.Text
                        End If
                        If (txtnombre.Text <> "") Then
                            row.Item("NombreBk") = txtnombre.Text
                        End If
                        If (TxtMoneda.Text <> "") Then
                            row.Item("moneda") = TxtMoneda.Text
                        End If
                        If (TxtFecha.Value <> "01/01/01") Then
                            row.Item("FechaI") = SQLDate(TxtFecha.Value)
                        End If
                        If CBool(TxtVal_cap.Text) Then
                            row.Item("Val_nominal") = TxtVal_cap.Text
                        End If
                        If (txtmunicipio.Text <> "") Then
                            row.Item("municipio") = txtmunicipio.SelectedValue
                        End If
                        If (ComboBox1.Text <> "") Then
                            row("Proyecto") = ComboBox1.SelectedValue
                        End If
                        'valores por defecto
                        row.Item("PRFG") = 10
                        row.Item("PRI") = 10
                        row.Item("PRGR") = 20
                        row.Item("ICCFG") = 0
                        row.Item("PRFP") = 0
                        row.Item("TasaIO1") = 5
                        row.Item("TasaIO2") = 4
                        row.Item("TasaM1") = 5
                        row.Item("TasaM2") = 4
                        row.Item("MontoMaximo") = TxtVal_cap.Text
                        row.Item("Caps-Creditos") = 20
                        row.Item("GarantiaFiador") = 20
                        row.Item("Plazo") = 3
                        row.Item("SaldoBk") = 0
                        row.Item("SAFGASTOS") = 0
                        row.Item("VCR") = 1
                        .Rows.Add(row)
                    End With
                    MsgBox("Felicitaciones. Su BK fue creado con exito.")
                    'Application.Exit()
                Else
                    MsgBox("ERROR: Debe Completar todos los Datos Generales del Banko")
                End If
            Else
                MsgBox("ERROR: La Base de Datos ya contiene un BK Con ese mismo codigo")
            End If
        End If
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub CrearBK_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        updating = True
        TxtFecha.Value = Now
        pview = New DataView
        eview = New DataView
        mview = New DataView
        pview.Table = MainDSO.Tables("TblPaises")
        eview.Table = MainDSO.Tables("TblEstados")
        mview.Table = MainDSO.Tables("TblMunicipios")
        Dim pbsource As New BindingSource
        pbsource.DataSource = pview
        TxtPais.DataSource = pbsource

        Dim ebsource As New BindingSource
        ebsource.DataSource = eview
        txtestado.DataSource = ebsource

        Dim mbsource As New BindingSource
        mbsource.DataSource = mview
        txtmunicipio.DataSource = mbsource

        ComboBox1.DataSource = MainDSO.Tables("TblProyectos")
        updating = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtPais.SelectedIndexChanged
        If Not updating And TxtPais.Text <> "" Then
            eview.RowFilter = "PID = " & TxtPais.SelectedValue.ToString
        End If
    End Sub

    Private Sub txtestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtestado.SelectedIndexChanged
        If Not updating And txtestado.Text <> "" Then
            mview.RowFilter = "EID = " & txtestado.SelectedValue.ToString
        End If
    End Sub

    Private Sub txtmunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmunicipio.SelectedIndexChanged
    End Sub
End Class