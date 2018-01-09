Public Class frmMenuProcurments

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim oform As New frmQASupplierSatisfactionCriteria
        oform.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim oform As New frmQASupplierSatisfactionMarks
        oform.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oform As New rptSuppliersE7427
        oform.pSupTypeID = 1
        oform.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim oform As New rptSuppliersE7427
        oform.pSupTypeID = 2
        oform.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim oform As New frmSupplier
        oform.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim oform As New rptSupplierEvaluationCriteriaE745
        oform.Show()
    End Sub
End Class
