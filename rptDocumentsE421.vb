Public Class rptDocumentsE421

    Private Sub rptDocumentsE421_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptDocumentsE421' table. You can move, or remove it, as needed.
        Me.rptDocumentsE421TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptDocumentsE421)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class