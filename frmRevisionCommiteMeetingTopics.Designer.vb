<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRevisionCommiteMeetingTopics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRevisionCommiteMeetingTopics))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblRevComitMeetingTopicsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRevComitMeetingTopicsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblRevComitMeetingTopicsTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblRevComitMeetingTopicsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblRevComitMeetingTopicsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblRevComitMeetingTopicsDataGridView = New System.Windows.Forms.DataGridView
        Me.VcRevComittMeetingTopicTypeIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VcRevComittMeetingTopicTypeIDTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcRevComittMeetingTopicTypeIDTableAdapter
        Me.revComitMeetingTopicID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.revComitMeetingID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.revComitMeetingTopicTypeID = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.revComitMeetingTopicComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRevComitMeetingTopicsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRevComitMeetingTopicsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblRevComitMeetingTopicsBindingNavigator.SuspendLayout()
        CType(Me.TblRevComitMeetingTopicsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcRevComittMeetingTopicTypeIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRevComitMeetingTopicsBindingSource
        '
        Me.TblRevComitMeetingTopicsBindingSource.DataMember = "tblRevComitMeetingTopics"
        Me.TblRevComitMeetingTopicsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblRevComitMeetingTopicsTableAdapter
        '
        Me.TblRevComitMeetingTopicsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblRevComitMeetingsTableAdapter = Nothing
        Me.TableAdapterManager.tblRevComitMeetingTopicsTableAdapter = Me.TblRevComitMeetingTopicsTableAdapter
        Me.TableAdapterManager.tblRevComitMeetingTopicTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblRevComitMeetingTopicsBindingNavigator
        '
        Me.TblRevComitMeetingTopicsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblRevComitMeetingTopicsBindingNavigator.BindingSource = Me.TblRevComitMeetingTopicsBindingSource
        Me.TblRevComitMeetingTopicsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblRevComitMeetingTopicsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblRevComitMeetingTopicsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblRevComitMeetingTopicsBindingNavigatorSaveItem})
        Me.TblRevComitMeetingTopicsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblRevComitMeetingTopicsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblRevComitMeetingTopicsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblRevComitMeetingTopicsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblRevComitMeetingTopicsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblRevComitMeetingTopicsBindingNavigator.Name = "TblRevComitMeetingTopicsBindingNavigator"
        Me.TblRevComitMeetingTopicsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblRevComitMeetingTopicsBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblRevComitMeetingTopicsBindingNavigator.TabIndex = 2
        Me.TblRevComitMeetingTopicsBindingNavigator.Text = "BindingNavigator1"
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
        'TblRevComitMeetingTopicsBindingNavigatorSaveItem
        '
        Me.TblRevComitMeetingTopicsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblRevComitMeetingTopicsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblRevComitMeetingTopicsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblRevComitMeetingTopicsBindingNavigatorSaveItem.Name = "TblRevComitMeetingTopicsBindingNavigatorSaveItem"
        Me.TblRevComitMeetingTopicsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblRevComitMeetingTopicsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblRevComitMeetingTopicsDataGridView
        '
        Me.TblRevComitMeetingTopicsDataGridView.AutoGenerateColumns = False
        Me.TblRevComitMeetingTopicsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRevComitMeetingTopicsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.revComitMeetingTopicID, Me.revComitMeetingID, Me.revComitMeetingTopicTypeID, Me.revComitMeetingTopicComments})
        Me.TblRevComitMeetingTopicsDataGridView.DataSource = Me.TblRevComitMeetingTopicsBindingSource
        Me.TblRevComitMeetingTopicsDataGridView.Location = New System.Drawing.Point(91, 216)
        Me.TblRevComitMeetingTopicsDataGridView.Name = "TblRevComitMeetingTopicsDataGridView"
        Me.TblRevComitMeetingTopicsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblRevComitMeetingTopicsDataGridView.TabIndex = 3
        '
        'VcRevComittMeetingTopicTypeIDBindingSource
        '
        Me.VcRevComittMeetingTopicTypeIDBindingSource.DataMember = "vcRevComittMeetingTopicTypeID"
        Me.VcRevComittMeetingTopicTypeIDBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VcRevComittMeetingTopicTypeIDTableAdapter
        '
        Me.VcRevComittMeetingTopicTypeIDTableAdapter.ClearBeforeFill = True
        '
        'revComitMeetingTopicID
        '
        Me.revComitMeetingTopicID.DataPropertyName = "revComitMeetingTopicID"
        Me.revComitMeetingTopicID.HeaderText = "revComitMeetingTopicID"
        Me.revComitMeetingTopicID.Name = "revComitMeetingTopicID"
        Me.revComitMeetingTopicID.ReadOnly = True
        '
        'revComitMeetingID
        '
        Me.revComitMeetingID.DataPropertyName = "revComitMeetingID"
        Me.revComitMeetingID.HeaderText = "revComitMeetingID"
        Me.revComitMeetingID.Name = "revComitMeetingID"
        '
        'revComitMeetingTopicTypeID
        '
        Me.revComitMeetingTopicTypeID.DataPropertyName = "revComitMeetingTopicTypeID"
        Me.revComitMeetingTopicTypeID.DataSource = Me.VcRevComittMeetingTopicTypeIDBindingSource
        Me.revComitMeetingTopicTypeID.DisplayMember = "revComitMeetingTopicTypeDescription"
        Me.revComitMeetingTopicTypeID.HeaderText = "revComitMeetingTopicTypeID"
        Me.revComitMeetingTopicTypeID.Name = "revComitMeetingTopicTypeID"
        Me.revComitMeetingTopicTypeID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.revComitMeetingTopicTypeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.revComitMeetingTopicTypeID.ValueMember = "revComitMeetingTopicTypeID"
        '
        'revComitMeetingTopicComments
        '
        Me.revComitMeetingTopicComments.DataPropertyName = "revComitMeetingTopicComments"
        Me.revComitMeetingTopicComments.HeaderText = "revComitMeetingTopicComments"
        Me.revComitMeetingTopicComments.Name = "revComitMeetingTopicComments"
        '
        'frmRevisionCommiteMeetingTopics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.TblRevComitMeetingTopicsDataGridView)
        Me.Controls.Add(Me.TblRevComitMeetingTopicsBindingNavigator)
        Me.Name = "frmRevisionCommiteMeetingTopics"
        Me.Controls.SetChildIndex(Me.TblRevComitMeetingTopicsBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblRevComitMeetingTopicsDataGridView, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRevComitMeetingTopicsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRevComitMeetingTopicsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblRevComitMeetingTopicsBindingNavigator.ResumeLayout(False)
        Me.TblRevComitMeetingTopicsBindingNavigator.PerformLayout()
        CType(Me.TblRevComitMeetingTopicsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcRevComittMeetingTopicTypeIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblRevComitMeetingTopicsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblRevComitMeetingTopicsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblRevComitMeetingTopicsTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblRevComitMeetingTopicsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblRevComitMeetingTopicsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblRevComitMeetingTopicsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VcRevComittMeetingTopicTypeIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcRevComittMeetingTopicTypeIDTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcRevComittMeetingTopicTypeIDTableAdapter
    Friend WithEvents revComitMeetingTopicID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents revComitMeetingID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents revComitMeetingTopicTypeID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents revComitMeetingTopicComments As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
