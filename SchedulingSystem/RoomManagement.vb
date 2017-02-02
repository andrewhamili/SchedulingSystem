Imports MySql.Data.MySqlClient
Class RoomManagement

    Private Sub RoomManagement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub RoomManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Rooms()
    End Sub
    Public Sub Load_Rooms()
        ListBoxRoom.Items.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM `roomlist" & SchoolYear + Semester & "`", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ListBoxRoom.Items.Add(reader.GetString("room"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("INSERT into `roomlist" & SchoolYear + Semester & "` VALUES(@room)", MySQLConn)
            comm.Parameters.AddWithValue("room", txtRoom.Text)
            comm.ExecuteNonQuery()
            MsgBox("The room has been successfully added to the list!", MsgBoxStyle.Information, SystemTitle)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        Load_Rooms()
    End Sub
End Class