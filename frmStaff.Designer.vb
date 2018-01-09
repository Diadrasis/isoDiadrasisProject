<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.TblStaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TblStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TblStaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblStaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TblStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblStaffTableAdapter()
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager()
        Me.staffId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffSurname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffBirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffBirthPlace = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffFathername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffMotherName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffWorkingFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empResume = New System.Windows.Forms.DataGridViewImageColumn()
        Me.empEvaluations = New System.Windows.Forms.DataGridViewImageColumn()
        Me.empTrainning = New System.Windows.Forms.DataGridViewImageColumn()
        Me.education = New System.Windows.Forms.DataGridViewImageColumn()
        Me.staffAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffADT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffAFM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffDOY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffAMKA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffFax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffBankAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffTK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffExperience = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffKnowledge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffSpecialAbilities = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffLectures = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.staffMilitary = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.staffComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TblStaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblStaffBindingNavigator.SuspendLayout()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblStaffBindingNavigator
        '
        Me.TblStaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblStaffBindingNavigator.BindingSource = Me.TblStaffBindingSource
        Me.TblStaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblStaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblStaffBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblStaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblStaffBindingNavigatorSaveItem})
        Me.TblStaffBindingNavigator.Location = New System.Drawing.Point(40, 222)
        Me.TblStaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblStaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblStaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblStaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblStaffBindingNavigator.Name = "TblStaffBindingNavigator"
        Me.TblStaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblStaffBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.TblStaffBindingNavigator.TabIndex = 2
        Me.TblStaffBindingNavigator.Text = "BindingNavigator1"
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
        'TblStaffBindingSource
        '
        Me.TblStaffBindingSource.DataMember = "tblStaff"
        Me.TblStaffBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
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
        'TblStaffBindingNavigatorSaveItem
        '
        Me.TblStaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblStaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblStaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblStaffBindingNavigatorSaveItem.Name = "TblStaffBindingNavigatorSaveItem"
        Me.TblStaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblStaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblStaffDataGridView
        '
        Me.TblStaffDataGridView.AutoGenerateColumns = False
        Me.TblStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblStaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.staffId, Me.staffSurname, Me.staffName, Me.staffBirthDate, Me.staffBirthPlace, Me.staffFathername, Me.staffMotherName, Me.staffWorkingFrom, Me.empResume, Me.empEvaluations, Me.empTrainning, Me.education, Me.staffAMA, Me.staffADT, Me.staffAFM, Me.staffDOY, Me.staffAMKA, Me.staffTelephone, Me.staffFax, Me.staffBankAccount, Me.staffMail, Me.staffAddress, Me.staffTK, Me.staffCity, Me.staffExperience, Me.staffKnowledge, Me.staffSpecialAbilities, Me.staffLectures, Me.staffMilitary, Me.staffComments})
        Me.TblStaffDataGridView.DataSource = Me.TblStaffBindingSource
        Me.TblStaffDataGridView.Location = New System.Drawing.Point(40, 284)
        Me.TblStaffDataGridView.Name = "TblStaffDataGridView"
        Me.TblStaffDataGridView.Size = New System.Drawing.Size(910, 290)
        Me.TblStaffDataGridView.TabIndex = 3
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(989, 129)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 5
        '
        'TblStaffTableAdapter
        '
        Me.TblStaffTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblStaffTableAdapter = Me.TblStaffTableAdapter
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
        'staffId
        '
        Me.staffId.DataPropertyName = "staffId"
        Me.staffId.HeaderText = "staffId"
        Me.staffId.Name = "staffId"
        Me.staffId.ReadOnly = True
        '
        'staffSurname
        '
        Me.staffSurname.DataPropertyName = "staffSurname"
        Me.staffSurname.HeaderText = "staffSurname"
        Me.staffSurname.Name = "staffSurname"
        '
        'staffName
        '
        Me.staffName.DataPropertyName = "staffName"
        Me.staffName.HeaderText = "staffName"
        Me.staffName.Name = "staffName"
        '
        'staffBirthDate
        '
        Me.staffBirthDate.DataPropertyName = "staffBirthDate"
        Me.staffBirthDate.HeaderText = "staffBirthDate"
        Me.staffBirthDate.Name = "staffBirthDate"
        '
        'staffBirthPlace
        '
        Me.staffBirthPlace.DataPropertyName = "staffBirthPlace"
        Me.staffBirthPlace.HeaderText = "staffBirthPlace"
        Me.staffBirthPlace.Name = "staffBirthPlace"
        '
        'staffFathername
        '
        Me.staffFathername.DataPropertyName = "staffFathername"
        Me.staffFathername.HeaderText = "staffFathername"
        Me.staffFathername.Name = "staffFathername"
        '
        'staffMotherName
        '
        Me.staffMotherName.DataPropertyName = "staffMotherName"
        Me.staffMotherName.HeaderText = "staffMotherName"
        Me.staffMotherName.Name = "staffMotherName"
        '
        'staffWorkingFrom
        '
        Me.staffWorkingFrom.DataPropertyName = "staffWorkingFrom"
        Me.staffWorkingFrom.HeaderText = "staffWorkingFrom"
        Me.staffWorkingFrom.Name = "staffWorkingFrom"
        '
        'empResume
        '
        Me.empResume.HeaderText = "empResume"
        Me.empResume.Image = Global.diadrasisProjects.My.Resources.Resources.comment
        Me.empResume.Name = "empResume"
        '
        'empEvaluations
        '
        Me.empEvaluations.HeaderText = "empEvaluations"
        Me.empEvaluations.Image = Global.diadrasisProjects.My.Resources.Resources.evaluation
        Me.empEvaluations.Name = "empEvaluations"
        '
        'empTrainning
        '
        Me.empTrainning.HeaderText = "empTrainning"
        Me.empTrainning.Image = Global.diadrasisProjects.My.Resources.Resources.book
        Me.empTrainning.Name = "empTrainning"
        '
        'education
        '
        Me.education.HeaderText = "education"
        Me.education.Image = Global.diadrasisProjects.My.Resources.Resources.education
        Me.education.Name = "education"
        '
        'staffAMA
        '
        Me.staffAMA.DataPropertyName = "staffAMA"
        Me.staffAMA.HeaderText = "staffAMA"
        Me.staffAMA.Name = "staffAMA"
        '
        'staffADT
        '
        Me.staffADT.DataPropertyName = "staffADT"
        Me.staffADT.HeaderText = "staffADT"
        Me.staffADT.Name = "staffADT"
        '
        'staffAFM
        '
        Me.staffAFM.DataPropertyName = "staffAFM"
        Me.staffAFM.HeaderText = "staffAFM"
        Me.staffAFM.Name = "staffAFM"
        '
        'staffDOY
        '
        Me.staffDOY.DataPropertyName = "staffDOY"
        Me.staffDOY.HeaderText = "staffDOY"
        Me.staffDOY.Name = "staffDOY"
        '
        'staffAMKA
        '
        Me.staffAMKA.DataPropertyName = "staffAMKA"
        Me.staffAMKA.HeaderText = "staffAMKA"
        Me.staffAMKA.Name = "staffAMKA"
        '
        'staffTelephone
        '
        Me.staffTelephone.DataPropertyName = "staffTelephone"
        Me.staffTelephone.HeaderText = "staffTelephone"
        Me.staffTelephone.Name = "staffTelephone"
        '
        'staffFax
        '
        Me.staffFax.DataPropertyName = "staffFax"
        Me.staffFax.HeaderText = "staffFax"
        Me.staffFax.Name = "staffFax"
        '
        'staffBankAccount
        '
        Me.staffBankAccount.DataPropertyName = "staffBankAccount"
        Me.staffBankAccount.HeaderText = "staffBankAccount"
        Me.staffBankAccount.Name = "staffBankAccount"
        '
        'staffMail
        '
        Me.staffMail.DataPropertyName = "staffMail"
        Me.staffMail.HeaderText = "staffMail"
        Me.staffMail.Name = "staffMail"
        '
        'staffAddress
        '
        Me.staffAddress.DataPropertyName = "staffAddress"
        Me.staffAddress.HeaderText = "staffAddress"
        Me.staffAddress.Name = "staffAddress"
        '
        'staffTK
        '
        Me.staffTK.DataPropertyName = "staffTK"
        Me.staffTK.HeaderText = "staffTK"
        Me.staffTK.Name = "staffTK"
        '
        'staffCity
        '
        Me.staffCity.DataPropertyName = "staffCity"
        Me.staffCity.HeaderText = "staffCity"
        Me.staffCity.Name = "staffCity"
        '
        'staffExperience
        '
        Me.staffExperience.DataPropertyName = "staffExperience"
        Me.staffExperience.HeaderText = "staffExperience"
        Me.staffExperience.Name = "staffExperience"
        '
        'staffKnowledge
        '
        Me.staffKnowledge.DataPropertyName = "staffKnowledge"
        Me.staffKnowledge.HeaderText = "staffKnowledge"
        Me.staffKnowledge.Name = "staffKnowledge"
        '
        'staffSpecialAbilities
        '
        Me.staffSpecialAbilities.DataPropertyName = "staffSpecialAbilities"
        Me.staffSpecialAbilities.HeaderText = "staffSpecialAbilities"
        Me.staffSpecialAbilities.Name = "staffSpecialAbilities"
        '
        'staffLectures
        '
        Me.staffLectures.DataPropertyName = "staffLectures"
        Me.staffLectures.HeaderText = "staffLectures"
        Me.staffLectures.Name = "staffLectures"
        '
        'staffMilitary
        '
        Me.staffMilitary.DataPropertyName = "staffMilitary"
        Me.staffMilitary.HeaderText = "staffMilitary"
        Me.staffMilitary.Name = "staffMilitary"
        '
        'staffComments
        '
        Me.staffComments.DataPropertyName = "staffComments"
        Me.staffComments.HeaderText = "staffComments"
        Me.staffComments.Name = "staffComments"
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.TblStaffDataGridView)
        Me.Controls.Add(Me.TblStaffBindingNavigator)
        Me.Name = "frmStaff"
        Me.Controls.SetChildIndex(Me.TblStaffBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblStaffDataGridView, 0)
        Me.Controls.SetChildIndex(Me.MonthCalendar1, 0)
        CType(Me.TblStaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblStaffBindingNavigator.ResumeLayout(False)
        Me.TblStaffBindingNavigator.PerformLayout()
        CType(Me.TblStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblStaffTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblStaffBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblStaffBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblStaffDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents staffId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffSurname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffBirthDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffBirthPlace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffFathername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffMotherName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffWorkingFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empResume As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents empEvaluations As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents empTrainning As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents education As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents staffAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffADT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffAFM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffDOY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffAMKA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffTelephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffFax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffBankAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffTK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffExperience As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffKnowledge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffSpecialAbilities As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffLectures As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffMilitary As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents staffComments As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
