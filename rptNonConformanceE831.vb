Public Class rptNonConformanceE831
    Public pNonConfID As Integer
    Private Sub rptNonConformanceE831_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptNonConformancesE831' table. You can move, or remove it, as needed.
        Me.rptNonConformancesE831TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptNonConformancesE831, pNonConfID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class