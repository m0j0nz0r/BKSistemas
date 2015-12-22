<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FechaRendimiento
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
	Public WithEvents Fecha2 As System.Windows.Forms.ComboBox
	Public WithEvents Fecha1 As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Fecha2 = New System.Windows.Forms.ComboBox()
        Me.Fecha1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(248, 152)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(97, 25)
        Me.Command2.TabIndex = 3
        Me.Command2.Text = "Cancelar"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(144, 152)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(97, 25)
        Me.Command1.TabIndex = 2
        Me.Command1.Text = "Aceptar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.Fecha2)
        Me.Frame1.Controls.Add(Me.Fecha1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(337, 137)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'Fecha2
        '
        Me.Fecha2.BackColor = System.Drawing.SystemColors.Window
        Me.Fecha2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Fecha2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Fecha2.Location = New System.Drawing.Point(16, 88)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fecha2.Size = New System.Drawing.Size(289, 23)
        Me.Fecha2.TabIndex = 1
        '
        'Fecha1
        '
        Me.Fecha1.BackColor = System.Drawing.SystemColors.Window
        Me.Fecha1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Fecha1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Fecha1.Location = New System.Drawing.Point(16, 32)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fecha1.Size = New System.Drawing.Size(289, 23)
        Me.Fecha1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(241, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha Inicial "
        '
        'FechaRendimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(355, 184)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "FechaRendimiento"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - Rendimientos Acciones :::"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class