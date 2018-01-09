<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeEvaluationDetails
    Inherits diadrasisProjects.frmTemplate

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeEvaluationDetails))
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.TblQAEmployeeEvaluationDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQAEmployeeEvaluationDetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.empEvalDetID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empEvalID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empEvalCritID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VcEmpEvalCritBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empEvalMarkID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VcEmpEvalMarkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.empEvalDetComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblQAEmployeeEvaluationDetailsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQAEmployeeEvaluationDetailsTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.Label1 = New System.Windows.Forms.Label
        Me.VcEmpEvalCritTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcEmpEvalCritTableAdapter
        Me.VcEmpEvalMarkTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcEmpEvalMarkTableAdapter
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.TblQAEmployeeEvaluationDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.SuspendLayout()
        CType(Me.TblQAEmployeeEvaluationDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQAEmployeeEvaluationDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcEmpEvalCritBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcEmpEvalMarkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblQAEmployeeEvaluationDetailsBindingNavigator
        '
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.BindingSource = Me.TblQAEmployeeEvaluationDetailsBindingSource
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem})
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.Name = "TblQAEmployeeEvaluationDetailsBindingNavigator"
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.TabIndex = 2
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.Text = "BindingNavigator1"
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
        'TblQAEmployeeEvaluationDetailsBindingSource
        '
        Me.TblQAEmployeeEvaluationDetailsBindingSource.DataMember = "tblQAEmployeeEvaluationDetails"
        Me.TblQAEmployeeEvaluationDetailsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem
        '
        Me.TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem.Name = "TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem"
        Me.TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQAEmployeeEvaluationDetailsDataGridView
        '
        Me.TblQAEmployeeEvaluationDetailsDataGridView.AutoGenerateColumns = False
        Me.TblQAEmployeeEvaluationDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQAEmployeeEvaluationDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empEvalDetID, Me.empEvalID, Me.empEvalCritID, Me.empEvalMarkID, Me.empEvalDetComments})
        Me.TblQAEmployeeEvaluationDetailsDataGridView.DataSource = Me.TblQAEmployeeEvaluationDetailsBindingSource
        Me.TblQAEmployeeEvaluationDetailsDataGridView.Location = New System.Drawing.Point(22, 218)
        Me.TblQAEmployeeEvaluationDetailsDataGridView.Name = "TblQAEmployeeEvaluationDetailsDataGridView"
        Me.TblQAEmployeeEvaluationDetailsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblQAEmployeeEvaluationDetailsDataGridView.TabIndex = 3
        '
        'empEvalDetID
        '
        Me.empEvalDetID.DataPropertyName = "empEvalDetID"
        Me.empEvalDetID.HeaderText = "empEvalDetID"
        Me.empEvalDetID.Name = "empEvalDetID"
        Me.empEvalDetID.ReadOnly = True
        '
        'empEvalID
        '
        Me.empEvalID.DataPropertyName = "empEvalID"
        Me.empEvalID.HeaderText = "empEvalID"
        Me.empEvalID.Name = "empEvalID"
        '
        'empEvalCritID
        '
        Me.empEvalCritID.DataPropertyName = "empEvalCritID"
        Me.empEvalCritID.DataSource = Me.VcEmpEvalCritBindingSource
        Me.empEvalCritID.DisplayMember = "empEvalCritTitle"
        Me.empEvalCritID.HeaderText = "empEvalCritID"
        Me.empEvalCritID.Name = "empEvalCritID"
        Me.empEvalCritID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.empEvalCritID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.empEvalCritID.ValueMember = "empEvalCritID"
        '
        'VcEmpEvalCritBindingSource
        '
        Me.VcEmpEvalCritBindingSource.DataMember = "vcEmpEvalCrit"
        Me.VcEmpEvalCritBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'empEvalMarkID
        '
        Me.empEvalMarkID.DataPropertyName = "empEvalMarkID"
        Me.empEvalMarkID.DataSource = Me.VcEmpEvalMarkBindingSource
        Me.empEvalMarkID.DisplayMember = "empEvalMarkValue"
        Me.empEvalMarkID.HeaderText = "empEvalMarkID"
        Me.empEvalMarkID.Name = "empEvalMarkID"
        Me.empEvalMarkID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.empEvalMarkID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.empEvalMarkID.ValueMember = "empEvalMarkID"
        '
        'VcEmpEvalMarkBindingSource
        '
        Me.VcEmpEvalMarkBindingSource.DataMember = "vcEmpEvalMark"
        Me.VcEmpEvalMarkBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'empEvalDetComments
        '
        Me.empEvalDetComments.DataPropertyName = "empEvalDetComments"
        Me.empEvalDetComments.HeaderText = "empEvalDetComments"
        Me.empEvalDetComments.Name = "empEvalDetComments"
        '
        'TblQAEmployeeEvaluationDetailsTableAdapter
        '
        Me.TblQAEmployeeEvaluationDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentsTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.tblQADurationsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationDetailsTableAdapter = Me.TblQAEmployeeEvaluationDetailsTableAdapter
        Me.TableAdapterManager.tblQAEmployeeEvaluationMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAResponsibilitiesTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'VcEmpEvalCritTableAdapter
        '
        Me.VcEmpEvalCritTableAdapter.ClearBeforeFill = True
        '
        'VcEmpEvalMarkTableAdapter
        '
        Me.VcEmpEvalMarkTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Image = Global.diadrasisProjects.My.Resources.Resources.chart_pie
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(679, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 60)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Αναφορά"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmEmployeeEvaluationDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblQAEmployeeEvaluationDetailsDataGridView)
        Me.Controls.Add(Me.TblQAEmployeeEvaluationDetailsBindingNavigator)
        Me.Name = "frmEmployeeEvaluationDetails"
        Me.Controls.SetChildIndex(Me.TblQAEmployeeEvaluationDetailsBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQAEmployeeEvaluationDetailsDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        CType(Me.TblQAEmployeeEvaluationDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.ResumeLayout(False)
        Me.TblQAEmployeeEvaluationDetailsBindingNavigator.PerformLayout()
        CType(Me.TblQAEmployeeEvaluationDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQAEmployeeEvaluationDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcEmpEvalCritBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcEmpEvalMarkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblQAEmployeeEvaluationDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQAEmployeeEvaluationDetailsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQAEmployeeEvaluationDetailsTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQAEmployeeEvaluationDetailsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQAEmployeeEvaluationDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VcEmpEvalCritBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcEmpEvalCritTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcEmpEvalCritTableAdapter
    Friend WithEvents VcEmpEvalMarkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcEmpEvalMarkTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcEmpEvalMarkTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empEvalDetI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empEvalID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empEvalCritID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents empEvalMarkID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents empEvalDetComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empEvalDetID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
