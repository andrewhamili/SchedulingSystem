Imports MySql.Data.MySqlClient
Public Class AvailableRooms
    Public adapter As New MySqlDataAdapter
    Public bsource As New BindingSource
    Public dbdataset As New DataTable
    Private Sub AvailableRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableRooms()
    End Sub

    Private Sub LoadAvailableRooms()
        'DataGridAvailableRooms = is d' GridView Name
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'SubjectDescription', day AS Day, room AS Room, TIME_FORMAT(TimeStart, '%H:%i') AS 'Time Start', TIME_FORMAT(TimeEnd, '%H:%i') AS 'Time End', instructor AS Instructor, units as 'Unit(s)' FROM `assignedsubj" & SchoolYear & "" & Semester & "` ORDER BY instructor ASC", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            DataGridAvailableRooms.DataSource = dbdataset
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class