<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptTasksByProject
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
        Me.rptTasksByProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.diadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.rptTasksByProjectTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptTasksByProjectTableAdapter
        CType(Me.rptTasksByProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptTasksByProjectBindingSource
        '
        Me.rptTasksByProjectBindingSource.DataMember = "rptTasksByProject"
        Me.rptTasksByProjectBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'diadrasisProjectsDBDataSet
        '
        Me.diadrasisProjectsDBDataSet.DataSetName = "diadrasisProjectsDBDataSet"
        Me.diadrasisProjectsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "diadrasisProjectsDBDataSet_rptTasksByProject"
        ReportDataSource1.Value = Me.rptTasksByProjectBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptTasksByProject.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1252, 730)
        Me.ReportViewer1.TabIndex = 0
        '
        'rptTasksByProjectTableAdapter
        '
        Me.rptTasksByProjectTableAdapter.ClearBeforeFill = True
        '
        'rptTasksByProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptTasksByProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rptTasksByProject"
        CType(Me.rptTasksByProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptTasksByProjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents rptTasksByProjectTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptTasksByProjectTableAdapter
End Class
