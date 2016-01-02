<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaisDlg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProyectList = New System.Windows.Forms.ComboBox()
        Me.MainDS = New BkSistema.MainDS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChkAgain = New System.Windows.Forms.CheckBox()
        Me.TblPaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'ProyectList
        '
        Me.ProyectList.DataSource = Me.TblPaisesBindingSource
        Me.ProyectList.DisplayMember = "Nombre"
        Me.ProyectList.FormattingEnabled = True
        Me.ProyectList.Location = New System.Drawing.Point(13, 30)
        Me.ProyectList.Name = "ProyectList"
        Me.ProyectList.Size = New System.Drawing.Size(210, 21)
        Me.ProyectList.TabIndex = 1
        Me.ProyectList.ValueMember = "ID"
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "MainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChkAgain
        '
        Me.ChkAgain.AutoSize = True
        Me.ChkAgain.Checked = True
        Me.ChkAgain.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAgain.Location = New System.Drawing.Point(12, 57)
        Me.ChkAgain.Name = "ChkAgain"
        Me.ChkAgain.Size = New System.Drawing.Size(153, 17)
        Me.ChkAgain.TabIndex = 3
        Me.ChkAgain.Text = "No preguntarme de nuevo."
        Me.ChkAgain.UseVisualStyleBackColor = True
        '
        'TblPaisesBindingSource
        '
        Me.TblPaisesBindingSource.DataMember = "TblPaises"
        Me.TblPaisesBindingSource.DataSource = Me.MainDS
        '
        'PaisDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 114)
        Me.Controls.Add(Me.ChkAgain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProyectList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaisDlg"
        Me.Text = "Pais"
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProyectList As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MainDS As BkSistema.MainDS
    Friend WithEvents ChkAgain As System.Windows.Forms.CheckBox
    Friend WithEvents TblPaisesBindingSource As System.Windows.Forms.BindingSource
End Class
