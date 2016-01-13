<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Menu_Principal
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents BtnProcesar As System.Windows.Forms.Button
    Public WithEvents BtnRptFinancieros As System.Windows.Forms.Button
    Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
    Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents BtnClasifCred As System.Windows.Forms.Button
    Public WithEvents BtnTablas As System.Windows.Forms.Button
    Public WithEvents BtnNewBk As System.Windows.Forms.Button
    Public WithEvents BtnProfiles As System.Windows.Forms.Button
    Public WithEvents BtnBackup As System.Windows.Forms.Button
    Public WithEvents BtnPanelRpt As System.Windows.Forms.Button
    Public WithEvents BtnLibroIE As System.Windows.Forms.Button
    Public WithEvents BtnDatosCreditos As System.Windows.Forms.Button
    Public WithEvents BtnPanelSocios As System.Windows.Forms.Button
    Public WithEvents BtnCuadreCierre As System.Windows.Forms.Button
    Public WithEvents BtnVolver As System.Windows.Forms.Button
    Public WithEvents BtnDatosBanko As System.Windows.Forms.Button
    Public WithEvents LblProcesar As System.Windows.Forms.Label
    Public WithEvents LblRptFinancieros As System.Windows.Forms.Label
    Public WithEvents LblClasifCred As System.Windows.Forms.Label
    Public WithEvents LblTablas As System.Windows.Forms.Label
    Public WithEvents LblNewBk As System.Windows.Forms.Label
    Public WithEvents LblProfiles As System.Windows.Forms.Label
    Public WithEvents LblBackup As System.Windows.Forms.Label
    Public WithEvents LblPanelRpt As System.Windows.Forms.Label
    Public WithEvents LblLibroIE As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents LblDatosCreditos As System.Windows.Forms.Label
    Public WithEvents LblPanelSocios As System.Windows.Forms.Label
    Public WithEvents LblCuadreCierre As System.Windows.Forms.Label
    Public WithEvents LblVolver As System.Windows.Forms.Label
    Public WithEvents LblDatosBanko As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.Panel
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog()
        Me.CommonDialog1Save = New System.Windows.Forms.SaveFileDialog()
        Me.Frame2 = New System.Windows.Forms.Panel()
        Me.LblProcesar = New System.Windows.Forms.Label()
        Me.LblRptFinancieros = New System.Windows.Forms.Label()
        Me.LblClasifCred = New System.Windows.Forms.Label()
        Me.LblTablas = New System.Windows.Forms.Label()
        Me.LblNewBk = New System.Windows.Forms.Label()
        Me.LblProfiles = New System.Windows.Forms.Label()
        Me.LblBackup = New System.Windows.Forms.Label()
        Me.LblPanelRpt = New System.Windows.Forms.Label()
        Me.LblLibroIE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDatosCreditos = New System.Windows.Forms.Label()
        Me.LblPanelSocios = New System.Windows.Forms.Label()
        Me.LblCuadreCierre = New System.Windows.Forms.Label()
        Me.LblVolver = New System.Windows.Forms.Label()
        Me.LblDatosBanko = New System.Windows.Forms.Label()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.BtnRptFinancieros = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnClasifCred = New System.Windows.Forms.Button()
        Me.BtnTablas = New System.Windows.Forms.Button()
        Me.BtnNewBk = New System.Windows.Forms.Button()
        Me.BtnProfiles = New System.Windows.Forms.Button()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.BtnPanelRpt = New System.Windows.Forms.Button()
        Me.BtnLibroIE = New System.Windows.Forms.Button()
        Me.BtnDatosCreditos = New System.Windows.Forms.Button()
        Me.BtnPanelSocios = New System.Windows.Forms.Button()
        Me.BtnCuadreCierre = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnDatosBanko = New System.Windows.Forms.Button()
        Me.Frame2.SuspendLayout()
        Me.Picture1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommonDialog1Open
        '
        Me.CommonDialog1Open.FileName = "BKSistema_datos.mdb"
        '
        'CommonDialog1Save
        '
        Me.CommonDialog1Save.FileName = "BKSistema_datos.mdb"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.BtnClasifCred)
        Me.Frame2.Controls.Add(Me.BtnTablas)
        Me.Frame2.Controls.Add(Me.BtnNewBk)
        Me.Frame2.Controls.Add(Me.BtnProfiles)
        Me.Frame2.Controls.Add(Me.BtnBackup)
        Me.Frame2.Controls.Add(Me.BtnPanelRpt)
        Me.Frame2.Controls.Add(Me.BtnLibroIE)
        Me.Frame2.Controls.Add(Me.BtnDatosCreditos)
        Me.Frame2.Controls.Add(Me.BtnPanelSocios)
        Me.Frame2.Controls.Add(Me.BtnCuadreCierre)
        Me.Frame2.Controls.Add(Me.BtnVolver)
        Me.Frame2.Controls.Add(Me.BtnDatosBanko)
        Me.Frame2.Controls.Add(Me.LblProcesar)
        Me.Frame2.Controls.Add(Me.LblRptFinancieros)
        Me.Frame2.Controls.Add(Me.LblClasifCred)
        Me.Frame2.Controls.Add(Me.LblTablas)
        Me.Frame2.Controls.Add(Me.LblNewBk)
        Me.Frame2.Controls.Add(Me.LblProfiles)
        Me.Frame2.Controls.Add(Me.LblBackup)
        Me.Frame2.Controls.Add(Me.LblPanelRpt)
        Me.Frame2.Controls.Add(Me.LblLibroIE)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Controls.Add(Me.LblDatosCreditos)
        Me.Frame2.Controls.Add(Me.LblPanelSocios)
        Me.Frame2.Controls.Add(Me.LblCuadreCierre)
        Me.Frame2.Controls.Add(Me.LblVolver)
        Me.Frame2.Controls.Add(Me.LblDatosBanko)
        Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(8, 104)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(505, 361)
        Me.Frame2.TabIndex = 7
        '
        'LblProcesar
        '
        Me.LblProcesar.BackColor = System.Drawing.Color.White
        Me.LblProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblProcesar.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblProcesar.Location = New System.Drawing.Point(336, 320)
        Me.LblProcesar.Name = "LblProcesar"
        Me.LblProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblProcesar.Size = New System.Drawing.Size(161, 25)
        Me.LblProcesar.TabIndex = 30
        Me.LblProcesar.Text = "Procesar"
        '
        'LblRptFinancieros
        '
        Me.LblRptFinancieros.BackColor = System.Drawing.Color.White
        Me.LblRptFinancieros.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblRptFinancieros.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRptFinancieros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblRptFinancieros.Location = New System.Drawing.Point(336, 272)
        Me.LblRptFinancieros.Name = "LblRptFinancieros"
        Me.LblRptFinancieros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblRptFinancieros.Size = New System.Drawing.Size(161, 25)
        Me.LblRptFinancieros.TabIndex = 29
        Me.LblRptFinancieros.Text = "Reportes Financieros"
        '
        'LblClasifCred
        '
        Me.LblClasifCred.BackColor = System.Drawing.Color.White
        Me.LblClasifCred.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblClasifCred.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClasifCred.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblClasifCred.Location = New System.Drawing.Point(336, 224)
        Me.LblClasifCred.Name = "LblClasifCred"
        Me.LblClasifCred.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblClasifCred.Size = New System.Drawing.Size(171, 22)
        Me.LblClasifCred.TabIndex = 27
        Me.LblClasifCred.Text = "Tablas"
        '
        'LblTablas
        '
        Me.LblTablas.BackColor = System.Drawing.Color.White
        Me.LblTablas.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTablas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTablas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTablas.Location = New System.Drawing.Point(336, 176)
        Me.LblTablas.Name = "LblTablas"
        Me.LblTablas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblTablas.Size = New System.Drawing.Size(157, 25)
        Me.LblTablas.TabIndex = 25
        Me.LblTablas.Text = "Configuración"
        '
        'LblNewBk
        '
        Me.LblNewBk.BackColor = System.Drawing.Color.White
        Me.LblNewBk.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblNewBk.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewBk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblNewBk.Location = New System.Drawing.Point(336, 128)
        Me.LblNewBk.Name = "LblNewBk"
        Me.LblNewBk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblNewBk.Size = New System.Drawing.Size(157, 25)
        Me.LblNewBk.TabIndex = 23
        Me.LblNewBk.Text = "Crear BK"
        '
        'LblProfiles
        '
        Me.LblProfiles.BackColor = System.Drawing.Color.White
        Me.LblProfiles.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblProfiles.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfiles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblProfiles.Location = New System.Drawing.Point(336, 80)
        Me.LblProfiles.Name = "LblProfiles"
        Me.LblProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblProfiles.Size = New System.Drawing.Size(157, 25)
        Me.LblProfiles.TabIndex = 22
        Me.LblProfiles.Text = "Perfiles"
        '
        'LblBackup
        '
        Me.LblBackup.BackColor = System.Drawing.Color.White
        Me.LblBackup.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblBackup.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblBackup.Location = New System.Drawing.Point(336, 32)
        Me.LblBackup.Name = "LblBackup"
        Me.LblBackup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblBackup.Size = New System.Drawing.Size(157, 25)
        Me.LblBackup.TabIndex = 21
        Me.LblBackup.Text = "Respaldo de Data"
        '
        'LblPanelRpt
        '
        Me.LblPanelRpt.BackColor = System.Drawing.Color.White
        Me.LblPanelRpt.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPanelRpt.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPanelRpt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPanelRpt.Location = New System.Drawing.Point(80, 272)
        Me.LblPanelRpt.Name = "LblPanelRpt"
        Me.LblPanelRpt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPanelRpt.Size = New System.Drawing.Size(137, 41)
        Me.LblPanelRpt.TabIndex = 17
        Me.LblPanelRpt.Text = "Panel Reportes"
        '
        'LblLibroIE
        '
        Me.LblLibroIE.BackColor = System.Drawing.Color.White
        Me.LblLibroIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblLibroIE.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibroIE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblLibroIE.Location = New System.Drawing.Point(80, 80)
        Me.LblLibroIE.Name = "LblLibroIE"
        Me.LblLibroIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblLibroIE.Size = New System.Drawing.Size(209, 25)
        Me.LblLibroIE.TabIndex = 16
        Me.LblLibroIE.Text = "Libro de Ingresos/Egresos"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(72, -16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Datos del Bankomunal "
        '
        'LblDatosCreditos
        '
        Me.LblDatosCreditos.BackColor = System.Drawing.Color.White
        Me.LblDatosCreditos.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblDatosCreditos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosCreditos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDatosCreditos.Location = New System.Drawing.Point(80, 128)
        Me.LblDatosCreditos.Name = "LblDatosCreditos"
        Me.LblDatosCreditos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblDatosCreditos.Size = New System.Drawing.Size(201, 25)
        Me.LblDatosCreditos.TabIndex = 12
        Me.LblDatosCreditos.Text = "Datos de los Créditos"
        '
        'LblPanelSocios
        '
        Me.LblPanelSocios.BackColor = System.Drawing.Color.White
        Me.LblPanelSocios.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPanelSocios.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPanelSocios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPanelSocios.Location = New System.Drawing.Point(80, 176)
        Me.LblPanelSocios.Name = "LblPanelSocios"
        Me.LblPanelSocios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblPanelSocios.Size = New System.Drawing.Size(201, 25)
        Me.LblPanelSocios.TabIndex = 11
        Me.LblPanelSocios.Text = "Panel de Socios"
        '
        'LblCuadreCierre
        '
        Me.LblCuadreCierre.BackColor = System.Drawing.Color.White
        Me.LblCuadreCierre.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCuadreCierre.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCuadreCierre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblCuadreCierre.Location = New System.Drawing.Point(80, 224)
        Me.LblCuadreCierre.Name = "LblCuadreCierre"
        Me.LblCuadreCierre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblCuadreCierre.Size = New System.Drawing.Size(185, 25)
        Me.LblCuadreCierre.TabIndex = 10
        Me.LblCuadreCierre.Text = "Cuadre y Cierre"
        '
        'LblVolver
        '
        Me.LblVolver.BackColor = System.Drawing.Color.White
        Me.LblVolver.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblVolver.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVolver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblVolver.Location = New System.Drawing.Point(80, 320)
        Me.LblVolver.Name = "LblVolver"
        Me.LblVolver.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblVolver.Size = New System.Drawing.Size(161, 41)
        Me.LblVolver.TabIndex = 9
        Me.LblVolver.Text = "Volver al  Inicio"
        '
        'LblDatosBanko
        '
        Me.LblDatosBanko.BackColor = System.Drawing.Color.White
        Me.LblDatosBanko.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblDatosBanko.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatosBanko.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblDatosBanko.Location = New System.Drawing.Point(80, 32)
        Me.LblDatosBanko.Name = "LblDatosBanko"
        Me.LblDatosBanko.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblDatosBanko.Size = New System.Drawing.Size(177, 25)
        Me.LblDatosBanko.TabIndex = 8
        Me.LblDatosBanko.Text = "Datos del Bankomunal"
        '
        'BtnProcesar
        '
        Me.BtnProcesar.BackColor = System.Drawing.Color.White
        Me.BtnProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnProcesar.Image = CType(resources.GetObject("BtnProcesar.Image"), System.Drawing.Image)
        Me.BtnProcesar.Location = New System.Drawing.Point(288, 416)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnProcesar.Size = New System.Drawing.Size(41, 41)
        Me.BtnProcesar.TabIndex = 31
        Me.BtnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProcesar.UseVisualStyleBackColor = False
        '
        'BtnRptFinancieros
        '
        Me.BtnRptFinancieros.BackColor = System.Drawing.Color.White
        Me.BtnRptFinancieros.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnRptFinancieros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRptFinancieros.Image = CType(resources.GetObject("BtnRptFinancieros.Image"), System.Drawing.Image)
        Me.BtnRptFinancieros.Location = New System.Drawing.Point(288, 368)
        Me.BtnRptFinancieros.Name = "BtnRptFinancieros"
        Me.BtnRptFinancieros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRptFinancieros.Size = New System.Drawing.Size(41, 41)
        Me.BtnRptFinancieros.TabIndex = 28
        Me.BtnRptFinancieros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRptFinancieros.UseVisualStyleBackColor = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me.Button1)
        Me.Picture1.Controls.Add(Me.Label14)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(-32, 0)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(537, 97)
        Me.Picture1.TabIndex = 14
        Me.Picture1.TabStop = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(446, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(221, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(310, 41)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "::: Menu Principal"
        '
        'BtnClasifCred
        '
        Me.BtnClasifCred.BackColor = System.Drawing.Color.White
        Me.BtnClasifCred.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnClasifCred.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClasifCred.Image = CType(resources.GetObject("BtnClasifCred.Image"), System.Drawing.Image)
        Me.BtnClasifCred.Location = New System.Drawing.Point(280, 216)
        Me.BtnClasifCred.Name = "BtnClasifCred"
        Me.BtnClasifCred.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnClasifCred.Size = New System.Drawing.Size(41, 41)
        Me.BtnClasifCred.TabIndex = 26
        Me.BtnClasifCred.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClasifCred.UseVisualStyleBackColor = False
        '
        'BtnTablas
        '
        Me.BtnTablas.BackColor = System.Drawing.Color.White
        Me.BtnTablas.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnTablas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnTablas.Image = CType(resources.GetObject("BtnTablas.Image"), System.Drawing.Image)
        Me.BtnTablas.Location = New System.Drawing.Point(280, 168)
        Me.BtnTablas.Name = "BtnTablas"
        Me.BtnTablas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnTablas.Size = New System.Drawing.Size(41, 41)
        Me.BtnTablas.TabIndex = 24
        Me.BtnTablas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTablas.UseVisualStyleBackColor = False
        '
        'BtnNewBk
        '
        Me.BtnNewBk.BackColor = System.Drawing.Color.White
        Me.BtnNewBk.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnNewBk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnNewBk.Image = CType(resources.GetObject("BtnNewBk.Image"), System.Drawing.Image)
        Me.BtnNewBk.Location = New System.Drawing.Point(280, 120)
        Me.BtnNewBk.Name = "BtnNewBk"
        Me.BtnNewBk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNewBk.Size = New System.Drawing.Size(41, 41)
        Me.BtnNewBk.TabIndex = 20
        Me.BtnNewBk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNewBk.UseVisualStyleBackColor = False
        '
        'BtnProfiles
        '
        Me.BtnProfiles.BackColor = System.Drawing.Color.White
        Me.BtnProfiles.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnProfiles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnProfiles.Image = CType(resources.GetObject("BtnProfiles.Image"), System.Drawing.Image)
        Me.BtnProfiles.Location = New System.Drawing.Point(280, 72)
        Me.BtnProfiles.Name = "BtnProfiles"
        Me.BtnProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnProfiles.Size = New System.Drawing.Size(41, 41)
        Me.BtnProfiles.TabIndex = 19
        Me.BtnProfiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProfiles.UseVisualStyleBackColor = False
        '
        'BtnBackup
        '
        Me.BtnBackup.BackColor = System.Drawing.Color.White
        Me.BtnBackup.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnBackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBackup.Image = CType(resources.GetObject("BtnBackup.Image"), System.Drawing.Image)
        Me.BtnBackup.Location = New System.Drawing.Point(280, 24)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBackup.Size = New System.Drawing.Size(41, 41)
        Me.BtnBackup.TabIndex = 18
        Me.BtnBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBackup.UseVisualStyleBackColor = False
        '
        'BtnPanelRpt
        '
        Me.BtnPanelRpt.BackColor = System.Drawing.Color.White
        Me.BtnPanelRpt.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnPanelRpt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPanelRpt.Image = CType(resources.GetObject("BtnPanelRpt.Image"), System.Drawing.Image)
        Me.BtnPanelRpt.Location = New System.Drawing.Point(24, 264)
        Me.BtnPanelRpt.Name = "BtnPanelRpt"
        Me.BtnPanelRpt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPanelRpt.Size = New System.Drawing.Size(41, 41)
        Me.BtnPanelRpt.TabIndex = 5
        Me.BtnPanelRpt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPanelRpt.UseVisualStyleBackColor = False
        '
        'BtnLibroIE
        '
        Me.BtnLibroIE.BackColor = System.Drawing.Color.White
        Me.BtnLibroIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnLibroIE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLibroIE.Image = CType(resources.GetObject("BtnLibroIE.Image"), System.Drawing.Image)
        Me.BtnLibroIE.Location = New System.Drawing.Point(24, 72)
        Me.BtnLibroIE.Name = "BtnLibroIE"
        Me.BtnLibroIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLibroIE.Size = New System.Drawing.Size(41, 41)
        Me.BtnLibroIE.TabIndex = 1
        Me.BtnLibroIE.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLibroIE.UseVisualStyleBackColor = False
        '
        'BtnDatosCreditos
        '
        Me.BtnDatosCreditos.BackColor = System.Drawing.Color.White
        Me.BtnDatosCreditos.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnDatosCreditos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnDatosCreditos.Image = CType(resources.GetObject("BtnDatosCreditos.Image"), System.Drawing.Image)
        Me.BtnDatosCreditos.Location = New System.Drawing.Point(24, 120)
        Me.BtnDatosCreditos.Name = "BtnDatosCreditos"
        Me.BtnDatosCreditos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDatosCreditos.Size = New System.Drawing.Size(41, 41)
        Me.BtnDatosCreditos.TabIndex = 2
        Me.BtnDatosCreditos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDatosCreditos.UseVisualStyleBackColor = False
        '
        'BtnPanelSocios
        '
        Me.BtnPanelSocios.BackColor = System.Drawing.Color.White
        Me.BtnPanelSocios.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnPanelSocios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPanelSocios.Image = CType(resources.GetObject("BtnPanelSocios.Image"), System.Drawing.Image)
        Me.BtnPanelSocios.Location = New System.Drawing.Point(24, 168)
        Me.BtnPanelSocios.Name = "BtnPanelSocios"
        Me.BtnPanelSocios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPanelSocios.Size = New System.Drawing.Size(41, 41)
        Me.BtnPanelSocios.TabIndex = 3
        Me.BtnPanelSocios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPanelSocios.UseVisualStyleBackColor = False
        '
        'BtnCuadreCierre
        '
        Me.BtnCuadreCierre.BackColor = System.Drawing.Color.White
        Me.BtnCuadreCierre.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCuadreCierre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCuadreCierre.Image = CType(resources.GetObject("BtnCuadreCierre.Image"), System.Drawing.Image)
        Me.BtnCuadreCierre.Location = New System.Drawing.Point(24, 216)
        Me.BtnCuadreCierre.Name = "BtnCuadreCierre"
        Me.BtnCuadreCierre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCuadreCierre.Size = New System.Drawing.Size(41, 41)
        Me.BtnCuadreCierre.TabIndex = 4
        Me.BtnCuadreCierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCuadreCierre.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.White
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnVolver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnVolver.Image = CType(resources.GetObject("BtnVolver.Image"), System.Drawing.Image)
        Me.BtnVolver.Location = New System.Drawing.Point(24, 312)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnVolver.Size = New System.Drawing.Size(41, 41)
        Me.BtnVolver.TabIndex = 6
        Me.BtnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnDatosBanko
        '
        Me.BtnDatosBanko.BackColor = System.Drawing.Color.White
        Me.BtnDatosBanko.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnDatosBanko.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnDatosBanko.Image = CType(resources.GetObject("BtnDatosBanko.Image"), System.Drawing.Image)
        Me.BtnDatosBanko.Location = New System.Drawing.Point(24, 24)
        Me.BtnDatosBanko.Name = "BtnDatosBanko"
        Me.BtnDatosBanko.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDatosBanko.Size = New System.Drawing.Size(41, 41)
        Me.BtnDatosBanko.TabIndex = 0
        Me.BtnDatosBanko.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDatosBanko.UseVisualStyleBackColor = False
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(525, 473)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.BtnRptFinancieros)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(255, 166)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Principal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Frame2.ResumeLayout(False)
        Me.Picture1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
#End Region
End Class