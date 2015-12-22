<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class ORD
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
    Public WithEvents Command27 As System.Windows.Forms.Button
    Public WithEvents Command26 As System.Windows.Forms.Button
    Public WithEvents TORMonto As System.Windows.Forms.TextBox
    Public WithEvents CORCredito As System.Windows.Forms.ComboBox
    Public WithEvents TORNumero As System.Windows.Forms.TextBox
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label62 As System.Windows.Forms.Label
    Public WithEvents Label63 As System.Windows.Forms.Label
    Public WithEvents Label64 As System.Windows.Forms.Label
    Public WithEvents Label69 As System.Windows.Forms.Label
    Public WithEvents Label51 As System.Windows.Forms.Label
    Public WithEvents Label50 As System.Windows.Forms.Label
    Public WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents Label48 As System.Windows.Forms.Label
    Public WithEvents _Image10_2 As System.Windows.Forms.PictureBox
    Public WithEvents ORDGroupBox As System.Windows.Forms.GroupBox
    Public WithEvents Image10 As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ORD))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ORDGroupBox = New System.Windows.Forms.GroupBox()
        Me.TORFecha = New System.Windows.Forms.DateTimePicker()
        Me.Command27 = New System.Windows.Forms.Button()
        Me.Command26 = New System.Windows.Forms.Button()
        Me.TORMonto = New System.Windows.Forms.TextBox()
        Me.CORCredito = New System.Windows.Forms.ComboBox()
        Me.TORNumero = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me._Image10_2 = New System.Windows.Forms.PictureBox()
        Me.Image10 = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(Me.components)
        Me.ORDGroupBox.SuspendLayout()
        CType(Me._Image10_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ORDGroupBox
        '
        Me.ORDGroupBox.BackColor = System.Drawing.Color.White
        Me.ORDGroupBox.Controls.Add(Me.TORFecha)
        Me.ORDGroupBox.Controls.Add(Me.Command27)
        Me.ORDGroupBox.Controls.Add(Me.Command26)
        Me.ORDGroupBox.Controls.Add(Me.TORMonto)
        Me.ORDGroupBox.Controls.Add(Me.CORCredito)
        Me.ORDGroupBox.Controls.Add(Me.TORNumero)
        Me.ORDGroupBox.Controls.Add(Me.Label32)
        Me.ORDGroupBox.Controls.Add(Me.Label62)
        Me.ORDGroupBox.Controls.Add(Me.Label63)
        Me.ORDGroupBox.Controls.Add(Me.Label64)
        Me.ORDGroupBox.Controls.Add(Me.Label69)
        Me.ORDGroupBox.Controls.Add(Me.Label51)
        Me.ORDGroupBox.Controls.Add(Me.Label50)
        Me.ORDGroupBox.Controls.Add(Me.Label49)
        Me.ORDGroupBox.Controls.Add(Me.Label48)
        Me.ORDGroupBox.Controls.Add(Me._Image10_2)
        Me.ORDGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORDGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ORDGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.ORDGroupBox.Name = "ORDGroupBox"
        Me.ORDGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.ORDGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ORDGroupBox.Size = New System.Drawing.Size(545, 193)
        Me.ORDGroupBox.TabIndex = 8
        Me.ORDGroupBox.TabStop = False
        Me.ORDGroupBox.Text = "::: Intereses Ordinarios :::"
        '
        'TORFecha
        '
        Me.TORFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TORFecha.Location = New System.Drawing.Point(136, 64)
        Me.TORFecha.Name = "TORFecha"
        Me.TORFecha.Size = New System.Drawing.Size(185, 20)
        Me.TORFecha.TabIndex = 19
        '
        'Command27
        '
        Me.Command27.BackColor = System.Drawing.SystemColors.Control
        Me.Command27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command27.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command27.Location = New System.Drawing.Point(448, 160)
        Me.Command27.Name = "Command27"
        Me.Command27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command27.Size = New System.Drawing.Size(81, 25)
        Me.Command27.TabIndex = 7
        Me.Command27.Text = "Cancelar"
        Me.Command27.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command27.UseVisualStyleBackColor = False
        '
        'Command26
        '
        Me.Command26.BackColor = System.Drawing.SystemColors.Control
        Me.Command26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command26.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command26.Location = New System.Drawing.Point(360, 160)
        Me.Command26.Name = "Command26"
        Me.Command26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command26.Size = New System.Drawing.Size(81, 25)
        Me.Command26.TabIndex = 4
        Me.Command26.Text = "Guardar"
        Me.Command26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command26.UseVisualStyleBackColor = False
        '
        'TORMonto
        '
        Me.TORMonto.AcceptsReturn = True
        Me.TORMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TORMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TORMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TORMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TORMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TORMonto.Location = New System.Drawing.Point(136, 125)
        Me.TORMonto.MaxLength = 0
        Me.TORMonto.Name = "TORMonto"
        Me.TORMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TORMonto.Size = New System.Drawing.Size(185, 22)
        Me.TORMonto.TabIndex = 3
        '
        'CORCredito
        '
        Me.CORCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CORCredito.Cursor = System.Windows.Forms.Cursors.Default
        Me.CORCredito.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CORCredito.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CORCredito.Location = New System.Drawing.Point(136, 96)
        Me.CORCredito.Name = "CORCredito"
        Me.CORCredito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CORCredito.Size = New System.Drawing.Size(185, 24)
        Me.CORCredito.TabIndex = 2
        '
        'TORNumero
        '
        Me.TORNumero.AcceptsReturn = True
        Me.TORNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TORNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TORNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TORNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TORNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TORNumero.Location = New System.Drawing.Point(136, 32)
        Me.TORNumero.MaxLength = 0
        Me.TORNumero.Name = "TORNumero"
        Me.TORNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TORNumero.Size = New System.Drawing.Size(185, 22)
        Me.TORNumero.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(336, 32)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(185, 17)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "Label32"
        Me.Label32.Visible = False
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label62.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label62.Location = New System.Drawing.Point(336, 80)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(185, 17)
        Me.Label62.TabIndex = 16
        Me.Label62.Text = "Label62"
        Me.Label62.Visible = False
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label63.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(336, 104)
        Me.Label63.Name = "Label63"
        Me.Label63.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label63.Size = New System.Drawing.Size(185, 25)
        Me.Label63.TabIndex = 15
        Me.Label63.Text = "Label63"
        Me.Label63.Visible = False
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label64.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(384, 56)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label64.Size = New System.Drawing.Size(113, 17)
        Me.Label64.TabIndex = 14
        Me.Label64.Text = "Label64"
        Me.Label64.Visible = False
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label69.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label69.Location = New System.Drawing.Point(336, 56)
        Me.Label69.Name = "Label69"
        Me.Label69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label69.Size = New System.Drawing.Size(49, 17)
        Me.Label69.TabIndex = 13
        Me.Label69.Text = "Cedula:"
        Me.Label69.Visible = False
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.White
        Me.Label51.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label51.Location = New System.Drawing.Point(24, 129)
        Me.Label51.Name = "Label51"
        Me.Label51.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label51.Size = New System.Drawing.Size(121, 17)
        Me.Label51.TabIndex = 12
        Me.Label51.Text = "Monto Intereses:"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(24, 101)
        Me.Label50.Name = "Label50"
        Me.Label50.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label50.Size = New System.Drawing.Size(97, 17)
        Me.Label50.TabIndex = 11
        Me.Label50.Text = "Nº Credito:"
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.White
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(24, 69)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label49.Size = New System.Drawing.Size(81, 17)
        Me.Label49.TabIndex = 10
        Me.Label49.Text = "Fecha:"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.White
        Me.Label48.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label48.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(24, 36)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label48.Size = New System.Drawing.Size(193, 17)
        Me.Label48.TabIndex = 9
        Me.Label48.Text = "Nº Op. / Nº Recibo:"
        '
        '_Image10_2
        '
        Me._Image10_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Image10_2.Image = CType(resources.GetObject("_Image10_2.Image"), System.Drawing.Image)
        Me.Image10.SetIndex(Me._Image10_2, CType(2, Short))
        Me._Image10_2.Location = New System.Drawing.Point(408, 24)
        Me._Image10_2.Name = "_Image10_2"
        Me._Image10_2.Size = New System.Drawing.Size(120, 112)
        Me._Image10_2.TabIndex = 18
        Me._Image10_2.TabStop = False
        '
        'ORD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(560, 209)
        Me.Controls.Add(Me.ORDGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "ORD"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistemas - OR :::"
        Me.ORDGroupBox.ResumeLayout(False)
        Me.ORDGroupBox.PerformLayout()
        CType(Me._Image10_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TORFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class