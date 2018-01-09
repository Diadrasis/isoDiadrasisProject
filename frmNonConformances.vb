Public Class frmNonConformances
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer
    Private Sub TblNonConformances_BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblNonConformances_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblNonConformances_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmNonConformances_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwStaff' table. You can move, or remove it, as needed.
        Me.VwStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwStaff)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcNonConformanceType' table. You can move, or remove it, as needed.
        Me.VcNonConformanceTypeTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcNonConformanceType)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblNonConformances_' table. You can move, or remove it, as needed.
        Me.TblNonConformances_TableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblNonConformances_)

        dgv = Me.TblNonConformances_DataGridView
        dbn = Me.TblNonConformances_BindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Έκθεση Μη Συμμόρφωσης"

        DesignColumn(dgv, "nonConfID", False)
        DesignColumn(dgv, "nonConfDate", "Ημ/νία", 120)
        DesignColumn(dgv, "nonConfTypeID", "Τύπος", 220)
        DesignColumn(dgv, "nonConfDescription", "Στόχοι", 120)
        DesignColumn(dgv, "nonConfActions", "Αποτελέσματα", 120)
        DesignColumn(dgv, "inspectorID", "Επιθεωρητής", 220)
        DesignColumn(dgv, "inspectedID", "Εκπρόσωπος", 120)
        DesignColumn(dgv, "nonConfPreventActions", "Θέματα", 120)
        DesignColumn(dgv, "nonConfReport", "Αναφορά", 120)
        DesignColumn(dgv, "nonConfMesures", "Στόχοι", 120)
        DesignColumn(dgv, "nonConfPreventing", "Αποτελέσματα", 120)
        DesignColumn(dgv, "nonConfChecked", "Αποτελέσματα", 120)
    End Sub

    Private Sub TblNonConformances_DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblNonConformances_DataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentrow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("nonConfReport").Index Then
                Dim oform As New rptNonConformanceE831
                oform.pNonConfID = dgv.Rows(currentrow).Cells("nonConfID").Value
                oform.Show()
            End If
        End If
    End Sub
End Class
