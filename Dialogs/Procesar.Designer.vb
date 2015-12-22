<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Procesar
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
        Me.LstBankos = New System.Windows.Forms.DataGridView
        CType(Me.LstBankos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstBankos
        '
        Me.LstBankos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LstBankos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstBankos.Location = New System.Drawing.Point(0, 0)
        Me.LstBankos.Name = "LstBankos"
        Me.LstBankos.Size = New System.Drawing.Size(284, 262)
        Me.LstBankos.TabIndex = 0
        '
        'Procesar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.LstBankos)
        Me.Name = "Procesar"
        Me.Text = "Procesar"
        CType(Me.LstBankos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstBankos As System.Windows.Forms.DataGridView
End Class
