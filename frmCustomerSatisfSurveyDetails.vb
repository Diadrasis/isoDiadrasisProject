Public Class frmCustomerSatisfSurveyDetails
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentRow
    Public pCustSatSurvID As Integer
    Public pCustFullName As String
    Private Sub TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQACustomerSatisfactionSurveyDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQACustomerSatisfactionSurveyDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub
    Private Sub frmCustomerSatisfSurveyDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionMarks' table. You can move, or remove it, as needed.
        Me.TblQACustomerSatisfactionMarksTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionMarks)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcCustomSatCrit' table. You can move, or remove it, as needed.
        Me.VcCustomSatCritTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcCustomSatCrit)

        Me.TblQACustomerSatisfactionSurveyDetailsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionSurveyDetails, pCustSatSurvID)

        dgv = Me.TblQACustomerSatisfactionSurveyDetailsDataGridView
        dbn = Me.TblQACustomerSatisfactionSurveyDetailsBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Αξιολόγηση Εργαζομένου"
        Me.Label1.Text = Me.pCustFullName

        DesignColumn(dgv, "cusSatisfSurvDetID", False)
        DesignColumn(dgv, "cusSatisfSurvID", False)
        DesignColumn(dgv, "cusSatisfCritID", "Κριτήριο", 220)
        DesignColumn(dgv, "cusSatisfMarkID", "Βαθμός", 220)
        DesignColumn(dgv, "cusSatisfDetComments", "Παρατηρήσεις", 125)
    End Sub
    Private Sub TblQACustomerSatisfactionSurveyDetailsDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQACustomerSatisfactionSurveyDetailsDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("cusSatisfSurvID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("cusSatisfSurvID").Value = pCustSatSurvID
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim oform As New rptCustomerSatisfactionE841
        oform.pCustSatSurvID = Me.pCustSatSurvID
        oform.Show()
    End Sub
End Class
