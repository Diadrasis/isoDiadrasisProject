<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevisionComiteeMeetings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRevisionComiteeMeetings))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblRevComitMeetingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRevComitMeetingsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblRevComitMeetingsTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblRevComitMeetingsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblRevComitMeetingsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblRevComitMeetingsDataGridView = New System.Windows.Forms.DataGridView
        Me.revComitMeetingID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.revComitMeetingDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.revComitMeetingNextDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.revComitMeetingComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.revComitMeetingTopics = New System.Windows.Forms.DataGridViewImageColumn
        Me.revComitMeetingRecommedations = New System.Windows.Forms.DataGridViewImageColumn
        Me.revComitMeetingReport = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRevComitMeetingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRevComitMeetingsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblRevComitMeetingsBindingNavigator.SuspendLayout()
        CType(Me.TblRevComitMeetingsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRevComitMeetingsBindingSource
        '
        Me.TblRevComitMeetingsBindingSource.DataMember = "tblRevComitMeetings"
        Me.TblRevComitMeetingsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblRevComitMeetingsTableAdapter
        '
        Me.TblRevComitMeetingsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
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
        Me.TableAdapterManager.tblRevComitMeetingsTableAdapter = Me.TblRevComitMeetingsTableAdapter
        Me.TableAdapterManager.tblRevComitMeetingTopicsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingTopicTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblRevComitMeetingsBindingNavigator
        '
        Me.TblRevComitMeetingsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblRevComitMeetingsBindingNavigator.BindingSource = Me.TblRevComitMeetingsBindingSource
        Me.TblRevComitMeetingsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblRevComitMeetingsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblRevComitMeetingsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblRevComitMeetingsBindingNavigatorSaveItem})
        Me.TblRevComitMeetingsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblRevComitMeetingsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblRevComitMeetingsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblRevComitMeetingsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblRevComitMeetingsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblRevComitMeetingsBindingNavigator.Name = "TblRevComitMeetingsBindingNavigator"
        Me.TblRevComitMeetingsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblRevComitMeetingsBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblRevComitMeetingsBindingNavigator.TabIndex = 2
        Me.TblRevComitMeetingsBindingNavigator.Text = "BindingNavigator1"
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
        'TblRevComitMeetingsBindingNavigatorSaveItem
        '
        Me.TblRevComitMeetingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblRevComitMeetingsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblRevComitMeetingsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblRevComitMeetingsBindingNavigatorSaveItem.Name = "TblRevComitMeetingsBindingNavigatorSaveItem"
        Me.TblRevComitMeetingsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblRevComitMeetingsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblRevComitMeetingsDataGridView
        '
        Me.TblRevComitMeetingsDataGridView.AutoGenerateColumns = False
        Me.TblRevComitMeetingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRevComitMeetingsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.revComitMeetingID, Me.revComitMeetingDate, Me.revComitMeetingNextDate, Me.revComitMeetingComments, Me.revComitMeetingTopics, Me.revComitMeetingRecommedations, Me.revComitMeetingReport})
        Me.TblRevComitMeetingsDataGridView.DataSource = Me.TblRevComitMeetingsBindingSource
        Me.TblRevComitMeetingsDataGridView.Location = New System.Drawing.Point(101, 246)
        Me.TblRevComitMeetingsDataGridView.Name = "TblRevComitMeetingsDataGridView"
        Me.TblRevComitMeetingsDataGridView.Size = New System.Drawing.Size(573, 220)
        Me.TblRevComitMeetingsDataGridView.TabIndex = 3
        '
        'revComitMeetingID
        '
        Me.revComitMeetingID.DataPropertyName = "revComitMeetingID"
        Me.revComitMeetingID.HeaderText = "revComitMeetingID"
        Me.revComitMeetingID.Name = "revComitMeetingID"
        Me.revComitMeetingID.ReadOnly = True
        '
        'revComitMeetingDate
        '
        Me.revComitMeetingDate.DataPropertyName = "revComitMeetingDate"
        Me.revComitMeetingDate.HeaderText = "revComitMeetingDate"
        Me.revComitMeetingDate.Name = "revComitMeetingDate"
        '
        'revComitMeetingNextDate
        '
        Me.revComitMeetingNextDate.DataPropertyName = "revComitMeetingNextDate"
        Me.revComitMeetingNextDate.HeaderText = "revComitMeetingNextDate"
        Me.revComitMeetingNextDate.Name = "revComitMeetingNextDate"
        '
        'revComitMeetingComments
        '
        Me.revComitMeetingComments.DataPropertyName = "revComitMeetingComments"
        Me.revComitMeetingComments.HeaderText = "revComitMeetingComments"
        Me.revComitMeetingComments.Name = "revComitMeetingComments"
        '
        'revComitMeetingTopics
        '
        Me.revComitMeetingTopics.HeaderText = "revComitMeetingTopics"
        Me.revComitMeetingTopics.Image = Global.diadrasisProjects.My.Resources.Resources.book
        Me.revComitMeetingTopics.Name = "revComitMeetingTopics"
        Me.revComitMeetingTopics.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.revComitMeetingTopics.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'revComitMeetingRecommedations
        '
        Me.revComitMeetingRecommedations.HeaderText = "revComitMeetingRecommedations"
        Me.revComitMeetingRecommedations.Image = Global.diadrasisProjects.My.Resources.Resources.comment
        Me.revComitMeetingRecommedations.Name = "revComitMeetingRecommedations"
        Me.revComitMeetingRecommedations.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.revComitMeetingRecommedations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'revComitMeetingReport
        '
        Me.revComitMeetingReport.HeaderText = "revComitMeetingReport"
        Me.revComitMeetingReport.Image = Global.diadrasisProjects.My.Resources.Resources.reports
        Me.revComitMeetingReport.Name = "revComitMeetingReport"
        '
        'frmRevisionComiteeMeetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.TblRevComitMeetingsDataGridView)
        Me.Controls.Add(Me.TblRevComitMeetingsBindingNavigator)
        Me.Name = "frmRevisionComiteeMeetings"
        Me.Controls.SetChildIndex(Me.TblRevComitMeetingsBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblRevComitMeetingsDataGridView, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRevComitMeetingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRevComitMeetingsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblRevComitMeetingsBindingNavigator.ResumeLayout(False)
        Me.TblRevComitMeetingsBindingNavigator.PerformLayout()
        CType(Me.TblRevComitMeetingsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblRevComitMeetingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRevComitMeetingsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblRevComitMeetingsTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblRevComitMeetingsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblRevComitMeetingsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblRevComitMeetingsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents revComitMeetingTopic As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents revComitMeetingID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents revComitMeetingDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents revComitMeetingNextDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents revComitMeetingComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents revComitMeetingTopics As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents revComitMeetingRecommedations As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents revComitMeetingReport As System.Windows.Forms.DataGridViewImageColumn

End Class
