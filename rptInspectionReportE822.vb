Public Class rptInspectionReportE822
    Public pInspRepID As Integer
    Private Sub rptInspectionReportE822_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptInspectionReportE822' table. You can move, or remove it, as needed.
        Me.rptInspectionReportE822TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptInspectionReportE822, pInspRepID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class