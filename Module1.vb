Option Strict Off
Option Explicit On
Module Module1
    Public openFile As String
    Public ForceSelect As Boolean
    Public FilterCode As String = ""
    Public user As String
    Public uPassword As String
    Public logged As Boolean
    Public tuser As Integer
    Public codi As String
    Public gest As Short 'did we check our balance?
    Public COR As Short
    Public corsaldo As Double
    Public cornum As Double
    Public Const ENCRYPT As Short = 1
    Public Const DECRYPT As Short = 2
    Public rstentrar As MainDS.TblLibroIERow
    Public ThisBanko As MainDS.TblBankoRow
    'Public rstbk2 As DataRow
    Public RstSocio As MainDS.TblSociosRow
    Public rstTasas As DataRow
    Public rstbuscalibro As DataRow
    Public MainDSO As New MainDS()
    Public fechaP As Date
    Public fechaU As Date
    Public fechas As Date
    Public ncod As Double
    Public nominal As Short
    Public cedula As String
    Public saldol As System.Windows.Forms.Label
    Public Libro1 As DataGridView
    Public correccion As Short
    Public fiador1 As String
    Public fiador2 As String
    Public idregistro As Double
    Public CurrentUserPermits As MainDS.TblUserconfigDataTable

    Sub setBindingSource(ByRef obj As ComboBox, ByRef dataSource As Object, ByRef bindingSource As BindingSource)
        Dim displayMember As String = obj.DisplayMember
        Dim valueMember As String = obj.ValueMember
        obj.DataSource = Nothing
        bindingSource.DataSource = dataSource
        obj.DataSource = bindingSource
        obj.DisplayMember = displayMember
        obj.ValueMember = valueMember
    End Sub

    Function FindPermit(ID As Integer, var As String) As String
        Dim retval As String = ""
        If CurrentUserPermits.Rows.Contains({ID, var}) Then
            retval = CurrentUserPermits.Rows.Find({ID, var})("val")
        End If
        Return retval
    End Function
    Function NextIdReg() As Integer
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblLibroIE")
        view.Sort = "IdReg"
        If view.Count = 0 Then
            Return 0
        Else
            Return CInt(view(view.Count - 1)("IdReg")) + 1
        End If
    End Function
    Function SQLDate(d As Date) As String
        Return d.Year & "-" & d.Month & "-" & d.Day
    End Function

    Sub ShowProgressBar(ByRef form As Form, ByRef pb As ProgressBar, ByRef lbl As Label)
        form.Size = New Size(450, 100)
        form.ControlBox = False
        form.MaximizeBox = False
        form.MinimizeBox = False
        pb.Step = 1
        pb.Value = 0
        pb.Size = New Size(400, 20)
        pb.Left = 25
        pb.Top = 50
        pb.Name = "Pb"
        form.Controls.Add(pb)
        lbl.Top = 25
        lbl.Left = 25
        lbl.Visible = True
        form.Controls.Add(lbl)
    End Sub
    Sub LibroSaldo(IdReg As Double, Optional fix As Boolean = False)
        Dim saldo As Double = 0
        saldo = recalcula()
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblLibroIE")
        view.RowFilter = "Anulado=0 AND IdBK='" & ThisBanko("CodBk") & "'" & IIf(fix, "", " AND bloqueo=0")
        view.Sort = "Fecha,NoRecibo,IdReg"
        If view.Count > 0 Then

            Dim reg As Integer
            If IdReg = 0 Then
                reg = 0
            Else
                For i As Integer = 0 To view.Count - 1
                    If Double.Parse(view(i)("IdReg")) = IdReg Then
                        reg = i
                        Exit For
                    End If
                Next
            End If

            If fix Then
                reg = 0
                saldo = 0
            End If

            If reg > 0 Then
                saldo = view(reg - 1).Row("Saldo")
            End If

            If reg <= view.Count - 1 Then
                'Se recalcula el saldo del libro
                Dim cod As String = ""
                For i As Integer = reg To view.Count - 1
                    cod = view(i)("codope")
                    If cod <> "BA" And
                        cod <> "AR" And
                        cod <> "DO2" And
                        cod <> "ICP" Then
                        view(i)("Saldo") = saldo + view(i)("Ingreso") - view(i)("Egreso")
                        saldo = view(i)("Saldo")
                    Else
                        view(i)("Saldo") = saldo
                    End If
                Next
            End If
        End If
        ThisBanko("SaldoBk") = saldo
    End Sub

    Sub LibroAdd(row As MainDS.TblLibroIERow)
        row.IdReg = NextIdReg()
        row.Anulado = 0
        row.Bloqueo = 0
        If MainDSO.TblLibroIE.Rows.Contains({row.IdBK, row.Fecha, row.NoRecibo, row.CodOpe}) Then
            MsgBox("No puede insertar registros duplicados en el Libro I/E")
        Else
            MainDSO.TblLibroIE.Rows.Add(row)
            LibroSaldo(row.IdReg)
            If (row.CodOpe = "CON" Or row.CodOpe = "COR" Or row.CodOpe = "PC") And Not row.Descripcion.Contains("Ret.") Then
                If MsgBox("¿Desea crear un registro de intereses ordinarios?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim Socios As New DataView
                    Dim Credito As New DataView
                    Dim f As New ORD
                    Credito.Table = MainDSO.TblCredito
                    Credito.Sort = "NoCredito"
                    Credito.RowFilter = "IdOp='0' AND NoCredito='" & row("NoCredito") & "'"
                    For Each r As DataRowView In Credito
                        If MainDSO.TblSocios.Rows.Contains(r("VCI")) Then
                            f.CORCredito.Items.Add(r("NoCredito"))
                        End If
                    Next
                    If MainDSO.TblSocios.Rows.Contains(Credito(0)("VCI")) Then
                        Dim rstnombre As MainDS.TblSociosRow = MainDSO.TblSocios.Rows.Find(Credito(0)("VCI"))
                        f.Label32.Text = "Nombres: " + rstnombre.Nombres
                        f.Label62.Text = "Acciones: " & Str(rstnombre.cap)
                        f.Label63.Text = "Saldo: " & VB6.Format(Credito(0)("Saldo"), "###,##0.00")
                        f.Label64.Text = Str(rstnombre.CI)
                        f.Label32.Visible = True
                        f.Label62.Visible = True
                        f.Label63.Visible = True
                        f.Label64.Visible = True
                        f.Label69.Visible = True
                    End If


                    f.TORFecha.Value = Date.Now
                    fechas = Fcod(fechaU, ncod)
                    f.TORNumero.Text = ncod
                    f.CORCredito.Text = row.NoCredito
                    f.AutoClose = True
                    f.ShowDialog()
                End If
            End If
            If row.CodOpe = "PC" And Not row.Descripcion.Contains("Ret.") Then
                If MsgBox("¿Desea crear un registro de intereses de mora?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim Creditos As New DataView
                    Dim f As New MO
                    Creditos.Table = MainDSO.TblCredito
                    Creditos.Sort = "NoCredito"
                    Creditos.RowFilter = "IdOp='0' AND NoCredito='" & row.NoCredito & "'"
                    For Each r As DataRowView In Creditos
                        If MainDSO.TblSocios.Rows.Contains(r("VCI")) Then
                            f.TMOCredito.Items.Add(r("NoCredito"))
                        End If
                    Next

                    If MainDSO.TblSocios.Rows.Contains(Creditos(0)("VCI")) Then
                        Dim rstnombre As MainDS.TblSociosRow = MainDSO.TblSocios.Rows.Find(Creditos(0)("VCI"))
                        f.Label65.Text = "Nombres: " + rstnombre.Nombres
                        f.Label67.Text = "Acciones: " & Str(rstnombre.cap)
                        f.Label68.Text = "Saldo:" & Str(Creditos(0)("Saldo"))
                        f.Label66.Text = Str(rstnombre.CI)
                        f.Label65.Visible = True
                        f.Label66.Visible = True
                        f.Label67.Visible = True
                        f.Label68.Visible = True
                        f.Label70.Visible = True
                    End If
                    f.TMOFecha.Value = Date.Now
                    fechas = Fcod(fechaU, ncod)
                    f.TMONumero.Text = ncod
                    f.TMOCredito.Text = row.NoCredito
                    f.TMOMonto.Text = ""
                    f.AutoClose = True
                    f.ShowDialog()
                End If
            End If
        End If
    End Sub

    Function LibroFind(reg As Double) As DataRow
        Dim view As New DataView
        view.Table = MainDSO.TblLibroIE
        view.RowFilter = "IdReg=" + reg
        Return view(0).Row
    End Function

    Sub Init()
        Try
            Dim path As String
            If My.Application.CommandLineArgs.Count > 0 Then
                path = My.Application.CommandLineArgs(0)
            Else
                path = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData(0)
                Dim uri As New Uri(path)
                If uri.IsFile Then
                    path = uri.LocalPath
                End If
            End If
            MsgBox("Cargando data de: " & path)
            Dim save As String = My.Settings.SaveData
            My.Settings.SaveData = path
            My.Settings.Save()
            LoadOffline(MainDSO)
            My.Settings.SaveData = save
            My.Settings.Save()
        Catch ex As Exception
            If HaveInternetConnection() Then
                LoadOnline(MainDSO)
            Else
                LoadOffline(MainDSO)
            End If
        End Try
        'checks if being started from a file. If so, it loads only file data.


        'Filter data
        If Not ForceSelect And FilterCode <> "" Then 'No point in filtering twice or filtering with no filter
            FilterTables(FilterCode, MainDSO)
        End If

        'Set missing keys

        For Each t As DataTable In MainDSO.Tables
            If t.PrimaryKey.Length = 0 Then
                SetKeys(t)
            End If
        Next

        ThisBanko = MainDSO.TblBanko.FindByCodBk(codi)
    End Sub

    Public Function HaveInternetConnection() As Boolean
        If My.Settings.Offline Then
            Return False
        Else
            Try
                Debug.WriteLine("Testing connection...")
                Return My.Computer.Network.Ping("www.fundefir.org")
            Catch e As Exception
                Debug.WriteLine(e.Message)
                Return False
            End Try
        End If
    End Function
    Sub GetTableList(ByRef DS As MainDS)
        With DS.Tables
            If Not .Contains("ClasifCreditos") Then
                .Add(New MainDS.ClasifCreditosDataTable())
            End If
            If Not .Contains("Gestion") Then
                .Add(New MainDS.GestionDataTable())
            End If
            If Not .Contains("gestiontemp") Then
                .Add(New MainDS.gestiontempDataTable())
            End If
            If Not .Contains("MovAcumulado") Then
                .Add(New MainDS.MovAcumuladoDataTable())
            End If
            If Not .Contains("RptConsolidado") Then
                .Add(New MainDS.RptConsolidadoDataTable())
            End If
            If Not .Contains("TblAnulaciones") Then
                .Add(New MainDS.TblAnulacionesDataTable())
            End If
            If Not .Contains("TblBanko") Then
                .Add(New MainDS.TblBankoDataTable())
            End If
            If Not .Contains("TblBenef") Then
                .Add(New MainDS.TblBenefDataTable())
            End If
            If Not .Contains("TblClaseCredito") Then
                .Add(New MainDS.TblClaseCreditoDataTable())
            End If
            If Not .Contains("TblCodCCr") Then
                .Add(New MainDS.TblCodCCrDataTable())
            End If
            If Not .Contains("TblCorrige") Then
                .Add(New MainDS.TblCorrigeDataTable())
            End If
            If Not .Contains("TblCredito") Then
                .Add(New MainDS.TblCreditoDataTable())
            End If
            If Not .Contains("TblFiadores") Then
                .Add(New MainDS.TblFiadoresDataTable())
            End If
            If Not .Contains("TblLibroIE") Then
                .Add(New MainDS.TblLibroIEDataTable())
            End If
            If Not .Contains("TblLibroIETemp") Then
                .Add(New MainDS.TblLibroIETempDataTable())
            End If
            If Not .Contains("TblMesbloqueado") Then
                .Add(New MainDS.TblMesbloqueadoDataTable())
            End If
            If Not .Contains("TblOperacion") Then
                .Add(New MainDS.TblOperacionDataTable())
            End If
            If Not .Contains("tblreportecred") Then
                .Add(New MainDS.tblreportecredDataTable())
            End If
            If Not .Contains("TblSocios") Then
                .Add(New MainDS.TblSociosDataTable())
            End If
            If Not .Contains("tblTope") Then
                .Add(New MainDS.tblTopeDataTable())
            End If
            If Not .Contains("tblTraspasos") Then
                .Add(New MainDS.tblTraspasosDataTable())
            End If
            If Not .Contains("tblUsuario") Then
                .Add(New MainDS.tblUsuarioDataTable())
            End If
            If Not .Contains("TipoCredito") Then
                .Add(New MainDS.TipoCreditoDataTable())
            End If
            If Not .Contains("TblMunicipios") Then
                .Add(New MainDS.TblMunicipiosDataTable())
            End If
            If Not .Contains("TblEstados") Then
                .Add(New MainDS.TblEstadosDataTable())
            End If
            If Not .Contains("TblPaises") Then
                .Add(New MainDS.TblPaisesDataTable())
            End If
            If Not .Contains("TblProyectos") Then
                .Add(New MainDS.TblProyectosDataTable())
            End If
            If Not .Contains("TblUserConfig") Then
                .Add(New MainDS.TblUserconfigDataTable())
            End If
        End With
    End Sub
    Public Sub LoadOffline(ByRef DS As MainDS)

        GetTableList(DS)
        If My.Settings.SaveData <> "" Then
            If Not IO.File.Exists(My.Settings.SaveData) Then
                My.Settings.SaveData = ""
            End If
        End If
        Dim file As IO.StreamReader
        If My.Settings.SaveData = "" Then
            Dim openfileDlg As New OpenFileDialog()
            openfileDlg.Filter = "Respaldo BkSistema (*.bks)|*.bks"
            openfileDlg.AddExtension = True
            openfileDlg.Title = "Seleccionar el archivo de respaldo"
            openfileDlg.ShowDialog()
            My.Settings.SaveData = openfileDlg.FileName
            My.Settings.Save()
        End If

        Try
            file = My.Computer.FileSystem.OpenTextFileReader(My.Settings.SaveData)
            DS = JsonConvert.DeserializeObject(Of MainDS)(file.ReadToEnd())
            file.Close()
        Catch ex As System.ArgumentNullException
            MsgBox("No puede iniciar en modo Offline sin un archivo de data...")
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadOnline(ByRef DS As MainDS)
        GetTableList(DS)
        Dim adapter As New DatabaseWebAdapter
        Dim filler As New DatabaseWebAdapter.FillAsync(AddressOf adapter.FillByCommandStr)
        adapter.SelectCommand = New DatabaseWebCommand("", New DatabaseWebConnection(My.Settings.ConnectionString))
        Dim dlg As New Form
        Dim pb As New ProgressBar
        Dim lbl As New Label
        lbl.Text = "Cargando data..."
        ShowProgressBar(dlg, pb, lbl)
        pb.Maximum = DS.Tables.Count
        pb.Step = 1
        dlg.Show()
        adapter.SelectCommand.CommandText = "SELECT * FROM TblBanko"
        adapter.Fill(DS)
        Dim municipio As String = ""
        Dim proyecto As String
        If ForceSelect Then
            ThisBanko = DS.Tables("TblBanko").Rows.Find(codi)
            municipio = ThisBanko("Municipio").ToString
            proyecto = ThisBanko("Proyecto").ToString
        End If
        Dim AsyncResults As New Generic.List(Of IAsyncResult)
        For Each t As DataTable In DS.Tables
            Try
                Debug.WriteLine("Loading table: " & t.TableName)
                Dim command As String = "SELECT * FROM " + t.TableName
                If ForceSelect Then
                    Select Case t.TableName
                        Case "Gestion"
                            command += " WHERE CodBK = '" + codi + "'"
                        Case "gestiontemp"
                            command += " WHERE codBK = '" + codi + "'"
                        Case "TblBanko"
                            command += " WHERE CodBk='" + codi + "'"
                        Case "TblBenef"
                            command += " WHERE CodBK = '" + codi + "'"
                        Case "TblCorrige"
                            command += " WHERE codbK = '" + codi + "'"
                        Case "TblCredito"
                            command += " WHERE VBK = '" + codi + "'"
                        Case "TblFiadores"
                            command += " WHERE CodBK = '" + codi + "'"
                        Case "TblLibroIE"
                            command += " WHERE IdBK = '" + codi + "'"
                        Case "TblMesbloqueado"
                            command += " WHERE codBanco = '" + codi + "'"
                        Case "TblSocios"
                            command += " WHERE CodBK = '" + codi + "'"
                        Case "tblreportecred"
                            command += " WHERE codbK = '" + codi + "'"
                        Case "tblTraspasos"
                            command += " WHERE idbk = '" + codi + "'"
                        Case "tblUsuario"
                            command += " WHERE Bk = '" + codi + "'"
                        Case "TblPaises"
                            command += " WHERE ID = (SELECT PID FROM TblEstados WHERE ID = (SELECT EID FROM TblMunicipios WHERE ID = '" & municipio & "'))"
                        Case "TblEstados"
                            command += " WHERE ID = (SELECT EID FROM TblMunicipios WHERE ID = '" & municipio & "')"
                        Case "TblMunicipios"
                            command += " WHERE ID = '" & municipio & "'"
                        Case "TblProyectos"
                            command += " WHERE ID = '" & municipio & "'"
                    End Select
                End If
                If My.Settings.AsyncLoading Then
                    AsyncResults.Add(filler.BeginInvoke(DS, command, Nothing, Nothing))
                Else
                    lbl.Text = "Cargando data... " & pb.Value + 1 & "/" & pb.Maximum + 1 & ""
                    pb.PerformStep()
                    adapter.SelectCommand.CommandText = command
                    adapter.Fill(DS)
                End If
            Catch ex As RowNotInTableException
                Debug.WriteLine(ex.Message & vbNewLine & ex.Source & vbNewLine & ex.StackTrace)
            Catch ex As Exception
                Debug.WriteLine(ex.Message & vbNewLine & ex.Source & vbNewLine & ex.StackTrace)
            End Try
        Next
        While AsyncResults.Count > 0
            Dim i As Integer = 0
            Dim r As Boolean = False
            For Each result As IAsyncResult In AsyncResults
                If result.IsCompleted Then
                    Dim j As Integer = filler.EndInvoke(result)
                    'Debug.WriteLine(j)
                    i = AsyncResults.IndexOf(result)
                    r = True
                    Exit For
                End If
            Next
            If r Then
                lbl.Text = "Cargando data... " & pb.Value + 1 & "/" & pb.Maximum + 1 & ""
                pb.PerformStep()
                AsyncResults.RemoveAt(i)
                r = False
            End If
        End While
        dlg.Close()
    End Sub

    Public Function CreateCustomFilter(var As String, values As Generic.List(Of String)) As String
        Dim retval As String = ""
        If var <> "" Then
            For Each v As String In values
                If retval.Length > 0 Then
                    retval = retval & " or "
                End If
                retval = retval & var & "='" & v & "'"
            Next
        End If
        Return retval
    End Function

    Private Function GetFieldByTable(table As String) As String
        Dim retval As String = ""
        Select Case table
            Case "Gestion"
                retval = "CodBK"
            Case "gestiontemp"
                retval = "codBK"
            Case "TblBanko"
                retval = "CodBk"
            Case "TblBenef"
                retval = "CodBK"
            Case "TblCorrige"
                retval = "codbK"
            Case "TblCredito"
                retval = "VBK"
            Case "TblFiadores"
                retval = "CodBK"
            Case "TblLibroIE"
                retval = "IdBK"
            Case "TblMesbloqueado"
                retval = "codBanco"
            Case "TblSocios"
                retval = "CodBK"
            Case "tblreportecred"
                retval = "codbK"
            Case "tblTraspasos"
                retval = "idbk"
            Case "tblUsuario"
                retval = "Bk"
        End Select
        Return retval
    End Function

    Private Sub ApplyFilter(ByRef ds As DataSet, filter As String, t As String)
        Debug.WriteLine("Filter: " & t & " : " & filter)
        Dim view As New DataView
        Dim tbl As DataTable
        view.Table = ds.Tables(t)
        view.RowFilter = filter
        tbl = view.ToTable
        ds.Tables(t).Clear()
        For Each r As DataRow In tbl.Rows
            ds.Tables(t).ImportRow(r)
        Next
    End Sub
    Public Sub FilterTables(filter As String, ByRef ds As MainDS)
        ApplyFilter(ds, filter, "TblBanko")
        Dim tbl As MainDS.TblBankoDataTable = ds.TblBanko
        Dim bks As New Generic.List(Of String)
        Dim proyectos As New Generic.List(Of String)
        Dim paises As New Generic.List(Of String)
        Dim estados As New Generic.List(Of String)
        Dim municipios As New Generic.List(Of String)
        Dim tables As New Generic.List(Of String)

        For Each r As MainDS.TblBankoRow In tbl.Rows
            If Not bks.Contains(r.CodBk) Then 'Creando lista de bks
                bks.Add(r.CodBk)
            End If
            If Not proyectos.Contains(r.Proyecto) Then 'Creando lista de proyectos
                proyectos.Add(r.Proyecto)
            End If
            If Not municipios.Contains(r.Municipio) Then 'Creando lista de Municipios
                municipios.Add(r.Municipio)
            End If
        Next

        For Each t As DataTable In ds.Tables 'Creando lista de tablas
            tables.Add(t.TableName)
        Next

        For Each t As String In tables 'Aplicar filtro x bk a lista de tablas
            ApplyFilter(ds, CreateCustomFilter(GetFieldByTable(t), bks), t)
        Next

        ApplyFilter(ds, CreateCustomFilter("ID", proyectos), "TblProyectos")
        ApplyFilter(ds, CreateCustomFilter("ID", municipios), "TblMunicipios")

        For Each r As MainDS.TblMunicipiosRow In ds.TblMunicipios.Rows 'Creando lista de estados
            If Not estados.Contains(r.EID) Then
                estados.Add(r.EID)
            End If
        Next
        ApplyFilter(ds, CreateCustomFilter("ID", estados), "TblEstados")

        For Each r As MainDS.TblEstadosRow In ds.TblEstados.Rows 'Creando lista de paises
            If Not paises.Contains(r.PID) Then
                paises.Add(r.PID)
            End If
        Next
        ApplyFilter(ds, CreateCustomFilter("ID", paises), "TblPaises")
    End Sub
    Public Sub SetKeys(dTable As DataTable)
        Debug.WriteLine("Setting Keys for: " & dTable.TableName)
        Select Case dTable.TableName
            Case "ClasifCreditos"
                dTable.PrimaryKey = {dTable.Columns("CodTipo")}
            Case "Gestion"
                dTable.PrimaryKey = {dTable.Columns("idgestion"), dTable.Columns("codBK")}
            Case "gestiontemp"
                dTable.PrimaryKey = {dTable.Columns("idgestion"), dTable.Columns("codBK")}
            Case "MovAcumulado"
                dTable.PrimaryKey = {dTable.Columns("BanKo")}
            Case "RptConsolidado"
                dTable.PrimaryKey = {dTable.Columns("CantdeBk")}
            Case "TblBanko"
                dTable.PrimaryKey = {dTable.Columns("CodBk")}
            Case "TblBenef"
                dTable.PrimaryKey = {dTable.Columns("IdReq")}
            Case "TblClaseCredito"
                dTable.PrimaryKey = {dTable.Columns("CodClase")}
            Case "TblCodCCr"
                dTable.PrimaryKey = {dTable.Columns("idCC")}
            Case "TblCorrige"
                dTable.PrimaryKey = {dTable.Columns("id")}
            Case "TblCredito"
                dTable.PrimaryKey = {dTable.Columns("VBK"), dTable.Columns("NoCredito")}
            Case "TblFiadores"
                dTable.PrimaryKey = {dTable.Columns("CodBk"), dTable.Columns("NoCredito"), dTable.Columns("CI")}
            Case "TblLibroIE"
                dTable.PrimaryKey = {dTable.Columns("IdBK"), dTable.Columns("Fecha"), dTable.Columns("NoRecibo"), dTable.Columns("CodOpe")}
            Case "TblLibroIETemp"
                dTable.PrimaryKey = {dTable.Columns("IdReq")}
            Case "TblMesbloqueado"
                dTable.PrimaryKey = {dTable.Columns("codBanco"), dTable.Columns("FechaG")}
            Case "TblMunicipios"
                dTable.PrimaryKey = {dTable.Columns("Municipios")}
            Case "TblOperacion"
                dTable.PrimaryKey = {dTable.Columns("CodOPe")}
            Case "tblreportecred"
                'dTable.PrimaryKey = {dTable.Columns("CodClase")}
            Case "TblSocios"
                dTable.PrimaryKey = {dTable.Columns("CI")}
            Case "tblTope"
                dTable.PrimaryKey = {dTable.Columns("tope")}
            Case "tblTraspasos"
                dTable.PrimaryKey = {dTable.Columns("iDreq"), dTable.Columns("idbk")}
            Case "tblUsuario"
                dTable.PrimaryKey = {dTable.Columns("Usuario")}
            Case "TipoCredito"
                dTable.PrimaryKey = {dTable.Columns("Clase")}
            Case "TblPaises"
                dTable.PrimaryKey = {dTable.Columns("ID")}
            Case "TblEstados"
                dTable.PrimaryKey = {dTable.Columns("ID")}
            Case "TblMunicipios"
                dTable.PrimaryKey = {dTable.Columns("ID")}
            Case "TblProyectos"
                dTable.PrimaryKey = {dTable.Columns("ID")}
            Case "TblAnulaciones"
                dTable.PrimaryKey = {dTable.Columns("ID")}
            Case "TblUserConfig"
                dTable.PrimaryKey = {dTable.Columns("User"), dTable.Columns("var")}
        End Select

    End Sub

    Function recalcula() As Double
        Dim saldo As Double = 0
        Dim rstsaldogestion As New DataView
        rstsaldogestion.Table = MainDSO.Tables("Gestion")
        rstsaldogestion.Sort = "FInicio"

        If rstsaldogestion.Count = 0 Then
            saldo = 0
        Else
            saldo = rstsaldogestion(rstsaldogestion.Count - 1)("DECIERRE")
        End If
        Return saldo
    End Function

    'Funcion que verifica si existe el NoOperacion y la fecha
    Public Function BuscaLibro(ByRef fechaop As Date, ByRef nop As Double, ByRef op As String, ByRef existe As Short) As Object
        Dim rstbusca As DataTable
        Dim dia As String
        Dim mes As String
        Dim ano As String
        dia = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Day, fechaop))
        mes = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Month, fechaop))
        ano = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Year, fechaop))
        rstbusca = MainDSO.Tables("TblLibroIE")
        If rstbusca.Rows.Contains({codi, SQLDate(fechaop), nop, op}) Then
            existe = 1
            idregistro = rstbusca.Rows.Find({codi, SQLDate(fechaop), nop, op})("IdReg")
        Else
            existe = 0
        End If
        Return idregistro
    End Function

    Public Function LastOp() As Integer
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblLibroIE")
        view.Sort = "NoRecibo DESC"
        Dim retval As Double = 0
        If view.Count > 0 Then retval = view(0)("NoRecibo")
        Return retval
    End Function
    'Calculo de la ultima fecha y el ultimo codigo del libro
    Public Function Fcod(ByRef fechaU As Date, ByRef ncod As Double) As Date
        Dim rstfecha As New DataView
        rstfecha.Table = MainDSO.Tables("TblLibroIE")
        'rstfecha.RowFilter = "Anulado=0"
        rstfecha.Sort = "Fecha,NoRecibo,IdReg"
        If rstfecha.Count > 0 Then
            ncod = rstfecha(rstfecha.Count - 1)("NoRecibo") + 1
            fechaU = rstfecha(rstfecha.Count - 1)("fecha")
        Else
            fechaU = Now
            ncod = 1
        End If
        Return fechaU
    End Function

    'Calcula la primera fecha abierta en el libro
    Public Function fechaLIE(ByRef fechaP As Date, ByRef fechaU As Date, ByRef mesgestion As Date) As Date
        Dim rstfecha As New DataView
        Dim rstmesgestion As New DataView
        rstfecha.Table = MainDSO.Tables("TblLibroIE")
        rstfecha.RowFilter = "bloqueo=0 AND Anulado=0"
        rstfecha.Sort = "Fecha,NoRecibo,IdReg"
        rstmesgestion.Table = MainDSO.Tables("Gestion")
        rstmesgestion.Sort = "FCorte"
        If rstfecha.Count > 0 Then
            fechaP = rstfecha(0)("fecha")
            fechaU = rstfecha(rstfecha.Count - 1)("fecha")
        Else
            fechaP = Now
            fechaU = Now
        End If
        If rstmesgestion.Count > 0 Then
            mesgestion = rstmesgestion(rstmesgestion.Count - 1)("FCorte")
        Else
            mesgestion = CDate("01/01/1989")
        End If
    End Function

    Public Function Decode(s As String, encode As Boolean) As String
        Dim dic As New Collections.Generic.Dictionary(Of String, String)
        dic.Add("**192", "À")
        dic.Add("**193", "Á")
        dic.Add("**194", "Â")
        dic.Add("**195", "Ã")
        dic.Add("**196", "Ä")
        dic.Add("**197", "Å")
        dic.Add("**198", "Æ")
        dic.Add("**199", "Ç")
        dic.Add("**200", "È")
        dic.Add("**201", "É")
        dic.Add("**202", "Ê")
        dic.Add("**203", "Ë")
        dic.Add("**204", "Ì")
        dic.Add("**205", "Í")
        dic.Add("**206", "Î")
        dic.Add("**207", "Ï")
        dic.Add("**208", "Ð")
        dic.Add("**209", "Ñ")
        dic.Add("**210", "Ò")
        dic.Add("**211", "Ó")
        dic.Add("**212", "Ô")
        dic.Add("**213", "Õ")
        dic.Add("**214", "Ö")
        dic.Add("**215", "×")
        dic.Add("**216", "Ø")
        dic.Add("**217", "Ù")
        dic.Add("**218", "Ú")
        dic.Add("**219", "Û")
        dic.Add("**220", "Ü")
        dic.Add("**221", "Ý")
        dic.Add("**222", "Þ")
        dic.Add("**223", "ß")
        dic.Add("**224", "à")
        dic.Add("**225", "á")
        dic.Add("**226", "â")
        dic.Add("**227", "ã")
        dic.Add("**228", "ä")
        dic.Add("**229", "å")
        dic.Add("**230", "æ")
        dic.Add("**231", "ç")
        dic.Add("**232", "è")
        dic.Add("**233", "é")
        dic.Add("**234", "ê")
        dic.Add("**235", "ë")
        dic.Add("**236", "ì")
        dic.Add("**237", "í")
        dic.Add("**238", "î")
        dic.Add("**239", "ï")
        dic.Add("**240", "ð")
        dic.Add("**241", "ñ")
        dic.Add("**242", "ò")
        dic.Add("**243", "ó")
        dic.Add("**244", "ô")
        dic.Add("**245", "õ")
        dic.Add("**246", "ö")
        dic.Add("**247", "÷")
        dic.Add("**248", "ø")
        dic.Add("**249", "ù")
        dic.Add("**250", "ú")
        dic.Add("**251", "û")
        dic.Add("**252", "ü")
        dic.Add("**253", "ý")
        dic.Add("**254", "þ")
        dic.Add("**255", "ÿ")

        dic.Add(",`Caps-Creditos`=", ",Caps-Creditos=")
        For Each p As Collections.Generic.KeyValuePair(Of String, String) In dic
            Dim sOld, sNew As String
            If Not encode Then 'decoding
                sOld = p.Key
                sNew = p.Value
            Else                'encoding
                sOld = p.Value
                sNew = p.Key
            End If
            If s.Contains(sOld) Then
                s = s.Replace(sOld, sNew)
            End If
        Next
        Return s
    End Function
    Public Function EncryptStringDec(ByRef UserKey As String, ByRef Text As String, ByRef Action As Single) As String
        Dim Temp As Short
        Dim i As Short
        Dim j As Short
        Dim n As Short
        Dim rtn As String = ""

        Dim cadn As String = ""
        Dim rsttope2 As New DataView
        Dim rsttope As DataRow
        '//Get UserKey characters
        n = Len(UserKey)
        Dim UserKeyASCIIS(n) As Object
        For i = 1 To n
            UserKeyASCIIS(i) = Asc(Mid(UserKey, i, 1))
        Next

        '//Get Text characters
        Dim textasciis(Len(Text)) As Short

        'ReDim cadn(Len(Text)) As Integer

        For i = 1 To Len(Text)
            textasciis(i) = Asc(Mid(Text, i, 1))
        Next
        '//Encryption/Decryption
        If Action = ENCRYPT Then
            For i = 1 To Len(Text)
                j = IIf(j + 1 >= n, 1, j + 1)
                Temp = textasciis(i) + UserKeyASCIIS(j) - i * 10
                If Temp > 255 Then
                    Temp = Temp - 255
                End If
                cadn = cadn & "-" & CStr(Temp)
                rtn = rtn & Chr(Temp)
            Next
            MsgBox(cadn)
        ElseIf Action = DECRYPT Then
            For i = 1 To Len(Text)
                j = IIf(j + 1 >= n, 1, j + 1)
                Temp = textasciis(i) - UserKeyASCIIS(j) + i * 10
                If Temp < 0 Then
                    Temp = Temp + 255
                End If
                rtn = rtn & Chr(Temp)
            Next
        End If
        '//Return
        EncryptStringDec = rtn
        rsttope = ThisBanko
        If ((rsttope("CodBk") = rtn) <> CBool("")) Then
            rsttope2.Table = MainDSO.Tables("TblTope")
            rsttope2(0)("tope") = DateAdd(Microsoft.VisualBasic.DateInterval.Month, 4, rsttope2(0)("tope"))
            MsgBox("Clave ***AUTORIZADA***. " & vbCrLf & "El Sistema se Cerrara. Vuelva a ingresar normalmente")
            End
        Else
            MsgBox("Clave ***NO AUTORIZADA***. " & vbCrLf & "Comuníquese con su proveedor y solicite" & vbCrLf & "una autorización para activar la licencia", MsgBoxStyle.Information)
        End If
    End Function

    Public Sub DataGridViewErrorHandler(sender As Object, e As DataGridViewDataErrorEventArgs)
        Dim dg As DataGridView = sender
        If e.Exception.GetType().ToString().Equals("System.FormatException") Then
            MsgBox("Error de formato. El tipo de data introducida no coincide con el tipo de data esperada." & vbLf & "El valor introducido no es válido para el campo " & dg.Columns(e.ColumnIndex).HeaderText, MsgBoxStyle.Exclamation, "Error!")
        End If
        e.Cancel = True
    End Sub
    Public Sub SaveData()



        If HaveInternetConnection() Then

            Dim adapter As New DatabaseWebAdapter()
            adapter.UpdateCommand = New DatabaseWebCommand("", New DatabaseWebConnection(My.Settings.ConnectionString))
            adapter.Update(MainDSO)

        End If




        If My.Settings.SaveData <> "" Then
            If Not IO.File.Exists(My.Settings.SaveData) Then
                My.Settings.SaveData = ""
            End If
        End If
        Dim rst As DialogResult
        If My.Settings.SaveData = "" Then
            Dim openfileDlg As New SaveFileDialog
            openfileDlg.Filter = "Respaldo BkSistema (*.bks)|*.bks"
            openfileDlg.AddExtension = True
            openfileDlg.Title = "Seleccionar el directorio donde desea respaldar la Data"
            rst = openfileDlg.ShowDialog()
            If rst = DialogResult.OK Then
                My.Settings.SaveData = openfileDlg.FileName
                My.Settings.Save()
            End If
        End If
        If rst = DialogResult.OK And My.Settings.SaveData <> "" Then
            Dim file As IO.StreamWriter
            Try
                file = My.Computer.FileSystem.OpenTextFileWriter(My.Settings.SaveData, False)
                file.Write(JsonConvert.SerializeObject(MainDSO))
                file.Close()
                MessageBox.Show("Respaldo exitoso!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Public Function BuildFilterStringByCountry(PID As Integer) As String
        Dim municipios As New Generic.List(Of Integer),
            estadosView As New DataView,
            municipiosView As New DataView
        estadosView.Table = MainDSO.TblEstados
        municipiosView.Table = MainDSO.TblMunicipios
        estadosView.RowFilter = "PID=" & PID
        For Each r As DataRowView In estadosView
            municipiosView.RowFilter = "EID=" & r("ID")
            For Each c As DataRowView In municipiosView
                municipios.Add(c("ID"))
            Next
        Next
        Return BuildFilterString(municipios, "Municipio")
    End Function
    Public Function BuildFilterStringByState(EID As Integer) As String
        Dim municipios As New Generic.List(Of Integer),
            municipiosView As New DataView
        municipiosView.Table = MainDSO.TblMunicipios
        municipiosView.RowFilter = "EID=" & EID
        For Each c As DataRowView In municipiosView
            municipios.Add(c("ID"))
        Next
        Return BuildFilterString(municipios, "Municipio")
    End Function
    Public Function BuildFilterString(list As Generic.List(Of Integer), field As String) As String
        Dim initialValue As Integer, currentValue As Integer, previousValue As Integer = -1, filter As String = ""
        list.Sort()
        If list.Count > 0 Then
            initialValue = list(0)
            For Each n As Integer In list
                currentValue = n
                If previousValue >= 0 And previousValue + 1 <> currentValue Then
                    If initialValue = previousValue Then
                        filter = filter & field & "=" & initialValue & " OR "
                    Else
                        filter = filter & "(" & field & ">=" & initialValue & " AND " & field & "<=" & previousValue & ") OR "
                    End If
                    initialValue = currentValue
                End If
                previousValue = currentValue
            Next
            If previousValue <> initialValue Then
                filter = filter & field & ">=" & initialValue & " AND " & field & "<=" & previousValue
            Else
                If filter.Length > 0 Then
                    filter = filter.Substring(0, filter.Length - 4)
                End If
            End If
        End If
        Return filter
    End Function
    Public Function getDbValue(reader As OleDb.OleDbDataReader, field As String)
        If (IsDBNull(reader(field))) Then
            Throw New Exception("El campo '" & field & "' en la tabla '" & reader.GetSchemaTable().Rows(0)("BaseTableName") & "' tiene un valor nulo, por favor corrija el archivo e intente de nuevo." & vbNewLine & "Archivo: " & openFile)
        Else
            Return reader(field)
        End If
    End Function
End Module