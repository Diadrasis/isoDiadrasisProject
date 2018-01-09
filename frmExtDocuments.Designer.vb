<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtDocuments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExtDocuments))
        Me.DiadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.TblQADocumentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblQADocumentsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQADocumentsTableAdapter
        Me.TableAdapterManager = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
        Me.TblQADocumentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblQADocumentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TblQADocumentsDataGridView = New System.Windows.Forms.DataGridView
        Me.VcDurationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VcResponibilitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblQADocumentTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VcDurationsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcDurationsTableAdapter
        Me.VcResponibilitiesTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcResponibilitiesTableAdapter
        Me.TblQADocumentTypesTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQADocumentTypesTableAdapter
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.docID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docInternal = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.docTitle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docPublication = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docDuration = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.docResponsible = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.docType = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.docReview = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docFile = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.docFileLocation = New System.Windows.Forms.DataGridViewImageColumn
        Me.docFileOpen = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQADocumentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQADocumentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblQADocumentsBindingNavigator.SuspendLayout()
        CType(Me.TblQADocumentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcDurationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcResponibilitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblQADocumentTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiadrasisProjectsDBDataSet
        '
        Me.DiadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.DiadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblQADocumentsBindingSource
        '
        Me.TblQADocumentsBindingSource.DataMember = "tblQADocuments"
        Me.TblQADocumentsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblQADocumentsTableAdapter
        '
        Me.TblQADocumentsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblQADocumentsTableAdapter = Me.TblQADocumentsTableAdapter
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
        Me.TableAdapterManager.tblStaffTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierEvalTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblSupplierTypeTableAdapter = Nothing
        Me.TableAdapterManager.tblTaskTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblQADocumentsBindingNavigator
        '
        Me.TblQADocumentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblQADocumentsBindingNavigator.BindingSource = Me.TblQADocumentsBindingSource
        Me.TblQADocumentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblQADocumentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblQADocumentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblQADocumentsBindingNavigatorSaveItem})
        Me.TblQADocumentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblQADocumentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblQADocumentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblQADocumentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblQADocumentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblQADocumentsBindingNavigator.Name = "TblQADocumentsBindingNavigator"
        Me.TblQADocumentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblQADocumentsBindingNavigator.Size = New System.Drawing.Size(1252, 25)
        Me.TblQADocumentsBindingNavigator.TabIndex = 2
        Me.TblQADocumentsBindingNavigator.Text = "BindingNavigator1"
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
        'TblQADocumentsBindingNavigatorSaveItem
        '
        Me.TblQADocumentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblQADocumentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblQADocumentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblQADocumentsBindingNavigatorSaveItem.Name = "TblQADocumentsBindingNavigatorSaveItem"
        Me.TblQADocumentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblQADocumentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblQADocumentsDataGridView
        '
        Me.TblQADocumentsDataGridView.AutoGenerateColumns = False
        Me.TblQADocumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblQADocumentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.docID, Me.docInternal, Me.docTitle, Me.docCode, Me.docPublication, Me.docDate, Me.docDuration, Me.docResponsible, Me.docType, Me.docReview, Me.docFile, Me.docFileLocation, Me.docFileOpen})
        Me.TblQADocumentsDataGridView.DataSource = Me.TblQADocumentsBindingSource
        Me.TblQADocumentsDataGridView.Location = New System.Drawing.Point(67, 204)
        Me.TblQADocumentsDataGridView.Name = "TblQADocumentsDataGridView"
        Me.TblQADocumentsDataGridView.Size = New System.Drawing.Size(1064, 220)
        Me.TblQADocumentsDataGridView.TabIndex = 3
        '
        'VcDurationsBindingSource
        '
        Me.VcDurationsBindingSource.DataMember = "vcDurations"
        Me.VcDurationsBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VcResponibilitiesBindingSource
        '
        Me.VcResponibilitiesBindingSource.DataMember = "vcResponibilities"
        Me.VcResponibilitiesBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'TblQADocumentTypesBindingSource
        '
        Me.TblQADocumentTypesBindingSource.DataMember = "tblQADocumentTypes"
        Me.TblQADocumentTypesBindingSource.DataSource = Me.DiadrasisProjectsDBDataSet
        '
        'VcDurationsTableAdapter
        '
        Me.VcDurationsTableAdapter.ClearBeforeFill = True
        '
        'VcResponibilitiesTableAdapter
        '
        Me.VcResponibilitiesTableAdapter.ClearBeforeFill = True
        '
        'TblQADocumentTypesTableAdapter
        '
        Me.TblQADocumentTypesTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        '
        'docID
        '
        Me.docID.DataPropertyName = "docID"
        Me.docID.HeaderText = "docID"
        Me.docID.Name = "docID"
        Me.docID.ReadOnly = True
        '
        'docInternal
        '
        Me.docInternal.DataPropertyName = "docInternal"
        Me.docInternal.HeaderText = "docInternal"
        Me.docInternal.Name = "docInternal"
        '
        'docTitle
        '
        Me.docTitle.DataPropertyName = "docTitle"
        Me.docTitle.HeaderText = "docTitle"
        Me.docTitle.Name = "docTitle"
        '
        'docCode
        '
        Me.docCode.DataPropertyName = "docCode"
        Me.docCode.HeaderText = "docCode"
        Me.docCode.Name = "docCode"
        '
        'docPublication
        '
        Me.docPublication.DataPropertyName = "docPublication"
        Me.docPublication.HeaderText = "docPublication"
        Me.docPublication.Name = "docPublication"
        '
        'docDate
        '
        Me.docDate.DataPropertyName = "docDate"
        Me.docDate.HeaderText = "docDate"
        Me.docDate.Name = "docDate"
        '
        'docDuration
        '
        Me.docDuration.DataPropertyName = "docDuration"
        Me.docDuration.DataSource = Me.VcDurationsBindingSource
        Me.docDuration.DisplayMember = "durDesc"
        Me.docDuration.HeaderText = "docDuration"
        Me.docDuration.Name = "docDuration"
        Me.docDuration.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.docDuration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.docDuration.ValueMember = "durID"
        '
        'docResponsible
        '
        Me.docResponsible.DataPropertyName = "docResponsible"
        Me.docResponsible.DataSource = Me.VcResponibilitiesBindingSource
        Me.docResponsible.DisplayMember = "respDesc"
        Me.docResponsible.HeaderText = "docResponsible"
        Me.docResponsible.Name = "docResponsible"
        Me.docResponsible.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.docResponsible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.docResponsible.ValueMember = "respID"
        '
        'docType
        '
        Me.docType.DataPropertyName = "docType"
        Me.docType.DataSource = Me.TblQADocumentTypesBindingSource
        Me.docType.DisplayMember = "doctypeDesc"
        Me.docType.HeaderText = "docType"
        Me.docType.Name = "docType"
        Me.docType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.docType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.docType.ValueMember = "doctypeID"
        '
        'docReview
        '
        Me.docReview.DataPropertyName = "docReview"
        Me.docReview.HeaderText = "docReview"
        Me.docReview.Name = "docReview"
        '
        'docFile
        '
        Me.docFile.HeaderText = "docFile"
        Me.docFile.Name = "docFile"
        '
        'docFileLocation
        '
        Me.docFileLocation.HeaderText = "docFileLocation"
        Me.docFileLocation.Image = Global.diadrasisProjects.My.Resources.Resources.save
        Me.docFileLocation.Name = "docFileLocation"
        '
        'docFileOpen
        '
        Me.docFileOpen.HeaderText = "docFileOpen"
        Me.docFileOpen.Image = Global.diadrasisProjects.My.Resources.Resources.update
        Me.docFileOpen.Name = "docFileOpen"
        '
        'frmExtDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.TblQADocumentsDataGridView)
        Me.Controls.Add(Me.TblQADocumentsBindingNavigator)
        Me.Name = "frmExtDocuments"
        Me.Controls.SetChildIndex(Me.TblQADocumentsBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.TblQADocumentsDataGridView, 0)
        CType(Me.DiadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQADocumentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQADocumentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblQADocumentsBindingNavigator.ResumeLayout(False)
        Me.TblQADocumentsBindingNavigator.PerformLayout()
        CType(Me.TblQADocumentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcDurationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcResponibilitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblQADocumentTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents TblQADocumentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQADocumentsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQADocumentsTableAdapter
    Friend WithEvents TableAdapterManager As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblQADocumentsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblQADocumentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblQADocumentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VcDurationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcDurationsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcDurationsTableAdapter
    Friend WithEvents VcResponibilitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VcResponibilitiesTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcResponibilitiesTableAdapter
    Friend WithEvents TblQADocumentTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblQADocumentTypesTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.tblQADocumentTypesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents docID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docInternal As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents docTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docPublication As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docDuration As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents docResponsible As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents docType As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents docReview As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docFileLocation As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents docFileOpen As System.Windows.Forms.DataGridViewImageColumn

End Class
