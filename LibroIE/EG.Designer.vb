<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class EGForm
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
    Public WithEvents Command9 As System.Windows.Forms.Button
    Public WithEvents TEGNumero As System.Windows.Forms.TextBox
    Public WithEvents TEGMonto As System.Windows.Forms.TextBox
    Public WithEvents Command8 As System.Windows.Forms.Button
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Image5 As System.Windows.Forms.PictureBox
    Public WithEvents EGGroupBox As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EGForm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EGGroupBox = New System.Windows.Forms.GroupBox()
        Me.TEGFecha = New System.Windows.Forms.DateTimePicker()
        Me.Command9 = New System.Windows.Forms.Button()
        Me.TEGNumero = New System.Windows.Forms.TextBox()
        Me.TEGMonto = New System.Windows.Forms.TextBox()
        Me.Command8 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Image5 = New System.Windows.Forms.PictureBox()
        Me.EGGroupBox.SuspendLayout()
        CType(Me.Image5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EGGroupBox
        '
        Me.EGGroupBox.BackColor = System.Drawing.Color.White
        Me.EGGroupBox.Controls.Add(Me.TEGFecha)
        Me.EGGroupBox.Controls.Add(Me.Command9)
        Me.EGGroupBox.Controls.Add(Me.TEGNumero)
        Me.EGGroupBox.Controls.Add(Me.TEGMonto)
        Me.EGGroupBox.Controls.Add(Me.Command8)
        Me.EGGroupBox.Controls.Add(Me.Label16)
        Me.EGGroupBox.Controls.Add(Me.Label17)
        Me.EGGroupBox.Controls.Add(Me.Label18)
        Me.EGGroupBox.Controls.Add(Me.Image5)
        Me.EGGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EGGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EGGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.EGGroupBox.Name = "EGGroupBox"
        Me.EGGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.EGGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EGGroupBox.Size = New System.Drawing.Size(537, 193)
        Me.EGGroupBox.TabIndex = 7
        Me.EGGroupBox.TabStop = False
        Me.EGGroupBox.Text = "::: Otros Egresos Repartibles :::"
        '
        'TEGFecha
        '
        Me.TEGFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TEGFecha.Location = New System.Drawing.Point(160, 73)
        Me.TEGFecha.Name = "TEGFecha"
        Me.TEGFecha.Size = New System.Drawing.Size(225, 20)
        Me.TEGFecha.TabIndex = 12
        '
        'Command9
        '
        Me.Command9.BackColor = System.Drawing.SystemColors.Control
        Me.Command9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command9.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command9.Location = New System.Drawing.Point(344, 152)
        Me.Command9.Name = "Command9"
        Me.Command9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command9.Size = New System.Drawing.Size(89, 25)
        Me.Command9.TabIndex = 3
        Me.Command9.Text = "Guardar"
        Me.Command9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command9.UseVisualStyleBackColor = False
        '
        'TEGNumero
        '
        Me.TEGNumero.AcceptsReturn = True
        Me.TEGNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TEGNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TEGNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TEGNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEGNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TEGNumero.Location = New System.Drawing.Point(160, 37)
        Me.TEGNumero.MaxLength = 0
        Me.TEGNumero.Name = "TEGNumero"
        Me.TEGNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TEGNumero.Size = New System.Drawing.Size(225, 22)
        Me.TEGNumero.TabIndex = 0
        '
        'TEGMonto
        '
        Me.TEGMonto.AcceptsReturn = True
        Me.TEGMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TEGMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TEGMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TEGMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEGMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TEGMonto.Location = New System.Drawing.Point(160, 109)
        Me.TEGMonto.MaxLength = 0
        Me.TEGMonto.Name = "TEGMonto"
        Me.TEGMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TEGMonto.Size = New System.Drawing.Size(337, 22)
        Me.TEGMonto.TabIndex = 2
        '
        'Command8
        '
        Me.Command8.BackColor = System.Drawing.SystemColors.Control
        Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command8.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command8.Location = New System.Drawing.Point(440, 152)
        Me.Command8.Name = "Command8"
        Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command8.Size = New System.Drawing.Size(81, 25)
        Me.Command8.TabIndex = 6
        Me.Command8.Text = "Cancelar"
        Me.Command8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command8.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(32, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(153, 17)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "No Op. / No Recibo:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(32, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(137, 17)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Fecha:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(32, 113)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(137, 17)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Monto de Egreso: "
        '
        'Image5
        '
        Me.Image5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image5.Image = CType(resources.GetObject("Image5.Image"), System.Drawing.Image)
        Me.Image5.Location = New System.Drawing.Point(424, 40)
        Me.Image5.Name = "Image5"
        Me.Image5.Size = New System.Drawing.Size(50, 50)
        Me.Image5.TabIndex = 11
        Me.Image5.TabStop = False
        '
        'EGForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(554, 207)
        Me.Controls.Add(Me.EGGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "EGForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - EG :::"
        Me.EGGroupBox.ResumeLayout(False)
        Me.EGGroupBox.PerformLayout()
        CType(Me.Image5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TEGFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class