Imports MySql.Data.MySqlClient
Public Class ControlViewAssignedSchedule
    Public Sub Load_Schedules()

        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbdataset As New DataTable

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If



        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'SubjectDescription', day AS Day, room AS Room, TIME_FORMAT(TimeStart, '%H:%i') AS 'Time Start', TIME_FORMAT(TimeEnd, '%H:%i') AS 'Time End', instructor AS Instructor, units as 'Unit(s)' FROM `assignedsubj" & SchoolYear & "" & Semester & "` ORDER BY instructor ASC", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            DataGridSched.DataSource = dbdataset
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub Load_FacultyList(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabSpecific.Enter
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring & database

        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbdataset As New DataTable

        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', username AS Username FROM userlist WHERE username!='pass';", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridFaculty.DataSource = bsource
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Close()
        End Try
    End Sub

    Private Sub DataGridFaculty_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridFaculty.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridFaculty.Rows(e.RowIndex)
            Dim lname As String = row.Cells("Last Name").Value.ToString
            Dim fname As String = row.Cells("First Name").Value.ToString
            FacultySched.instrname = "" & lname & ", " & fname
            FacultySched.ShowDialog()
        End If
    End Sub
End Class
