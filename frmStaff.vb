Public Class frmStaff

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator
    Dim currentrow As Integer

    Private Sub TblStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblStaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblStaff' table. You can move, or remove it, as needed.
        Me.TblStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblStaff)

        dgv = Me.TblStaffDataGridView
        dbn = Me.TblStaffBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        Me.Text = "Προσωπικό"

        DesignColumn(dgv, "staffId", False)

        DesignColumn(dgv, "staffName", "Όνομα", 150, Color.LightYellow)
        DesignColumn(dgv, "staffSurname", "Επώνυμο", 150, Color.LightYellow)
        dgv.Columns(getColIndex(dgv, "staffName")).Frozen = True
        dgv.Columns(getColIndex(dgv, "staffSurname")).Frozen = True

        DesignColumn(dgv, "staffWorkingFrom", "Εργάζεται από", 130, Color.LightYellow)
        dgv.Columns("staffWorkingFrom").ReadOnly = True

        DesignColumn(dgv, "empResume", "Βιογραφικό", 70)
        DesignColumn(dgv, "empEvaluations", "Αξιολογήσεις", 70)
        DesignColumn(dgv, "empTrainning", "Εκπαίδευση", 70)
        DesignColumn(dgv, "education", "Σπουδές", 70)



        DesignColumn(dgv, "staffAddress", "Διεύθυνση", 150)
        DesignColumn(dgv, "staffBankAccount", "Τρ. Λογ/σμός", 150)
        DesignColumn(dgv, "staffComments", "Παρατηρήσεις", 150)
        DesignColumn(dgv, "staffTelephone", "Τηλέφωνο", 106)
        DesignColumn(dgv, "staffFax", "Φαξ", 100)
        DesignColumn(dgv, "staffMail", "Ηλ. Ταχυδρομείο", 180)
        DesignColumn(dgv, "staffFathername", "Ον.Πατρός", 110)
        DesignColumn(dgv, "staffMothername", "Ον.Μητρός", 110)
        DesignColumn(dgv, "staffBirthdate", "Ημ.Γέννησης", 120)
        DesignColumn(dgv, "staffBirthPlace", "Τόπος Γέννησης", 150)
        DesignColumn(dgv, "staffAMA", "Αρ.Μητρ.ΙΚΑ", 100)
        DesignColumn(dgv, "staffADT", "Α.Δ.Τ.", 100)
        DesignColumn(dgv, "staffDOY", "ΔΟΥ", 100)
        DesignColumn(dgv, "staffAFM", "Α.Φ.Μ.", 100)
        DesignColumn(dgv, "staffAMKA", "ΑΜΚΑ", 100)
        DesignColumn(dgv, "staffCity", "Πόλη", 100)
        DesignColumn(dgv, "staffTK", "Ταχ.Κώδικας", 100)

        DesignColumn(dgv, "staffExperience", "Προϋπηρεσία", 150)
        DesignColumn(dgv, "staffKnowledge", "Γνώσεις", 150)
        DesignColumn(dgv, "staffSpecialAbilities", "Ειδικές Δεξιότητες", 150)
        DesignColumn(dgv, "staffLectures", "Σεμινάρια", 130)
        DesignColumn(dgv, "staffMilitary", "Στρ.Υποχρεώσεις", 130)

        Me.MonthCalendar1.Visible = False

    End Sub

    Private Sub TblStaffDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblStaffDataGridView.CellClick
        If e.RowIndex > -1 Then
            currentrow = e.RowIndex
            If dgv.Rows(e.RowIndex).Cells("staffWorkingFrom").ColumnIndex = e.ColumnIndex Then
                If Me.MonthCalendar1.Visible = False Then
                    Me.MonthCalendar1.Visible = True
                    Me.MonthCalendar1.Location = New Point(MousePosition.X - Me.Location.X, MousePosition.Y - Me.Location.Y)

                    If dgv.Rows(e.RowIndex).Cells("staffWorkingFrom").Value IsNot System.DBNull.Value Then
                        Me.MonthCalendar1.SetDate(CDate(dgv.Rows(e.RowIndex).Cells("staffWorkingFrom").Value))
                    Else
                        Me.MonthCalendar1.SetDate(Date.Now)
                    End If
                Else
                    Me.MonthCalendar1.Visible = False
                End If
                'Me.MonthCalendar1.SetDate(CDate(dgv.Rows(e.RowIndex).Cells("columnDate").Value))
            ElseIf dgv.Rows(e.RowIndex).Cells("empEvaluations").ColumnIndex = e.ColumnIndex Then
                Dim oform As New frmEmployeeEvaluations
                oform.pEmpID = CInt(dgv.Rows(currentrow).Cells("staffID").Value)
                oform.pEmpFullName = dgv.Rows(currentrow).Cells("staffName").Value & " " & dgv.Rows(currentrow).Cells("staffSurName").Value
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("empResume").ColumnIndex = e.ColumnIndex Then
                Dim oform As New frmChooseProject
                oform.pEmpID = CInt(dgv.Rows(currentrow).Cells("staffID").Value)                
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("empTrainning").ColumnIndex = e.ColumnIndex Then
                Dim oform As New frmTrainningEmployees
                oform.pEmpID = CInt(dgv.Rows(currentrow).Cells("staffID").Value)
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells("education").ColumnIndex = e.ColumnIndex Then
                Dim oform As New frmEducation
                oform.sID = CInt(dgv.Rows(currentrow).Cells("staffID").Value)
                oform.Show()
            ElseIf dgv.Rows(e.RowIndex).Cells(getColIndex(dgv, "staffExperience")).ColumnIndex = e.ColumnIndex Then
                showMultiTextbox("Προϋπηρεσία", dgv, "staffExperience", e.RowIndex)
            ElseIf dgv.Rows(e.RowIndex).Cells(getColIndex(dgv, "staffKnowledge")).ColumnIndex = e.ColumnIndex Then
                showMultiTextbox("Γνώσεις", dgv, "staffKnowledge", e.RowIndex)
            ElseIf dgv.Rows(e.RowIndex).Cells(getColIndex(dgv, "staffSpecialAbilities")).ColumnIndex = e.ColumnIndex Then
                showMultiTextbox("Ειδικές Δεξιότητες", dgv, "staffSpecialAbilities", e.RowIndex)
            ElseIf dgv.Rows(e.RowIndex).Cells(getColIndex(dgv, "staffLectures")).ColumnIndex = e.ColumnIndex Then
                showMultiTextbox("Σεμινάρια", dgv, "staffLectures", e.RowIndex)
            End If
        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        dgv.Rows(currentrow).Cells("staffWorkingFrom").Value = Me.MonthCalendar1.SelectionRange.Start
        Me.MonthCalendar1.Visible = False
    End Sub

End Class
