<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class BA
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
    Public WithEvents TBATipo As System.Windows.Forms.ComboBox
    Public WithEvents Command19 As System.Windows.Forms.Button
    Public WithEvents Command18 As System.Windows.Forms.Button
    Public WithEvents TBAMonto As System.Windows.Forms.TextBox
    Public WithEvents TBANumero As System.Windows.Forms.TextBox
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Image9 As System.Windows.Forms.PictureBox
    Public WithEvents BAGroupBox As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BA))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BAGroupBox = New System.Windows.Forms.GroupBox()
        Me.TBAFecha = New System.Windows.Forms.DateTimePicker()
        Me.TBATipo = New System.Windows.Forms.ComboBox()
        Me.Command19 = New System.Windows.Forms.Button()
        Me.Command18 = New System.Windows.Forms.Button()
        Me.TBAMonto = New System.Windows.Forms.TextBox()
        Me.TBANumero = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Image9 = New System.Windows.Forms.PictureBox()
        Me.BAGroupBox.SuspendLayout()
        CType(Me.Image9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BAGroupBox
        '
        Me.BAGroupBox.BackColor = System.Drawing.Color.White
        Me.BAGroupBox.Controls.Add(Me.TBAFecha)
        Me.BAGroupBox.Controls.Add(Me.TBATipo)
        Me.BAGroupBox.Controls.Add(Me.Command19)
        Me.BAGroupBox.Controls.Add(Me.Command18)
        Me.BAGroupBox.Controls.Add(Me.TBAMonto)
        Me.BAGroupBox.Controls.Add(Me.TBANumero)
        Me.BAGroupBox.Controls.Add(Me.Label36)
        Me.BAGroupBox.Controls.Add(Me.Label35)
        Me.BAGroupBox.Controls.Add(Me.Label34)
        Me.BAGroupBox.Controls.Add(Me.Label33)
        Me.BAGroupBox.Controls.Add(Me.Image9)
        Me.BAGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BAGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.BAGroupBox.Name = "BAGroupBox"
        Me.BAGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.BAGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BAGroupBox.Size = New System.Drawing.Size(545, 193)
        Me.BAGroupBox.TabIndex = 6
        Me.BAGroupBox.TabStop = False
        Me.BAGroupBox.Text = "::: Bienes Adquiridos :::"
        '
        'TBAFecha
        '
        Me.TBAFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TBAFecha.Location = New System.Drawing.Point(152, 62)
        Me.TBAFecha.Name = "TBAFecha"
        Me.TBAFecha.Size = New System.Drawing.Size(193, 20)
        Me.TBAFecha.TabIndex = 12
        '
        'TBATipo
        '
        Me.TBATipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBATipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.TBATipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBATipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TBATipo.Items.AddRange(New Object() {"1 Propio", "2 En Comodato"})
        Me.TBATipo.Location = New System.Drawing.Point(152, 88)
        Me.TBATipo.Name = "TBATipo"
        Me.TBATipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TBATipo.Size = New System.Drawing.Size(193, 24)
        Me.TBATipo.TabIndex = 2
        '
        'Command19
        '
        Me.Command19.BackColor = System.Drawing.SystemColors.Control
        Me.Command19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command19.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command19.Location = New System.Drawing.Point(432, 160)
        Me.Command19.Name = "Command19"
        Me.Command19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command19.Size = New System.Drawing.Size(89, 25)
        Me.Command19.TabIndex = 5
        Me.Command19.Text = "Cancelar"
        Me.Command19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command19.UseVisualStyleBackColor = False
        '
        'Command18
        '
        Me.Command18.BackColor = System.Drawing.SystemColors.Control
        Me.Command18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command18.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command18.Location = New System.Drawing.Point(336, 160)
        Me.Command18.Name = "Command18"
        Me.Command18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command18.Size = New System.Drawing.Size(89, 25)
        Me.Command18.TabIndex = 4
        Me.Command18.Text = "Guardar"
        Me.Command18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command18.UseVisualStyleBackColor = False
        '
        'TBAMonto
        '
        Me.TBAMonto.AcceptsReturn = True
        Me.TBAMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBAMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBAMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBAMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TBAMonto.Location = New System.Drawing.Point(152, 117)
        Me.TBAMonto.MaxLength = 0
        Me.TBAMonto.Name = "TBAMonto"
        Me.TBAMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TBAMonto.Size = New System.Drawing.Size(369, 22)
        Me.TBAMonto.TabIndex = 3
        '
        'TBANumero
        '
        Me.TBANumero.AcceptsReturn = True
        Me.TBANumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBANumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBANumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBANumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBANumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TBANumero.Location = New System.Drawing.Point(152, 37)
        Me.TBANumero.MaxLength = 0
        Me.TBANumero.Name = "TBANumero"
        Me.TBANumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TBANumero.Size = New System.Drawing.Size(193, 22)
        Me.TBANumero.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.White
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(24, 121)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(121, 17)
        Me.Label36.TabIndex = 10
        Me.Label36.Text = "Monto del Bien:"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(24, 93)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(129, 17)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "Tipo del Bien: "
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(24, 67)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(48, 17)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Fecha:"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(24, 41)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(145, 17)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "No Op. / No de Recibo: "
        '
        'Image9
        '
        Me.Image9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image9.Image = CType(resources.GetObject("Image9.Image"), System.Drawing.Image)
        Me.Image9.Location = New System.Drawing.Point(392, 24)
        Me.Image9.Name = "Image9"
        Me.Image9.Size = New System.Drawing.Size(80, 77)
        Me.Image9.TabIndex = 11
        Me.Image9.TabStop = False
        '
        'BA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 208)
        Me.Controls.Add(Me.BAGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "BA"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - BA :::"
        Me.BAGroupBox.ResumeLayout(False)
        Me.BAGroupBox.PerformLayout()
        CType(Me.Image9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TBAFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class