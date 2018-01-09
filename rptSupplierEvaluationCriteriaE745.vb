Public Class rptSupplierEvaluationCriteriaE745

    Private Sub rptSupplierEvaluationE745_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.vcCustomSatCrit' table. You can move, or remove it, as needed.
        Me.vcCustomSatCritTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.vcCustomSatCrit)
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.vcSuppSatMarks' table. You can move, or remove it, as needed.
        Me.vcSuppSatMarksTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.vcSuppSatMarks)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class