Public Class frmInvoices
    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Private Sub frmInvoicesvb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.rptInvoice' table. You can move, or remove it, as needed.
        Me.RptInvoiceTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.rptInvoice)

        dgv = Me.RptInvoiceDataGridView
        dbn = Me.RptInvoiceBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Παραστατικά"

        DesignColumn(dgv, "invoiceId", False)
        DesignColumn(dgv, "invoiceCode", "Κωδικός", 65, Color.LightCyan)
        DesignColumn(dgv, "invoiceDate", "Ημερομηνία", 80, Color.LightCyan)
        dgv.Columns("invoiceDate").DefaultCellStyle.Format = "dd/MM/yyyy"

        DesignColumn(dgv, "invoiceTypeDescription", "Είδος", 180)
        DesignColumn(dgv, "customerCompany", "Αντισυμβαλλόμενος", 220)
        DesignColumn(dgv, "invoiceDescription", "Περιγραφή", 350)
        DesignColumn(dgv, "invoiceComments", "Παρατηρήσεις", 150)
        DesignColumn(dgv, "invoice", "Εκτύπωση Αντιγράφου", 90)

        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub RptInvoiceDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RptInvoiceDataGridView.CellContentClick
        If e.RowIndex > -1 Then
            If dgv.Rows(e.RowIndex).Cells("invoice").ColumnIndex = e.ColumnIndex Then
                If ComboBox1.SelectedIndex = 0 Then
                    Dim oform As New rptInvoice
                    oform.invId = Convert.ToInt32(dgv.Rows(e.RowIndex).Cells("invoiceId").Value)
                    oform.isCopy = True
                    oform.Show()
                Else
                    Dim oform As New frmInvoiceData
                    oform.invId = dgv.Rows(e.RowIndex).Cells("invoiceId").Value
                    oform.Show()
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            dgv.Columns("invoice").HeaderText = "Εκτύπωση Αντιγράφου"
            RptInvoiceBindingSource.Filter = "invoiceCompleted = 1 AND invoiceIssued = 1"
        Else
            dgv.Columns("invoice").HeaderText = "Επεξεργασία Παραστατικού"
            RptInvoiceBindingSource.Filter = "invoiceCompleted = 0 AND invoiceIssued = 1"
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        dgv.Refresh()
        Me.RptInvoiceTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.rptInvoice)
    End Sub
End Class
