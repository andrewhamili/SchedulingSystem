Public Class DatabaseConnectionConfiguration

    Public mysqlconnection As Boolean = False
    Public PingResult As Boolean = False
    Private Sub DatabaseConnectionConfiguration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PingResult = PingServer(My.Settings.hostname)
        If PingResult = True Then
            LoginPage.Show()
        Else
            MsgBox("The specified Databbase Server is unreachable! Please check if you have entered the correct Hostname or IP Address of the Database Server", MsgBoxStyle.Critical, SystemTitle)
            Exit Sub
        End If
    End Sub
    Public Sub CheckMYSQLConnection()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            MySQLConnection = True
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox("MySQL Communication error.  The Server Username or Password is incorrect.", MsgBoxStyle.Critical, SystemTitle)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Function PingServer(ByVal hostname As String)
        Dim result As Boolean = True
        If My.Settings.hostname = "localhost" Then

            Return result
            Exit Function
        Else
            If My.Computer.Network.Ping(hostname) = False Then
                result = False
            End If
        End If
        Return result
    End Function
End Class