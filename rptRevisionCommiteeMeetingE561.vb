Public Class rptRevisionCommiteeMeetingE561
    Public pMeetingID As Integer
    Private Sub rptRevisionCommiteeMeetingE561_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptRevisionCommiteeMeetingE561' table. You can move, or remove it, as needed.
        Me.rptRevisionCommiteeMeetingE561TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptRevisionCommiteeMeetingE561, pMeetingID)
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.vcRevisionCommiteeMeetingRecommedetations' table. You can move, or remove it, as needed.
        Me.vcRevisionCommiteeMeetingRecommedetationsTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.vcRevisionCommiteeMeetingRecommedetations, pMeetingID)
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.vcRevisionCommiteeMeetingTopics' table. You can move, or remove it, as needed.
        Me.vcRevisionCommiteeMeetingTopicsTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.vcRevisionCommiteeMeetingTopics, pMeetingID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class