<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptRevisionCommiteeMeetingE561
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.diadrasisProjectsDBDataSet = New diadrasisProjects.diadrasisProjectsDBDataSet
        Me.rptRevisionCommiteeMeetingE561BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptRevisionCommiteeMeetingE561TableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptRevisionCommiteeMeetingE561TableAdapter
        Me.vcRevisionCommiteeMeetingRecommedetationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vcRevisionCommiteeMeetingRecommedetationsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcRevisionCommiteeMeetingRecommedetationsTableAdapter
        Me.vcRevisionCommiteeMeetingTopicsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vcRevisionCommiteeMeetingTopicsTableAdapter = New diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcRevisionCommiteeMeetingTopicsTableAdapter
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptRevisionCommiteeMeetingE561BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vcRevisionCommiteeMeetingRecommedetationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vcRevisionCommiteeMeetingTopicsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "diadrasisProjectsDBDataSet_rptRevisionCommiteeMeetingE561"
        ReportDataSource1.Value = Me.rptRevisionCommiteeMeetingE561BindingSource
        ReportDataSource2.Name = "diadrasisProjectsDBDataSet_vcRevisionCommiteeMeetingRecommedetations"
        ReportDataSource2.Value = Me.vcRevisionCommiteeMeetingRecommedetationsBindingSource
        ReportDataSource3.Name = "diadrasisProjectsDBDataSet_vcRevisionCommiteeMeetingTopics"
        ReportDataSource3.Value = Me.vcRevisionCommiteeMeetingTopicsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "diadrasisProjects.rptRevisionCommiteeMeetingE561.rdlc"
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
        'rptRevisionCommiteeMeetingE561BindingSource
        '
        Me.rptRevisionCommiteeMeetingE561BindingSource.DataMember = "rptRevisionCommiteeMeetingE561"
        Me.rptRevisionCommiteeMeetingE561BindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'rptRevisionCommiteeMeetingE561TableAdapter
        '
        Me.rptRevisionCommiteeMeetingE561TableAdapter.ClearBeforeFill = True
        '
        'vcRevisionCommiteeMeetingRecommedetationsBindingSource
        '
        Me.vcRevisionCommiteeMeetingRecommedetationsBindingSource.DataMember = "vcRevisionCommiteeMeetingRecommedetations"
        Me.vcRevisionCommiteeMeetingRecommedetationsBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'vcRevisionCommiteeMeetingRecommedetationsTableAdapter
        '
        Me.vcRevisionCommiteeMeetingRecommedetationsTableAdapter.ClearBeforeFill = True
        '
        'vcRevisionCommiteeMeetingTopicsBindingSource
        '
        Me.vcRevisionCommiteeMeetingTopicsBindingSource.DataMember = "vcRevisionCommiteeMeetingTopics"
        Me.vcRevisionCommiteeMeetingTopicsBindingSource.DataSource = Me.diadrasisProjectsDBDataSet
        '
        'vcRevisionCommiteeMeetingTopicsTableAdapter
        '
        Me.vcRevisionCommiteeMeetingTopicsTableAdapter.ClearBeforeFill = True
        '
        'rptRevisionCommiteeMeetingE561
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 732)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptRevisionCommiteeMeetingE561"
        Me.Text = "rptRevisionCommiteeMeetingE561"
        CType(Me.diadrasisProjectsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptRevisionCommiteeMeetingE561BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vcRevisionCommiteeMeetingRecommedetationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vcRevisionCommiteeMeetingTopicsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptRevisionCommiteeMeetingE561BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents diadrasisProjectsDBDataSet As diadrasisProjects.diadrasisProjectsDBDataSet
    Friend WithEvents vcRevisionCommiteeMeetingRecommedetationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents vcRevisionCommiteeMeetingTopicsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rptRevisionCommiteeMeetingE561TableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.rptRevisionCommiteeMeetingE561TableAdapter
    Friend WithEvents vcRevisionCommiteeMeetingRecommedetationsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcRevisionCommiteeMeetingRecommedetationsTableAdapter
    Friend WithEvents vcRevisionCommiteeMeetingTopicsTableAdapter As diadrasisProjects.diadrasisProjectsDBDataSetTableAdapters.vcRevisionCommiteeMeetingTopicsTableAdapter
End Class
