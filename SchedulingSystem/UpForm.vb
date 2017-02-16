Imports MySql.Data.MySqlClient
Class UpForm

    Private Sub UpForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        LoginPage.Show()
        LoginPage.tboxusername.Focus()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBoxRooms.Items.AddRange(Fill_ListView)
        ListBoxRooms.SelectedIndex = 0
    End Sub
    Public Sub Load_Rooms(ByRef Roomlist As ArrayList)

    End Sub
    Function Fill_ListView()
        Dim RoomPopulate As New List(Of String)


        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM `roomlist2015-20161st`", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                RoomPopulate.Add(reader.GetString("room"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

        Dim Roomlist As Array = RoomPopulate.ToArray
        Return Roomlist
    End Function

    Private Sub ListBoxRooms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxRooms.SelectedIndexChanged
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT CONCAT(TimeStart, ' - ', TimeEnd) as 'Time Occupied', instructor AS Instructor, room as 'Room Assigned', day as Day FROM `assignedsubj2015-20161st` WHERE room=@selectedroom", MySQLConn)
            adapter.SelectCommand = comm
            adapter.SelectCommand.Parameters.AddWithValue("selectedroom", ListBoxRooms.SelectedItem.ToString)
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

    Private Sub Btnout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnout.Click
        Dim ans As DialogResult
        ans = MsgBox("Are you sure you want to log-out now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
        If ans = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AssignToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignToolStripMenuItem.Click
        AssignSchedule.ShowDialog()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        UnassignSchedule.ShowDialog()
    End Sub

    Private Sub ManageRoomsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageRoomsToolStripMenuItem.Click
        RoomManagement.ShowDialog()
    End Sub
End Class
