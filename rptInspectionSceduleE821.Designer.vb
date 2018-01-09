<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptInspectionSceduleE821
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
        Me.rptInspectionSceduleE821BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptInspectionSceduleE821TableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptInspectionSceduleE821TableAdapter
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptInspectionSceduleE821BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "diadrasisProjectsDBDataSet_rptInspectionSceduleE821"
        ReportDataSource1.Value = Me.rptInspectionSceduleE821BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptInspectionSceduleE821.rdlc"
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
        'rptInspectionSceduleE821BindingSource
        '
        Me.rptInspectionSceduleE821BindingSource.DataMember = "rptInspectionSceduleE821"
        Me.rptInspectionSceduleE821BindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'rptInspectionSceduleE821TableAdapter
        '
        Me.rptInspectionSceduleE821TableAdapter.ClearBeforeFill = True
        '
        'rptInspectionSceduleE821
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 732)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptInspectionSceduleE821"
        Me.Text = "rptInspectionSceduleE821"
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptInspectionSceduleE821BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptInspectionSceduleE821BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents rptInspectionSceduleE821TableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptInspectionSceduleE821TableAdapter
End Class
