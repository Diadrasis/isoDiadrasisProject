Public Class rptSupplierEvaluationSurveyE746
    Public pSuppEvalSurvID As Integer
    Private Sub rptSupplierEvaluationSurveyE746_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptSupplierEvaluationSurveyE746' table. You can move, or remove it, as needed.
        Me.rptSupplierEvaluationSurveyE746TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptSupplierEvaluationSurveyE746, pSuppEvalSurvID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class