Imports MySql.Data.MySqlClient



Public Class Form1







    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        PictureBox1.Hide()
        Timer1.Enabled = True
        settime = 1000
        TextBox1.Text = ""
        TextBox2.Text = ""


        AcceptButton = Button1
        CancelButton = Button2
        TextBox1.Focus()



        dbconnectinstatus = False
        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = connstring



        Try
            MySQLConn.Open()
            dbconnectinstatus = True
            MySQLConn.Close()
        Catch ex As MySqlException



        Finally
            MySQLConn.Dispose()
            If dbconnectinstatus = True Then
                Label3.Text = "Online"
                Label3.ForeColor = Color.Green


            Else
                Label3.Text = "Offline"
                Label3.ForeColor = Color.Red
                Me.Cursor = Cursors.No
                PictureBox1.Show()
            End If
        End Try
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dbconnectinstatus = True Then

            MySQLConn.ConnectionString = connstring

            If attempt < 3 Then


                Try
                    MySQLConn.Open()

                    Dim query As String
                    query = "select * from scheduling.userlist where Username='" & TextBox1.Text & "'and Password=sha2('" & TextBox2.Text & "', 512)"
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    Dim count As Integer

                    count = 0


                    While reader.Read
                        count += 1
                    End While


                    closinglistener = False
                    If count = 1 Then

                        Me.Hide()
                        'Form2.Show()

                        attempt = 0
                        activeusername = reader.GetString("username")
                        activeuserfname = reader.GetString("fname")
                        activeusermname = reader.GetString("mname")
                        activeuserlname = reader.GetString("lname")
                        activeusertype = reader.GetString("usertype")
                        Form2.WelcomeText.Text = "Welcome!, " & activeuserfname & ""

                        If reader.GetString("usertype") <> "Administrator" Then
                            Me.Hide()
                            Form2.Hide()
                            UserWindow.WelcomeText.Text = "Welcome!, " & activeuserfname & ""
                            UserWindow.Show()

                            'Form2.TabPage2.Enabled = False
                            'Form2.radioedit.Hide()
                            'Form2.radiocreate.Hide()
                            'Form2.muserlistchooseuname.Hide()

                        Else
                            Form2.Show()
                            Me.Hide()

                        End If
                    Else
                        MsgBox("Username does not exist or username and password combination is incorrect", MsgBoxStyle.Critical)

                        attempt = attempt + 1
                        TextBox1.Clear()
                        TextBox2.Clear()
                        TextBox1.Focus()

                    End If

                Catch ex As MySqlException

                    MsgBox("Either you have a problem connecting to the Database or you have used an invalid character in the password field, that you have encountered this error.", MsgBoxStyle.Critical)

                Finally
                    MySQLConn.Dispose()
                End Try

                If attempt = 3 Then
                    Me.Hide()
                    MsgBox("The maximum Login attempts was reached. System terminated.", MsgBoxStyle.Critical, "Are you an authorized user?")
                    End
                End If

            End If
        Else

            MsgBox("The Database is offline. Please restart the system.", MsgBoxStyle.Critical, "Offline")
        End If



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Now.ToString("HH:mm:ss")
        Label5.Text = Date.Now.ToString("MMMMMMMMM dd, yyyy")
        Form2.Label14.Text = "Time: " + Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Application.Restart()
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Gray
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub StartScroll()
        Dim sb As New System.Text.StringBuilder(textBox1.Text & " ")
        Do
            Dim ch As Char = sb(sb.Length - 1)
            sb.Remove(sb.Length - 1, 1)
            sb.Insert(0, ch)
            Label1.Text = sb.ToString()
            Label1.Refresh()
            System.Threading.Thread.Sleep(100)
        Loop
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus

    End Sub
End Class
