Public Class frmInvoicePayment
    Public invId As Integer
    Public invForm As frmInvoices
    Private Sub TblInvoicesByIDPaymentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblInvoicesByIDPaymentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblInvoicesByIDPaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

        invForm.RefreshDataGrid()

    End Sub

    Private Sub frmInvoicePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblInvoiceResponsibles' table. You can move, or remove it, as needed.
        Me.TblInvoiceResponsiblesTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblInvoiceResponsibles)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblInvoices' table. You can move, or remove it, as needed.
        'Me.TblInvoicesTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblInvoices)

        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblProject' table. You can move, or remove it, as needed.
        Me.TblProjectTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblProject)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblInvoiceTypes' table. You can move, or remove it, as needed.
        Me.TblInvoiceTypesTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblInvoiceTypes)
        Try
            Me.TblInvoicesByIDPaymentTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblInvoicesByIDPayment, invId)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        If InvoicePaidCheckBox.Checked = False Then
            Me.PayDateDateTimePicker.Enabled = False
            Me.PayDateDateTimePicker.CustomFormat = " "
            Me.PayDateDateTimePicker.Format = DateTimePickerFormat.Custom

        End If

    End Sub

    Private Sub InvoicePaidCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles InvoicePaidCheckBox.CheckedChanged
        If Me.InvoicePaidCheckBox.Checked = False Then
            Me.PayDateDateTimePicker.Enabled = False
            Me.PayDateDateTimePicker.CustomFormat = " "
            Me.PayDateDateTimePicker.Format = DateTimePickerFormat.Custom
            Me.PayDateDateTimePicker.ResetText()
        Else
            Me.PayDateDateTimePicker.Enabled = True
            Me.PayDateDateTimePicker.Format = DateTimePickerFormat.Long
        End If
    End Sub

    Private Sub PayDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles PayDateDateTimePicker.ValueChanged

    End Sub

    Private Sub InvresIDLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class