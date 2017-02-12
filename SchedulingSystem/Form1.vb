Imports MySql.Data.MySqlClient
Public Class LoginPage

    Dim MySQLConnection As Boolean = False

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub LoginPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Count > 0 Then

        End If
        CheckMYSQLConnection()
        Check_if_database_exists()
        If MySQLConnection = True Then
            With lblDatabaseStatus
                .Text = "Online"
                .ForeColor = Color.Green
            End With
        Else
            With lblDatabaseStatus
                .Text = "Offline"
                .ForeColor = Color.Red
            End With
        End If
        AcceptButton = btnLogin
        CancelButton = btnCancel
        Timer_CurrentTimeAndDate.Enabled = True

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If tboxusername.Text = "" Or tboxpassword.Text = "" Then
            MsgBox("Please enter the Username and Password first!", MsgBoxStyle.Exclamation, SystemTitle)
        Else
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If
            MySQLConn.ConnectionString = connstring & database

            Try
                MySQLConn.Open()
                comm = New MySqlCommand("SELECT * FROM scheduling.userlist where BINARY username=@username AND password=sha2(@password, 512);", MySQLConn)
                comm.Parameters.AddWithValue("username", tboxusername.Text)
                comm.Parameters.AddWithValue("password", tboxpassword.Text)
                reader = comm.ExecuteReader
                Dim count As Integer = 0
                While reader.Read
                    count += 1
                End While
                If count > 0 Then
                    Me.Hide()
                    tboxusername.Text = ""
                    tboxusername.Focus()
                    tboxpassword.Text = ""
                    activeusername = reader.GetString("username")
                    activeuserfname = reader.GetString("fname")
                    activeuserlname = reader.GetString("lname")
                    usertype = reader.GetString("usertype")
                    Dim welcomename As String = activeuserfname + " " + activeuserlname
                    Dim UserPageName As String = activeuserlname + ", " + activeuserfname
                    AdminPage.lblName.Text = "Welcome!, " & welcomename & ""
                    Get_Active_SchoolYearSemester()
                    If usertype = "Administrator" Then
                        AdminPage.Show()
                    Else
                        UserWindow.instrname = UserPageName
                        UserWindow.Show()
                    End If

                Else
                    MsgBox("You have entered an incorrect username/password", MsgBoxStyle.Exclamation, SystemTitle)
                    With tboxusername
                        .Text = ""
                        .Focus()
                    End With
                    tboxpassword.Text = ""
                End If
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
        
    End Sub
    Private Sub Timer_CurrentTimeAndDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_CurrentTimeAndDate.Tick
        lblDate.Text = Now.ToString("MMMMM dd, yyyy")
        lblTime.Text = Now.ToString("HH:mm:ss")
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
            MsgBox("MySQL Communication error" & ex.Message, MsgBoxStyle.Critical, SystemTitle)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub Check_if_database_exists()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()

            comm = New MySqlCommand("SHOW DATABASES LIKE 'scheduling'", MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count += 1
            End While
            If count = 0 Then
                MsgBox("WARNING: The MySQL Database Server is Online but the database for this system was not found! Logging-in will not be possible.", MsgBoxStyle.Exclamation, SystemTitle)
                btnLogin.Enabled = False
            End If
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox("MySQL Server Connection Error" & ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub Get_Active_SchoolYearSemester()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM existingschoolyearsemester WHERE isActive='true';", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                SchoolYear = reader.GetString("schoolyear")
                Semester = reader.GetString("semester")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class
