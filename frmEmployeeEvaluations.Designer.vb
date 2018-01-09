<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeEvaluations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeEvaluations))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblQAEmployeeEvaluationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblQAEmployeeEvaluationsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQAEmployeeEvaluationsTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblQAEmployeeEvaluationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblQAEmployeeEvaluationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQAEmployeeEvaluationsDataGridView = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.empEvalID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.staffID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empEvalDateFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empEvalDateTo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empEvalComments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.empEvalDetails = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQAEmployeeEvaluationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQAEmployeeEvaluationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQAEmployeeEvaluationsBindingNavigator.SuspendLayout()
        CType(Me.TblQAEmployeeEvaluationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblQAEmployeeEvaluationsBindingSource
        '
        Me.TblQAEmployeeEvaluationsBindingSource.DataMember = "tblQAEmployeeEvaluations"
        Me.TblQAEmployeeEvaluationsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblQAEmployeeEvaluationsTableAdapter
        '
        Me.TblQAEmployeeEvaluationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAgreementTableAdapter = Nothing
        Me.TableAdapterManager.tblAgreementTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblLoginTableAdapter = Nothing
        Me.TableAdapterManager.tblProjectTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentsTableAdapter = Nothing
        Me.TableAdapterManager.tblQADocumentTypesTableAdapter = Nothing
        Me.TableAdapterManager.tblQADurationsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationCriteriaTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationDetailsTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationMarksTableAdapter = Nothing
        Me.TableAdapterManager.tblQAEmployeeEvaluationsTableAdapter = Me.TblQAEmployeeEvaluationsTableAdapter
        Me.TableAdapterManager.tblQAResponsibilitiesTableAdapter = Nothing
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblQAEmployeeEvaluationsBindingNavigator
        '
        Me.TblQAEmployeeEvaluationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQAEmployeeEvaluationsBindingNavigator.BindingSource = Me.TblQAEmployeeEvaluationsBindingSource
        Me.TblQAEmployeeEvaluationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQAEmployeeEvaluationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQAEmployeeEvaluationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQAEmployeeEvaluationsBindingNavigatorSaveItem})
        Me.TblQAEmployeeEvaluationsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblQAEmployeeEvaluationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQAEmployeeEvaluationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQAEmployeeEvaluationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQAEmployeeEvaluationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQAEmployeeEvaluationsBindingNavigator.Name = "TblQAEmployeeEvaluationsBindingNavigator"
        Me.TblQAEmployeeEvaluationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQAEmployeeEvaluationsBindingNavigator.Size = New System.Drawing.Size(1272, 25)
        Me.TblQAEmployeeEvaluationsBindingNavigator.TabIndex = 2
        Me.TblQAEmployeeEvaluationsBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        'TblQAEmployeeEvaluationsBindingNavigatorSaveItem
        '
        Me.TblQAEmployeeEvaluationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQAEmployeeEvaluationsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQAEmployeeEvaluationsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQAEmployeeEvaluationsBindingNavigatorSaveItem.Name = "TblQAEmployeeEvaluationsBindingNavigatorSaveItem"
        Me.TblQAEmployeeEvaluationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblQAEmployeeEvaluationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQAEmployeeEvaluationsDataGridView
        '
        Me.TblQAEmployeeEvaluationsDataGridView.AutoGenerateColumns = False
        Me.TblQAEmployeeEvaluationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQAEmployeeEvaluationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empEvalID, Me.staffID, Me.empEvalDateFrom, Me.empEvalDateTo, Me.empEvalComments, Me.empEvalDetails})
        Me.TblQAEmployeeEvaluationsDataGridView.DataSource = Me.TblQAEmployeeEvaluationsBindingSource
        Me.TblQAEmployeeEvaluationsDataGridView.Location = New System.Drawing.Point(70, 260)
        Me.TblQAEmployeeEvaluationsDataGridView.Name = "TblQAEmployeeEvaluationsDataGridView"
        Me.TblQAEmployeeEvaluationsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblQAEmployeeEvaluationsDataGridView.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'empEvalID
        '
        Me.empEvalID.DataPropertyName = "empEvalID"
        Me.empEvalID.HeaderText = "empEvalID"
        Me.empEvalID.Name = "empEvalID"
        Me.empEvalID.ReadOnly = True
        '
        'staffID
        '
        Me.staffID.DataPropertyName = "staffID"
        Me.staffID.HeaderText = "staffID"
        Me.staffID.Name = "staffID"
        '
        'empEvalDateFrom
        '
        Me.empEvalDateFrom.DataPropertyName = "empEvalDateFrom"
        Me.empEvalDateFrom.HeaderText = "empEvalDateFrom"
        Me.empEvalDateFrom.Name = "empEvalDateFrom"
        '
        'empEvalDateTo
        '
        Me.empEvalDateTo.DataPropertyName = "empEvalDateTo"
        Me.empEvalDateTo.HeaderText = "empEvalDateTo"
        Me.empEvalDateTo.Name = "empEvalDateTo"
        '
        'empEvalComments
        '
        Me.empEvalComments.DataPropertyName = "empEvalComments"
        Me.empEvalComments.HeaderText = "empEvalComments"
        Me.empEvalComments.Name = "empEvalComments"
        '
        'empEvalDetails
        '
        Me.empEvalDetails.HeaderText = "empEvalDetails"
        Me.empEvalDetails.Image = Global.diadrasisProjects.My.Resources.Resources.search
        Me.empEvalDetails.Name = "empEvalDetails"
        Me.empEvalDetails.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.empEvalDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmEmployeeEvaluations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1272, 739)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblQAEmployeeEvaluationsDataGridView)
        Me.Controls.Add(Me.TblQAEmployeeEvaluationsBindingNavigator)
        Me.Name = "frmEmployeeEvaluations"
        Me.Controls.SetChildIndex(Me.TblQAEmployeeEvaluationsBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQAEmployeeEvaluationsDataGridView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQAEmployeeEvaluationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQAEmployeeEvaluationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQAEmployeeEvaluationsBindingNavigator.ResumeLayout(False)
        Me.TblQAEmployeeEvaluationsBindingNavigator.PerformLayout()
        CType(Me.TblQAEmployeeEvaluationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblQAEmployeeEvaluationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQAEmployeeEvaluationsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQAEmployeeEvaluationsTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQAEmployeeEvaluationsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblQAEmployeeEvaluationsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQAEmployeeEvaluationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents empEvalID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staffID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empEvalDateFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empEvalDateTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empEvalComments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empEvalDetails As System.Windows.Forms.DataGridViewImageColumn

End Class
