Public Class rptCustomersE754

    Private Sub rptCustomersE754_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.vwCustomer' table. You can move, or remove it, as needed.
        Me.vwCustomerTableAdapter.Fill(Me.diadrasisProjectsDBDataSet.vwCustomer)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class