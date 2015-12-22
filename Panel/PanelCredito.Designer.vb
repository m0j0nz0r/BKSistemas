<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class PanelCredito
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
	Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents DataGrid1 As DataGridView
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents TIntMora As System.Windows.Forms.TextBox
	Public WithEvents TIntOrd As System.Windows.Forms.TextBox
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents TNombre As System.Windows.Forms.TextBox
	Public WithEvents TCedula As System.Windows.Forms.TextBox
	Public WithEvents TMonto As System.Windows.Forms.TextBox
	Public WithEvents TVencimiento As System.Windows.Forms.TextBox
	Public WithEvents TClase As System.Windows.Forms.TextBox
	Public WithEvents TSaldo As System.Windows.Forms.TextBox
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents CCedula As System.Windows.Forms.ComboBox
	Public WithEvents status As System.Windows.Forms.CheckBox
	Public WithEvents CCredito As System.Windows.Forms.ComboBox
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelCredito))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.TIntMora = New System.Windows.Forms.TextBox()
        Me.TIntOrd = New System.Windows.Forms.TextBox()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TCedula = New System.Windows.Forms.TextBox()
        Me.TMonto = New System.Windows.Forms.TextBox()
        Me.TVencimiento = New System.Windows.Forms.TextBox()
        Me.TClase = New System.Windows.Forms.TextBox()
        Me.TSaldo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.CCedula = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.CheckBox()
        Me.CCredito = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Frame4.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Picture1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.Color.White
        Me.Frame4.Controls.Add(Me.Command1)
        Me.Frame4.Controls.Add(Me.DataGrid1)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(8, 392)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(601, 129)
        Me.Frame4.TabIndex = 22
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "::: Movimientos del Credito :::"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(464, 80)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(113, 33)
        Me.Command1.TabIndex = 4
        Me.Command1.Text = "Cerrar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToAddRows = False
        Me.DataGrid1.AllowUserToDeleteRows = False
        Me.DataGrid1.Location = New System.Drawing.Point(16, 24)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(433, 89)
        Me.DataGrid1.TabIndex = 23
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.White
        Me.Frame3.Controls.Add(Me.TIntMora)
        Me.Frame3.Controls.Add(Me.TIntOrd)
        Me.Frame3.Controls.Add(Me.Frame5)
        Me.Frame3.Controls.Add(Me.TNombre)
        Me.Frame3.Controls.Add(Me.TCedula)
        Me.Frame3.Controls.Add(Me.TMonto)
        Me.Frame3.Controls.Add(Me.TVencimiento)
        Me.Frame3.Controls.Add(Me.TClase)
        Me.Frame3.Controls.Add(Me.TSaldo)
        Me.Frame3.Controls.Add(Me.Label19)
        Me.Frame3.Controls.Add(Me.Label18)
        Me.Frame3.Controls.Add(Me.Label2)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Controls.Add(Me.Label5)
        Me.Frame3.Controls.Add(Me.Label6)
        Me.Frame3.Controls.Add(Me.Label7)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(8, 168)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(601, 225)
        Me.Frame3.TabIndex = 8
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "::: Datos del Credito :::"
        '
        'TIntMora
        '
        Me.TIntMora.AcceptsReturn = True
        Me.TIntMora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TIntMora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TIntMora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TIntMora.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TIntMora.Location = New System.Drawing.Point(112, 192)
        Me.TIntMora.MaxLength = 0
        Me.TIntMora.Name = "TIntMora"
        Me.TIntMora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TIntMora.Size = New System.Drawing.Size(194, 13)
        Me.TIntMora.TabIndex = 36
        '
        'TIntOrd
        '
        Me.TIntOrd.AcceptsReturn = True
        Me.TIntOrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TIntOrd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TIntOrd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TIntOrd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TIntOrd.Location = New System.Drawing.Point(112, 168)
        Me.TIntOrd.MaxLength = 0
        Me.TIntOrd.Name = "TIntOrd"
        Me.TIntOrd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TIntOrd.Size = New System.Drawing.Size(193, 13)
        Me.TIntOrd.TabIndex = 34
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.White
        Me.Frame5.Controls.Add(Me.Label21)
        Me.Frame5.Controls.Add(Me.Label20)
        Me.Frame5.Controls.Add(Me.Label17)
        Me.Frame5.Controls.Add(Me.Label16)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.Controls.Add(Me.Label13)
        Me.Frame5.Controls.Add(Me.Label12)
        Me.Frame5.Controls.Add(Me.Label11)
        Me.Frame5.Controls.Add(Me.Label10)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(320, 16)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(265, 193)
        Me.Frame5.TabIndex = 15
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "::: Datos del Fiador :::"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(249, 17)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Label21"
        Me.Label21.Visible = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(8, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(241, 17)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Label20"
        Me.Label20.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(249, 17)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Label17"
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(249, 17)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Label16"
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(233, 17)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Label15"
        Me.Label15.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(8, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(233, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Label13"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(233, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Label12"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(233, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Label11"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(233, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Label10"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(233, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Label9"
        Me.Label9.Visible = False
        '
        'TNombre
        '
        Me.TNombre.AcceptsReturn = True
        Me.TNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TNombre.Location = New System.Drawing.Point(112, 24)
        Me.TNombre.MaxLength = 0
        Me.TNombre.Name = "TNombre"
        Me.TNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TNombre.Size = New System.Drawing.Size(193, 13)
        Me.TNombre.TabIndex = 14
        '
        'TCedula
        '
        Me.TCedula.AcceptsReturn = True
        Me.TCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCedula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TCedula.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TCedula.Location = New System.Drawing.Point(112, 48)
        Me.TCedula.MaxLength = 0
        Me.TCedula.Name = "TCedula"
        Me.TCedula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TCedula.Size = New System.Drawing.Size(193, 13)
        Me.TCedula.TabIndex = 13
        '
        'TMonto
        '
        Me.TMonto.AcceptsReturn = True
        Me.TMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TMonto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TMonto.Location = New System.Drawing.Point(112, 72)
        Me.TMonto.MaxLength = 0
        Me.TMonto.Name = "TMonto"
        Me.TMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TMonto.Size = New System.Drawing.Size(193, 13)
        Me.TMonto.TabIndex = 12
        '
        'TVencimiento
        '
        Me.TVencimiento.AcceptsReturn = True
        Me.TVencimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVencimiento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TVencimiento.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TVencimiento.Location = New System.Drawing.Point(112, 96)
        Me.TVencimiento.MaxLength = 0
        Me.TVencimiento.Name = "TVencimiento"
        Me.TVencimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TVencimiento.Size = New System.Drawing.Size(193, 13)
        Me.TVencimiento.TabIndex = 11
        '
        'TClase
        '
        Me.TClase.AcceptsReturn = True
        Me.TClase.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TClase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TClase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TClase.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TClase.Location = New System.Drawing.Point(112, 120)
        Me.TClase.MaxLength = 0
        Me.TClase.Name = "TClase"
        Me.TClase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TClase.Size = New System.Drawing.Size(193, 13)
        Me.TClase.TabIndex = 10
        '
        'TSaldo
        '
        Me.TSaldo.AcceptsReturn = True
        Me.TSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TSaldo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TSaldo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TSaldo.Location = New System.Drawing.Point(112, 144)
        Me.TSaldo.MaxLength = 0
        Me.TSaldo.Name = "TSaldo"
        Me.TSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TSaldo.Size = New System.Drawing.Size(193, 13)
        Me.TSaldo.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(16, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(89, 17)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Int. Mora.:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(16, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(73, 17)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Int. Ord.:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nº Cedula:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Monto Otorg:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Vencimiento:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Riesgo:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(113, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Saldo:"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.CCedula)
        Me.Frame2.Controls.Add(Me.status)
        Me.Frame2.Controls.Add(Me.CCredito)
        Me.Frame2.Controls.Add(Me.Label22)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 64)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(601, 105)
        Me.Frame2.TabIndex = 6
        Me.Frame2.TabStop = False
        '
        'CCedula
        '
        Me.CCedula.BackColor = System.Drawing.SystemColors.Window
        Me.CCedula.Cursor = System.Windows.Forms.Cursors.Default
        Me.CCedula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCedula.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CCedula.Location = New System.Drawing.Point(152, 64)
        Me.CCedula.Name = "CCedula"
        Me.CCedula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CCedula.Size = New System.Drawing.Size(241, 24)
        Me.CCedula.TabIndex = 1
        '
        'status
        '
        Me.status.BackColor = System.Drawing.Color.White
        Me.status.Cursor = System.Windows.Forms.Cursors.Default
        Me.status.ForeColor = System.Drawing.SystemColors.ControlText
        Me.status.Location = New System.Drawing.Point(416, 32)
        Me.status.Name = "status"
        Me.status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.status.Size = New System.Drawing.Size(17, 17)
        Me.status.TabIndex = 3
        Me.status.Text = "Check1"
        Me.status.UseVisualStyleBackColor = False
        '
        'CCredito
        '
        Me.CCredito.BackColor = System.Drawing.SystemColors.Window
        Me.CCredito.Cursor = System.Windows.Forms.Cursors.Default
        Me.CCredito.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCredito.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CCredito.Location = New System.Drawing.Point(152, 32)
        Me.CCredito.Name = "CCredito"
        Me.CCredito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CCredito.Size = New System.Drawing.Size(241, 24)
        Me.CCredito.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(32, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(129, 17)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Nº de Cedula:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(440, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(121, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Creditos Pagados"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nº del Crédito:"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me.Label14)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(0, -40)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(633, 97)
        Me.Picture1.TabIndex = 2
        Me.Picture1.TabStop = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(272, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(331, 41)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "::: Datos de Creditos"
        '
        'PanelCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(617, 524)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Picture1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(162, 93)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PanelCredito"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema :::"
        Me.Frame4.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame5.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Picture1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class