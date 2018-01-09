Public Class rptEmployeeTrainningE625
    Public pEmpID As Integer
    Private Sub rptEmployeeTrainningE625_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptTrainningEmployeeE265' table. You can move, or remove it, as needed.
        Me.rptTrainningEmployeeE265TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptTrainningEmployeeE265, pEmpID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class