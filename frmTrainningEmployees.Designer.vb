<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainningEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrainningEmployees))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblTrainningEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTrainningEmployeesTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTrainningEmployeesTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblTrainningEmployeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblTrainningEmployeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblTrainningEmployeesDataGridView = New System.Windows.Forms.DataGridView
        Me.trainEmpID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.employeeID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainEmpTopic = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainEmpDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainEmpDuration = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainEmpComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrainningEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrainningEmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTrainningEmployeesBindingNavigator.SuspendLayout()
        CType(Me.TblTrainningEmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTrainningEmployeesBindingSource
        '
        Me.TblTrainningEmployeesBindingSource.DataMember = "tblTrainningEmployees"
        Me.TblTrainningEmployeesBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblTrainningEmployeesTableAdapter
        '
        Me.TblTrainningEmployeesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblTrainningEmployeesTableAdapter = Me.TblTrainningEmployeesTableAdapter
        Me.TableAdapterManager.tblTrainningProgrammesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTrainningEmployeesBindingNavigator
        '
        Me.TblTrainningEmployeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTrainningEmployeesBindingNavigator.BindingSource = Me.TblTrainningEmployeesBindingSource
        Me.TblTrainningEmployeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTrainningEmployeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTrainningEmployeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTrainningEmployeesBindingNavigatorSaveItem})
        Me.TblTrainningEmployeesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTrainningEmployeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTrainningEmployeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTrainningEmployeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTrainningEmployeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTrainningEmployeesBindingNavigator.Name = "TblTrainningEmployeesBindingNavigator"
        Me.TblTrainningEmployeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTrainningEmployeesBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblTrainningEmployeesBindingNavigator.TabIndex = 2
        Me.TblTrainningEmployeesBindingNavigator.Text = "BindingNavigator1"
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
        'TblTrainningEmployeesBindingNavigatorSaveItem
        '
        Me.TblTrainningEmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTrainningEmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTrainningEmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTrainningEmployeesBindingNavigatorSaveItem.Name = "TblTrainningEmployeesBindingNavigatorSaveItem"
        Me.TblTrainningEmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTrainningEmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTrainningEmployeesDataGridView
        '
        Me.TblTrainningEmployeesDataGridView.AutoGenerateColumns = False
        Me.TblTrainningEmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTrainningEmployeesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trainEmpID, Me.employeeID, Me.trainEmpTopic, Me.trainEmpDate, Me.trainEmpDuration, Me.trainEmpComments})
        Me.TblTrainningEmployeesDataGridView.DataSource = Me.TblTrainningEmployeesBindingSource
        Me.TblTrainningEmployeesDataGridView.Location = New System.Drawing.Point(59, 182)
        Me.TblTrainningEmployeesDataGridView.Name = "TblTrainningEmployeesDataGridView"
        Me.TblTrainningEmployeesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblTrainningEmployeesDataGridView.TabIndex = 3
        '
        'trainEmpID
        '
        Me.trainEmpID.DataPropertyName = "trainEmpID"
        Me.trainEmpID.HeaderText = "trainEmpID"
        Me.trainEmpID.Name = "trainEmpID"
        Me.trainEmpID.ReadOnly = True
        '
        'employeeID
        '
        Me.employeeID.DataPropertyName = "employeeID"
        Me.employeeID.HeaderText = "employeeID"
        Me.employeeID.Name = "employeeID"
        '
        'trainEmpTopic
        '
        Me.trainEmpTopic.DataPropertyName = "trainEmpTopic"
        Me.trainEmpTopic.HeaderText = "trainEmpTopic"
        Me.trainEmpTopic.Name = "trainEmpTopic"
        '
        'trainEmpDate
        '
        Me.trainEmpDate.DataPropertyName = "trainEmpDate"
        Me.trainEmpDate.HeaderText = "trainEmpDate"
        Me.trainEmpDate.Name = "trainEmpDate"
        '
        'trainEmpDuration
        '
        Me.trainEmpDuration.DataPropertyName = "trainEmpDuration"
        Me.trainEmpDuration.HeaderText = "trainEmpDuration"
        Me.trainEmpDuration.Name = "trainEmpDuration"
        '
        'trainEmpComments
        '
        Me.trainEmpComments.DataPropertyName = "trainEmpComments"
        Me.trainEmpComments.HeaderText = "trainEmpComments"
        Me.trainEmpComments.Name = "trainEmpComments"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Image = Global.diadrasisProjects.My.Resources.Resources.reports
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(472, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTrainningEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblTrainningEmployeesDataGridView)
        Me.Controls.Add(Me.TblTrainningEmployeesBindingNavigator)
        Me.Name = "frmTrainningEmployees"
        Me.Controls.SetChildIndex(Me.TblTrainningEmployeesBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblTrainningEmployeesDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrainningEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrainningEmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTrainningEmployeesBindingNavigator.ResumeLayout(False)
        Me.TblTrainningEmployeesBindingNavigator.PerformLayout()
        CType(Me.TblTrainningEmployeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblTrainningEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTrainningEmployeesTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTrainningEmployeesTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTrainningEmployeesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblTrainningEmployeesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblTrainningEmployeesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainEmpID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employeeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainEmpTopic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainEmpDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainEmpDuration As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainEmpComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
