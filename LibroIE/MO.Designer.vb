<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MO
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
    Public WithEvents TMONumero As System.Windows.Forms.TextBox
    Public WithEvents TMOCredito As System.Windows.Forms.ComboBox
    Public WithEvents TMOMonto As System.Windows.Forms.TextBox
    Public WithEvents Command28 As System.Windows.Forms.Button
    Public WithEvents Command29 As System.Windows.Forms.Button
    Public WithEvents Label65 As System.Windows.Forms.Label
    Public WithEvents Label66 As System.Windows.Forms.Label
    Public WithEvents Label67 As System.Windows.Forms.Label
    Public WithEvents Label68 As System.Windows.Forms.Label
    Public WithEvents Label70 As System.Windows.Forms.Label
    Public WithEvents _Label52_0 As System.Windows.Forms.Label
    Public WithEvents _Label53_0 As System.Windows.Forms.Label
    Public WithEvents _Label54_0 As System.Windows.Forms.Label
    Public WithEvents _Label55_0 As System.Windows.Forms.Label
    Public WithEvents _Image10_0 As System.Windows.Forms.PictureBox
    Public WithEvents MOGroupBox As System.Windows.Forms.GroupBox
    Public WithEvents Image10 As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    Public WithEvents Label52 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label53 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label54 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents Label55 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MO))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MOGroupBox = New System.Windows.Forms.GroupBox()
        Me.TMOFecha = New System.Windows.Forms.DateTimePicker()
        Me.TMONumero = New System.Windows.Forms.TextBox()
        Me.TMOCredito = New System.Windows.Forms.ComboBox()
        Me.TMOMonto = New System.Windows.Forms.TextBox()
        Me.Command28 = New System.Windows.Forms.Button()
        Me.Command29 = New System.Windows.Forms.Button()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me._Label52_0 = New System.Windows.Forms.Label()
        Me._Label53_0 = New System.Windows.Forms.Label()
        Me._Label54_0 = New System.Windows.Forms.Label()
        Me._Label55_0 = New System.Windows.Forms.Label()
        Me._Image10_0 = New System.Windows.Forms.PictureBox()
        Me.Image10 = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.Label52 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label53 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label54 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label55 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.MOGroupBox.SuspendLayout()
        CType(Me._Image10_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MOGroupBox
        '
        Me.MOGroupBox.BackColor = System.Drawing.Color.White
        Me.MOGroupBox.Controls.Add(Me.TMOFecha)
        Me.MOGroupBox.Controls.Add(Me.TMONumero)
        Me.MOGroupBox.Controls.Add(Me.TMOCredito)
        Me.MOGroupBox.Controls.Add(Me.TMOMonto)
        Me.MOGroupBox.Controls.Add(Me.Command28)
        Me.MOGroupBox.Controls.Add(Me.Command29)
        Me.MOGroupBox.Controls.Add(Me.Label65)
        Me.MOGroupBox.Controls.Add(Me.Label66)
        Me.MOGroupBox.Controls.Add(Me.Label67)
        Me.MOGroupBox.Controls.Add(Me.Label68)
        Me.MOGroupBox.Controls.Add(Me.Label70)
        Me.MOGroupBox.Controls.Add(Me._Label52_0)
        Me.MOGroupBox.Controls.Add(Me._Label53_0)
        Me.MOGroupBox.Controls.Add(Me._Label54_0)
        Me.MOGroupBox.Controls.Add(Me._Label55_0)
        Me.MOGroupBox.Controls.Add(Me._Image10_0)
        Me.MOGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MOGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.MOGroupBox.Name = "MOGroupBox"
        Me.MOGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.MOGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MOGroupBox.Size = New System.Drawing.Size(537, 193)
        Me.MOGroupBox.TabIndex = 8
        Me.MOGroupBox.TabStop = False
        Me.MOGroupBox.Text = "::: Intereses de Mora :::"
        '
        'TMOFecha
        '
        Me.TMOFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TMOFecha.Location = New System.Drawing.Point(136, 57)
        Me.TMOFecha.Name = "TMOFecha"
        Me.TMOFecha.Size = New System.Drawing.Size(177, 20)
        Me.TMOFecha.TabIndex = 19
        '
        'TMONumero
        '
        Me.TMONumero.AcceptsReturn = True
        Me.TMONumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TMONumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TMONumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TMONumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMONumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TMONumero.Location = New System.Drawing.Point(136, 29)
        Me.TMONumero.MaxLength = 0
        Me.TMONumero.Name = "TMONumero"
        Me.TMONumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TMONumero.Size = New System.Drawing.Size(177, 22)
        Me.TMONumero.TabIndex = 0
        '
        'TMOCredito
        '
        Me.TMOCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TMOCredito.Cursor = System.Windows.Forms.Cursors.Default
        Me.TMOCredito.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMOCredito.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TMOCredito.Location = New System.Drawing.Point(136, 88)
        Me.TMOCredito.Name = "TMOCredito"
        Me.TMOCredito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TMOCredito.Size = New System.Drawing.Size(177, 24)
        Me.TMOCredito.TabIndex = 2
        '
        'TMOMonto
        '
        Me.TMOMonto.AcceptsReturn = True
        Me.TMOMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TMOMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TMOMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TMOMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMOMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TMOMonto.Location = New System.Drawing.Point(136, 117)
        Me.TMOMonto.MaxLength = 0
        Me.TMOMonto.Name = "TMOMonto"
        Me.TMOMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TMOMonto.Size = New System.Drawing.Size(177, 22)
        Me.TMOMonto.TabIndex = 3
        '
        'Command28
        '
        Me.Command28.BackColor = System.Drawing.SystemColors.Control
        Me.Command28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command28.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command28.Location = New System.Drawing.Point(423, 152)
        Me.Command28.Name = "Command28"
        Me.Command28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command28.Size = New System.Drawing.Size(89, 25)
        Me.Command28.TabIndex = 7
        Me.Command28.Text = "Cancelar"
        Me.Command28.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command28.UseVisualStyleBackColor = False
        '
        'Command29
        '
        Me.Command29.BackColor = System.Drawing.SystemColors.Control
        Me.Command29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command29.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command29.Location = New System.Drawing.Point(335, 152)
        Me.Command29.Name = "Command29"
        Me.Command29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command29.Size = New System.Drawing.Size(81, 25)
        Me.Command29.TabIndex = 4
        Me.Command29.Text = "Guardar"
        Me.Command29.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command29.UseVisualStyleBackColor = False
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label65.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(336, 32)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label65.Size = New System.Drawing.Size(193, 17)
        Me.Label65.TabIndex = 17
        Me.Label65.Text = "Label65"
        Me.Label65.Visible = False
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label66.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label66.Location = New System.Drawing.Point(384, 56)
        Me.Label66.Name = "Label66"
        Me.Label66.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label66.Size = New System.Drawing.Size(137, 17)
        Me.Label66.TabIndex = 16
        Me.Label66.Text = "Label66"
        Me.Label66.Visible = False
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label67.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label67.Location = New System.Drawing.Point(336, 80)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(193, 17)
        Me.Label67.TabIndex = 15
        Me.Label67.Text = "Label67"
        Me.Label67.Visible = False
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label68.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label68.Location = New System.Drawing.Point(336, 104)
        Me.Label68.Name = "Label68"
        Me.Label68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label68.Size = New System.Drawing.Size(185, 17)
        Me.Label68.TabIndex = 14
        Me.Label68.Text = "Label68"
        Me.Label68.Visible = False
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label70.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label70.Location = New System.Drawing.Point(336, 56)
        Me.Label70.Name = "Label70"
        Me.Label70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label70.Size = New System.Drawing.Size(49, 17)
        Me.Label70.TabIndex = 13
        Me.Label70.Text = "Cedula:"
        Me.Label70.Visible = False
        '
        '_Label52_0
        '
        Me._Label52_0.BackColor = System.Drawing.Color.White
        Me._Label52_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label52_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label52_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.SetIndex(Me._Label52_0, CType(0, Short))
        Me._Label52_0.Location = New System.Drawing.Point(16, 32)
        Me._Label52_0.Name = "_Label52_0"
        Me._Label52_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label52_0.Size = New System.Drawing.Size(113, 17)
        Me._Label52_0.TabIndex = 12
        Me._Label52_0.Text = "Nº Op. / Nº Recibo:"
        '
        '_Label53_0
        '
        Me._Label53_0.BackColor = System.Drawing.Color.White
        Me._Label53_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label53_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label53_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.SetIndex(Me._Label53_0, CType(0, Short))
        Me._Label53_0.Location = New System.Drawing.Point(16, 62)
        Me._Label53_0.Name = "_Label53_0"
        Me._Label53_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label53_0.Size = New System.Drawing.Size(113, 17)
        Me._Label53_0.TabIndex = 11
        Me._Label53_0.Text = "Fecha:"
        '
        '_Label54_0
        '
        Me._Label54_0.BackColor = System.Drawing.Color.White
        Me._Label54_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label54_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label54_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.SetIndex(Me._Label54_0, CType(0, Short))
        Me._Label54_0.Location = New System.Drawing.Point(16, 93)
        Me._Label54_0.Name = "_Label54_0"
        Me._Label54_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label54_0.Size = New System.Drawing.Size(145, 17)
        Me._Label54_0.TabIndex = 10
        Me._Label54_0.Text = "Nº Credito:"
        '
        '_Label55_0
        '
        Me._Label55_0.BackColor = System.Drawing.Color.White
        Me._Label55_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label55_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label55_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.SetIndex(Me._Label55_0, CType(0, Short))
        Me._Label55_0.Location = New System.Drawing.Point(16, 122)
        Me._Label55_0.Name = "_Label55_0"
        Me._Label55_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label55_0.Size = New System.Drawing.Size(145, 17)
        Me._Label55_0.TabIndex = 9
        Me._Label55_0.Text = "Monto de Intereses:"
        '
        '_Image10_0
        '
        Me._Image10_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Image10_0.Image = CType(resources.GetObject("_Image10_0.Image"), System.Drawing.Image)
        Me.Image10.SetIndex(Me._Image10_0, CType(0, Short))
        Me._Image10_0.Location = New System.Drawing.Point(392, 24)
        Me._Image10_0.Name = "_Image10_0"
        Me._Image10_0.Size = New System.Drawing.Size(120, 112)
        Me._Image10_0.TabIndex = 18
        Me._Image10_0.TabStop = False
        '
        'MO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 211)
        Me.Controls.Add(Me.MOGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "MO"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistemas - MO :::"
        Me.MOGroupBox.ResumeLayout(False)
        Me.MOGroupBox.PerformLayout()
        CType(Me._Image10_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TMOFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class