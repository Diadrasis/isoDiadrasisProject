Public Class frmInspectionReports
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer
    Private Sub TblInspectionsReportBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblInspectionsReportBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblInspectionsReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmInspectionReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwStaff' table. You can move, or remove it, as needed.
        Me.VwStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwStaff)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcDepartment' table. You can move, or remove it, as needed.
        Me.VcDepartmentTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcDepartment)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblInspectionsReport' table. You can move, or remove it, as needed.
        Me.TblInspectionsReportTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblInspectionsReport)

        dgv = Me.TblInspectionsReportDataGridView
        dbn = Me.TblInspectionsReportBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Έκθεση Επιθεώρησης"

        DesignColumn(dgv, "inspRepID", False)
        DesignColumn(dgv, "inspRepDate", "Μήνας", 120)
        DesignColumn(dgv, "deptID", "Τμήμα", 220)
        DesignColumn(dgv, "inspectorID", "Επιθεωρητής", 220)
        DesignColumn(dgv, "inspectedID", "Εκπρόσωπος", 120)
        DesignColumn(dgv, "inspTopics", "Θέματα", 120)
        DesignColumn(dgv, "inspTarget", "Στόχοι", 120)
        DesignColumn(dgv, "inspResults", "Αποτελέσματα", 120)
        DesignColumn(dgv, "inspRepReport", "Αναφορά", 120)
        DesignColumn(dgv, "inspComments", "Σχόλια", 220)


    End Sub

    Private Sub TblInspectionsReportDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblInspectionsReportDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentrow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("inspRepReport").Index Then
                Dim oform As New rptInspectionReportE822
                oform.pInspRepID = dgv.Rows(currentrow).Cells("inspRepID").Value
                oform.Show()
            End If
        End If
    End Sub
End Class
