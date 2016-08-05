Imports MySql.Data.MySqlClient

Public Class AddSubjectWindow
    Public timer As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click


        Dim mo As Boolean = CheckBoxMo.Checked
        Dim tu As Boolean = CheckBoxTu.Checked
        Dim we As Boolean = CheckBoxWe.Checked
        Dim th As Boolean = CheckBoxTh.Checked
        Dim fr As Boolean = CheckBoxFr.Checked
        Dim sa As Boolean = CheckBoxSa.Checked

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





        If AddSubjectTboxClasscode.Text = "" Or AddSubjectTboxSubj_desc.Text = "" Or AddSubjectTboxSubj_unit.Text = "" Or AddSubjectCBoxRoom.Text = "" Or daytext = "" Or MaskedTextBoxTimeFrom.Text = "  :" Or MaskedTextBoxTimeTo.Text = "  :" Then
            MsgBox("Please fill-up all the filelds")
        Else



            Try


                MySQLConn.Open()
                query = "select classcode from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode='" & AddSubjectTboxClasscode.Text & "'"
                'query = "insert into subjectlist values('" & AddSubjectTboxClasscode.Text & "', '" & AddSubjectTboxSubj_desc.Text & "', '" & AddSubjectTboxSubj_unit.Text & "', '" & daytext & "', '" & timefrom & "', '" & timeto & "', '" & AddSubjectCBoxRoom.Text & "')"
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader

                Dim count As Integer
                count = 0

                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then

                    MsgBox("The Classcode is already used. Please double ckheck your Classcode. If you want to edit a subject, press the edit button in the Subjects Tab.", MsgBoxStyle.Critical, "Duplicate Classcode")

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
                        query = "select * from  `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` where room='" & AddSubjectCBoxRoom.Text & "' and day like '%" & daycheck & "%' and ('" & MaskedTextBoxTimeFrom.Text & "' >=TimeFrom and '" & MaskedTextBoxTimeFrom.Text & "' < Timeto)"
                        starter = starter + 2
                        looper = looper + 1
                        comm = New MySqlCommand(query, MySQLConn)
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
                            query = "insert into `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` values('" & AddSubjectTboxClasscode.Text & "', '" & AddSubjectTboxSubj_desc.Text & "', '" & AddSubjectTboxSubj_unit.Text & "', '" & daytext & "', '" & MaskedTextBoxTimeFrom.Text & "', '" & MaskedTextBoxTimeTo.Text & "', '" & AddSubjectCBoxRoom.Text & "', 'false')"
                            comm = New MySqlCommand(query, MySQLConn)
                            reader = comm.ExecuteReader
                            'If starter = daytext.Length Then
                            MsgBox("The Subject has been saved to the Database and is now ready to be assigned to a Professor!", MsgBoxStyle.Information, "New Subject")
                            'End If
                            MySQLConn.Close()


                        End If

                    End While

                End If

            Catch ex As Exception

                'MsgBox("You may be missing some fileds, please double check!", MsgBoxStyle.Exclamation, "Insufficient")
                MsgBox(ex.Message)

            Finally
                MySQLConn.Dispose()

            End Try

            Dim adapter As New MySqlDataAdapter
            Dim dbdataset As New DataTable
            Dim bsource As New BindingSource


            Try

                MySQLConn.Open()
                query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeFrom, '%H:%i') as 'From', time_format(TimeTo, '%H:%i') as 'To', subj_unit as 'Unit' from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by room asc"
                comm = New MySqlCommand(query, MySQLConn)
                adapter.SelectCommand = comm
                adapter.Fill(dbdataset)
                bsource.DataSource = dbdataset
                Form2.DataGridSubj.DataSource = bsource
                adapter.Update(dbdataset)



                MySQLConn.Close()




            Catch ex As Exception

                MessageBox.Show(ex.Message)

            Finally
                MySQLConn.Dispose()

            End Try


        End If





    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If timer = 5 Then

            If ButtonSave.BackColor = Color.FromArgb(240, 240, 240) Then
                ButtonSave.BackColor = Color.LightGreen
            Else
                ButtonSave.BackColor = Color.FromArgb(240, 240, 240)
            End If
            timer = 0
        End If
        timer += 1

    End Sub

    Private Sub AddSubjectWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        NotifyIcon1.BalloonTipText = "Test"
    End Sub

    Private Sub AddSubjectWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True



    End Sub

   

End Class