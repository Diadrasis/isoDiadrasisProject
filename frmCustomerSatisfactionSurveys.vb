Public Class frmCustomerSatisfactionSurveys
    Public pCustID As Integer
    Public pCustName As String
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentRow As Integer
    Private Sub TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQACustomerSatisfactionSurveysBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQACustomerSatisfactionSurveysBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmCustomerSatisfactionSurveys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionSurveys' table. You can move, or remove it, as needed.
        Me.TblQACustomerSatisfactionSurveysTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQACustomerSatisfactionSurveys, pCustID)

        dgv = Me.TblQACustomerSatisfactionSurveysDataGridView
        dbn = Me.TblQACustomerSatisfactionSurveysBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)
        Me.Text = "Μετρήσεις Ικανοποίησης Πελάτη"
        Me.Label1.Text = Me.pCustName

        DesignColumn(dgv, "cusSatisfSurvID", False)
        DesignColumn(dgv, "customerID", False)
        DesignColumn(dgv, "cusSatisfSurvDateFrom", "Από ", 120)
        DesignColumn(dgv, "cusSatisfSurvDateTo", "Έως", 120)
        DesignColumn(dgv, "custSatisfDetails", "Λεπτομέρειες", 120)
        DesignColumn(dgv, "cusSatisfSurvComments", "Παρατηρήσεις", 125)
    End Sub
    Private Sub TblQACustomerSatisfactionSurveysDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQACustomerSatisfactionSurveysDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentRow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("custSatisfDetails").Index Then
                Dim oform As New frmCustomerSatisfSurveyDetails
                oform.pCustSatSurvID = dgv.Rows(currentRow).Cells("cusSatisfSurvID").Value
                oform.pCustFullName = Me.pCustName
                oform.Show()
            End If
        End If
    End Sub
    Private Sub TblQACustomerSatisfactionSurveysDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQACustomerSatisfactionSurveysDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("customerID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("customerID").Value = Me.pCustID
        End If
    End Sub

   
End Class
