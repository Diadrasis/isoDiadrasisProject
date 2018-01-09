Public Class frmTrainningProgrammes
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer
    Private Sub TblTrainningProgrammesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblTrainningProgrammesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTrainningProgrammesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmTrainningProgrammes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblTrainningProgrammes' table. You can move, or remove it, as needed.
        Me.TblTrainningProgrammesTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblTrainningProgrammes)

        dgv = Me.TblTrainningProgrammesDataGridView
        dbn = Me.TblTrainningProgrammesBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Ετήσια Προγράμματα Εκπαίδευσης"

        DesignColumn(dgv, "trainProgID", False)
        DesignColumn(dgv, "trainProgYear", "Έτος", 120)
        DesignColumn(dgv, "trainProgTopics", "Θέματα", 120)
        DesignColumn(dgv, "trainProgReport", "Αναφορά", 120)
        DesignColumn(dgv, "trainProgComments", "Σχόλια", 220)
    End Sub

    Private Sub TblTrainningProgrammesDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTrainningProgrammesDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentrow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("trainProgTopics").Index Then
                Dim oform As New frmTrainningTopics
                oform.pTrainProgID = dgv.Rows(currentrow).Cells("trainProgID").Value
                oform.pTrainProgYear = dgv.Rows(currentrow).Cells("trainProgYear").Value
                oform.Show()
            ElseIf e.ColumnIndex = dgv.Columns("trainProgReport").Index Then
                Dim oform As New rptTrainningProgrammeE624
                oform.pTrainProgID = dgv.Rows(currentrow).Cells("trainProgID").Value
                oform.Show()
            End If
        End If
    End Sub
End Class
