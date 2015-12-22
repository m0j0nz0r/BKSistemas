<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptCreditosVencidos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RptDataset = New BkSistema.RptDataset()
        Me.RptCreditosVencidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.RptDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptCreditosVencidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Main"
        ReportDataSource1.Value = Me.RptCreditosVencidosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BkSistema.RptCreditosVencidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'RptDataset
        '
        Me.RptDataset.DataSetName = "RptDataset"
        Me.RptDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptCreditosVencidosBindingSource
        '
        Me.RptCreditosVencidosBindingSource.DataMember = "RptCreditosVencidos"
        Me.RptCreditosVencidosBindingSource.DataSource = Me.RptDataset
        '
        'RptCreditosVencidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RptCreditosVencidos"
        Me.Text = "::: Creditos Vencidos :::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RptDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptCreditosVencidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RptCreditosVencidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RptDataset As BkSistema.RptDataset
End Class
