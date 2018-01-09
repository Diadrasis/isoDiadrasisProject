Public Class frmMenuQuality

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oform As New frmDocuments
        oform.pInternal = True
        oform.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim oform As New frmExtDocuments
        oform.pInternal = False
        oform.Show()
    End Sub
End Class
