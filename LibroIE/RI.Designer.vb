<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class RI
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
    Public WithEvents Command80 As System.Windows.Forms.Button
    Public WithEvents Command81 As System.Windows.Forms.Button
    Public WithEvents TRIMonto As System.Windows.Forms.TextBox
    Public WithEvents TRICredito As System.Windows.Forms.ComboBox
    Public WithEvents TRINumero As System.Windows.Forms.TextBox
    Public WithEvents Label93 As System.Windows.Forms.Label
    Public WithEvents Label90 As System.Windows.Forms.Label
    Public WithEvents Label92 As System.Windows.Forms.Label
    Public WithEvents _Label55_1 As System.Windows.Forms.Label
    Public WithEvents _Label54_1 As System.Windows.Forms.Label
    Public WithEvents _Label53_1 As System.Windows.Forms.Label
    Public WithEvents _Label52_1 As System.Windows.Forms.Label
    Public WithEvents _Image10_3 As System.Windows.Forms.PictureBox
    Public WithEvents Label94 As System.Windows.Forms.Label
    Public WithEvents Label91 As System.Windows.Forms.Label
    Public WithEvents RIGroupBox As System.Windows.Forms.GroupBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RI))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RIGroupBox = New System.Windows.Forms.GroupBox()
        Me.TRIFecha = New System.Windows.Forms.DateTimePicker()
        Me.Command80 = New System.Windows.Forms.Button()
        Me.Command81 = New System.Windows.Forms.Button()
        Me.TRIMonto = New System.Windows.Forms.TextBox()
        Me.TRICredito = New System.Windows.Forms.ComboBox()
        Me.TRINumero = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me._Label55_1 = New System.Windows.Forms.Label()
        Me._Label54_1 = New System.Windows.Forms.Label()
        Me._Label53_1 = New System.Windows.Forms.Label()
        Me._Label52_1 = New System.Windows.Forms.Label()
        Me._Image10_3 = New System.Windows.Forms.PictureBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Image10 = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.Label52 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label53 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label54 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label55 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.RIGroupBox.SuspendLayout()
        CType(Me._Image10_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RIGroupBox
        '
        Me.RIGroupBox.BackColor = System.Drawing.Color.White
        Me.RIGroupBox.Controls.Add(Me.TRIFecha)
        Me.RIGroupBox.Controls.Add(Me.Command80)
        Me.RIGroupBox.Controls.Add(Me.Command81)
        Me.RIGroupBox.Controls.Add(Me.TRIMonto)
        Me.RIGroupBox.Controls.Add(Me.TRICredito)
        Me.RIGroupBox.Controls.Add(Me.TRINumero)
        Me.RIGroupBox.Controls.Add(Me.Label93)
        Me.RIGroupBox.Controls.Add(Me.Label90)
        Me.RIGroupBox.Controls.Add(Me.Label92)
        Me.RIGroupBox.Controls.Add(Me._Label55_1)
        Me.RIGroupBox.Controls.Add(Me._Label54_1)
        Me.RIGroupBox.Controls.Add(Me._Label53_1)
        Me.RIGroupBox.Controls.Add(Me._Label52_1)
        Me.RIGroupBox.Controls.Add(Me._Image10_3)
        Me.RIGroupBox.Controls.Add(Me.Label94)
        Me.RIGroupBox.Controls.Add(Me.Label91)
        Me.RIGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RIGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.RIGroupBox.Name = "RIGroupBox"
        Me.RIGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.RIGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RIGroupBox.Size = New System.Drawing.Size(537, 193)
        Me.RIGroupBox.TabIndex = 8
        Me.RIGroupBox.TabStop = False
        Me.RIGroupBox.Text = "::: Reintegro de Intereses :::"
        '
        'TRIFecha
        '
        Me.TRIFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TRIFecha.Location = New System.Drawing.Point(136, 58)
        Me.TRIFecha.Name = "TRIFecha"
        Me.TRIFecha.Size = New System.Drawing.Size(177, 20)
        Me.TRIFecha.TabIndex = 19
        '
        'Command80
        '
        Me.Command80.BackColor = System.Drawing.SystemColors.Control
        Me.Command80.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command80.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command80.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command80.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command80.Location = New System.Drawing.Point(344, 152)
        Me.Command80.Name = "Command80"
        Me.Command80.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command80.Size = New System.Drawing.Size(81, 25)
        Me.Command80.TabIndex = 4
        Me.Command80.Text = "Guardar"
        Me.Command80.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command80.UseVisualStyleBackColor = False
        '
        'Command81
        '
        Me.Command81.BackColor = System.Drawing.SystemColors.Control
        Me.Command81.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command81.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command81.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command81.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command81.Location = New System.Drawing.Point(432, 152)
        Me.Command81.Name = "Command81"
        Me.Command81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command81.Size = New System.Drawing.Size(88, 25)
        Me.Command81.TabIndex = 7
        Me.Command81.Text = "Cancelar"
        Me.Command81.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command81.UseVisualStyleBackColor = False
        '
        'TRIMonto
        '
        Me.TRIMonto.AcceptsReturn = True
        Me.TRIMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TRIMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRIMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TRIMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRIMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TRIMonto.Location = New System.Drawing.Point(136, 117)
        Me.TRIMonto.MaxLength = 0
        Me.TRIMonto.Name = "TRIMonto"
        Me.TRIMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TRIMonto.Size = New System.Drawing.Size(177, 22)
        Me.TRIMonto.TabIndex = 3
        '
        'TRICredito
        '
        Me.TRICredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TRICredito.Cursor = System.Windows.Forms.Cursors.Default
        Me.TRICredito.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRICredito.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TRICredito.Location = New System.Drawing.Point(136, 88)
        Me.TRICredito.Name = "TRICredito"
        Me.TRICredito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TRICredito.Size = New System.Drawing.Size(177, 24)
        Me.TRICredito.TabIndex = 2
        '
        'TRINumero
        '
        Me.TRINumero.AcceptsReturn = True
        Me.TRINumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TRINumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRINumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TRINumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRINumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TRINumero.Location = New System.Drawing.Point(136, 29)
        Me.TRINumero.MaxLength = 0
        Me.TRINumero.Name = "TRINumero"
        Me.TRINumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TRINumero.Size = New System.Drawing.Size(177, 22)
        Me.TRINumero.TabIndex = 0
        '
        'Label93
        '
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label93.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label93.Location = New System.Drawing.Point(328, 104)
        Me.Label93.Name = "Label93"
        Me.Label93.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label93.Size = New System.Drawing.Size(193, 17)
        Me.Label93.TabIndex = 17
        Me.Label93.Text = "Label67"
        Me.Label93.Visible = False
        '
        'Label90
        '
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label90.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label90.Location = New System.Drawing.Point(328, 32)
        Me.Label90.Name = "Label90"
        Me.Label90.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label90.Size = New System.Drawing.Size(193, 17)
        Me.Label90.TabIndex = 16
        Me.Label90.Text = "Reintegro"
        Me.Label90.Visible = False
        '
        'Label92
        '
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label92.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label92.Location = New System.Drawing.Point(376, 56)
        Me.Label92.Name = "Label92"
        Me.Label92.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label92.Size = New System.Drawing.Size(137, 17)
        Me.Label92.TabIndex = 15
        Me.Label92.Visible = False
        '
        '_Label55_1
        '
        Me._Label55_1.BackColor = System.Drawing.Color.White
        Me._Label55_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label55_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label55_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.SetIndex(Me._Label55_1, CType(1, Short))
        Me._Label55_1.Location = New System.Drawing.Point(16, 121)
        Me._Label55_1.Name = "_Label55_1"
        Me._Label55_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label55_1.Size = New System.Drawing.Size(145, 17)
        Me._Label55_1.TabIndex = 14
        Me._Label55_1.Text = "Monto de Intereses:"
        '
        '_Label54_1
        '
        Me._Label54_1.BackColor = System.Drawing.Color.White
        Me._Label54_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label54_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label54_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.SetIndex(Me._Label54_1, CType(1, Short))
        Me._Label54_1.Location = New System.Drawing.Point(16, 93)
        Me._Label54_1.Name = "_Label54_1"
        Me._Label54_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label54_1.Size = New System.Drawing.Size(145, 17)
        Me._Label54_1.TabIndex = 13
        Me._Label54_1.Text = "Nº Credito:"
        '
        '_Label53_1
        '
        Me._Label53_1.BackColor = System.Drawing.Color.White
        Me._Label53_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label53_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label53_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.SetIndex(Me._Label53_1, CType(1, Short))
        Me._Label53_1.Location = New System.Drawing.Point(16, 56)
        Me._Label53_1.Name = "_Label53_1"
        Me._Label53_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label53_1.Size = New System.Drawing.Size(137, 17)
        Me._Label53_1.TabIndex = 12
        Me._Label53_1.Text = "Fecha:"
        '
        '_Label52_1
        '
        Me._Label52_1.BackColor = System.Drawing.Color.White
        Me._Label52_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label52_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label52_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.SetIndex(Me._Label52_1, CType(1, Short))
        Me._Label52_1.Location = New System.Drawing.Point(16, 32)
        Me._Label52_1.Name = "_Label52_1"
        Me._Label52_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label52_1.Size = New System.Drawing.Size(113, 17)
        Me._Label52_1.TabIndex = 11
        Me._Label52_1.Text = "Nº Op. / Nº Recibo:"
        '
        '_Image10_3
        '
        Me._Image10_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Image10_3.Image = CType(resources.GetObject("_Image10_3.Image"), System.Drawing.Image)
        Me.Image10.SetIndex(Me._Image10_3, CType(3, Short))
        Me._Image10_3.Location = New System.Drawing.Point(400, 16)
        Me._Image10_3.Name = "_Image10_3"
        Me._Image10_3.Size = New System.Drawing.Size(120, 112)
        Me._Image10_3.TabIndex = 18
        Me._Image10_3.TabStop = False
        '
        'Label94
        '
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label94.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label94.Location = New System.Drawing.Point(328, 80)
        Me.Label94.Name = "Label94"
        Me.Label94.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label94.Size = New System.Drawing.Size(185, 17)
        Me.Label94.TabIndex = 10
        Me.Label94.Text = "Label68"
        Me.Label94.Visible = False
        '
        'Label91
        '
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label91.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label91.Location = New System.Drawing.Point(328, 56)
        Me.Label91.Name = "Label91"
        Me.Label91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label91.Size = New System.Drawing.Size(49, 17)
        Me.Label91.TabIndex = 9
        Me.Label91.Text = "Cedula:"
        Me.Label91.Visible = False
        '
        'RI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(552, 209)
        Me.Controls.Add(Me.RIGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(7, 19)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RI"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistemas - Reintegro de Intereses :::"
        Me.RIGroupBox.ResumeLayout(False)
        Me.RIGroupBox.PerformLayout()
        CType(Me._Image10_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TRIFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class