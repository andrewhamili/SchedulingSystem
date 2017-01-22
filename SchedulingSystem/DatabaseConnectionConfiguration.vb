Public Class DatabaseConnectionConfiguration

    Public mysqlconnection As Boolean = False
    Public PingResult As Boolean = False
    Public MySQLStatus As Boolean
    Private Sub DatabaseConnectionConfiguration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PingResult = PingServer(My.Settings.hostname)
        If PingResult = True Then
            MySQLStatus = CheckMYSQLConnection()
            If MySQLStatus = True Then

                LoginPage.Show()
                Me.Dispose()

            End If
        Else
            MsgBox("The specified Database Server is unreachable! Please check if you have entered the correct Hostname or IP Address of the Database Server", MsgBoxStyle.Critical, SystemTitle)
            Exit Sub
        End If
    End Sub
    Function CheckMYSQLConnection()
        Dim status As Boolean = False
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            status = True
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox("MySQL Communication error.  The Server Username or Password is incorrect.", MsgBoxStyle.Critical, SystemTitle)
        Finally
            MySQLConn.Dispose()
        End Try
        Return status
    End Function
    Public Function PingServer(ByVal hostname As String)
        Dim result As Boolean = True
        If My.Settings.hostname = "localhost" Or My.Settings.hostname = "LOCALHOST" Then
            If MySQLProcessCheck() = False Then
                MsgBox("The MySQL Server is not running! Please check if you have installed MySQL Server or it is running on process. (mysqld.exe)", MsgBoxStyle.Critical, SystemTitle)
                result = False
                Return result
                Exit Function
            End If
            Return result
            Exit Function
        Else
            If My.Computer.Network.Ping(hostname) = False Then
                result = False
            End If
        End If
        Return result
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.hostname = txtHostname.Text
        My.Settings.username = txtUsername.Text
        My.Settings.password = txtPassword.Text
        My.Settings.Save()
        Application.Restart()
    End Sub
    Function MySQLProcessCheck()
        For Each clsProcess As Process In Process.GetProcesses()


            If clsProcess.ProcessName.StartsWith("mysql") Then
                Return True

                'process found so it's running so return true




            End If
        Next
        Return False
    End Function
End Class