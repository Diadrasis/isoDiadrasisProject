Public Class frmProjectStaff

    Public pId As Integer

    Dim dgv As DataGridView
    Dim dbn As BindingNavigator

    Private Sub TblProjectStaffBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblProjectStaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblProjectStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DiadrasisProjectsDBDataSet)

    End Sub

    Private Sub frmProjectStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.vwStaff' table. You can move, or remove it, as needed.
        Me.VwStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.vwStaff)
        'TODO: This line of code loads data into the 'DiadrasisProjectsDBDataSet.tblProjectStaff' table. You can move, or remove it, as needed.
        Me.TblProjectStaffTableAdapter.Fill(Me.DiadrasisProjectsDBDataSet.tblProjectStaff, pId)

        dgv = Me.TblProjectStaffDataGridView
        dbn = Me.TblProjectStaffBindingNavigator

        DesignDataGridNavigator(dbn)
        DesignDataGridView(dgv)

        DesignColumn(dgv, "projectStaffId", False)
        DesignColumn(dgv, "projectId", True)
        DesignColumn(dgv, "staffId", "Προσωπικό", 250)
        DesignColumn(dgv, "projectStaffDuties", "Καθήκοντα", 350)
        DesignColumn(dgv, "projectStaffCategory", "Κατηγορία Στελέχους", 250)
        DesignColumn(dgv, "projectStaffComments", "Παρατηρήσεις", 150)

        Me.Text = "Ομάδα Έργου"

        Me.Label2.Text = getProjectName()
    End Sub

    Private Sub TblProjectStaffDataGridView_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblProjectStaffDataGridView.RowValidated
        If e.RowIndex > -1 Then
            dgv.Rows(e.RowIndex).Cells("projectId").Value = pId
        End If
    End Sub

    Function getProjectName() As String
        Dim myConnection As New System.Data.SqlClient.SqlConnection
        myConnection.ConnectionString = My.Settings.diadrasisProjectsDBConnectionString
        Dim myCommand As New System.Data.SqlClient.SqlCommand

        myCommand.Connection = myConnection
        myCommand.CommandType = CommandType.Text

        myCommand.CommandText = "SELECT projectName FROM tblProject WHERE projectId = " & pId

        Dim name As String = ""
        Try
            myConnection.Open()

            If myCommand.ExecuteScalar() IsNot System.DBNull.Value Then
                name = myCommand.ExecuteScalar()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            myConnection.Close()
        End Try

        Return name
    End Function
End Class
