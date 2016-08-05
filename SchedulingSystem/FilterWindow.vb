Imports MySql.Data.MySqlClient


Public Class FilterWindow
    Public day As String

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Close()
            MySQLConn.Open()
            query = "select lname from userlist where username!='pass' order by lname asc"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            While reader.Read
                ComboBoxLastname.Items.Add(reader.GetString("lname"))
                ComboBoxLastname.AutoCompleteCustomSource.Add(reader.GetString("lname"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub FilterWindow_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Dispose()
    End Sub

    Private Sub FilterWindow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBoxLastname.Items.Clear()
        RadioButton1.Checked = True
        CancelButton = Button1
        ComboBoxLastname.Focus()


    End Sub

    Private Sub ComboBoxLastname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxLastname.SelectedIndexChanged

        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where instructor like '%" & ComboBoxLastname.Text & "%'order by instructor asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            Form2.DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub Subject_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Subject.Enter
        ComboBoxClasscode.Items.Clear()
        MySQLConn.ConnectionString = connstring

        

        Try
            MySQLConn.Open()
            query = "select classcode from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "`"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ComboBoxClasscode.Items.Add(reader.GetString("classcode"))
                ComboBoxClasscode.AutoCompleteCustomSource.Add(reader.GetString("classcode"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub ComboBoxClasscode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxClasscode.SelectedIndexChanged
        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode like '%" & ComboBoxClasscode.Text & "%'order by instructor asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            Form2.DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class