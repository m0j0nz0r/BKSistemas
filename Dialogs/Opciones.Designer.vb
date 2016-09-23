<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opciones
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
        Me.LblOffline = New System.Windows.Forms.Label()
        Me.LblLoad = New System.Windows.Forms.Label()
        Me.BtnOffline = New System.Windows.Forms.Button()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.BtnFile = New System.Windows.Forms.Button()
        Me.LblFile = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblOffline
        '
        Me.LblOffline.AutoSize = True
        Me.LblOffline.Location = New System.Drawing.Point(41, 17)
        Me.LblOffline.Name = "LblOffline"
        Me.LblOffline.Size = New System.Drawing.Size(67, 13)
        Me.LblOffline.TabIndex = 0
        Me.LblOffline.Text = "Modo Offline"
        '
        'LblLoad
        '
        Me.LblLoad.AutoSize = True
        Me.LblLoad.Location = New System.Drawing.Point(41, 46)
        Me.LblLoad.Name = "LblLoad"
        Me.LblLoad.Size = New System.Drawing.Size(76, 13)
        Me.LblLoad.TabIndex = 1
        Me.LblLoad.Text = "Carga Paralela"
        '
        'BtnOffline
        '
        Me.BtnOffline.Location = New System.Drawing.Point(12, 12)
        Me.BtnOffline.Name = "BtnOffline"
        Me.BtnOffline.Size = New System.Drawing.Size(23, 23)
        Me.BtnOffline.TabIndex = 2
        Me.BtnOffline.UseVisualStyleBackColor = True
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(12, 41)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(23, 23)
        Me.BtnLoad.TabIndex = 3
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'BtnFile
        '
        Me.BtnFile.Location = New System.Drawing.Point(12, 70)
        Me.BtnFile.Name = "BtnFile"
        Me.BtnFile.Size = New System.Drawing.Size(23, 23)
        Me.BtnFile.TabIndex = 4
        Me.BtnFile.UseVisualStyleBackColor = True
        '
        'LblFile
        '
        Me.LblFile.AutoSize = True
        Me.LblFile.Location = New System.Drawing.Point(41, 75)
        Me.LblFile.Name = "LblFile"
        Me.LblFile.Size = New System.Drawing.Size(46, 13)
        Me.LblFile.TabIndex = 5
        Me.LblFile.Text = "Archivo:"
        '
        'Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 98)
        Me.Controls.Add(Me.LblFile)
        Me.Controls.Add(Me.BtnFile)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.BtnOffline)
        Me.Controls.Add(Me.LblLoad)
        Me.Controls.Add(Me.LblOffline)
        Me.Name = "Opciones"
        Me.Text = "Opciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblOffline As System.Windows.Forms.Label
    Friend WithEvents LblLoad As System.Windows.Forms.Label
    Friend WithEvents BtnOffline As System.Windows.Forms.Button
    Friend WithEvents BtnLoad As System.Windows.Forms.Button
    Friend WithEvents BtnFile As System.Windows.Forms.Button
    Friend WithEvents LblFile As System.Windows.Forms.Label
End Class
