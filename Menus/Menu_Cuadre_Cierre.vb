Option Strict Off
Option Explicit On
Friend Class Menu_Cuadre_Cierre
    Inherits System.Windows.Forms.Form
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnCuadre.Click
        Dim Cuadre As New Cuadre
        Cuadre.ShowDialog()
    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        If MainDSO.Tables.Contains("gestiontemp") Then
            MainDSO.Tables("gestiontemp").Rows.Clear()
        End If
        Me.Close()
    End Sub
    Public MovAcum As Boolean = False
    Public Sub Calculate()
        Dim rstgestion As DataRow
        Dim rstgestion2 As DataRow
        Dim rstLibro As DataRow
        Dim rstBanko As DataRow
        Dim idgestion As Double
        Dim codigo As String
        Dim dia As String
        Dim mes As String
        Dim ano As String
        Dim Fecha As Date
        Dim resp As Short
        If MovAcum Then
            resp = 6
        Else
            resp = MsgBox("IMPORTANTE" & vbCrLf & "Realmente esta seguro que desea CERRAR el Mes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BKSistema")
        End If
        If (resp = 6) Then
            codigo = codi

            If (MainDSO.Tables.Contains("gestiontemp")) Then
                If MainDSO.Tables("gestiontemp").Rows.Count = 0 Then
                    MsgBox("Debe realizar el proceso de Cuadre antes para verificar si cuadra el Balance")

                Else
                    If (gest <> 0 Or MovAcum) Then
                        LibroSaldo(0)
                        rstgestion = MainDSO.Tables("gestiontemp").Rows(0)
                        If (rstgestion("DECIERRE") >= 0 Or MovAcum) Then
                            Dim gestion As New DataView
                            gestion.Table = MainDSO.Tables("Gestion")
                            gestion.RowFilter = "codBK='" & codi & "'"
                            gestion.Sort = "idgestion"
                            rstBanko = ThisBanko
                            If gestion.Count > 0 Then
                                idgestion = gestion(gestion.Count - 1)("idgestion")
                            Else
                                idgestion = 0
                            End If
                            rstBanko("SAFGASTOS") = rstgestion("SAFGASTOS")
                            rstgestion2 = MainDSO.Tables("Gestion").NewRow
                            rstgestion2("CodBk") = codigo
                            rstgestion2("idgestion") = idgestion + 1
                            rstgestion2("Finicio") = rstgestion("Finicio")
                            rstgestion2("FCorte") = rstgestion("FCorte")
                            rstgestion2("NTSM") = rstgestion("NTSM")
                            rstgestion2("NTSF") = rstgestion("NTSF")
                            rstgestion2("NTSMACUM") = rstgestion("NTSMACUM")
                            rstgestion2("NTSFACUM") = rstgestion("NTSFACUM")
                            rstgestion2("NTSMR") = rstgestion("NTSMR")
                            rstgestion2("NTSFR") = rstgestion("NTSFR")
                            rstgestion2("NTSMRACUM") = rstgestion("NTSMRACUM")
                            rstgestion2("NTSFRACUM") = rstgestion("NTSFRACUM")
                            rstgestion2("ZVC") = rstgestion("ZVC")
                            rstgestion2("ZVCACUM") = rstgestion("ZVCACUM")
                            rstgestion2("ZLC") = rstgestion("ZLC")
                            rstgestion2("ZLCACUM") = rstgestion("ZLCACUM")
                            rstgestion2("ZCON") = rstgestion("ZCON")
                            rstgestion2("ZCONACUM") = rstgestion("ZCONACUM")
                            rstgestion2("qCON") = rstgestion("qCON")
                            rstgestion2("qCONACUM") = rstgestion("qCONACUM")
                            rstgestion2("ZCOR") = rstgestion("ZCOR")
                            rstgestion2("ZCORACUM") = rstgestion("ZCORACUM")
                            rstgestion2("qCOR") = rstgestion("qCOR")
                            rstgestion2("qCORACUM") = rstgestion("qCORACUM")
                            rstgestion2("ZOR") = rstgestion("ZOR")
                            rstgestion2("ZORACUM") = rstgestion("ZORACUM")
                            rstgestion2("ZMO") = rstgestion("ZMO")
                            rstgestion2("ZMOACUM") = rstgestion("ZMOACUM")
                            rstgestion2("ZOI") = rstgestion("ZOI")
                            rstgestion2("ZOIACUM") = rstgestion("ZOIACUM")
                            rstgestion2("ZEG") = rstgestion("ZEG")
                            rstgestion2("ZEGACUM") = rstgestion("ZEGACUM")
                            rstgestion2("ZBA") = rstgestion("ZBA")
                            rstgestion2("ZBAACUM") = rstgestion("ZBAACUM")
                            rstgestion2("ZDO1") = rstgestion("ZDO1")
                            rstgestion2("ZDO1ACUM") = rstgestion("ZDO1ACUM")
                            rstgestion2("ZDO2") = rstgestion("ZDO2")
                            rstgestion2("ZDO2ACUM") = rstgestion("ZDO2ACUM")
                            rstgestion2("ZICP") = rstgestion("ZICP")
                            rstgestion2("ZICPACUM") = rstgestion("ZICPACUM")
                            rstgestion2("ZECP") = rstgestion("ZECP")
                            rstgestion2("ZECPACUM") = rstgestion("ZECPACUM")
                            rstgestion2("MTCPAGAR") = rstgestion("MTCPAGAR")
                            rstgestion2("ZPC") = rstgestion("ZPC")
                            rstgestion2("ZPCACUM") = rstgestion("ZPCACUM")
                            rstgestion2("ZICB") = rstgestion("ZICB")
                            rstgestion2("ZICBACUM") = rstgestion("ZICBACUM")
                            rstgestion2("MPRECUP") = rstgestion("MPRECUP")
                            rstgestion2("MPRECUP30") = rstgestion("MPRECUP30")
                            rstgestion2("MPRECUP60") = rstgestion("MPRECUP60")
                            rstgestion2("MPRECUP90") = rstgestion("MPRECUP90")
                            rstgestion2("ZRICB") = rstgestion("ZRICB")
                            rstgestion2("ZRICBACUM") = rstgestion("ZRICBACUM")
                            rstgestion2("GestionMB") = rstgestion("GestionMB")
                            rstgestion2("GestionMBACUM") = rstgestion("GestionMBACUM")
                            rstgestion2("ZMRF") = rstgestion("ZMRF")
                            rstgestion2("ZMRFACUM") = rstgestion("ZMRFACUM")
                            rstgestion2("ZGestionMNeto") = rstgestion("ZGestionMNeto")
                            rstgestion2("ZGestionMNetoACUM") = rstgestion("ZGestionMNetoACUM")
                            rstgestion2("ZMONTOGNORep") = rstgestion("ZMONTOGNORep")
                            rstgestion2("RESTCAPS") = rstgestion("RESTCAPS")
                            rstgestion2("ZIFG1") = rstgestion("ZIFG1")
                            rstgestion2("ZIFG1ACUM") = rstgestion("ZIFG1ACUM")
                            rstgestion2("ZGBK1") = rstgestion("ZGBK1")
                            rstgestion2("ZGBK1ACUM") = rstgestion("ZGBK1ACUM")
                            rstgestion2("SAFGASTOS") = rstgestion("SAFGASTOS")
                            rstgestion2("DECIERRE") = rstgestion("DECIERRE")
                            rstgestion2("ZUR") = rstgestion("ZUR")
                            rstgestion2("ZURACUM") = rstgestion("ZURACUM")
                            MainDSO.Tables("Gestion").Rows.Add(rstgestion2)
                            If Not MovAcum Then
                                MsgBox("El Mes fue Cerrado Exitosamente..!")
                                'Bloquea los registros en el libro de IE##############################################################################
                                Dim Libro As New DataView
                                Libro.Table = MainDSO.Tables("TblLibroIE")
                                Libro.RowFilter = "bloqueo=0 AND Anulado=0"
                                Libro.Sort = "Fecha"
                                rstLibro = Libro(0).Row
                                Fecha = rstLibro("fecha")
                                dia = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Day, Fecha))
                                mes = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Month, Fecha))
                                ano = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Year, Fecha))
                                Libro.RowFilter = "bloqueo=0 AND Fecha <= #" & ano & "-" & mes & "-" & DateSerial(ano, mes + 1, 0).Day & "#"
                                If Libro.Count > 0 Then
                                    For Each r As DataRowView In Libro
                                        r("bloqueo") = 1
                                    Next
                                End If
                            End If
                            'Se elimina el Registro Activo en la Gestion Temporal
                            If MainDSO.Tables.Contains("gestiontemp") Then
                                MainDSO.Tables("gestiontemp").Rows.Clear()
                            End If
                        Else
                            MsgBox("No puede cerrar un mes con saldo negativo.")
                        End If
                    Else
                        MsgBox("El Balance no cuadra verifique los movimientos del mes")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnCierre.Click
        Calculate()
    End Sub

    Private Sub Menu_Cuadre_Cierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DynamicPermits Then
            BtnCuadre.Visible = (FindPermit(tuser, "CuadreCierreCuadre") = "1") And ForceSelect
            LblCuadre.Visible = BtnCuadre.Visible
            BtnCierre.Visible = (FindPermit(tuser, "CuadreCierreCierre") = "1") And ForceSelect
            LblCierre.Visible = BtnCierre.Visible
            BtnUndo.Visible = (FindPermit(tuser, "CuadreCierreUndo") = "1") And ForceSelect
            LblUndo.Visible = BtnUndo.Visible
        End If
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        If MsgBox("Está seguro que desea deshacer el último cierre?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim Inicio As Date
            Dim view As New DataView
            view.Table = MainDSO.Gestion
            view.Sort = "FInicio DESC"
            Inicio = Microsoft.VisualBasic.DateSerial(view(0)("FInicio").Year, view(0)("FInicio").Month, 1)
            view(0).Delete()
            view.Table = MainDSO.TblLibroIE
            view.RowFilter = "bloqueo<>0 AND Fecha >= #" & Inicio.ToString("yyyy-MM-dd") & "#"
            'view.RowFilter = "Bloqueo=1 AND Fecha >= #" & Inicio.ToShortDateString & "#"
            For Each r As DataRowView In view
                r("Bloqueo") = 0
            Next
            MsgBox("El cierre con fecha de inicio " & Inicio.ToString("dd/MM/yyyy") & " ha sido revertido.")
        End If
    End Sub
End Class