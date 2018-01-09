Public Class frmEmployeeEvaluations

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentRow As Integer
    Public pEmpID As Integer
    Public pEmpFullName As String

    Private Sub TblQAEmployeeEvaluationsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQAEmployeeEvaluationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQAEmployeeEvaluationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmEvaluations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQAEmployeeEvaluations' table. You can move, or remove it, as needed.
        Me.TblQAEmployeeEvaluationsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQAEmployeeEvaluations, pEmpID)

        dgv = Me.TblQAEmployeeEvaluationsDataGridView
        dbn = Me.TblQAEmployeeEvaluationsBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Αξιολόγησεις Εργαζομένου"
        Me.Label1.Text = Me.pEmpFullName

        DesignColumn(dgv, "empEvalID", False)
        DesignColumn(dgv, "staffID", False)
        DesignColumn(dgv, "empEvalDateFrom", "Από ", 120)
        DesignColumn(dgv, "empEvalDateTo", "Έως", 120)
        DesignColumn(dgv, "empEvalDetails", "Λεπτομέρειες", 120)
        DesignColumn(dgv, "empEvalComments", "Παρατηρήσεις", 125)

    End Sub
    Private Sub TblQAEmployeeEvaluationsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQAEmployeeEvaluationsDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentRow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("empEvalDetails").Index Then
                Dim oform As New frmEmployeeEvaluationDetails
                oform.pEvalID = dgv.Rows(currentRow).Cells("empEvalID").Value
                oform.pEmpFullName = Me.pEmpFullName
                oform.Show()
            End If
        End If
    End Sub
    Private Sub TblQAEmployeeEvaluationsDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQAEmployeeEvaluationsDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("staffID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("staffID").Value = Me.pEmpID
        End If
    End Sub
End Class
