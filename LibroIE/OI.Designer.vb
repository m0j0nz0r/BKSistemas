<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class OI
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
    Public WithEvents TIONumero As System.Windows.Forms.TextBox
	Public WithEvents TIOMonto As System.Windows.Forms.TextBox
	Public WithEvents Command6 As System.Windows.Forms.Button
	Public WithEvents Command7 As System.Windows.Forms.Button
    Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Image4 As System.Windows.Forms.PictureBox
	Public WithEvents IO As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OI))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.IO = New System.Windows.Forms.GroupBox()
        Me.TIOFecha = New System.Windows.Forms.DateTimePicker()
        Me.TIONumero = New System.Windows.Forms.TextBox()
        Me.TIOMonto = New System.Windows.Forms.TextBox()
        Me.Command6 = New System.Windows.Forms.Button()
        Me.Command7 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Image4 = New System.Windows.Forms.PictureBox()
        Me.IO.SuspendLayout()
        CType(Me.Image4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IO
        '
        Me.IO.BackColor = System.Drawing.Color.White
        Me.IO.Controls.Add(Me.TIOFecha)
        Me.IO.Controls.Add(Me.TIONumero)
        Me.IO.Controls.Add(Me.TIOMonto)
        Me.IO.Controls.Add(Me.Command6)
        Me.IO.Controls.Add(Me.Command7)
        Me.IO.Controls.Add(Me.Label13)
        Me.IO.Controls.Add(Me.Label14)
        Me.IO.Controls.Add(Me.Label15)
        Me.IO.Controls.Add(Me.Image4)
        Me.IO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IO.Location = New System.Drawing.Point(8, 8)
        Me.IO.Name = "IO"
        Me.IO.Padding = New System.Windows.Forms.Padding(0)
        Me.IO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IO.Size = New System.Drawing.Size(545, 193)
        Me.IO.TabIndex = 7
        Me.IO.TabStop = False
        Me.IO.Text = "::: Otros Ingresos Repartibles :::"
        '
        'TIOFecha
        '
        Me.TIOFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TIOFecha.Location = New System.Drawing.Point(176, 75)
        Me.TIOFecha.Name = "TIOFecha"
        Me.TIOFecha.Size = New System.Drawing.Size(217, 20)
        Me.TIOFecha.TabIndex = 12
        '
        'TIONumero
        '
        Me.TIONumero.AcceptsReturn = True
        Me.TIONumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TIONumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TIONumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TIONumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIONumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TIONumero.Location = New System.Drawing.Point(176, 37)
        Me.TIONumero.MaxLength = 0
        Me.TIONumero.Name = "TIONumero"
        Me.TIONumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TIONumero.Size = New System.Drawing.Size(217, 22)
        Me.TIONumero.TabIndex = 0
        '
        'TIOMonto
        '
        Me.TIOMonto.AcceptsReturn = True
        Me.TIOMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TIOMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TIOMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TIOMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIOMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TIOMonto.Location = New System.Drawing.Point(176, 109)
        Me.TIOMonto.MaxLength = 0
        Me.TIOMonto.Name = "TIOMonto"
        Me.TIOMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TIOMonto.Size = New System.Drawing.Size(345, 22)
        Me.TIOMonto.TabIndex = 2
        '
        'Command6
        '
        Me.Command6.BackColor = System.Drawing.SystemColors.Control
        Me.Command6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command6.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command6.Location = New System.Drawing.Point(424, 152)
        Me.Command6.Name = "Command6"
        Me.Command6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command6.Size = New System.Drawing.Size(97, 25)
        Me.Command6.TabIndex = 6
        Me.Command6.Text = "Cancelar"
        Me.Command6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command6.UseVisualStyleBackColor = False
        '
        'Command7
        '
        Me.Command7.BackColor = System.Drawing.SystemColors.Control
        Me.Command7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command7.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command7.Location = New System.Drawing.Point(320, 152)
        Me.Command7.Name = "Command7"
        Me.Command7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command7.Size = New System.Drawing.Size(97, 25)
        Me.Command7.TabIndex = 3
        Me.Command7.Text = "Guardar"
        Me.Command7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command7.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(32, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(121, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "No Op. / No Recibo: "
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(32, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(121, 17)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Fecha:"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(32, 113)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(153, 17)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Monto de los Ingresos:"
        '
        'Image4
        '
        Me.Image4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image4.Image = CType(resources.GetObject("Image4.Image"), System.Drawing.Image)
        Me.Image4.Location = New System.Drawing.Point(432, 40)
        Me.Image4.Name = "Image4"
        Me.Image4.Size = New System.Drawing.Size(50, 50)
        Me.Image4.TabIndex = 11
        Me.Image4.TabStop = False
        '
        'OI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(561, 206)
        Me.Controls.Add(Me.IO)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "OI"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - OI :::"
        Me.IO.ResumeLayout(False)
        Me.IO.PerformLayout()
        CType(Me.Image4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TIOFecha As System.Windows.Forms.DateTimePicker
#End Region 
End Class