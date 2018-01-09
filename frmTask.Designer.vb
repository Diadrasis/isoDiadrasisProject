<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTask
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTask))
        Me.TblTaskBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblTaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblTaskBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblTaskDataGridView = New System.Windows.Forms.DataGridView()
        Me.taskId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taskName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taskReasonID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VcTaskReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.projectPhaseID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VcProjectPhaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.taskDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taskDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taskHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VwStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.taskCompleted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.taskComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TblTaskTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTaskTableAdapter()
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager()
        Me.VwStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter()
        Me.VcTaskReasonTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcTaskReasonTableAdapter()
        Me.VcProjectPhaseTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcProjectPhaseTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TblTaskBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTaskBindingNavigator.SuspendLayout()
        CType(Me.TblTaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTaskDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcTaskReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcProjectPhaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TblTaskBindingNavigator
        '
        Me.TblTaskBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTaskBindingNavigator.BindingSource = Me.TblTaskBindingSource
        Me.TblTaskBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTaskBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTaskBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblTaskBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTaskBindingNavigatorSaveItem})
        Me.TblTaskBindingNavigator.Location = New System.Drawing.Point(70, 214)
        Me.TblTaskBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTaskBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTaskBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTaskBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTaskBindingNavigator.Name = "TblTaskBindingNavigator"
        Me.TblTaskBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTaskBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.TblTaskBindingNavigator.TabIndex = 2
        Me.TblTaskBindingNavigator.Text = "BindingNavigator1"
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
        'TblTaskBindingSource
        '
        Me.TblTaskBindingSource.DataMember = "tblTask"
        Me.TblTaskBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
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
        'TblTaskBindingNavigatorSaveItem
        '
        Me.TblTaskBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTaskBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTaskBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTaskBindingNavigatorSaveItem.Name = "TblTaskBindingNavigatorSaveItem"
        Me.TblTaskBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTaskBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTaskDataGridView
        '
        Me.TblTaskDataGridView.AutoGenerateColumns = False
        Me.TblTaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTaskDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.taskId, Me.taskName, Me.taskReasonID, Me.projectPhaseID, Me.taskDescription, Me.taskDate, Me.taskHours, Me.staffId, Me.taskCompleted, Me.taskComments, Me.projectId})
        Me.TblTaskDataGridView.DataSource = Me.TblTaskBindingSource
        Me.TblTaskDataGridView.Location = New System.Drawing.Point(70, 264)
        Me.TblTaskDataGridView.Name = "TblTaskDataGridView"
        Me.TblTaskDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblTaskDataGridView.TabIndex = 3
        '
        'taskId
        '
        Me.taskId.DataPropertyName = "taskId"
        Me.taskId.HeaderText = "taskId"
        Me.taskId.Name = "taskId"
        Me.taskId.ReadOnly = True
        '
        'taskName
        '
        Me.taskName.DataPropertyName = "taskName"
        Me.taskName.HeaderText = "taskName"
        Me.taskName.Name = "taskName"
        '
        'taskReasonID
        '
        Me.taskReasonID.DataPropertyName = "taskReasonID"
        Me.taskReasonID.DataSource = Me.VcTaskReasonBindingSource
        Me.taskReasonID.DisplayMember = "taskReasonDesc"
        Me.taskReasonID.HeaderText = "taskReasonID"
        Me.taskReasonID.Name = "taskReasonID"
        Me.taskReasonID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.taskReasonID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.taskReasonID.ValueMember = "taskReasonID"
        '
        'VcTaskReasonBindingSource
        '
        Me.VcTaskReasonBindingSource.DataMember = "vcTaskReason"
        Me.VcTaskReasonBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'projectPhaseID
        '
        Me.projectPhaseID.DataPropertyName = "projectPhaseID"
        Me.projectPhaseID.DataSource = Me.VcProjectPhaseBindingSource
        Me.projectPhaseID.DisplayMember = "projPhaseDesc"
        Me.projectPhaseID.HeaderText = "projectPhaseID"
        Me.projectPhaseID.Name = "projectPhaseID"
        Me.projectPhaseID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.projectPhaseID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.projectPhaseID.ValueMember = "projPhaseID"
        '
        'VcProjectPhaseBindingSource
        '
        Me.VcProjectPhaseBindingSource.DataMember = "vcProjectPhase"
        Me.VcProjectPhaseBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'taskDescription
        '
        Me.taskDescription.DataPropertyName = "taskDescription"
        Me.taskDescription.HeaderText = "taskDescription"
        Me.taskDescription.Name = "taskDescription"
        '
        'taskDate
        '
        Me.taskDate.DataPropertyName = "taskDate"
        Me.taskDate.HeaderText = "taskDate"
        Me.taskDate.Name = "taskDate"
        '
        'taskHours
        '
        Me.taskHours.DataPropertyName = "taskHours"
        Me.taskHours.HeaderText = "taskHours"
        Me.taskHours.Name = "taskHours"
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
        'taskCompleted
        '
        Me.taskCompleted.DataPropertyName = "taskCompleted"
        Me.taskCompleted.HeaderText = "taskCompleted"
        Me.taskCompleted.Name = "taskCompleted"
        '
        'taskComments
        '
        Me.taskComments.DataPropertyName = "taskComments"
        Me.taskComments.HeaderText = "taskComments"
        Me.taskComments.Name = "taskComments"
        '
        'projectId
        '
        Me.projectId.DataPropertyName = "projectId"
        Me.projectId.HeaderText = "projectId"
        Me.projectId.Name = "projectId"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(904, 183)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'TblTaskTableAdapter
        '
        Me.TblTaskTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblInvoicesTableAdapter = Nothing
        Me.TableAdapterManager.tblInvoiceTypesTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformances_TableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformanceTypes_TableAdapter = Nothing
        Me.TableAdapterManager.tblProjectPhasesTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectStaffTableAdapter = Nothing
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
        Me.TableAdapterManager.tblTaskTableAdapter = Me.TblTaskTableAdapter
        Me.TableAdapterManager.tblTrainningEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningProgrammesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VwStaffTableAdapter
        '
        Me.VwStaffTableAdapter.ClearBeforeFill = True
        '
        'VcTaskReasonTableAdapter
        '
        Me.VcTaskReasonTableAdapter.ClearBeforeFill = True
        '
        'VcProjectPhaseTableAdapter
        '
        Me.VcProjectPhaseTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Image = Global.diadrasisProjects.My.Resources.Resources.chart_pie
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(547, 509)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 60)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Αναφορές"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(110, 32)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Location = New System.Drawing.Point(278, 540)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 65)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Φίλτρα"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Εώς"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Από"
        '
        'frmTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.TblTaskDataGridView)
        Me.Controls.Add(Me.TblTaskBindingNavigator)
        Me.Name = "frmTask"
        Me.Controls.SetChildIndex(Me.TblTaskBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblTaskDataGridView, 0)
        Me.Controls.SetChildIndex(Me.MonthCalendar1, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        CType(Me.TblTaskBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTaskBindingNavigator.ResumeLayout(False)
        Me.TblTaskBindingNavigator.PerformLayout()
        CType(Me.TblTaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTaskDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcTaskReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcProjectPhaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblTaskBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTaskTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTaskTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTaskBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblTaskBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblTaskDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents VwStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
    Friend WithEvents VcTaskReasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcTaskReasonTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcTaskReasonTableAdapter
    Friend WithEvents VcProjectPhaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcProjectPhaseTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcProjectPhaseTableAdapter
    Friend WithEvents taskId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taskName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taskReasonID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents projectPhaseID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents taskDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taskDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taskHours As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents taskCompleted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents taskComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
