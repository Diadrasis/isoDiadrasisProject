Public Class frmTask

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Dim currentrow As Integer

    Public pId As Integer

    Private Sub TblTaskBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblTaskBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTaskBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcProjectPhase' table. You can move, or remove it, as needed.
        Me.VcProjectPhaseTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcProjectPhase)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vcTaskReason' table. You can move, or remove it, as needed.
        Me.VcTaskReasonTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vcTaskReason)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwStaff' table. You can move, or remove it, as needed.
        Me.VwStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwStaff)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblTask' table. You can move, or remove it, as needed.
        Me.TblTaskTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblTask, pId)

        dgv = Me.TblTaskDataGridView
        dbn = Me.TblTaskBindingNavigator

        DesignDataGridView(dgv)
        DesignDataGridNavigator(dbn)

        GroupBox1.Location = New Point(lrMargin + dbn.Width + 20, dgv.Location.Y - GroupBox1.Height)
        Button4.Location = New Point(GroupBox1.Location.X + GroupBox1.Width + 5, dgv.Location.Y - Button4.Height)

        DateTimePicker1.Value = DateTimePicker1.Value.AddDays(-Date.Now.Day + 1)
        DateTimePicker2.Value = DateTimePicker2.Value.AddMonths(1).AddDays(-Date.Now.Day)

        Me.Text = "Εργασίες"

        DesignColumn(dgv, "taskId", False)
        DesignColumn(dgv, "taskName", "Ονομασία", 200)
        DesignColumn(dgv, "taskReasonID", "Προέλευση", 200)
        DesignColumn(dgv, "projectPhaseID", "Φάση", 200)
        DesignColumn(dgv, "taskCompleted", "Ολοκλήρωση", 200)
        DesignColumn(dgv, "taskDescription", "Περιγραφή", 200)
        DesignColumn(dgv, "staffId", "Εργαζόμενος", 200)
        DesignColumn(dgv, "projectId", False)
        DesignColumn(dgv, "taskHours", "Ώρες Απασχόλησης", 150)
        DesignColumn(dgv, "taskComments", "Παρατηρησείς", 106)

        DesignColumn(dgv, "taskDate", "Ημερομηνία", 106)
        dgv.Columns("taskDate").ReadOnly = True

        Me.MonthCalendar1.Visible = False

    End Sub

    Private Sub TblTaskDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTaskDataGridView.CellClick
        If e.RowIndex > -1 Then
            If dgv.Rows(e.RowIndex).Cells("taskDate").ColumnIndex = e.ColumnIndex Then
                currentrow = e.RowIndex
                If Me.MonthCalendar1.Visible = False Then
                    Me.MonthCalendar1.Visible = True
                    Me.MonthCalendar1.Location = New Point(MousePosition.X - Me.Location.X, MousePosition.Y - Me.Location.Y)

                    If dgv.Rows(e.RowIndex).Cells("taskDate").Value IsNot System.DBNull.Value Then
                        Me.MonthCalendar1.SetDate(CDate(dgv.Rows(e.RowIndex).Cells("taskDate").Value))
                    Else
                        Me.MonthCalendar1.SetDate(Date.Now)
                    End If
                Else
                    Me.MonthCalendar1.Visible = False
                End If
                'Me.MonthCalendar1.SetDate(CDate(dgv.Rows(e.RowIndex).Cells("columnDate").Value))
            End If
        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        dgv.Rows(currentrow).Cells("taskDate").Value = Me.MonthCalendar1.SelectionRange.Start
        Me.MonthCalendar1.Visible = False
    End Sub

    Private Sub TblTaskDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblTaskDataGridView.RowValidated
        dgv.Rows(e.RowIndex).Cells("projectId").Value = pId
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim oform As New rptProjectTasksE752
        oform.pProjID = Me.pId
        oform.pDateStart = DateTimePicker1.Value
        oform.pDateEnd = DateTimePicker2.Value
        oform.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TblTaskBindingSource.Filter = "taskDate >= '" & DateTimePicker1.Value.AddDays(-1).ToString() & "' AND taskDate <= '" & DateTimePicker2.Value.AddDays(1).ToString() & "'"
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        TblTaskBindingSource.Filter = "taskDate >= '" & DateTimePicker1.Value.AddDays(-1).ToString() & "' AND taskDate <= '" & DateTimePicker2.Value.AddDays(1).ToString() & "'"
    End Sub
End Class
