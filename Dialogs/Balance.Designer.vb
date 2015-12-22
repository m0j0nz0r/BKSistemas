<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Balance
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
	Public WithEvents CFecha As System.Windows.Forms.ComboBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Cuadre As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Cuadre = New System.Windows.Forms.GroupBox()
        Me.CFecha = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cuadre.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(272, 128)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(97, 33)
        Me.Command2.TabIndex = 4
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(168, 128)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(97, 33)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Consultar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Cuadre
        '
        Me.Cuadre.BackColor = System.Drawing.Color.White
        Me.Cuadre.Controls.Add(Me.CFecha)
        Me.Cuadre.Controls.Add(Me.Label1)
        Me.Cuadre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cuadre.Location = New System.Drawing.Point(0, 0)
        Me.Cuadre.Name = "Cuadre"
        Me.Cuadre.Padding = New System.Windows.Forms.Padding(0)
        Me.Cuadre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cuadre.Size = New System.Drawing.Size(369, 121)
        Me.Cuadre.TabIndex = 0
        Me.Cuadre.TabStop = False
        Me.Cuadre.Text = "::: Balance General :::"
        '
        'CFecha
        '
        Me.CFecha.BackColor = System.Drawing.SystemColors.Window
        Me.CFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.CFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFecha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CFecha.Location = New System.Drawing.Point(16, 64)
        Me.CFecha.Name = "CFecha"
        Me.CFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CFecha.Size = New System.Drawing.Size(257, 24)
        Me.CFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(273, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione un fecha para consultar el Balance"
        '
        'Balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(370, 170)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Cuadre)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(277, 287)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Balance"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema :::"
        Me.Cuadre.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class