<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainningProgrammes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrainningProgrammes))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblTrainningProgrammesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTrainningProgrammesTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTrainningProgrammesTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblTrainningProgrammesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblTrainningProgrammesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblTrainningProgrammesDataGridView = New System.Windows.Forms.DataGridView
        Me.trainProgID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainProgYear = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainProgTopics = New System.Windows.Forms.DataGridViewImageColumn
        Me.trainProgReport = New System.Windows.Forms.DataGridViewImageColumn
        Me.trainProgComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrainningProgrammesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrainningProgrammesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTrainningProgrammesBindingNavigator.SuspendLayout()
        CType(Me.TblTrainningProgrammesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTrainningProgrammesBindingSource
        '
        Me.TblTrainningProgrammesBindingSource.DataMember = "tblTrainningProgrammes"
        Me.TblTrainningProgrammesBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblTrainningProgrammesTableAdapter
        '
        Me.TblTrainningProgrammesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblTrainningProgrammesTableAdapter = Me.TblTrainningProgrammesTableAdapter
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTrainningProgrammesBindingNavigator
        '
        Me.TblTrainningProgrammesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTrainningProgrammesBindingNavigator.BindingSource = Me.TblTrainningProgrammesBindingSource
        Me.TblTrainningProgrammesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTrainningProgrammesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTrainningProgrammesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTrainningProgrammesBindingNavigatorSaveItem})
        Me.TblTrainningProgrammesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTrainningProgrammesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTrainningProgrammesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTrainningProgrammesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTrainningProgrammesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTrainningProgrammesBindingNavigator.Name = "TblTrainningProgrammesBindingNavigator"
        Me.TblTrainningProgrammesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTrainningProgrammesBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblTrainningProgrammesBindingNavigator.TabIndex = 2
        Me.TblTrainningProgrammesBindingNavigator.Text = "BindingNavigator1"
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
        'TblTrainningProgrammesBindingNavigatorSaveItem
        '
        Me.TblTrainningProgrammesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTrainningProgrammesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTrainningProgrammesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTrainningProgrammesBindingNavigatorSaveItem.Name = "TblTrainningProgrammesBindingNavigatorSaveItem"
        Me.TblTrainningProgrammesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTrainningProgrammesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTrainningProgrammesDataGridView
        '
        Me.TblTrainningProgrammesDataGridView.AutoGenerateColumns = False
        Me.TblTrainningProgrammesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTrainningProgrammesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trainProgID, Me.trainProgYear, Me.trainProgTopics, Me.trainProgReport, Me.trainProgComments})
        Me.TblTrainningProgrammesDataGridView.DataSource = Me.TblTrainningProgrammesBindingSource
        Me.TblTrainningProgrammesDataGridView.Location = New System.Drawing.Point(112, 219)
        Me.TblTrainningProgrammesDataGridView.Name = "TblTrainningProgrammesDataGridView"
        Me.TblTrainningProgrammesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblTrainningProgrammesDataGridView.TabIndex = 3
        '
        'trainProgID
        '
        Me.trainProgID.DataPropertyName = "trainProgID"
        Me.trainProgID.HeaderText = "trainProgID"
        Me.trainProgID.Name = "trainProgID"
        Me.trainProgID.ReadOnly = True
        '
        'trainProgYear
        '
        Me.trainProgYear.DataPropertyName = "trainProgYear"
        Me.trainProgYear.HeaderText = "trainProgYear"
        Me.trainProgYear.Name = "trainProgYear"
        '
        'trainProgTopics
        '
        Me.trainProgTopics.HeaderText = "trainProgTopics"
        Me.trainProgTopics.Image = Global.diadrasisProjects.My.Resources.Resources.book
        Me.trainProgTopics.Name = "trainProgTopics"
        '
        'trainProgReport
        '
        Me.trainProgReport.HeaderText = "trainProgReport"
        Me.trainProgReport.Image = Global.diadrasisProjects.My.Resources.Resources.reports
        Me.trainProgReport.Name = "trainProgReport"
        '
        'trainProgComments
        '
        Me.trainProgComments.DataPropertyName = "trainProgComments"
        Me.trainProgComments.HeaderText = "trainProgComments"
        Me.trainProgComments.Name = "trainProgComments"
        '
        'frmTrainningProgrammes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.TblTrainningProgrammesDataGridView)
        Me.Controls.Add(Me.TblTrainningProgrammesBindingNavigator)
        Me.Name = "frmTrainningProgrammes"
        Me.Controls.SetChildIndex(Me.TblTrainningProgrammesBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblTrainningProgrammesDataGridView, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrainningProgrammesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrainningProgrammesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTrainningProgrammesBindingNavigator.ResumeLayout(False)
        Me.TblTrainningProgrammesBindingNavigator.PerformLayout()
        CType(Me.TblTrainningProgrammesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblTrainningProgrammesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTrainningProgrammesTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTrainningProgrammesTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTrainningProgrammesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblTrainningProgrammesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblTrainningProgrammesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainProgID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainProgYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainProgTopics As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents trainProgReport As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents trainProgComments As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
