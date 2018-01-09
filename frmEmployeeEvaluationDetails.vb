Public Class frmEmployeeEvaluationDetails
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentRow
    Public pEvalID As Integer
    Public pEmpFullName As String

    Private Sub TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQAEmployeeEvaluationDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQAEmployeeEvaluationDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmEmployeeEvaluationDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcEmpEvalMark' table. You can move, or remove it, as needed.
        Me.VcEmpEvalMarkTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcEmpEvalMark)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcEmpEvalCrit' table. You can move, or remove it, as needed.
        Me.VcEmpEvalCritTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcEmpEvalCrit)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQAEmployeeEvaluationDetails' table. You can move, or remove it, as needed.
        Me.TblQAEmployeeEvaluationDetailsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQAEmployeeEvaluationDetails, pEvalID)

        dgv = Me.TblQAEmployeeEvaluationDetailsDataGridView
        dbn = Me.TblQAEmployeeEvaluationDetailsBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Αξιολόγηση Εργαζομένου"
        Me.Label1.Text = Me.pEmpFullName

        DesignColumn(dgv, "empEvalDetID", False)
        DesignColumn(dgv, "empEvalID", False)
        DesignColumn(dgv, "empEvalCritID", "Κριτήριο", 220)
        DesignColumn(dgv, "empEvalMarkID", "Βαθμός", 220)
        DesignColumn(dgv, "empEvalDetComments", "Παρατηρήσεις", 125)

    End Sub

    Private Sub TblQAEmployeeEvaluationDetailsDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQAEmployeeEvaluationDetailsDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("empEvalID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("empEvalID").Value = pEvalID
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim oform As New rptEmployeeEvaluationE623
        oform.pEvalID = Me.pEvalID
        oform.Show()
    End Sub
End Class
