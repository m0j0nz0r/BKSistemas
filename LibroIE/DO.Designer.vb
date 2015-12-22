<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class DON
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
    Public WithEvents Command17 As System.Windows.Forms.Button
    Public WithEvents Command16 As System.Windows.Forms.Button
    Public WithEvents TDONMonto As System.Windows.Forms.TextBox
    Public WithEvents TDONNumero As System.Windows.Forms.TextBox
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Image7 As System.Windows.Forms.PictureBox
    Public WithEvents DONGroupBox As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DON))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DONGroupBox = New System.Windows.Forms.GroupBox()
        Me.DONFecha = New System.Windows.Forms.DateTimePicker()
        Me.Command17 = New System.Windows.Forms.Button()
        Me.Command16 = New System.Windows.Forms.Button()
        Me.TDONMonto = New System.Windows.Forms.TextBox()
        Me.TDONNumero = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Image7 = New System.Windows.Forms.PictureBox()
        Me.DONGroupBox.SuspendLayout()
        CType(Me.Image7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DONGroupBox
        '
        Me.DONGroupBox.BackColor = System.Drawing.Color.White
        Me.DONGroupBox.Controls.Add(Me.DONFecha)
        Me.DONGroupBox.Controls.Add(Me.Command17)
        Me.DONGroupBox.Controls.Add(Me.Command16)
        Me.DONGroupBox.Controls.Add(Me.TDONMonto)
        Me.DONGroupBox.Controls.Add(Me.TDONNumero)
        Me.DONGroupBox.Controls.Add(Me.Label31)
        Me.DONGroupBox.Controls.Add(Me.Label30)
        Me.DONGroupBox.Controls.Add(Me.Label29)
        Me.DONGroupBox.Controls.Add(Me.Image7)
        Me.DONGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DONGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DONGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.DONGroupBox.Name = "DONGroupBox"
        Me.DONGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.DONGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DONGroupBox.Size = New System.Drawing.Size(545, 193)
        Me.DONGroupBox.TabIndex = 5
        Me.DONGroupBox.TabStop = False
        Me.DONGroupBox.Text = "::: Donaciones :::"
        '
        'DONFecha
        '
        Me.DONFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DONFecha.Location = New System.Drawing.Point(160, 83)
        Me.DONFecha.Name = "DONFecha"
        Me.DONFecha.Size = New System.Drawing.Size(217, 20)
        Me.DONFecha.TabIndex = 12
        '
        'Command17
        '
        Me.Command17.BackColor = System.Drawing.SystemColors.Control
        Me.Command17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command17.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command17.Location = New System.Drawing.Point(352, 160)
        Me.Command17.Name = "Command17"
        Me.Command17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command17.Size = New System.Drawing.Size(89, 25)
        Me.Command17.TabIndex = 3
        Me.Command17.Text = "Guardar"
        Me.Command17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command17.UseVisualStyleBackColor = False
        '
        'Command16
        '
        Me.Command16.BackColor = System.Drawing.SystemColors.Control
        Me.Command16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command16.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command16.Location = New System.Drawing.Point(448, 160)
        Me.Command16.Name = "Command16"
        Me.Command16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command16.Size = New System.Drawing.Size(81, 25)
        Me.Command16.TabIndex = 4
        Me.Command16.Text = "Cancelar"
        Me.Command16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command16.UseVisualStyleBackColor = False
        '
        'TDONMonto
        '
        Me.TDONMonto.AcceptsReturn = True
        Me.TDONMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TDONMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TDONMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TDONMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDONMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TDONMonto.Location = New System.Drawing.Point(160, 116)
        Me.TDONMonto.MaxLength = 0
        Me.TDONMonto.Name = "TDONMonto"
        Me.TDONMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TDONMonto.Size = New System.Drawing.Size(217, 22)
        Me.TDONMonto.TabIndex = 2
        '
        'TDONNumero
        '
        Me.TDONNumero.AcceptsReturn = True
        Me.TDONNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TDONNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TDONNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TDONNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDONNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TDONNumero.Location = New System.Drawing.Point(160, 45)
        Me.TDONNumero.MaxLength = 0
        Me.TDONNumero.Name = "TDONNumero"
        Me.TDONNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TDONNumero.Size = New System.Drawing.Size(217, 22)
        Me.TDONNumero.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(16, 120)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(138, 17)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Monto de la Donación: "
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(16, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(153, 17)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "Fecha:"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(16, 49)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(113, 25)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "No Op. / No Recibo:"
        '
        'Image7
        '
        Me.Image7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image7.Image = CType(resources.GetObject("Image7.Image"), System.Drawing.Image)
        Me.Image7.Location = New System.Drawing.Point(416, 48)
        Me.Image7.Name = "Image7"
        Me.Image7.Size = New System.Drawing.Size(80, 71)
        Me.Image7.TabIndex = 11
        Me.Image7.TabStop = False
        '
        'DON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(561, 208)
        Me.Controls.Add(Me.DONGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "DON"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - DO :::"
        Me.DONGroupBox.ResumeLayout(False)
        Me.DONGroupBox.PerformLayout()
        CType(Me.Image7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DONFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class