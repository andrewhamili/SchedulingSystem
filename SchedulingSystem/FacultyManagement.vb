Imports MySql.Data.MySqlClient
Public Class FacultyManagement
    Dim adapter As New MySqlDataAdapter
    Dim bsource As New BindingSource
    Dim dbdataset As New DataTable
    Private Sub LoadFacultyTable()
        Try
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
    Private Sub ClearFields()
        txt_Empid.Enabled = True
        txt_Empid.Text = ""
        txt_Fname.Text = ""
        txt_Mname.Text = ""
        txt_Lname.Text = ""
        txt_SchoolCollege.Text = ""
    End Sub
    Private Sub FacultyManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFacultyTable()
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            CheckOpenConnection_AND_CloseIt()
            MySQLConn.Open()
            comm = New MySqlCommand("INSERT INTO scheduling.facultylist (faculty_id, faculty_firstname, faculty_middlename, faculty_lastname, faculty_schoolcollege) VALUES(@a,@b,@c,@d,@e)", MySQLConn)
            comm.Parameters.AddWithValue("@a", txt_Empid.Text)
            comm.Parameters.AddWithValue("@b", txt_Fname.Text)
            comm.Parameters.AddWithValue("@c", txt_Mname.Text)
            comm.Parameters.AddWithValue("@d", txt_Lname.Text)
            comm.Parameters.AddWithValue("@e", txt_SchoolCollege.Text)
            comm.ExecuteNonQuery()
            MsgBox("Faculty registered!", MsgBoxStyle.Information, SystemTitle)
            MySQLConn.Close()
            ClearFields()
            LoadFacultyTable()
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
            comm = New MySqlCommand("UPDATE scheduling.facultylist SET faculty_firstname=@b, faculty_middlename=@c, faculty_lastname=@d, faculty_schoolcollege=@e) WHERE faculty_id=@a", MySQLConn)
            comm.Parameters.AddWithValue("@a", txt_Empid.Text)
            comm.Parameters.AddWithValue("@b", txt_Fname.Text)
            comm.Parameters.AddWithValue("@c", txt_Mname.Text)
            comm.Parameters.AddWithValue("@d", txt_Lname.Text)
            comm.Parameters.AddWithValue("@e", txt_SchoolCollege.Text)
            comm.ExecuteNonQuery()
            MsgBox("Faculty details updated!", MsgBoxStyle.Information, SystemTitle)
            MySQLConn.Close()

            ClearFields()
            btn_Update.Enabled = False
            btn_Save.Enabled = True
            LoadFacultyTable()
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
            btn_Update.Enabled = True
            btn_Save.Enabled = False
            row = DataGridViewFaculty.Rows(e.RowIndex)
            txt_Empid.Text = row.Cells("Employee ID").Value
            txt_Fname.Text = row.Cells("First Name").Value
            txt_Mname.Text = row.Cells("Middle Name").Value
            txt_Lname.Text = row.Cells("Last Name").Value
            txt_SchoolCollege.Text = row.Cells("School/College").Value
        End If
    End Sub
End Class
