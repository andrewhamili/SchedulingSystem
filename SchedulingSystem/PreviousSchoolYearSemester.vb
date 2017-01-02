Imports MySql.Data.MySqlClient
Public Class PreviousSchoolYearSemester

    Private Sub ComboBoxSchoolYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSchoolYear.SelectedIndexChanged
        ComboBoxSemester.Items.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT semester FROM existingschoolyearsemester WHERE schoolyear=@schoolyear", MySQLConn)
            comm.Parameters.AddWithValue("schoolyear", ComboBoxSchoolYear.Text)
            reader = comm.ExecuteReader
            Dim count = 0
            While reader.Read
                count += 1
                ComboBoxSemester.Items.Add(reader.GetString("semester"))
            End While
            If count = 0 Then
                MsgBox("There are no exsting semesters to use from the School Year " & ComboBoxSchoolYear.Text & "", MsgBoxStyle.Critical, SystemTitle)
            End If
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("CREATE TABLE `assignedsubj" & SchoolYearSemester.ComboBoxSchoolYear.Text & "" & SchoolYearSemester.ComboBoxSemester.Text & "` LIKE assignedsubj;CREATE TABLE `subjectlist" & SchoolYearSemester.ComboBoxSchoolYear.Text & "" & SchoolYearSemester.ComboBoxSemester.Text & "` LIKE subjectlist;INSERT INTO `subjectlist" & SchoolYearSemester.ComboBoxSchoolYear.Text & "" & SchoolYearSemester.ComboBoxSemester.Text & "` SELECT * FROM `subjectlist" & ComboBoxSchoolYear.Text & "" & ComboBoxSemester.Text & "`;UPDATE `subjectlist" & SchoolYearSemester.ComboBoxSchoolYear.Text & "" & ComboBoxSemester.Text & "` SET isAssigned='false';INSERT INTO existingschoolyearsemester VALUES(@schoolyear, @semester, @isActive)", MySQLConn)
            With comm.Parameters
                .AddWithValue("schoolyear", SchoolYearSemester.ComboBoxSchoolYear.Text)
                .AddWithValue("semester", SchoolYearSemester.ComboBoxSemester.Text)
                .AddWithValue("isActive", "false")
            End With
            comm.ExecuteReader()
            MsgBox("The SchoolYear and Semester has been successfully created! You can now load it.", MsgBoxStyle.Information, SystemTitle)

            MySQLConn.Close()
            Me.Dispose()
            SchoolYearSemester.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class