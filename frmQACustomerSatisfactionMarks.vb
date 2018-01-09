Public Class frmQACustomerSatisfactionMarks
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Private Sub TblQACustomerSatisfactionMarksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQACustomerSatisfactionMarksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQACustomerSatisfactionMarksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmQACustomerSatisfactionMarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionMarks' table. You can move, or remove it, as needed.
        Me.TblQACustomerSatisfactionMarksTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionMarks)

        dgv = Me.TblQACustomerSatisfactionMarksDataGridView
        dbn = Me.TblQACustomerSatisfactionMarksBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Βαθμοί Αξιολόγησης"

        DesignColumn(dgv, "cusSatisfMarkID", False)
        DesignColumn(dgv, "cusSatisfMarkValue", "Βαθμός", 75)
        DesignColumn(dgv, "cusSatisfMarkDesc", "Περιγραφή", 300)

    End Sub
End Class
