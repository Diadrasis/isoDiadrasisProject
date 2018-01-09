<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSatisfactionSurveys
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerSatisfactionSurveys))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblQACustomerSatisfactionSurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblQACustomerSatisfactionSurveysTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQACustomerSatisfactionSurveysTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblQACustomerSatisfactionSurveysBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQACustomerSatisfactionSurveysDataGridView = New System.Windows.Forms.DataGridView
        Me.cusSatisfSurvID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.customerID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cusSatisfSurvDateFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cusSatisfSurvDateTo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.custSatisfDetails = New System.Windows.Forms.DataGridViewImageColumn
        Me.cusSatisfSurvComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQACustomerSatisfactionSurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQACustomerSatisfactionSurveysBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.SuspendLayout()
        CType(Me.TblQACustomerSatisfactionSurveysDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblQACustomerSatisfactionSurveysBindingSource
        '
        Me.TblQACustomerSatisfactionSurveysBindingSource.DataMember = "tblQACustomerSatisfactionSurveys"
        Me.TblQACustomerSatisfactionSurveysBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblQACustomerSatisfactionSurveysTableAdapter
        '
        Me.TblQACustomerSatisfactionSurveysTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveyDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQACustomerSatisfactionSurveysTableAdapter = Me.TblQACustomerSatisfactionSurveysTableAdapter
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
        'TblQACustomerSatisfactionSurveysBindingNavigator
        '
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.BindingSource = Me.TblQACustomerSatisfactionSurveysBindingSource
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem})
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.Name = "TblQACustomerSatisfactionSurveysBindingNavigator"
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.TabIndex = 2
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.Text = "BindingNavigator1"
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
        'TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem
        '
        Me.TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem.Name = "TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem"
        Me.TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQACustomerSatisfactionSurveysDataGridView
        '
        Me.TblQACustomerSatisfactionSurveysDataGridView.AutoGenerateColumns = False
        Me.TblQACustomerSatisfactionSurveysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQACustomerSatisfactionSurveysDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cusSatisfSurvID, Me.customerID, Me.cusSatisfSurvDateFrom, Me.cusSatisfSurvDateTo, Me.custSatisfDetails, Me.cusSatisfSurvComments})
        Me.TblQACustomerSatisfactionSurveysDataGridView.DataSource = Me.TblQACustomerSatisfactionSurveysBindingSource
        Me.TblQACustomerSatisfactionSurveysDataGridView.Location = New System.Drawing.Point(105, 223)
        Me.TblQACustomerSatisfactionSurveysDataGridView.Name = "TblQACustomerSatisfactionSurveysDataGridView"
        Me.TblQACustomerSatisfactionSurveysDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblQACustomerSatisfactionSurveysDataGridView.TabIndex = 3
        '
        'cusSatisfSurvID
        '
        Me.cusSatisfSurvID.DataPropertyName = "cusSatisfSurvID"
        Me.cusSatisfSurvID.HeaderText = "cusSatisfSurvID"
        Me.cusSatisfSurvID.Name = "cusSatisfSurvID"
        Me.cusSatisfSurvID.ReadOnly = True
        '
        'customerID
        '
        Me.customerID.DataPropertyName = "customerID"
        Me.customerID.HeaderText = "customerID"
        Me.customerID.Name = "customerID"
        '
        'cusSatisfSurvDateFrom
        '
        Me.cusSatisfSurvDateFrom.DataPropertyName = "cusSatisfSurvDateFrom"
        Me.cusSatisfSurvDateFrom.HeaderText = "cusSatisfSurvDateFrom"
        Me.cusSatisfSurvDateFrom.Name = "cusSatisfSurvDateFrom"
        '
        'cusSatisfSurvDateTo
        '
        Me.cusSatisfSurvDateTo.DataPropertyName = "cusSatisfSurvDateTo"
        Me.cusSatisfSurvDateTo.HeaderText = "cusSatisfSurvDateTo"
        Me.cusSatisfSurvDateTo.Name = "cusSatisfSurvDateTo"
        '
        'custSatisfDetails
        '
        Me.custSatisfDetails.HeaderText = "custSatisfDetails"
        Me.custSatisfDetails.Image = Global.diadrasisProjects.My.Resources.Resources.search
        Me.custSatisfDetails.Name = "custSatisfDetails"
        Me.custSatisfDetails.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.custSatisfDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cusSatisfSurvComments
        '
        Me.cusSatisfSurvComments.DataPropertyName = "cusSatisfSurvComments"
        Me.cusSatisfSurvComments.HeaderText = "cusSatisfSurvComments"
        Me.cusSatisfSurvComments.Name = "cusSatisfSurvComments"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'frmCustomerSatisfactionSurveys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblQACustomerSatisfactionSurveysDataGridView)
        Me.Controls.Add(Me.TblQACustomerSatisfactionSurveysBindingNavigator)
        Me.Name = "frmCustomerSatisfactionSurveys"
        Me.Controls.SetChildIndex(Me.TblQACustomerSatisfactionSurveysBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQACustomerSatisfactionSurveysDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQACustomerSatisfactionSurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQACustomerSatisfactionSurveysBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.ResumeLayout(False)
        Me.TblQACustomerSatisfactionSurveysBindingNavigator.PerformLayout()
        CType(Me.TblQACustomerSatisfactionSurveysDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblQACustomerSatisfactionSurveysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQACustomerSatisfactionSurveysTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQACustomerSatisfactionSurveysTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQACustomerSatisfactionSurveysBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQACustomerSatisfactionSurveysDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custSatisfDetails As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cusSatisfSurvID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cusSatisfSurvDateFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cusSatisfSurvDateTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cusSatisfSurvComments As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
