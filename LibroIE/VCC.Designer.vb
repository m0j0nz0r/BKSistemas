<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class VCC
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
    Public WithEvents TMonto As System.Windows.Forms.TextBox
	Public WithEvents TNumero As System.Windows.Forms.TextBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents TCedula As System.Windows.Forms.ComboBox
    Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label58 As System.Windows.Forms.Label
	Public WithEvents VC As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.VC = New System.Windows.Forms.GroupBox()
        Me.TFecha = New System.Windows.Forms.DateTimePicker()
        Me.TMonto = New System.Windows.Forms.TextBox()
        Me.TNumero = New System.Windows.Forms.TextBox()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.TCedula = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.VC.SuspendLayout()
        Me.SuspendLayout()
        '
        'VC
        '
        Me.VC.BackColor = System.Drawing.Color.White
        Me.VC.Controls.Add(Me.TFecha)
        Me.VC.Controls.Add(Me.TMonto)
        Me.VC.Controls.Add(Me.TNumero)
        Me.VC.Controls.Add(Me.Command2)
        Me.VC.Controls.Add(Me.Command1)
        Me.VC.Controls.Add(Me.TCedula)
        Me.VC.Controls.Add(Me.Label2)
        Me.VC.Controls.Add(Me.Label1)
        Me.VC.Controls.Add(Me.Label8)
        Me.VC.Controls.Add(Me.Label7)
        Me.VC.Controls.Add(Me.Label5)
        Me.VC.Controls.Add(Me.Label6)
        Me.VC.Controls.Add(Me.Label58)
        Me.VC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.VC.Location = New System.Drawing.Point(8, 8)
        Me.VC.Name = "VC"
        Me.VC.Padding = New System.Windows.Forms.Padding(0)
        Me.VC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VC.Size = New System.Drawing.Size(545, 196)
        Me.VC.TabIndex = 8
        Me.VC.TabStop = False
        Me.VC.Text = "::: Venta de Acciones :::"
        '
        'TFecha
        '
        Me.TFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TFecha.Location = New System.Drawing.Point(144, 69)
        Me.TFecha.Name = "TFecha"
        Me.TFecha.Size = New System.Drawing.Size(177, 20)
        Me.TFecha.TabIndex = 16
        '
        'TMonto
        '
        Me.TMonto.AcceptsReturn = True
        Me.TMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TMonto.Location = New System.Drawing.Point(144, 128)
        Me.TMonto.MaxLength = 0
        Me.TMonto.Name = "TMonto"
        Me.TMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TMonto.Size = New System.Drawing.Size(369, 22)
        Me.TMonto.TabIndex = 3
        '
        'TNumero
        '
        Me.TNumero.AcceptsReturn = True
        Me.TNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TNumero.Location = New System.Drawing.Point(144, 40)
        Me.TNumero.MaxLength = 0
        Me.TNumero.Name = "TNumero"
        Me.TNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TNumero.Size = New System.Drawing.Size(177, 22)
        Me.TNumero.TabIndex = 0
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command2.Location = New System.Drawing.Point(432, 156)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(89, 25)
        Me.Command2.TabIndex = 7
        Me.Command2.Text = "Cancelar"
        Me.Command2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command1.Location = New System.Drawing.Point(328, 156)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(97, 25)
        Me.Command1.TabIndex = 4
        Me.Command1.Text = "Guardar"
        Me.Command1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command1.UseVisualStyleBackColor = False
        '
        'TCedula
        '
        Me.TCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TCedula.Cursor = System.Windows.Forms.Cursors.Default
        Me.TCedula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCedula.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TCedula.Location = New System.Drawing.Point(144, 96)
        Me.TCedula.Name = "TCedula"
        Me.TCedula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TCedula.Size = New System.Drawing.Size(177, 24)
        Me.TCedula.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(344, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(177, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(344, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(177, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(32, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Monto:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(32, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(161, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "No Op. / No Recibo:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(32, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(129, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cedula del Socio:"
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.White
        Me.Label58.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(344, 32)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label58.Size = New System.Drawing.Size(177, 17)
        Me.Label58.TabIndex = 9
        Me.Label58.Text = "Label58"
        Me.Label58.Visible = False
        '
        'VCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(560, 210)
        Me.Controls.Add(Me.VC)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VCC"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistemas - Venta de Acciones :::"
        Me.VC.ResumeLayout(False)
        Me.VC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TFecha As System.Windows.Forms.DateTimePicker
#End Region 
End Class