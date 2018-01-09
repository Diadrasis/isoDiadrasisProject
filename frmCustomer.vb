Public Class frmCustomer

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentRow As Integer

    Private Sub TblCustomerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblCustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.FillByType(Me.DiadrasisProjectsDBDataSet.tblCustomer, True)

        dgv = Me.TblCustomerDataGridView
        dbn = Me.TblCustomerBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Πελάτες"

        DesignColumn(dgv, "customerId", False)
        DesignColumn(dgv, "customerSurname", "Υπεύθυνος", 200, Color.LightYellow)
        DesignColumn(dgv, "customerCompany", "Εταιρεία", 200, Color.LightYellow)
        DesignColumn(dgv, "customerSatisfSurveys", "Ικανοποίηση", 75, Color.LightYellow)

        DesignColumn(dgv, "customerAFM", "ΑΦΜ", 100)
        DesignColumn(dgv, "customerDOY", "ΔΟΥ", 100)
        DesignColumn(dgv, "customerAddress", "Διεύθυνση", 150)
        DesignColumn(dgv, "customerProfession", "Επάγγελμα", 150)
        DesignColumn(dgv, "customerTitle", "Διακριτικός Τίτλος", 150)
        DesignColumn(dgv, "customerZIP", "Ταχ. Κώδικας", 80)
        DesignColumn(dgv, "customerCity", "Πόλη", 110)
        DesignColumn(dgv, "customerComments", "Παρατηρήσεις", 120)
        DesignColumn(dgv, "customerTelephone1", "Τηλέφωνο(1)", 106)
        DesignColumn(dgv, "customerTelephone2", "Τηλέφωνο(2)", 106)

        Me.ComboBox1.Location = New Point(dbn.Location.X + 300, dbn.Location.Y)

        Me.ComboBox1.Items.Add("Πελάτες")
        Me.ComboBox1.Items.Add("Πελάτες Τρίτων")

        Me.ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub TblCustomerDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblCustomerDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            currentRow = e.RowIndex
            If e.ColumnIndex = dgv.Columns("customerSatisfSurveys").Index Then
                Dim oform As New frmCustomerSatisfactionSurveys
                oform.pCustID = dgv.Rows(currentRow).Cells("customerID").Value
                oform.pCustName = dgv.Rows(currentRow).Cells("customerCompany").Value
                oform.Show()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        If Me.ComboBox1.SelectedIndex = 0 Then
            Me.TblCustomerTableAdapter.FillByType(Me.DiadrasisProjectsDBDataSet.tblCustomer, True)
        Else
            Me.TblCustomerTableAdapter.FillByType(Me.DiadrasisProjectsDBDataSet.tblCustomer, False)
        End If
    End Sub

    Private Sub TblCustomerDataGridView_RowValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblCustomerDataGridView.RowValidated
        If e.RowIndex > -1 Then
            If Me.ComboBox1.SelectedIndex = 0 Then
                dgv.Rows(e.RowIndex).Cells("isDiadrasis").Value = True
            Else
                dgv.Rows(e.RowIndex).Cells("isDiadrasis").Value = False
            End If
        End If
    End Sub
End Class
