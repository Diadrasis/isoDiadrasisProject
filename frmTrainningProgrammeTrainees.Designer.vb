﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainningProgrammeTrainees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrainningProgrammeTrainees))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblTrainningTopicTraineesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTrainningTopicTraineesTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTrainningTopicTraineesTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblTrainningTopicTraineesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblTrainningTopicTraineesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblTrainningTopicTraineesDataGridView = New System.Windows.Forms.DataGridView
        Me.trainTopicTraineeID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trainTopicID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.traineeID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VwStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrainningTopicTraineesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTrainningTopicTraineesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTrainningTopicTraineesBindingNavigator.SuspendLayout()
        CType(Me.TblTrainningTopicTraineesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTrainningTopicTraineesBindingSource
        '
        Me.TblTrainningTopicTraineesBindingSource.DataMember = "tblTrainningTopicTrainees"
        Me.TblTrainningTopicTraineesBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblTrainningTopicTraineesTableAdapter
        '
        Me.TblTrainningTopicTraineesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblTrainningTopicTableAdapter = Nothing
        Me.TableAdapterManager.tblTrainningTopicTraineesTableAdapter = Me.TblTrainningTopicTraineesTableAdapter
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTrainningTopicTraineesBindingNavigator
        '
        Me.TblTrainningTopicTraineesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTrainningTopicTraineesBindingNavigator.BindingSource = Me.TblTrainningTopicTraineesBindingSource
        Me.TblTrainningTopicTraineesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTrainningTopicTraineesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTrainningTopicTraineesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTrainningTopicTraineesBindingNavigatorSaveItem})
        Me.TblTrainningTopicTraineesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTrainningTopicTraineesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTrainningTopicTraineesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTrainningTopicTraineesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTrainningTopicTraineesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTrainningTopicTraineesBindingNavigator.Name = "TblTrainningTopicTraineesBindingNavigator"
        Me.TblTrainningTopicTraineesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTrainningTopicTraineesBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblTrainningTopicTraineesBindingNavigator.TabIndex = 2
        Me.TblTrainningTopicTraineesBindingNavigator.Text = "BindingNavigator1"
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
        'TblTrainningTopicTraineesBindingNavigatorSaveItem
        '
        Me.TblTrainningTopicTraineesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTrainningTopicTraineesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTrainningTopicTraineesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTrainningTopicTraineesBindingNavigatorSaveItem.Name = "TblTrainningTopicTraineesBindingNavigatorSaveItem"
        Me.TblTrainningTopicTraineesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTrainningTopicTraineesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTrainningTopicTraineesDataGridView
        '
        Me.TblTrainningTopicTraineesDataGridView.AutoGenerateColumns = False
        Me.TblTrainningTopicTraineesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTrainningTopicTraineesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trainTopicTraineeID, Me.trainTopicID, Me.traineeID})
        Me.TblTrainningTopicTraineesDataGridView.DataSource = Me.TblTrainningTopicTraineesBindingSource
        Me.TblTrainningTopicTraineesDataGridView.Location = New System.Drawing.Point(49, 262)
        Me.TblTrainningTopicTraineesDataGridView.Name = "TblTrainningTopicTraineesDataGridView"
        Me.TblTrainningTopicTraineesDataGridView.Size = New System.Drawing.Size(382, 220)
        Me.TblTrainningTopicTraineesDataGridView.TabIndex = 3
        '
        'trainTopicTraineeID
        '
        Me.trainTopicTraineeID.DataPropertyName = "trainTopicTraineeID"
        Me.trainTopicTraineeID.HeaderText = "trainTopicTraineeID"
        Me.trainTopicTraineeID.Name = "trainTopicTraineeID"
        Me.trainTopicTraineeID.ReadOnly = True
        '
        'trainTopicID
        '
        Me.trainTopicID.DataPropertyName = "trainTopicID"
        Me.trainTopicID.HeaderText = "trainTopicID"
        Me.trainTopicID.Name = "trainTopicID"
        '
        'traineeID
        '
        Me.traineeID.DataPropertyName = "traineeID"
        Me.traineeID.DataSource = Me.VwStaffBindingSource
        Me.traineeID.DisplayMember = "staffFullname"
        Me.traineeID.HeaderText = "traineeID"
        Me.traineeID.Name = "traineeID"
        Me.traineeID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.traineeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.traineeID.ValueMember = "staffId"
        '
        'VwStaffBindingSource
        '
        Me.VwStaffBindingSource.DataMember = "vwStaff"
        Me.VwStaffBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VwStaffTableAdapter
        '
        Me.VwStaffTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'frmTrainningProgrammeTrainees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblTrainningTopicTraineesDataGridView)
        Me.Controls.Add(Me.TblTrainningTopicTraineesBindingNavigator)
        Me.Name = "frmTrainningProgrammeTrainees"
        Me.Controls.SetChildIndex(Me.TblTrainningTopicTraineesBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblTrainningTopicTraineesDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrainningTopicTraineesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTrainningTopicTraineesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTrainningTopicTraineesBindingNavigator.ResumeLayout(False)
        Me.TblTrainningTopicTraineesBindingNavigator.PerformLayout()
        CType(Me.TblTrainningTopicTraineesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblTrainningTopicTraineesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTrainningTopicTraineesTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblTrainningTopicTraineesTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTrainningTopicTraineesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblTrainningTopicTraineesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblTrainningTopicTraineesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VwStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vwStaffTableAdapter
    Friend WithEvents trainTopicTraineeID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trainTopicID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents traineeID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
