Public Class frmTrainningTopics
    Public pTrainProgID As Integer
    Public pTrainProgYear As Integer

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer
    Private Sub TblTrainningTopicBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblTrainningTopicBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTrainningTopicBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmTrainningTopics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwStaff' table. You can move, or remove it, as needed.
        Me.VwStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwStaff)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblMonths' table. You can move, or remove it, as needed.
        Me.TblMonthsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblMonths)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblTrainningTopic' table. You can move, or remove it, as needed.
        Me.TblTrainningTopicTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblTrainningTopic)

        dgv = Me.TblTrainningTopicDataGridView
        dbn = Me.TblTrainningTopicBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Θέματα Ετήσια Προγράμματα Εκπαίδευσης"
        Me.Label1.Text = Me.pTrainProgYear

        DesignColumn(dgv, "trainTopicID", False)
        DesignColumn(dgv, "trainProgID", False)
        DesignColumn(dgv, "monthID", "Μήνας", 120)
        DesignColumn(dgv, "trainTopicName", "Θέμα", 220)
        DesignColumn(dgv, "trainerID", "Εκπαιδευτής", 220)
        DesignColumn(dgv, "trainTrainees", "Εκπαιδευόμενοι", 120)
        DesignColumn(dgv, "trainTopicComments", "Σχόλια", 220)

    End Sub

    Private Sub TblTrainningTopicDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTrainningTopicDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentrow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("trainTrainees").Index Then
                Dim oform As New frmTrainningProgrammeTrainees
                oform.pTrainTopicID = CInt(dgv.Rows(currentrow).Cells("trainTopicID").Value)
                oform.pTrainTopicName = dgv.Rows(currentrow).Cells("trainTopicName").Value
                oform.Show()
            End If
        End If
    End Sub

    Private Sub TblTrainningTopicDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTrainningTopicDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("trainProgID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("trainProgID").Value = Me.pTrainProgID
        End If
    End Sub
End Class
