<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQASupplierSatisfactionMarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQASupplierSatisfactionMarks))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblQASupplierSatisfactionMarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblQASupplierSatisfactionMarksTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQASupplierSatisfactionMarksTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblQASupplierSatisfactionMarksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.TblQASupplierSatisfactionMarksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQASupplierSatisfactionMarksDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQASupplierSatisfactionMarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQASupplierSatisfactionMarksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQASupplierSatisfactionMarksBindingNavigator.SuspendLayout()
        CType(Me.TblQASupplierSatisfactionMarksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblQASupplierSatisfactionMarksBindingSource
        '
        Me.TblQASupplierSatisfactionMarksBindingSource.DataMember = "tblQASupplierSatisfactionMarks"
        Me.TblQASupplierSatisfactionMarksBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblQASupplierSatisfactionMarksTableAdapter
        '
        Me.TblQASupplierSatisfactionMarksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveyDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveysTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentsTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.tblQADurationsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAResponsibilitiesTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionMarksTableAdapter = Me.TblQASupplierSatisfactionMarksTableAdapter
        Me.TableAdapterManager.tblQASupplierSatisfactionSurveyDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionSurveysTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblQASupplierSatisfactionMarksBindingNavigator
        '
        Me.TblQASupplierSatisfactionMarksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQASupplierSatisfactionMarksBindingNavigator.BindingSource = Me.TblQASupplierSatisfactionMarksBindingSource
        Me.TblQASupplierSatisfactionMarksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQASupplierSatisfactionMarksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQASupplierSatisfactionMarksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQASupplierSatisfactionMarksBindingNavigatorSaveItem})
        Me.TblQASupplierSatisfactionMarksBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblQASupplierSatisfactionMarksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQASupplierSatisfactionMarksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQASupplierSatisfactionMarksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQASupplierSatisfactionMarksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQASupplierSatisfactionMarksBindingNavigator.Name = "TblQASupplierSatisfactionMarksBindingNavigator"
        Me.TblQASupplierSatisfactionMarksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQASupplierSatisfactionMarksBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblQASupplierSatisfactionMarksBindingNavigator.TabIndex = 2
        Me.TblQASupplierSatisfactionMarksBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblQASupplierSatisfactionMarksBindingNavigatorSaveItem
        '
        Me.TblQASupplierSatisfactionMarksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQASupplierSatisfactionMarksBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQASupplierSatisfactionMarksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQASupplierSatisfactionMarksBindingNavigatorSaveItem.Name = "TblQASupplierSatisfactionMarksBindingNavigatorSaveItem"
        Me.TblQASupplierSatisfactionMarksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblQASupplierSatisfactionMarksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQASupplierSatisfactionMarksDataGridView
        '
        Me.TblQASupplierSatisfactionMarksDataGridView.AutoGenerateColumns = False
        Me.TblQASupplierSatisfactionMarksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQASupplierSatisfactionMarksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblQASupplierSatisfactionMarksDataGridView.DataSource = Me.TblQASupplierSatisfactionMarksBindingSource
        Me.TblQASupplierSatisfactionMarksDataGridView.Location = New System.Drawing.Point(159, 291)
        Me.TblQASupplierSatisfactionMarksDataGridView.Name = "TblQASupplierSatisfactionMarksDataGridView"
        Me.TblQASupplierSatisfactionMarksDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblQASupplierSatisfactionMarksDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "supSatisfMarkID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "supSatisfMarkID"
        Me.DataGridViewTextBoxColumn1.Name = "supSatisfMarkID"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "supSatisfMarkDesc"
        Me.DataGridViewTextBoxColumn2.HeaderText = "supSatisfMarkDesc"
        Me.DataGridViewTextBoxColumn2.Name = "supSatisfMarkDesc"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "supSatisfMarkValue"
        Me.DataGridViewTextBoxColumn3.HeaderText = "supSatisfMarkValue"
        Me.DataGridViewTextBoxColumn3.Name = "supSatisfMarkValue"
        '
        'frmQASupplierSatisfactionMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.TblQASupplierSatisfactionMarksDataGridView)
        Me.Controls.Add(Me.TblQASupplierSatisfactionMarksBindingNavigator)
        Me.Name = "frmQASupplierSatisfactionMarks"
        Me.Controls.SetChildIndex(Me.TblQASupplierSatisfactionMarksBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQASupplierSatisfactionMarksDataGridView, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQASupplierSatisfactionMarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQASupplierSatisfactionMarksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQASupplierSatisfactionMarksBindingNavigator.ResumeLayout(False)
        Me.TblQASupplierSatisfactionMarksBindingNavigator.PerformLayout()
        CType(Me.TblQASupplierSatisfactionMarksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblQASupplierSatisfactionMarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQASupplierSatisfactionMarksTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQASupplierSatisfactionMarksTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQASupplierSatisfactionMarksBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblQASupplierSatisfactionMarksBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQASupplierSatisfactionMarksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
