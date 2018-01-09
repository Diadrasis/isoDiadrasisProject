Public Class frmQACustomerSatisfactionCriteria
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Private Sub TblQACustomerSatisfactionCriteriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQACustomerSatisfactionCriteriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQACustomerSatisfactionCriteriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmQACustomerSatisfactionCriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionCriteria' table. You can move, or remove it, as needed.
        Me.TblQACustomerSatisfactionCriteriaTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionCriteria)

        dgv = Me.TblQACustomerSatisfactionCriteriaDataGridView
        dbn = Me.TblQACustomerSatisfactionCriteriaBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Κριτήρια Ικανοποίησης Πελάτη"

        DesignColumn(dgv, "cusSatisfCritID", False)
        DesignColumn(dgv, "cusSatisfCritTitle", "Τίτλος", 220)
        DesignColumn(dgv, "cusSatisfCritDesc", "Περιγραφή", 300)
        DesignColumn(dgv, "cusSatisfCritCurrent", "Σε Ισχύ", 120)
        DesignColumn(dgv, "cusSatisfCritComm", "Σχόλια", 250)
    End Sub
End Class
