<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptEmployeeResumeE622
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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rptEmployeeResumeE622BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.diadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.rptEmployeeResumeE622TableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptEmployeeResumeE622TableAdapter
        Me.RptEducationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptEducationTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptEducationTableAdapter
        Me.RptProjectByStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptProjectByStaffTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptProjectByStaffTableAdapter
        CType(Me.rptEmployeeResumeE622BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptEducationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptProjectByStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "diadrasisProjectsDBDataSet_rptEmployeeResumeE622"
        ReportDataSource4.Value = Me.rptEmployeeResumeE622BindingSource
        ReportDataSource5.Name = "diadrasisProjectsDBDataSet_rptEducation"
        ReportDataSource5.Value = Me.RptEducationBindingSource
        ReportDataSource6.Name = "diadrasisProjectsDBDataSet_rptProjectByStaff"
        ReportDataSource6.Value = Me.RptProjectByStaffBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptEmployeeResumeE622.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 732)
        Me.ReportViewer1.TabIndex = 0
        '
        'rptEmployeeResumeE622BindingSource
        '
        Me.rptEmployeeResumeE622BindingSource.DataMember = "rptEmployeeResumeE622"
        Me.rptEmployeeResumeE622BindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'diadrasisProjectsDBDataSet
        '
        Me.diadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.diadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptEmployeeResumeE622TableAdapter
        '
        Me.rptEmployeeResumeE622TableAdapter.ClearBeforeFill = True
        '
        'RptEducationBindingSource
        '
        Me.RptEducationBindingSource.DataMember = "rptEducation"
        Me.RptEducationBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'RptEducationTableAdapter
        '
        Me.RptEducationTableAdapter.ClearBeforeFill = True
        '
        'RptProjectByStaffBindingSource
        '
        Me.RptProjectByStaffBindingSource.DataMember = "rptProjectByStaff"
        Me.RptProjectByStaffBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'RptProjectByStaffTableAdapter
        '
        Me.RptProjectByStaffTableAdapter.ClearBeforeFill = True
        '
        'rptEmployeeResumeE622
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 732)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptEmployeeResumeE622"
        Me.Text = "rptEmployeeResumeE622"
        CType(Me.rptEmployeeResumeE622BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptEducationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptProjectByStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptEmployeeResumeE622BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents rptEmployeeResumeE622TableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptEmployeeResumeE622TableAdapter
    Friend WithEvents RptEducationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RptProjectByStaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RptEducationTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptEducationTableAdapter
    Friend WithEvents RptProjectByStaffTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptProjectByStaffTableAdapter
End Class
