<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptProjectTasksE752
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rptProjectTasksE752BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.diadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptProjectTasksE752TableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptProjectTasksE752TableAdapter()
        Me.RptProjectTasksE752BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.rptProjectTasksE752BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptProjectTasksE752BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptProjectTasksE752BindingSource
        '
        Me.rptProjectTasksE752BindingSource.DataMember = "rptProjectTasksE752"
        Me.rptProjectTasksE752BindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'diadrasisProjectsDBDataSet
        '
        Me.diadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.diadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RptProjectTasksE752BindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptProjectTasksE752.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 732)
        Me.ReportViewer1.TabIndex = 0
        '
        'rptProjectTasksE752TableAdapter
        '
        Me.rptProjectTasksE752TableAdapter.ClearBeforeFill = True
        '
        'RptProjectTasksE752BindingSource1
        '
        Me.RptProjectTasksE752BindingSource1.DataMember = "rptProjectTasksE752"
        Me.RptProjectTasksE752BindingSource1.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'rptProjectTasksE752
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 732)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptProjectTasksE752"
        Me.Text = "rptProjectTasksE752"
        CType(Me.rptProjectTasksE752BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptProjectTasksE752BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptProjectTasksE752BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents rptProjectTasksE752TableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptProjectTasksE752TableAdapter
    Friend WithEvents RptProjectTasksE752BindingSource1 As System.Windows.Forms.BindingSource
End Class
