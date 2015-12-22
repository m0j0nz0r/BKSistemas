<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class CrearSocio
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
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents TEmail As System.Windows.Forms.TextBox
    Public WithEvents CSexo As System.Windows.Forms.ComboBox
    Public WithEvents TDireccion As System.Windows.Forms.TextBox
    Public WithEvents TOcupacion As System.Windows.Forms.TextBox
    Public WithEvents TTelefono As System.Windows.Forms.TextBox
    Public WithEvents TNombre As System.Windows.Forms.TextBox
    Public WithEvents TCedula As System.Windows.Forms.TextBox
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents Label6 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearSocio))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.CSexo = New System.Windows.Forms.ComboBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TOcupacion = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TCedula = New System.Windows.Forms.TextBox()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Frame2.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Picture1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(432, 328)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(97, 25)
        Me.Command2.TabIndex = 8
        Me.Command2.Text = "Cancelar"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(320, 328)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(105, 25)
        Me.Command1.TabIndex = 7
        Me.Command1.Text = "Guardar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.TFNacimiento)
        Me.Frame2.Controls.Add(Me.TEmail)
        Me.Frame2.Controls.Add(Me.CSexo)
        Me.Frame2.Controls.Add(Me.TDireccion)
        Me.Frame2.Controls.Add(Me.TOcupacion)
        Me.Frame2.Controls.Add(Me.TTelefono)
        Me.Frame2.Controls.Add(Me.TNombre)
        Me.Frame2.Controls.Add(Me.TCedula)
        Me.Frame2.Controls.Add(Me.Image1)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label11)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(8, 80)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(521, 233)
        Me.Frame2.TabIndex = 11
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "::: Datos del Socio :::"
        '
        'TEmail
        '
        Me.TEmail.AcceptsReturn = True
        Me.TEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TEmail.Location = New System.Drawing.Point(112, 120)
        Me.TEmail.MaxLength = 0
        Me.TEmail.Name = "TEmail"
        Me.TEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TEmail.Size = New System.Drawing.Size(201, 19)
        Me.TEmail.TabIndex = 3
        '
        'CSexo
        '
        Me.CSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CSexo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CSexo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.CSexo.Location = New System.Drawing.Point(112, 168)
        Me.CSexo.Name = "CSexo"
        Me.CSexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CSexo.Size = New System.Drawing.Size(201, 22)
        Me.CSexo.TabIndex = 5
        '
        'TDireccion
        '
        Me.TDireccion.AcceptsReturn = True
        Me.TDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TDireccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TDireccion.Location = New System.Drawing.Point(112, 144)
        Me.TDireccion.MaxLength = 0
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TDireccion.Size = New System.Drawing.Size(201, 19)
        Me.TDireccion.TabIndex = 4
        '
        'TOcupacion
        '
        Me.TOcupacion.AcceptsReturn = True
        Me.TOcupacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOcupacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TOcupacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TOcupacion.Location = New System.Drawing.Point(112, 192)
        Me.TOcupacion.MaxLength = 0
        Me.TOcupacion.Name = "TOcupacion"
        Me.TOcupacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TOcupacion.Size = New System.Drawing.Size(201, 19)
        Me.TOcupacion.TabIndex = 6
        '
        'TTelefono
        '
        Me.TTelefono.AcceptsReturn = True
        Me.TTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TTelefono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TTelefono.Location = New System.Drawing.Point(112, 96)
        Me.TTelefono.MaxLength = 0
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TTelefono.Size = New System.Drawing.Size(201, 19)
        Me.TTelefono.TabIndex = 2
        '
        'TNombre
        '
        Me.TNombre.AcceptsReturn = True
        Me.TNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TNombre.Location = New System.Drawing.Point(112, 40)
        Me.TNombre.MaxLength = 0
        Me.TNombre.Name = "TNombre"
        Me.TNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TNombre.Size = New System.Drawing.Size(201, 19)
        Me.TNombre.TabIndex = 0
        '
        'TCedula
        '
        Me.TCedula.AcceptsReturn = True
        Me.TCedula.BackColor = System.Drawing.Color.White
        Me.TCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCedula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TCedula.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCedula.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TCedula.Location = New System.Drawing.Point(112, 24)
        Me.TCedula.MaxLength = 0
        Me.TCedula.Name = "TCedula"
        Me.TCedula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TCedula.Size = New System.Drawing.Size(201, 19)
        Me.TCedula.TabIndex = 12
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(360, 72)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(120, 103)
        Me.Image1.TabIndex = 13
        Me.Image1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Email:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(16, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Direccion:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Ocupacion:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Sexo (*):"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Telefono (*):"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "F. Nacim:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre (*) :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "N° Cedula (*):"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me.Label14)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(0, -32)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(633, 97)
        Me.Picture1.TabIndex = 9
        Me.Picture1.TabStop = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(232, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(345, 41)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "::: Ingresar Nuevo Socio"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(161, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "   (*) Datos Requeridos"
        '
        'TFNacimiento
        '
        Me.TFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TFNacimiento.Location = New System.Drawing.Point(112, 67)
        Me.TFNacimiento.Name = "TFNacimiento"
        Me.TFNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.TFNacimiento.TabIndex = 21
        '
        'Socios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 359)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Socios"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema :::"
        Me.Frame2.ResumeLayout(False)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Picture1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TFNacimiento As System.Windows.Forms.DateTimePicker
#End Region
End Class