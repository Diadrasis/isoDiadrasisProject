<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptSupplierEvaluationSurveyE746
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.diadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.rptSupplierEvaluationSurveyE746BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptSupplierEvaluationSurveyE746TableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptSupplierEvaluationSurveyE746TableAdapter
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptSupplierEvaluationSurveyE746BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "diadrasisProjectsDBDataSet_rptSupplierEvaluationSurveyE746"
        ReportDataSource1.Value = Me.rptSupplierEvaluationSurveyE746BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptSupplierEvaluationSurveyE746.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 732)
        Me.ReportViewer1.TabIndex = 0
        '
        'diadrasisProjectsDBDataSet
        '
        Me.diadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.diadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptSupplierEvaluationSurveyE746BindingSource
        '
        Me.rptSupplierEvaluationSurveyE746BindingSource.DataMember = "rptSupplierEvaluationSurveyE746"
        Me.rptSupplierEvaluationSurveyE746BindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'rptSupplierEvaluationSurveyE746TableAdapter
        '
        Me.rptSupplierEvaluationSurveyE746TableAdapter.ClearBeforeFill = True
        '
        'rptSupplierEvaluationSurveyE746
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 732)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptSupplierEvaluationSurveyE746"
        Me.Text = "rptSupplierEvaluationSurveyE746"
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptSupplierEvaluationSurveyE746BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptSupplierEvaluationSurveyE746BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents rptSupplierEvaluationSurveyE746TableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptSupplierEvaluationSurveyE746TableAdapter
End Class
