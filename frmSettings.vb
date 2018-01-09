Public Class frmSettings

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim oform As New frmChooseTheme
        ' oform.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim oform As New frmUsers
        oform.Show()
    End Sub

    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Ρυθμίσεις"
    End Sub
End Class
