Public Class Procesar

    Private Sub Procesar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstFiles.DisplayMember = "Name"
        LstFiles.ValueMember = "BKS"
    End Sub

    Private fileList As New Generic.List(Of BKfile)
    Private Class BKfile
        Private _name
        Default Property Name(ByVal n As String) As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property
        Public path As String
        Public BKS As Generic.List(Of Banko)
        Public Sub New(p As String, l As Generic.List(Of Banko))
            BKS = l
            path = p
            _name = p.Substring(p.LastIndexOf("\") + 1)
        End Sub
        Public Overrides Function ToString() As String
            Return _name
        End Function
    End Class
    Private Class Banko
        Public CodBk As String
        Public Nombre As String
        Public Checked As CheckState
        Sub New(c As String, n As String, b As CheckState)
            CodBk = c
            Nombre = n
            Checked = b
        End Sub
    End Class
    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        'Abrir archivo access
        Dim fileDlg As New OpenFileDialog()
        fileDlg.Filter = "Base de Datos BKSistema viejo (*.mdb)|*.mdb"
        fileDlg.Title = "Seleccione el archivo a cargar..."
        fileDlg.Multiselect = True
        fileDlg.ShowDialog()
        For Each path As String In fileDlg.FileNames
            Using objConn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path)
                Try
                    objConn.Open()
                    Dim command As New OleDb.OleDbCommand("SELECT * FROM TblBanko", objConn)
                    Dim reader As OleDb.OleDbDataReader = command.ExecuteReader()
                    'Leer Bankos y agregar a lista de bankos en archivo
                    Dim bankoLst As New Generic.List(Of Banko)
                    While reader.Read()
                        bankoLst.Add(New Banko(reader("CodBk"), reader("NombreBK"), CheckState.Checked))
                    End While
                    'agregar archivo, lista de bankos a lista de archivos
                    fileList.Add(New BKfile(path, bankoLst))
                Catch ex As Exception
                    Debug.WriteLine(ex.Message & vbNewLine & ex.Source & vbNewLine & ex.StackTrace)
                End Try
            End Using
        Next
        LstFiles.Items.Clear()
        For Each file As BKfile In fileList
            LstFiles.Items.Add(file)
        Next
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Eliminar bankos x archivo.
        If LstFiles.SelectedItems.Count = 0 Then
            MsgBox("Seleccione el archivo que desea eliminar de la lista.")
        Else
            If fileList(LstFiles.SelectedIndex).path = LstFiles.SelectedItem.path Then
                fileList.RemoveAt(LstFiles.SelectedIndex)
                LstFiles.Items.Remove(LstFiles.SelectedItem)
            End If
        End If
    End Sub

    Private Overloads Function PrintRow(row As DataRow) As String
        Dim retval As String = ""
        For Each c As DataColumn In row.Table.Columns
            retval += c.ColumnName & ": " & row(c.ColumnName) & " ||"
        Next
        Return retval
    End Function
    Private Overloads Function PrintRow(row As OleDb.OleDbDataReader)
        Dim retval As String = ""
        Dim tbl As DataTable = row.GetSchemaTable()
        For Each c As DataRow In tbl.Rows
            retval += c("ColumnName") & ": " & row(c("ColumnName")) & " ||"
        Next
        Return retval
    End Function

    Private ProyectoDictionary As New Generic.Dictionary(Of String, Integer)
    Private Function GetProyecto(reader As OleDb.OleDbDataReader) As Integer
        Dim value As String = ""
        Dim retval As Integer = -1
        Dim found As Boolean = False

        If reader.GetSchemaTable.Columns.Contains("Proyecto") Then
            value = reader("Proyecto")
        End If
        For Each r As MainDS.TblProyectosRow In MainDSO.TblProyectos.Rows
            If r.Nombre = value Then
                found = True
                retval = r.ID
                Exit For
            End If
        Next
        If Not found Then
            found = ProyectoDictionary.TryGetValue(value, retval)
        End If
        If Not found Then
            Dim dlg As New ProyectoDlg
            dlg.Prompt = "Seleccione el proyecto equivalente a: " & IIf(value = "", "<Vacío>", value)
            dlg.ShowDialog()
            retval = dlg.ID
            If dlg.Again Then
                ProyectoDictionary.Add(value, retval)
            End If
        End If
        Return retval
    End Function

    Private PaisDictionary As New Generic.Dictionary(Of String, Integer)
    Private Function GetPais(value As String) As Integer
        Dim retval = -1
        Dim found As Boolean = False
        For Each r As MainDS.TblPaisesRow In MainDSO.TblPaises.Rows
            If r.Nombre = value Then
                found = True
                retval = r.ID
                Exit For
            End If
        Next
        If Not found Then
            found = PaisDictionary.TryGetValue(value, retval)
        End If
        If Not found Then
            Dim dlg As New PaisDlg
            dlg.Prompt = "Seleccione el país equivalente a: " & value
            dlg.ShowDialog()
            retval = dlg.ID
            If dlg.Again Then
                PaisDictionary.Add(value, retval)
            End If
        End If
        Return retval
    End Function

    Private EstadoDictionary As New Generic.Dictionary(Of String, Integer)
    Private Function GetEstado(value As String, Optional pais As Integer = -1) As Integer
        Dim retval = -1
        Dim found As Boolean = False
        For Each r As MainDS.TblEstadosRow In MainDSO.TblEstados.Rows
            If r.Nombre = value Then
                found = True
                retval = r.ID
                Exit For
            End If
        Next
        If Not found Then
            found = EstadoDictionary.TryGetValue(value, retval)
        End If
        If Not found Then
            Dim dlg As New EstadoDlg
            dlg.Prompt = "Seleccione el estado equivalente a: " & value
            dlg.Pais = pais
            dlg.ShowDialog()
            retval = dlg.ID
            If dlg.Again Then
                EstadoDictionary.Add(value, retval)
            End If
        End If
        Return retval
    End Function

    Private MunicipioDictionary As New Generic.Dictionary(Of String, Integer)
    Private Function GetMunicipio(value As String, Optional estado As Integer = -1) As Integer
        Dim retval = -1
        Dim found As Boolean = False
        For Each r As MainDS.TblMunicipiosRow In MainDSO.TblMunicipios.Rows
            If r.Municipios = value Then
                found = True
                retval = r.ID
                Exit For
            End If
        Next
        If Not found Then
            found = MunicipioDictionary.TryGetValue(value, retval)
        End If
        If Not found Then
            Dim dlg As New MunicipioDlg
            dlg.Prompt = "Seleccione el municipio equivalente a: " & value
            dlg.Estado = estado
            dlg.ShowDialog()
            retval = dlg.ID
            If dlg.Again Then
                MunicipioDictionary.Add(value, retval)
            End If
        End If
        Return retval
    End Function

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'Establecer equivalencias de datos
        Dim tables As String() = {"Gestion",
                                  "TblBanko",
                                  "TblBenef",
                                  "TblCredito",
                                  "TblCredito",
                                  "TblFiadores",
                                  "TblLibroIE",
                                  "TblSocios"}
        For Each file As BKfile In fileList
            Using conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & file.path)
                For Each bk As Banko In file.BKS
                    If bk.Checked = CheckState.Checked Then
                        For Each t As String In tables
                            Dim command As String = "SELECT * FROM " & t
                            Select Case t
                                Case "Gestion"
                                    command += " WHERE CodBK = '" + bk.CodBk + "'"
                                Case "TblBanko"
                                    command += " WHERE CodBk='" + bk.CodBk + "'"
                                Case "TblBenef"
                                    command += " WHERE CodBK = '" + bk.CodBk + "'"
                                Case "TblCredito"
                                    command += " WHERE VBK = '" + bk.CodBk + "'"
                                Case "TblFiadores"
                                    command += " WHERE CodBK = '" + bk.CodBk + "'"
                                Case "TblLibroIE"
                                    command += " WHERE IdBK = '" + bk.CodBk + "'"
                                Case "TblSocios"
                                    command += " WHERE CodBK = '" + bk.CodBk + "'"
                            End Select
                            If conn.State <> ConnectionState.Open Then conn.Open()
                            Dim objCommand As New OleDb.OleDbCommand(command, conn)
                            Dim reader As OleDb.OleDbDataReader = objCommand.ExecuteReader
                            While reader.Read
                                Dim add As Boolean = True
                                Select Case t
                                    Case "Gestion"
                                        Dim row As MainDS.GestionRow
                                        If MainDSO.Gestion.Rows.Contains({reader("idgestion"), reader("codBK")}) Then
                                            Continue While
                                            row = MainDSO.Gestion.Rows.Find({reader("idgestion"), reader("codBK")})
                                            If vbYes <> MsgBox("Registro duplicado encontrado!" & vbNewLine &
                                                              "Registro local: " & vbNewLine & PrintRow(row) & vbNewLine &
                                                              "Registro entrante: " & vbNewLine & PrintRow(reader) & vbNewLine &
                                                              "Desea sobreescribir el registro local?", MsgBoxStyle.YesNo) Then
                                                Continue While
                                            End If
                                            add = False
                                        Else
                                            row = MainDSO.Gestion.NewGestionRow()
                                        End If

                                        row.DEXCAPITAL = CDbl(reader("DEXCAPITAL"))
                                        row.DEXINTERES = CDbl(reader("DEXINTERES"))
                                        row.idgestion = CInt(reader("idgestion"))
                                        row.codBK = reader("codBK")
                                        row.Finicio = CDate(reader("Finicio"))
                                        row.FCorte = CDate(reader("FCorte"))
                                        row.NTSM = CInt(reader("NTSM"))
                                        row.NTSMACUM = CInt(reader("NTSMACUM"))
                                        row.NTSMR = CInt(reader("NTSMR"))
                                        row.NTSMRACUM = CInt(reader("NTSMRACUM"))
                                        row.NTSMA = CInt(reader("NTSMA"))
                                        row.NTSF = (CInt(reader("NTSF")))
                                        row.NTSMACUM = CInt(reader("NTSFACUM"))
                                        row.NTSFR = CInt(reader("NTSFR"))
                                        row.NTSMRACUM = CInt(reader("NTSFRACUM"))
                                        row.NTSMA = CInt(reader("NTSFA"))
                                        row.qVCt = CInt(reader("qVCt"))
                                        row.qVCACUMt = CInt(reader("qVCACUMt"))
                                        row.ZVC = CDbl(reader("ZVC"))
                                        row.ZVCACUM = CDbl(reader("ZVCACUM"))
                                        row.qCON = CDbl(reader("qCON"))
                                        row.qCONACUM = CDbl(reader("qCONACUM"))
                                        row.qCOR = CDbl(reader("qCOR"))
                                        row.qCORACUM = CDbl(reader("qCORACUM"))
                                        row.ZCON = CDbl(reader("ZCON"))
                                        row.ZCONACUM = CDbl(reader("ZCONACUM"))
                                        row.ZCOR = CDbl(reader("ZCOR"))
                                        row.ZCORACUM = CDbl(reader("ZCORACUM"))
                                        row.qLCt = CInt(reader("qLCt"))
                                        row.qLCACUMt = CInt(reader("qLCACUMt"))
                                        row.ZLC = CDbl(reader("ZLC"))
                                        row.ZLCACUM = CDbl(reader("ZLCACUM"))
                                        row.qRI = CInt(reader("qRI"))
                                        row.ZPC = CDbl(reader("ZPC"))
                                        row.ZPCACUM = CDbl(reader("ZPCACUM"))
                                        row.MPRECUP = CDbl(reader("MPRECUP"))
                                        row.MPRECUP30 = CDbl(reader("MPRECUP30"))
                                        row.MPRECUP60 = CDbl(reader("MPRECUP60"))
                                        row.MPRECUP90 = CDbl(reader("MPRECUP90"))
                                        row.ZICB = CDbl(reader("ZICB"))
                                        row.ZICBACUM = CDbl(reader("ZICBACUM"))
                                        row.ZOR = CDbl(reader("ZOR"))
                                        row.ZORACUM = CDbl(reader("ZORACUM"))
                                        row.ZMO = CDbl(reader("ZMO"))
                                        row.ZMOACUM = CDbl(reader("ZMOACUM"))
                                        row.ZOI = CDbl(reader("ZOI"))
                                        row.ZOIACUM = CDbl(reader("ZOIACUM"))
                                        row.ZRICB = CDbl(reader("ZRICB"))
                                        row.ZRICBACUM = CDbl(reader("ZRICBACUM"))
                                        row.ZEG = CDbl(reader("ZEG"))
                                        row.ZEGACUM = CDbl(reader("ZEGACUM"))
                                        row.ZPEX = CDbl(reader("ZPEX"))
                                        row.ZPEXACUM = CDbl(reader("ZPEXACUM"))
                                        row.ZIEX = CDbl(reader("ZIEX"))
                                        row.ZIEXACUM = CDbl(reader("ZIEXACUM"))
                                        row.ZDEX = CDbl(reader("ZDEX"))
                                        row.ZDEXACUM = CDbl(reader("ZDEXACUM"))
                                        row.ZMEX = CDbl(reader("ZMEX"))
                                        row.ZMEXACUM = CDbl(reader("ZMEXACUM"))
                                        row.ZUR = CDbl(reader("ZUR"))
                                        row.ZURACUM = CDbl(reader("ZURACUM"))
                                        row.GR = CDbl(reader("GR"))
                                        row.MRFt = CDbl(reader("MRFt"))
                                        row.ZBA = CDbl(reader("ZBA"))
                                        row.SAFGASTOS = CDbl(reader("SAFGASTOS"))
                                        row.MTCPAGAR = CDbl(reader("MTCPAGAR"))
                                        row.DECIERRE = CDbl(reader("DECIERRE"))
                                        row.ZMONTOGNORep = CDbl(reader("ZMONTOGNORep"))
                                        row.GestionMBACUM = CDbl(reader("GestionMBACUM"))
                                        row.GestionMB = CDbl(reader("GestionMB"))
                                        row.ZMRFACUM = CDbl(reader("ZMRFACUM"))
                                        row.ZMRF = CDbl(reader("ZMRF"))
                                        row.ZGestionMNeto = CDbl(reader("ZGestionMNeto"))
                                        row.ZGestionMNetoACUM = CDbl(reader("ZGestionMNetoACUM"))
                                        row.ZICp = CDbl(reader("ZICp"))
                                        row.ZICpACUM = CDbl(reader("ZICpACUM"))
                                        row.ZECp = CDbl(reader("ZECp"))
                                        row.ZECpACUM = CDbl(reader("ZECpACUM"))
                                        row.ZDO1 = CDbl(reader("ZDO1"))
                                        row.ZDO1ACUM = CDbl(reader("ZDO1ACUM"))
                                        row.ZDO2 = CDbl(reader("ZDO2"))
                                        row.ZDO2ACUM = CDbl(reader("ZDO2ACUM"))
                                        row.ZBAACUM = CDbl(reader("ZBAACUM"))
                                        row.RESTCAPS = CDbl(reader("RESTCAPS"))
                                        row.ZIFG1 = CDbl(reader("ZIFG1"))
                                        row.ZIFG1ACUM = CDbl(reader("ZIFG1ACUM"))
                                        row.ZIFG2 = CDbl(reader("ZIFG2"))
                                        row.ZIFG2ACUM = CDbl(reader("ZIFG2ACUM"))
                                        row.ZGBK1 = CDbl(reader("ZGBK1"))
                                        row.ZGBK1ACUM = CDbl(reader("ZGBK1ACUM"))
                                        row.ZGBK2 = CDbl(reader("ZGBK2"))
                                        row.ZGBK2ACUM = CDbl(reader("ZGBK2ACUM"))
                                        If add Then MainDSO.Gestion.AddGestionRow(row)

                                    Case "TblBanko"
                                        Dim row As MainDS.TblBankoRow
                                        Dim Proyecto As Integer = GetProyecto(reader)
                                        If Proyecto < 0 Then Continue While
                                        Dim Pais As Integer = GetPais(reader("Pais"))
                                        If Pais < 0 Then Continue While
                                        Dim Estado As Integer = GetEstado(reader("Estado"), Pais)
                                        If Estado < 0 Then Continue While
                                        Dim Municipio As Integer = GetMunicipio(reader("Municipio"), Estado)
                                        If Municipio < 0 Then Continue While
                                        If MainDSO.TblBanko.Rows.Contains(reader("CodBk")) Then
                                            Continue While
                                            row = MainDSO.TblBanko.FindByCodBk(reader("CodBk"))
                                            If vbYes <> MsgBox("Registro duplicado encontrado!" & vbNewLine &
                                                               "Registro local: " & vbNewLine & PrintRow(row) & vbNewLine &
                                                               "Registro entrante: " & vbNewLine & PrintRow(reader) & vbNewLine &
                                                               "Desea sobreescribir el registro local?", MsgBoxStyle.YesNo) Then
                                                Continue While
                                            End If
                                            add = False
                                        Else
                                            row = MainDSO.TblBanko.NewTblBankoRow
                                        End If
                                        row.CodBk = reader("CodBk")
                                        row.NombreBk = reader("NombreBk")
                                        row.Proyecto = Proyecto
                                        row.Municipio = Municipio
                                        row.PRI = CInt(reader("PRI"))
                                        row.VCR = CInt(reader("VCR"))
                                        row.PRFG = CInt(reader("PRFG"))
                                        row.PRGR = CInt(reader("PRGR"))
                                        row.ICCFG = CInt(reader("ICCFG"))
                                        row.SaldoBk = CDbl(reader("SaldoBk"))
                                        row.FechaI = CDate(reader("FechaI"))
                                        row.Val_nominal = CInt(reader("Val_nominal"))
                                        row.moneda = reader("moneda")
                                        row.TasaIO1 = CDbl(reader("TasaIO1"))
                                        row.TasaIO2 = CDbl(reader("TasaIO2"))
                                        row.TasaM1 = CDbl(reader("TasaM1"))
                                        row.TasaM2 = CDbl(reader("TasaM2"))
                                        row.MontoMaximo = CDbl(reader("MontoMaximo"))
                                        row._Caps_Creditos = CDbl(reader("Caps-Creditos"))
                                        row.GarantiaFiador = CInt(reader("GarantiaFiador"))
                                        row.SAFGASTOS = CDbl(reader("SAFGASTOS"))
                                        row.Plazo = CInt(reader("Plazo"))
                                        row.PRFP = CInt(reader("PRFP"))
                                        If add Then MainDSO.TblBanko.AddTblBankoRow(row)
                                    Case "TblBenef"
                                        Dim row As MainDS.TblBenefRow
                                        If MainDSO.TblBenef.Rows.Contains(reader("IdReq")) Then
                                            Continue While
                                            row = MainDSO.TblBenef.Rows.Find(reader("IdReq"))
                                            If vbYes <> MsgBox("Registro duplicado encontrado!" & vbNewLine &
                                                              "Registro local: " & vbNewLine & PrintRow(row) & vbNewLine &
                                                              "Registro entrante: " & vbNewLine & PrintRow(reader) & vbNewLine &
                                                              "Desea sobreescribir el registro local?", MsgBoxStyle.YesNo) Then
                                                Continue While
                                            End If
                                            add = False
                                        Else
                                            row = MainDSO.TblBenef.NewTblBenefRow
                                        End If
                                        row.IdReq = CInt(reader("Idreq"))
                                        row.VinSocio = reader("VinSocio")
                                        row.NombresB = reader("NombresB")
                                        row.CIB = reader("CIB")
                                        row.FechaNace = CDate(reader("FechaNace"))
                                        row.Direccion = reader("Direccion")
                                        row.Oficio = reader("Oficio")
                                        row.Parentesco = reader("Parentesco")
                                        row.sexo = reader("sexo")
                                        row.CodBK = reader("CodBK")
                                        If add Then MainDSO.TblBenef.AddTblBenefRow(row)
                                    Case "TblCredito"
                                        Dim row As MainDS.TblCreditoRow
                                        If MainDSO.TblCredito.Rows.Contains({reader("VBK"), reader("NoCredito")}) Then
                                            Continue While
                                            row = MainDSO.TblCredito.Rows.Find({reader("VBK"), reader("NoCredito")})
                                            If vbYes <> MsgBox("Registro duplicado encontrado!" & vbNewLine &
                                                              "Registro local: " & vbNewLine & PrintRow(row) & vbNewLine &
                                                              "Registro entrante: " & vbNewLine & PrintRow(reader) & vbNewLine &
                                                              "Desea sobreescribir el registro local?", MsgBoxStyle.YesNo) Then
                                                Continue While
                                            End If
                                            add = False
                                        Else
                                            row = MainDSO.TblCredito.NewTblCreditoRow
                                        End If

                                        row.IdOp = 0
                                        row.VCI = reader("VCI")
                                        row.VBK = reader("VBK")
                                        row.NoCredito = CInt(reader("NoCredito"))
                                        row.Fecha = CDate(reader("Fecha"))
                                        row.FechaVence = CDate(reader("FechaVence"))
                                        row.MontoCred = CDbl(reader("MontoCred"))
                                        row.Tipo = reader("Tipo")
                                        row.Saldo = CDbl(reader("Saldo"))
                                        row.IntDEX = reader("IntDEX")
                                        row.MontoIntDEX = reader("IntDEX")
                                        row.MoraDEX = reader("MoraDEX")
                                        row.Cancelado = reader("Cancelado")
                                        row.FechaCancela = CDate("FechaCancela")
                                        row.sexo = reader("sexo")
                                        row.deuda = CDbl(reader("deuda"))
                                        row.incobrable = reader("incobrable")
                                        row.TasaIO = reader("TasaIO")
                                        row.TasaMO = reader("TasaMO")
                                        row.Riezgo = reader("Riezgo")
                                        row.Frecuencia = reader("Frecuencia")
                                        row.Clase = reader("Clase")
                                        If add Then MainDSO.TblCredito.AddTblCreditoRow(row)
                                    Case "TblFiadores"
                                        Dim row As MainDS.TblFiadoresRow
                                        If MainDSO.TblFiadores.Rows.Contains({reader("CodBk"), reader("NoCredito"), reader("CI")}) Then
                                            Continue While
                                            row = MainDSO.TblFiadores.Rows.Find({reader("CodBk"), reader("NoCredito"), reader("CI")})
                                            If vbYes <> MsgBox("Registro duplicado encontrado!" & vbNewLine &
                                                              "Registro local: " & vbNewLine & PrintRow(row) & vbNewLine &
                                                              "Registro entrante: " & vbNewLine & PrintRow(reader) & vbNewLine &
                                                              "Desea sobreescribir el registro local?", MsgBoxStyle.YesNo) Then
                                                Continue While
                                            End If
                                            add = False
                                        Else
                                            row = MainDSO.TblFiadores.NewTblFiadoresRow
                                        End If

                                        row.CodBk = reader("CodBk")
                                        row.NoCredito = CInt(reader("NoCredito"))
                                        row.CI = reader("CI")
                                        row.CapsGarantia = CDbl(reader("CapsGarantia"))
                                        row.porcentajegarantizado = CDbl(reader("porcentajegarantizado"))
                                        row.Observacion = reader("Observacion")
                                        If add Then MainDSO.TblFiadores.AddTblFiadoresRow(row)
                                    Case "TblLibroIE"
                                        Dim row As MainDS.TblLibroIERow
                                        If MainDSO.TblLibroIE.Rows.Contains({reader("IdBK"), reader("Fecha"), reader("NoRecibo"), reader("CodOpe")}) Then
                                            Continue While
                                            row = MainDSO.TblLibroIE.Rows.Find({reader("IdBK"), reader("Fecha"), reader("NoRecibo"), reader("CodOpe")})
                                            If vbYes <> MsgBox("Registro duplicado encontrado!" & vbNewLine &
                                                              "Registro local: " & vbNewLine & PrintRow(row) & vbNewLine &
                                                              "Registro entrante: " & vbNewLine & PrintRow(reader) & vbNewLine &
                                                              "Desea sobreescribir el registro local?", MsgBoxStyle.YesNo) Then
                                                Continue While
                                            End If
                                            add = False
                                        Else
                                            row = MainDSO.TblLibroIE.NewTblLibroIERow
                                        End If
                                        Dim tblSchema As DataTable = reader.GetSchemaTable
                                        tblSchema.PrimaryKey = {tblSchema.Columns("ColumnName")}
                                        row.IdReg = CInt(reader("IdReg"))
                                        If reader.IsDBNull(tblSchema.Rows.Find("IdOpe")("ColumnOrdinal")) Then
                                            row.IdOpe = ""
                                        Else
                                            row.IdOpe = reader("IdOpe")
                                        End If
                                        row.IdBK = reader("IdBK")
                                        row.Fecha = CDate(reader("Fecha"))
                                        row.NoCredito = CInt(reader("NoCredito"))
                                        row.NoRecibo = CInt(reader("NoRecibo"))
                                        row.CI = reader("CI")
                                        row.CodOpe = reader("CodOpe")
                                        row.Descripcion = reader("Descripcion")
                                        row.Ingreso = CDbl(reader("Ingreso"))
                                        row.Egreso = CDbl(reader("Egreso"))
                                        row.Saldo = CDbl(reader("Saldo"))
                                        row.Bloqueo = CByte(reader("Bloqueo"))
                                        row.Anulado = 0
                                        If add Then MainDSO.TblLibroIE.AddTblLibroIERow(row)

                                    Case "TblSocios"
                                        Dim row As MainDS.TblSociosRow
                                        If MainDSO.TblSocios.Rows.Contains(reader("CI")) Then
                                            Continue While
                                            row = MainDSO.TblSocios.Rows.Find(reader("CI"))
                                            If vbYes <> MsgBox("Registro duplicado encontrado!" & vbNewLine &
                                                              "Registro local: " & vbNewLine & PrintRow(row) & vbNewLine &
                                                              "Registro entrante: " & vbNewLine & PrintRow(reader) & vbNewLine &
                                                              "Desea sobreescribir el registro local?", MsgBoxStyle.YesNo) Then
                                                Continue While
                                            End If
                                            add = False
                                        Else
                                            row = MainDSO.TblSocios.NewTblSociosRow
                                        End If

                                        row.CI = reader("CI")
                                        row.CodBk = reader("CodBk")
                                        row.Nombres = reader("Nombres")
                                        row.Sexo = reader("Sexo")
                                        row.FNace = CDate(reader("FNace"))
                                        row.Profesion = reader("Profesion")
                                        row.Direccion = reader("Direccion")
                                        row.Telefono = reader("Telefono")
                                        row.FIngreso = CDate(reader("FIngreso"))
                                        row.AcumMoras = CInt(reader("AcumMoras"))
                                        row.Estatus = CInt(reader("Estatus"))
                                        row.Deuda = CDbl(reader("Deuda"))
                                        row.Fretiro = CDate(reader("Fretiro"))
                                        row.cap = CInt(reader("cap"))
                                        row.CapLiq = CInt(reader("CapLiq"))
                                        row.Email = reader("Email")
                                        If add Then MainDSO.TblSocios.AddTblSociosRow(row)
                                End Select
                            End While
                        Next
                    End If

                Next
                conn.Close()
            End Using

        Next

        'correr Update() por banko
    End Sub

    Private Sub LstFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstFiles.SelectedIndexChanged
        LstBankos.Items.Clear()
        If LstFiles.SelectedItems.Count Then
            For Each file As BKfile In fileList
                If file.path = LstFiles.SelectedItem.path Then
                    For Each banko As Banko In file.BKS
                        LstBankos.Items.Add(banko.CodBk, banko.Checked)
                    Next
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub LstBankos_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles LstBankos.ItemCheck
        For Each file As BKfile In fileList
            If file.path = LstFiles.SelectedItem.path Then
                For Each banko As Banko In file.BKS
                    If banko.CodBk = LstBankos.Items(e.Index) Then
                        banko.Checked = e.NewValue
                    End If
                Next
                Exit For
            End If
        Next
    End Sub
End Class