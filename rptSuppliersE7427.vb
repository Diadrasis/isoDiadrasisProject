Public Class rptSuppliersE7427
    Public pSupTypeID As Integer
    Private Sub rptSuppliersE7427_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'diadrasisProjectsDBDataSet.rptSuppliersE7247' table. You can move, or remove it, as needed.
        Me.rptSuppliersE7247TableAdapter.Fill(Me.diadrasisProjectsDBDataSet.rptSuppliersE7247, Me.pSupTypeID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class