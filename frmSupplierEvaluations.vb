Public Class frmSupplierEvaluations
    Public pSupID As Integer
    Public pSupFullName As String

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentRow As Integer
    
    Private Sub TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblQASupplierSatisfactionSurveysBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblQASupplierSatisfactionSurveysBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    

    Private Sub frmSupplierEvaluations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TblQASupplierSatisfactionSurveysTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblQASupplierSatisfactionSurveys, Me.pSupID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcSupplierEvaluationMark' table. You can move, or remove it, as needed.
        Me.VcSupplierEvaluationMarkTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcSupplierEvaluationMark)

        dgv = Me.TblQASupplierSatisfactionSurveysDataGridView
        dbn = Me.TblQASupplierSatisfactionSurveysBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Αξιολόγησεις Προμηθευτή"
        Me.Label1.Text = Me.pSupFullName

        DesignColumn(dgv, "supSatisfSurvID", False)
        DesignColumn(dgv, "supplierID", False)
        DesignColumn(dgv, "supSatisfSurvDate", "Ημ/νία", 120)
        DesignColumn(dgv, "supSatisfSurvType", "Τύπος", 120)
        DesignColumn(dgv, "supSatisfPrevMarkID", "Πρίν", 120)
        DesignColumn(dgv, "supSatisfMarkID", "Μετά", 120)
        DesignColumn(dgv, "supSatisfSurvComments", "Παρατηρήσεις", 225)
        DesignColumn(dgv, "supSatisfSurvReport", "Αναφορά", 75)

    End Sub

    Private Sub TblQASupplierSatisfactionSurveysDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQASupplierSatisfactionSurveysDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentRow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("supSatisfSurvReport").Index Then
                Dim oform As New rptSupplierEvaluationSurveyE746
                oform.pSuppEvalSurvID = CInt(dgv.Rows(currentRow).Cells("supSatisfSurvID").Value)
                oform.Show()
            End If
        End If

    End Sub

    Private Sub TblQASupplierSatisfactionSurveysDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblQASupplierSatisfactionSurveysDataGridView.RowValidated
        If dgv.Rows(e.RowIndex).Cells("supplierID").Value Is System.DBNull.Value Then
            dgv.Rows(e.RowIndex).Cells("supplierID").Value = Me.pSupID
        End If
    End Sub
End Class
