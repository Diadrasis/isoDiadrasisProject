<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet()
        Me.TblSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSupplierTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblSupplierTableAdapter()
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager()
        Me.TblSupplierBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.TblSupplierBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblSupplierDataGridView = New System.Windows.Forms.DataGridView()
        Me.VwSupplierTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwSupplierEvalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwSupplierTypeTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwSupplierTypeTableAdapter()
        Me.VwSupplierEvalTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwSupplierEvalTableAdapter()
        Me.supplierId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierServices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierDateApproval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierEvaluations = New System.Windows.Forms.DataGridViewImageColumn()
        Me.supplierAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierTelephone1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierTelephone2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierAFM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierDOY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierTypeId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.supplierEvalId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.supplierComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierZIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierDistrict = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSupplierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSupplierBindingNavigator.SuspendLayout()
        CType(Me.TblSupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSupplierEvalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSupplierBindingSource
        '
        Me.TblSupplierBindingSource.DataMember = "tblSupplier"
        Me.TblSupplierBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblSupplierTableAdapter
        '
        Me.TblSupplierTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblSupplierTableAdapter = Me.TblSupplierTableAdapter
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskReasonsTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningEmployeesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningProgrammesTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSupplierBindingNavigator
        '
        Me.TblSupplierBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblSupplierBindingNavigator.BindingSource = Me.TblSupplierBindingSource
        Me.TblSupplierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSupplierBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblSupplierBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblSupplierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblSupplierBindingNavigatorSaveItem})
        Me.TblSupplierBindingNavigator.Location = New System.Drawing.Point(457, 221)
        Me.TblSupplierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSupplierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSupplierBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSupplierBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSupplierBindingNavigator.Name = "TblSupplierBindingNavigator"
        Me.TblSupplierBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSupplierBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.TblSupplierBindingNavigator.TabIndex = 2
        Me.TblSupplierBindingNavigator.Text = "BindingNavigator1"
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
        'TblSupplierBindingNavigatorSaveItem
        '
        Me.TblSupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblSupplierBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblSupplierBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblSupplierBindingNavigatorSaveItem.Name = "TblSupplierBindingNavigatorSaveItem"
        Me.TblSupplierBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblSupplierBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblSupplierDataGridView
        '
        Me.TblSupplierDataGridView.AutoGenerateColumns = False
        Me.TblSupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblSupplierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supplierId, Me.supplierName, Me.supplierSurname, Me.supplierCompany, Me.supplierServices, Me.supplierDateApproval, Me.supplierEvaluations, Me.supplierAddress, Me.supplierTelephone1, Me.supplierTelephone2, Me.supplierAFM, Me.supplierDOY, Me.supplierTypeId, Me.supplierEvalId, Me.supplierComments, Me.supplierCity, Me.supplierZIP, Me.supplierDistrict})
        Me.TblSupplierDataGridView.DataSource = Me.TblSupplierBindingSource
        Me.TblSupplierDataGridView.Location = New System.Drawing.Point(379, 295)
        Me.TblSupplierDataGridView.Name = "TblSupplierDataGridView"
        Me.TblSupplierDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblSupplierDataGridView.TabIndex = 3
        '
        'VwSupplierTypeBindingSource
        '
        Me.VwSupplierTypeBindingSource.DataMember = "vwSupplierType"
        Me.VwSupplierTypeBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VwSupplierEvalBindingSource
        '
        Me.VwSupplierEvalBindingSource.DataMember = "vwSupplierEval"
        Me.VwSupplierEvalBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VwSupplierTypeTableAdapter
        '
        Me.VwSupplierTypeTableAdapter.ClearBeforeFill = True
        '
        'VwSupplierEvalTableAdapter
        '
        Me.VwSupplierEvalTableAdapter.ClearBeforeFill = True
        '
        'supplierId
        '
        Me.supplierId.DataPropertyName = "supplierId"
        Me.supplierId.HeaderText = "supplierId"
        Me.supplierId.Name = "supplierId"
        Me.supplierId.ReadOnly = True
        '
        'supplierName
        '
        Me.supplierName.DataPropertyName = "supplierName"
        Me.supplierName.HeaderText = "supplierName"
        Me.supplierName.Name = "supplierName"
        '
        'supplierSurname
        '
        Me.supplierSurname.DataPropertyName = "supplierSurname"
        Me.supplierSurname.HeaderText = "supplierSurname"
        Me.supplierSurname.Name = "supplierSurname"
        '
        'supplierCompany
        '
        Me.supplierCompany.DataPropertyName = "supplierCompany"
        Me.supplierCompany.HeaderText = "supplierCompany"
        Me.supplierCompany.Name = "supplierCompany"
        '
        'supplierServices
        '
        Me.supplierServices.DataPropertyName = "supplierServices"
        Me.supplierServices.HeaderText = "supplierServices"
        Me.supplierServices.Name = "supplierServices"
        '
        'supplierDateApproval
        '
        Me.supplierDateApproval.DataPropertyName = "supplierDateApproval"
        Me.supplierDateApproval.HeaderText = "supplierDateApproval"
        Me.supplierDateApproval.Name = "supplierDateApproval"
        '
        'supplierEvaluations
        '
        Me.supplierEvaluations.HeaderText = "supplierEvaluations"
        Me.supplierEvaluations.Image = Global.diadrasisProjects.My.Resources.Resources.evaluation
        Me.supplierEvaluations.Name = "supplierEvaluations"
        '
        'supplierAddress
        '
        Me.supplierAddress.DataPropertyName = "supplierAddress"
        Me.supplierAddress.HeaderText = "supplierAddress"
        Me.supplierAddress.Name = "supplierAddress"
        '
        'supplierTelephone1
        '
        Me.supplierTelephone1.DataPropertyName = "supplierTelephone1"
        Me.supplierTelephone1.HeaderText = "supplierTelephone1"
        Me.supplierTelephone1.Name = "supplierTelephone1"
        '
        'supplierTelephone2
        '
        Me.supplierTelephone2.DataPropertyName = "supplierTelephone2"
        Me.supplierTelephone2.HeaderText = "supplierTelephone2"
        Me.supplierTelephone2.Name = "supplierTelephone2"
        '
        'supplierAFM
        '
        Me.supplierAFM.DataPropertyName = "supplierAFM"
        Me.supplierAFM.HeaderText = "supplierAFM"
        Me.supplierAFM.Name = "supplierAFM"
        '
        'supplierDOY
        '
        Me.supplierDOY.DataPropertyName = "supplierDOY"
        Me.supplierDOY.HeaderText = "supplierDOY"
        Me.supplierDOY.Name = "supplierDOY"
        '
        'supplierTypeId
        '
        Me.supplierTypeId.DataPropertyName = "supplierTypeId"
        Me.supplierTypeId.DataSource = Me.VwSupplierTypeBindingSource
        Me.supplierTypeId.DisplayMember = "supplierTypeName"
        Me.supplierTypeId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.supplierTypeId.HeaderText = "supplierTypeId"
        Me.supplierTypeId.Name = "supplierTypeId"
        Me.supplierTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supplierTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.supplierTypeId.ValueMember = "supplierTypeId"
        '
        'supplierEvalId
        '
        Me.supplierEvalId.DataPropertyName = "supplierEvalId"
        Me.supplierEvalId.DataSource = Me.VwSupplierEvalBindingSource
        Me.supplierEvalId.DisplayMember = "supplierEvalName"
        Me.supplierEvalId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.supplierEvalId.HeaderText = "supplierEvalId"
        Me.supplierEvalId.Name = "supplierEvalId"
        Me.supplierEvalId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supplierEvalId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.supplierEvalId.ValueMember = "supplierEvalId"
        '
        'supplierComments
        '
        Me.supplierComments.DataPropertyName = "supplierComments"
        Me.supplierComments.HeaderText = "supplierComments"
        Me.supplierComments.Name = "supplierComments"
        '
        'supplierCity
        '
        Me.supplierCity.DataPropertyName = "supplierCity"
        Me.supplierCity.HeaderText = "supplierCity"
        Me.supplierCity.Name = "supplierCity"
        '
        'supplierZIP
        '
        Me.supplierZIP.DataPropertyName = "supplierZIP"
        Me.supplierZIP.HeaderText = "supplierZIP"
        Me.supplierZIP.Name = "supplierZIP"
        '
        'supplierDistrict
        '
        Me.supplierDistrict.DataPropertyName = "supplierDistrict"
        Me.supplierDistrict.HeaderText = "supplierDistrict"
        Me.supplierDistrict.Name = "supplierDistrict"
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.TblSupplierDataGridView)
        Me.Controls.Add(Me.TblSupplierBindingNavigator)
        Me.Name = "frmSupplier"
        Me.Controls.SetChildIndex(Me.TblSupplierBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblSupplierDataGridView, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSupplierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSupplierBindingNavigator.ResumeLayout(False)
        Me.TblSupplierBindingNavigator.PerformLayout()
        CType(Me.TblSupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSupplierEvalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSupplierTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblSupplierTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSupplierBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblSupplierBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblSupplierDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwSupplierTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSupplierTypeTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwSupplierTypeTableAdapter
    Friend WithEvents VwSupplierEvalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwSupplierEvalTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwSupplierEvalTableAdapter
    Friend WithEvents supplierId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierSurname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierCompany As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierServices As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierDateApproval As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierEvaluations As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents supplierAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierTelephone1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierTelephone2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierAFM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierDOY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierTypeId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents supplierEvalId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents supplierComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierZIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplierDistrict As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
