Option Strict Off
Option Explicit On
Friend Class FilterDlg

    Inherits System.Windows.Forms.Form
    Private ProyectView As DataView
    Private CountryView As DataView
    Private StateView As DataView
    Private ProvinceView As DataView
    Private BankoView As DataView
    Public Field, Estado, Filter As String
    Private Sub ResetButtons(Name As String)
        Select Case Name
            Case Is <> "CheckProyect"
                CheckProyect.Checked = False
            Case Is <> "CheckCountry"
                CheckCountry.Checked = False
            Case Is <> "CheckState"
                CheckState.Checked = False
            Case Is <> "CheckProvince"
                CheckProvince.Checked = False
            Case Is <> "CheckBanko"
                CheckBanko.Checked = False
            Case Is <> "CheckAll"
                CheckBanko.Checked = False
        End Select
    End Sub
    Public Sub BuildStrings()
        If CheckProyect.Checked Then
            Estado = "Proyecto: " & CBProyect.Text
            Filter = "Proyecto=" & CBProyect.SelectedValue
        ElseIf CheckCountry.Checked Then
            Dim previousID As Integer = -1, initialID As Integer = -1
            Estado = "Pais: " & CBCountry.Text
            Filter = BuildFilterStringByCountry(CBCountry.SelectedValue)
        ElseIf CheckState.Checked Then
            Dim previousID As Integer = -1, initialID As Integer = -1
            Estado = "Estado: " & CBState.Text
            Filter = BuildFilterStringByState(CBState.SelectedValue)
        ElseIf CheckProvince.Checked Then
            Estado = "Municipio: " & CBProvince.Text
            Filter = "Municipio=" & CBProvince.SelectedValue
        ElseIf CheckBanko.Checked Then
            Estado = "Banko: " & MainDSO.Tables("TblBanko").Rows.Find(CBBanko.SelectedValue)("NombreBk")
            Filter = "CodBk='" & CBBanko.SelectedValue & "'"
        Else
            Estado = "Todos"
            Filter = ""
        End If
    End Sub
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        BuildStrings()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        BuildStrings()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub
    Private Class ComboItem
        Private mID As String
        Private mName As String
        Public Sub New(ByVal id As String, ByVal name As String)
            mID = id
            mName = name
        End Sub

        Public Property ID As String
            Get
                Return mID
            End Get
            Set(value As String)
                mID = value
            End Set
        End Property
        Public Property Name As String
            Get
                Return mName
            End Get
            Set(value As String)
                mName = value
            End Set
        End Property
    End Class
    Private Function GetComboItems() As Collections.Generic.List(Of ComboItem)
        Dim retval As New Generic.List(Of ComboItem)
        For Each r As DataRowView In BankoView
            retval.Add(New ComboItem(r("CodBk"), r("CodBk") & " | " & r("NombreBk")))
        Next
        Return retval
    End Function
    Private Sub ClasifCreditoxClase_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If Field = "Tipo" Then Me.Text = "..:: Clasificacion de Credito por Tipo ::.."
        ProyectView = New DataView
        ProyectView.Table = MainDSO.TblProyectos
        setBindingSource(CBProyect, ProyectView, TblProyectosBindingSource)
        CountryView = New DataView
        CountryView.Table = MainDSO.TblPaises
        setBindingSource(CBCountry, CountryView, TblPaisesBindingSource)
        StateView = New DataView
        StateView.Table = MainDSO.TblEstados
        setBindingSource(CBState, StateView, TblEstadosBindingSource)
        ProvinceView = New DataView
        ProvinceView.Table = MainDSO.TblMunicipios
        setBindingSource(CBProvince, ProvinceView, TblMunicipiosBindingSource)
        BankoView = New DataView
        BankoView.Table = MainDSO.TblBanko
        TblBankoBindingSource.DataSource = BankoView
        CBBanko.DataSource = GetComboItems()
        CBBanko.DisplayMember = "Name"
        CBBanko.ValueMember = "ID"
    End Sub


    Private Sub CBCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCountry.SelectedIndexChanged
        If Not DataView.Equals(StateView, Nothing) Then
            StateView.RowFilter = "PID=" & CBCountry.SelectedValue
        End If
    End Sub

    Private Sub CBState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBState.SelectedIndexChanged
        If Not DataView.Equals(ProvinceView, Nothing) Then
            ProvinceView.RowFilter = "EID=" & CBState.SelectedValue
        End If
    End Sub

    Private Sub CBProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProvince.SelectedIndexChanged
        If Not DataView.Equals(BankoView, Nothing) Then
            BankoView.RowFilter = "Municipio=" & CBProvince.SelectedValue
        End If
    End Sub


    Private Sub CheckProyect_CheckedChanged(sender As Object, e As EventArgs) Handles CheckProyect.CheckedChanged, CheckState.CheckedChanged, CheckProvince.CheckedChanged, CheckCountry.CheckedChanged, CheckBanko.CheckedChanged, CheckAll.CheckedChanged
        If CType(sender, RadioButton).Checked Then ResetButtons(CType(sender, RadioButton).Name)
    End Sub
End Class