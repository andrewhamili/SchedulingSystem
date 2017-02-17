Imports MySql.Data.MySqlClient
Class AccountManagement

    Private Sub AccountManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        CancelButton = btnCancel

        If EntryText = "Add" Then
            PanelEditOrDelete.Hide()
        Else
            PanelCreate.Hide()
        End If

        Load_Accounts()
        PanelTools.Hide()
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
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
            EntryText = ""
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

    Private Sub DataGridViewAccounts_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            PanelTools.Show()
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
            EntryText = "Edit"
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
                EntryText = ""
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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtRetypePassword.Text = ""
    End Sub
End Class