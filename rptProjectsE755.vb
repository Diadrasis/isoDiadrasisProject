Public Class rptProjectsE755

    Private Sub rptProjectsE755_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptProjectsE755' table. You can move, or remove it, as needed.
        Me.rptProjectsE755TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptProjectsE755)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class