<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FilterDlg
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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.CheckAll = New System.Windows.Forms.RadioButton()
        Me.CBBanko = New System.Windows.Forms.ComboBox()
        Me.CheckBanko = New System.Windows.Forms.RadioButton()
        Me.CheckProvince = New System.Windows.Forms.RadioButton()
        Me.CheckState = New System.Windows.Forms.RadioButton()
        Me.CheckCountry = New System.Windows.Forms.RadioButton()
        Me.CheckProyect = New System.Windows.Forms.RadioButton()
        Me.CBProvince = New System.Windows.Forms.ComboBox()
        Me.TblMunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBState = New System.Windows.Forms.ComboBox()
        Me.TblEstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBCountry = New System.Windows.Forms.ComboBox()
        Me.TblPaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBProyect = New System.Windows.Forms.ComboBox()
        Me.TblProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblBankoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Frame1.SuspendLayout()
        CType(Me.TblMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBankoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.White
        Me.Frame1.Controls.Add(Me.CheckAll)
        Me.Frame1.Controls.Add(Me.CBBanko)
        Me.Frame1.Controls.Add(Me.CheckBanko)
        Me.Frame1.Controls.Add(Me.CheckProvince)
        Me.Frame1.Controls.Add(Me.CheckState)
        Me.Frame1.Controls.Add(Me.CheckCountry)
        Me.Frame1.Controls.Add(Me.CheckProyect)
        Me.Frame1.Controls.Add(Me.CBProvince)
        Me.Frame1.Controls.Add(Me.CBState)
        Me.Frame1.Controls.Add(Me.CBCountry)
        Me.Frame1.Controls.Add(Me.CBProyect)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(333, 217)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        '
        'CheckAll
        '
        Me.CheckAll.AutoSize = True
        Me.CheckAll.Location = New System.Drawing.Point(22, 180)
        Me.CheckAll.Name = "CheckAll"
        Me.CheckAll.Size = New System.Drawing.Size(55, 17)
        Me.CheckAll.TabIndex = 15
        Me.CheckAll.TabStop = True
        Me.CheckAll.Text = "Todos"
        Me.CheckAll.UseVisualStyleBackColor = True
        '
        'CBBanko
        '
        Me.CBBanko.FormattingEnabled = True
        Me.CBBanko.Location = New System.Drawing.Point(119, 156)
        Me.CBBanko.Name = "CBBanko"
        Me.CBBanko.Size = New System.Drawing.Size(211, 21)
        Me.CBBanko.TabIndex = 14
        '
        'CheckBanko
        '
        Me.CheckBanko.AutoSize = True
        Me.CheckBanko.Location = New System.Drawing.Point(22, 157)
        Me.CheckBanko.Name = "CheckBanko"
        Me.CheckBanko.Size = New System.Drawing.Size(59, 17)
        Me.CheckBanko.TabIndex = 13
        Me.CheckBanko.TabStop = True
        Me.CheckBanko.Text = "Banko:"
        Me.CheckBanko.UseVisualStyleBackColor = True
        '
        'CheckProvince
        '
        Me.CheckProvince.AutoSize = True
        Me.CheckProvince.Location = New System.Drawing.Point(22, 129)
        Me.CheckProvince.Name = "CheckProvince"
        Me.CheckProvince.Size = New System.Drawing.Size(73, 17)
        Me.CheckProvince.TabIndex = 12
        Me.CheckProvince.TabStop = True
        Me.CheckProvince.Text = "Municipio:"
        Me.CheckProvince.UseVisualStyleBackColor = True
        '
        'CheckState
        '
        Me.CheckState.AutoSize = True
        Me.CheckState.Location = New System.Drawing.Point(22, 101)
        Me.CheckState.Name = "CheckState"
        Me.CheckState.Size = New System.Drawing.Size(61, 17)
        Me.CheckState.TabIndex = 11
        Me.CheckState.TabStop = True
        Me.CheckState.Text = "Estado:"
        Me.CheckState.UseVisualStyleBackColor = True
        '
        'CheckCountry
        '
        Me.CheckCountry.AutoSize = True
        Me.CheckCountry.Location = New System.Drawing.Point(22, 73)
        Me.CheckCountry.Name = "CheckCountry"
        Me.CheckCountry.Size = New System.Drawing.Size(50, 17)
        Me.CheckCountry.TabIndex = 10
        Me.CheckCountry.TabStop = True
        Me.CheckCountry.Text = "País:"
        Me.CheckCountry.UseVisualStyleBackColor = True
        '
        'CheckProyect
        '
        Me.CheckProyect.AutoSize = True
        Me.CheckProyect.Location = New System.Drawing.Point(22, 45)
        Me.CheckProyect.Name = "CheckProyect"
        Me.CheckProyect.Size = New System.Drawing.Size(70, 17)
        Me.CheckProyect.TabIndex = 9
        Me.CheckProyect.TabStop = True
        Me.CheckProyect.Text = "Proyecto:"
        Me.CheckProyect.UseVisualStyleBackColor = True
        '
        'CBProvince
        '
        Me.CBProvince.DataSource = Me.TblMunicipiosBindingSource
        Me.CBProvince.DisplayMember = "Municipios"
        Me.CBProvince.FormattingEnabled = True
        Me.CBProvince.Location = New System.Drawing.Point(118, 128)
        Me.CBProvince.Name = "CBProvince"
        Me.CBProvince.Size = New System.Drawing.Size(211, 21)
        Me.CBProvince.TabIndex = 8
        Me.CBProvince.ValueMember = "ID"
        '
        'CBState
        '
        Me.CBState.DataSource = Me.TblEstadosBindingSource
        Me.CBState.DisplayMember = "Nombre"
        Me.CBState.FormattingEnabled = True
        Me.CBState.Location = New System.Drawing.Point(118, 100)
        Me.CBState.Name = "CBState"
        Me.CBState.Size = New System.Drawing.Size(211, 21)
        Me.CBState.TabIndex = 7
        Me.CBState.ValueMember = "ID"
        '
        'CBCountry
        '
        Me.CBCountry.DataSource = Me.TblPaisesBindingSource
        Me.CBCountry.DisplayMember = "Nombre"
        Me.CBCountry.FormattingEnabled = True
        Me.CBCountry.Location = New System.Drawing.Point(118, 72)
        Me.CBCountry.Name = "CBCountry"
        Me.CBCountry.Size = New System.Drawing.Size(211, 21)
        Me.CBCountry.TabIndex = 6
        Me.CBCountry.ValueMember = "ID"
        '
        'CBProyect
        '
        Me.CBProyect.DataSource = Me.TblProyectosBindingSource
        Me.CBProyect.DisplayMember = "Nombre"
        Me.CBProyect.FormattingEnabled = True
        Me.CBProyect.Location = New System.Drawing.Point(118, 44)
        Me.CBProyect.Name = "CBProyect"
        Me.CBProyect.Size = New System.Drawing.Size(211, 21)
        Me.CBProyect.TabIndex = 5
        Me.CBProyect.ValueMember = "ID"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(227, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione rango de la consulta: "
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(252, 223)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Cancelar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(165, 223)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(81, 33)
        Me.Command2.TabIndex = 0
        Me.Command2.Text = "Aceptar"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'FilterDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(345, 260)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Command2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(459, 307)
        Me.Name = "FilterDlg"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "..:: Reportes ::.."
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.TblMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBankoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBBanko As System.Windows.Forms.ComboBox
    Friend WithEvents TblBankoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckBanko As System.Windows.Forms.RadioButton
    Friend WithEvents CheckProvince As System.Windows.Forms.RadioButton
    Friend WithEvents CheckState As System.Windows.Forms.RadioButton
    Friend WithEvents CheckCountry As System.Windows.Forms.RadioButton
    Friend WithEvents CheckProyect As System.Windows.Forms.RadioButton
    Friend WithEvents CBProvince As System.Windows.Forms.ComboBox
    Friend WithEvents TblMunicipiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CBState As System.Windows.Forms.ComboBox
    Friend WithEvents TblEstadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CBCountry As System.Windows.Forms.ComboBox
    Friend WithEvents TblPaisesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CBProyect As System.Windows.Forms.ComboBox
    Friend WithEvents TblProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckAll As System.Windows.Forms.RadioButton
#End Region
End Class