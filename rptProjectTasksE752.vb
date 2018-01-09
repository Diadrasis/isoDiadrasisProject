Public Class rptProjectTasksE752
    Public pProjID As Integer
    Public pDateStart, pDateEnd As DateTime

    Private Sub rptProjectTasksE752_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptProjectTasksE752' table. You can move, or remove it, as needed.
        Me.rptProjectTasksE752TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptProjectTasksE752, pProjID, pDateStart, pDateEnd)

        Dim parDateStart, parDateEnd As New Microsoft.Reporting.WinForms.ReportParameter()

        parDateStart.Name = "pDateStart"
        parDateStart.Values.Add(pDateStart)

        parDateEnd.Name = "pDateEnd"
        parDateEnd.Values.Add(pDateEnd)

        Dim parameters() As Microsoft.Reporting.WinForms.ReportParameter = {parDateStart, parDateEnd}

        Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class