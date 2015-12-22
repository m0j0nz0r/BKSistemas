<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Cuadre
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
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents CFecha As System.Windows.Forms.ComboBox
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents CuadreGroupBox As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuadre))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.CuadreGroupBox = New System.Windows.Forms.GroupBox()
        Me.CFecha = New System.Windows.Forms.ComboBox()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CuadreGroupBox.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(288, 144)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(89, 33)
        Me.Command2.TabIndex = 4
        Me.Command2.Text = "Salir"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(192, 144)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(97, 33)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Aceptar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'CuadreGroupBox
        '
        Me.CuadreGroupBox.BackColor = System.Drawing.Color.White
        Me.CuadreGroupBox.Controls.Add(Me.CFecha)
        Me.CuadreGroupBox.Controls.Add(Me.Image1)
        Me.CuadreGroupBox.Controls.Add(Me.Label1)
        Me.CuadreGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CuadreGroupBox.Location = New System.Drawing.Point(8, 16)
        Me.CuadreGroupBox.Name = "CuadreGroupBox"
        Me.CuadreGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.CuadreGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CuadreGroupBox.Size = New System.Drawing.Size(369, 121)
        Me.CuadreGroupBox.TabIndex = 0
        Me.CuadreGroupBox.TabStop = False
        Me.CuadreGroupBox.Text = "::: Proceso de Cuadre :::"
        '
        'CFecha
        '
        Me.CFecha.BackColor = System.Drawing.SystemColors.Window
        Me.CFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.CFecha.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFecha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CFecha.Location = New System.Drawing.Point(16, 64)
        Me.CFecha.Name = "CFecha"
        Me.CFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CFecha.Size = New System.Drawing.Size(257, 24)
        Me.CFecha.TabIndex = 1
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(288, 24)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(64, 78)
        Me.Image1.TabIndex = 2
        Me.Image1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(273, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione un mes para el proceso de Cuadre"
        '
        'Cuadref
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(384, 181)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.CuadreGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(270, 294)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cuadref"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistemas :::"
        Me.CuadreGroupBox.ResumeLayout(False)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class