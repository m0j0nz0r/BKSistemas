<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Fecha3
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
    Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Frame1 As System.Windows.Forms.Panel
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fecha3))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame1 = New System.Windows.Forms.Panel()
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Frame1.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.Fecha2)
        Me.Frame1.Controls.Add(Me.Fecha1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Image1)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(289, 145)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Text = "::: Indique la Fecha Actual :::"
        '
        'Fecha2
        '
        Me.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha2.Location = New System.Drawing.Point(16, 93)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(145, 21)
        Me.Fecha2.TabIndex = 9
        '
        'Fecha1
        '
        Me.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha1.Location = New System.Drawing.Point(16, 40)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(145, 21)
        Me.Fecha1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Indique la Fecha Final:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Indique la Fecha Inicio:"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command2.Location = New System.Drawing.Point(216, 160)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(81, 33)
        Me.Command2.TabIndex = 3
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
        Me.Command1.Location = New System.Drawing.Point(128, 160)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 2
        Me.Command1.Text = "Aceptar"
        Me.Command1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(184, 40)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(300, 300)
        Me.Image1.TabIndex = 7
        Me.Image1.TabStop = False
        '
        'Fecha3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(305, 200)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fecha3"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - RptLibro I/E :::"
        Me.Frame1.ResumeLayout(False)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha1 As System.Windows.Forms.DateTimePicker
#End Region 
End Class