Imports MySql.Data.MySqlClient
Class RoomManagement

    Private Sub RoomManagement_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub RoomManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancelButton = btnClose
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
        Dim response As DialogResult = MsgBox("Sure to add this room?" & vbCrLf + vbCrLf & "NOTE: The system cannot detect room duplication if it has a different Character casing or spacing to a duplicate item. So, you should double check the added rooms.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)

        If txtRoom.Text = "" Then
            MsgBox("Please enter a room!", MsgBoxStyle.Critical, SystemTitle)
            Exit Sub
        End If
        If response = DialogResult.No Then
            Exit Sub
        End If
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
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show(Me, "The room exists.", SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(Me, ex.Number & vbNewLine & ex.Message, SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        Load_Rooms()
    End Sub

    Private Sub ListBoxRoom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxRoom.DoubleClick
        Dim response As DialogResult = MsgBox("Are you sure you want to delete this room? This cannot be undone." & vbCrLf + vbCrLf & "NOTE: Deleting a room will also delete all schedules for the room.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
        If response = DialogResult.No Then
            Exit Sub
        End If
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("DELETE FROM `roomlist" & SchoolYear + Semester & "` WHERE room=@room; DELETE FROM `subjectlist" & SchoolYear + Semester & "` WHERE room=@room;DELETE FROM  `assignedsubj" & SchoolYear + Semester & "` WHERE room=@room;", MySQLConn)
            comm.Parameters.AddWithValue("room", ListBoxRoom.SelectedItem)
            comm.ExecuteNonQuery()
            MsgBox("The room has been successfully deleted!", MsgBoxStyle.Information, SystemTitle)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        Load_Rooms()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class