Public Class frmQAEmployeeEvaluationMarks
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Private Sub TblQAEmployeeEvaluationMarksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQAEmployeeEvaluationMarksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQAEmployeeEvaluationMarksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmQAEmployeeEvaluationMarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQAEmployeeEvaluationMarks' table. You can move, or remove it, as needed.
        Me.TblQAEmployeeEvaluationMarksTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQAEmployeeEvaluationMarks)

        dgv = Me.TblQAEmployeeEvaluationMarksDataGridView
        dbn = Me.TblQAEmployeeEvaluationMarksBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Βαθμοί Αξιολόγησης"

        DesignColumn(dgv, "empEvalMarkID", False)
        DesignColumn(dgv, "empEvalMarkValue", "Βαθμός", 75)
        DesignColumn(dgv, "empEvalMarkDesc", "Περιγραφή", 300)
    End Sub
End Class
