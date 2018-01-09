<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptNonConformanceE831
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
        Me.rptNonConformancesE831BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptNonConformancesE831TableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptNonConformancesE831TableAdapter
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptNonConformancesE831BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "diadrasisProjectsDBDataSet_rptNonConformancesE831"
        ReportDataSource1.Value = Me.rptNonConformancesE831BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptNonConformanceE831.rdlc"
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
        'rptNonConformancesE831BindingSource
        '
        Me.rptNonConformancesE831BindingSource.DataMember = "rptNonConformancesE831"
        Me.rptNonConformancesE831BindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'rptNonConformancesE831TableAdapter
        '
        Me.rptNonConformancesE831TableAdapter.ClearBeforeFill = True
        '
        'rptNonConformanceE831
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 732)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptNonConformanceE831"
        Me.Text = "rptNonConformanceE831"
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptNonConformancesE831BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptNonConformancesE831BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents rptNonConformancesE831TableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptNonConformancesE831TableAdapter
End Class
