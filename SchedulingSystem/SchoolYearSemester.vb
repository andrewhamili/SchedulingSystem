Imports MySql.Data.MySqlClient
Imports System.IO

Public Class SchoolYearSemester

    Public tablecreationquerysubj As String
    Public tablecreationqueryassignedsubj As String
    Public bringoutcomboschoolyear As String
    Public bringoutcombosemester As String



    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property

    Private Sub SchoolYearSemester_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hovercheck = False
        ComboBoxSchoolyear.Text = My.Settings.schoolyear
        ComboBoxSemester.Text = My.Settings.semester
        If Dir("C:\Users\" & pcname & "\Desktop\SchedulingSystemDAtabaseBackup.7z") <> "" Then
            Dim info As String
            info = System.IO.File.GetLastWriteTime("C:\Users\" & pcname & "\Desktop\SchedulingSystemDAtabaseBackup.7z").ToString
            Label4.Text = "Last Backup created:"
            Label5.Text = info
        Else
            Label4.Text = "No backup file detected."
        End If





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
            MySQLConn.Dispose()

        End If

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "select * from existingschoolyearsemester where schoolyear='" & ComboBoxSchoolyear.Text & "' and semester='" & ComboBoxSemester.Text & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As String
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then

                If ComboBoxSchoolyear.Text = "" Or ComboBoxSemester.Text = "" Then
                    MsgBox("Make sure you have selected a School Year and a Semester", MsgBoxStyle.Critical)
                Else
                    MySQLConn.Close()

                    My.Settings.schoolyear = ComboBoxSchoolyear.Text
                    My.Settings.semester = ComboBoxSemester.Text
                    MsgBox("The active schoolyear and semester was successfully changed.", MsgBoxStyle.Information)
                    MsgBox("Navigate through the tabs under Schedule Management tabs to refresh", MsgBoxStyle.Information)
                    Form2.TextBoxSchoolYear.Text = ComboBoxSchoolyear.Text
                    Form2.TextBoxSchoolYear.Text = ComboBoxSemester.Text
                End If
            Else
                MsgBox("The selected SchoolYear and Semester does not exist, you can create a new SchoolYear and Semester by clicking the 'Create' Button", MsgBoxStyle.Critical)

            End If
            MySQLConn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Dispose()
        Form2.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
            MySQLConn.Dispose()
        End If

        If ComboBoxSchoolyear.Text = "" And ComboBoxSemester.Text = "" Then
            MsgBox("Please select a Schoolyear and a Semester to be created.", MsgBoxStyle.Critical)
        Else



            Try
                MySQLConn.Open()
                query = "select * from existingschoolyearsemester where schoolyear='" & ComboBoxSchoolyear.Text & "' and semester='" & ComboBoxSemester.Text & "'"
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count += 1
                End While
                If count = 1 Then
                    MsgBox("Schoolyear " & ComboBoxSchoolyear.Text & "" & ComboBoxSemester.Text & " has been previously added to the Database and is readey to be loaded.", MsgBoxStyle.Information, "Duplication")
                Else
                    Dim ans As Integer
                    a = MsgBox("Do you want to copy existing Subjects from a previous Semester?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
                    If a = 7 Then
                        MySQLConn.Close()
                        MySQLConn.Open()
                        ProgressBar1.Value = 20
                        query = "create table `subjectlist" & ComboBoxSchoolyear.Text & "" & ComboBoxSemester.Text & "` like subjectlist"
                        comm = New MySqlCommand(query, MySQLConn)
                        reader = comm.ExecuteReader
                        ProgressBar1.Value = 25
                        MySQLConn.Close()
                        MySQLConn.Open()
                        query = "create table `assignedsubj" & ComboBoxSchoolyear.Text & "" & ComboBoxSemester.Text & "` like assignedsubj"
                        comm = New MySqlCommand(query, MySQLConn)
                        reader = comm.ExecuteReader
                        ProgressBar1.Value = 50
                        MySQLConn.Close()

                        MySQLConn.Open()
                        query = "insert into existingschoolyearsemester values('" & ComboBoxSchoolyear.Text & "', '" & ComboBoxSemester.Text & "')"
                        comm = New MySqlCommand(query, MySQLConn)
                        reader = comm.ExecuteReader
                        ProgressBar1.Value = 75
                        MySQLConn.Close()
                        ProgressBar1.Value = 100
                        MsgBox("A new Scheduling table is now created and is ready to be loaded.", MsgBoxStyle.Information)
                        ProgressBar1.Value = 0
                    ElseIf a = 6 Then
                        Me.Hide()
                        PreviousSchoolYearSemester.Show()
                        tablecreationqueryassignedsubj = "create table `assignedsubj" & ComboBoxSchoolyear.Text & "" & ComboBoxSemester.Text & "` like assignedsubj"
                        tablecreationquerysubj = "create table `subjectlist" & ComboBoxSchoolyear.Text & "" & ComboBoxSemester.Text & "` like subjectlist"
                        bringoutcomboschoolyear = ComboBoxSchoolyear.Text
                        bringoutcombosemester = ComboBoxSemester.Text
                    Else
                        MsgBox("Cretion cancelled by the user.", MsgBoxStyle.Information)
                    End If
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Me.Dispose()
        Form2.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
            MySQLConn.Dispose()
        End If

        MySQLConn.ConnectionString = connstring

        If ComboBoxSchoolyear.Text = "" And ComboBoxSemester.Text = "" Then

            MsgBox("Make sure you have selected a Schoolyear and a Semester.", MsgBoxStyle.Information, "Blank")
        ElseIf ComboBoxSchoolyear.Text = My.Settings.schoolyear And ComboBoxSemester.Text = My.Settings.semester Then
            MsgBox("The Selected Schoolyear and Semester cannot be deleted because it is the active Schoolyear and Semester. Load a different Schoolyear and Semester first!", MsgBoxStyle.Critical)
        Else



            Try
                ProgressBar1.Value = 33.3
                MySQLConn.Open()
                query = "select * from existingschoolyearsemester where schoolyear='" & ComboBoxSchoolyear.Text & "' and semester='" & ComboBoxSemester.Text & "'"
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count += 1
                End While
                If count = 1 Then
                    MySQLConn.Close()
                    MySQLConn.Open()
                    query = "drop table `subjectlist" & ComboBoxSchoolyear.Text & "" & ComboBoxSemester.Text & "`"
                    Labeltip.Text = "Deleting Subjectlist..."
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()

                    ProgressBar1.Value = 66.6

                    MySQLConn.Open()
                    query = "drop table `assignedsubj" & ComboBoxSchoolyear.Text & "" & ComboBoxSemester.Text & "`"
                    Labeltip.Text = "Deleting Assigned Subjects..."
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()

                    ProgressBar1.Value = 99.9

                    MySQLConn.Open()
                    query = "delete from existingschoolyearsemester where schoolyear='" & ComboBoxSchoolyear.Text & "' and semester='" & ComboBoxSemester.Text & "'"
                    Labeltip.Text = "Updating Table Records..."
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    MsgBox("The Schoolyear and Semester was  deleted Successfully", MsgBoxStyle.Information, "Delete")
                    ProgressBar1.Value = 100
                Else
                    MsgBox("The selected Schoolyear and Semester cannot be deleted because it does not exist!", MsgBoxStyle.Critical, "Nothing to Delete")
                End If
                ProgressBar1.Value = 0
                Labeltip.Text = ""
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                MySQLConn.Dispose()
            End Try
        End If


    End Sub

    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseHover



        If hovercheck = False Then
            MsgBox("WARNING: This Delete button was created for you to permanently delete the whole Tables that includes the Assigned Subjects for Professors and the Subjectlist table for a particular Schoolyear and Semester. USE WITH EXTREME CAUTION!", MsgBoxStyle.Critical, "DISCLAIMER")
            hovercheck = True
        End If
    End Sub

    Private Sub Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backup.Click
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
        Label5.Text = Format(Now)
    End Sub

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

    Private Sub Rrestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rrestore.Click
        If Label4.Text <> "No backup file detected." Then
            Dim resp As Integer = MsgBox("Are you sure you want to restore the previous Database Backup? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
            If resp = 6 Then
                closinglistener = True
                Me.Cursor = Cursors.WaitCursor
                backupfilelength = 0
                defaultrundir = Directory.GetCurrentDirectory()
                Environment.CurrentDirectory = mysqldir
                'Environment.CurrentDirectory = Environment.GetEnvironmentVariable("programfiles")
                ShellandWait("RestoreTool.exe")
                ShellandWait("SettingsResetTool")
                'Environment.CurrentDirectory = defaultrundir
                Me.Cursor = Cursors.Default
                MsgBox("The Database restoration was successful.", MsgBoxStyle.Information)
                Application.Restart()



            Else
                MsgBox("The Database restoration was cancelled.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Could not find a backup file on the Desktop Directory. Please copy the Backup file on your Desktop (C:\Users\" & pcname & "\Desktop\) first!", MsgBoxStyle.Critical, "File Not Found!")
        End If



    End Sub
End Class