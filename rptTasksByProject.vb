Public Class rptTasksByProject

    Private Sub rptTasksByProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptTasksByProject' table. You can move, or remove it, as needed.
        Me.rptTasksByProjectTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptTasksByProject)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class