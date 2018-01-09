Public Class frmTrainningEmployees
    Public pEmpID As Integer
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer
    Private Sub TblTrainningEmployeesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblTrainningEmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTrainningEmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmTainningEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblTrainningEmployees' table. You can move, or remove it, as needed.
        Me.TblTrainningEmployeesTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblTrainningEmployees, pEmpID)

        dgv = Me.TblTrainningEmployeesDataGridView
        dbn = Me.TblTrainningEmployeesBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Αναφορά Εκπαίδευσης"

        DesignColumn(dgv, "trainEmpID", False)
        DesignColumn(dgv, "employeeID", False)
        DesignColumn(dgv, "trainEmpTopic", "Θέμα", 120)
        DesignColumn(dgv, "trainEmpDate", "Ημ/νία", 120)
        DesignColumn(dgv, "trainEmpDuration", "Διάρκεια", 120)
        DesignColumn(dgv, "trainEmpComments", "Σχόλια", 220)
    End Sub

    Private Sub TblTrainningEmployeesDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTrainningEmployeesDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("employeeID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("employeeID").Value = Me.pEmpID
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oform As New rptEmployeeTrainningE625
        oform.pEmpID = Me.pEmpID
        oform.Show()
    End Sub
End Class
