Imports MySql.Data.MySqlClient

Public Class AddSchedule

    Public daytext As String
    Private Sub AddSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancelButton = btnCancel
        Load_Rooms()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim mo As Boolean = CheckBox_AddSchedule_Day_mo.Checked
        Dim tu As Boolean = CheckBox_AddSchedule_Day_tu.Checked
        Dim we As Boolean = CheckBox_AddSchedule_Day_we.Checked
        Dim th As Boolean = CheckBox_AddSchedule_Day_th.Checked
        Dim fr As Boolean = CheckBox_AddSchedule_Day_fr.Checked
        Dim sa As Boolean = CheckBox_AddSchedule_Day_sa.Checked

        Dim TimeStart As DateTime = DateTimePicker_AddSchedule_timefrom.Value.ToString("HH:mm")

        Dim TimeEnd As DateTime = DateTimePicker_AddSchedule_timeto.Value.ToString("HH:mm")

        Dim span As TimeSpan
        span = TimeEnd.Subtract(TimeStart)

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        daytext = ""

        If mo = True Then
            daytext = daytext + "Mo"
        End If

        If tu = True Then
            daytext = daytext + "Tu"
        End If

        If we = True Then
            daytext = daytext + "We"
        End If

        If th = True Then
            daytext = daytext + "Th"
        End If

        If fr = True Then
            daytext = daytext + "Fr"
        End If

        If sa = True Then
            daytext = daytext + "Sa"
        End If

        If txt_AddSchedule_Classcode.Text = "" Or txt_AddSchedule_SubjDesc.Text = "" Or txt_AddSchedule_Unit.Text = "" Or DateTimePicker_AddSchedule_timefrom.Value.ToString = "00:00" Or DateTimePicker_AddSchedule_timeto.Value.ToString = "00:00" Or CboxChooseRoom.Text = "" Or daytext = "" Then
            MsgBox("Please fill-up all fields!", MsgBoxStyle.Critical, SystemTitle)
        ElseIf span.TotalSeconds <= 0 Then
            MsgBox("The Time Start cannto be greater or equal to the Time End", MsgBoxStyle.Critical, SystemTitle)
        Else

            Try
                MySQLConn.Open()
                'query = "insert into subjectlist values('" & AddSubjectTboxClasscode.Text & "', '" & AddSubjectTboxSubj_desc.Text & "', '" & AddSubjectTboxSubj_unit.Text & "', '" & daytext & "', '" & timefrom & "', '" & timeto & "', '" & AddSubjectCBoxRoom.Text & "')"
                comm = New MySqlCommand("SELECT classcode FROM `subjectlist" & SchoolYear & "" & Semester & "` WHERE classcode=@classcode", MySQLConn)
                comm.Parameters.AddWithValue("classcode", txt_AddSchedule_Classcode.Text)
                reader = comm.ExecuteReader

                Dim count As Integer
                count = 0

                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then

                    MsgBox("The Classcode is already used. Please double check your Classcode. If you want to edit a subject, press the edit button in the Subjects Tab.", MsgBoxStyle.Critical, "Duplicate Classcode")

                Else

                    MySQLConn.Close()
                    Dim divider As Integer = daytext.Length / 2 - 1
                    Dim looper As Integer
                    Dim starter As Integer = 0
                    Dim stopper As Integer = 0
                    Dim daycheck As String
                    Dim conflictTimeFrom As String
                    Dim conflictTimeTo As String
                    Dim conflictClasscode As String
                    While looper <= divider
                        MySQLConn.Close()
                        daycheck = daytext.Substring(starter, 2)
                        MySQLConn.Open()

                        starter = starter + 2
                        looper = looper + 1
                        comm = New MySqlCommand("SELECT * FROM `subjectlist" & SchoolYear & "" & Semester & "` WHERE day like '%" & daycheck & "%' and room=@room and TimeTo > @timefrom and TimeFrom < @timeto;", MySQLConn)
                        comm.Parameters.AddWithValue("room", CboxChooseRoom.Text)
                        comm.Parameters.AddWithValue("timeto", DateTimePicker_AddSchedule_timeto.Value.ToString("HH:mm"))
                        comm.Parameters.AddWithValue("timefrom", DateTimePicker_AddSchedule_timefrom.Value.ToString("HH:mm"))

                        reader = comm.ExecuteReader

                        While reader.Read
                            conflictTimeFrom = reader.GetString("TimeFrom")
                            conflictTimeTo = reader.GetString("TimeTo")
                            conflictClasscode = reader.GetString("classcode")
                            stopper += 1
                        End While
                        If stopper > 0 Then
                            MsgBox("The System has detected a conflict! " & vbCrLf & "" & vbCrLf & "Classcode: " & conflictClasscode & "" & vbCrLf & "Start Time: " & conflictTimeFrom & "" & vbCrLf & "End Time: " & conflictTimeTo & "" & vbCrLf & "Day : " & daycheck & "", MsgBoxStyle.Critical, "Occupied")
                            MySQLConn.Close()
                            Exit Sub
                        End If
                        If starter = daytext.Length Then

                            MySQLConn.Close()
                            MySQLConn.Open()

                            comm = New MySqlCommand("INSERT INTO `subjectlist" & SchoolYear & "" & Semester & "` VALUES(@classcode, @subjDesc, @subjUnit, '" & daytext & "', @timefrom, @timeto, @room, 'false')", MySQLConn)
                            comm.Parameters.AddWithValue("classcode", txt_AddSchedule_Classcode.Text)
                            comm.Parameters.AddWithValue("subjDesc", txt_AddSchedule_SubjDesc.Text)
                            comm.Parameters.AddWithValue("subjUnit", txt_AddSchedule_Unit.Text)
                            comm.Parameters.AddWithValue("timefrom", DateTimePicker_AddSchedule_timefrom.Value.ToString("HH:mm"))
                            comm.Parameters.AddWithValue("timeto", DateTimePicker_AddSchedule_timeto.Value.ToString("HH:mm"))
                            comm.Parameters.AddWithValue("room", CboxChooseRoom.Text)
                            reader = comm.ExecuteReader
                            'If starter = daytext.Length Then
                            MsgBox("The Subject has been saved to the Database and is now ready to be assigned to a Professor!", MsgBoxStyle.Information, "New Subject")
                            'End If
                            MySQLConn.Close()
                        End If

                    End While

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub txt_AddSchedule_Unit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_AddSchedule_Unit.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar))
        If e.Handled = True Then
            Beep()
        End If
    End Sub

    Private Sub txt_AddSchedule_Unit_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txt_AddSchedule_Unit.PreviewKeyDown
        If e.KeyCode = Keys.Back Then
            If txt_AddSchedule_Unit.Text.Length > 0 Then
                txt_AddSchedule_Unit.Text = txt_AddSchedule_Unit.Text.Substring(0, txt_AddSchedule_Unit.Text.Length - 1)
                txt_AddSchedule_Unit.Select(txt_AddSchedule_Unit.Text.Length, 0)
            End If
        End If
    End Sub
    Public Sub Load_Rooms()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM `roomlist" + SchoolYear & Semester + "`", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                CboxChooseRoom.Items.Add(reader.GetString("room"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        If CboxChooseRoom.Items.Count = 0 Then
            MsgBox("There are no rooms available. Please add a room first!", MsgBoxStyle.Critical, SystemTitle)
            Me.Dispose()
        End If
    End Sub
End Class