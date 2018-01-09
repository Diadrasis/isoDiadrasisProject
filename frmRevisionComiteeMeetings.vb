Public Class frmRevisionComiteeMeetings
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentRow As Integer

    Private Sub TblRevComitMeetingsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblRevComitMeetingsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRevComitMeetingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmRevisionComiteeMeetings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblRevComitMeetings' table. You can move, or remove it, as needed.
        Me.TblRevComitMeetingsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblRevComitMeetings)

        dgv = Me.TblRevComitMeetingsDataGridView
        dbn = Me.TblRevComitMeetingsBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Επιτροπή Ανασκόπισης Ποιότητας"

        DesignColumn(dgv, "revComitMeetingID", False)
        DesignColumn(dgv, "revComitMeetingDate", "Ημ/νία", 120)
        DesignColumn(dgv, "revComitMeetingNextDate", "Ημ/νία", 120)
        DesignColumn(dgv, "revComitMeetingTopics", "Θέματα", 120)
        DesignColumn(dgv, "revComitMeetingRecommedations", "Προτάσεις", 120)
        DesignColumn(dgv, "revComitMeetingComments", "Παρατηρήσεις", 225)
        DesignColumn(dgv, "revComitMeetingReport", "Πρακτικό", 225)

    End Sub

    Private Sub TblRevComitMeetingsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblRevComitMeetingsDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentRow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("revComitMeetingTopics").Index Then
                Dim oform As New frmRevisionCommiteMeetingTopics
                oform.pMeetingID = dgv.Rows(currentRow).Cells("revComitMeetingID").Value
                oform.Show()
            ElseIf e.ColumnIndex = dgv.Columns("revComitMeetingRecommedations").Index Then
                Dim oform As New frmRevisionComiteeMeetingRecommedations
                oform.pMeetingID = dgv.Rows(currentRow).Cells("revComitMeetingID").Value
                oform.Show()
            ElseIf e.ColumnIndex = dgv.Columns("revComitMeetingReport").Index Then
                Dim oform As New rptRevisionCommiteeMeetingE561
                oform.pMeetingID = dgv.Rows(currentRow).Cells("revComitMeetingID").Value
                oform.Show()
            End If
        End If
    End Sub

End Class
