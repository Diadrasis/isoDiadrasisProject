Public Class frmQAEmployeeEvaluationCritera
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Private Sub TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQAEmployeeEvaluationCriteriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQAEmployeeEvaluationCriteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmQAEmlployeeEvaluationCritera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQAEmployeeEvaluationCriteria' table. You can move, or remove it, as needed.
        Me.TblQAEmployeeEvaluationCriteriaTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQAEmployeeEvaluationCriteria)

        dgv = Me.TblQAEmployeeEvaluationCriteriaDataGridView
        dbn = Me.TblQAEmployeeEvaluationCriteriaBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Κριτήρια Αξιολόγησης"

        DesignColumn(dgv, "empEvalCritID", False)
        DesignColumn(dgv, "empEvalCritTitle", "Τίτλος", 220)
        DesignColumn(dgv, "empEvalCritDesc", "Περιγραφή", 300)
        DesignColumn(dgv, "empEvalCritCurrent", "Σε Ισχύ", 120)
        DesignColumn(dgv, "empEvalCritComm", "Σχόλια", 250)


    End Sub
End Class
