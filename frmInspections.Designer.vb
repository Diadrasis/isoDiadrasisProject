<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInspections
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInspections))
        Me.TblInspectionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.TblInspectionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TblInspectionsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblInspectionsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TblMonthsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VcDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblInspectionsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblInspectionsTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblMonthsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblMonthsTableAdapter
        Me.VcDepartmentTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcDepartmentTableAdapter
        Me.VwStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.TblInspectionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblInspectionsBindingNavigator.SuspendLayout()
        CType(Me.TblInspectionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInspectionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMonthsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblInspectionsBindingNavigator
        '
        Me.TblInspectionsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblInspectionsBindingNavigator.BindingSource = Me.TblInspectionsBindingSource
        Me.TblInspectionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblInspectionsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblInspectionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblInspectionsBindingNavigatorSaveItem})
        Me.TblInspectionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblInspectionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblInspectionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblInspectionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblInspectionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblInspectionsBindingNavigator.Name = "TblInspectionsBindingNavigator"
        Me.TblInspectionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblInspectionsBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblInspectionsBindingNavigator.TabIndex = 2
        Me.TblInspectionsBindingNavigator.Text = "BindingNavigator1"
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
        'TblInspectionsBindingSource
        '
        Me.TblInspectionsBindingSource.DataMember = "tblInspections"
        Me.TblInspectionsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
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
        'TblInspectionsBindingNavigatorSaveItem
        '
        Me.TblInspectionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblInspectionsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblInspectionsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblInspectionsBindingNavigatorSaveItem.Name = "TblInspectionsBindingNavigatorSaveItem"
        Me.TblInspectionsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblInspectionsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblInspectionsDataGridView
        '
        Me.TblInspectionsDataGridView.AutoGenerateColumns = False
        Me.TblInspectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInspectionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblInspectionsDataGridView.DataSource = Me.TblInspectionsBindingSource
        Me.TblInspectionsDataGridView.Location = New System.Drawing.Point(39, 236)
        Me.TblInspectionsDataGridView.Name = "TblInspectionsDataGridView"
        Me.TblInspectionsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblInspectionsDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "inspID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "inspID"
        Me.DataGridViewTextBoxColumn1.Name = "inspID"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "inspSceduleID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "inspSceduleID"
        Me.DataGridViewTextBoxColumn2.Name = "inspSceduleID"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "monthID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.TblMonthsBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "monthName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "monthID"
        Me.DataGridViewTextBoxColumn3.Name = "monthID"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "monthID"
        '
        'TblMonthsBindingSource
        '
        Me.TblMonthsBindingSource.DataMember = "tblMonths"
        Me.TblMonthsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "deptID"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.VcDepartmentBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "deptName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "deptID"
        Me.DataGridViewTextBoxColumn4.Name = "deptID"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "deptID"
        '
        'VcDepartmentBindingSource
        '
        Me.VcDepartmentBindingSource.DataMember = "vcDepartment"
        Me.VcDepartmentBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "inspectorID"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.VwStaffBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "staffFullname"
        Me.DataGridViewTextBoxColumn5.HeaderText = "inspectorID"
        Me.DataGridViewTextBoxColumn5.Name = "inspectorID"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "staffId"
        '
        'VwStaffBindingSource
        '
        Me.VwStaffBindingSource.DataMember = "vwStaff"
        Me.VwStaffBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "inspectedID"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.VwStaffBindingSource1
        Me.DataGridViewTextBoxColumn6.DisplayMember = "staffFullname"
        Me.DataGridViewTextBoxColumn6.HeaderText = "inspectedID"
        Me.DataGridViewTextBoxColumn6.Name = "inspectedID"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "staffId"
        '
        'VwStaffBindingSource1
        '
        Me.VwStaffBindingSource1.DataMember = "vwStaff"
        Me.VwStaffBindingSource1.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "inspTopics"
        Me.DataGridViewTextBoxColumn7.HeaderText = "inspTopics"
        Me.DataGridViewTextBoxColumn7.Name = "inspTopics"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "inspComments"
        Me.DataGridViewTextBoxColumn8.HeaderText = "inspComments"
        Me.DataGridViewTextBoxColumn8.Name = "inspComments"
        '
        'TblInspectionsTableAdapter
        '
        Me.TblInspectionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionScedulesTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsTableAdapter = Me.TblInspectionsTableAdapter
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectPhasesTableAdapter = Nothing
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
        Me.TableAdapterManager.tblQASupplierSatisfactionMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionSurveyDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQASupplierSatisfactionSurveysTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingRecommedationsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingTopicsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingTopicTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskReasonsTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningProgrammesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblMonthsTableAdapter
        '
        Me.TblMonthsTableAdapter.ClearBeforeFill = True
        '
        'VcDepartmentTableAdapter
        '
        Me.VcDepartmentTableAdapter.ClearBeforeFill = True
        '
        'VwStaffTableAdapter
        '
        Me.VwStaffTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'frmInspections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblInspectionsDataGridView)
        Me.Controls.Add(Me.TblInspectionsBindingNavigator)
        Me.Name = "frmInspections"
        Me.Controls.SetChildIndex(Me.TblInspectionsBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblInspectionsDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.TblInspectionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblInspectionsBindingNavigator.ResumeLayout(False)
        Me.TblInspectionsBindingNavigator.PerformLayout()
        CType(Me.TblInspectionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInspectionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMonthsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblInspectionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInspectionsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblInspectionsTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblInspectionsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblInspectionsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblInspectionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TblMonthsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMonthsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblMonthsTableAdapter
    Friend WithEvents VcDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcDepartmentTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcDepartmentTableAdapter
    Friend WithEvents VwStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents VwStaffBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
