Imports MySql.Data.MySqlClient
Imports System.IO
Imports Microsoft.Win32

Class SchoolYearSemester

    Public hovercheck As Boolean = False
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property


    Private Sub SchoolYearSemester_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancelButton = btnClose
        ComboBoxSchoolYear.Text = SchoolYear
        ComboBoxSemester.Text = Semester
    End Sub

    Private Sub SchoolYearSemester_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AdminPage.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM existingschoolyearsemester WHERE schoolyear=@schoolyear AND semester=@semester", MySQLConn)
            comm.Parameters.AddWithValue("schoolyear", ComboBoxSchoolYear.Text)
            comm.Parameters.AddWithValue("semester", ComboBoxSemester.Text)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count += 1
            End While
            MySQLConn.Close()
            If count > 0 Then
                MsgBox("Error creating the School Year and Semester because it already exists!", MsgBoxStyle.Exclamation, SystemTitle)
            Else
                Dim copyexist As DialogResult = MsgBox("Do you want to copy subjects from a previous School Year and Semester?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
                If copyexist = DialogResult.Yes Then
                    Me.Hide()
                    PreviousSchoolYearSemester.ShowDialog()
                Else
                    MySQLConn.Open()
                    comm = New MySqlCommand("CREATE TABLE `subjectlist" & ComboBoxSchoolYear.Text & "" & ComboBoxSemester.Text & "` LIKE subjectlist;CREATE TABLE `assignedsubj" & ComboBoxSchoolYear.Text & "" & ComboBoxSemester.Text & "` LIKE assignedsubj;", MySQLConn)
                    comm.ExecuteReader()
                    MySQLConn.Close()
                    MySQLConn.Open()
                    comm = New MySqlCommand("INSERT INTO existingschoolyearsemester VALUES(@schoolyear, @semester, @isActive);", MySQLConn)
                    comm.Parameters.AddWithValue("schoolyear", ComboBoxSchoolYear.Text)
                    comm.Parameters.AddWithValue("semester", ComboBoxSemester.Text)
                    comm.Parameters.AddWithValue("isActive", "false")
                    comm.ExecuteReader()
                    MsgBox("The School Year and Semester has been successfully created. You can now Load it by clicking the 'Load' Button.", MsgBoxStyle.Information, SystemTitle)
                    MySQLConn.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Dim confirmDelete As DialogResult = MsgBox("Are you sure you want to delete the selected School Year and Semester. This action is irreversible unless you have the latest database backup", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
        If ComboBoxSchoolYear.Text = SchoolYear And ComboBoxSemester.Text = Semester Then
            MsgBox("You cannot delete the selected School Year and Semester because it is Active, activate another School Year and Semester so that you can delete this.", MsgBoxStyle.Critical, SystemTitle)
        ElseIf confirmDelete = DialogResult.Yes Then
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If
            MySQLConn.ConnectionString = connstring & database

            Try
                MySQLConn.Open()
                comm = New MySqlCommand("DROP TABLE `assignedsubj" & ComboBoxSchoolYear.Text & "" & ComboBoxSemester.Text & "`;DROP TABLE `subjectlist" & ComboBoxSchoolYear.Text & "" & ComboBoxSemester.Text & "`;DELETE FROM existingschoolyearsemester WHERE schoolyear=@schoolyear AND semester=@semester;", MySQLConn)
                comm.Parameters.AddWithValue("schoolyear", ComboBoxSchoolYear.Text)
                comm.Parameters.AddWithValue("semester", ComboBoxSemester.Text)
                comm.ExecuteReader()
                MsgBox("The School Year and Semester has been successfully deleted!", MsgBoxStyle.Information, SystemTitle)
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If

    End Sub

    Private Sub ButtonDelete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDelete.MouseHover
        If hovercheck = False Then
            MsgBox("WARNING: This Delete button was created for you to permanently delete the whole Tables that includes the Assigned Subjects for Professors and the Subjectlist table for a particular Schoolyear and Semester. USE WITH EXTREME CAUTION!", MsgBoxStyle.Critical, "DISCLAIMER")
            hovercheck = True
        End If
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM existingschoolyearsemester WHERE schoolyear=@schoolyear AND semester=@semester;", MySQLConn)
            With comm.Parameters
                .AddWithValue("schoolyear", ComboBoxSchoolYear.Text)
                .AddWithValue("semester", ComboBoxSemester.Text)
            End With
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count += 1
            End While
            If count > 0 Then
                SchoolYear = ComboBoxSchoolYear.Text
                Semester = ComboBoxSemester.Text
                MySQLConn.Close()
                MySQLConn.Open()
                comm = New MySqlCommand("UPDATE existingschoolyearsemester SET isActive='false';UPDATE existingschoolyearsemester SET isActive='true' WHERE schoolyear=@schoolyear AND semester=@semester;", MySQLConn)
                With comm.Parameters
                    .AddWithValue("schoolyear", ComboBoxSchoolYear.Text)
                    .AddWithValue("semester", ComboBoxSemester.Text)
                End With
                comm.ExecuteReader()
                MsgBox("The School Year and Semester is now loaded!", MsgBoxStyle.Information, SystemTitle)
                MySQLConn.Close()
            Else
                MsgBox("The School Year and Semester does not exist. Click the 'Create' button first!", MsgBoxStyle.Critical, SystemTitle)
            End If
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        BackupDB()
    End Sub
    Public Sub setFileAssociation()
        Dim root As RegistryKey = Registry.ClassesRoot
        Dim filetype As RegistryKey = root.OpenSubKey(".ssbackup")
        If filetype Is Nothing Then 'Check if file is associated
            Dim newReg As RegistryKey
            'Create new Registry Key
            newReg = root.CreateSubKey(".ssbackup")
            'Set Unique file type name
            newReg.SetValue("", "ssbackup.test")
            'Create file type information Key
            Dim info As RegistryKey = root.CreateSubKey("ssbackup.test")
            'Set default value to file type Description
            info.SetValue("", "Scheduling System Backup File")
            'Create shell Key to contain all verbs. (Context Menu)
            Dim shell As RegistryKey = info.CreateSubKey("shell")
            'Create a subkey for the "Open" verb
            Dim open As RegistryKey = shell.CreateSubKey("Open")
            'Set the menu name against the key
            open.SetValue("", "&Open Document")
            'Create and set the command string
            newReg = open.CreateSubKey("command")
            newReg.SetValue("", Application.ExecutablePath & " ""%l"" ")
            'Assign a default icon
            newReg = info.CreateSubKey("DefaultIcon")
            newReg.SetValue("", Application.ExecutablePath + ",0")
            MsgBox("You can now open the file", MsgBoxStyle.Information, SystemTitle)
        End If
    End Sub
    Public Sub BackupDB()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim DBbackup As New MySqlBackup
        MySQLConn.ConnectionString = connstring & database
        Try
            If SFD_Database.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                MySQLConn.Open()
                comm = New MySqlCommand
                comm.Connection = MySQLConn
                DBbackup = New MySqlBackup(comm)
                With DBbackup
                    .ExportInfo.AddCreateDatabase = True
                    .ExportInfo.EnableEncryption = True
                    .ExportInfo.EncryptionPassword = "a"
                    .ExportToFile("db.sql")
                End With
                MySQLConn.Close()
            End If
            Dim archive As New Process
            With archive
                With .StartInfo
                    .WindowStyle = ProcessWindowStyle.Hidden
                    .CreateNoWindow = True
                    .FileName = "7z.exe"
                    .Arguments = "a backup.7z db.sql -p123 -mhe"
                End With
                .Start()
                .WaitForExit()
            End With
            Dim files As New FileInfo("backup.7z")
            If File.Exists(SFD_Database.FileName) Then
                File.Delete(SFD_Database.FileName)
            End If
            files.MoveTo(SFD_Database.FileName)
            Dim dbfile As New FileInfo("db.sql")
            dbfile.Delete()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class