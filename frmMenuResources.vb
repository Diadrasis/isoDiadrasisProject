Public Class frmMenuResources

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim oform As New frmQAEmployeeEvaluationCritera
        oform.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim oform As New frmQAEmployeeEvaluationMarks
        oform.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oform As New frmStaff
        oform.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim oform As New frmTrainningProgrammes
        oform.Show()
    End Sub

    Private Sub frmMenuResources_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Πόροι"
    End Sub
End Class
