Public Class frmInspections
    Public pInspSceduleID As Integer
    Public pInspSceduleYear As Integer

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer

    Private Sub TblInspectionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblInspectionsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblInspectionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmInspections_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwStaff' table. You can move, or remove it, as needed.
        Me.VwStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwStaff)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcDepartment' table. You can move, or remove it, as needed.
        Me.VcDepartmentTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcDepartment)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblMonths' table. You can move, or remove it, as needed.
        Me.TblMonthsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblMonths)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblInspections' table. You can move, or remove it, as needed.
        Me.TblInspectionsTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblInspections, pInspSceduleID)

        dgv = Me.TblInspectionsDataGridView
        dbn = Me.TblInspectionsBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Θέματα Ετήσια Προγράμματα Εκπαίδευσης"
        Me.Label1.Text = Me.pInspSceduleYear

        DesignColumn(dgv, "inspID", False)
        DesignColumn(dgv, "inspSceduleID", False)
        DesignColumn(dgv, "monthID", "Μήνας", 120)
        DesignColumn(dgv, "deptID", "Τμήμα", 220)
        DesignColumn(dgv, "inspectorID", "Επιθεωρητής", 220)
        DesignColumn(dgv, "inspectedID", "Εκπρόσωπος", 120)
        DesignColumn(dgv, "inspTopics", "Θέματα", 120)

        DesignColumn(dgv, "inspComments", "Σχόλια", 220)

    End Sub
End Class
