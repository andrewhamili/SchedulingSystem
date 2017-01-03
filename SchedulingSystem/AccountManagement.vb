Imports MySql.Data.MySqlClient
Class AccountManagement
    Public EditText As String = "Create"
    Private Sub AccountManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancelButton = btnCancel
        Load_Accounts()
    End Sub
    Public Sub Load_Accounts()
        DataGridViewAccounts.DataSource = Nothing
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT fname AS 'First Name', mname AS 'Middle Name', lname AS 'Last Name', username AS Username, usertype AS 'User Type' FROM userlist WHERE username!='pass';", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridViewAccounts.DataSource = bsource
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If EditText = "Edit" Then
            EditUser()
        Else
            CreateUser()
        End If
    End Sub
    Public Sub EditUser()
        If txtPassword.Text = "" Then
            MsgBox("Password cannot be blank!", MsgBoxStyle.Critical, SystemTitle)
            Exit Sub
        End If
        If txtPassword.Text <> txtRetypePassword.Text Then
            MsgBox("The Passwords do not match!", MsgBoxStyle.Critical, SystemTitle)
            Exit Sub
        End If
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("UPDATE userlist SET password=sha2(@password,512),  usertype=@usertype WHERE username=@username;", MySQLConn)
            comm.Parameters.AddWithValue("password", txtRetypePassword.Text)
            comm.Parameters.AddWithValue("usertype", ComboBoxUsertype.Text)
            comm.Parameters.AddWithValue("username", txtUsername.Text)
            comm.ExecuteReader()
            MsgBox("The Account has been successfully updated!", MsgBoxStyle.Information, SystemTitle)
            EditText = ""
            txtFname.Text = ""
            txtMname.Text = ""
            txtLname.Text = ""
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtRetypePassword.Text = ""
            DataGridViewAccounts.Enabled = True
            MySQLConn.Close()
            Load_Accounts()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub DataGridViewAccounts_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAccounts.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridViewAccounts.Rows(e.RowIndex)
            txtFname.Text = row.Cells("First Name").Value
            txtMname.Text = row.Cells("Middle Name").Value
            txtLname.Text = row.Cells("Last Name").Value
            txtUsername.Text = row.Cells("Username").Value
            ComboBoxUsertype.Text = row.Cells("User Type").Value
            txtFname.Enabled = False
            txtMname.Enabled = False
            txtLname.Enabled = False
            txtUsername.Enabled = False
            DataGridViewAccounts.Enabled = False
            EditText = "Edit"
        End If
    End Sub
    Public Sub CreateUser()
        If txtFname.Text = "" Or txtLname.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or ComboBoxUsertype.Text = "" Then
            MsgBox("Please complete th fields", MsgBoxStyle.Critical, SystemTitle)
        ElseIf txtPassword.Text <> txtRetypePassword.Text Then
            MsgBox("The passwords do not match!", MsgBoxStyle.Critical, SystemTitle)
        Else

            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If
            MySQLConn.ConnectionString = connstring & database
            Try
                MySQLConn.Open()
                comm = New MySqlCommand("INSERT INTO userlist VALUES(@fname, @mname, @lname, @username, sha2(@password, 512), @usertype)", MySQLConn)
                With comm.Parameters
                    .AddWithValue("username", txtUsername.Text)
                    .AddWithValue("password", txtRetypePassword.Text)
                    .AddWithValue("fname", txtFname.Text)
                    .AddWithValue("mname", txtMname.Text)
                    .AddWithValue("lname", txtLname.Text)
                    .AddWithValue("usertype", ComboBoxUsertype.Text)
                End With
                comm.ExecuteReader()
                MsgBox("The account has been successfully created!", MsgBoxStyle.Information, SystemTitle)
                EditText = ""
                txtFname.Text = ""
                txtMname.Text = ""
                txtLname.Text = ""
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtRetypePassword.Text = ""
                ComboBoxUsertype.Text = ""
                MySQLConn.Close()
                Load_Accounts()
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If activeusername = txtUsername.Text Then
            MsgBox("You cannot delete your own account while you are logged in. Use another Administrator account instead", MsgBoxStyle.Critical, SystemTitle)
            Exit Sub
        End If
        Dim confirmDelete As DialogResult = MsgBox("Are you sure you want to delete this account? This action is irreversible unless you have the latest database backup.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
        If confirmDelete = DialogResult.Yes Then
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If
            MySQLConn.ConnectionString = connstring & database
            Try
                MySQLConn.Open()
                comm = New MySqlCommand("DELETE FROM userlist WHERE username=@username;DELETE FROM `assignedsubj" & SchoolYear & "" & Semester & "` WHERE instructor=@instrname;", MySQLConn)
                Dim instrname As String = txtLname.Text + ", " & txtFname.Text
                comm.Parameters.AddWithValue("username", txtUsername.Text)
                comm.Parameters.AddWithValue("instrname", instrname)
                comm.ExecuteReader()
                MsgBox("The account has been successfully deleted!", MsgBoxStyle.Information, SystemTitle)
                MySQLConn.Close()
                Load_Accounts()
                DataGridViewAccounts.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If

    End Sub
End Class