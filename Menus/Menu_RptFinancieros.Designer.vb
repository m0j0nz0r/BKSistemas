<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Menu_RptFinancieros
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
    Public WithEvents BtnConsolidado As System.Windows.Forms.Button
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents BtnClase As System.Windows.Forms.Button
    Public WithEvents BtnTipo As System.Windows.Forms.Button
    Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents BtnAcum As System.Windows.Forms.Button
    Public WithEvents LblClase As System.Windows.Forms.Label
    Public WithEvents LblConsolidado As System.Windows.Forms.Label
    Public WithEvents LblAcum As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents LblTipo As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.Panel
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_RptFinancieros))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnConsolidado = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.Panel()
        Me.BtnClase = New System.Windows.Forms.Button()
        Me.BtnTipo = New System.Windows.Forms.Button()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.BtnAcum = New System.Windows.Forms.Button()
        Me.LblClase = New System.Windows.Forms.Label()
        Me.LblConsolidado = New System.Windows.Forms.Label()
        Me.LblAcum = New System.Windows.Forms.Label()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Picture1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnConsolidado
        '
        Me.BtnConsolidado.BackColor = System.Drawing.Color.White
        Me.BtnConsolidado.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnConsolidado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnConsolidado.Image = CType(resources.GetObject("BtnConsolidado.Image"), System.Drawing.Image)
        Me.BtnConsolidado.Location = New System.Drawing.Point(40, 288)
        Me.BtnConsolidado.Name = "BtnConsolidado"
        Me.BtnConsolidado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnConsolidado.Size = New System.Drawing.Size(41, 41)
        Me.BtnConsolidado.TabIndex = 10
        Me.BtnConsolidado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsolidado.UseVisualStyleBackColor = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me.Label14)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(0, 0)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(633, 97)
        Me.Picture1.TabIndex = 8
        Me.Picture1.TabStop = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(232, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(265, 33)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Reportes Financieros "
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.BtnClase)
        Me.Frame2.Controls.Add(Me.BtnTipo)
        Me.Frame2.Controls.Add(Me.Command3)
        Me.Frame2.Controls.Add(Me.BtnAcum)
        Me.Frame2.Controls.Add(Me.LblClase)
        Me.Frame2.Controls.Add(Me.LblConsolidado)
        Me.Frame2.Controls.Add(Me.LblAcum)
        Me.Frame2.Controls.Add(Me.Image1)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.LblTipo)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Frame2.Location = New System.Drawing.Point(8, 104)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(497, 329)
        Me.Frame2.TabIndex = 0
        '
        'BtnClase
        '
        Me.BtnClase.BackColor = System.Drawing.Color.White
        Me.BtnClase.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnClase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClase.Image = CType(resources.GetObject("BtnClase.Image"), System.Drawing.Image)
        Me.BtnClase.Location = New System.Drawing.Point(32, 88)
        Me.BtnClase.Name = "BtnClase"
        Me.BtnClase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnClase.Size = New System.Drawing.Size(41, 41)
        Me.BtnClase.TabIndex = 12
        Me.BtnClase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClase.UseVisualStyleBackColor = False
        '
        'BtnTipo
        '
        Me.BtnTipo.BackColor = System.Drawing.Color.White
        Me.BtnTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnTipo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnTipo.Image = CType(resources.GetObject("BtnTipo.Image"), System.Drawing.Image)
        Me.BtnTipo.Location = New System.Drawing.Point(32, 40)
        Me.BtnTipo.Name = "BtnTipo"
        Me.BtnTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnTipo.Size = New System.Drawing.Size(41, 41)
        Me.BtnTipo.TabIndex = 3
        Me.BtnTipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTipo.UseVisualStyleBackColor = False
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.Color.White
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
        Me.Command3.Location = New System.Drawing.Point(32, 240)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(41, 41)
        Me.Command3.TabIndex = 2
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = False
        '
        'BtnAcum
        '
        Me.BtnAcum.BackColor = System.Drawing.Color.White
        Me.BtnAcum.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnAcum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAcum.Image = CType(resources.GetObject("BtnAcum.Image"), System.Drawing.Image)
        Me.BtnAcum.Location = New System.Drawing.Point(32, 136)
        Me.BtnAcum.Name = "BtnAcum"
        Me.BtnAcum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAcum.Size = New System.Drawing.Size(41, 41)
        Me.BtnAcum.TabIndex = 1
        Me.BtnAcum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAcum.UseVisualStyleBackColor = False
        '
        'LblClase
        '
        Me.LblClase.BackColor = System.Drawing.Color.White
        Me.LblClase.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblClase.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblClase.Location = New System.Drawing.Point(88, 96)
        Me.LblClase.Name = "LblClase"
        Me.LblClase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblClase.Size = New System.Drawing.Size(257, 25)
        Me.LblClase.TabIndex = 13
        Me.LblClase.Text = "Clasificacion de Creditos x Clase"
        '
        'LblConsolidado
        '
        Me.LblConsolidado.BackColor = System.Drawing.Color.White
        Me.LblConsolidado.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblConsolidado.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsolidado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblConsolidado.Location = New System.Drawing.Point(88, 200)
        Me.LblConsolidado.Name = "LblConsolidado"
        Me.LblConsolidado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblConsolidado.Size = New System.Drawing.Size(209, 25)
        Me.LblConsolidado.TabIndex = 11
        Me.LblConsolidado.Text = "Reporte Consolidado"
        '
        'LblAcum
        '
        Me.LblAcum.BackColor = System.Drawing.Color.White
        Me.LblAcum.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblAcum.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAcum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblAcum.Location = New System.Drawing.Point(88, 144)
        Me.LblAcum.Name = "LblAcum"
        Me.LblAcum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblAcum.Size = New System.Drawing.Size(209, 25)
        Me.LblAcum.TabIndex = 7
        Me.LblAcum.Text = "Movimiento Acumulado"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(256, 128)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(376, 400)
        Me.Image1.TabIndex = 14
        Me.Image1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(72, -16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(265, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Datos del Bankomunal "
        '
        'LblTipo
        '
        Me.LblTipo.BackColor = System.Drawing.Color.White
        Me.LblTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTipo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTipo.Location = New System.Drawing.Point(88, 48)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblTipo.Size = New System.Drawing.Size(300, 25)
        Me.LblTipo.TabIndex = 5
        Me.LblTipo.Text = "Clasificacion de Creditos x Tipo"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(88, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(145, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Volver al Menu"
        '
        'Menu_RptFinancieros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(511, 439)
        Me.Controls.Add(Me.BtnConsolidado)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 30)
        Me.Name = "Menu_RptFinancieros"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Reportes Financieros ::.."
        Me.Picture1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class