<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class LC
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
    Public WithEvents TLCNumero As System.Windows.Forms.TextBox
    Public WithEvents TLCMonto As System.Windows.Forms.TextBox
    Public WithEvents Command24 As System.Windows.Forms.Button
    Public WithEvents Command25 As System.Windows.Forms.Button
    Public WithEvents TLCCedula As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label43 As System.Windows.Forms.Label
    Public WithEvents Label44 As System.Windows.Forms.Label
    Public WithEvents Label45 As System.Windows.Forms.Label
    Public WithEvents Label46 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Label59 As System.Windows.Forms.Label
    Public WithEvents LCGoupBox As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LC))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LCGoupBox = New System.Windows.Forms.GroupBox()
        Me.TLCFecha = New System.Windows.Forms.DateTimePicker()
        Me.TLCNumero = New System.Windows.Forms.TextBox()
        Me.TLCMonto = New System.Windows.Forms.TextBox()
        Me.Command24 = New System.Windows.Forms.Button()
        Me.Command25 = New System.Windows.Forms.Button()
        Me.TLCCedula = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.LCGoupBox.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LCGoupBox
        '
        Me.LCGoupBox.BackColor = System.Drawing.Color.White
        Me.LCGoupBox.Controls.Add(Me.TLCFecha)
        Me.LCGoupBox.Controls.Add(Me.TLCNumero)
        Me.LCGoupBox.Controls.Add(Me.TLCMonto)
        Me.LCGoupBox.Controls.Add(Me.Command24)
        Me.LCGoupBox.Controls.Add(Me.Command25)
        Me.LCGoupBox.Controls.Add(Me.TLCCedula)
        Me.LCGoupBox.Controls.Add(Me.Label1)
        Me.LCGoupBox.Controls.Add(Me.Label43)
        Me.LCGoupBox.Controls.Add(Me.Label44)
        Me.LCGoupBox.Controls.Add(Me.Label45)
        Me.LCGoupBox.Controls.Add(Me.Label46)
        Me.LCGoupBox.Controls.Add(Me.Image1)
        Me.LCGoupBox.Controls.Add(Me.Label59)
        Me.LCGoupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCGoupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LCGoupBox.Location = New System.Drawing.Point(8, 8)
        Me.LCGoupBox.Name = "LCGoupBox"
        Me.LCGoupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.LCGoupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LCGoupBox.Size = New System.Drawing.Size(545, 193)
        Me.LCGoupBox.TabIndex = 8
        Me.LCGoupBox.TabStop = False
        Me.LCGoupBox.Text = "::: Liquidacion de Acciones :::"
        '
        'TLCFecha
        '
        Me.TLCFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TLCFecha.Location = New System.Drawing.Point(152, 67)
        Me.TLCFecha.Name = "TLCFecha"
        Me.TLCFecha.Size = New System.Drawing.Size(241, 20)
        Me.TLCFecha.TabIndex = 16
        '
        'TLCNumero
        '
        Me.TLCNumero.AcceptsReturn = True
        Me.TLCNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TLCNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TLCNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TLCNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLCNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TLCNumero.Location = New System.Drawing.Point(152, 37)
        Me.TLCNumero.MaxLength = 0
        Me.TLCNumero.Name = "TLCNumero"
        Me.TLCNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TLCNumero.Size = New System.Drawing.Size(241, 22)
        Me.TLCNumero.TabIndex = 0
        '
        'TLCMonto
        '
        Me.TLCMonto.AcceptsReturn = True
        Me.TLCMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TLCMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TLCMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TLCMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLCMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TLCMonto.Location = New System.Drawing.Point(152, 125)
        Me.TLCMonto.MaxLength = 0
        Me.TLCMonto.Name = "TLCMonto"
        Me.TLCMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TLCMonto.Size = New System.Drawing.Size(153, 22)
        Me.TLCMonto.TabIndex = 3
        '
        'Command24
        '
        Me.Command24.BackColor = System.Drawing.SystemColors.Control
        Me.Command24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command24.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command24.Location = New System.Drawing.Point(360, 160)
        Me.Command24.Name = "Command24"
        Me.Command24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command24.Size = New System.Drawing.Size(81, 25)
        Me.Command24.TabIndex = 4
        Me.Command24.Text = "Guardar"
        Me.Command24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command24.UseVisualStyleBackColor = False
        '
        'Command25
        '
        Me.Command25.BackColor = System.Drawing.SystemColors.Control
        Me.Command25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command25.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command25.Location = New System.Drawing.Point(448, 160)
        Me.Command25.Name = "Command25"
        Me.Command25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command25.Size = New System.Drawing.Size(81, 25)
        Me.Command25.TabIndex = 7
        Me.Command25.Text = "Cancelar"
        Me.Command25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command25.UseVisualStyleBackColor = False
        '
        'TLCCedula
        '
        Me.TLCCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TLCCedula.Cursor = System.Windows.Forms.Cursors.Default
        Me.TLCCedula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLCCedula.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TLCCedula.Location = New System.Drawing.Point(152, 96)
        Me.TLCCedula.Name = "TLCCedula"
        Me.TLCCedula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TLCCedula.Size = New System.Drawing.Size(153, 24)
        Me.TLCCedula.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(320, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(209, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.White
        Me.Label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label43.Location = New System.Drawing.Point(24, 40)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label43.Size = New System.Drawing.Size(113, 17)
        Me.Label43.TabIndex = 13
        Me.Label43.Text = "No Op. / No Recibo"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label44.Location = New System.Drawing.Point(24, 72)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label44.Size = New System.Drawing.Size(121, 17)
        Me.Label44.TabIndex = 12
        Me.Label44.Text = "Fecha:"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.White
        Me.Label45.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(24, 104)
        Me.Label45.Name = "Label45"
        Me.Label45.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label45.Size = New System.Drawing.Size(121, 17)
        Me.Label45.TabIndex = 11
        Me.Label45.Text = "Cedula del Socio: "
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.White
        Me.Label46.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label46.Location = New System.Drawing.Point(24, 128)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label46.Size = New System.Drawing.Size(113, 17)
        Me.Label46.TabIndex = 10
        Me.Label46.Text = "Monto:"
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.White
        Me.Label59.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label59.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Location = New System.Drawing.Point(320, 96)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(201, 17)
        Me.Label59.TabIndex = 9
        Me.Label59.Text = "Label59"
        Me.Label59.Visible = False
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(416, 32)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(100, 54)
        Me.Image1.TabIndex = 15
        Me.Image1.TabStop = False
        '
        'LC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(561, 210)
        Me.Controls.Add(Me.LCGoupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "LC"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistemas - LC :::"
        Me.LCGoupBox.ResumeLayout(False)
        Me.LCGoupBox.PerformLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TLCFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class