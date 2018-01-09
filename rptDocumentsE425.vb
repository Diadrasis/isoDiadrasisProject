Public Class rptDocumentsE425

    Private Sub rptDocumentsE425_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptDocumentsE425' table. You can move, or remove it, as needed.
        Me.rptDocumentsE425TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptDocumentsE425)
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptDocumentsE421' table. You can move, or remove it, as needed.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class