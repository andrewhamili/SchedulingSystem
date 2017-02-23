Imports MySql.Data.MySqlClient
Public Class FacultyManagement
    Private Sub LoadFacultyTable()
        Try
            Dim adapter As New MySqlDataAdapter
            Dim bsource As New BindingSource
            Dim dbdataset As New DataTable
            CheckOpenConnection_AND_CloseIt()
            MySQLConn.ConnectionString = connstring & database
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT faculty_id as 'Employee ID', faculty_firstname as 'First Name', faculty_middlename as 'Middle Name', faculty_lastname as 'Last Name', faculty_schoolcollege as 'School/College' FROM scheduling.facultylist", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            DataGridViewFaculty.DataSource = dbdataset
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Private Sub ClearFields(refreshTable As Boolean)
        txt_Empid.Enabled = True
        txt_Empid.Text = ""
        txt_Fname.Text = ""
        txt_Mname.Text = ""
        txt_Lname.Text = ""
        txt_SchoolCollege.Text = ""
        btn_Save.Show()
        btn_Update.Hide()
        btn_Delete.Hide()
        If refreshTable = True Then
            LoadFacultyTable()
        End If
    End Sub
    Private Sub FacultyManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFacultyTable()
        btn_Delete.Hide()
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            If txt_Empid.Text = "" Or txt_Fname.Text = "" Or txt_Mname.Text = "" Or txt_Lname.Text = "" Or txt_SchoolCollege.Text = "" Then
                MessageBox.Show(Me, "Please complete the fields.", SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CheckOpenConnection_AND_CloseIt()
                MySQLConn.Open()
                comm = New MySqlCommand("INSERT INTO scheduling.facultylist (faculty_id, faculty_firstname, faculty_middlename, faculty_lastname, faculty_schoolcollege) VALUES(@a,@b,@c,@d,@e)", MySQLConn)
                comm.Parameters.AddWithValue("@a", txt_Empid.Text)
                comm.Parameters.AddWithValue("@b", txt_Fname.Text)
                comm.Parameters.AddWithValue("@c", txt_Mname.Text)
                comm.Parameters.AddWithValue("@d", txt_Lname.Text)
                comm.Parameters.AddWithValue("@e", txt_SchoolCollege.Text)
                comm.ExecuteNonQuery()
                MySQLConn.Close()
                ClearFields(True)
                MessageBox.Show(Me, "Faculty successfully registered.", SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show(Me, "The faculty already exists.", SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(Me, ex.Number & vbNewLine & ex.Message, SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click
        Try
            CheckOpenConnection_AND_CloseIt()
            MySQLConn.Open()
            comm = New MySqlCommand("UPDATE scheduling.facultylist SET faculty_firstname=@b, faculty_middlename=@c, faculty_lastname=@d, faculty_schoolcollege=@e WHERE faculty_id=@a", MySQLConn)
            comm.Parameters.AddWithValue("@a", txt_Empid.Text)
            comm.Parameters.AddWithValue("@b", txt_Fname.Text)
            comm.Parameters.AddWithValue("@c", txt_Mname.Text)
            comm.Parameters.AddWithValue("@d", txt_Lname.Text)
            comm.Parameters.AddWithValue("@e", txt_SchoolCollege.Text)
            comm.ExecuteNonQuery()
            MySQLConn.Close()
            ClearFields(True)
            MessageBox.Show(Me, "Successfully updated the faculty information.", SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Dispose()
    End Sub


    Private Sub DataGridViewFaculty_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewFaculty.CellDoubleClick
        Dim row As DataGridViewRow
        If e.RowIndex >= 0 Then
            txt_Empid.Enabled = False
            btn_Save.Hide()
            btn_Update.Show()
            btn_Delete.Show()
            row = DataGridViewFaculty.Rows(e.RowIndex)
            txt_Empid.Text = row.Cells("Employee ID").Value
            txt_Fname.Text = row.Cells("First Name").Value
            txt_Mname.Text = row.Cells("Middle Name").Value
            txt_Lname.Text = row.Cells("Last Name").Value
            txt_SchoolCollege.Text = row.Cells("School/College").Value
        End If
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        ClearFields(False)
    End Sub

    Private Sub btn_Delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_Delete.Click
        Try
            Dim confirm = MessageBox.Show(Me, "Are you sure you want to delete the account of " & txt_Fname.Text & " " & txt_Lname.Text & "?", SystemTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.Yes Then
                CheckOpenConnection_AND_CloseIt()
                MySQLConn.Open()
                comm = New MySqlCommand("DELETE FROM scheduling.facultylist WHERE faculty_id=@a AND faculty_firstname=@b AND faculty_middlename=@c AND faculty_lastname=@d AND faculty_schoolcollege=@e", MySQLConn)
                comm.Parameters.AddWithValue("@a", txt_Empid.Text)
                comm.Parameters.AddWithValue("@b", txt_Fname.Text)
                comm.Parameters.AddWithValue("@c", txt_Mname.Text)
                comm.Parameters.AddWithValue("@d", txt_Lname.Text)
                comm.Parameters.AddWithValue("@e", txt_SchoolCollege.Text)
                comm.ExecuteNonQuery()
                MySQLConn.Close()
                ClearFields(True)
                MessageBox.Show(Me, "Successfully deleted the faculty.", SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, SystemTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class
