<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQAEmployeeEvaluationCritera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQAEmployeeEvaluationCritera))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblQAEmployeeEvaluationCriteriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblQAEmployeeEvaluationCriteriaTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQAEmployeeEvaluationCriteriaTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQAEmployeeEvaluationCriteriaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQAEmployeeEvaluationCriteriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQAEmployeeEvaluationCriteriaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.SuspendLayout()
        CType(Me.TblQAEmployeeEvaluationCriteriaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblQAEmployeeEvaluationCriteriaBindingSource
        '
        Me.TblQAEmployeeEvaluationCriteriaBindingSource.DataMember = "tblQAEmployeeEvaluationCriteria"
        Me.TblQAEmployeeEvaluationCriteriaBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblQAEmployeeEvaluationCriteriaTableAdapter
        '
        Me.TblQAEmployeeEvaluationCriteriaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblQAEmployeeEvaluationCriteriaTableAdapter = Me.TblQAEmployeeEvaluationCriteriaTableAdapter
        Me.TableAdapterManager.tblQAEmployeeEvaluationDetailsTableAdapter = Nothing
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
        'TblQAEmployeeEvaluationCriteriaBindingNavigator
        '
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.BindingSource = Me.TblQAEmployeeEvaluationCriteriaBindingSource
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem})
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.Name = "TblQAEmployeeEvaluationCriteriaBindingNavigator"
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.TabIndex = 2
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.Text = "BindingNavigator1"
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
        'TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem
        '
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem.Name = "TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem"
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQAEmployeeEvaluationCriteriaDataGridView
        '
        Me.TblQAEmployeeEvaluationCriteriaDataGridView.AutoGenerateColumns = False
        Me.TblQAEmployeeEvaluationCriteriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQAEmployeeEvaluationCriteriaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4})
        Me.TblQAEmployeeEvaluationCriteriaDataGridView.DataSource = Me.TblQAEmployeeEvaluationCriteriaBindingSource
        Me.TblQAEmployeeEvaluationCriteriaDataGridView.Location = New System.Drawing.Point(89, 187)
        Me.TblQAEmployeeEvaluationCriteriaDataGridView.Name = "TblQAEmployeeEvaluationCriteriaDataGridView"
        Me.TblQAEmployeeEvaluationCriteriaDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblQAEmployeeEvaluationCriteriaDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "empEvalCritID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "empEvalCritID"
        Me.DataGridViewTextBoxColumn1.Name = "empEvalCritID"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "empEvalCritTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "empEvalCritTitle"
        Me.DataGridViewTextBoxColumn2.Name = "empEvalCritTitle"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "empEvalCritDesc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "empEvalCritDesc"
        Me.DataGridViewTextBoxColumn3.Name = "empEvalCritDesc"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "empEvalCritCurrent"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "empEvalCritCurrent"
        Me.DataGridViewCheckBoxColumn1.Name = "empEvalCritCurrent"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "empEvalCritComm"
        Me.DataGridViewTextBoxColumn4.HeaderText = "empEvalCritComm"
        Me.DataGridViewTextBoxColumn4.Name = "empEvalCritComm"
        '
        'frmQAEmlployeeEvaluationCritera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.TblQAEmployeeEvaluationCriteriaDataGridView)
        Me.Controls.Add(Me.TblQAEmployeeEvaluationCriteriaBindingNavigator)
        Me.Name = "frmQAEmlployeeEvaluationCritera"
        Me.Controls.SetChildIndex(Me.TblQAEmployeeEvaluationCriteriaBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQAEmployeeEvaluationCriteriaDataGridView, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQAEmployeeEvaluationCriteriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQAEmployeeEvaluationCriteriaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.ResumeLayout(False)
        Me.TblQAEmployeeEvaluationCriteriaBindingNavigator.PerformLayout()
        CType(Me.TblQAEmployeeEvaluationCriteriaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblQAEmployeeEvaluationCriteriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQAEmployeeEvaluationCriteriaTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQAEmployeeEvaluationCriteriaTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQAEmployeeEvaluationCriteriaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQAEmployeeEvaluationCriteriaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
