Public Class rptEmployeeEvaluationE623

    Public pEvalID As Integer    

    Private Sub rptEmployeeEvaluationE623_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.vcEmpEvalMark' table. You can move, or remove it, as needed.
        Me.vcEmpEvalMarkTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.vcEmpEvalMark)
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptEmployeeEvaluationE623' table. You can move, or remove it, as needed.
        Me.rptEmployeeEvaluationE623TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptEmployeeEvaluationE623, pEvalID)
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.vcEmpEvalCrit' table. You can move, or remove it, as needed.
        Me.vcEmpEvalCritTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.vcEmpEvalCrit)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class