<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainningTopics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrainningTopics))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblTrainningTopicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTrainningTopicTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTrainningTopicTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblTrainningTopicBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblTrainningTopicBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblTrainningTopicDataGridView = New System.Windows.Forms.DataGridView
        Me.trainTopicID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainProgID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.monthID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TblMonthsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.trainTopicName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainerID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.trainTrainees = New System.Windows.Forms.DataGridViewImageColumn
        Me.trainTopicComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblMonthsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblMonthsTableAdapter
        Me.VwStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrainningTopicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrainningTopicBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTrainningTopicBindingNavigator.SuspendLayout()
        CType(Me.TblTrainningTopicDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMonthsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTrainningTopicBindingSource
        '
        Me.TblTrainningTopicBindingSource.DataMember = "tblTrainningTopic"
        Me.TblTrainningTopicBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblTrainningTopicTableAdapter
        '
        Me.TblTrainningTopicTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblMonthsTableAdapter = Nothing
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
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningProgrammesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Me.TblTrainningTopicTableAdapter
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTrainningTopicBindingNavigator
        '
        Me.TblTrainningTopicBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTrainningTopicBindingNavigator.BindingSource = Me.TblTrainningTopicBindingSource
        Me.TblTrainningTopicBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTrainningTopicBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTrainningTopicBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTrainningTopicBindingNavigatorSaveItem})
        Me.TblTrainningTopicBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTrainningTopicBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTrainningTopicBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTrainningTopicBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTrainningTopicBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTrainningTopicBindingNavigator.Name = "TblTrainningTopicBindingNavigator"
        Me.TblTrainningTopicBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTrainningTopicBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblTrainningTopicBindingNavigator.TabIndex = 2
        Me.TblTrainningTopicBindingNavigator.Text = "BindingNavigator1"
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
        'TblTrainningTopicBindingNavigatorSaveItem
        '
        Me.TblTrainningTopicBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTrainningTopicBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTrainningTopicBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTrainningTopicBindingNavigatorSaveItem.Name = "TblTrainningTopicBindingNavigatorSaveItem"
        Me.TblTrainningTopicBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTrainningTopicBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTrainningTopicDataGridView
        '
        Me.TblTrainningTopicDataGridView.AutoGenerateColumns = False
        Me.TblTrainningTopicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTrainningTopicDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trainTopicID, Me.trainProgID, Me.monthID, Me.trainTopicName, Me.trainerID, Me.trainTrainees, Me.trainTopicComments})
        Me.TblTrainningTopicDataGridView.DataSource = Me.TblTrainningTopicBindingSource
        Me.TblTrainningTopicDataGridView.Location = New System.Drawing.Point(42, 240)
        Me.TblTrainningTopicDataGridView.Name = "TblTrainningTopicDataGridView"
        Me.TblTrainningTopicDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblTrainningTopicDataGridView.TabIndex = 3
        '
        'trainTopicID
        '
        Me.trainTopicID.DataPropertyName = "trainTopicID"
        Me.trainTopicID.HeaderText = "trainTopicID"
        Me.trainTopicID.Name = "trainTopicID"
        Me.trainTopicID.ReadOnly = True
        '
        'trainProgID
        '
        Me.trainProgID.DataPropertyName = "trainProgID"
        Me.trainProgID.HeaderText = "trainProgID"
        Me.trainProgID.Name = "trainProgID"
        '
        'monthID
        '
        Me.monthID.DataPropertyName = "monthID"
        Me.monthID.DataSource = Me.TblMonthsBindingSource
        Me.monthID.DisplayMember = "monthName"
        Me.monthID.HeaderText = "monthID"
        Me.monthID.Name = "monthID"
        Me.monthID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.monthID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.monthID.ValueMember = "monthID"
        '
        'TblMonthsBindingSource
        '
        Me.TblMonthsBindingSource.DataMember = "tblMonths"
        Me.TblMonthsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'trainTopicName
        '
        Me.trainTopicName.DataPropertyName = "trainTopicName"
        Me.trainTopicName.HeaderText = "trainTopicName"
        Me.trainTopicName.Name = "trainTopicName"
        '
        'trainerID
        '
        Me.trainerID.DataPropertyName = "trainerID"
        Me.trainerID.DataSource = Me.VwStaffBindingSource
        Me.trainerID.DisplayMember = "staffFullname"
        Me.trainerID.HeaderText = "trainerID"
        Me.trainerID.Name = "trainerID"
        Me.trainerID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trainerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.trainerID.ValueMember = "staffId"
        '
        'VwStaffBindingSource
        '
        Me.VwStaffBindingSource.DataMember = "vwStaff"
        Me.VwStaffBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'trainTrainees
        '
        Me.trainTrainees.HeaderText = "trainTrainees"
        Me.trainTrainees.Image = Global.diadrasisProjects.My.Resources.Resources.users
        Me.trainTrainees.Name = "trainTrainees"
        '
        'trainTopicComments
        '
        Me.trainTopicComments.DataPropertyName = "trainTopicComments"
        Me.trainTopicComments.HeaderText = "trainTopicComments"
        Me.trainTopicComments.Name = "trainTopicComments"
        '
        'TblMonthsTableAdapter
        '
        Me.TblMonthsTableAdapter.ClearBeforeFill = True
        '
        'VwStaffTableAdapter
        '
        Me.VwStaffTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'frmTrainningTopics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblTrainningTopicDataGridView)
        Me.Controls.Add(Me.TblTrainningTopicBindingNavigator)
        Me.Name = "frmTrainningTopics"
        Me.Controls.SetChildIndex(Me.TblTrainningTopicBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblTrainningTopicDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrainningTopicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrainningTopicBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTrainningTopicBindingNavigator.ResumeLayout(False)
        Me.TblTrainningTopicBindingNavigator.PerformLayout()
        CType(Me.TblTrainningTopicDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMonthsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblTrainningTopicBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTrainningTopicTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTrainningTopicTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTrainningTopicBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblTrainningTopicBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblTrainningTopicDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblMonthsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMonthsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblMonthsTableAdapter
    Friend WithEvents VwStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
    Friend WithEvents trainTopicID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainProgID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monthID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents trainTopicName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainerID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents trainTrainees As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents trainTopicComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
