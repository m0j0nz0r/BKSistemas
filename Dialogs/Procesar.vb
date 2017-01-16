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
            Dim st As String = ""
            If estado > 0 Then st = vbNewLine & " en el estado: " & MainDSO.TblEstados.FindByID(estado).Nombre
            dlg.Prompt = "Seleccione el municipio equivalente a: " & value & st
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
        Try
            MainDSO.AcceptChanges()
            Dim tables As String() = {"Gestion",
                                      "TblBanko",
                                      "TblBenef",
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
                                openFile = conn.DataSource
                                Dim objCommand As New OleDb.OleDbCommand(command, conn)
                                Dim reader As OleDb.OleDbDataReader = objCommand.ExecuteReader(CommandBehavior.KeyInfo)
                                While reader.Read
                                    Dim add As Boolean = True
                                    Select Case t
                                        Case "Gestion"
                                            Dim row As MainDS.GestionRow
                                            If MainDSO.Gestion.Rows.Contains({getDbValue(reader, "idgestion"), getDbValue(reader, "codBK")}) Then
                                                Continue While
                                                row = MainDSO.Gestion.Rows.Find({getDbValue(reader, "idgestion"), getDbValue(reader, "codBK")})
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

                                            row.DEXCAPITAL = CDbl(getDbValue(reader, "DEXCAPITAL"))
                                            row.DEXINTERES = CDbl(getDbValue(reader, "DEXINTERES"))
                                            row.idgestion = CInt(getDbValue(reader, "idgestion"))
                                            row.codBK = getDbValue(reader, "codBK")
                                            row.Finicio = CDate(getDbValue(reader, "Finicio"))
                                            row.FCorte = CDate(getDbValue(reader, "FCorte"))
                                            row.NTSM = CInt(getDbValue(reader, "NTSM"))
                                            row.NTSMACUM = CInt(getDbValue(reader, "NTSMACUM"))
                                            row.NTSMR = CInt(getDbValue(reader, "NTSMR"))
                                            row.NTSMRACUM = CInt(getDbValue(reader, "NTSMRACUM"))
                                            row.NTSMA = CInt(getDbValue(reader, "NTSMA"))
                                            row.NTSF = (CInt(getDbValue(reader, "NTSF")))
                                            row.NTSFACUM = CInt(getDbValue(reader, "NTSFACUM"))
                                            row.NTSFR = CInt(getDbValue(reader, "NTSFR"))
                                            row.NTSFRACUM = CInt(getDbValue(reader, "NTSFRACUM"))
                                            row.NTSFA = CInt(getDbValue(reader, "NTSFA"))
                                            row.qVCt = CInt(getDbValue(reader, "qVCt"))
                                            row.qVCACUMt = CInt(getDbValue(reader, "qVCACUMt"))
                                            row.ZVC = CDbl(getDbValue(reader, "ZVC"))
                                            row.ZVCACUM = CDbl(getDbValue(reader, "ZVCACUM"))
                                            row.qCON = CDbl(getDbValue(reader, "qCON"))
                                            row.qCONACUM = CDbl(getDbValue(reader, "qCONACUM"))
                                            row.qCOR = CDbl(getDbValue(reader, "qCOR"))
                                            row.qCORACUM = CDbl(getDbValue(reader, "qCORACUM"))
                                            row.ZCON = CDbl(getDbValue(reader, "ZCON"))
                                            row.ZCONACUM = CDbl(getDbValue(reader, "ZCONACUM"))
                                            row.ZCOR = CDbl(getDbValue(reader, "ZCOR"))
                                            row.ZCORACUM = CDbl(getDbValue(reader, "ZCORACUM"))
                                            row.qLCt = CInt(getDbValue(reader, "qLCt"))
                                            row.qLCACUMt = CInt(getDbValue(reader, "qLCACUMt"))
                                            row.ZLC = CDbl(getDbValue(reader, "ZLC"))
                                            row.ZLCACUM = CDbl(getDbValue(reader, "ZLCACUM"))
                                            row.qRI = CInt(getDbValue(reader, "qRI"))
                                            row.ZPC = CDbl(getDbValue(reader, "ZPC"))
                                            row.ZPCACUM = CDbl(getDbValue(reader, "ZPCACUM"))
                                            row.MPRECUP = CDbl(getDbValue(reader, "MPRECUP"))
                                            row.MPRECUP30 = CDbl(getDbValue(reader, "MPRECUP30"))
                                            row.MPRECUP60 = CDbl(getDbValue(reader, "MPRECUP60"))
                                            row.MPRECUP90 = CDbl(getDbValue(reader, "MPRECUP90"))
                                            row.ZICB = CDbl(getDbValue(reader, "ZICB"))
                                            row.ZICBACUM = CDbl(getDbValue(reader, "ZICBACUM"))
                                            row.ZOR = CDbl(getDbValue(reader, "ZOR"))
                                            row.ZORACUM = CDbl(getDbValue(reader, "ZORACUM"))
                                            row.ZMO = CDbl(getDbValue(reader, "ZMO"))
                                            row.ZMOACUM = CDbl(getDbValue(reader, "ZMOACUM"))
                                            row.ZOI = CDbl(getDbValue(reader, "ZOI"))
                                            row.ZOIACUM = CDbl(getDbValue(reader, "ZOIACUM"))
                                            row.ZRICB = CDbl(getDbValue(reader, "ZRICB"))
                                            row.ZRICBACUM = CDbl(getDbValue(reader, "ZRICBACUM"))
                                            row.ZEG = CDbl(getDbValue(reader, "ZEG"))
                                            row.ZEGACUM = CDbl(getDbValue(reader, "ZEGACUM"))
                                            row.ZPEX = CDbl(getDbValue(reader, "ZPEX"))
                                            row.ZPEXACUM = CDbl(getDbValue(reader, "ZPEXACUM"))
                                            row.ZIEX = CDbl(getDbValue(reader, "ZIEX"))
                                            row.ZIEXACUM = CDbl(getDbValue(reader, "ZIEXACUM"))
                                            row.ZDEX = CDbl(getDbValue(reader, "ZDEX"))
                                            row.ZDEXACUM = CDbl(getDbValue(reader, "ZDEXACUM"))
                                            row.ZMEX = CDbl(getDbValue(reader, "ZMEX"))
                                            row.ZMEXACUM = CDbl(getDbValue(reader, "ZMEXACUM"))
                                            row.ZUR = CDbl(getDbValue(reader, "ZUR"))
                                            row.ZURACUM = CDbl(getDbValue(reader, "ZURACUM"))
                                            row.GR = CDbl(getDbValue(reader, "GR"))
                                            row.MRFt = CDbl(getDbValue(reader, "MRFt"))
                                            row.ZBA = CDbl(getDbValue(reader, "ZBA"))
                                            row.SAFGASTOS = CDbl(getDbValue(reader, "SAFGASTOS"))
                                            row.MTCPAGAR = CDbl(getDbValue(reader, "MTCPAGAR"))
                                            row.DECIERRE = CDbl(getDbValue(reader, "DECIERRE"))
                                            row.ZMONTOGNORep = CDbl(getDbValue(reader, "ZMONTOGNORep"))
                                            row.GestionMBACUM = CDbl(getDbValue(reader, "GestionMBACUM"))
                                            row.GestionMB = CDbl(getDbValue(reader, "GestionMB"))
                                            row.ZMRFACUM = CDbl(getDbValue(reader, "ZMRFACUM"))
                                            row.ZMRF = CDbl(getDbValue(reader, "ZMRF"))
                                            row.ZGestionMNeto = CDbl(getDbValue(reader, "ZGestionMNeto"))
                                            row.ZGestionMNetoACUM = CDbl(getDbValue(reader, "ZGestionMNetoACUM"))
                                            row.ZICp = CDbl(getDbValue(reader, "ZICp"))
                                            row.ZICpACUM = CDbl(getDbValue(reader, "ZICpACUM"))
                                            row.ZECp = CDbl(getDbValue(reader, "ZECp"))
                                            row.ZECpACUM = CDbl(getDbValue(reader, "ZECpACUM"))
                                            row.ZDO1 = CDbl(getDbValue(reader, "ZDO1"))
                                            row.ZDO1ACUM = CDbl(getDbValue(reader, "ZDO1ACUM"))
                                            row.ZDO2 = CDbl(getDbValue(reader, "ZDO2"))
                                            row.ZDO2ACUM = CDbl(getDbValue(reader, "ZDO2ACUM"))
                                            row.ZBAACUM = CDbl(getDbValue(reader, "ZBAACUM"))
                                            row.RESTCAPS = CDbl(getDbValue(reader, "RESTCAPS"))
                                            row.ZIFG1 = CDbl(getDbValue(reader, "ZIFG1"))
                                            row.ZIFG1ACUM = CDbl(getDbValue(reader, "ZIFG1ACUM"))
                                            row.ZIFG2 = CDbl(getDbValue(reader, "ZIFG2"))
                                            row.ZIFG2ACUM = CDbl(getDbValue(reader, "ZIFG2ACUM"))
                                            row.ZGBK1 = CDbl(getDbValue(reader, "ZGBK1"))
                                            row.ZGBK1ACUM = CDbl(getDbValue(reader, "ZGBK1ACUM"))
                                            row.ZGBK2 = CDbl(getDbValue(reader, "ZGBK2"))
                                            row.ZGBK2ACUM = CDbl(getDbValue(reader, "ZGBK2ACUM"))
                                            If add Then MainDSO.Gestion.AddGestionRow(row)

                                        Case "TblBanko"
                                            Dim row As MainDS.TblBankoRow
                                            Dim Proyecto As Integer = GetProyecto(reader)
                                            If Proyecto < 0 Then Continue While
                                            Dim Pais As Integer = GetPais(getDbValue(reader, "Pais"))
                                            If Pais < 0 Then Continue While
                                            Dim Estado As Integer = GetEstado(getDbValue(reader, "Estado"), Pais)
                                            If Estado < 0 Then Continue While
                                            Dim Municipio As Integer = GetMunicipio(getDbValue(reader, "Municipio"), Estado)
                                            If Municipio < 0 Then Continue While
                                            If MainDSO.TblBanko.Rows.Contains(getDbValue(reader, "CodBk")) Then
                                                Continue While
                                                row = MainDSO.TblBanko.FindByCodBk(getDbValue(reader, "CodBk"))
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
                                            row.CodBk = getDbValue(reader, "CodBk")
                                            row.NombreBk = getDbValue(reader, "NombreBk")
                                            row.Proyecto = Proyecto
                                            row.Municipio = Municipio
                                            row.PRI = CInt(getDbValue(reader, "PRI"))
                                            row.VCR = CInt(getDbValue(reader, "VCR"))
                                            row.PRFG = CInt(getDbValue(reader, "PRFG"))
                                            row.PRGR = CInt(getDbValue(reader, "PRGR"))
                                            row.ICCFG = CInt(getDbValue(reader, "ICCFG"))
                                            row.SaldoBk = CDbl(getDbValue(reader, "SaldoBk"))
                                            row.FechaI = CDate(getDbValue(reader, "FechaI"))
                                            row.Val_nominal = CInt(getDbValue(reader, "Val_nominal"))
                                            row.moneda = getDbValue(reader, "moneda")
                                            row.TasaIO1 = CDbl(getDbValue(reader, "TasaIO1"))
                                            row.TasaIO2 = CDbl(getDbValue(reader, "TasaIO2"))
                                            row.TasaM1 = CDbl(getDbValue(reader, "TasaM1"))
                                            row.TasaM2 = CDbl(getDbValue(reader, "TasaM2"))
                                            row.MontoMaximo = CDbl(getDbValue(reader, "MontoMaximo"))
                                            row._Caps_Creditos = CDbl(getDbValue(reader, "Caps-Creditos"))
                                            row.GarantiaFiador = CInt(getDbValue(reader, "GarantiaFiador"))
                                            row.SAFGASTOS = CDbl(getDbValue(reader, "SAFGASTOS"))
                                            row.Plazo = CInt(getDbValue(reader, "Plazo"))
                                            row.PRFP = CInt(getDbValue(reader, "PRFP"))
                                            If add Then MainDSO.TblBanko.AddTblBankoRow(row)
                                        Case "TblBenef"
                                            Dim row As MainDS.TblBenefRow
                                            If MainDSO.TblBenef.Rows.Contains(getDbValue(reader, "IdReq")) Then
                                                Continue While
                                                row = MainDSO.TblBenef.Rows.Find(getDbValue(reader, "IdReq"))
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
                                            row.IdReq = CInt(getDbValue(reader, "Idreq"))
                                            row.VinSocio = getDbValue(reader, "VinSocio")
                                            row.NombresB = getDbValue(reader, "NombresB")
                                            row.CIB = getDbValue(reader, "CIB")
                                            row.FechaNace = CDate(getDbValue(reader, "FechaNace"))
                                            row.Direccion = getDbValue(reader, "Direccion")
                                            row.Oficio = getDbValue(reader, "Oficio")
                                            row.Parentesco = getDbValue(reader, "Parentesco")
                                            row.sexo = getDbValue(reader, "sexo")
                                            row.CodBK = getDbValue(reader, "CodBK")
                                            If add Then MainDSO.TblBenef.AddTblBenefRow(row)
                                        Case "TblCredito"
                                            Dim row As MainDS.TblCreditoRow
                                            If MainDSO.TblCredito.Rows.Contains({getDbValue(reader, "VBK"), getDbValue(reader, "NoCredito")}) Then
                                                Continue While
                                                row = MainDSO.TblCredito.Rows.Find({getDbValue(reader, "VBK"), getDbValue(reader, "NoCredito")})
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
                                            row.VCI = getDbValue(reader, "VCI")
                                            row.VBK = getDbValue(reader, "VBK")
                                            row.NoCredito = CInt(getDbValue(reader, "NoCredito"))
                                            row.Fecha = CDate(getDbValue(reader, "Fecha"))
                                            row.FechaVence = CDate(getDbValue(reader, "FechaVence"))
                                            row.MontoCred = CDbl(getDbValue(reader, "MontoCred"))
                                            row.Tipo = getDbValue(reader, "Tipo")
                                            row.Saldo = CDbl(getDbValue(reader, "Saldo"))
                                            row.IntDEX = getDbValue(reader, "IntDEX")
                                            row.MontoIntDEX = getDbValue(reader, "IntDEX")
                                            row.MoraDEX = getDbValue(reader, "MoraDEX")
                                            row.Cancelado = getDbValue(reader, "Cancelado")
                                            If Not reader.IsDBNull(reader.GetOrdinal("FechaCancela")) Then
                                                row.FechaCancela = CDate(getDbValue(reader, "FechaCancela"))
                                            End If
                                            row.sexo = getDbValue(reader, "sexo")
                                            row.deuda = CDbl(getDbValue(reader, "deuda"))
                                            row.incobrable = getDbValue(reader, "incobrable")
                                            row.TasaIO = getDbValue(reader, "TasaIO")
                                            row.TasaMO = getDbValue(reader, "TasaMO")
                                            row.Riezgo = getDbValue(reader, "Riezgo")
                                            row.Frecuencia = getDbValue(reader, "Frecuencia")
                                            row.Clase = getDbValue(reader, "Clase")
                                            If add Then MainDSO.TblCredito.AddTblCreditoRow(row)
                                        Case "TblFiadores"
                                            Dim row As MainDS.TblFiadoresRow
                                            If MainDSO.TblFiadores.Rows.Contains({getDbValue(reader, "CodBk"), getDbValue(reader, "NoCredito"), getDbValue(reader, "CI")}) Then
                                                Continue While
                                                row = MainDSO.TblFiadores.Rows.Find({getDbValue(reader, "CodBk"), getDbValue(reader, "NoCredito"), getDbValue(reader, "CI")})
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

                                            row.CodBk = getDbValue(reader, "CodBk")
                                            row.NoCredito = CInt(getDbValue(reader, "NoCredito"))
                                            row.CI = getDbValue(reader, "CI")
                                            row.CapsGarantia = CDbl(getDbValue(reader, "CapsGarantia"))
                                            row.porcentajegarantizado = CDbl(getDbValue(reader, "porcentajegarantizado"))
                                            If Not reader.IsDBNull(reader.GetOrdinal("Observacion")) Then
                                                row.Observacion = getDbValue(reader, "Observacion")
                                            End If
                                            If add Then MainDSO.TblFiadores.AddTblFiadoresRow(row)
                                        Case "TblLibroIE"
                                            Dim row As MainDS.TblLibroIERow
                                            If MainDSO.TblLibroIE.Rows.Contains({getDbValue(reader, "IdBK"), getDbValue(reader, "Fecha"), getDbValue(reader, "NoRecibo"), getDbValue(reader, "CodOpe")}) Then
                                                Continue While
                                                row = MainDSO.TblLibroIE.Rows.Find({getDbValue(reader, "IdBK"), getDbValue(reader, "Fecha"), getDbValue(reader, "NoRecibo"), getDbValue(reader, "CodOpe")})
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
                                            row.IdReg = CInt(getDbValue(reader, "IdReg"))
                                            If reader.IsDBNull(tblSchema.Rows.Find("IdOpe")("ColumnOrdinal")) Then
                                                row.IdOpe = ""
                                            Else
                                                row.IdOpe = getDbValue(reader, "IdOpe")
                                            End If
                                            row.IdBK = getDbValue(reader, "IdBK")
                                            row.Fecha = CDate(getDbValue(reader, "Fecha"))
                                            row.NoCredito = CInt(getDbValue(reader, "NoCredito"))
                                            row.NoRecibo = CInt(getDbValue(reader, "NoRecibo"))
                                            row.CI = getDbValue(reader, "CI")
                                            row.CodOpe = getDbValue(reader, "CodOpe")
                                            row.Descripcion = getDbValue(reader, "Descripcion")
                                            row.Ingreso = CDbl(getDbValue(reader, "Ingreso"))
                                            row.Egreso = CDbl(getDbValue(reader, "Egreso"))
                                            row.Saldo = CDbl(getDbValue(reader, "Saldo"))
                                            row.Bloqueo = CByte(getDbValue(reader, "Bloqueo"))
                                            row.Anulado = 0
                                            If add Then MainDSO.TblLibroIE.AddTblLibroIERow(row)

                                        Case "TblSocios"
                                            Dim row As MainDS.TblSociosRow
                                            If MainDSO.TblSocios.Rows.Contains(getDbValue(reader, "CI")) Then
                                                Continue While
                                                row = MainDSO.TblSocios.Rows.Find(getDbValue(reader, "CI"))
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

                                            row.CI = getDbValue(reader, "CI")
                                            row.CodBk = getDbValue(reader, "CodBk")
                                            row.Nombres = getDbValue(reader, "Nombres")
                                            row.Sexo = getDbValue(reader, "Sexo")
                                            If Not reader.IsDBNull(reader.GetOrdinal("FNace")) Then
                                                row.FNace = CDate(getDbValue(reader, "FNace"))
                                            End If
                                            If Not reader.IsDBNull(reader.GetOrdinal("Profesion")) Then
                                                row.Profesion = getDbValue(reader, "Profesion")
                                            End If
                                            If Not reader.IsDBNull(reader.GetOrdinal("Direccion")) Then
                                                row.Direccion = getDbValue(reader, "Direccion")
                                            End If
                                            row.Telefono = getDbValue(reader, "Telefono")
                                            row.FIngreso = CDate(getDbValue(reader, "FIngreso"))
                                            row.AcumMoras = CInt(getDbValue(reader, "AcumMoras"))
                                            row.Estatus = CInt(getDbValue(reader, "Estatus"))
                                            row.Deuda = CDbl(getDbValue(reader, "Deuda"))
                                            If Not reader.IsDBNull(reader.GetOrdinal("Fretiro")) Then
                                                row.Fretiro = CDate(getDbValue(reader, "Fretiro"))
                                            End If
                                            row.cap = CInt(getDbValue(reader, "cap"))
                                            row.CapLiq = CInt(getDbValue(reader, "CapLiq"))
                                            If Not reader.IsDBNull(reader.GetOrdinal("Email")) Then
                                                row.Email = getDbValue(reader, "Email")
                                            End If
                                            If add Then MainDSO.TblSocios.AddTblSociosRow(row)
                                    End Select
                                End While
                            Next
                        End If

                    Next
                    conn.Close()
                End Using
            Next
            MsgBox("Carga completada!")
        Catch ex As Exception
            MainDSO.RejectChanges()
            MsgBox(ex.Message)
        End Try

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