Public Class frmEducation

    Public sId As Integer = 0

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Private Sub TblEducationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblEducationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblEducationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmEducation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblEducation' table. You can move, or remove it, as needed.
        Me.TblEducationTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblEducation, sId)

        dbn = Me.TblEducationBindingNavigator
        dgv = Me.TblEducationDataGridView

        DesignDataGridNavigator(dbn)
        DesignDataGridView(dgv)

        DesignColumn(dgv, "educationId", False)
        DesignColumn(dgv, "staffId", False)
        DesignColumn(dgv, "educationName", "Όνομα Ιδρύματος", 350)
        DesignColumn(dgv, "educationDegree", "Τίτλος Πτυχίου", 300)
        DesignColumn(dgv, "educationSpecialty", "Ειδικότητα", 250)
        DesignColumn(dgv, "educationDate", "Ημ.Απόκτησης", 100)
        DesignColumn(dgv, "educationComments", "Παρατηρήσεις", 100)

    End Sub


    Private Sub TblEducationDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEducationDataGridView.RowValidated
        If e.RowIndex > -1 Then
            dgv.Rows(e.RowIndex).Cells(getColIndex(dgv, "staffId")).Value = sId
        End If
    End Sub
End Class
