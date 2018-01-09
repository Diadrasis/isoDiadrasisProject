Public Class rptEmployeeResumeE622

    Public pEmpID As Integer
    Public pCategory As String

    Private Sub rptEmployeeResumeE622_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptEmployeeResumeE622' table. You can move, or remove it, as needed.
        Me.rptEmployeeResumeE622TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptEmployeeResumeE622, pEmpID)

        Me.RptEducationTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptEducation, pEmpID)

        Me.RptProjectByStaffTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptProjectByStaff, pEmpID)        

        Dim par As New Microsoft.Reporting.WinForms.ReportParameter()

        par.Name = "Category"
        If pCategory IsNot Nothing Then
            par.Values.Add(pCategory)
        Else
            par.Values.Add("")
        End If

        Dim parameters() As Microsoft.Reporting.WinForms.ReportParameter = {par}
        Me.ReportViewer1.LocalReport.SetParameters(parameters)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class