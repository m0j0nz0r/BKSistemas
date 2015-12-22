<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class GBK
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
    Public WithEvents TGBKNumero As System.Windows.Forms.TextBox
    Public WithEvents TGBKMonto As System.Windows.Forms.TextBox
    Public WithEvents Command12 As System.Windows.Forms.Button
    Public WithEvents Command13 As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents GBKGroupBox As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GBKGroupBox = New System.Windows.Forms.GroupBox()
        Me.TGBKFecha = New System.Windows.Forms.DateTimePicker()
        Me.TGBKNumero = New System.Windows.Forms.TextBox()
        Me.TGBKMonto = New System.Windows.Forms.TextBox()
        Me.Command12 = New System.Windows.Forms.Button()
        Me.Command13 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GBKGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBKGroupBox
        '
        Me.GBKGroupBox.BackColor = System.Drawing.Color.White
        Me.GBKGroupBox.Controls.Add(Me.TGBKFecha)
        Me.GBKGroupBox.Controls.Add(Me.TGBKNumero)
        Me.GBKGroupBox.Controls.Add(Me.TGBKMonto)
        Me.GBKGroupBox.Controls.Add(Me.Command12)
        Me.GBKGroupBox.Controls.Add(Me.Command13)
        Me.GBKGroupBox.Controls.Add(Me.Label2)
        Me.GBKGroupBox.Controls.Add(Me.Label1)
        Me.GBKGroupBox.Controls.Add(Me.Label23)
        Me.GBKGroupBox.Controls.Add(Me.Label24)
        Me.GBKGroupBox.Controls.Add(Me.Label25)
        Me.GBKGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBKGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GBKGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.GBKGroupBox.Name = "GBKGroupBox"
        Me.GBKGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.GBKGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GBKGroupBox.Size = New System.Drawing.Size(545, 193)
        Me.GBKGroupBox.TabIndex = 5
        Me.GBKGroupBox.TabStop = False
        Me.GBKGroupBox.Text = "::: Gastos el Bankomunal :::"
        '
        'TGBKFecha
        '
        Me.TGBKFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TGBKFecha.Location = New System.Drawing.Point(152, 80)
        Me.TGBKFecha.Name = "TGBKFecha"
        Me.TGBKFecha.Size = New System.Drawing.Size(161, 20)
        Me.TGBKFecha.TabIndex = 11
        '
        'TGBKNumero
        '
        Me.TGBKNumero.AcceptsReturn = True
        Me.TGBKNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TGBKNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TGBKNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TGBKNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGBKNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TGBKNumero.Location = New System.Drawing.Point(152, 37)
        Me.TGBKNumero.MaxLength = 0
        Me.TGBKNumero.Name = "TGBKNumero"
        Me.TGBKNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TGBKNumero.Size = New System.Drawing.Size(161, 22)
        Me.TGBKNumero.TabIndex = 0
        '
        'TGBKMonto
        '
        Me.TGBKMonto.AcceptsReturn = True
        Me.TGBKMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TGBKMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TGBKMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TGBKMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGBKMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TGBKMonto.Location = New System.Drawing.Point(152, 117)
        Me.TGBKMonto.MaxLength = 0
        Me.TGBKMonto.Name = "TGBKMonto"
        Me.TGBKMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TGBKMonto.Size = New System.Drawing.Size(369, 22)
        Me.TGBKMonto.TabIndex = 2
        '
        'Command12
        '
        Me.Command12.BackColor = System.Drawing.SystemColors.Control
        Me.Command12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command12.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command12.Location = New System.Drawing.Point(432, 160)
        Me.Command12.Name = "Command12"
        Me.Command12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command12.Size = New System.Drawing.Size(97, 25)
        Me.Command12.TabIndex = 4
        Me.Command12.Text = "Cancelar"
        Me.Command12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command12.UseVisualStyleBackColor = False
        '
        'Command13
        '
        Me.Command13.BackColor = System.Drawing.SystemColors.Control
        Me.Command13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command13.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command13.Location = New System.Drawing.Point(328, 160)
        Me.Command13.Name = "Command13"
        Me.Command13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command13.Size = New System.Drawing.Size(97, 25)
        Me.Command13.TabIndex = 3
        Me.Command13.Text = "Guardar"
        Me.Command13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command13.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(328, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(193, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(328, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(193, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Saldo del Fondo para Gastos:"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(32, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(121, 17)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "No Op. / No Recibo"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(32, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(113, 17)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Fecha:"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(32, 121)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(145, 17)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Monto del Gasto:"
        '
        'GBK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(559, 208)
        Me.Controls.Add(Me.GBKGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "GBK"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - GBK :::"
        Me.GBKGroupBox.ResumeLayout(False)
        Me.GBKGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TGBKFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class