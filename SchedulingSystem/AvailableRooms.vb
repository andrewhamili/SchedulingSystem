Imports MySql.Data.MySqlClient
Public Class AvailableRooms
    Public RoomList As New List(Of String)
    Public day As String

    Private Sub AvailableRooms_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub AvailableRooms_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Load_current_Rooms(RoomList)
        Console.WriteLine(RoomList.Count)
        DTP_date.Value = Now.ToString("MM/dd/yyyy")
        DTP_timestart.Value = Now.ToString("MM/dd/yyyy HH:mm")
        Dim PlusOne As DateTime = DTP_timestart.Value
        DTP_timeend.Value = PlusOne.AddHours(1).ToString("MM/dd/yyyy HH:mm")
        day = DTP_date.Value.DayOfWeek.ToString.Substring(0, 2)
        Show_available_rooms()
        ListBoxRooms.Items.AddRange(RoomList.ToArray)
    End Sub
    Public Sub Load_current_Rooms(ByRef room As List(Of String))
        
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If


        MySQLConn.ConnectionString = connstring & database



        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM `roomlist" + SchoolYear & Semester + "`", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                room.Add(reader.GetString("room"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub Show_available_rooms() Handles btnShow.Click


        Dim tstart As DateTime = DTP_timestart.Value.ToString("HH:mm")
        Dim tend As DateTime = DTP_timeend.Value.ToString("HH:mm")
        Dim span As TimeSpan
        span = tend.Subtract(tstart)
        If span.TotalSeconds <= 0 Then
            MsgBox("The Time End cannot be equal or greater than the Time Start.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        day = DTP_date.Value.DayOfWeek.ToString.Substring(0, 2)
        ListBoxRooms.Items.Clear()
        ListBoxRooms.Items.AddRange(RoomList.ToArray)
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            'comm = New MySqlCommand("SELECT room FROM `assignedsubj" + SchoolYear & Semester + "` WHERE day like '%@day%' AND TimeEnd > @timefrom and TimeStart < @timeto", MySQLConn)
            comm = New MySqlCommand("SELECT room FROM `assignedsubj" + SchoolYear & Semester + "` WHERE day like '%" & day & "%' AND TimeEnd > '" & DTP_timestart.Value.ToString("HH:mm") & "' and TimeStart < '" & DTP_timeend.Value.ToString("HH:mm") & "'", MySQLConn)

            'With comm.Parameters
            '    .AddWithValue("day", day)
            '    .AddWithValue("timefrom", DTP_timestart.Value.ToString("HH:mm"))
            '    .AddWithValue("timeto", DTP_timeend.Value.ToString("HH:mm"))
            'End With
            reader = comm.ExecuteReader
            While reader.Read
                ListBoxRooms.Items.Remove(reader.GetString("room"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub
End Class