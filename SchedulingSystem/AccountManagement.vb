Imports MySql.Data.MySqlClient
Class AccountManagement

    Private Sub AccountManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        CancelButton = btnCancel

        If EntryText = "Add" Then
            PanelCreate.Show()
            PanelEditOrDelete.Hide()
        ElseIf EntryText = "Edit" Then
            PanelEditOrDelete.Show()
        Else
            PanelCreate.Hide()
            PanelEditOrDelete.Hide()
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If Not (txtFnameEdit.Text = "" And txtMnameEdit.Text = "" And txtLnameEdit.Text = "" And txtUsernameEdit.Text = "" And txtPasswordEdit.Text = "" And txtRetypePasswordEdit.Text = "" And ComboBoxUsertypeEdit.Text = "") Then
            Dim confirm As DialogResult = MessageBox.Show(Me, "Changes will not be saved. Are you sure you want to close this window?", SystemTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.Yes Then
                Me.Dispose()
            End If
        Else
            Me.Dispose()
        End If
    End Sub
    Private Sub btn_SaveEdit_Click(sender As System.Object, e As System.EventArgs) Handles btn_SaveEdit.Click
        If txtPasswordEdit.Text = "" Then
            MsgBox("Password cannot be blank!", MsgBoxStyle.Critical, SystemTitle)
            Exit Sub
        End If
        If txtFnameEdit.Text = "" Or txtLnameEdit.Text = "" Or txtUsernameEdit.Text = "" Then
            MsgBox("Please select an account.", MsgBoxStyle.Critical, SystemTitle)
            Exit Sub
        End If
        If txtPasswordEdit.Text <> txtRetypePasswordEdit.Text Then
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
            comm.Parameters.AddWithValue("password", txtRetypePasswordEdit.Text)
            comm.Parameters.AddWithValue("usertype", ComboBoxUsertypeEdit.Text)
            comm.Parameters.AddWithValue("username", txtUsernameEdit.Text)
            comm.ExecuteReader()
            MsgBox("The Account has been successfully updated!", MsgBoxStyle.Information, SystemTitle)
            EntryText = ""
            txtFnameEdit.Text = ""
            txtMnameEdit.Text = ""
            txtLnameEdit.Text = ""
            txtUsernameEdit.Text = ""
            txtPasswordEdit.Text = ""
            txtRetypePasswordEdit.Text = ""
            DataGridViewAccounts.Enabled = True
            MySQLConn.Close()
            Load_Accounts()
            PanelTools.Hide()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    'Private Sub DataGridViewAccounts_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If e.RowIndex >= 0 Then
    '        PanelTools.Show()
    '        Dim row As DataGridViewRow = DataGridViewAccounts.Rows(e.RowIndex)
    '        txtFname.Text = row.Cells("First Name").Value
    '        txtMname.Text = row.Cells("Middle Name").Value
    '        txtLname.Text = row.Cells("Last Name").Value
    '        txtUsername.Text = row.Cells("Username").Value
    '        ComboBoxUsertype.Text = row.Cells("User Type").Value
    '        txtFname.Enabled = False
    '        txtMname.Enabled = False
    '        txtLname.Enabled = False
    '        txtUsername.Enabled = False
    '        DataGridViewAccounts.Enabled = False
    '        EntryText = "Edit"
    '    End If
    'End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtFname.Text = "" Or txtLname.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or ComboBoxUsertype.Text = "" Then
            MsgBox("Please complete the fields", MsgBoxStyle.Critical, SystemTitle)
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
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
    End Sub


    Private Sub btn_ClearEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClearEdit.Click
        txtFnameEdit.Text = ""
        txtMnameEdit.Text = ""
        txtLnameEdit.Text = ""
        txtUsernameEdit.Text = ""
        txtPasswordEdit.Text = ""
        txtRetypePasswordEdit.Text = ""

        txtFnameEdit.Focus()
    End Sub

    Private Sub DataGridViewAccounts_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAccounts.CellDoubleClick
        If e.RowIndex >= 0 Then
            txtRetypePasswordEdit.Text = ""
            txtPasswordEdit.Text = ""
            Dim row As DataGridViewRow = DataGridViewAccounts.Rows(e.RowIndex)
            txtFnameEdit.Text = row.Cells("First Name").Value
            txtMnameEdit.Text = row.Cells("Middle Name").Value
            txtLnameEdit.Text = row.Cells("Last Name").Value
            txtUsernameEdit.Text = row.Cells("Username").Value
            ComboBoxUsertypeEdit.Text = row.Cells("User Type").Value
            PanelTools.Show()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub

    Private Sub btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtRetypePassword.Text = ""
        ComboBoxUsertype.Text = ""
        txtFname.Focus()
    End Sub

    Private Sub btn_DeleteEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeleteEdit.Click
        Try
            Dim confirm As DialogResult = MessageBox.Show(Me, "Are you sure you want to delete the account of " & txtFnameEdit.Text & " " & txtLnameEdit.Text & "?", SystemTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                MySQLConn.Open()
                comm = New MySqlCommand("DELETE FROM userlist WHERE usertype=@usertype AND username=@username AND fname=@firstname AND lname=@lastname", MySQLConn)
                comm.Parameters.AddWithValue("usertype", ComboBoxUsertypeEdit.Text)
                comm.Parameters.AddWithValue("username", txtUsernameEdit.Text)
                comm.Parameters.AddWithValue("firstname", txtFnameEdit.Text)
                comm.Parameters.AddWithValue("lastname", txtLnameEdit.Text)
                comm.ExecuteNonQuery()
                MySQLConn.Close()
                Load_Accounts()
                PanelTools.Hide()
                EntryText = ""
                txtFnameEdit.Text = ""
                txtMnameEdit.Text = ""
                txtLnameEdit.Text = ""
                txtUsernameEdit.Text = ""
                txtPasswordEdit.Text = ""
                txtRetypePasswordEdit.Text = ""
                DataGridViewAccounts.Enabled = True
                MsgBox("The Account has been successfully Deleted!", MsgBoxStyle.Information, SystemTitle)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub
End Class