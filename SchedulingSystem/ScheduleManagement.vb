Imports MySql.Data.MySqlClient
Class ManageSchedule

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property
    Public daytext As String

    Public tempSubjDesc As String
    Public tempSubjUnit As String
    Public tempDaytext As String
    Public tempTimeFrom As String
    Public tempTimeTo As String
    Public tempRoom As String

    Private Sub ScheduleManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Classcodes()
        Panel1.Hide()
    End Sub
    Public Sub Load_Classcodes()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        With ComboBoxClasscode
            Try
                MySQLConn.Open()
                comm = New MySqlCommand("SELECT classcode FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "`", MySQLConn)
                reader = comm.ExecuteReader
                While reader.Read
                    .Items.Add(reader.GetString("classcode"))
                    .AutoCompleteCustomSource.Add(reader.GetString("classcode"))
                End While
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End With
    End Sub

    Private Sub ComboBoxClasscode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxClasscode.SelectedIndexChanged


        'Dim mo As Boolean

        'Dim tu As Boolean

        'Dim we As Boolean

        'Dim th As Boolean

        'Dim fr As Boolean

        'Dim sa As Boolean

        ComboBoxClasscode.Enabled = False
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE classcode=@classcode", MySQLConn)
            comm.Parameters.AddWithValue("classcode", ComboBoxClasscode.Text)
            reader = comm.ExecuteReader
            While reader.Read
                txtSubjDesc.Text = reader.GetString("subj_desc")
                txtUnit.Text = reader.GetString("subj_unit")
                daytext = reader.GetString("day")
                DateTimePickertimefrom.Text = reader.GetString("TimeFrom")
                DateTimePickertimeto.Text = reader.GetString("TimeTo")
                ComboBoxRoom.Text = reader.GetString("room")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

        If daytext.Contains("Mo") Then
            CheckBoxDay_mo.Checked = True
        End If

        If daytext.Contains("Tu") Then
            CheckBoxDay_tu.Checked = True
        End If

        If daytext.Contains("We") Then
            CheckBoxDay_we.Checked = True
        End If

        If daytext.Contains("Th") Then
            CheckBoxDay_th.Checked = True
        End If

        If daytext.Contains("Fr") Then
            CheckBoxDay_fr.Checked = True
        End If

        If daytext.Contains("Sa") Then
            CheckBoxDay_sa.Checked = True
        End If

        btnCancel.Enabled = False
        Panel1.Show()

        tempSubjDesc = txtSubjDesc.Text
        tempSubjUnit = txtUnit.Text
        tempDaytext = daytext
        tempTimeFrom = DateTimePickertimefrom.Text
        tempTimeTo = DateTimePickertimeto.Text
        tempRoom = ComboBoxRoom.Text

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim resetWindow As New ManageSchedule
        Me.Dispose()
        resetWindow.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel1.Click
        Me.Dispose()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click

        Dim change As Boolean = False

        

        Dim mo As Boolean = CheckBoxDay_mo.Checked

        Dim tu As Boolean = CheckBoxDay_tu.Checked

        Dim we As Boolean = CheckBoxDay_we.Checked

        Dim th As Boolean = CheckBoxDay_th.Checked

        Dim fr As Boolean = CheckBoxDay_fr.Checked

        Dim sa As Boolean = CheckBoxDay_sa.Checked

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
            daytext = daytext + "Mo"
        End If

        If tempSubjDesc <> txtSubjDesc.Text Then
            change = True
            Console.WriteLine("1")
        End If

        If tempSubjUnit <> txtUnit.Text Then
            change = True
            Console.WriteLine("2")
        End If

        If tempDaytext <> daytext Then
            change = True
            Console.WriteLine("3")
        End If

        If tempTimeFrom <> DateTimePickertimefrom.Text Then
            change = True
            Console.WriteLine("4")
        End If

        If tempTimeTo <> DateTimePickertimeto.Text Then
            change = True
            Console.WriteLine("5")
        End If

        If tempRoom <> ComboBoxRoom.Text Then
            change = True
            Console.WriteLine("6")
        End If

        If change = True Then
            Dim answer As DialogResult = MsgBox("Are you sure you want to modify the Schedule? Modifying the schedule will automatically unassign it to a Professor. You need to assign it again to prevent schedule conflicts.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
            If answer = Windows.Forms.DialogResult.Yes Then

                Try

                    Dim divider As Integer = daytext.Length / 2 - 1
                    Dim looper As Integer
                    Dim starter As Integer = 0
                    Dim stopper As Integer = 0
                    Dim daycheck As String
                    Dim conflictTimeFrom As String
                    Dim conflictTimeTo As String
                    Dim conflictClasscode As String
                    Dim conflictRoom As String
                    While looper <= divider
                        daycheck = daytext.Substring(starter, 2)
                        starter += 1
                        looper += 1

                        MySQLConn.Open()
                        'comm = New MySqlCommand("SELECT * FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE day like '%" & daycheck & "%' and room='" & ComboBoxRoom.Text & "' AND TimeTo > '" & DateTimePickertimefrom.Value.ToString("HH:mm") & "' and TimeFrom < '" & DateTimePickertimeto.Value.ToString("HH:mm") & "' AND classcode!='" & ComboBoxClasscode.Text & "'", MySQLConn)
                        comm = New MySqlCommand("SELECT * FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE day like '%" & daycheck & "%' and room=@room and TimeTo > @timefrom and TimeFrom < @timeto AND classcode!=@classcode", MySQLConn)
                        comm.Parameters.AddWithValue("room", ComboBoxRoom.Text)
                        comm.Parameters.AddWithValue("timefrom", DateTimePickertimefrom.Value.ToString("HH:mm"))
                        comm.Parameters.AddWithValue("timeto", DateTimePickertimeto.Value.ToString("HH:mm"))
                        comm.Parameters.AddWithValue("classcode", ComboBoxClasscode.Text)
                        reader = comm.ExecuteReader
                        While reader.Read
                            conflictTimeFrom = reader.GetString("TimeFrom")
                            conflictTimeTo = reader.GetString("TimeTo")
                            conflictClasscode = reader.GetString("classcode")
                            conflictRoom = reader.GetString("room")
                            stopper += 1
                        End While
                        If stopper > 0 Then
                            MsgBox("The System has detected a conflict! " & vbCrLf & "" & vbCrLf & "Classcode: " & conflictClasscode & "" & vbCrLf & "Start Time: " & conflictTimeFrom & "" & vbCrLf & "End Time: " & conflictTimeTo & "" & vbCrLf & "Day : " & daycheck & "" & vbCrLf & "Room: " & conflictRoom & "", MsgBoxStyle.Critical, "Occupied")
                            MySQLConn.Close()
                            Exit Sub
                        End If
                        MySQLConn.Close()
                    End While
                    MySQLConn.Close()
                    MySQLConn.Open()
                    comm = New MySqlCommand("UPDATE `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` SET subj_desc=@subjdesc, subj_unit=@subjunit, day=@subjday, TimeFrom=@timefrom, TimeTo=@timeto, room=@room, isAssigned='false' WHERE classcode=@classcode;", MySQLConn)
                    comm.Parameters.AddWithValue("subjdesc", txtSubjDesc.Text)
                    comm.Parameters.AddWithValue("subjunit", txtUnit.Text)
                    comm.Parameters.AddWithValue("subjday", daytext)
                    comm.Parameters.AddWithValue("timefrom", DateTimePickertimefrom.Value.ToString("HH:mm"))
                    comm.Parameters.AddWithValue("timeto", DateTimePickertimeto.Value.ToString("HH:mm"))
                    comm.Parameters.AddWithValue("room", ComboBoxRoom.Text)
                    comm.Parameters.AddWithValue("classcode", ComboBoxClasscode.Text)

                    comm.ExecuteReader()
                    MySQLConn.Close()
                    MySQLConn.Open()
                    comm = New MySqlCommand("DELETE FROM `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE classcode=@classcode", MySQLConn)
                    comm.Parameters.AddWithValue("classcode", ComboBoxClasscode.Text)
                    comm.ExecuteReader()
                    MySQLConn.Close()
                    MsgBox("The Schedule has been modified", MsgBoxStyle.Information, SystemTitle)
                    MySQLConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            
        Else
            MsgBox("No modification to be saved", MsgBoxStyle.Information, SystemTitle)
        End If

    End Sub
End Class