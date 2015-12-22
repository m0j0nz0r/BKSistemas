<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelUsuarios
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ClaveLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelUsuarios))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBBanko = New System.Windows.Forms.ComboBox()
        Me.TblBankoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDS = New BkSistema.MainDS()
        Me.CBPerfil = New System.Windows.Forms.ComboBox()
        Me.TblProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClaveTextBox = New System.Windows.Forms.TextBox()
        Me.TblUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.TblUsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblUsuarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        UsuarioLabel = New System.Windows.Forms.Label()
        ClaveLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TblBankoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblUsuarioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(10, 31)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 0
        UsuarioLabel.Text = "Usuario:"
        '
        'ClaveLabel
        '
        ClaveLabel.AutoSize = True
        ClaveLabel.Location = New System.Drawing.Point(19, 57)
        ClaveLabel.Name = "ClaveLabel"
        ClaveLabel.Size = New System.Drawing.Size(37, 13)
        ClaveLabel.TabIndex = 2
        ClaveLabel.Text = "Clave:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CBBanko)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CBPerfil)
        Me.SplitContainer1.Panel1.Controls.Add(ClaveLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ClaveTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(UsuarioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UsuarioTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TblUsuarioDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(435, 419)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Banko:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Perfil:"
        '
        'CBBanko
        '
        Me.CBBanko.DataSource = Me.TblBankoBindingSource
        Me.CBBanko.DisplayMember = "NombreBk"
        Me.CBBanko.FormattingEnabled = True
        Me.CBBanko.Location = New System.Drawing.Point(241, 54)
        Me.CBBanko.Name = "CBBanko"
        Me.CBBanko.Size = New System.Drawing.Size(121, 21)
        Me.CBBanko.TabIndex = 5
        Me.CBBanko.ValueMember = "CodBk"
        '
        'TblBankoBindingSource
        '
        Me.TblBankoBindingSource.DataMember = "TblBanko"
        Me.TblBankoBindingSource.DataSource = Me.MainDS
        '
        'MainDS
        '
        Me.MainDS.DataSetName = "MainDS"
        Me.MainDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CBPerfil
        '
        Me.CBPerfil.DataSource = Me.TblProfilesBindingSource
        Me.CBPerfil.DisplayMember = "Perfil"
        Me.CBPerfil.FormattingEnabled = True
        Me.CBPerfil.Location = New System.Drawing.Point(241, 31)
        Me.CBPerfil.Name = "CBPerfil"
        Me.CBPerfil.Size = New System.Drawing.Size(121, 21)
        Me.CBPerfil.TabIndex = 4
        Me.CBPerfil.ValueMember = "ID"
        '
        'TblProfilesBindingSource
        '
        Me.TblProfilesBindingSource.DataMember = "TblProfiles"
        Me.TblProfilesBindingSource.DataSource = Me.MainDS
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsuarioBindingSource, "Clave", True))
        Me.ClaveTextBox.Location = New System.Drawing.Point(62, 54)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClaveTextBox.TabIndex = 3
        '
        'TblUsuarioBindingSource
        '
        Me.TblUsuarioBindingSource.DataMember = "tblUsuario"
        Me.TblUsuarioBindingSource.DataSource = Me.MainDS
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsuarioBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(62, 28)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTextBox.TabIndex = 1
        '
        'TblUsuarioDataGridView
        '
        Me.TblUsuarioDataGridView.AllowUserToDeleteRows = False
        Me.TblUsuarioDataGridView.AutoGenerateColumns = False
        Me.TblUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblUsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblUsuarioDataGridView.DataSource = Me.TblUsuarioBindingSource
        Me.TblUsuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblUsuarioDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblUsuarioDataGridView.Name = "TblUsuarioDataGridView"
        Me.TblUsuarioDataGridView.Size = New System.Drawing.Size(435, 334)
        Me.TblUsuarioDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Clave"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Clave"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TipoUser"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Perfil de Usuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Bk"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bk"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'TblUsuarioBindingNavigator
        '
        Me.TblUsuarioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblUsuarioBindingNavigator.BindingSource = Me.TblUsuarioBindingSource
        Me.TblUsuarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblUsuarioBindingNavigator.CountItemFormat = "de {0}"
        Me.TblUsuarioBindingNavigator.DeleteItem = Nothing
        Me.TblUsuarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem})
        Me.TblUsuarioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblUsuarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblUsuarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblUsuarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblUsuarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblUsuarioBindingNavigator.Name = "TblUsuarioBindingNavigator"
        Me.TblUsuarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblUsuarioBindingNavigator.Size = New System.Drawing.Size(435, 25)
        Me.TblUsuarioBindingNavigator.TabIndex = 1
        Me.TblUsuarioBindingNavigator.Text = "BindingNavigator1"
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
        'PanelUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 419)
        Me.Controls.Add(Me.TblUsuarioBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PanelUsuarios"
        Me.Text = "PanelUsuarios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TblBankoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblUsuarioBindingNavigator.ResumeLayout(False)
        Me.TblUsuarioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TblUsuarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblUsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainDS As BkSistema.MainDS
    Friend WithEvents TblUsuarioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBBanko As System.Windows.Forms.ComboBox
    Friend WithEvents TblBankoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CBPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents TblProfilesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClaveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
