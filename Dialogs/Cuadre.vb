Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Cuadre
    Inherits System.Windows.Forms.Form
    Public MovAcum As Boolean = False
    Public Banko As String = ""
    Private Function GetNTS(FechaP As Date, FechaU As Date, male As Boolean, Optional Ret As Boolean = False) As Integer
        Dim Socios As New DataView
        Socios.Table = MainDSO.Tables("TblSocios")
        Socios.RowFilter = "CodBk='" & codi & "' AND (Sexo = '" & IIf(male, "M", "F") & "' OR Sexo ='" & IIf(male, "m", "f") & "') AND " & IIf(Ret, "Fretiro", "FIngreso") & " >= #" & FechaP.ToString("yyyy-MM-dd") & "# AND " & IIf(Ret, "Fretiro", "FIngreso") & " <= #" & FechaU.ToString("yyyy-MM-dd") & "#" & IIf(Ret, " AND (Estatus=2 OR Estatus=3)", "")
        Return Socios.Count
    End Function
    Private Function GetNTSAcum(NTS As Integer, male As Boolean, Optional Ret As Boolean = False) As Integer
        Dim rstACUM As New DataView
        rstACUM.Table = MainDSO.Tables("Gestion")
        rstACUM.Sort = "FInicio DESC"
        rstACUM.RowFilter = "codBK='" & codi & "'"
        Dim colname As String = "NTS" & IIf(male, "M", "F") & IIf(Ret, "R", "") & "ACUM"
        Dim retval As Integer
        If rstACUM.Count > 0 Then
            retval = NTS + rstACUM(0)(colname)
        Else
            retval = NTS
        End If
        Return retval
    End Function

    Private Function GetZOPE(FechaPrimero As Date, FechaUltimo As Date, CodOpe As String, Ingreso As Boolean, Optional Nominal As Boolean = True) As Double
        Dim retval As Double = 0
        Dim rstlibro As New DataView
        rstlibro.Table = MainDSO.Tables("TblLibroIE")
        rstlibro.RowFilter = "Anulado=0 AND IdBK='" & codi & "' AND CodOpe = '" & CodOpe & "' AND Fecha >=#" & FechaPrimero.ToString("yyyy-MM-dd") & "# AND Fecha <=#" & FechaUltimo.ToString("yyyy-MM-dd") & "#"
        Dim colname As String = IIf(Ingreso, "Ingreso", "Egreso")
        For Each r As DataRowView In rstlibro
            retval += CDbl(r(colname))
        Next
        If Nominal Then
            If (retval > 0) Then
                retval = retval / ThisBanko("Val_Nominal")
            Else
                retval = 0
            End If
        End If

        Return retval
    End Function

    Private Function GetqOPE(FechaPrimero As Date, FechaUltimo As Date, CodOpe As String) As Integer
        Dim view As New DataView
        view.Table = MainDSO.Tables("TblLibroIE")
        view.RowFilter = "Anulado=0 AND IdBK='" & codi & "' AND CodOpe = '" & CodOpe & "' AND Fecha >=#" & FechaPrimero.ToString("yyyy-MM-dd") & "# AND Fecha <=#" & FechaUltimo.ToString("yyyy-MM-dd") & "#"
        Return view.Count
    End Function
    Public Sub Calculate()
        Dim ZIFG1ACUM As Double
        Dim difDias As Integer
        Dim NTSFRACUM As Double
        Dim NTSMRACUM As Double
        Dim NTSFR As Double
        Dim NTSMR As Double
        Dim NTSFACUM As Double
        Dim NTSMACUM As Double
        Dim PRGR As Object
        Dim rstLibro As New DataView
        Dim rstACUM As New DataView
        Dim rstGestemp As DataRow
        Dim Fecha As Date
        Dim diaultimo As String
        Dim mes As String
        Dim ano As String
        Dim FechaUltimo As Date
        Dim NTSM As Double
        Dim NTSF As Double
        Dim ZLC As Double
        Dim ZLCC As Double
        Dim ZLCACUM As Double
        Dim ZVC As Double
        Dim ZVCACUM As Double
        Dim NTCA As Double
        Dim qCON As Double
        Dim ZCON As Double
        Dim qCOR As Double
        Dim ZCOR As Double
        Dim qCONACUM As Double
        Dim ZCONACUM As Double
        Dim qCORACUM As Double
        Dim ZCORACUM As Double
        Dim ZOR As Double
        Dim ZORACUM As Double
        Dim ZMO As Double
        Dim ZMOACUM As Double
        Dim ZOI As Double
        Dim ZOIACUM As Double
        Dim ZEG As Double
        Dim ZEGACUM As Double
        Dim ZUR As Double
        Dim ZURACUM As Double
        Dim ZICP As Double
        Dim ZICPACUM As Double
        Dim ZECP As Double
        Dim ZECPACUM As Double
        Dim MTCPAGAR As Double
        Dim ZDO1ACUM As Double
        Dim ZDO1 As Double
        Dim ZDO2ACUM As Double
        Dim ZDO2 As Double
        Dim ZBA As Double
        Dim ZBAACUM As Double
        Dim ZPC As Double
        Dim ZPCACUM As Double
        Dim ZICB As Double
        Dim ZICBACUM As Double
        Dim MPRECUP As Double
        Dim MPRECUP30 As Double
        Dim MPRECUP60 As Double
        Dim MPRECUP90 As Double
        Dim ZRICB As Double
        Dim ZRICBACUM As Double
        Dim GestionMB As Double
        Dim GestionMBACUM As Double
        Dim ZMRF As Double
        Dim ZMRFACUM As Double
        Dim ZGestionMNeto As Double
        Dim ZGestionMNetoACUM As Double
        Dim ZMONTOGNORep As Double
        Dim RESTCAPS As Double
        Dim ZIFG1 As Double
        Dim ZGBK1 As Double
        Dim ZGBK1ACUM As Double
        Dim safgastos As Double
        Dim DECIERRE As Double
        Dim Finicio As Date
        Dim FCorte As Date
        Dim f1 As Double
        Dim f2 As Double
        Dim valnominal As Double
        Dim ppi As Double
        Dim ZPRFP As Double
        Dim PRFP As Double
        Dim tope As Double
        Dim FechaPrimero As Date
        If (CFecha.Text <> "" Or MovAcum) Then
            If MovAcum Then
                ThisBanko = MainDSO.Tables("TblBanko").Rows.Find(Banko)
                codi = Banko
            End If
            rstLibro.Table = MainDSO.Tables("TblLibroIE")
            rstLibro.RowFilter = "IdBK='" & codi & "' AND bloqueo=0 AND Anulado=0"
            rstLibro.Sort = "Fecha ASC"
            rstACUM.Table = MainDSO.Tables("Gestion")
            rstACUM.Sort = "FInicio DESC"
            rstACUM.RowFilter = "codBK='" & codi & "'"
            LibroSaldo(0)

            valnominal = ThisBanko("Val_nominal")
            PRFP = ThisBanko("PRFP")
            PRGR = ThisBanko("PRGR")
            ppi = ThisBanko("PRI")
            Fecha = rstLibro(0)("Fecha")
            Finicio = Fecha
            mes = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Month, Fecha))
            ano = CStr(DatePart(Microsoft.VisualBasic.DateInterval.Year, Fecha))
            diaultimo = CStr(VB.Day(DateSerial(Year(Fecha), Month(Fecha) + 1, 0)))
            FechaPrimero = CDate("01/" & mes & "/" & ano)
            FechaUltimo = CDate(diaultimo & "/" & mes & "/" & ano)

            'Dim Socios As New DataView
            'Socios.Table = MainDSO.Tables("TblSocios")
            NTSM = GetNTS(FechaPrimero, FechaUltimo, True)
            NTSF = GetNTS(FechaPrimero, FechaUltimo, False)

            'Calcular los totales de Socios Nuevos Masculinos y Femeninos
            NTSFACUM = GetNTSAcum(NTSF, False)
            NTSMACUM = GetNTSAcum(NTSM, True)
            
            'Calcula el numero total de Socios Retirados Masculinos
            NTSMR = GetNTS(FechaPrimero, FechaUltimo, True, True)

            'Calcular el numero total de Socios Retirados Femeninos
            NTSFR = GetNTS(FechaPrimero, FechaUltimo, False, True)


            'Calcular el Acumunado de Socios Retirados Femeninos y Masculinos
            NTSMRACUM = GetNTSAcum(NTSMR, True, True)
            NTSFRACUM = GetNTSAcum(NTSFR, False, True)
            
            'Calculo del total de VC y VCRR
            ZVC = GetZOPE(FechaPrimero, FechaUltimo, "VC", True) + GetZOPE(FechaPrimero, FechaUltimo, "VCRR", True)

            'Calculo del total de LCC
            ZLCC = GetZOPE(FechaPrimero, FechaUltimo, "LCC", False)

            'Calcular los Acumulados del ZVC y ZLCC
            If rstACUM.Count > 0 Then
                ZVCACUM = rstACUM(0)("ZVCACUM") + ZVC - ZLCC
            Else
                ZVCACUM = ZVC - ZLCC
            End If

            'Calcular el total de LC
            ZLC = GetZOPE(FechaPrimero, FechaUltimo, "LC", False)
            
            'Calcular los Acumulados de LC
            If rstACUM.Count > 0 Then
                ZLCACUM = (rstACUM(0)("ZLCACUM") + ZLC)
            Else
                ZLCACUM = (ZLC)
            End If

            'Calcular el numero total de Caps Activos
            NTCA = ZVCACUM - ZLCACUM

            'Se calcula el tope
            tope = ((NTCA * valnominal) * PRGR) / 100

            'Calcular el numero de Creditos Otorgados en el Mes (CON)
            qCON = GetqOPE(FechaPrimero, FechaUltimo, "CON")

            'Calcular el monto en creditos otorgados en el mes (ZCON)
            ZCON = GetZOPE(FechaPrimero, FechaUltimo, "CON", False, False)

            'Calcular el numero de Creditos Refinanciados en el Mes (COR)
            qCOR = GetqOPE(FechaPrimero, FechaUltimo, "COR")

            'Calcular el monto en creditos Refinanciados en el mes (ZCOR)
            ZCOR = GetZOPE(FechaPrimero, FechaUltimo, "COR", False, False)
            
            'Calcular los Totales del Otorgamiento de Creditos
            If rstACUM.Count > 0 Then
                qCONACUM = rstACUM(0)("qCONACUM") + qCON
                qCORACUM = rstACUM(0)("qCORACUM") + qCOR
            Else
                qCONACUM = qCON
                qCORACUM = qCOR
            End If
            If rstACUM.Count > 0 Then
                ZCONACUM = System.Math.Round(rstACUM(0)("ZCONACUM") + ZCON, 2)
                ZCORACUM = System.Math.Round(rstACUM(0)("ZCORACUM") + ZCOR, 2)
            Else
                ZCONACUM = System.Math.Round(ZCON, 2)
                ZCORACUM = System.Math.Round(ZCOR, 2)
            End If

            'Calcular los totales de Intereses Ordinarios (OR)
            ZOR = GetZOPE(FechaPrimero, FechaUltimo, "OR", True, False)

            'Calcular el total de Intereses Ordinarios (OR)
            If (CDbl(mes) <> 1) Then
                If rstACUM.Count > 0 Then
                    ZORACUM = System.Math.Round(rstACUM(0)("ZORACUM") + ZOR, 2)
                Else
                    ZORACUM = System.Math.Round(ZOR, 2)
                End If
            Else
                ZORACUM = System.Math.Round(ZOR, 2)
            End If

            'Calcular los totales de Intereses de Mora (MO)
            ZMO = GetZOPE(FechaPrimero, FechaUltimo, "MO", True, False)

            'Calcular el total de Intereses de Mora (MO)
            If (CDbl(mes) <> 1) Then
                If rstACUM.Count > 0 Then
                    ZMOACUM = System.Math.Round(rstACUM(0)("ZMOACUM") + ZMO, 2)
                Else
                    ZMOACUM = System.Math.Round(ZMO, 2)
                End If
            Else
                ZMOACUM = System.Math.Round(ZMO, 2)
            End If

            'Calcular los totales de otros Ingresos (OI)
            ZOI = GetZOPE(FechaPrimero, FechaUltimo, "PDP", True, False) + GetZOPE(FechaPrimero, FechaUltimo, "OI", True, False)

            'Calcular el total de Otros Ingresos (OI)
            If (CDbl(mes) <> 1) Then
                If rstACUM.Count > 0 Then
                    ZOIACUM = System.Math.Round(rstACUM(0)("ZOIACUM") + ZOI, 2)
                Else
                    ZOIACUM = System.Math.Round(ZOI, 2)
                End If
            Else
                ZOIACUM = System.Math.Round(ZOI, 2)
            End If

            'Calcular los totales de otros Egresos (EG)
            ZEG = GetZOPE(FechaPrimero, FechaUltimo, "EG", False, False) + GetZOPE(FechaPrimero, FechaUltimo, "RI", False, False)

            'Calcular el total de Otros Egresos (EG)
            If (CDbl(mes) <> 1) Then
                If rstACUM.Count > 0 Then
                    ZEGACUM = System.Math.Round(rstACUM(0)("ZEGACUM") + ZEG, 2)
                Else
                    ZEGACUM = System.Math.Round(ZEG, 2)
                End If
            Else
                ZEGACUM = System.Math.Round(ZEG, 2)
            End If

            'Calcular los totales de Ganacias Repartdias (UR)
            ZUR = GetZOPE(FechaPrimero, FechaUltimo, "UR", False, False)

            'Calcular el total de Ganancias Repartidas
            If (CDbl(mes) <> 1) Then
                If rstACUM.Count > 0 Then
                    ZURACUM = System.Math.Round(rstACUM(0)("ZURACUM") + ZUR, 2)
                Else
                    ZURACUM = System.Math.Round(ZUR, 2)
                End If
            Else
                ZURACUM = System.Math.Round(ZUR, 2)
            End If

            'Calcular los totales de ICP
            ZICP = GetZOPE(FechaPrimero, FechaUltimo, "ICP", True, False)

            'Calcular los totales de ECP
            ZECP = GetZOPE(FechaPrimero, FechaUltimo, "ECP", True, False)

            'Calcular el Monto total de las Cuentas por Pagar MTCPAGAR
            If rstACUM.Count > 0 Then
                MTCPAGAR = System.Math.Round((rstACUM(0)("MTCPAGAR") + ZICP) - ZECP, 2)
            Else
                MTCPAGAR = System.Math.Round((ZICP) - ZECP, 2)
            End If

            'Calcular los totales de DO1
            ZDO1 = GetZOPE(FechaPrimero, FechaUltimo, "DO1", True, False)

            'Calcular el total de DO1
            If rstACUM.Count > 0 Then
                ZDO1ACUM = System.Math.Round(rstACUM(0)("ZDO1ACUM") + ZDO1, 2)
            Else
                ZDO1ACUM = System.Math.Round(ZDO1, 2)
            End If

            'Calcular los totales de DO2
            ZDO2 = GetZOPE(FechaPrimero, FechaUltimo, "DO2", True, False)

            'Calcular el total de DO2
            If rstACUM.Count > 0 Then
                ZDO2ACUM = System.Math.Round(rstACUM(0)("ZDO2ACUM") + ZDO2, 2)
            Else
                ZDO2ACUM = System.Math.Round(ZDO2, 2)
            End If

            'Calcular los totales de BA
            ZBA = GetZOPE(FechaPrimero, FechaUltimo, "BA", False, False)

            'Calcular el total de BA
            If rstACUM.Count > 0 Then
                ZBAACUM = System.Math.Round(rstACUM(0)("ZBAACUM") + ZBA, 2)
            Else
                ZBAACUM = System.Math.Round(ZBA, 2)
            End If

            'Calcular los totales de Pago de Cuotas (PC)
            ZPC = GetZOPE(FechaPrimero, FechaUltimo, "PC", True, False)

            'Calcular los totales de los Creditos pasados a incobrables (ZICB)
            rstLibro.Table = MainDSO.Tables("TblCredito")
            rstLibro.RowFilter = "VBK='" & codi & "' AND IdOp=0 AND incobrable=1 AND FechaCancela >=#" & FechaPrimero.ToString("yyyy-MM-dd") & "# AND Fecha <=#" & FechaUltimo.ToString("yyyy-MM-dd") & "#"
            ZICB = 0
            For Each r As DataRowView In rstLibro
                ZICB += CDbl(r("deuda"))
            Next
            ZICB = Math.Round(ZICB, 2)

            'Calcular el total de ICB Incobrables
            If rstACUM.Count > 0 Then
                ZICBACUM = System.Math.Round(rstACUM(0)("ZICBACUM") + ZICB, 2)
            Else
                ZICBACUM = System.Math.Round(ZICB, 2)
            End If

            'Calcular el total de Montos Recuperados
            If rstACUM.Count > 0 Then
                ZPCACUM = System.Math.Round(rstACUM(0)("ZPCACUM") + ZPC, 2)
            Else
                ZPCACUM = System.Math.Round(ZPC, 2)
            End If

            'Calcular el total de Montos por Recuperar
            MPRECUP = System.Math.Round((ZCONACUM + ZCORACUM) - (ZPCACUM + ZICBACUM), 2)

            'calcular la mora a 30 60 y 90
            rstLibro.RowFilter = "IdOp=0 AND VBK='" & codi & "' AND fechavence < #" & VB6.Format(FechaUltimo, "mm/dd/YY") & "# AND saldo > 0"
            MPRECUP30 = 0
            MPRECUP60 = 0
            MPRECUP90 = 0
            For Each r As DataRowView In rstLibro
                difDias = CShort(DateDiff(Microsoft.VisualBasic.DateInterval.Day, r("Fechavence"), FechaUltimo))
                r("NoCredito") = r("NoCredito")
                If difDias >= 30 And difDias <= 60 Then
                    MPRECUP30 = MPRECUP30 + r("Saldo")
                ElseIf difDias > 60 And difDias <= 90 Then
                    MPRECUP60 = MPRECUP60 + r("Saldo")
                ElseIf difDias > 90 Then
                    MPRECUP90 = MPRECUP90 + r("Saldo")
                End If
            Next

            'Calcular el Balance de Gestion Mensual Bruto restar excedente de incobrables si es negativo
            GestionMB = System.Math.Round(((ZOR + ZMO + ZOI)) - ZEG, 2)
            'ZRICBACUM = rstACUM(0)("ZRICBACUM") - ZICB
            If (CDbl(mes) <> 1) Then
                If rstACUM.Count > 0 Then
                    GestionMBACUM = System.Math.Round(GestionMB + rstACUM(0)("GestionMBACUM"), 2)
                Else
                    GestionMBACUM = System.Math.Round(GestionMB, 2)
                End If
            Else
                GestionMBACUM = System.Math.Round(GestionMB, 2)
            End If
            'Calcular el Monto Retenido para Fondo de Protección
            ZPRFP = (((GestionMB) * PRFP) / 100)

            'Calcular la Provision por Mora (ZRICB Y ZRICBACUM)

            If rstACUM.Count > 0 Then
                If (rstACUM(0)("ZRICBACUM") < tope) Then
                    ZRICB = System.Math.Round(((GestionMB) * ppi) / 100, 2)
                Else
                    ZRICB = 0
                End If
            Else
                ZRICB = System.Math.Round(((GestionMB) * ppi) / 100, 2)
            End If

            If (GestionMB < 0) Then
                ZRICB = 0
            End If

            If rstACUM.Count > 0 Then
                ZRICBACUM = System.Math.Round(ZRICB + rstACUM(0)("ZRICBACUM"), 2)
            Else
                ZRICBACUM = System.Math.Round(ZRICB, 2)
            End If
            ZRICBACUM = ZRICBACUM - ZICB
            
            'If ZRICBACUM < 0 Then GestionMB += ZRICBACUM

            'calcular la retencion para el Fondo de Gastos

            If (GestionMB > 0) Then
                ZMRF = System.Math.Round((GestionMB * ThisBanko("PRFG")) / 100, 2)
            Else
                ZMRF = 0
            End If
            If rstACUM.Count > 0 Then
                ZMRFACUM = System.Math.Round(ZMRF + rstACUM(0)("ZMRFACUM"), 2)
            Else
                ZMRFACUM = System.Math.Round(ZMRF, 2)
            End If

            'Calcular el Balance de Gestion Mensual Neto
            ZGestionMNeto = System.Math.Round(((GestionMB - ZRICB) - ZMRF) - ZPRFP, 2)
            If (CDbl(mes) <> 1) Then
                If rstACUM.Count > 0 Then
                    ZGestionMNetoACUM = System.Math.Round(ZGestionMNeto + rstACUM(0)("ZGestionMNetoACUM"), 2)
                Else
                    ZGestionMNetoACUM = System.Math.Round(ZGestionMNeto, 2)
                End If
            Else
                If rstACUM.Count > 0 Then
                    ZGestionMNetoACUM = System.Math.Round((rstACUM(0)("ZGestionMNetoACUM") - rstACUM(0)("ZURACUM")) + ZGestionMNeto, 2)
                Else
                    ZGestionMNetoACUM = System.Math.Round(ZGestionMNeto, 2)
                End If
            End If

            'Calcular el total de Ganancias no Repartidas ZMONTOGNORep
            'If (CDbl(mes) <> 1) Then
            ZMONTOGNORep = System.Math.Round(ZGestionMNetoACUM - ZURACUM, 2)
            'Else
            '   ZMONTOGNORep = System.Math.Round(ZGestionMNetoACUM, 2)
            'End If
            'Rendimiento estimado de CAPS
            RESTCAPS = System.Math.Round(ZGestionMNeto / NTCA, 2)

            'Calcular el total de Ingreso al Fondo de Gastos IFG1
            rstLibro.Table = MainDSO.Tables("TblLibroIE")
            ZIFG1 = GetZOPE(FechaPrimero, FechaUltimo, "IFG1", True, False)
            ZIFG1 = Math.Round(ZIFG1 + ZMRF + ZDO1 + ZPRFP, 2)
            If rstACUM.Count > 0 Then
                ZIFG1ACUM = System.Math.Round(ZIFG1 + rstACUM(0)("ZIFG1ACUM"), 2)
            Else
                ZIFG1ACUM = System.Math.Round(ZIFG1, 2)
            End If

            'Calcular el total de Gastos del Bankomunal
            ZGBK1 = GetZOPE(FechaPrimero, FechaUltimo, "GBK1", False, False)
            If rstACUM.Count > 0 Then
                ZGBK1ACUM = System.Math.Round(ZGBK1 + rstACUM(0)("ZGBK1ACUM"), 2)
            Else
                ZGBK1ACUM = System.Math.Round(ZGBK1, 2)
            End If


            'Calcular el Saldo Actual del Fondo para Gastos
            safgastos = System.Math.Round(ZIFG1ACUM - ZGBK1ACUM, 2)
            If (safgastos < 0) Then
                safgastos = 0
            End If


            'Calcular el total disponible de Efectivo
            rstLibro.RowFilter = "Anulado=0 AND IdBK='" & codi & "' AND Fecha >=#" & FechaPrimero.ToString("yyyy-MM-dd") & "# AND Fecha <=#" & FechaUltimo.ToString("yyyy-MM-dd") & "#"
            rstLibro.Sort = "Fecha,NoRecibo,IdReg"
            If rstLibro.Count > 0 Then
                DECIERRE = System.Math.Round(rstLibro(rstLibro.Count - 1)("Saldo"), 2)
            Else
                DECIERRE = rstACUM(0)("DECIERRE")
            End If

            If ZRICBACUM < 0 Then
                GestionMB += ZRICBACUM
                GestionMBACUM += ZRICBACUM
                ZGestionMNeto += ZRICBACUM
                ZGestionMNetoACUM += ZRICBACUM
                ZRICBACUM = 0
            End If
            rstLibro.Sort = "Fecha"

            f2 = valnominal
            Dim pasivo As Double
            Dim capital As Double
            Dim activo As Double
            Dim utilidades As Double
            pasivo = MTCPAGAR
            capital = (ZVCACUM - ZLCACUM) * valnominal + ZDO1ACUM + ZDO2ACUM
            utilidades = ZGestionMNetoACUM + safgastos - ZURACUM
            activo = DECIERRE + MPRECUP - ZRICBACUM + ZBAACUM
            f1 = System.Math.Round(pasivo + capital + utilidades - activo)
            If (f1 = 0) Then
                gest = 1 'Si balance cuadra entonces gest = 1
            Else
                gest = 0
            End If
            '######################
            'gest = 0
            FCorte = rstLibro(rstLibro.Count - 1)("Fecha")
            '###############################################################################
            'Guarda la Gestion Generada en la tabla Gestion 
            MainDSO.Tables("gestiontemp").Rows.Clear()
            rstGestemp = MainDSO.Tables("gestiontemp").NewRow
            rstGestemp("CodBk") = codi
            rstGestemp("Finicio") = SQLDate(Finicio)
            rstGestemp("FCorte") = SQLDate(FCorte)
            rstGestemp("NTSM") = NTSM
            rstGestemp("NTSF") = NTSF
            rstGestemp("NTSMACUM") = NTSMACUM
            rstGestemp("NTSFACUM") = NTSFACUM
            rstGestemp("NTSMR") = NTSMR
            rstGestemp("NTSFR") = NTSFR
            rstGestemp("NTSMRACUM") = NTSMRACUM
            rstGestemp("NTSFRACUM") = NTSFRACUM
            rstGestemp("ZVC") = ZVC
            rstGestemp("ZVCACUM") = ZVCACUM
            rstGestemp("ZLC") = ZLC
            rstGestemp("ZLCACUM") = ZLCACUM
            rstGestemp("ZCON") = ZCON
            rstGestemp("ZCONACUM") = ZCONACUM
            rstGestemp("qCON") = qCON
            rstGestemp("qCONACUM") = qCONACUM
            rstGestemp("ZCOR") = ZCOR
            rstGestemp("ZCORACUM") = ZCORACUM
            rstGestemp("qCOR") = qCOR
            rstGestemp("qCORACUM") = qCORACUM
            rstGestemp("ZOR") = ZOR
            rstGestemp("ZORACUM") = ZORACUM
            rstGestemp("ZMO") = ZMO
            rstGestemp("ZMOACUM") = ZMOACUM
            rstGestemp("ZOI") = ZOI
            rstGestemp("ZOIACUM") = ZOIACUM
            rstGestemp("ZEG") = ZEG
            rstGestemp("ZEGACUM") = ZEGACUM
            rstGestemp("ZBA") = ZBA
            rstGestemp("ZBAACUM") = ZBAACUM
            rstGestemp("ZDO1") = ZDO1
            rstGestemp("ZDO1ACUM") = ZDO1ACUM
            rstGestemp("ZDO2") = ZDO2
            rstGestemp("ZDO2ACUM") = ZDO2ACUM
            rstGestemp("ZICP") = ZICP
            rstGestemp("ZICPACUM") = ZICPACUM
            rstGestemp("ZECP") = ZECP
            rstGestemp("ZECPACUM") = ZECPACUM
            rstGestemp("MTCPAGAR") = MTCPAGAR
            rstGestemp("ZPC") = ZPC
            rstGestemp("ZPCACUM") = ZPCACUM
            rstGestemp("ZICB") = ZICB
            rstGestemp("ZICBACUM") = ZICBACUM
            rstGestemp("MPRECUP") = MPRECUP
            rstGestemp("MPRECUP30") = MPRECUP30
            rstGestemp("MPRECUP60") = MPRECUP60
            rstGestemp("MPRECUP90") = MPRECUP90
            rstGestemp("ZRICB") = ZRICB
            rstGestemp("ZRICBACUM") = ZRICBACUM
            rstGestemp("GestionMB") = GestionMB
            rstGestemp("GestionMBACUM") = GestionMBACUM
            rstGestemp("ZMRF") = ZMRF
            rstGestemp("ZMRFACUM") = ZMRFACUM
            rstGestemp("ZGestionMNeto") = ZGestionMNeto
            rstGestemp("ZGestionMNetoACUM") = ZGestionMNetoACUM
            rstGestemp("ZMONTOGNORep") = ZMONTOGNORep
            rstGestemp("RESTCAPS") = RESTCAPS
            rstGestemp("ZIFG1") = ZIFG1
            rstGestemp("ZIFG1ACUM") = ZIFG1ACUM
            rstGestemp("ZGBK1") = ZGBK1
            rstGestemp("ZGBK1ACUM") = ZGBK1ACUM
            rstGestemp("SAFGASTOS") = safgastos
            rstGestemp("DECIERRE") = DECIERRE
            rstGestemp("ZUR") = ZUR
            rstGestemp("ZURACUM") = ZURACUM
            rstGestemp("idgestion") = 1
            ThisBanko("SAFGASTOS") = safgastos - ZMRF - ZPRFP
            MainDSO.Tables("gestiontemp").Rows.Add(rstGestemp)
            If Not MovAcum Then
                '###############################################################################
                'Muestra el reporte de Gestion y el Balance
                Dim rpt As New RptGestion
                rpt.CFecha = FCorte
                rpt.cuadre = True
                rpt.ShowDialog()
                '#############################################################################
                'Muestra el Balance generado por la gestion
                Dim rpt2 As New RptBalance
                rpt2.CFecha = FCorte
                rpt2.cuadre = True
                rpt2.ShowDialog()
                '###############################################################################
            End If
        End If
    End Sub

    Private Sub CFecha_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles CFecha.KeyPress
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

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Calculate()
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Me.Close()
    End Sub

    Private Sub Cuadre_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim rstLibro As New DataView
        Dim Fecha As Date
        rstLibro.Table = MainDSO.Tables("TblLibroIE")
        rstLibro.RowFilter = "IdBK='" & codi & "' AND bloqueo=0 AND Anulado=0"
        rstLibro.Sort = "Fecha ASC"
        If rstLibro.Count > 0 Then
            Fecha = rstLibro(0)("Fecha")
            CFecha.Text = Fecha.ToString("MMMM' de 'yyyy")
        End If
    End Sub
End Class