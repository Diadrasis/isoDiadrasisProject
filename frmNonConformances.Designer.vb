<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNonConformances
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNonConformances))
        Me.TblNonConformances_BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.TblNonConformances_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TblNonConformances_BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblNonConformances_DataGridView = New System.Windows.Forms.DataGridView
        Me.nonConfID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nonConfDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nonConfTypeID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VcNonConformanceTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nonConfDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nonConfActions = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nonConfPreventActions = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inspectorID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inspectedID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.nonConfReport = New System.Windows.Forms.DataGridViewImageColumn
        Me.nonConfMesures = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nonConfPreventing = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nonConfChecked = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TblNonConformances_TableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblNonConformances_TableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.VcNonConformanceTypeTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcNonConformanceTypeTableAdapter
        Me.VwStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
        CType(Me.TblNonConformances_BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblNonConformances_BindingNavigator.SuspendLayout()
        CType(Me.TblNonConformances_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblNonConformances_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcNonConformanceTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblNonConformances_BindingNavigator
        '
        Me.TblNonConformances_BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblNonConformances_BindingNavigator.BindingSource = Me.TblNonConformances_BindingSource
        Me.TblNonConformances_BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblNonConformances_BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblNonConformances_BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblNonConformances_BindingNavigatorSaveItem})
        Me.TblNonConformances_BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblNonConformances_BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblNonConformances_BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblNonConformances_BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblNonConformances_BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblNonConformances_BindingNavigator.Name = "TblNonConformances_BindingNavigator"
        Me.TblNonConformances_BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblNonConformances_BindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblNonConformances_BindingNavigator.TabIndex = 2
        Me.TblNonConformances_BindingNavigator.Text = "BindingNavigator1"
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
        'TblNonConformances_BindingSource
        '
        Me.TblNonConformances_BindingSource.DataMember = "tblNonConformances "
        Me.TblNonConformances_BindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
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
        'TblNonConformances_BindingNavigatorSaveItem
        '
        Me.TblNonConformances_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblNonConformances_BindingNavigatorSaveItem.Image = CType(resources.GetObject("TblNonConformances_BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblNonConformances_BindingNavigatorSaveItem.Name = "TblNonConformances_BindingNavigatorSaveItem"
        Me.TblNonConformances_BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblNonConformances_BindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblNonConformances_DataGridView
        '
        Me.TblNonConformances_DataGridView.AutoGenerateColumns = False
        Me.TblNonConformances_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblNonConformances_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nonConfID, Me.nonConfDate, Me.nonConfTypeID, Me.nonConfDescription, Me.nonConfActions, Me.nonConfPreventActions, Me.inspectorID, Me.inspectedID, Me.nonConfReport, Me.nonConfMesures, Me.nonConfPreventing, Me.nonConfChecked})
        Me.TblNonConformances_DataGridView.DataSource = Me.TblNonConformances_BindingSource
        Me.TblNonConformances_DataGridView.Location = New System.Drawing.Point(110, 291)
        Me.TblNonConformances_DataGridView.Name = "TblNonConformances_DataGridView"
        Me.TblNonConformances_DataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblNonConformances_DataGridView.TabIndex = 3
        '
        'nonConfID
        '
        Me.nonConfID.DataPropertyName = "nonConfID"
        Me.nonConfID.HeaderText = "nonConfID"
        Me.nonConfID.Name = "nonConfID"
        Me.nonConfID.ReadOnly = True
        '
        'nonConfDate
        '
        Me.nonConfDate.DataPropertyName = "nonConfDate"
        Me.nonConfDate.HeaderText = "nonConfDate"
        Me.nonConfDate.Name = "nonConfDate"
        '
        'nonConfTypeID
        '
        Me.nonConfTypeID.DataPropertyName = "nonConfTypeID"
        Me.nonConfTypeID.DataSource = Me.VcNonConformanceTypeBindingSource
        Me.nonConfTypeID.DisplayMember = "nonConfTypeDescription"
        Me.nonConfTypeID.HeaderText = "nonConfTypeID"
        Me.nonConfTypeID.Name = "nonConfTypeID"
        Me.nonConfTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nonConfTypeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.nonConfTypeID.ValueMember = "nonConfTypeID"
        '
        'VcNonConformanceTypeBindingSource
        '
        Me.VcNonConformanceTypeBindingSource.DataMember = "vcNonConformanceType"
        Me.VcNonConformanceTypeBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'nonConfDescription
        '
        Me.nonConfDescription.DataPropertyName = "nonConfDescription"
        Me.nonConfDescription.HeaderText = "nonConfDescription"
        Me.nonConfDescription.Name = "nonConfDescription"
        '
        'nonConfActions
        '
        Me.nonConfActions.DataPropertyName = "nonConfActions"
        Me.nonConfActions.HeaderText = "nonConfActions"
        Me.nonConfActions.Name = "nonConfActions"
        '
        'nonConfPreventActions
        '
        Me.nonConfPreventActions.DataPropertyName = "nonConfPreventActions"
        Me.nonConfPreventActions.HeaderText = "nonConfPreventActions"
        Me.nonConfPreventActions.Name = "nonConfPreventActions"
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
        'nonConfReport
        '
        Me.nonConfReport.HeaderText = "nonConfReport"
        Me.nonConfReport.Image = Global.diadrasisProjects.My.Resources.Resources.reports
        Me.nonConfReport.Name = "nonConfReport"
        Me.nonConfReport.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nonConfReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'nonConfMesures
        '
        Me.nonConfMesures.DataPropertyName = "nonConfMesures"
        Me.nonConfMesures.HeaderText = "nonConfMesures"
        Me.nonConfMesures.Name = "nonConfMesures"
        '
        'nonConfPreventing
        '
        Me.nonConfPreventing.DataPropertyName = "nonConfPreventing"
        Me.nonConfPreventing.HeaderText = "nonConfPreventing"
        Me.nonConfPreventing.Name = "nonConfPreventing"
        '
        'nonConfChecked
        '
        Me.nonConfChecked.DataPropertyName = "nonConfChecked"
        Me.nonConfChecked.HeaderText = "nonConfChecked"
        Me.nonConfChecked.Name = "nonConfChecked"
        '
        'TblNonConformances_TableAdapter
        '
        Me.TblNonConformances_TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionScedulesTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsReportTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionsTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformances_TableAdapter = Me.TblNonConformances_TableAdapter
        Me.TableAdapterManager.tblNonConformanceTypes_TableAdapter = Nothing
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
        'VcNonConformanceTypeTableAdapter
        '
        Me.VcNonConformanceTypeTableAdapter.ClearBeforeFill = True
        '
        'VwStaffTableAdapter
        '
        Me.VwStaffTableAdapter.ClearBeforeFill = True
        '
        'frmNonConformances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.TblNonConformances_DataGridView)
        Me.Controls.Add(Me.TblNonConformances_BindingNavigator)
        Me.Name = "frmNonConformances"
        Me.Controls.SetChildIndex(Me.TblNonConformances_BindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblNonConformances_DataGridView, 0)
        CType(Me.TblNonConformances_BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblNonConformances_BindingNavigator.ResumeLayout(False)
        Me.TblNonConformances_BindingNavigator.PerformLayout()
        CType(Me.TblNonConformances_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblNonConformances_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcNonConformanceTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblNonConformances_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblNonConformances_TableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblNonConformances_TableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblNonConformances_BindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblNonConformances_BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblNonConformances_DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VcNonConformanceTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcNonConformanceTypeTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcNonConformanceTypeTableAdapter
    Friend WithEvents VwStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents VwStaffBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents nonConfReport As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents nonConfID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nonConfDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nonConfTypeID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents nonConfDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nonConfActions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nonConfPreventActions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspectorID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents inspectedID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents nonConfMesures As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nonConfPreventing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nonConfChecked As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
