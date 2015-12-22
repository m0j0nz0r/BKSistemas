<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class UR
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
    Public WithEvents TURNumero As System.Windows.Forms.TextBox
    Public WithEvents Command5 As System.Windows.Forms.Button
    Public WithEvents Command4 As System.Windows.Forms.Button
    Public WithEvents TURMonto As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Image3 As System.Windows.Forms.PictureBox
    Public WithEvents URGroupBox As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UR))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.URGroupBox = New System.Windows.Forms.GroupBox()
        Me.TURFecha = New System.Windows.Forms.DateTimePicker()
        Me.TURNumero = New System.Windows.Forms.TextBox()
        Me.Command5 = New System.Windows.Forms.Button()
        Me.Command4 = New System.Windows.Forms.Button()
        Me.TURMonto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Image3 = New System.Windows.Forms.PictureBox()
        Me.URGroupBox.SuspendLayout()
        CType(Me.Image3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'URGroupBox
        '
        Me.URGroupBox.BackColor = System.Drawing.Color.White
        Me.URGroupBox.Controls.Add(Me.TURFecha)
        Me.URGroupBox.Controls.Add(Me.TURNumero)
        Me.URGroupBox.Controls.Add(Me.Command5)
        Me.URGroupBox.Controls.Add(Me.Command4)
        Me.URGroupBox.Controls.Add(Me.TURMonto)
        Me.URGroupBox.Controls.Add(Me.Label11)
        Me.URGroupBox.Controls.Add(Me.Label10)
        Me.URGroupBox.Controls.Add(Me.Label9)
        Me.URGroupBox.Controls.Add(Me.Image3)
        Me.URGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.URGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.URGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.URGroupBox.Name = "URGroupBox"
        Me.URGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.URGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.URGroupBox.Size = New System.Drawing.Size(545, 193)
        Me.URGroupBox.TabIndex = 7
        Me.URGroupBox.TabStop = False
        Me.URGroupBox.Text = "::: Ganancias Repartidas :::"
        '
        'TURFecha
        '
        Me.TURFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TURFecha.Location = New System.Drawing.Point(160, 80)
        Me.TURFecha.Name = "TURFecha"
        Me.TURFecha.Size = New System.Drawing.Size(225, 20)
        Me.TURFecha.TabIndex = 12
        '
        'TURNumero
        '
        Me.TURNumero.AcceptsReturn = True
        Me.TURNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TURNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TURNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TURNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TURNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TURNumero.Location = New System.Drawing.Point(160, 45)
        Me.TURNumero.MaxLength = 0
        Me.TURNumero.Name = "TURNumero"
        Me.TURNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TURNumero.Size = New System.Drawing.Size(225, 22)
        Me.TURNumero.TabIndex = 0
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.SystemColors.Control
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command5.Location = New System.Drawing.Point(320, 152)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(97, 25)
        Me.Command5.TabIndex = 3
        Me.Command5.Text = "Guardar"
        Me.Command5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command5.UseVisualStyleBackColor = False
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command4.Location = New System.Drawing.Point(424, 152)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(89, 25)
        Me.Command4.TabIndex = 6
        Me.Command4.Text = "Cancelar"
        Me.Command4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command4.UseVisualStyleBackColor = False
        '
        'TURMonto
        '
        Me.TURMonto.AcceptsReturn = True
        Me.TURMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TURMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TURMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TURMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TURMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TURMonto.Location = New System.Drawing.Point(160, 117)
        Me.TURMonto.MaxLength = 0
        Me.TURMonto.Name = "TURMonto"
        Me.TURMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TURMonto.Size = New System.Drawing.Size(345, 22)
        Me.TURMonto.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(24, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(129, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "No Op. / No Recibo: "
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(24, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(145, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Monto:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(24, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(145, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fecha:"
        '
        'Image3
        '
        Me.Image3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image3.Image = CType(resources.GetObject("Image3.Image"), System.Drawing.Image)
        Me.Image3.Location = New System.Drawing.Point(400, 40)
        Me.Image3.Name = "Image3"
        Me.Image3.Size = New System.Drawing.Size(100, 54)
        Me.Image3.TabIndex = 11
        Me.Image3.TabStop = False
        '
        'UR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 209)
        Me.Controls.Add(Me.URGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UR"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - UR :::"
        Me.URGroupBox.ResumeLayout(False)
        Me.URGroupBox.PerformLayout()
        CType(Me.Image3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TURFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class