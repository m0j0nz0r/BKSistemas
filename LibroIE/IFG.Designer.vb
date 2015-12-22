<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class IFG
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
    Public WithEvents TIFGNumero As System.Windows.Forms.TextBox
    Public WithEvents TIFGMonto As System.Windows.Forms.TextBox
    Public WithEvents Command10 As System.Windows.Forms.Button
    Public WithEvents Command11 As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents IFGGroupBox As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.IFGGroupBox = New System.Windows.Forms.GroupBox()
        Me.TIFGFecha = New System.Windows.Forms.DateTimePicker()
        Me.TIFGNumero = New System.Windows.Forms.TextBox()
        Me.TIFGMonto = New System.Windows.Forms.TextBox()
        Me.Command10 = New System.Windows.Forms.Button()
        Me.Command11 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.IFGGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'IFGGroupBox
        '
        Me.IFGGroupBox.BackColor = System.Drawing.Color.White
        Me.IFGGroupBox.Controls.Add(Me.TIFGFecha)
        Me.IFGGroupBox.Controls.Add(Me.TIFGNumero)
        Me.IFGGroupBox.Controls.Add(Me.TIFGMonto)
        Me.IFGGroupBox.Controls.Add(Me.Command10)
        Me.IFGGroupBox.Controls.Add(Me.Command11)
        Me.IFGGroupBox.Controls.Add(Me.Label1)
        Me.IFGGroupBox.Controls.Add(Me.Label2)
        Me.IFGGroupBox.Controls.Add(Me.Label20)
        Me.IFGGroupBox.Controls.Add(Me.Label21)
        Me.IFGGroupBox.Controls.Add(Me.Label22)
        Me.IFGGroupBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IFGGroupBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IFGGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.IFGGroupBox.Name = "IFGGroupBox"
        Me.IFGGroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.IFGGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.IFGGroupBox.Size = New System.Drawing.Size(545, 185)
        Me.IFGGroupBox.TabIndex = 0
        Me.IFGGroupBox.TabStop = False
        Me.IFGGroupBox.Text = "::: Ingreso para el Fondo de Gastos :::"
        '
        'TIFGFecha
        '
        Me.TIFGFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TIFGFecha.Location = New System.Drawing.Point(144, 72)
        Me.TIFGFecha.Name = "TIFGFecha"
        Me.TIFGFecha.Size = New System.Drawing.Size(193, 20)
        Me.TIFGFecha.TabIndex = 11
        '
        'TIFGNumero
        '
        Me.TIFGNumero.AcceptsReturn = True
        Me.TIFGNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TIFGNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TIFGNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TIFGNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIFGNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TIFGNumero.Location = New System.Drawing.Point(144, 37)
        Me.TIFGNumero.MaxLength = 0
        Me.TIFGNumero.Name = "TIFGNumero"
        Me.TIFGNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TIFGNumero.Size = New System.Drawing.Size(193, 22)
        Me.TIFGNumero.TabIndex = 4
        '
        'TIFGMonto
        '
        Me.TIFGMonto.AcceptsReturn = True
        Me.TIFGMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TIFGMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TIFGMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TIFGMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIFGMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TIFGMonto.Location = New System.Drawing.Point(144, 109)
        Me.TIFGMonto.MaxLength = 0
        Me.TIFGMonto.Name = "TIFGMonto"
        Me.TIFGMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TIFGMonto.Size = New System.Drawing.Size(361, 22)
        Me.TIFGMonto.TabIndex = 3
        '
        'Command10
        '
        Me.Command10.BackColor = System.Drawing.SystemColors.Control
        Me.Command10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command10.Image = Global.BkSistema.My.Resources.Resources.No
        Me.Command10.Location = New System.Drawing.Point(424, 152)
        Me.Command10.Name = "Command10"
        Me.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command10.Size = New System.Drawing.Size(97, 25)
        Me.Command10.TabIndex = 2
        Me.Command10.Text = "Cancelar"
        Me.Command10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command10.UseVisualStyleBackColor = False
        '
        'Command11
        '
        Me.Command11.BackColor = System.Drawing.SystemColors.Control
        Me.Command11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command11.Image = Global.BkSistema.My.Resources.Resources.Yes
        Me.Command11.Location = New System.Drawing.Point(312, 152)
        Me.Command11.Name = "Command11"
        Me.Command11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command11.Size = New System.Drawing.Size(105, 25)
        Me.Command11.TabIndex = 1
        Me.Command11.Text = "Guardar"
        Me.Command11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Command11.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(360, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Saldo del Fondo para Gastos:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(360, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(161, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(24, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(129, 17)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "No Op. / No Recibo:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(24, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(113, 17)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Fecha:"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(24, 113)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(113, 17)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Monto de Ingreso:"
        '
        'IFG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(559, 200)
        Me.Controls.Add(Me.IFGGroupBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 28)
        Me.Name = "IFG"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::: BKSistema - IFG :::"
        Me.IFGGroupBox.ResumeLayout(False)
        Me.IFGGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TIFGFecha As System.Windows.Forms.DateTimePicker
#End Region
End Class