Public Class frmQASupplierSatisfactionCriteria
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Private Sub TblQASupplierSatisfactionCriteriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQASupplierSatisfactionCriteriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQASupplierSatisfactionCriteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmQASupplierSatisfactionCriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQASupplierSatisfactionCriteria' table. You can move, or remove it, as needed.
        Me.TblQASupplierSatisfactionCriteriaTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQASupplierSatisfactionCriteria)

        dgv = Me.TblQASupplierSatisfactionCriteriaDataGridView
        dbn = Me.TblQASupplierSatisfactionCriteriaBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Κριτήρια Ικανοποίησης Προμηθευτή"

        DesignColumn(dgv, "supSatisfCritID", False)
        DesignColumn(dgv, "supSatisfCritTitle", "Τίτλος", 220)
        DesignColumn(dgv, "supSatisfCritDesc", "Περιγραφή", 300)
        DesignColumn(dgv, "supSatisfCritCurrent", "Σε Ισχύ", 120)
        DesignColumn(dgv, "supSatisfCritComm", "Σχόλια", 250)

    End Sub
End Class
