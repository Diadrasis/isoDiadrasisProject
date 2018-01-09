Public Class rptTrainningProgrammeE624
    Public pTrainProgID As Integer
    Private Sub rptTrainningProgrammeE624_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptTrainningProgrammeE624' table. You can move, or remove it, as needed.
        Me.rptTrainningProgrammeE624TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptTrainningProgrammeE624, pTrainProgID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class