<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class CrearBK
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
    Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents TxtVal_cap As System.Windows.Forms.TextBox
    Public WithEvents TxtMoneda As System.Windows.Forms.TextBox
	Public WithEvents txtnombre As System.Windows.Forms.TextBox
	Public WithEvents txtcodigo As System.Windows.Forms.TextBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearBK))
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtmunicipio = New System.Windows.Forms.ComboBox()
        Me.TblMunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New BkSistema.MainDS()
        Me.txtestado = New System.Windows.Forms.ComboBox()
        Me.TblEstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtPais = New System.Windows.Forms.ComboBox()
        Me.TblPaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtVal_cap = New System.Windows.Forms.TextBox()
        Me.TxtMoneda = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Picture1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.TblMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(376, 371)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(105, 33)
        Me.Command2.TabIndex = 19
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(256, 371)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(113, 33)
        Me.Command1.TabIndex = 0
        Me.Command1.Text = "Guardar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me.Label24)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(8, 8)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(473, 97)
        Me.Picture1.TabIndex = 16
        Me.Picture1.TabStop = True
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(224, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(361, 41)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "::: CREAR BK"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.ComboBox1)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.txtmunicipio)
        Me.Frame2.Controls.Add(Me.txtestado)
        Me.Frame2.Controls.Add(Me.TxtPais)
        Me.Frame2.Controls.Add(Me.TxtFecha)
        Me.Frame2.Controls.Add(Me.TxtVal_cap)
        Me.Frame2.Controls.Add(Me.TxtMoneda)
        Me.Frame2.Controls.Add(Me.txtnombre)
        Me.Frame2.Controls.Add(Me.txtcodigo)
        Me.Frame2.Controls.Add(Me.Image1)
        Me.Frame2.Controls.Add(Me.Label11)
        Me.Frame2.Controls.Add(Me.Label10)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(8, 112)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(473, 253)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "::: Datos Generales del Bankomunal :::"
        '
        'txtmunicipio
        '
        Me.txtmunicipio.DataSource = Me.TblMunicipiosBindingSource
        Me.txtmunicipio.DisplayMember = "Municipios"
        Me.txtmunicipio.FormattingEnabled = True
        Me.txtmunicipio.Location = New System.Drawing.Point(139, 200)
        Me.txtmunicipio.Name = "txtmunicipio"
        Me.txtmunicipio.Size = New System.Drawing.Size(142, 21)
        Me.txtmunicipio.TabIndex = 25
        Me.txtmunicipio.ValueMember = "ID"
        '
        'TblMunicipiosBindingSource
        '
        Me.TblMunicipiosBindingSource.DataMember = "TblMunicipios"
        Me.TblMunicipiosBindingSource.DataSource = Me.MainDS
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "MainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtestado
        '
        Me.txtestado.DataSource = Me.TblEstadosBindingSource
        Me.txtestado.DisplayMember = "Nombre"
        Me.txtestado.FormattingEnabled = True
        Me.txtestado.Location = New System.Drawing.Point(139, 176)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(142, 21)
        Me.txtestado.TabIndex = 24
        Me.txtestado.ValueMember = "ID"
        '
        'TblEstadosBindingSource
        '
        Me.TblEstadosBindingSource.DataMember = "TblEstados"
        Me.TblEstadosBindingSource.DataSource = Me.MainDS
        '
        'TxtPais
        '
        Me.TxtPais.DataSource = Me.TblPaisesBindingSource
        Me.TxtPais.DisplayMember = "Nombre"
        Me.TxtPais.FormattingEnabled = True
        Me.TxtPais.Location = New System.Drawing.Point(139, 148)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(142, 21)
        Me.TxtPais.TabIndex = 23
        Me.TxtPais.ValueMember = "ID"
        '
        'TblPaisesBindingSource
        '
        Me.TblPaisesBindingSource.DataMember = "TblPaises"
        Me.TblPaisesBindingSource.DataSource = Me.MainDS
        '
        'TxtFecha
        '
        Me.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFecha.Location = New System.Drawing.Point(139, 103)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(142, 20)
        Me.TxtFecha.TabIndex = 22
        '
        'TxtVal_cap
        '
        Me.TxtVal_cap.AcceptsReturn = True
        Me.TxtVal_cap.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtVal_cap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtVal_cap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtVal_cap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtVal_cap.Location = New System.Drawing.Point(139, 128)
        Me.TxtVal_cap.MaxLength = 0
        Me.TxtVal_cap.Name = "TxtVal_cap"
        Me.TxtVal_cap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtVal_cap.Size = New System.Drawing.Size(142, 13)
        Me.TxtVal_cap.TabIndex = 3
        '
        'TxtMoneda
        '
        Me.TxtMoneda.AcceptsReturn = True
        Me.TxtMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMoneda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMoneda.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtMoneda.Location = New System.Drawing.Point(139, 80)
        Me.TxtMoneda.MaxLength = 0
        Me.TxtMoneda.Name = "TxtMoneda"
        Me.TxtMoneda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMoneda.Size = New System.Drawing.Size(142, 13)
        Me.TxtMoneda.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.AcceptsReturn = True
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtnombre.Location = New System.Drawing.Point(139, 56)
        Me.txtnombre.MaxLength = 0
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtnombre.Size = New System.Drawing.Size(142, 13)
        Me.txtnombre.TabIndex = 1
        '
        'txtcodigo
        '
        Me.txtcodigo.AcceptsReturn = True
        Me.txtcodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcodigo.Location = New System.Drawing.Point(139, 32)
        Me.txtcodigo.MaxLength = 0
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcodigo.Size = New System.Drawing.Size(142, 13)
        Me.txtcodigo.TabIndex = 0
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(328, 72)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(100, 100)
        Me.Image1.TabIndex = 21
        Me.Image1.TabStop = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(24, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(109, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Municipio:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(24, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Estado:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(24, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(109, 25)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Pais:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(24, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Valor de la acción:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(24, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Creacion:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(24, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Moneda:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Codigo:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(24, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(109, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Proyecto:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblProyectosBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(140, 224)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 21)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.ValueMember = "ID"
        '
        'TblProyectosBindingSource
        '
        Me.TblProyectosBindingSource.DataMember = "TblProyectos"
        Me.TblProyectosBindingSource.DataSource = Me.MainDS
        '
        'CrearBK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(493, 408)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "CrearBK"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BKSistema - Crear BK"
        Me.Picture1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.TblMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtmunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents txtestado As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPais As System.Windows.Forms.ComboBox
    Friend WithEvents TblMunicipiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainDS As BkSistema.MainDS
    Friend WithEvents TblEstadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPaisesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TblProyectosBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents Label6 As System.Windows.Forms.Label
#End Region
End Class