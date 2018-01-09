Public Class frmSupplier

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentRow As Integer


    Private Sub TblSupplierBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblSupplierBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwSupplierEval' table. You can move, or remove it, as needed.
        Me.VwSupplierEvalTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwSupplierEval)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwSupplierType' table. You can move, or remove it, as needed.
        Me.VwSupplierTypeTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwSupplierType)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblSupplier' table. You can move, or remove it, as needed.
        Me.TblSupplierTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblSupplier)

        Me.Text = "Προμηθευτές"

        dgv = Me.TblSupplierDataGridView
        dbn = Me.TblSupplierBindingNavigator

        DesignDataGridNavigator(dbn)
        DesignDataGridView(dgv)

        DesignColumn(dgv, "supplierId", False)
        DesignColumn(dgv, "supplierName", "Όνομα", 180, Color.LightYellow)
        DesignColumn(dgv, "supplierSurname", "Επώνυμο", 180, Color.LightYellow)
        DesignColumn(dgv, "supplierCompany", "Εταιρεία", 130)

        DesignColumn(dgv, "supplierEvaluations", "Αξιολογήσεις", 70)


        DesignColumn(dgv, "supplierAddress", "Διεύθυνση", 150)
        DesignColumn(dgv, "supplierTelephone1", "Τηλέφωνο 1", 120)
        DesignColumn(dgv, "supplierTelephone2", "Τηλέφωνο 2", 120)
        DesignColumn(dgv, "supplierAFM", "ΑΦΜ", 100)
        DesignColumn(dgv, "supplierDOY", "ΔΟΥ", 130)
        DesignColumn(dgv, "supplierComments", "Παρατηρήσεις", 150)
        DesignColumn(dgv, "supplierServices", "Υπηρεσίες", 180, Color.LightYellow)
        DesignColumn(dgv, "supplierDateApproval", "Ημ. Έγκρισης", 130)
        DesignColumn(dgv, "supplierTypeId", "Τύπος", 150)
        DesignColumn(dgv, "supplierEvalId", "Κατ.Αξιολόγησης", 100, Color.LightYellow)

    End Sub

    Private Sub TblSupplierDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblSupplierDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentRow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("supplierEvaluations").Index Then
                Dim oform As New frmSupplierEvaluations
                oform.pSupID = CInt(dgv.Rows(currentRow).Cells("supplierId").Value)
                oform.pSupFullName = dgv.Rows(currentRow).Cells("supplierName").Value & " " & dgv.Rows(currentRow).Cells("supplierSurname").Value & " " & dgv.Rows(currentRow).Cells("supplierCompany").Value
                oform.Show()
            End If
        End If
    End Sub
End Class
