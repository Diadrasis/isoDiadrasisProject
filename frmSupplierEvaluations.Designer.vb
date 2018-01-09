<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierEvaluations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplierEvaluations))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblQASupplierSatisfactionSurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblQASupplierSatisfactionSurveysTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQASupplierSatisfactionSurveysTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblQASupplierSatisfactionSurveysBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQASupplierSatisfactionSurveysDataGridView = New System.Windows.Forms.DataGridView
        Me.VcSupplierEvaluationMarkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VcSupplierEvaluationMarkBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VcSupplierEvaluationMarkTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcSupplierEvaluationMarkTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.supSatisfSurvID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.supplierID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.supSatisfSurvComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.supSatisfSurvDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.supSatisfSurvType = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.supSatisfPrevMarkID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.supSatisfMarkID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.supSatisfSurvReport = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQASupplierSatisfactionSurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQASupplierSatisfactionSurveysBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.SuspendLayout()
        CType(Me.TblQASupplierSatisfactionSurveysDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcSupplierEvaluationMarkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcSupplierEvaluationMarkBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblQASupplierSatisfactionSurveysBindingSource
        '
        Me.TblQASupplierSatisfactionSurveysBindingSource.DataMember = "tblQASupplierSatisfactionSurveys"
        Me.TblQASupplierSatisfactionSurveysBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblQASupplierSatisfactionSurveysTableAdapter
        '
        Me.TblQASupplierSatisfactionSurveysTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblQASupplierSatisfactionSurveysTableAdapter = Me.TblQASupplierSatisfactionSurveysTableAdapter
        Me.TableAdapterManager.tblRevComitMeetingRecommedationsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingTopicsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingTopicTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningProgrammesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblQASupplierSatisfactionSurveysBindingNavigator
        '
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.BindingSource = Me.TblQASupplierSatisfactionSurveysBindingSource
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem})
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.Name = "TblQASupplierSatisfactionSurveysBindingNavigator"
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.TabIndex = 2
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.Text = "BindingNavigator1"
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
        'TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem
        '
        Me.TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem.Name = "TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem"
        Me.TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQASupplierSatisfactionSurveysDataGridView
        '
        Me.TblQASupplierSatisfactionSurveysDataGridView.AutoGenerateColumns = False
        Me.TblQASupplierSatisfactionSurveysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQASupplierSatisfactionSurveysDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supSatisfSurvID, Me.supplierID, Me.supSatisfSurvComments, Me.supSatisfSurvDate, Me.supSatisfSurvType, Me.supSatisfPrevMarkID, Me.supSatisfMarkID, Me.supSatisfSurvReport})
        Me.TblQASupplierSatisfactionSurveysDataGridView.DataSource = Me.TblQASupplierSatisfactionSurveysBindingSource
        Me.TblQASupplierSatisfactionSurveysDataGridView.Location = New System.Drawing.Point(98, 204)
        Me.TblQASupplierSatisfactionSurveysDataGridView.Name = "TblQASupplierSatisfactionSurveysDataGridView"
        Me.TblQASupplierSatisfactionSurveysDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblQASupplierSatisfactionSurveysDataGridView.TabIndex = 4
        '
        'VcSupplierEvaluationMarkBindingSource
        '
        Me.VcSupplierEvaluationMarkBindingSource.DataMember = "vcSupplierEvaluationMark"
        Me.VcSupplierEvaluationMarkBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VcSupplierEvaluationMarkBindingSource1
        '
        Me.VcSupplierEvaluationMarkBindingSource1.DataMember = "vcSupplierEvaluationMark"
        Me.VcSupplierEvaluationMarkBindingSource1.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VcSupplierEvaluationMarkTableAdapter
        '
        Me.VcSupplierEvaluationMarkTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'supSatisfSurvID
        '
        Me.supSatisfSurvID.DataPropertyName = "supSatisfSurvID"
        Me.supSatisfSurvID.HeaderText = "supSatisfSurvID"
        Me.supSatisfSurvID.Name = "supSatisfSurvID"
        Me.supSatisfSurvID.ReadOnly = True
        '
        'supplierID
        '
        Me.supplierID.DataPropertyName = "supplierID"
        Me.supplierID.HeaderText = "supplierID"
        Me.supplierID.Name = "supplierID"
        '
        'supSatisfSurvComments
        '
        Me.supSatisfSurvComments.DataPropertyName = "supSatisfSurvComments"
        Me.supSatisfSurvComments.HeaderText = "supSatisfSurvComments"
        Me.supSatisfSurvComments.Name = "supSatisfSurvComments"
        '
        'supSatisfSurvDate
        '
        Me.supSatisfSurvDate.DataPropertyName = "supSatisfSurvDate"
        Me.supSatisfSurvDate.HeaderText = "supSatisfSurvDate"
        Me.supSatisfSurvDate.Name = "supSatisfSurvDate"
        '
        'supSatisfSurvType
        '
        Me.supSatisfSurvType.DataPropertyName = "supSatisfSurvType"
        Me.supSatisfSurvType.HeaderText = "supSatisfSurvType"
        Me.supSatisfSurvType.Items.AddRange(New Object() {"Αρχική", "Μετά από Συνεργασία"})
        Me.supSatisfSurvType.Name = "supSatisfSurvType"
        Me.supSatisfSurvType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supSatisfSurvType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'supSatisfPrevMarkID
        '
        Me.supSatisfPrevMarkID.DataPropertyName = "supSatisfPrevMarkID"
        Me.supSatisfPrevMarkID.DataSource = Me.VcSupplierEvaluationMarkBindingSource
        Me.supSatisfPrevMarkID.DisplayMember = "supSatisfMarkValue"
        Me.supSatisfPrevMarkID.HeaderText = "supSatisfPrevMarkID"
        Me.supSatisfPrevMarkID.Name = "supSatisfPrevMarkID"
        Me.supSatisfPrevMarkID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supSatisfPrevMarkID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.supSatisfPrevMarkID.ValueMember = "supSatisfMarkID"
        '
        'supSatisfMarkID
        '
        Me.supSatisfMarkID.DataPropertyName = "supSatisfMarkID"
        Me.supSatisfMarkID.DataSource = Me.VcSupplierEvaluationMarkBindingSource1
        Me.supSatisfMarkID.DisplayMember = "supSatisfMarkValue"
        Me.supSatisfMarkID.HeaderText = "supSatisfMarkID"
        Me.supSatisfMarkID.Name = "supSatisfMarkID"
        Me.supSatisfMarkID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supSatisfMarkID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.supSatisfMarkID.ValueMember = "supSatisfMarkID"
        '
        'supSatisfSurvReport
        '
        Me.supSatisfSurvReport.HeaderText = "supSatisfSurvReport"
        Me.supSatisfSurvReport.Image = Global.diadrasisProjects.My.Resources.Resources.reports
        Me.supSatisfSurvReport.Name = "supSatisfSurvReport"
        '
        'frmSupplierEvaluations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblQASupplierSatisfactionSurveysDataGridView)
        Me.Controls.Add(Me.TblQASupplierSatisfactionSurveysBindingNavigator)
        Me.Name = "frmSupplierEvaluations"
        Me.Controls.SetChildIndex(Me.TblQASupplierSatisfactionSurveysBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQASupplierSatisfactionSurveysDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQASupplierSatisfactionSurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQASupplierSatisfactionSurveysBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.ResumeLayout(False)
        Me.TblQASupplierSatisfactionSurveysBindingNavigator.PerformLayout()
        CType(Me.TblQASupplierSatisfactionSurveysDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcSupplierEvaluationMarkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcSupplierEvaluationMarkBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblQASupplierSatisfactionSurveysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQASupplierSatisfactionSurveysTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQASupplierSatisfactionSurveysTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQASupplierSatisfactionSurveysBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQASupplierSatisfactionSurveysDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VcSupplierEvaluationMarkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcSupplierEvaluationMarkTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcSupplierEvaluationMarkTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents VcSupplierEvaluationMarkBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents supSatisfSurvID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supSatisfSurvComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supSatisfSurvDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supSatisfSurvType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents supSatisfPrevMarkID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents supSatisfMarkID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents supSatisfSurvReport As System.Windows.Forms.DataGridViewImageColumn

End Class
