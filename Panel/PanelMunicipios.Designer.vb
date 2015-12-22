<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelMunicipios
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim MunicipiosLabel As System.Windows.Forms.Label
        Dim EIDLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelMunicipios))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TblEstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New BkSistema.MainDS()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.TblPaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MunicipiosTextBox = New System.Windows.Forms.TextBox()
        Me.TblMunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TblMunicipiosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblMunicipiosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        IDLabel = New System.Windows.Forms.Label()
        MunicipiosLabel = New System.Windows.Forms.Label()
        EIDLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TblEstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMunicipiosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMunicipiosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblMunicipiosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(14, 58)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'MunicipiosLabel
        '
        MunicipiosLabel.AutoSize = True
        MunicipiosLabel.Location = New System.Drawing.Point(147, 58)
        MunicipiosLabel.Name = "MunicipiosLabel"
        MunicipiosLabel.Size = New System.Drawing.Size(60, 13)
        MunicipiosLabel.TabIndex = 2
        MunicipiosLabel.Text = "Municipios:"
        '
        'EIDLabel
        '
        EIDLabel.AutoSize = True
        EIDLabel.Location = New System.Drawing.Point(319, 58)
        EIDLabel.Name = "EIDLabel"
        EIDLabel.Size = New System.Drawing.Size(28, 13)
        EIDLabel.TabIndex = 4
        EIDLabel.Text = "EID:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(272, 31)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(76, 13)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "Filtrar Estados:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.EIDComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(EIDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(MunicipiosLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MunicipiosTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IDTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TblMunicipiosDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(620, 307)
        Me.SplitContainer1.SplitterDistance = 86
        Me.SplitContainer1.TabIndex = 0
        '
        'EIDComboBox
        '
        Me.EIDComboBox.FormattingEnabled = True
        Me.EIDComboBox.Location = New System.Drawing.Point(354, 55)
        Me.EIDComboBox.Name = "EIDComboBox"
        Me.EIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EIDComboBox.TabIndex = 8
        '
        'TblEstadosBindingSource
        '
        Me.TblEstadosBindingSource.DataMember = "TblEstados"
        Me.TblEstadosBindingSource.DataSource = Me.MainDS
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "MainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPaisesBindingSource, "Nombre", True))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(353, 28)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NombreComboBox.TabIndex = 7
        '
        'TblPaisesBindingSource
        '
        Me.TblPaisesBindingSource.DataMember = "TblPaises"
        Me.TblPaisesBindingSource.DataSource = Me.MainDS
        '
        'MunicipiosTextBox
        '
        Me.MunicipiosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMunicipiosBindingSource, "Municipios", True))
        Me.MunicipiosTextBox.Location = New System.Drawing.Point(213, 55)
        Me.MunicipiosTextBox.Name = "MunicipiosTextBox"
        Me.MunicipiosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MunicipiosTextBox.TabIndex = 3
        '
        'TblMunicipiosBindingSource
        '
        Me.TblMunicipiosBindingSource.DataMember = "TblMunicipios"
        Me.TblMunicipiosBindingSource.DataSource = Me.MainDS
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMunicipiosBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(41, 55)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'TblMunicipiosDataGridView
        '
        Me.TblMunicipiosDataGridView.AllowUserToDeleteRows = False
        Me.TblMunicipiosDataGridView.AutoGenerateColumns = False
        Me.TblMunicipiosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblMunicipiosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblMunicipiosDataGridView.DataSource = Me.TblMunicipiosBindingSource
        Me.TblMunicipiosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblMunicipiosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblMunicipiosDataGridView.Name = "TblMunicipiosDataGridView"
        Me.TblMunicipiosDataGridView.Size = New System.Drawing.Size(620, 217)
        Me.TblMunicipiosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Municipios"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Municipios"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TblMunicipiosBindingNavigator
        '
        Me.TblMunicipiosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblMunicipiosBindingNavigator.BindingSource = Me.TblMunicipiosBindingSource
        Me.TblMunicipiosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblMunicipiosBindingNavigator.CountItemFormat = "de {0}"
        Me.TblMunicipiosBindingNavigator.DeleteItem = Nothing
        Me.TblMunicipiosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem})
        Me.TblMunicipiosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblMunicipiosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblMunicipiosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblMunicipiosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblMunicipiosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblMunicipiosBindingNavigator.Name = "TblMunicipiosBindingNavigator"
        Me.TblMunicipiosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblMunicipiosBindingNavigator.Size = New System.Drawing.Size(620, 25)
        Me.TblMunicipiosBindingNavigator.TabIndex = 1
        Me.TblMunicipiosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PanelMunicipios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 307)
        Me.Controls.Add(Me.TblMunicipiosBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PanelMunicipios"
        Me.Text = "PanelMunicipios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TblEstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMunicipiosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMunicipiosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblMunicipiosBindingNavigator.ResumeLayout(False)
        Me.TblMunicipiosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TblMunicipiosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblMunicipiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainDS As BkSistema.MainDS
    Friend WithEvents TblMunicipiosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblEstadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MunicipiosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TblPaisesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EIDComboBox As System.Windows.Forms.ComboBox
End Class
