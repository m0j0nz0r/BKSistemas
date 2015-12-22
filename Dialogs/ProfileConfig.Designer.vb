<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guardar")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos del Bankomunal", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Venta de Acciones")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Liquidación de Acciones")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ganancias Repartidas")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Retiro de Socios")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Acciones", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Intereses Ordinarios")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Intereses de Mora")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reintegro de Intereses")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pago de Cuotas")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Otorgamiento de Creditos")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pago de Deuda Pendiente")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Refinanciamiento")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Creditos", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Otros Ingresos")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Otros Egresos")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Otros I/E", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ingreso al Fondo")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gastos del Bankomunal")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fondo de Gastos", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Donaciones")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bienes Adquiridos")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Otras Operaciones", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Libro de Ingresos/Egresos", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode15, TreeNode18, TreeNode21, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos de los Créditos")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Movimientos")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guardar")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos de los Socios", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nuevo")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guardar")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Datos de los Protegidos", New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Panel de Socios", New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cuadre")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cierre")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deshacer Último Cierre")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cuadre y Cierre", New System.Windows.Forms.TreeNode() {TreeNode34, TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Socios Activos")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte de Gestión")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Balance General")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte de Fiadores")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saldos de Creditos Vencidos")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saldos de Creditos Vigentes")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Libro de Ingresos y Egresos")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rendimiento de Acciones")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Socios Fondo Protección")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Panel de Reportes", New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode43, TreeNode44, TreeNode45, TreeNode46})
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Volver al Inicio")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Respaldo de Data")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Perfiles")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crear Bk")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Proyectos")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Paises")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estados")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Municipios")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Usuarios")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tipos de Crédito")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clases de Crédito")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clasificación de Créditos")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Configuración", New System.Windows.Forms.TreeNode() {TreeNode52, TreeNode53, TreeNode54, TreeNode55, TreeNode56, TreeNode57, TreeNode58, TreeNode59})
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clase de Creditos")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clasificación de Creditos x Tipo")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clasificación de Creditos x Clase")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Movimiento Acumulado")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte Consolidado")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reportes Financieros", New System.Windows.Forms.TreeNode() {TreeNode62, TreeNode63, TreeNode64, TreeNode65})
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Procesar")
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menú Principal", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode25, TreeNode26, TreeNode33, TreeNode37, TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode60, TreeNode61, TreeNode66, TreeNode67})
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New BkSistema.MainDS()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ckForceSelect = New System.Windows.Forms.CheckBox()
        Me.lblFilterStatus = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TblProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(422, 479)
        Me.SplitContainer1.SplitterDistance = 30
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Image = Global.BkSistema.My.Resources.Resources.plus
        Me.Button1.Location = New System.Drawing.Point(140, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblProfilesBindingSource
        Me.ComboBox1.DisplayMember = "Perfil"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "ID"
        '
        'TblProfilesBindingSource
        '
        Me.TblProfilesBindingSource.DataMember = "TblProfiles"
        Me.TblProfilesBindingSource.DataSource = Me.MainDS
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "MainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ckForceSelect)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblFilterStatus)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblFilter)
        Me.SplitContainer2.Size = New System.Drawing.Size(422, 445)
        Me.SplitContainer2.SplitterDistance = 248
        Me.SplitContainer2.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "DatosBankoGuardar"
        TreeNode1.Text = "Guardar"
        TreeNode2.Name = "DatosBanko"
        TreeNode2.Text = "Datos del Bankomunal"
        TreeNode3.Name = "LibroIEAccionesVenta"
        TreeNode3.Text = "Venta de Acciones"
        TreeNode4.Name = "LibroIEAccionesLiq"
        TreeNode4.Text = "Liquidación de Acciones"
        TreeNode5.Name = "LibroIEAccionesGanancias"
        TreeNode5.Text = "Ganancias Repartidas"
        TreeNode6.Name = "LibroIEAccionesRetiro"
        TreeNode6.Text = "Retiro de Socios"
        TreeNode7.Name = "LibroIEAcciones"
        TreeNode7.Text = "Acciones"
        TreeNode8.Name = "LibroIECreditosIntOrd"
        TreeNode8.Text = "Intereses Ordinarios"
        TreeNode9.Name = "LibroIECreditosIntMora"
        TreeNode9.Text = "Intereses de Mora"
        TreeNode10.Name = "LibroIECreditosReintegro"
        TreeNode10.Text = "Reintegro de Intereses"
        TreeNode11.Name = "LibroIECreditosPagoCuota"
        TreeNode11.Text = "Pago de Cuotas"
        TreeNode12.Name = "LibroIECreditosOtorgamiento"
        TreeNode12.Text = "Otorgamiento de Creditos"
        TreeNode13.Name = "LibroIECreditosPagoDeuda"
        TreeNode13.Text = "Pago de Deuda Pendiente"
        TreeNode14.Name = "LibroIECreditosRefinanciamiento"
        TreeNode14.Text = "Refinanciamiento"
        TreeNode15.Name = "LibroIECreditos"
        TreeNode15.Text = "Creditos"
        TreeNode16.Name = "LibroIEOtrosIEIngresos"
        TreeNode16.Text = "Otros Ingresos"
        TreeNode17.Name = "LibroIEOtrosIEEgresos"
        TreeNode17.Text = "Otros Egresos"
        TreeNode18.Name = "LibroIEOtrosIE"
        TreeNode18.Text = "Otros I/E"
        TreeNode19.Name = "LibroIEFondoIngreso"
        TreeNode19.Text = "Ingreso al Fondo"
        TreeNode20.Name = "LibroIEFondoGasto"
        TreeNode20.Text = "Gastos del Bankomunal"
        TreeNode21.Name = "LibroIEFondo"
        TreeNode21.Text = "Fondo de Gastos"
        TreeNode22.Name = "LibroIEOtrasOpDonaciones"
        TreeNode22.Text = "Donaciones"
        TreeNode23.Name = "LibroIEOtrasOpBienes"
        TreeNode23.Text = "Bienes Adquiridos"
        TreeNode24.Name = "LibroIEOtrasOp"
        TreeNode24.Text = "Otras Operaciones"
        TreeNode25.Name = "LibroIE"
        TreeNode25.Text = "Libro de Ingresos/Egresos"
        TreeNode26.Name = "DatosCreditos"
        TreeNode26.Text = "Datos de los Créditos"
        TreeNode27.Name = "PanelSociosSociosMovimientos"
        TreeNode27.Text = "Movimientos"
        TreeNode28.Name = "PanelSociosSociosGuardar"
        TreeNode28.Text = "Guardar"
        TreeNode29.Name = "PanelSociosSocios"
        TreeNode29.Text = "Datos de los Socios"
        TreeNode30.Name = "PanelSociosProtegidosNuevo"
        TreeNode30.Text = "Nuevo"
        TreeNode31.Name = "PanelSociosProtegidosGuardar"
        TreeNode31.Text = "Guardar"
        TreeNode32.Name = "PanelSociosProtegidos"
        TreeNode32.Text = "Datos de los Protegidos"
        TreeNode33.Name = "PanelSocios"
        TreeNode33.Text = "Panel de Socios"
        TreeNode34.Name = "CuadreCierreCuadre"
        TreeNode34.Text = "Cuadre"
        TreeNode35.Name = "CuadreCierreCierre"
        TreeNode35.Text = "Cierre"
        TreeNode36.Name = "CuadreCierreUndo"
        TreeNode36.Text = "Deshacer Último Cierre"
        TreeNode37.Name = "CuadreCierre"
        TreeNode37.Text = "Cuadre y Cierre"
        TreeNode38.Name = "PanelReportesSociosActivos"
        TreeNode38.Text = "Socios Activos"
        TreeNode39.Name = "PanelReportesGestion"
        TreeNode39.Text = "Reporte de Gestión"
        TreeNode40.Name = "PanelReportesBalance"
        TreeNode40.Text = "Balance General"
        TreeNode41.Name = "PanelReportesFiadores"
        TreeNode41.Text = "Reporte de Fiadores"
        TreeNode42.Name = "PanelReportesCreditosVencidos"
        TreeNode42.Text = "Saldos de Creditos Vencidos"
        TreeNode43.Name = "PanelReportesCreditosVigentes"
        TreeNode43.Text = "Saldos de Creditos Vigentes"
        TreeNode44.Name = "PanelReportesLibroIE"
        TreeNode44.Text = "Libro de Ingresos y Egresos"
        TreeNode45.Name = "PanelReportesRendimiento"
        TreeNode45.Text = "Rendimiento de Acciones"
        TreeNode46.Name = "PanelReporteFondoProteccion"
        TreeNode46.Text = "Socios Fondo Protección"
        TreeNode47.Name = "PanelReportes"
        TreeNode47.Text = "Panel de Reportes"
        TreeNode48.Name = "Volver"
        TreeNode48.Text = "Volver al Inicio"
        TreeNode49.Name = "Respaldo"
        TreeNode49.Text = "Respaldo de Data"
        TreeNode50.Name = "Perfiles"
        TreeNode50.Text = "Perfiles"
        TreeNode51.Name = "CrearBk"
        TreeNode51.Text = "Crear Bk"
        TreeNode52.Name = "PanelConfigProyectos"
        TreeNode52.Text = "Proyectos"
        TreeNode53.Name = "PanelConfigPaises"
        TreeNode53.Text = "Paises"
        TreeNode54.Name = "PanelConfigEstados"
        TreeNode54.Text = "Estados"
        TreeNode55.Name = "PanelConfigMunicipios"
        TreeNode55.Text = "Municipios"
        TreeNode56.Name = "PanelConfigUsuarios"
        TreeNode56.Text = "Usuarios"
        TreeNode57.Name = "PanelConfigTipoCredito"
        TreeNode57.Text = "Tipos de Crédito"
        TreeNode58.Name = "PanelConfigClaseCredito"
        TreeNode58.Text = "Clases de Crédito"
        TreeNode59.Name = "PanelConfigClasifCredito"
        TreeNode59.Text = "Clasificación de Créditos"
        TreeNode60.Name = "Tablas"
        TreeNode60.Text = "Configuración"
        TreeNode61.Name = "ClaseCreditos"
        TreeNode61.Text = "Clase de Creditos"
        TreeNode62.Name = "ReportesFinancierosCreditoxTipo"
        TreeNode62.Text = "Clasificación de Creditos x Tipo"
        TreeNode63.Name = "ReportesFinancierosCreditoxClase"
        TreeNode63.Text = "Clasificación de Creditos x Clase"
        TreeNode64.Name = "ReportesFinancierosMovimientoAcumulado"
        TreeNode64.Text = "Movimiento Acumulado"
        TreeNode65.Name = "ReportesFinancierosConsolidado"
        TreeNode65.Text = "Reporte Consolidado"
        TreeNode66.Name = "ReportesFinancieros"
        TreeNode66.Text = "Reportes Financieros"
        TreeNode67.Name = "Procesar"
        TreeNode67.Text = "Procesar"
        TreeNode68.Name = "MenuPrincipal"
        TreeNode68.Text = "Menú Principal"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode68})
        Me.TreeView1.Size = New System.Drawing.Size(248, 445)
        Me.TreeView1.TabIndex = 2
        '
        'ckForceSelect
        '
        Me.ckForceSelect.AutoSize = True
        Me.ckForceSelect.Location = New System.Drawing.Point(14, 28)
        Me.ckForceSelect.Name = "ckForceSelect"
        Me.ckForceSelect.Size = New System.Drawing.Size(144, 17)
        Me.ckForceSelect.TabIndex = 3
        Me.ckForceSelect.Text = "Debe escoger un banko."
        Me.ckForceSelect.UseVisualStyleBackColor = True
        '
        'lblFilterStatus
        '
        Me.lblFilterStatus.AutoSize = True
        Me.lblFilterStatus.Location = New System.Drawing.Point(52, 12)
        Me.lblFilterStatus.Name = "lblFilterStatus"
        Me.lblFilterStatus.Size = New System.Drawing.Size(44, 13)
        Me.lblFilterStatus.TabIndex = 1
        Me.lblFilterStatus.Text = "Sin filtro"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(11, 12)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(35, 13)
        Me.lblFilter.TabIndex = 0
        Me.lblFilter.Text = "Filtro: "
        '
        'ProfileConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 479)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ProfileConfig"
        Me.Text = "ProfileConfig"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TblProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TblProfilesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainDS As BkSistema.MainDS
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents lblFilterStatus As System.Windows.Forms.Label
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents ckForceSelect As System.Windows.Forms.CheckBox
End Class
