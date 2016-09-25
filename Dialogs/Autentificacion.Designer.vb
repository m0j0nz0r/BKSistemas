<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Autentificacion
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
	Public WithEvents bk As System.Windows.Forms.ComboBox
	Public WithEvents clave As System.Windows.Forms.TextBox
	Public WithEvents usuario As System.Windows.Forms.TextBox
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Autentificacion))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.municipio = New System.Windows.Forms.ComboBox()
        Me.TblMunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New BkSistema.MainDS()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.estado = New System.Windows.Forms.ComboBox()
        Me.TblEstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pais = New System.Windows.Forms.ComboBox()
        Me.TblPaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bk = New System.Windows.Forms.ComboBox()
        Me.clave = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        CType(Me.TblMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Picture1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.municipio)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.estado)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.pais)
        Me.Frame1.Controls.Add(Me.bk)
        Me.Frame1.Controls.Add(Me.clave)
        Me.Frame1.Controls.Add(Me.usuario)
        Me.Frame1.Controls.Add(Me.Image1)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 80)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(459, 204)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(17, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Municipio:"
        '
        'municipio
        '
        Me.municipio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.municipio.Cursor = System.Windows.Forms.Cursors.Default
        Me.municipio.DataSource = Me.TblMunicipiosBindingSource
        Me.municipio.DisplayMember = "Municipios"
        Me.municipio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.municipio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.municipio.Location = New System.Drawing.Point(103, 137)
        Me.municipio.Name = "municipio"
        Me.municipio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.municipio.Size = New System.Drawing.Size(249, 24)
        Me.municipio.TabIndex = 14
        Me.municipio.ValueMember = "ID"
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(17, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Estado:"
        '
        'estado
        '
        Me.estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.estado.Cursor = System.Windows.Forms.Cursors.Default
        Me.estado.DataSource = Me.TblEstadosBindingSource
        Me.estado.DisplayMember = "Nombre"
        Me.estado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.estado.Location = New System.Drawing.Point(103, 107)
        Me.estado.Name = "estado"
        Me.estado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.estado.Size = New System.Drawing.Size(249, 24)
        Me.estado.TabIndex = 12
        Me.estado.ValueMember = "ID"
        '
        'TblEstadosBindingSource
        '
        Me.TblEstadosBindingSource.DataMember = "TblEstados"
        Me.TblEstadosBindingSource.DataSource = Me.MainDS
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(17, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "País:"
        '
        'pais
        '
        Me.pais.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pais.Cursor = System.Windows.Forms.Cursors.Default
        Me.pais.DataSource = Me.TblPaisesBindingSource
        Me.pais.DisplayMember = "Nombre"
        Me.pais.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pais.ForeColor = System.Drawing.SystemColors.WindowText
        Me.pais.Location = New System.Drawing.Point(103, 77)
        Me.pais.Name = "pais"
        Me.pais.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pais.Size = New System.Drawing.Size(249, 24)
        Me.pais.TabIndex = 10
        Me.pais.ValueMember = "ID"
        '
        'TblPaisesBindingSource
        '
        Me.TblPaisesBindingSource.DataMember = "TblPaises"
        Me.TblPaisesBindingSource.DataSource = Me.MainDS
        '
        'bk
        '
        Me.bk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bk.Cursor = System.Windows.Forms.Cursors.Default
        Me.bk.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bk.Location = New System.Drawing.Point(103, 167)
        Me.bk.Name = "bk"
        Me.bk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bk.Size = New System.Drawing.Size(249, 24)
        Me.bk.TabIndex = 2
        '
        'clave
        '
        Me.clave.AcceptsReturn = True
        Me.clave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.clave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.clave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clave.ForeColor = System.Drawing.SystemColors.WindowText
        Me.clave.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.clave.Location = New System.Drawing.Point(103, 56)
        Me.clave.MaxLength = 0
        Me.clave.Name = "clave"
        Me.clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.clave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clave.Size = New System.Drawing.Size(249, 15)
        Me.clave.TabIndex = 1
        '
        'usuario
        '
        Me.usuario.AcceptsReturn = True
        Me.usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.usuario.Location = New System.Drawing.Point(103, 32)
        Me.usuario.MaxLength = 0
        Me.usuario.Name = "usuario"
        Me.usuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.usuario.Size = New System.Drawing.Size(249, 15)
        Me.usuario.TabIndex = 0
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(358, 32)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(90, 90)
        Me.Image1.TabIndex = 3
        Me.Image1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Banko:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario:"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me.Label4)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(-96, 0)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(563, 73)
        Me.Picture1.TabIndex = 5
        Me.Picture1.TabStop = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(328, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(233, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "::: Autentificacion"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command1.Location = New System.Drawing.Point(282, 290)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(89, 33)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Entrar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Image = CType(resources.GetObject("Command2.Image"), System.Drawing.Image)
        Me.Command2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command2.Location = New System.Drawing.Point(378, 290)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(89, 33)
        Me.Command2.TabIndex = 4
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Autentificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(478, 332)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Command2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(255, 279)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Autentificacion"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema :::"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.TblMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Picture1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents pais As System.Windows.Forms.ComboBox
    Friend WithEvents TblPaisesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainDS As BkSistema.MainDS
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents municipio As System.Windows.Forms.ComboBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents estado As System.Windows.Forms.ComboBox
    Friend WithEvents TblMunicipiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEstadosBindingSource As System.Windows.Forms.BindingSource
#End Region 
End Class