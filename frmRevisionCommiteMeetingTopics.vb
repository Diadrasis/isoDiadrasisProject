Public Class frmRevisionCommiteMeetingTopics
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Public pMeetingID As Integer

    Private Sub TblRevComitMeetingTopicsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblRevComitMeetingTopicsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRevComitMeetingTopicsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmRevisionCommiteMeetingTopics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcRevComittMeetingTopicTypeID' table. You can move, or remove it, as needed.
        Me.VcRevComittMeetingTopicTypeIDTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcRevComittMeetingTopicTypeID)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblRevComitMeetingTopics' table. You can move, or remove it, as needed.
        Me.TblRevComitMeetingTopicsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblRevComitMeetingTopics)

        dgv = Me.TblRevComitMeetingTopicsDataGridView
        dbn = Me.TblRevComitMeetingTopicsBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Θέματα Επιτροπής Ανασκόπισης Ποιότητας"

        DesignColumn(dgv, "revComitMeetingTopicID", False)
        DesignColumn(dgv, "revComitMeetingID", False)
        DesignColumn(dgv, "revComitMeetingTopicTypeID", "Είδος", 120)
        DesignColumn(dgv, "revComitMeetingTopicComments", "Παρατηρήσεις", 225)
    End Sub


    Private Sub TblRevComitMeetingTopicsDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblRevComitMeetingTopicsDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("revComitMeetingID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("revComitMeetingID").Value = Me.pMeetingID
        End If
    End Sub
End Class
