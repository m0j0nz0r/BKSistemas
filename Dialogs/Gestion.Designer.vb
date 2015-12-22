<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Gestion
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
    Public WithEvents CloseBtn As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents CFecha As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Cuadre As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Cuadre = New System.Windows.Forms.GroupBox()
        Me.CFecha = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Cuadre.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.SystemColors.Control
        Me.CloseBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CloseBtn.Location = New System.Drawing.Point(264, 128)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CloseBtn.Size = New System.Drawing.Size(105, 33)
        Me.CloseBtn.TabIndex = 4
        Me.CloseBtn.Text = "Salir"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(152, 128)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(105, 33)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Consultar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Cuadre
        '
        Me.Cuadre.BackColor = System.Drawing.Color.White
        Me.Cuadre.Controls.Add(Me.CFecha)
        Me.Cuadre.Controls.Add(Me.Label1)
        Me.Cuadre.Controls.Add(Me.Image1)
        Me.Cuadre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cuadre.Location = New System.Drawing.Point(0, 0)
        Me.Cuadre.Name = "Cuadre"
        Me.Cuadre.Padding = New System.Windows.Forms.Padding(0)
        Me.Cuadre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cuadre.Size = New System.Drawing.Size(369, 121)
        Me.Cuadre.TabIndex = 0
        Me.Cuadre.TabStop = False
        Me.Cuadre.Text = "::: Gestion Mensual :::"
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
        Me.Label1.Text = "Seleccione un fecha para consultar la Gestion"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(288, 24)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(64, 78)
        Me.Image1.TabIndex = 3
        Me.Image1.TabStop = False
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(373, 168)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Cuadre)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(241, 287)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Gestion"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema :::"
        Me.Cuadre.ResumeLayout(False)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class