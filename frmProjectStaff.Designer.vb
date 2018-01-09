<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectStaff))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblProjectStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProjectStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblProjectStaffTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblProjectStaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblProjectStaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblProjectStaffDataGridView = New System.Windows.Forms.DataGridView
        Me.projectStaffId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.projectId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.staffId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.projectStaffDuties = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.projectStaffCategory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.projectStaffComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VwStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProjectStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProjectStaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblProjectStaffBindingNavigator.SuspendLayout()
        CType(Me.TblProjectStaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProjectStaffBindingSource
        '
        Me.TblProjectStaffBindingSource.DataMember = "tblProjectStaff"
        Me.TblProjectStaffBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblProjectStaffTableAdapter
        '
        Me.TblProjectStaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblEducationTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionScedulesTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsReportTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformances_TableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformanceTypes_TableAdapter = Nothing
        Me.TableAdapterManager.tblProjectPhasesTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectStaffTableAdapter = Me.TblProjectStaffTableAdapter
        Me.TableAdapterManager.tblProjectTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectTypeTableAdapter = Nothing
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
        'TblProjectStaffBindingNavigator
        '
        Me.TblProjectStaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblProjectStaffBindingNavigator.BindingSource = Me.TblProjectStaffBindingSource
        Me.TblProjectStaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblProjectStaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblProjectStaffBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblProjectStaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblProjectStaffBindingNavigatorSaveItem})
        Me.TblProjectStaffBindingNavigator.Location = New System.Drawing.Point(36, 195)
        Me.TblProjectStaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblProjectStaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblProjectStaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblProjectStaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblProjectStaffBindingNavigator.Name = "TblProjectStaffBindingNavigator"
        Me.TblProjectStaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblProjectStaffBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.TblProjectStaffBindingNavigator.TabIndex = 3
        Me.TblProjectStaffBindingNavigator.Text = "BindingNavigator1"
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
        'TblProjectStaffBindingNavigatorSaveItem
        '
        Me.TblProjectStaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblProjectStaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblProjectStaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblProjectStaffBindingNavigatorSaveItem.Name = "TblProjectStaffBindingNavigatorSaveItem"
        Me.TblProjectStaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblProjectStaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblProjectStaffDataGridView
        '
        Me.TblProjectStaffDataGridView.AutoGenerateColumns = False
        Me.TblProjectStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProjectStaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.projectStaffId, Me.projectId, Me.staffId, Me.projectStaffDuties, Me.projectStaffCategory, Me.projectStaffComments})
        Me.TblProjectStaffDataGridView.DataSource = Me.TblProjectStaffBindingSource
        Me.TblProjectStaffDataGridView.Location = New System.Drawing.Point(36, 233)
        Me.TblProjectStaffDataGridView.Name = "TblProjectStaffDataGridView"
        Me.TblProjectStaffDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblProjectStaffDataGridView.TabIndex = 4
        '
        'projectStaffId
        '
        Me.projectStaffId.DataPropertyName = "projectStaffId"
        Me.projectStaffId.HeaderText = "projectStaffId"
        Me.projectStaffId.Name = "projectStaffId"
        Me.projectStaffId.ReadOnly = True
        '
        'projectId
        '
        Me.projectId.DataPropertyName = "projectId"
        Me.projectId.HeaderText = "projectId"
        Me.projectId.Name = "projectId"
        '
        'staffId
        '
        Me.staffId.DataPropertyName = "staffId"
        Me.staffId.DataSource = Me.VwStaffBindingSource
        Me.staffId.DisplayMember = "staffFullname"
        Me.staffId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.staffId.HeaderText = "staffId"
        Me.staffId.Name = "staffId"
        Me.staffId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.staffId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.staffId.ValueMember = "staffId"
        '
        'VwStaffBindingSource
        '
        Me.VwStaffBindingSource.DataMember = "vwStaff"
        Me.VwStaffBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'projectStaffDuties
        '
        Me.projectStaffDuties.DataPropertyName = "projectStaffDuties"
        Me.projectStaffDuties.HeaderText = "projectStaffDuties"
        Me.projectStaffDuties.Name = "projectStaffDuties"
        '
        'projectStaffCategory
        '
        Me.projectStaffCategory.DataPropertyName = "projectStaffCategory"
        Me.projectStaffCategory.HeaderText = "projectStaffCategory"
        Me.projectStaffCategory.Name = "projectStaffCategory"
        '
        'projectStaffComments
        '
        Me.projectStaffComments.DataPropertyName = "projectStaffComments"
        Me.projectStaffComments.HeaderText = "projectStaffComments"
        Me.projectStaffComments.Name = "projectStaffComments"
        '
        'VwStaffTableAdapter
        '
        Me.VwStaffTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Έργο :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(68, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'frmProjectStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 739)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblProjectStaffDataGridView)
        Me.Controls.Add(Me.TblProjectStaffBindingNavigator)
        Me.Name = "frmProjectStaff"
        Me.Controls.SetChildIndex(Me.TblProjectStaffBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblProjectStaffDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProjectStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProjectStaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblProjectStaffBindingNavigator.ResumeLayout(False)
        Me.TblProjectStaffBindingNavigator.PerformLayout()
        CType(Me.TblProjectStaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblProjectStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProjectStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblProjectStaffTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProjectStaffBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblProjectStaffBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblProjectStaffDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
    Friend WithEvents projectStaffId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents projectStaffDuties As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectStaffCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectStaffComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
