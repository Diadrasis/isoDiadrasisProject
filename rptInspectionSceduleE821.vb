Public Class rptInspectionSceduleE821
    Public pInspSceduleID As Integer
    Private Sub rptInspectionSceduleE821_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptInspectionSceduleE821' table. You can move, or remove it, as needed.
        Me.rptInspectionSceduleE821TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptInspectionSceduleE821, pInspSceduleID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class