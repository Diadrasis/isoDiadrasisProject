<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSatisfSurveyDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerSatisfSurveyDetails))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblQACustomerSatisfactionSurveyDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblQACustomerSatisfactionSurveyDetailsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQACustomerSatisfactionSurveyDetailsTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.cusSatisfSurvDetID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cusSatisfSurvID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cusSatisfCritID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VcCustomSatCritBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cusSatisfMarkID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TblQACustomerSatisfactionMarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cusSatisfDetComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VcCustomSatCritTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcCustomSatCritTableAdapter
        Me.TblQACustomerSatisfactionMarksTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQACustomerSatisfactionMarksTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQACustomerSatisfactionSurveyDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.SuspendLayout()
        CType(Me.TblQACustomerSatisfactionSurveyDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcCustomSatCritBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQACustomerSatisfactionMarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblQACustomerSatisfactionSurveyDetailsBindingSource
        '
        Me.TblQACustomerSatisfactionSurveyDetailsBindingSource.DataMember = "tblQACustomerSatisfactionSurveyDetails"
        Me.TblQACustomerSatisfactionSurveyDetailsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblQACustomerSatisfactionSurveyDetailsTableAdapter
        '
        Me.TblQACustomerSatisfactionSurveyDetailsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblNonConformances_TableAdapter = Nothing
        Me.TableAdapterManager.tblNonConformanceTypes_TableAdapter = Nothing
        Me.TableAdapterManager.tblProjectPhasesTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveyDetailsTableAdapter = Me.TblQACustomerSatisfactionSurveyDetailsTableAdapter
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
        'TblQACustomerSatisfactionSurveyDetailsBindingNavigator
        '
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.BindingSource = Me.TblQACustomerSatisfactionSurveyDetailsBindingSource
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem})
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.Name = "TblQACustomerSatisfactionSurveyDetailsBindingNavigator"
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.TabIndex = 2
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.Text = "BindingNavigator1"
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
        'TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem
        '
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem.Name = "TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem"
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQACustomerSatisfactionSurveyDetailsDataGridView
        '
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView.AutoGenerateColumns = False
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cusSatisfSurvDetID, Me.cusSatisfSurvID, Me.cusSatisfCritID, Me.cusSatisfMarkID, Me.cusSatisfDetComments})
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView.DataSource = Me.TblQACustomerSatisfactionSurveyDetailsBindingSource
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView.Location = New System.Drawing.Point(91, 231)
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView.Name = "TblQACustomerSatisfactionSurveyDetailsDataGridView"
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblQACustomerSatisfactionSurveyDetailsDataGridView.TabIndex = 4
        '
        'cusSatisfSurvDetID
        '
        Me.cusSatisfSurvDetID.DataPropertyName = "cusSatisfSurvDetID"
        Me.cusSatisfSurvDetID.HeaderText = "cusSatisfSurvDetID"
        Me.cusSatisfSurvDetID.Name = "cusSatisfSurvDetID"
        Me.cusSatisfSurvDetID.ReadOnly = True
        '
        'cusSatisfSurvID
        '
        Me.cusSatisfSurvID.DataPropertyName = "cusSatisfSurvID"
        Me.cusSatisfSurvID.HeaderText = "cusSatisfSurvID"
        Me.cusSatisfSurvID.Name = "cusSatisfSurvID"
        '
        'cusSatisfCritID
        '
        Me.cusSatisfCritID.DataPropertyName = "cusSatisfCritID"
        Me.cusSatisfCritID.DataSource = Me.VcCustomSatCritBindingSource
        Me.cusSatisfCritID.DisplayMember = "cusSatisfCritTitle"
        Me.cusSatisfCritID.HeaderText = "cusSatisfCritID"
        Me.cusSatisfCritID.Name = "cusSatisfCritID"
        Me.cusSatisfCritID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cusSatisfCritID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cusSatisfCritID.ValueMember = "cusSatisfCritID"
        '
        'VcCustomSatCritBindingSource
        '
        Me.VcCustomSatCritBindingSource.DataMember = "vcCustomSatCrit"
        Me.VcCustomSatCritBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'cusSatisfMarkID
        '
        Me.cusSatisfMarkID.DataPropertyName = "cusSatisfMarkID"
        Me.cusSatisfMarkID.DataSource = Me.TblQACustomerSatisfactionMarksBindingSource
        Me.cusSatisfMarkID.DisplayMember = "cusSatisfMarkValue"
        Me.cusSatisfMarkID.HeaderText = "cusSatisfMarkID"
        Me.cusSatisfMarkID.Name = "cusSatisfMarkID"
        Me.cusSatisfMarkID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cusSatisfMarkID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cusSatisfMarkID.ValueMember = "cusSatisfMarkID"
        '
        'TblQACustomerSatisfactionMarksBindingSource
        '
        Me.TblQACustomerSatisfactionMarksBindingSource.DataMember = "tblQACustomerSatisfactionMarks"
        Me.TblQACustomerSatisfactionMarksBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'cusSatisfDetComments
        '
        Me.cusSatisfDetComments.DataPropertyName = "cusSatisfDetComments"
        Me.cusSatisfDetComments.HeaderText = "cusSatisfDetComments"
        Me.cusSatisfDetComments.Name = "cusSatisfDetComments"
        '
        'VcCustomSatCritTableAdapter
        '
        Me.VcCustomSatCritTableAdapter.ClearBeforeFill = True
        '
        'TblQACustomerSatisfactionMarksTableAdapter
        '
        Me.TblQACustomerSatisfactionMarksTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Button4
        '
        Me.Button4.Image = Global.diadrasisProjects.My.Resources.Resources.chart_pie
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(695, 146)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 60)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Αναφορά"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmCustomerSatisfSurveyDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblQACustomerSatisfactionSurveyDetailsDataGridView)
        Me.Controls.Add(Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator)
        Me.Name = "frmCustomerSatisfSurveyDetails"
        Me.Controls.SetChildIndex(Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQACustomerSatisfactionSurveyDetailsDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQACustomerSatisfactionSurveyDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.ResumeLayout(False)
        Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator.PerformLayout()
        CType(Me.TblQACustomerSatisfactionSurveyDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcCustomSatCritBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQACustomerSatisfactionMarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblQACustomerSatisfactionSurveyDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQACustomerSatisfactionSurveyDetailsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQACustomerSatisfactionSurveyDetailsTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQACustomerSatisfactionSurveyDetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQACustomerSatisfactionSurveyDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VcCustomSatCritBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcCustomSatCritTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcCustomSatCritTableAdapter
    Friend WithEvents TblQACustomerSatisfactionMarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQACustomerSatisfactionMarksTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQACustomerSatisfactionMarksTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cusSatisfSurvDetID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cusSatisfSurvID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cusSatisfCritID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cusSatisfMarkID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cusSatisfDetComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
