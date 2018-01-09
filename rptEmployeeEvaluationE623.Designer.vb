<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptEmployeeEvaluationE623
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.rptEmployeeEvaluationE623BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.diadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.vcEmpEvalCritBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vcEmpEvalMarkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rptEmployeeEvaluationE623TableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptEmployeeEvaluationE623TableAdapter
        Me.vcEmpEvalCritTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcEmpEvalCritTableAdapter
        Me.vcEmpEvalMarkTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcEmpEvalMarkTableAdapter
        CType(Me.rptEmployeeEvaluationE623BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vcEmpEvalCritBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vcEmpEvalMarkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptEmployeeEvaluationE623BindingSource
        '
        Me.rptEmployeeEvaluationE623BindingSource.DataMember = "rptEmployeeEvaluationE623"
        Me.rptEmployeeEvaluationE623BindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'diadrasisProjectsDBDataSet
        '
        Me.diadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.diadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vcEmpEvalCritBindingSource
        '
        Me.vcEmpEvalCritBindingSource.DataMember = "vcEmpEvalCrit"
        Me.vcEmpEvalCritBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'vcEmpEvalMarkBindingSource
        '
        Me.vcEmpEvalMarkBindingSource.DataMember = "vcEmpEvalMark"
        Me.vcEmpEvalMarkBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "diadrasisProjectsDBDataSet_rptEmployeeEvaluationE623"
        ReportDataSource1.Value = Me.rptEmployeeEvaluationE623BindingSource
        ReportDataSource2.Name = "diadrasisProjectsDBDataSet_vcEmpEvalCrit"
        ReportDataSource2.Value = Me.vcEmpEvalCritBindingSource
        ReportDataSource3.Name = "diadrasisProjectsDBDataSet_vcEmpEvalMark"
        ReportDataSource3.Value = Me.vcEmpEvalMarkBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptEmployeeEvaluationE623.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 732)
        Me.ReportViewer1.TabIndex = 0
        '
        'rptEmployeeEvaluationE623TableAdapter
        '
        Me.rptEmployeeEvaluationE623TableAdapter.ClearBeforeFill = True
        '
        'vcEmpEvalCritTableAdapter
        '
        Me.vcEmpEvalCritTableAdapter.ClearBeforeFill = True
        '
        'vcEmpEvalMarkTableAdapter
        '
        Me.vcEmpEvalMarkTableAdapter.ClearBeforeFill = True
        '
        'rptEmployeeEvaluationE623
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 732)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptEmployeeEvaluationE623"
        Me.Text = "rptEmployeeEvaluationE623"
        CType(Me.rptEmployeeEvaluationE623BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vcEmpEvalCritBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vcEmpEvalMarkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptEmployeeEvaluationE623BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents vcEmpEvalCritBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rptEmployeeEvaluationE623TableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptEmployeeEvaluationE623TableAdapter
    Friend WithEvents vcEmpEvalCritTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcEmpEvalCritTableAdapter
    Friend WithEvents vcEmpEvalMarkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents vcEmpEvalMarkTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcEmpEvalMarkTableAdapter
End Class
