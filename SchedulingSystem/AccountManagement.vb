Imports MySql.Data.MySqlClient
Class AccountManagement

    Private Sub AccountManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtRetypePassword.Clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring & database

        If txtFname.Text = "" Or txtLname.Text = "" Or txtUsername.Text = "" Or txtRetypePassword.Text = "" Then
            MsgBox("Please fill-up all necessary fields!", MsgBoxStyle.Exclamation, SystemTitle)
        ElseIf txtPassword.Text <> txtRetypePassword.Text Then
            MsgBox("Passwords do not match!", MsgBoxStyle.Exclamation, SystemTitle)
        Else
            Try
                MySQLConn.Open()
                comm = New MySqlCommand("", MySQLConn)
                reader = comm.ExecuteReader
                Dim count As Integer = 0
                While reader.Read
                    count += 1
                End While
                If count > 0 Then
                    MsgBox("The  aready exists! Please use a different username.", MsgBoxStyle.Critical, SystemTitle)
                    MySQLConn.Close()
                    Exit Try
                Else
                    MySQLConn.Close()
                    MySQLConn.Open()
                    comm = New MySqlCommand("", MySQLConn)
                    comm.ExecuteNonQuery()
                    MsgBox("The Account has been successfully created!", MsgBoxStyle.Critical, SystemTitle)
                    MySQLConn.Close()
                End If
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
    End Sub
End Class