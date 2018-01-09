Public Class frmTrainningProgrammeTrainees
    Public pTrainTopicID As Integer
    Public pTrainTopicName As String

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Private Sub TblTrainningTopicTraineesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblTrainningTopicTraineesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTrainningTopicTraineesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmTrainningProgrammeTrainees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwStaff' table. You can move, or remove it, as needed.
        Me.VwStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwStaff)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblTrainningTopicTrainees' table. You can move, or remove it, as needed.
        Me.TblTrainningTopicTraineesTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblTrainningTopicTrainees)

        dgv = Me.TblTrainningTopicTraineesDataGridView
        dbn = Me.TblTrainningTopicTraineesBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Συμμετέχοντες σε Προγράμματα Εκπαίδευσης"
        Label1.Text = Me.pTrainTopicName

        DesignColumn(dgv, "trainTopicTraineeID", False)
        DesignColumn(dgv, "trainTopicID", False)
        DesignColumn(dgv, "traineeID", "Εκπαιδευόμενος", 220)
    End Sub

    Private Sub TblTrainningTopicTraineesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTrainningTopicTraineesDataGridView.CellContentClick

    End Sub

    Private Sub TblTrainningTopicTraineesDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTrainningTopicTraineesDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("trainTopicID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("trainTopicID").Value = Me.pTrainTopicID
        End If
    End Sub
End Class
