<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInspectionReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInspectionReports))
        Me.TblInspectionsReportBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.TblInspectionsReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TblInspectionsReportBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblInspectionsReportDataGridView = New System.Windows.Forms.DataGridView
        Me.inspRepID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inspRepDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.deptID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VcDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inspectorID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inspectedID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.inspTopics = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inspTarget = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inspResults = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inspRepReport = New System.Windows.Forms.DataGridViewImageColumn
        Me.inspComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblInspectionsReportTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblInspectionsReportTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.VcDepartmentTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcDepartmentTableAdapter
        Me.VwStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
        CType(Me.TblInspectionsReportBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblInspectionsReportBindingNavigator.SuspendLayout()
        CType(Me.TblInspectionsReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInspectionsReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblInspectionsReportBindingNavigator
        '
        Me.TblInspectionsReportBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblInspectionsReportBindingNavigator.BindingSource = Me.TblInspectionsReportBindingSource
        Me.TblInspectionsReportBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblInspectionsReportBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblInspectionsReportBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblInspectionsReportBindingNavigatorSaveItem})
        Me.TblInspectionsReportBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblInspectionsReportBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblInspectionsReportBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblInspectionsReportBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblInspectionsReportBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblInspectionsReportBindingNavigator.Name = "TblInspectionsReportBindingNavigator"
        Me.TblInspectionsReportBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblInspectionsReportBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblInspectionsReportBindingNavigator.TabIndex = 2
        Me.TblInspectionsReportBindingNavigator.Text = "BindingNavigator1"
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
        'TblInspectionsReportBindingSource
        '
        Me.TblInspectionsReportBindingSource.DataMember = "tblInspectionsReport"
        Me.TblInspectionsReportBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
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
        'TblInspectionsReportBindingNavigatorSaveItem
        '
        Me.TblInspectionsReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblInspectionsReportBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblInspectionsReportBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblInspectionsReportBindingNavigatorSaveItem.Name = "TblInspectionsReportBindingNavigatorSaveItem"
        Me.TblInspectionsReportBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblInspectionsReportBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblInspectionsReportDataGridView
        '
        Me.TblInspectionsReportDataGridView.AutoGenerateColumns = False
        Me.TblInspectionsReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInspectionsReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inspRepID, Me.inspRepDate, Me.deptID, Me.inspectorID, Me.inspectedID, Me.inspTopics, Me.inspTarget, Me.inspResults, Me.inspRepReport, Me.inspComments})
        Me.TblInspectionsReportDataGridView.DataSource = Me.TblInspectionsReportBindingSource
        Me.TblInspectionsReportDataGridView.Location = New System.Drawing.Point(106, 226)
        Me.TblInspectionsReportDataGridView.Name = "TblInspectionsReportDataGridView"
        Me.TblInspectionsReportDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblInspectionsReportDataGridView.TabIndex = 3
        '
        'inspRepID
        '
        Me.inspRepID.DataPropertyName = "inspRepID"
        Me.inspRepID.HeaderText = "inspRepID"
        Me.inspRepID.Name = "inspRepID"
        Me.inspRepID.ReadOnly = True
        '
        'inspRepDate
        '
        Me.inspRepDate.DataPropertyName = "inspRepDate"
        Me.inspRepDate.HeaderText = "inspRepDate"
        Me.inspRepDate.Name = "inspRepDate"
        '
        'deptID
        '
        Me.deptID.DataPropertyName = "deptID"
        Me.deptID.DataSource = Me.VcDepartmentBindingSource
        Me.deptID.DisplayMember = "deptName"
        Me.deptID.HeaderText = "deptID"
        Me.deptID.Name = "deptID"
        Me.deptID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deptID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.deptID.ValueMember = "deptID"
        '
        'VcDepartmentBindingSource
        '
        Me.VcDepartmentBindingSource.DataMember = "vcDepartment"
        Me.VcDepartmentBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'inspectorID
        '
        Me.inspectorID.DataPropertyName = "inspectorID"
        Me.inspectorID.DataSource = Me.VwStaffBindingSource
        Me.inspectorID.DisplayMember = "staffFullname"
        Me.inspectorID.HeaderText = "inspectorID"
        Me.inspectorID.Name = "inspectorID"
        Me.inspectorID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inspectorID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.inspectorID.ValueMember = "staffId"
        '
        'VwStaffBindingSource
        '
        Me.VwStaffBindingSource.DataMember = "vwStaff"
        Me.VwStaffBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'inspectedID
        '
        Me.inspectedID.DataPropertyName = "inspectedID"
        Me.inspectedID.DataSource = Me.VwStaffBindingSource1
        Me.inspectedID.DisplayMember = "staffFullname"
        Me.inspectedID.HeaderText = "inspectedID"
        Me.inspectedID.Name = "inspectedID"
        Me.inspectedID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inspectedID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.inspectedID.ValueMember = "staffId"
        '
        'VwStaffBindingSource1
        '
        Me.VwStaffBindingSource1.DataMember = "vwStaff"
        Me.VwStaffBindingSource1.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'inspTopics
        '
        Me.inspTopics.DataPropertyName = "inspTopics"
        Me.inspTopics.HeaderText = "inspTopics"
        Me.inspTopics.Name = "inspTopics"
        '
        'inspTarget
        '
        Me.inspTarget.DataPropertyName = "inspTarget"
        Me.inspTarget.HeaderText = "inspTarget"
        Me.inspTarget.Name = "inspTarget"
        '
        'inspResults
        '
        Me.inspResults.DataPropertyName = "inspResults"
        Me.inspResults.HeaderText = "inspResults"
        Me.inspResults.Name = "inspResults"
        '
        'inspRepReport
        '
        Me.inspRepReport.HeaderText = "inspRepReport"
        Me.inspRepReport.Image = Global.diadrasisProjects.My.Resources.Resources.reports
        Me.inspRepReport.Name = "inspRepReport"
        '
        'inspComments
        '
        Me.inspComments.DataPropertyName = "inspComments"
        Me.inspComments.HeaderText = "inspComments"
        Me.inspComments.Name = "inspComments"
        '
        'TblInspectionsReportTableAdapter
        '
        Me.TblInspectionsReportTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionScedulesTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsReportTableAdapter = Me.TblInspectionsReportTableAdapter
        Me.TableAdapterManager.tblInspectionsTableAdapter = Nothing
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
        'VcDepartmentTableAdapter
        '
        Me.VcDepartmentTableAdapter.ClearBeforeFill = True
        '
        'VwStaffTableAdapter
        '
        Me.VwStaffTableAdapter.ClearBeforeFill = True
        '
        'frmInspectionReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.TblInspectionsReportDataGridView)
        Me.Controls.Add(Me.TblInspectionsReportBindingNavigator)
        Me.Name = "frmInspectionReports"
        Me.Controls.SetChildIndex(Me.TblInspectionsReportBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblInspectionsReportDataGridView, 0)
        CType(Me.TblInspectionsReportBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblInspectionsReportBindingNavigator.ResumeLayout(False)
        Me.TblInspectionsReportBindingNavigator.PerformLayout()
        CType(Me.TblInspectionsReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInspectionsReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblInspectionsReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInspectionsReportTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblInspectionsReportTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblInspectionsReportBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblInspectionsReportBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblInspectionsReportDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VcDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcDepartmentTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcDepartmentTableAdapter
    Friend WithEvents VwStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
    Friend WithEvents VwStaffBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspRepReport As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspRepID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspRepDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deptID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents inspectorID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents inspectedID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents inspTopics As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspTarget As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspResults As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspComments As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
