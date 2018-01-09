Public Class frmQASupplierSatisfactionMarks
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Private Sub TblQASupplierSatisfactionMarksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQASupplierSatisfactionMarksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQASupplierSatisfactionMarksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmQASupplierSatisfactionMarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQASupplierSatisfactionMarks' table. You can move, or remove it, as needed.
        Me.TblQASupplierSatisfactionMarksTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQASupplierSatisfactionMarks)


        dgv = Me.TblQASupplierSatisfactionMarksDataGridView
        dbn = Me.TblQASupplierSatisfactionMarksBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Βαθμοί Αξιολόγησης"

        DesignColumn(dgv, "supSatisfMarkID", False)
        DesignColumn(dgv, "supSatisfMarkValue", "Βαθμός", 75)
        DesignColumn(dgv, "supSatisfMarkDesc", "Περιγραφή", 300)

    End Sub
End Class
