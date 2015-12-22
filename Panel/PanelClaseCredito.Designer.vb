<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelClaseCredito
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
        Dim CodClaseLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim TipoCreiditoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelClaseCredito))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TipoCreditoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New BkSistema.MainDS()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.TblClaseCreditoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodClaseTextBox = New System.Windows.Forms.TextBox()
        Me.TblClaseCreditoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblClaseCreditoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        CodClaseLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        TipoCreiditoLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TipoCreditoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClaseCreditoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClaseCreditoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClaseCreditoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblClaseCreditoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodClaseLabel
        '
        CodClaseLabel.AutoSize = True
        CodClaseLabel.Location = New System.Drawing.Point(17, 57)
        CodClaseLabel.Name = "CodClaseLabel"
        CodClaseLabel.Size = New System.Drawing.Size(58, 13)
        CodClaseLabel.TabIndex = 2
        CodClaseLabel.Text = "Cod Clase:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(9, 83)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'TipoCreiditoLabel
        '
        TipoCreiditoLabel.AutoSize = True
        TipoCreiditoLabel.Location = New System.Drawing.Point(6, 31)
        TipoCreiditoLabel.Name = "TipoCreiditoLabel"
        TipoCreiditoLabel.Size = New System.Drawing.Size(69, 13)
        TipoCreiditoLabel.TabIndex = 0
        TipoCreiditoLabel.Text = "Tipo Creidito:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel1.Controls.Add(DescripcionLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DescripcionTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(CodClaseLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CodClaseTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(TipoCreiditoLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TblClaseCreditoDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(399, 393)
        Me.SplitContainer1.SplitterDistance = 119
        Me.SplitContainer1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TipoCreditoBindingSource
        Me.ComboBox1.DisplayMember = "DescripClase"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(81, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "Clase"
        '
        'TipoCreditoBindingSource
        '
        Me.TipoCreditoBindingSource.DataMember = "TipoCredito"
        Me.TipoCreditoBindingSource.DataSource = Me.MainDS
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "MainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaseCreditoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(81, 80)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'TblClaseCreditoBindingSource
        '
        Me.TblClaseCreditoBindingSource.DataMember = "TblClaseCredito"
        Me.TblClaseCreditoBindingSource.DataSource = Me.MainDS
        '
        'CodClaseTextBox
        '
        Me.CodClaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaseCreditoBindingSource, "CodClase", True))
        Me.CodClaseTextBox.Location = New System.Drawing.Point(81, 54)
        Me.CodClaseTextBox.Name = "CodClaseTextBox"
        Me.CodClaseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodClaseTextBox.TabIndex = 3
        '
        'TblClaseCreditoDataGridView
        '
        Me.TblClaseCreditoDataGridView.AllowUserToDeleteRows = False
        Me.TblClaseCreditoDataGridView.AutoGenerateColumns = False
        Me.TblClaseCreditoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblClaseCreditoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblClaseCreditoDataGridView.DataSource = Me.TblClaseCreditoBindingSource
        Me.TblClaseCreditoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblClaseCreditoDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblClaseCreditoDataGridView.Name = "TblClaseCreditoDataGridView"
        Me.TblClaseCreditoDataGridView.Size = New System.Drawing.Size(399, 270)
        Me.TblClaseCreditoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TipoCreidito"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TipoCreidito"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodClase"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodClase"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TblClaseCreditoBindingNavigator
        '
        Me.TblClaseCreditoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblClaseCreditoBindingNavigator.BindingSource = Me.TblClaseCreditoBindingSource
        Me.TblClaseCreditoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblClaseCreditoBindingNavigator.CountItemFormat = "de {0}"
        Me.TblClaseCreditoBindingNavigator.DeleteItem = Nothing
        Me.TblClaseCreditoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem})
        Me.TblClaseCreditoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblClaseCreditoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblClaseCreditoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblClaseCreditoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblClaseCreditoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblClaseCreditoBindingNavigator.Name = "TblClaseCreditoBindingNavigator"
        Me.TblClaseCreditoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblClaseCreditoBindingNavigator.Size = New System.Drawing.Size(399, 25)
        Me.TblClaseCreditoBindingNavigator.TabIndex = 1
        Me.TblClaseCreditoBindingNavigator.Text = "BindingNavigator1"
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
        'PanelClaseCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 393)
        Me.Controls.Add(Me.TblClaseCreditoBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PanelClaseCredito"
        Me.Text = "PanelClaseCredito"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TipoCreditoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClaseCreditoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClaseCreditoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClaseCreditoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblClaseCreditoBindingNavigator.ResumeLayout(False)
        Me.TblClaseCreditoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TblClaseCreditoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblClaseCreditoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainDS As BkSistema.MainDS
    Friend WithEvents TblClaseCreditoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TipoCreditoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodClaseTextBox As System.Windows.Forms.TextBox
End Class
