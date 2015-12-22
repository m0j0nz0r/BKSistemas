<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class LibroIE
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
    Public WithEvents Libro As DataGridView
    Public WithEvents LCodBk As System.Windows.Forms.Label
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents CCreditos As System.Windows.Forms.ComboBox
    Public WithEvents COtrasOp As System.Windows.Forms.ComboBox
    Public WithEvents FondoGastos As System.Windows.Forms.ComboBox
    Public WithEvents COtrosIE As System.Windows.Forms.ComboBox
    Public WithEvents CCertificados As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label47 As System.Windows.Forms.Label
    Public WithEvents Image8 As System.Windows.Forms.PictureBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Label106 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibroIE))
        Me.Libro = New System.Windows.Forms.DataGridView()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.LCodBk = New System.Windows.Forms.Label()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.CCreditos = New System.Windows.Forms.ComboBox()
        Me.COtrasOp = New System.Windows.Forms.ComboBox()
        Me.FondoGastos = New System.Windows.Forms.ComboBox()
        Me.COtrosIE = New System.Windows.Forms.ComboBox()
        Me.CCertificados = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Image8 = New System.Windows.Forms.PictureBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Saldototal = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Libro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Picture1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.Image8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Libro
        '
        Me.Libro.AllowUserToAddRows = False
        Me.Libro.AllowUserToDeleteRows = False
        Me.Libro.Location = New System.Drawing.Point(8, 88)
        Me.Libro.Name = "Libro"
        Me.Libro.ReadOnly = True
        Me.Libro.Size = New System.Drawing.Size(1008, 289)
        Me.Libro.TabIndex = 7
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Window
        Me.Picture1.BackgroundImage = CType(resources.GetObject("Picture1.BackgroundImage"), System.Drawing.Image)
        Me.Picture1.Controls.Add(Me.LCodBk)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Location = New System.Drawing.Point(0, -24)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(937, 97)
        Me.Picture1.TabIndex = 9
        Me.Picture1.TabStop = True
        '
        'LCodBk
        '
        Me.LCodBk.BackColor = System.Drawing.Color.White
        Me.LCodBk.Cursor = System.Windows.Forms.Cursors.Default
        Me.LCodBk.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCodBk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LCodBk.Location = New System.Drawing.Point(240, 56)
        Me.LCodBk.Name = "LCodBk"
        Me.LCodBk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LCodBk.Size = New System.Drawing.Size(617, 41)
        Me.LCodBk.TabIndex = 10
        Me.LCodBk.Text = "::: Libro de I / E"
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.Color.White
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
        Me.Command3.Location = New System.Drawing.Point(952, 16)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(57, 57)
        Me.Command3.TabIndex = 6
        Me.Command3.Text = "Salir"
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.White
        Me.Frame2.Controls.Add(Me.CCreditos)
        Me.Frame2.Controls.Add(Me.COtrasOp)
        Me.Frame2.Controls.Add(Me.FondoGastos)
        Me.Frame2.Controls.Add(Me.COtrosIE)
        Me.Frame2.Controls.Add(Me.CCertificados)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Controls.Add(Me.Label12)
        Me.Frame2.Controls.Add(Me.Label19)
        Me.Frame2.Controls.Add(Me.Label26)
        Me.Frame2.Controls.Add(Me.Label47)
        Me.Frame2.Controls.Add(Me.Image8)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(16, 392)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(425, 193)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "::: Procesos del Bankomunal :::"
        '
        'CCreditos
        '
        Me.CCreditos.BackColor = System.Drawing.Color.White
        Me.CCreditos.Cursor = System.Windows.Forms.Cursors.Default
        Me.CCreditos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCreditos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CCreditos.Location = New System.Drawing.Point(152, 64)
        Me.CCreditos.Name = "CCreditos"
        Me.CCreditos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CCreditos.Size = New System.Drawing.Size(249, 24)
        Me.CCreditos.TabIndex = 1
        '
        'COtrasOp
        '
        Me.COtrasOp.BackColor = System.Drawing.Color.White
        Me.COtrasOp.Cursor = System.Windows.Forms.Cursors.Default
        Me.COtrasOp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COtrasOp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.COtrasOp.Location = New System.Drawing.Point(152, 136)
        Me.COtrasOp.Name = "COtrasOp"
        Me.COtrasOp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.COtrasOp.Size = New System.Drawing.Size(249, 24)
        Me.COtrasOp.TabIndex = 4
        '
        'FondoGastos
        '
        Me.FondoGastos.BackColor = System.Drawing.Color.White
        Me.FondoGastos.Cursor = System.Windows.Forms.Cursors.Default
        Me.FondoGastos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FondoGastos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FondoGastos.Location = New System.Drawing.Point(152, 112)
        Me.FondoGastos.Name = "FondoGastos"
        Me.FondoGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FondoGastos.Size = New System.Drawing.Size(249, 24)
        Me.FondoGastos.TabIndex = 3
        '
        'COtrosIE
        '
        Me.COtrosIE.BackColor = System.Drawing.Color.White
        Me.COtrosIE.Cursor = System.Windows.Forms.Cursors.Default
        Me.COtrosIE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COtrosIE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.COtrosIE.Location = New System.Drawing.Point(152, 88)
        Me.COtrosIE.Name = "COtrosIE"
        Me.COtrosIE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.COtrosIE.Size = New System.Drawing.Size(249, 24)
        Me.COtrosIE.TabIndex = 2
        '
        'CCertificados
        '
        Me.CCertificados.BackColor = System.Drawing.Color.White
        Me.CCertificados.Cursor = System.Windows.Forms.Cursors.Default
        Me.CCertificados.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCertificados.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CCertificados.Location = New System.Drawing.Point(152, 40)
        Me.CCertificados.Name = "CCertificados"
        Me.CCertificados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CCertificados.Size = New System.Drawing.Size(249, 24)
        Me.CCertificados.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Acciones:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(24, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Otros I/E:"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(24, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(105, 17)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Fondo de Gastos:"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(24, 136)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(121, 17)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Otras Operaciones:"
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(24, 64)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label47.Size = New System.Drawing.Size(73, 17)
        Me.Label47.TabIndex = 11
        Me.Label47.Text = "Creditos:"
        '
        'Image8
        '
        Me.Image8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image8.Image = CType(resources.GetObject("Image8.Image"), System.Drawing.Image)
        Me.Image8.Location = New System.Drawing.Point(24, 40)
        Me.Image8.Name = "Image8"
        Me.Image8.Size = New System.Drawing.Size(100, 100)
        Me.Image8.TabIndex = 16
        Me.Image8.TabStop = False
        '
        'Label106
        '
        Me.Label106.BackColor = System.Drawing.SystemColors.Control
        Me.Label106.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label106.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label106.Location = New System.Drawing.Point(376, 704)
        Me.Label106.Name = "Label106"
        Me.Label106.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label106.Size = New System.Drawing.Size(65, 17)
        Me.Label106.TabIndex = 16
        Me.Label106.Text = "Label5"
        Me.Label106.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(674, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Saldo del Banko:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(808, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(273, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "___________________________________"
        '
        'Saldototal
        '
        Me.Saldototal.Location = New System.Drawing.Point(811, 404)
        Me.Saldototal.Name = "Saldototal"
        Me.Saldototal.Size = New System.Drawing.Size(177, 21)
        Me.Saldototal.TabIndex = 19
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnularToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'AnularToolStripMenuItem
        '
        Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
        Me.AnularToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AnularToolStripMenuItem.Text = "Anular"
        '
        'LibroIE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 729)
        Me.Controls.Add(Me.Saldototal)
        Me.Controls.Add(Me.Libro)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Label106)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(158, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LibroIE"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "::: BKSistemas :::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Libro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Picture1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        CType(Me.Image8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Saldototal As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
#End Region
End Class