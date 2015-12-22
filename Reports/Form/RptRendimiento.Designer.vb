<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptRendimiento
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
        Me.MainDS = New BkSistema.MainDS()
        Me.TblLibroIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLibroIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Main"
        ReportDataSource1.Value = Me.GestionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BkSistema.RptRendimiento.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 262)
        Me.ReportViewer1.TabIndex = 0
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "MainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLibroIEBindingSource
        '
        Me.TblLibroIEBindingSource.DataMember = "TblLibroIE"
        Me.TblLibroIEBindingSource.DataSource = Me.MainDS
        '
        'GestionBindingSource
        '
        Me.GestionBindingSource.DataMember = "Gestion"
        Me.GestionBindingSource.DataSource = Me.MainDS
        '
        'RptRendimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RptRendimiento"
        Me.Text = "::: Rendimiento de las Acciones :::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLibroIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TblLibroIEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainDS As BkSistema.MainDS
    Friend WithEvents GestionBindingSource As System.Windows.Forms.BindingSource
End Class
