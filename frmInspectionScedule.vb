Public Class frmInspectionScedule
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer
    Private Sub TblInspectionScedulesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblInspectionScedulesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblInspectionScedulesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmInspectionScedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblInspectionScedules' table. You can move, or remove it, as needed.
        Me.TblInspectionScedulesTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblInspectionScedules)

        dgv = Me.TblInspectionScedulesDataGridView
        dbn = Me.TblInspectionScedulesBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Ετήσια Προγράμμα Επιθεωρήσεων"

        DesignColumn(dgv, "inspSceduleID", False)
        DesignColumn(dgv, "inspSceduleYear", "Έτος", 120)
        DesignColumn(dgv, "inspInspections", "Θέματα", 120)
        DesignColumn(dgv, "inspSceduleReport", "Αναφορά", 120)
        DesignColumn(dgv, "inspSceduleComments", "Σχόλια", 220)

    End Sub

    Private Sub TblInspectionScedulesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblInspectionScedulesDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentrow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("inspInspections").Index Then
                Dim oform As New frmInspections
                oform.pInspSceduleID = dgv.Rows(currentrow).Cells("inspSceduleID").Value
                oform.pInspSceduleYear = dgv.Rows(currentrow).Cells("inspSceduleYear").Value
                oform.Show()
            ElseIf e.ColumnIndex = dgv.Columns("inspSceduleReport").Index Then
                Dim oform As New rptInspectionSceduleE821
                oform.pInspSceduleID = dgv.Rows(currentrow).Cells("inspSceduleID").Value
                oform.Show()
            End If
        End If
    End Sub
End Class
