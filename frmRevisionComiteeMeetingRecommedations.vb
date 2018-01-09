Public Class frmRevisionComiteeMeetingRecommedations
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Public pMeetingID As Integer
    Private Sub TblRevComitMeetingRecommedationsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblRevComitMeetingRecommedationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRevComitMeetingRecommedationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmRevisionComiteeMeetingRecommedations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblRevComitMeetingRecommedations' table. You can move, or remove it, as needed.
        Me.TblRevComitMeetingRecommedationsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblRevComitMeetingRecommedations)

        dgv = Me.TblRevComitMeetingRecommedationsDataGridView
        dbn = Me.TblRevComitMeetingRecommedationsBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Προτάσεις Επιτροπής Ανασκόπισης Ποιότητας"

        DesignColumn(dgv, "revComitMeetingRecommedID", False)
        DesignColumn(dgv, "revComitMeetingID", False)
        DesignColumn(dgv, "revComitMeetingDescription", "Περιγραφή", 120)
        DesignColumn(dgv, "revComitMeetingArea", "Περιοχή", 120)
        DesignColumn(dgv, "revComitMeetingActions", "Ενέργειες", 120)
        DesignColumn(dgv, "revComitMeetingRecommedComments", "Παρατηρήσεις", 225)

    End Sub


    Private Sub TblRevComitMeetingRecommedationsDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblRevComitMeetingRecommedationsDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("revComitMeetingID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("revComitMeetingID").Value = Me.pMeetingID
        End If
    End Sub
End Class
