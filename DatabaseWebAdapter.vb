Imports System.Data.Common
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Collections.Generic


Public Class DatabaseWebAdapter
    Inherits DbDataAdapter
    Private Property _InstructionLimit As Integer
    Public Property InstructionLimit As Integer
        Set(value As Integer)
            If value <= 0 Then
                _InstructionLimit = 1
            End If
        End Set
        Get
            Return _InstructionLimit
        End Get
    End Property
    Public Sub New()
        _InstructionLimit = 100
    End Sub
    Public Function GetStream(inst As Collection, ConnectionString As String) As Stream
        Try

            Dim browser As HttpWebRequest
            browser = HttpWebRequest.Create(ConnectionString)
            browser.Credentials = CredentialCache.DefaultCredentials
            browser.Method = "POST"
            Dim postData As String = ""
            Dim i As Integer = 0
            For Each c As String In inst
                postData += "inst" + i.ToString() + ChrW(61) + c
                If i < inst.Count - 1 Then
                    postData += "&"
                End If
                i += 1
            Next
            Dim encoding As New ASCIIEncoding()
            Dim byte1 As Byte() = encoding.GetBytes(postData)
            browser.ContentType = "application/x-www-form-urlencoded"
            browser.ContentLength = byte1.Length
            browser.Timeout = 50000
            Dim stream As Stream
            Dim a As Integer = 1
            Do
                Try
                    stream = browser.GetRequestStream()
                    stream.Write(byte1, 0, byte1.Length)
                    stream.Close()
                    stream.Dispose()
                    a = 0
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            Loop Until a = 0

            Dim response As HttpWebResponse = browser.GetResponse()
            Return response.GetResponseStream()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Stream.Null
    End Function

    Private Function GetTableFromCommand(command As String) As String
        If command.Contains("FROM") Then
            Dim table As String
            table = command.Substring(command.IndexOf("FROM") + 5)
            If table.Contains("WHERE") Then
                table = table.Remove(table.IndexOf("WHERE") - 1)
            End If
            If table.Contains("ORDER") Then
                table = table.Remove(table.IndexOf("ORDER") - 1)
            End If
            Return table
        Else
            Return ""
        End If
    End Function

    Private Sub CreateColumns(dTable As DataTable)
        Select Case dTable.TableName
            Case "ClasifCreditos"
                dTable.Columns.Add("CodTipo")
                dTable.Columns.Add("Descripcion")
                dTable.Columns.Add("NTSM")
                dTable.Columns.Add("NTSF")
                dTable.Columns.Add("NTCM")
                dTable.Columns.Add("NTCF")
            Case "Gestion"
                dTable.Columns.Add("DEXCAPITAL")
                dTable.Columns.Add("DEXINTERES")
                dTable.Columns.Add("idgestion")
                dTable.Columns.Add("codBK")
                dTable.Columns.Add("Finicio")
                dTable.Columns.Add("FCorte")
                dTable.Columns.Add("NTSM")
                dTable.Columns.Add("NTSMACUM")
                dTable.Columns.Add("NTSMR")
                dTable.Columns.Add("NTSMRACUM")
                dTable.Columns.Add("NTSMA")
                dTable.Columns.Add("NTSF")
                dTable.Columns.Add("NTSFACUM")
                dTable.Columns.Add("NTSFR")
                dTable.Columns.Add("NTSFRACUM")
                dTable.Columns.Add("NTSFA")
                dTable.Columns.Add("qVCt")
                dTable.Columns.Add("qVCACUMt")
                dTable.Columns.Add("ZVC")
                dTable.Columns.Add("ZVCACUM")
                dTable.Columns.Add("qCON")
                dTable.Columns.Add("qCONACUM")
                dTable.Columns.Add("qCOR")
                dTable.Columns.Add("qCORACUM")
                dTable.Columns.Add("ZCON")
                dTable.Columns.Add("ZCONACUM")
                dTable.Columns.Add("ZCOR")
                dTable.Columns.Add("ZCORACUM")
                dTable.Columns.Add("qLCt")
                dTable.Columns.Add("qLCACUMt")
                dTable.Columns.Add("ZLC")
                dTable.Columns.Add("ZLCACUM")
                dTable.Columns.Add("qRI")
                dTable.Columns.Add("ZPC")
                dTable.Columns.Add("ZPCACUM")
                dTable.Columns.Add("MPRECUP")
                dTable.Columns.Add("MPRECUP30")
                dTable.Columns.Add("MPRECUP60")
                dTable.Columns.Add("MPRECUP90")
                dTable.Columns.Add("ZICB")
                dTable.Columns.Add("ZICBACUM")
                dTable.Columns.Add("ZOR")
                dTable.Columns.Add("ZORACUM")
                dTable.Columns.Add("ZMO")
                dTable.Columns.Add("ZMOACUM")
                dTable.Columns.Add("ZOI")
                dTable.Columns.Add("ZOIACUM")
                dTable.Columns.Add("ZRICB")
                dTable.Columns.Add("ZRICBACUM")
                dTable.Columns.Add("ZEG")
                dTable.Columns.Add("ZEGACUM")
                dTable.Columns.Add("ZPEX")
                dTable.Columns.Add("ZPEXACUM")
                dTable.Columns.Add("ZIEX")
                dTable.Columns.Add("ZIEXACUM")
                dTable.Columns.Add("ZDEX")
                dTable.Columns.Add("ZDEXACUM")
                dTable.Columns.Add("ZMEX")
                dTable.Columns.Add("ZMEXACUM")
                dTable.Columns.Add("ZUR")
                dTable.Columns.Add("ZURACUM")
                dTable.Columns.Add("GR")
                dTable.Columns.Add("MRFt")
                dTable.Columns.Add("ZBA")
                dTable.Columns.Add("SAFGASTOS")
                dTable.Columns.Add("MTCPAGAR")
                dTable.Columns.Add("DECIERRE")
                dTable.Columns.Add("ZMONTOGNORep")
                dTable.Columns.Add("GestionMBACUM")
                dTable.Columns.Add("GestionMB")
                dTable.Columns.Add("ZMRFACUM")
                dTable.Columns.Add("ZMRF")
                dTable.Columns.Add("ZGestionMNeto")
                dTable.Columns.Add("ZGestionMNetoACUM")
                dTable.Columns.Add("ZICp")
                dTable.Columns.Add("ZICpACUM")
                dTable.Columns.Add("ZECp")
                dTable.Columns.Add("ZECpACUM")
                dTable.Columns.Add("ZDO1")
                dTable.Columns.Add("ZDO1ACUM")
                dTable.Columns.Add("ZDO2")
                dTable.Columns.Add("ZDO2ACUM")
                dTable.Columns.Add("ZBAACUM")
                dTable.Columns.Add("RESTCAPS")
                dTable.Columns.Add("ZIFG1")
                dTable.Columns.Add("ZIFG1ACUM")
                dTable.Columns.Add("ZIFG2")
                dTable.Columns.Add("ZIFG2ACUM")
                dTable.Columns.Add("ZGBK1")
                dTable.Columns.Add("ZGBK1ACUM")
                dTable.Columns.Add("ZGBK2")
                dTable.Columns.Add("ZGBK2ACUM")
            Case "gestiontemp"
                dTable.Columns.Add("DEXCAPITAL")
                dTable.Columns.Add("DEXINTERES")
                dTable.Columns.Add("idgestion")
                dTable.Columns.Add("codBK")
                dTable.Columns.Add("balance")
                dTable.Columns.Add("Finicio")
                dTable.Columns.Add("FCorte")
                dTable.Columns.Add("NTSM")
                dTable.Columns.Add("NTSMACUM")
                dTable.Columns.Add("NTSMR")
                dTable.Columns.Add("NTSMRACUM")
                dTable.Columns.Add("NTSMA")
                dTable.Columns.Add("NTSF")
                dTable.Columns.Add("NTSFACUM")
                dTable.Columns.Add("NTSFR")
                dTable.Columns.Add("NTSFRACUM")
                dTable.Columns.Add("NTSFA")
                dTable.Columns.Add("qVCt")
                dTable.Columns.Add("qVCACUMt")
                dTable.Columns.Add("ZVC")
                dTable.Columns.Add("ZVCACUM")
                dTable.Columns.Add("qCON")
                dTable.Columns.Add("qCONACUM")
                dTable.Columns.Add("qCOR")
                dTable.Columns.Add("qCORACUM")
                dTable.Columns.Add("ZCON")
                dTable.Columns.Add("ZCONACUM")
                dTable.Columns.Add("ZCOR")
                dTable.Columns.Add("ZCORACUM")
                dTable.Columns.Add("qLCt")
                dTable.Columns.Add("qLCACUMt")
                dTable.Columns.Add("ZLC")
                dTable.Columns.Add("ZLCACUM")
                dTable.Columns.Add("qRI")
                dTable.Columns.Add("ZPC")
                dTable.Columns.Add("ZPCACUM")
                dTable.Columns.Add("MPRECUP")
                dTable.Columns.Add("MPRECUP30")
                dTable.Columns.Add("MPRECUP60")
                dTable.Columns.Add("MPRECUP90")
                dTable.Columns.Add("ZICB")
                dTable.Columns.Add("ZICBACUM")
                dTable.Columns.Add("ZOR")
                dTable.Columns.Add("ZORACUM")
                dTable.Columns.Add("ZMO")
                dTable.Columns.Add("ZMOACUM")
                dTable.Columns.Add("ZOI")
                dTable.Columns.Add("ZOIACUM")
                dTable.Columns.Add("ZRICB")
                dTable.Columns.Add("ZRICBACUM")
                dTable.Columns.Add("ZEG")
                dTable.Columns.Add("ZEGACUM")
                dTable.Columns.Add("ZPEX")
                dTable.Columns.Add("ZPEXACUM")
                dTable.Columns.Add("ZIEX")
                dTable.Columns.Add("ZIEXACUM")
                dTable.Columns.Add("ZDEX")
                dTable.Columns.Add("ZDEXACUM")
                dTable.Columns.Add("ZMEX")
                dTable.Columns.Add("ZMEXACUM")
                dTable.Columns.Add("ZUR")
                dTable.Columns.Add("ZURACUM")
                dTable.Columns.Add("GR")
                dTable.Columns.Add("MRFt")
                dTable.Columns.Add("ZBA")
                dTable.Columns.Add("SAFGASTOS")
                dTable.Columns.Add("MTCPAGAR")
                dTable.Columns.Add("DECIERRE")
                dTable.Columns.Add("ZMONTOGNORep")
                dTable.Columns.Add("GestionMBACUM")
                dTable.Columns.Add("GestionMB")
                dTable.Columns.Add("ZMRFACUM")
                dTable.Columns.Add("ZMRF")
                dTable.Columns.Add("ZGestionMNeto")
                dTable.Columns.Add("ZGestionMNetoACUM")
                dTable.Columns.Add("ZICp")
                dTable.Columns.Add("ZICpACUM")
                dTable.Columns.Add("ZECp")
                dTable.Columns.Add("ZECpACUM")
                dTable.Columns.Add("ZDO1")
                dTable.Columns.Add("ZDO1ACUM")
                dTable.Columns.Add("ZDO2")
                dTable.Columns.Add("ZDO2ACUM")
                dTable.Columns.Add("ZBAACUM")
                dTable.Columns.Add("RESTCAPS")
                dTable.Columns.Add("ZIFG1")
                dTable.Columns.Add("ZIFG1ACUM")
                dTable.Columns.Add("ZIFG2")
                dTable.Columns.Add("ZIFG2ACUM")
                dTable.Columns.Add("ZGBK1")
                dTable.Columns.Add("ZGBK1ACUM")
                dTable.Columns.Add("ZGBK2")
                dTable.Columns.Add("ZGBK2ACUM")
            Case "MovAcumulado"
                dTable.Columns.Add("BanKo")
                dTable.Columns.Add("NTSM")
                dTable.Columns.Add("NTSF")
                dTable.Columns.Add("NTS")
                dTable.Columns.Add("NTCAPS")
                dTable.Columns.Add("NTCRED")
                dTable.Columns.Add("MCRED")
                dTable.Columns.Add("CIERRE")
            Case "RptConsolidado"
                dTable.Columns.Add("CantdeBk")
                dTable.Columns.Add("SociosM")
                dTable.Columns.Add("SociosF")
                dTable.Columns.Add("CAPS")
                dTable.Columns.Add("TotalCreditos")
                dTable.Columns.Add("MontoCreditos")
                dTable.Columns.Add("Ganancias")
            Case "TblAnulaciones"
                dTable.Columns.Add("IdBK")
                dTable.Columns.Add("Fecha")
                dTable.Columns.Add("NoRecibo")
                dTable.Columns.Add("CodOpe")
                dTable.Columns.Add("User")
                dTable.Columns.Add("Clave")
                dTable.Columns.Add("Date")
                dTable.Columns.Add("Accion")
                dTable.Columns.Add("ID")

            Case "TblBanko"
                dTable.Columns.Add("CodBk")
                dTable.Columns.Add("NombreBk")
                dTable.Columns.Add("Proyecto")
                dTable.Columns.Add("Municipio")
                dTable.Columns.Add("PRI")
                dTable.Columns.Add("VCR")
                dTable.Columns.Add("PRFG")
                dTable.Columns.Add("PRGR")
                dTable.Columns.Add("ICCFG")
                dTable.Columns.Add("SaldoBk")
                dTable.Columns.Add("FechaI")
                dTable.Columns.Add("Val_Nominal")
                dTable.Columns.Add("moneda")
                dTable.Columns.Add("TasaIO1")
                dTable.Columns.Add("TasaIO2")
                dTable.Columns.Add("TasaM1")
                dTable.Columns.Add("TasaM2")
                dTable.Columns.Add("MontoMaximo")
                dTable.Columns.Add("Caps-Creditos")
                dTable.Columns.Add("GarantiaFiador")
                dTable.Columns.Add("SAFGASTOS")
                dTable.Columns.Add("Plazo")
                dTable.Columns.Add("PRFP")
            Case "TblBenef"
                dTable.Columns.Add("IdReq")
                dTable.Columns.Add("VinSocio")
                dTable.Columns.Add("NombresB")
                dTable.Columns.Add("CIB")
                dTable.Columns.Add("FechaNace")
                dTable.Columns.Add("Direccion")
                dTable.Columns.Add("Oficio")
                dTable.Columns.Add("Parentesco")
                dTable.Columns.Add("sexo")
                dTable.Columns.Add("CodBK")
            Case "TblClaseCredito"
                dTable.Columns.Add("TipoCreidito")
                dTable.Columns.Add("CodClase")
                dTable.Columns.Add("Descripcion")
            Case "TblCodCCr"
                dTable.Columns.Add("idCC")
                dTable.Columns.Add("vinOpe")
                dTable.Columns.Add("Descripcion")
                dTable.Columns.Add("formulario")
                dTable.Columns.Add("comentario")
                dTable.Columns.Add("ordenar")
            Case "TblCorrige"
                dTable.Columns.Add("id")
                dTable.Columns.Add("codbk")
                dTable.Columns.Add("fechac")
                dTable.Columns.Add("codop")
                dTable.Columns.Add("fechalibro")
                dTable.Columns.Add("nrecibo")
                dTable.Columns.Add("CIerrada")
                dTable.Columns.Add("CIcorrecta")
                dTable.Columns.Add("Ingreso")
                dTable.Columns.Add("Descripcion")
                dTable.Columns.Add("Egreso")
                dTable.Columns.Add("usuario")
                dTable.Columns.Add("fechaOp")
            Case "TblCredito"
                dTable.Columns.Add("IdOp")
                dTable.Columns.Add("VCI")
                dTable.Columns.Add("VBK")
                dTable.Columns.Add("NoCredito")
                dTable.Columns.Add("Fecha")
                dTable.Columns.Add("FechaVence")
                dTable.Columns.Add("MontoCred")
                dTable.Columns.Add("Tipo")
                dTable.Columns.Add("Saldo")
                dTable.Columns.Add("IntDEX")
                dTable.Columns.Add("MontoIntDEX")
                dTable.Columns.Add("MoraDEX")
                dTable.Columns.Add("Cancelado")
                dTable.Columns.Add("FechaCancela")
                dTable.Columns.Add("sexo")
                dTable.Columns.Add("deuda")
                dTable.Columns.Add("incobrable")
                dTable.Columns.Add("TasaIO")
                dTable.Columns.Add("TasaMO")
                dTable.Columns.Add("Riezgo")
                dTable.Columns.Add("Frecuencia")
                dTable.Columns.Add("Clase")
            Case "TblEstados"
                dTable.Columns.Add("ID")
                dTable.Columns.Add("Nombre")
                dTable.Columns.Add("PID")
            Case "TblFiadores"
                dTable.Columns.Add("CodBk")
                dTable.Columns.Add("NoCredito")
                dTable.Columns.Add("CI")
                dTable.Columns.Add("CapsGarantia")
                dTable.Columns.Add("porcentajegarantizado")
                dTable.Columns.Add("Observacion")
            Case "TblLibroIE"
                dTable.Columns.Add("IdReg")
                dTable.Columns.Add("IdOpe")
                dTable.Columns.Add("IdBK")
                dTable.Columns.Add("Fecha")
                dTable.Columns.Add("NoCredito")
                dTable.Columns.Add("NoRecibo")
                dTable.Columns.Add("CI")
                dTable.Columns.Add("CodOpe")
                dTable.Columns.Add("Descripcion")
                dTable.Columns.Add("Ingreso")
                dTable.Columns.Add("Egreso")
                dTable.Columns.Add("Saldo")
                dTable.Columns.Add("bloqueo")
                dTable.Columns.Add("Anulado")
            Case "TblLibroIETemp"
                dTable.Columns.Add("IdReg")
                dTable.Columns.Add("IdBK")
                dTable.Columns.Add("Fecha")
                dTable.Columns.Add("NoCredito")
                dTable.Columns.Add("NoRecibo")
                dTable.Columns.Add("CI")
                dTable.Columns.Add("CodOpe")
                dTable.Columns.Add("Descripcion")
                dTable.Columns.Add("Ingreso")
                dTable.Columns.Add("Egreso")
                dTable.Columns.Add("Saldo")
                dTable.Columns.Add("bloqueo")
            Case "TblMesbloqueado"
                dTable.Columns.Add("codBanco")
                dTable.Columns.Add("FechaG")
                dTable.Columns.Add("SaldoalCierre")
            Case "TblMunicipios"
                dTable.Columns.Add("ID")
                dTable.Columns.Add("Municipios")
                dTable.Columns.Add("EID")
            Case "TblOperacion"
                dTable.Columns.Add("CodOPe")
                dTable.Columns.Add("Descripcion")
                dTable.Columns.Add("Tipo")
            Case "TblPaises"
                dTable.Columns.Add("ID")
                dTable.Columns.Add("Nombre")
            Case "TblProyectos"
                dTable.Columns.Add("ID")
                dTable.Columns.Add("Nombre")
            Case "tblreportecred"
                dTable.Columns.Add("codbk")
                dTable.Columns.Add("tipo")
                dTable.Columns.Add("descripcion")
                dTable.Columns.Add("Qm")
                dTable.Columns.Add("Qh")
                dTable.Columns.Add("MontoM")
                dTable.Columns.Add("Montoh")
                dTable.Columns.Add("Desde")
                dTable.Columns.Add("Hasta")
            Case "TblSocios"
                dTable.Columns.Add("CI")
                dTable.Columns.Add("CodBk")
                dTable.Columns.Add("Nombres")
                dTable.Columns.Add("Sexo")
                dTable.Columns.Add("FNace")
                dTable.Columns.Add("Profesion")
                dTable.Columns.Add("Direccion")
                dTable.Columns.Add("Telefono")
                dTable.Columns.Add("FIngreso")
                dTable.Columns.Add("AcumMoras")
                dTable.Columns.Add("Estatus")
                dTable.Columns.Add("Deuda")
                dTable.Columns.Add("Fretiro")
                dTable.Columns.Add("cap")
                dTable.Columns.Add("CapLiq")
                dTable.Columns.Add("Email")
            Case "tblTope"
                dTable.Columns.Add("tope")
            Case "tblTraspasos"
                dTable.Columns.Add("iDreq")
                dTable.Columns.Add("idbk")
                dTable.Columns.Add("fechaOp")
                dTable.Columns.Add("NombresT")
                dTable.Columns.Add("CIT")
                dTable.Columns.Add("NombresR")
                dTable.Columns.Add("CIR")
                dTable.Columns.Add("Cantidad")
                dTable.Columns.Add("monto")
            Case "TblUserconfig"
                dTable.Columns.Add("User")
                dTable.Columns.Add("var")
                dTable.Columns.Add("val")
            Case "tblUsuario"
                dTable.Columns.Add("Usuario")
                dTable.Columns.Add("Clave")
                dTable.Columns.Add("TipoUser")
                dTable.Columns.Add("Bk")
            Case "TipoCredito"
                dTable.Columns.Add("Clase")
                dTable.Columns.Add("DescripClase")

        End Select
        SetKeys(dTable)
    End Sub

    Public Overrides Function Fill(dataSet As DataSet) As Integer
        Dim stream As Stream
        Dim inst As New Collection
        inst.Add(Me.SelectCommand.CommandText)
        stream = GetStream(inst, Me.SelectCommand.Connection.ConnectionString)
        Dim reader As New StreamReader(stream)
        Dim line As String = reader.ReadLine()
        Dim lineArr As New Dictionary(Of String, String)

        Dim table As String = GetTableFromCommand(Me.SelectCommand.CommandText)
        Dim dTable As DataTable
        If Not dataSet.Tables.Contains(table) Then
            dTable = dataSet.Tables.Add(table)
        Else
            dataSet.Tables(table).Rows.Clear()
            dTable = dataSet.Tables.Item(table)
        End If

        'Try

        While (line <> "</html>")

            If line.Contains("Errors:") Or line.Contains("Empty") Then
                If line.Contains("Empty") And dTable.Columns.Count = 0 Then
                    CreateColumns(dTable)
                End If
                line = reader.ReadLine()
                Continue While
            Else
                line = Decode(line, False)
                lineArr = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(line)

                line = reader.ReadLine()
                If lineArr.Count > 0 Then
                    If dTable.Columns.Count = 0 Then
                        CreateColumns(dTable)
                    End If

                    Dim row As DataRow = dTable.NewRow()
                    For Each kv As KeyValuePair(Of String, String) In lineArr
                        If kv.Value.Contains("0000-00-00") Or kv.Value.Contains("0001-01-01") Then
                            row(kv.Key) = CType(Nothing, DateTime)
                        Else
                            row(kv.Key) = kv.Value
                            If (kv.Value Like "*#.#*" Or
                                kv.Value Like "#.#*" Or
                                kv.Value Like "*#.#" Or
                                kv.Value Like "#.#") And
                                kv.Key <> "Email" Then
                                row(kv.Key) = Double.Parse(kv.Value.ToString.Replace(".", ","))
                            End If
                        End If
                    Next
                    dTable.Rows.Add(row)
                End If
            End If
        End While

        'Catch ex As Exception
        'MessageBox.Show(ex.Message & " " & ex.StackTrace)
        'End Try
        Return dTable.Rows.Count
    End Function
    Public Overrides Function Update(dataSet As DataSet) As Integer
        Dim OriginalDataset As New MainDS
        Dim inst As New Collection
        LoadOnline(OriginalDataset)
        For Each uTable As DataTable In dataSet.Tables
            If uTable.PrimaryKey.Length = 0 Then SetKeys(uTable)
            Dim OriginalTable As DataTable
            OriginalTable = OriginalDataset.Tables(uTable.TableName) 'find original table equivalent
            If OriginalTable.PrimaryKey.Length = 0 Then SetKeys(OriginalTable)
            Dim i As Integer = 0
            Dim Keys(OriginalTable.PrimaryKey.Length - 1) As Object
            If uTable.Rows.Count > 0 Then
                For Each r As DataRow In uTable.Rows
                    i = 0
                    For Each key As DataColumn In OriginalTable.PrimaryKey 'build search params
                        Keys(i) = r.Item(key.ColumnName)
                        i += 1
                    Next
                    Dim test As Boolean = OriginalTable.Rows.Count > 0 ' make sure there are rows in there
                    If test Then test = OriginalTable.Rows.Contains(Keys) 'look for the current record

                    If test Then 'if found, build UPDATE command
                        Dim row As DataRow = OriginalTable.Rows.Find(Keys)
                        i = 0
                        For j As Integer = 0 To r.ItemArray.Length - 1    'check for changes
                            If row(j).ToString.Contains("2012-00-00") Or row(j).ToString.Contains("2001-01-01") Then 'null date handling
                                row(j) = CDate(Nothing)
                            End If
                            If r(j).ToString.Contains("2012-00-00") Or r(j).ToString.Contains("2001-01-01") Then
                                r(j) = CDate(Nothing)
                            End If
                            If row(j).GetType.Equals(GetType(String)) Or r(j).GetType.Equals(GetType(String)) Then
                                'handle whitespace
                                r(j) = r(j).ToString.Trim
                            End If
                            'date format handling
                            If row(j).GetType.Equals(GetType(Date)) Or r(j).GetType.Equals(GetType(Date)) Or row(j).GetType.Equals(GetType(DateTime)) Or r(j).GetType.Equals(GetType(DateTime)) Then
                                test = test And (CDate(row(j)) = CDate(IIf(r.IsNull(j), Nothing, r(j))))
                            Else
                                test = test And row(j) = IIf(r.IsNull(j), Nothing, r(j)) 'handle DBnull values
                            End If
                            If Not test Then
                                Debug.WriteLine(row.Table.TableName & " : " & row.Table.Columns(j).ColumnName & " : " & row(j) & " <> " & r(j))
                            End If
                        Next
                        If Not test Then
                            Dim instruction As String = "UPDATE " + uTable.TableName + " SET "
                            Dim value As String = ""
                            For Each c As DataColumn In uTable.Columns
                                value = r(c.ColumnName).ToString.Trim
                                If GetType(Date).Equals(r(c.ColumnName).GetType) Then
                                    value = SQLDate(r(c.ColumnName))
                                End If
                                If GetType(Double).Equals(r(c.ColumnName).GetType) Then
                                    value = CDbl(r(c.ColumnName)).ToString.Replace(",", ".")
                                End If
                                If value Like "*#.#*" Or value Like "#.#*" Or value Like "*#.#" Or value Like "#.#" Then
                                    value = value.ToString.Replace(",", ".")
                                End If

                                instruction += c.ColumnName & "='" & value & "',"
                            Next
                            instruction = instruction.Remove(instruction.Length - 1)
                            instruction += "WHERE "
                            For Each c As DataColumn In uTable.PrimaryKey
                                If GetType(Date).Equals(r(c.ColumnName).GetType) Then
                                    value = SQLDate(r(c.ColumnName))
                                Else
                                    value = r(c.ColumnName)
                                End If
                                instruction += c.ColumnName & "='" & value & "' AND "
                            Next
                            instruction = instruction.Remove(instruction.Length - 5)
                            inst.Add(instruction)
                        End If
                    Else 'if not found INSERT new record
                        Dim instruction As String = "INSERT INTO " + uTable.TableName + " VALUES ("
                        For Each c As DataColumn In uTable.Columns
                            Dim value As String = r(c.ColumnName).ToString
                            If GetType(Date).Equals(r(c.ColumnName).GetType) Then
                                value = SQLDate(r(c.ColumnName))
                            End If
                            If GetType(Double).Equals(r(c.ColumnName).GetType) Then
                                value = CDbl(r(c.ColumnName)).ToString.Replace(",", ".")
                            End If
                            If value Like "*#.#*" Or value Like "#.#*" Or value Like "*#.#" Or value Like "#.#" Then
                                value = value.ToString.Replace(",", ".")
                            End If

                            instruction += "'" & value & "',"
                        Next
                        instruction = instruction.Remove(instruction.Length - 1)
                        instruction += ")"
                        inst.Add(instruction)
                    End If
                Next
            End If
            If OriginalTable.Rows.Count > 0 Then
                For Each r As DataRow In OriginalTable.Rows
                    i = 0
                    For Each key As DataColumn In uTable.PrimaryKey
                        Keys(i) = r.Item(key.ColumnName)
                        i += 1
                    Next
                    Dim test As Boolean = uTable.Rows.Count > 0 'new table has any rows
                    If test Then test = uTable.Rows.Contains(Keys) 'if so look for old record in new table

                    If Not test And tuser = 1 Then 'if not found then DELETE it
                        Dim instruction As String = "DELETE FROM " + uTable.TableName + " WHERE "
                        For Each c As DataColumn In uTable.PrimaryKey
                            Dim value As String = r(c.ColumnName).ToString
                            If GetType(Date).Equals(c.GetType) Then
                                value = SQLDate(r(c.ColumnName))
                                Debug.WriteLine(value)
                            End If
                            If GetType(Double).Equals(r(c.ColumnName).GetType) Then
                                value = CDbl(r(c.ColumnName)).ToString.Replace(",", ".")
                            End If
                            If value Like "*#.#*" Or value Like "#.#*" Or value Like "*#.#" Or value Like "#.#" Then
                                value = value.ToString.Replace(",", ".")
                            End If

                            instruction += c.ColumnName + "='" + value + "' AND "
                            instruction = instruction.Remove(instruction.Length - 5)
                            If False Then inst.Add(instruction)
                        Next
                    End If
                Next
            End If

        Next
        If inst.Count > 0 Then
            Dim finalinst As New Collection
            Dim dlg As New Form
            Dim pb As New ProgressBar
            Dim lbl As New Label
            lbl.Text = "Subiendo data..."
            ShowProgressBar(dlg, pb, lbl)
            pb.Value = 0
            pb.Maximum = inst.Count - 1
            For i As Integer = 1 To inst.Count
                pb.PerformStep()
                lbl.Text = "Subiendo data... [" & i & "/" & inst.Count & "]"
                finalinst.Add(Decode(inst.Item(i), True))
                Debug.WriteLine(Decode(inst.Item(i), True))
                If finalinst.Count = _InstructionLimit Or i = inst.Count Then
                    Debug.WriteLine("Uploading " + i.ToString())
                    Dim stream As Stream
                    stream = GetStream(finalinst, My.Settings.ConnectionString)
                    Dim reader As New StreamReader(stream)
                    stream.Close()
                    stream.Dispose()
                    'TODO: read stream error handling
                    finalinst.Clear()
                End If
            Next
            MsgBox("Se ha actualizado la base de datos online...")
            dlg.Close()
        Else
            MsgBox("No hay registros que actualizar...")
        End If
        Debug.WriteLine("Done Updating...")
        Return inst.Count
    End Function
End Class
