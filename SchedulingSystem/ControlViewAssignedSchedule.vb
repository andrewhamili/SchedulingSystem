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
End Class
