<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class PDP
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
    Public WithEvents TPDPNumero As System.Windows.Forms.TextBox
	Public WithEvents TPDPMonto As System.Windows.Forms.TextBox
	Public WithEvents TPDPCredito As System.Windows.Forms.ComboBox
	Public WithEvents Command32 As System.Windows.Forms.Button
	Public WithEvents Command33 As System.Windows.Forms.Button
    Public WithEvents Label60 As System.Windows.Forms.Label
	Public WithEvents Label82 As System.Windows.Forms.Label
	Public WithEvents Label83 As System.Windows.Forms.Label
	Public WithEvents Label84 As System.Windows.Forms.Label
	Public WithEvents Label89 As System.Windows.Forms.Label
	Public WithEvents Label88 As System.Windows.Forms.Label
	Public WithEvents Label87 As System.Windows.Forms.Label
	Public WithEvents Label86 As System.Windows.Forms.Label
	Public WithEvents Label85 As System.Windows.Forms.Label
	Public WithEvents PC As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PC = New System.Windows.Forms.GroupBox()
        Me.TPDPFecha = New System.Windows.Forms.DateTimePicker()
        Me.TPDPNumero = New System.Windows.Forms.TextBox()
        Me.TPDPMonto = New System.Windows.Forms.TextBox()
        Me.TPDPCredito = New System.Windows.Forms.ComboBox()
        Me.Command32 = New System.Windows.Forms.Button()
        Me.Command33 = New System.Windows.Forms.Button()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.PC.SuspendLayout()
        Me.SuspendLayout()
        '
        'PC
        '
        Me.PC.BackColor = System.Drawing.Color.White
        Me.PC.Controls.Add(Me.TPDPFecha)
        Me.PC.Controls.Add(Me.TPDPNumero)
        Me.PC.Controls.Add(Me.TPDPMonto)
        Me.PC.Controls.Add(Me.TPDPCredito)
        Me.PC.Controls.Add(Me.Command32)
        Me.PC.Controls.Add(Me.Command33)
        Me.PC.Controls.Add(Me.Label60)
        Me.PC.Controls.Add(Me.Label82)
        Me.PC.Controls.Add(Me.Label83)
        Me.PC.Controls.Add(Me.Label84)
        Me.PC.Controls.Add(Me.Label89)
        Me.PC.Controls.Add(Me.Label88)
        Me.PC.Controls.Add(Me.Label87)
        Me.PC.Controls.Add(Me.Label86)
        Me.PC.Controls.Add(Me.Label85)
        Me.PC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PC.Location = New System.Drawing.Point(8, 8)
        Me.PC.Name = "PC"
        Me.PC.Padding = New System.Windows.Forms.Padding(0)
        Me.PC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PC.Size = New System.Drawing.Size(545, 193)
        Me.PC.TabIndex = 8
        Me.PC.TabStop = False
        Me.PC.Text = "::: Pago de Deuda Pendiente :::"
        '
        'TPDPFecha
        '
        Me.TPDPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TPDPFecha.Location = New System.Drawing.Point(144, 64)
        Me.TPDPFecha.Name = "TPDPFecha"
        Me.TPDPFecha.Size = New System.Drawing.Size(169, 20)
        Me.TPDPFecha.TabIndex = 18
        '
        'TPDPNumero
        '
        Me.TPDPNumero.AcceptsReturn = True
        Me.TPDPNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TPDPNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TPDPNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TPDPNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPDPNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPDPNumero.Location = New System.Drawing.Point(144, 32)
        Me.TPDPNumero.MaxLength = 0
        Me.TPDPNumero.Name = "TPDPNumero"
        Me.TPDPNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TPDPNumero.Size = New System.Drawing.Size(169, 22)
        Me.TPDPNumero.TabIndex = 0
        Me.TPDPNumero.TabStop = False
        '
        'TPDPMonto
        '
        Me.TPDPMonto.AcceptsReturn = True
        Me.TPDPMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TPDPMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TPDPMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TPDPMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPDPMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPDPMonto.Location = New System.Drawing.Point(144, 128)
        Me.TPDPMonto.MaxLength = 0
        Me.TPDPMonto.Name = "TPDPMonto"
        Me.TPDPMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TPDPMonto.Size = New System.Drawing.Size(169, 22)
        Me.TPDPMonto.TabIndex = 3
        '
        'TPDPCredito
        '
        Me.TPDPCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TPDPCredito.Cursor = System.Windows.Forms.Cursors.Default
        Me.TPDPCredito.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPDPCredito.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TPDPCredito.Location = New System.Drawing.Point(144, 96)
        Me.TPDPCredito.Name = "TPDPCredito"
        Me.TPDPCredito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TPDPCredito.Size = New System.Drawing.Size(169, 24)
        Me.TPDPCredito.TabIndex = 2
        '
        'Command32
        '
        Me.Command32.BackColor = System.Drawing.SystemColors.Control
        Me.Command32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command32.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command32.Location = New System.Drawing.Point(360, 160)
        Me.Command32.Name = "Command32"
        Me.Command32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command32.Size = New System.Drawing.Size(81, 25)
        Me.Command32.TabIndex = 5
        Me.Command32.Text = "Guardar"
        Me.Command32.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command32.UseVisualStyleBackColor = False
        '
        'Command33
        '
        Me.Command33.BackColor = System.Drawing.SystemColors.Control
        Me.Command33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command33.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command33.Location = New System.Drawing.Point(448, 160)
        Me.Command33.Name = "Command33"
        Me.Command33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command33.Size = New System.Drawing.Size(81, 25)
        Me.Command33.TabIndex = 7
        Me.Command33.Text = "Cancelar"
        Me.Command33.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command33.UseVisualStyleBackColor = False
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.White
        Me.Label60.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(24, 36)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label60.Size = New System.Drawing.Size(105, 17)
        Me.Label60.TabIndex = 17
        Me.Label60.Text = "N° Op. / N° Recibo:"
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.Color.White
        Me.Label82.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label82.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label82.Location = New System.Drawing.Point(24, 69)
        Me.Label82.Name = "Label82"
        Me.Label82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label82.Size = New System.Drawing.Size(113, 17)
        Me.Label82.TabIndex = 16
        Me.Label82.Text = "Fecha:"
        '
        'Label83
        '
        Me.Label83.BackColor = System.Drawing.Color.White
        Me.Label83.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label83.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label83.Location = New System.Drawing.Point(24, 101)
        Me.Label83.Name = "Label83"
        Me.Label83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label83.Size = New System.Drawing.Size(73, 17)
        Me.Label83.TabIndex = 15
        Me.Label83.Text = "N° Credito:"
        '
        'Label84
        '
        Me.Label84.BackColor = System.Drawing.Color.White
        Me.Label84.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label84.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label84.Location = New System.Drawing.Point(24, 132)
        Me.Label84.Name = "Label84"
        Me.Label84.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label84.Size = New System.Drawing.Size(121, 17)
        Me.Label84.TabIndex = 14
        Me.Label84.Text = "Monto de la Cuota:"
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.Transparent
        Me.Label89.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label89.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label89.Location = New System.Drawing.Point(336, 104)
        Me.Label89.Name = "Label89"
        Me.Label89.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label89.Size = New System.Drawing.Size(185, 17)
        Me.Label89.TabIndex = 13
        Me.Label89.Text = "Label89"
        Me.Label89.Visible = False
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label88.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label88.Location = New System.Drawing.Point(336, 80)
        Me.Label88.Name = "Label88"
        Me.Label88.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label88.Size = New System.Drawing.Size(185, 17)
        Me.Label88.TabIndex = 12
        Me.Label88.Text = "Label88"
        Me.Label88.Visible = False
        '
        'Label87
        '
        Me.Label87.BackColor = System.Drawing.Color.Transparent
        Me.Label87.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label87.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label87.Location = New System.Drawing.Point(384, 56)
        Me.Label87.Name = "Label87"
        Me.Label87.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label87.Size = New System.Drawing.Size(129, 17)
        Me.Label87.TabIndex = 11
        Me.Label87.Text = "Label87"
        Me.Label87.Visible = False
        '
        'Label86
        '
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label86.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label86.Location = New System.Drawing.Point(336, 56)
        Me.Label86.Name = "Label86"
        Me.Label86.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label86.Size = New System.Drawing.Size(49, 17)
        Me.Label86.TabIndex = 10
        Me.Label86.Text = "Cedula:"
        Me.Label86.Visible = False
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label85.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label85.Location = New System.Drawing.Point(336, 32)
        Me.Label85.Name = "Label85"
        Me.Label85.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label85.Size = New System.Drawing.Size(185, 17)
        Me.Label85.TabIndex = 9
        Me.Label85.Text = "Label85"
        Me.Label85.Visible = False
        '
        'PDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(562, 211)
        Me.Controls.Add(Me.PC)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "PDP"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: BKSistema - PDP :::"
        Me.PC.ResumeLayout(False)
        Me.PC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TPDPFecha As System.Windows.Forms.DateTimePicker
#End Region 
End Class