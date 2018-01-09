<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInspectionScedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInspectionScedule))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblInspectionScedulesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInspectionScedulesTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblInspectionScedulesTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblInspectionScedulesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblInspectionScedulesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblInspectionScedulesDataGridView = New System.Windows.Forms.DataGridView
        Me.inspSceduleID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inspSceduleYear = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.inspInspections = New System.Windows.Forms.DataGridViewImageColumn
        Me.inspSceduleReport = New System.Windows.Forms.DataGridViewImageColumn
        Me.inspSceduleComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInspectionScedulesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInspectionScedulesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblInspectionScedulesBindingNavigator.SuspendLayout()
        CType(Me.TblInspectionScedulesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInspectionScedulesBindingSource
        '
        Me.TblInspectionScedulesBindingSource.DataMember = "tblInspectionScedules"
        Me.TblInspectionScedulesBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblInspectionScedulesTableAdapter
        '
        Me.TblInspectionScedulesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblDepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tblInspectionScedulesTableAdapter = Me.TblInspectionScedulesTableAdapter
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
        'TblInspectionScedulesBindingNavigator
        '
        Me.TblInspectionScedulesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblInspectionScedulesBindingNavigator.BindingSource = Me.TblInspectionScedulesBindingSource
        Me.TblInspectionScedulesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblInspectionScedulesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblInspectionScedulesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblInspectionScedulesBindingNavigatorSaveItem})
        Me.TblInspectionScedulesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblInspectionScedulesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblInspectionScedulesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblInspectionScedulesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblInspectionScedulesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblInspectionScedulesBindingNavigator.Name = "TblInspectionScedulesBindingNavigator"
        Me.TblInspectionScedulesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblInspectionScedulesBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblInspectionScedulesBindingNavigator.TabIndex = 2
        Me.TblInspectionScedulesBindingNavigator.Text = "BindingNavigator1"
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
        'TblInspectionScedulesBindingNavigatorSaveItem
        '
        Me.TblInspectionScedulesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblInspectionScedulesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblInspectionScedulesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblInspectionScedulesBindingNavigatorSaveItem.Name = "TblInspectionScedulesBindingNavigatorSaveItem"
        Me.TblInspectionScedulesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblInspectionScedulesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblInspectionScedulesDataGridView
        '
        Me.TblInspectionScedulesDataGridView.AutoGenerateColumns = False
        Me.TblInspectionScedulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInspectionScedulesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inspSceduleID, Me.inspSceduleYear, Me.inspInspections, Me.inspSceduleReport, Me.inspSceduleComments})
        Me.TblInspectionScedulesDataGridView.DataSource = Me.TblInspectionScedulesBindingSource
        Me.TblInspectionScedulesDataGridView.Location = New System.Drawing.Point(107, 242)
        Me.TblInspectionScedulesDataGridView.Name = "TblInspectionScedulesDataGridView"
        Me.TblInspectionScedulesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblInspectionScedulesDataGridView.TabIndex = 3
        '
        'inspSceduleID
        '
        Me.inspSceduleID.DataPropertyName = "inspSceduleID"
        Me.inspSceduleID.HeaderText = "inspSceduleID"
        Me.inspSceduleID.Name = "inspSceduleID"
        Me.inspSceduleID.ReadOnly = True
        '
        'inspSceduleYear
        '
        Me.inspSceduleYear.DataPropertyName = "inspSceduleYear"
        Me.inspSceduleYear.HeaderText = "inspSceduleYear"
        Me.inspSceduleYear.Name = "inspSceduleYear"
        '
        'inspInspections
        '
        Me.inspInspections.HeaderText = "inspInspections"
        Me.inspInspections.Image = Global.diadrasisProjects.My.Resources.Resources.search
        Me.inspInspections.Name = "inspInspections"
        '
        'inspSceduleReport
        '
        Me.inspSceduleReport.HeaderText = "inspSceduleReport"
        Me.inspSceduleReport.Image = Global.diadrasisProjects.My.Resources.Resources.reports
        Me.inspSceduleReport.Name = "inspSceduleReport"
        '
        'inspSceduleComments
        '
        Me.inspSceduleComments.DataPropertyName = "inspSceduleComments"
        Me.inspSceduleComments.HeaderText = "inspSceduleComments"
        Me.inspSceduleComments.Name = "inspSceduleComments"
        '
        'frmInspectionScedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.TblInspectionScedulesDataGridView)
        Me.Controls.Add(Me.TblInspectionScedulesBindingNavigator)
        Me.Name = "frmInspectionScedule"
        Me.Controls.SetChildIndex(Me.TblInspectionScedulesBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblInspectionScedulesDataGridView, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInspectionScedulesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInspectionScedulesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblInspectionScedulesBindingNavigator.ResumeLayout(False)
        Me.TblInspectionScedulesBindingNavigator.PerformLayout()
        CType(Me.TblInspectionScedulesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblInspectionScedulesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInspectionScedulesTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblInspectionScedulesTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblInspectionScedulesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblInspectionScedulesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblInspectionScedulesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspSceduleID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspSceduleYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inspInspections As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents inspSceduleReport As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents inspSceduleComments As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
