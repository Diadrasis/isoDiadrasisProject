Public Class rptCustomerSatisfactionE841
    Public pCustSatSurvID As Integer
    Private Sub rptCustomerSatisfactionE841_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptCustomerSatisfactionE841' table. You can move, or remove it, as needed.
        Me.rptCustomerSatisfactionE841TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptCustomerSatisfactionE841, pCustSatSurvID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class