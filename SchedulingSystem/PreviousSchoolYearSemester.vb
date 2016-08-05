Imports MySql.Data.MySqlClient


Public Class PreviousSchoolYearSemester

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Dispose()
        Dim back As New SchoolYearSemester
        back.Show()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MySQLConn.ConnectionString = connstring

        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Please select a SchoolYear and a Semester first!", MsgBoxStyle.Critical)
        Else

            Try
                MySQLConn.Open()
                query = SchoolYearSemester.tablecreationquerysubj
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MySQLConn.Open()
                query = "insert into `subjectlist" & SchoolYearSemester.bringoutcomboschoolyear & "" & SchoolYearSemester.bringoutcombosemester & "` select * from `subjectlist" & ComboBox1.Text & "" & ComboBox2.Text & "`"
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MySQLConn.Open()
                query = SchoolYearSemester.tablecreationqueryassignedsubj
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MySQLConn.Open()
                query = "insert into existingschoolyearsemester values('" & SchoolYearSemester.bringoutcomboschoolyear & "', '" & SchoolYearSemester.bringoutcombosemester & "')"
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MySQLConn.Open()
                query = "update `subjectlist" & SchoolYearSemester.bringoutcomboschoolyear & "" & SchoolYearSemester.bringoutcombosemester & "` set IsAssigned='false'"
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("A Scheduling table with previous subjects was created and is now avaliable for you to be loaded.", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                MySQLConn.Dispose()
                Me.Dispose()
                SchoolYearSemester.Show()

            End Try
        End If

    End Sub

    Private Sub PreviousSchoolYearSemester_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()

        End If

        'MySQLConn.ConnectionString = connstring

        'Try
        '    MySQLConn.Open()
        '    query = "select * from existingschoolyearsemester"
        '    comm = New MySqlCommand(query, MySQLConn)
        '    reader = comm.ExecuteReader

        '    While reader.Read
        '        ComboBox1.Items.Add(reader.GetString("schoolyear"))
        '    End While
        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'Finally
        '    MySQLConn.Dispose()

        'End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "select semester from existingschoolyearsemester where schoolyear='" & ComboBox1.Text & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            ComboBox2.Items.Clear()
            Dim count As Integer
            count = 0
            While reader.Read
                ComboBox2.Items.Add(reader.GetString("semester"))
                count += 1
            End While
            If count = 0 Then
                MsgBox("There are no Semeters available for the Schoolyear " & ComboBox1.Text & "", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            MySQLConn.Dispose()

        End Try
    End Sub
End Class