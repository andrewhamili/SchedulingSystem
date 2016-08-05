Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports DevComponents.DotNetBar
Imports System.IO

Public Class Form2

    Public query As String


    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property


    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        MySQLConn.ConnectionString = connstring
        Dim tempemp As String

        Try
            ProgBar.Value = 25
            MySQLConn.Open()

            Dim query As String
            query = "select * from userlist where username='" & musertboxuname.Text & "' or empnum='" & musertboxempnum.Text & "'"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer

            count = 0


            While reader.Read
                count += 1
            End While
            If count >= 1 Then
                ProgBar.Value = 50
                MsgBox("The Username or Employee code is already used! You can check the list of used Employee codes in  the Schedule Management > Professor Tab.", MsgBoxStyle.Critical, "Duplicate username or Employee code!")
            Else
                If musertboxempnum.Text = "" Or musertboxfname.Text = "" Or musertboxuname.Text = "" Or musertboxpword1.Text = "" Or musertboxpword2.Text = "" Then
                    MsgBox("Please Fill up at least the First name, Username and the passwords field", MsgBoxStyle.Critical, "Insufficient User Information")
                Else
                    MySQLConn.Close()
                    MySQLConn.Open()
                    query = "insert into userlist values('" & musertboxempnum.Text & "', '" & musertboxfname.Text & "', '" & musertboxmname.Text & "', '" & musertboxlname.Text & "',  '" & musertboxuname.Text & "', sha2('" & musertboxpword2.Text & "', 512), '" & musercboxutype.Text & "')"
                    comm = New MySqlCommand(query, MySQLConn)
                    ProgBar.Value = 75
                    If musertboxpword1.Text = musertboxpword2.Text Then
                        If musercboxutype.Text = "" And musercboxutype.Text = "" Then
                            MsgBox("Please Choose a User type first.", MsgBoxStyle.Critical, "Passwords did not match!")
                            Label6.BackColor = Color.Red
                        Else

                            reader = comm.ExecuteReader

                            tempemp = musertboxempnum.Text

                            ProgBar.Value = 100

                            MsgBox("User account for " & musertboxfname.Text & " was succcesfully created", MsgBoxStyle.Information, "" & musertboxfname.Text & "")

                            ProgBar.Value = 0
                            musertboxempnum.AutoCompleteCustomSource.Remove(tempemp)

                            musertboxfname.Text = ""
                            musertboxlname.Text = ""
                            musertboxmname.Text = ""
                            musertboxuname.Text = ""
                            musertboxpword1.Text = ""
                            musertboxpword2.Text = ""
                            musercboxutype.Text = ""

                        End If


                    Else

                        MsgBox("The passwords you have entered did not match. Please go back and re-enter the desired password in the password field", MsgBoxStyle.Critical, "Passwords did not match!")

                    End If
                End If
            End If


            MySQLConn.Close()

        Catch ex As MySqlException

            'MsgBox("There was an error connecting to the database. Please try again later. If the problem persists, refer to the user manual or contact the System Developer.", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub Form2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        TextBoxSchoolYear.Text = My.Settings.schoolyear
        TextBoxSemester.Text = My.Settings.semester
    End Sub

    Public Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If closinglistener = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radioedit.Checked = True










        'MySQLConn = New MySqlConnection
        'comm = New MySqlCommand
        'MySQLConn.ConnectionString = connstring
        'Dim adapter As New MySqlDataAdapter
        'Dim dbdataset As New DataTable
        'Dim bsource As New BindingSource


        'Try

        '    MySQLConn.Open()
        '    query = "SELECT classcode as ClassCode, description as Description, day as Day, time as Time, room as Room, units as Units from sampletable"
        '    comm = New MySqlCommand(query, MySQLConn)
        '    adapter.SelectCommand = comm
        '    adapter.Fill(dbdataset)
        '    bsource.DataSource = dbdataset
        '    DataGridSched.DataSource = bsource
        '    adapter.Update(dbdataset)



        '    MySQLConn.Close()




        'Catch ex As MySqlException

        '    MessageBox.Show(ex.Message)

        'Finally
        '    MySQLConn.Dispose()
        'End Try


        musertboxfname.Hide()
        musertboxlname.Hide()
        musertboxmname.Hide()
        musertboxuname.Hide()
        musertboxpword1.Hide()
        musertboxpword2.Hide()
        musercboxutype.Hide()
        btn_cancel.Hide()
        btn_save.Hide()
        btndelete.Hide()
        btnmodify.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label8.Hide()

        labeltip.Text = "List of Subjects Assigned to a Professor"
        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by classcode asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        Timer1.Enabled = True
        DataGridSched.Focus()

    End Sub

    Private Sub musercboxchooseuname_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        labeltip.Text = "This is where you will choose the existing usernames to edit"
    End Sub

    Private Sub musercboxchooseuname_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        labeltip.Text = ""
    End Sub

    Private Sub musercboxchooseuname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MySQLConn.ConnectionString = connstring

        musertboxfname.Show()
        musertboxlname.Show()
        musertboxmname.Show()
        musertboxuname.Show()
        musertboxpword1.Show()
        musertboxpword2.Show()
        musercboxutype.Show()
        btn_cancel.Show()
        btn_save.Hide()
        btndelete.Show()
        btnmodify.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label8.Show()

        Try
            MySQLConn.Open()

            Dim query As String
            query = "select * from userlist where Username='" & muserlistchooseuname.Text & "'"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                musertboxfname.Text = reader.GetString("fname")
                musertboxlname.Text = reader.GetString("lname")
                musertboxmname.Text = reader.GetString("mname")
                musertboxuname.Text = reader.GetString("Username")
                musercboxutype.Text = reader.GetString("usertype")
            End While
            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub musertboxpword2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musertboxpword2.GotFocus
        labeltip.Text = "Enter the password again. It should match the first entered password."
    End Sub

    Private Sub musertboxpword2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musertboxpword2.LostFocus
        If musertboxpword1.Text <> musertboxpword2.Text Then
            MsgBox("The passwords you have entered did not match. Please go back and re-enter the desired password in the password field", MsgBoxStyle.Critical, "Passwords did not match!")
        End If
    End Sub

    Private Sub musercboxutype_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musercboxutype.GotFocus

    End Sub

    Private Sub musercboxutype_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musercboxutype.LostFocus
        If musertboxpword1.Text <> musertboxpword2.Text Then
            MsgBox("The passwords you have entered did not match. Please go back and re-enter the desired password in the password field", MsgBoxStyle.Critical, "Passwords did not match!")
        End If
    End Sub
    Private Sub radiocreate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiocreate.CheckedChanged
        Me.Cursor = Cursors.WaitCursor

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
            MySQLConn.Dispose()

        End If

        labeltip.Text = "Create new User account"
        Label7.Hide()
        btnmodify.Hide()


        muserlistchooseuname.Hide()
        muserlistchooseuname.Hide()
        musertboxfname.Text = ""
        musertboxlname.Text = ""
        musertboxmname.Text = ""
        musertboxuname.Text = ""
        musertboxpword1.Text = ""
        musertboxpword2.Text = ""
        musercboxutype.Text = ""

        musertboxempnum.Show()
        musertboxfname.Show()
        musertboxlname.Show()
        musertboxmname.Show()
        musertboxuname.Show()
        musertboxuname.Enabled = True
        musertboxpword1.Show()
        musertboxpword2.Show()
        musercboxutype.Show()
        btn_cancel.Show()
        btn_save.Show()
        btndelete.Hide()
        btnmodify.Hide()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label8.Show()
        Label10.Show()

        Me.Cursor = Cursors.Default


        Try
            MySQLConn.Open()

            Dim query As String
            query = "select  * from userlist where username!='pass'"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                Dim OccupiedEmpNum = reader.GetString("empnum")
                musertboxempnum.AutoCompleteCustomSource.Add(OccupiedEmpNum)
            End While
            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        musertboxempnum.Focus()


    End Sub

    Private Sub radioedit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioedit.CheckedChanged
        MySQLConn = New MySqlConnection
        Dim reader As MySqlDataReader
        labeltip.Text = "Edit Existing Users"
        LabelOccupiedEmpCode.Text = ""
        MySQLConn.ConnectionString = connstring

        musertboxempnum.Hide()
        musertboxfname.Hide()
        musertboxlname.Hide()
        musertboxmname.Hide()
        musertboxuname.Enabled = False
        musertboxuname.Hide()
        musertboxpword1.Hide()
        musertboxpword2.Hide()
        musercboxutype.Hide()
        btn_cancel.Hide()
        btn_save.Hide()
        btndelete.Hide()
        btnmodify.Hide()


        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label6.BackColor = Color.Transparent
        Label8.Hide()
        Label10.Hide()


        Try
            MySQLConn.Open()

            Dim query As String
            query = "select * from userlist where username!='pass'"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                Dim usernames = reader.GetString("Username")
                Dim lnames = reader.GetString("lname")
                muserlistchooseuname.Items.Remove(usernames)
                muserlistchooseuname.Items.Add(usernames)
                AssignSchedWindow.AssignSchedCboxEmpNum.Items.Remove(lnames)
                AssignSchedWindow.AssignSchedCboxEmpNum.Items.Add(lnames)
                AssignSchedWindow.AssignSchedCboxEmpNum.AutoCompleteCustomSource.Add(lnames)
            End While
            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        Label7.Show()
        muserlistchooseuname.Show()
        muserlistchooseuname.Show()
        musertboxfname.Text = ""
        musertboxlname.Text = ""
        musertboxmname.Text = ""
        musertboxuname.Text = ""
        musertboxpword1.Text = ""
        musertboxpword2.Text = ""
        musercboxutype.Text = ""
        muserlistchooseuname.Focus()
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        MySQLConn = New MySqlConnection
        Dim reader As MySqlDataReader
        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()

            Dim firstquery As String
            Dim updatequery As String
            Dim tempuname As String
            Dim tempcurrentusertype As String

            firstquery = "SELECT * FROM userlist WHERE username='" & muserlistchooseuname.Text & "'"

            comm = New MySqlCommand(firstquery, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                tempuname = reader.GetString("username")
                tempcurrentusertype = reader.GetString("usertype")
            End While
            MySQLConn.Close()
            MySQLConn.Open()
            updatequery = "UPDATE userlist set fname='" & musertboxfname.Text & "', lname='" & musertboxlname.Text & "', mname='" & musertboxmname.Text & "', username='" & musertboxuname.Text & "', password=sha2('" & musertboxpword2.Text & "', 512), usertype='" & musercboxutype.Text & "' where username='" & tempuname & "'"
            comm = New MySqlCommand(updatequery, MySQLConn)

            If muserlistchooseuname.Text = activeusername Then

                If musercboxutype.Text = tempcurrentusertype Then

                    If musertboxpword1.Text = "" Or musertboxpword2.Text = "" Then

                        MsgBox("The password field cannot be blank!", MsgBoxStyle.Critical, "Blank password?")

                    ElseIf musertboxpword1.Text = musertboxpword2.Text Then

                        reader = comm.ExecuteReader
                        MsgBox("The user was successfully modified", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "User Updated")

                    Else

                        MsgBox("The passwords you have entered did not match. Please go back and re-enter the desired password in the password field", MsgBoxStyle.Critical, "Passwords did not match!")

                    End If

                Else

                    MsgBox("You cannot edit the Usertype of  " & muserlistchooseuname.Text & "  because it is an active user. Please Log-in to another user with Administrative Privilege to continue modifying  " & muserlistchooseuname.Text & "'s user type. The original usertype for  " & muserlistchooseuname.Text & " is " & tempcurrentusertype & "", MsgBoxStyle.Critical, "Canoot delete " & muserlistchooseuname.Text & "")

                End If

            Else

                If musertboxpword1.Text = "" Or musertboxpword2.Text = "" Then

                    MsgBox("The password field cannot be blank!", MsgBoxStyle.Critical, "Blank password?")

                ElseIf musertboxpword1.Text = musertboxpword2.Text Then

                    reader = comm.ExecuteReader
                    MsgBox("The user was successfully modified", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "User Updated")
                Else

                    MsgBox("The passwords you have entered did not match. Please go back and re-enter the desired password in the password field", MsgBoxStyle.Critical, "Passwords did not match!")

                End If

            End If


            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        MySQLConn = New MySqlConnection
        Dim answer As Integer
        Dim tempusername As String

        MySQLConn.ConnectionString = connstring



        Try
            MySQLConn.Open()
            Dim query As String
            'Dim queryforactiveuser As String
            query = "delete from userlist where username='" & muserlistchooseuname.Text & "'"

            comm = New MySqlCommand(query, MySQLConn)

            If muserlistchooseuname.Text = "" Then
                MsgBox("Please select an available username first", MsgBoxStyle.Critical, "Empty username")
                muserlistchooseuname.BackColor = Color.Red
            ElseIf muserlistchooseuname.Text = activeusername Then
                MsgBox("The user " & muserlistchooseuname.Text & " cannot be deleted because it is an active user. Please Log-in to another user with Administrative Privilege to continue deleting " & muserlistchooseuname.Text & "", MsgBoxStyle.Critical, "Canoot delete " & muserlistchooseuname.Text & "")
            Else

                answer = MsgBox("Are you sure you want to delete the selected user account?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Deleting User Accounts")
                If answer = 6 Then

                    ProgBar.Value = 50
                    tempusername = muserlistchooseuname.Text
                    reader = comm.ExecuteReader
                    ProgBar.Value = 100
                    MsgBox("The User account has been succesfully deleted", MsgBoxStyle.Information, "User Delete")
                    ProgBar.Value = 0
                    muserlistchooseuname.Items.Remove(tempusername)


                    musertboxfname.Hide()
                    musertboxlname.Hide()
                    musertboxmname.Hide()
                    musertboxuname.Hide()
                    musertboxpword1.Hide()
                    musertboxpword2.Hide()
                    musercboxutype.Hide()
                    btn_cancel.Hide()
                    btn_save.Hide()
                    btndelete.Hide()
                    btnmodify.Hide()
                    Label1.Hide()
                    Label2.Hide()
                    Label3.Hide()
                    Label4.Hide()
                    Label5.Hide()
                    Label6.Hide()
                    Label6.BackColor = Color.Transparent
                    Label8.Hide()

                    MySQLConn.Close()
                Else
                    MsgBox("The selected user account was not deleted because the user cancelled the transation.", MsgBoxStyle.Information, "Deleting User Accounts")
                End If
            End If
        Catch ex As MySqlException



        Finally
            MySQLConn.Dispose()

        End Try
    End Sub

    Private Sub btn_cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        LabelOccupiedEmpCode.Text = ""
        musertboxempnum.Hide()
        musertboxfname.Hide()
        musertboxlname.Hide()
        musertboxmname.Hide()
        musertboxuname.Enabled = False
        musertboxuname.Hide()
        musertboxpword1.Hide()
        musertboxpword2.Hide()
        musercboxutype.Hide()
        btn_cancel.Hide()
        btn_save.Hide()
        btndelete.Hide()
        btnmodify.Hide()


        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label6.BackColor = Color.Transparent
        Label8.Hide()
        Label10.Hide()
        radioedit.Checked = True
        MySQLConn.Close()
        MySQLConn.Dispose()
    End Sub

    Private Sub LogoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutButton.Click



        a = MsgBox("Are you sure you want to log-out now? Any unsaved changes will be discarded by the system.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Log-out")
        If a = 6 Then

            closinglistener = True
            Me.Dispose()


            AssignSchedWindow.Close()
            DeleteOrEditSubjectWindow.Close()
            ReportWindow.Close()
            AddSubjectWindow.Close()
            DeleteOrEditSubjectWindow.Close()
            FilterWindow.Close()



            Form1.TextBox1.Text = ""
            Form1.TextBox2.Text = ""
            closinglistener = False
            Form1.Show()
            Form1.TextBox1.Focus()


        End If


    End Sub

    Private Sub musercboxutype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles musercboxutype.SelectedIndexChanged
        Label6.BackColor = Color.Transparent
    End Sub

    Private Sub radioedit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioedit.MouseHover
        labeltip.Text = "Edit Existing Users"
    End Sub

    Private Sub radiocreate_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiocreate.MouseHover
        labeltip.Text = "Create new user account"
    End Sub

    Private Sub radiocreate_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles radiocreate.MouseLeave
        labeltip.Text = ""
    End Sub

    Private Sub radioedit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioedit.MouseLeave
        labeltip.Text = ""
    End Sub

    Private Sub musertboxfname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musertboxfname.GotFocus
        labeltip.Text = "Enter the Firstname of the owner of the user account that wll be created."
    End Sub

    Private Sub musertboxmname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musertboxmname.GotFocus
        labeltip.Text = "Enter the Middle name of the owner of the user account that wll be created."
    End Sub

    Private Sub musertboxlname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musertboxlname.GotFocus
        labeltip.Text = "Enter the Lastname of the owner of the user account that wll be created."
    End Sub

    Private Sub musertboxuname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musertboxuname.GotFocus
        labeltip.Text = "Enter the desired username for the user account that wll be created."
    End Sub

    Private Sub musertboxpword1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles musertboxpword1.GotFocus
        labeltip.Text = "Enter the desired password for the user account that wll be created."
    End Sub

    Private Sub musertboxuname_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles musertboxuname.MouseHover
        labeltip.Text = "Username is permanent and cannot be changed. Sorry."
    End Sub

    Private Sub musertboxuname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles musertboxuname.TextChanged

    End Sub

    Private Sub muserlistchooseuname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muserlistchooseuname.SelectedIndexChanged


        MySQLConn.ConnectionString = connstring

        musertboxempnum.Hide()
        musertboxfname.Show()
        musertboxlname.Show()
        musertboxmname.Show()
        musertboxuname.Show()
        musertboxpword1.Show()
        musertboxpword2.Show()
        musercboxutype.Show()
        btn_cancel.Show()
        btn_save.Hide()
        btndelete.Show()
        btnmodify.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label8.Show()
        Label10.Show()

        Try
            MySQLConn.Open()

            Dim query As String
            query = "select * from userlist where Username='" & muserlistchooseuname.Text & "'"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                LabelOccupiedEmpCode.Text = reader.GetString("empnum")
                musertboxfname.Text = reader.GetString("fname")
                musertboxlname.Text = reader.GetString("lname")
                musertboxmname.Text = reader.GetString("mname")
                musertboxuname.Text = reader.GetString("Username")
                musercboxutype.Text = reader.GetString("usertype")
            End While
            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

    End Sub



    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    '    Dim pdlg As Form = DirectCast(PrintPreviewDialog1, Form)
    '    Dim origheight As Integer = DataGridSched.Height
    '    DataGridSched.Height = DataGridSched.RowCount * DataGridSched.RowTemplate.Height
    '    PrintPreviewDialog1.Document = PrintDocument1
    '    PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
    '    pdlg.WindowState = FormWindowState.Maximized

    '    pdlg.ShowDialog()
    '    DataGridSched.Height = origheight



    'End Sub

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        reportwindowquery = query
        Me.Hide()
        ReportWindow.Show()


    End Sub


    Private Sub ButtonLoadTableSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MySQLConn.ConnectionString = connstring
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            query = "SELECT * from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "`"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSubj.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub RefreshSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'MySQLConn.ConnectionString = connstring
        'Dim adapter As New MySqlDataAdapter
        'Dim dbdataset As New DataTable
        'Dim bsource As New BindingSource


        'Try

        '    MySQLConn.Open()
        '    query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, TimeStart as 'From', TimeEnd as 'To', instructor as Instructor, units as 'Unit' from assignedsubj201520161st"
        '    comm = New MySqlCommand(query, MySQLConn)
        '    adapter.SelectCommand = comm
        '    adapter.Fill(dbdataset)
        '    bsource.DataSource = dbdataset
        '    DataGridSched.DataSource = bsource
        '    adapter.Update(dbdataset)



        '    MySQLConn.Close()




        'Catch ex As MySqlException

        '    MessageBox.Show(ex.Message)

        'Finally
        '    MySQLConn.Dispose()
        'End Try


    End Sub

    Private Sub ButtonAssignSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAssignSched.Click

        AssignSchedWindow.ShowDialog()

    End Sub

    Private Sub ButtonAddSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddSubject.Click

        AddSubjectWindow.ShowDialog()


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Cursor = Cursors.WaitCursor
        MySQLConn.Dispose()
        UserWindow.Label2.Text = ""
        reportwindowquery = query
        ReportWindow.Show()
        Me.Cursor = Cursors.Default
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub TimerRefreshAssignedSchedule_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '    MySQLConn.ConnectionString = connstring
        '    Dim adapter As New MySqlDataAdapter
        '    Dim dbdataset As New DataTable
        '    Dim bsource As New BindingSource


        '    Try

        '        MySQLConn.Open()
        '        query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, TimeStart as 'From', TimeEnd as 'To', instructor as Instructor, units as 'Unit' from assignedsubj201520161st order by instructor asc"
        '        comm = New MySqlCommand(query, MySQLConn)
        '        adapter.SelectCommand = comm
        '        adapter.Fill(dbdataset)
        '        bsource.DataSource = dbdataset
        '        DataGridSched.DataSource = bsource
        '        adapter.Update(dbdataset)



        '        MySQLConn.Close()




        '    Catch ex As MySqlException

        '        MessageBox.Show(ex.Message)

        '    Finally
        '        MySQLConn.Dispose()
        '    End Try

        'End Sub

        'Private Sub TimerRefreshSubjectlist_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRefreshSubjectlist.Tick

        '    MySQLConn.ConnectionString = connstring
        '    Dim adapter As New MySqlDataAdapter
        '    Dim dbdataset As New DataTable
        '    Dim bsource As New BindingSource


        '    Try

        '        MySQLConn.Open()
        '        query = "SELECT * from subjectlist"
        '        comm = New MySqlCommand(query, MySQLConn)
        '        adapter.SelectCommand = comm
        '        adapter.Fill(dbdataset)
        '        bsource.DataSource = dbdataset
        '        DataGridSubj.DataSource = bsource
        '        adapter.Update(dbdataset)



        '        MySQLConn.Close()




        '    Catch ex As MySqlException

        '        MessageBox.Show(ex.Message)

        '    Finally
        '        MySQLConn.Dispose()
        '    End Try

    End Sub

    Private Sub ProfSched_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProfSched.Enter


        labeltip.Text = "List of Subjects Assigned to a Professor"

        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by classcode asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        DataGridSched.Focus()

    End Sub

    Private Sub Prof_Enter(ByVal sender As Object, ByVal e As System.EventArgs)


        labeltip.Text = "List of Professors"
        MySQLConn.ConnectionString = connstring
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            query = "SELECT empnum as 'Employee Code', fname as Firstname, mname as MiddleName, lname as LastName, username as Username from userlist where username!='pass'"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridProf.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

    End Sub
    Private Sub Subjects_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Subjects.Enter

        labeltip.Text = "List of Subjects in Database"
        MySQLConn.ConnectionString = connstring
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeFrom, '%H:%i') as 'From', time_format(TimeTo, '%H:%i') as 'To', subj_unit as 'Unit' from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by classcode asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSubj.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        DataGridSubj.Focus()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        DeleteOrEditSubjectWindow.ShowDialog()


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Cursor = Cursors.WaitCursor
        MySQLConn.Dispose()
        UserWindow.Label2.Text = ""
        reportwindowquery = query
        ReportWindow.Show()
        Me.Cursor = Cursors.Default
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MySQLConn.ConnectionString = connstring
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, TimeFrom as 'From', TimeTo as 'To', subj_unit as 'Unit' from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by room asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSubj.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
        Label1.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Hide()
        SchoolYearSemester.Show()


    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        UserWindow.Label2.Text = ""
        reportwindowquery = query
        ReportWindow.Show()
        Me.Hide()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim dtemp As DataGridViewSelectedRowCollection = DataGridSched.SelectedRows
        Clipboard.SetDataObject(DataGridSched.GetClipboardContent)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBoxSchoolYear.Text = My.Settings.schoolyear
        TextBoxSemester.Text = My.Settings.semester
    End Sub

    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        labeltip.Text = "List of Subjects in Database"
        MySQLConn.ConnectionString = connstring
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            query = "Select empnum as 'Employee Number', fname as 'First Name', mname as 'Middle Name', lname as 'Last Name', username as Username from userlist where username!='pass'"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridProf.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub ProfSchedNoSort_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProfSchedNoSort.CheckedChanged
        If RadioThenRoom.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by day asc, room asc"
        ElseIf RadioThenProf.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by day asc, instructor asc"
        End If
        RadioThenDay.Checked = False
        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by day asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
        RadioThenDay.Enabled = False
        RadioThenRoom.Enabled = True
        RadioThenProf.Enabled = True
        DataGridSched.Focus()

    End Sub

    Private Sub ProfSchedSortRoom_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProfSchedSortRoom.CheckedChanged
        If RadioThenDay.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by room asc, day asc"
        ElseIf RadioThenProf.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by room asc instructor asc"
        End If
        RadioThenRoom.Checked = False
        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by room asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
        RadioThenDay.Enabled = True
        RadioThenRoom.Enabled = False
        RadioThenProf.Enabled = True
        DataGridSched.Focus()
    End Sub

    Private Sub ProfSchedSortProf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfSchedSortProf.CheckedChanged

        If RadioThenDay.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by instructor asc, day asc"
        ElseIf RadioThenRoom.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by instructor asc, room asc"
        End If
        RadioThenProf.Checked = False
        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by instructor asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        RadioThenDay.Enabled = True
        RadioThenRoom.Enabled = True
        RadioThenProf.Enabled = False
        DataGridSched.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FilterWindow.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        UnassignSubjWindow.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Search.Show()
    End Sub

    Private Sub DataGridSubj_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridSubj.CellContentClick

    End Sub

    Private Sub RadioThenDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioThenDay.CheckedChanged
        If ProfSchedSortRoom.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by day asc, room asc"
        ElseIf ProfSchedSortProf.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by day asc, instructor asc"
        End If

        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
        DataGridSched.Focus()

    End Sub

    Private Sub RadioThenRoom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioThenRoom.CheckedChanged
        If ProfSchedNoSort.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by room asc, day asc"
        ElseIf ProfSchedSortProf.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by day asc, instructor asc"
        End If
        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
        DataGridSched.Focus()

    End Sub

    Private Sub RadioThenProf_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioThenProf.CheckedChanged

        If ProfSchedNoSort.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by instructor asc, day asc"
        ElseIf ProfSchedSortRoom.Checked = True Then
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by instructor asc, room asc"
        End If

        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
        DataGridSched.Focus()

    End Sub

    'C:\Program Files\mysql\MySQL Server 5.6\bin\test.exe

    Public Sub ShellandWait(ByVal ProcessPath As String)
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()

            'Free resources associated with this process
            objProcess.Close()
        Catch
            MessageBox.Show("Could not start process " & ProcessPath, "Error")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        MsgBox("Click 'OK' start the backup process.", MsgBoxStyle.Information)
        Me.Cursor = Cursors.WaitCursor
        backupfilelength = 0
        defaultrundir = Directory.GetCurrentDirectory()
        Environment.CurrentDirectory = mysqldir
        'Environment.CurrentDirectory = Environment.GetEnvironmentVariable("programfiles")
        ShellandWait("BackupTool.exe")
        closinglistener = True
        Environment.CurrentDirectory = defaultrundir
        If Dir("C:\Users\" & pcname & "\Desktop\SchedulingSystemDatabaseBackup.7z") <> "" Then
            Dim info As New FileInfo("C:\Users\" & pcname & "\Desktop\SchedulingSystemDatabaseBackup.7z")
            backupfilelength = info.Length
        Else
            MsgBox("The Backup was not successful!")
        End If
        If backupfilelength < 100 Then
            MsgBox("The Backup was not successful!", MsgBoxStyle.Information)
        Else
            MsgBox("The Backup was  successful!", MsgBoxStyle.Information)
        End If
        Me.Cursor = Cursors.Default

    End Sub
End Class


