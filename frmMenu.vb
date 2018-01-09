Public Class frmMenu

    Private Sub frmMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Κεντρικό Μενού"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oform As New frmProject
        oform.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oform As New frmReports
        oform.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim oform As New frmSettings
        oform.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim oform As New frmMenuResources
        oform.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oform As New frmMenuEvaluation
        oform.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim oform As New frmMenuProcurments
        oform.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim oform As New frmMenuQuality
        oform.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim oform As New frmMenuManagement
        oform.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim oform As New frmMenuSales
        oform.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim oform As New frmMenuProduction
        oform.Show()
    End Sub
End Class
