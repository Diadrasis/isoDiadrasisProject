<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptSupplierEvaluationCriteriaE745
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.diadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.vcCustomSatCritBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vcCustomSatCritTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcCustomSatCritTableAdapter
        Me.vcSuppSatMarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vcSuppSatMarksTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcSuppSatMarksTableAdapter
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vcCustomSatCritBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vcSuppSatMarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "diadrasisProjectsDBDataSet_vcCustomSatCrit"
        ReportDataSource1.Value = Me.vcCustomSatCritBindingSource
        ReportDataSource2.Name = "diadrasisProjectsDBDataSet_vcSuppSatMarks"
        ReportDataSource2.Value = Me.vcSuppSatMarksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptSupplierEvaluationCriteriaE745.rdlc"
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
        'vcCustomSatCritBindingSource
        '
        Me.vcCustomSatCritBindingSource.DataMember = "vcCustomSatCrit"
        Me.vcCustomSatCritBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'vcCustomSatCritTableAdapter
        '
        Me.vcCustomSatCritTableAdapter.ClearBeforeFill = True
        '
        'vcSuppSatMarksBindingSource
        '
        Me.vcSuppSatMarksBindingSource.DataMember = "vcSuppSatMarks"
        Me.vcSuppSatMarksBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'vcSuppSatMarksTableAdapter
        '
        Me.vcSuppSatMarksTableAdapter.ClearBeforeFill = True
        '
        'rptSupplierEvaluationE745
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 732)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptSupplierEvaluationE745"
        Me.Text = "rptSupplierEvaluationE745"
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vcCustomSatCritBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vcSuppSatMarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents vcCustomSatCritBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents vcSuppSatMarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents vcCustomSatCritTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcCustomSatCritTableAdapter
    Friend WithEvents vcSuppSatMarksTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcSuppSatMarksTableAdapter
End Class
