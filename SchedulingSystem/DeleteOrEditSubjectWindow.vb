Imports MySql.Data.MySqlClient

Public Class DeleteOrEditSubjectWindow

    Private Sub DeleteOrEditSubjectWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MySQLConn.ConnectionString = connstring


        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        
        Label11.Hide()
        Label12.Hide()

        ModifySubjectTboxSubj_desc.Hide()


        CheckBoxMo.Hide()
        CheckBoxTu.Hide()
        CheckBoxWe.Hide()
        CheckBoxTh.Hide()
        CheckBoxFr.Hide()
        CheckBoxSa.Hide()
        ModifySubjectCBoxRoom.Hide()
        MaskedTextBoxUnit.Hide()
        MaskedTextBoxTimeFrom.Hide()
        MaskedTextBoxTimeTo.Hide()



        Try
            MySQLConn.Open()
            query = "select * from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "`"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer
            count = 0

            While reader.Read

                ModifySubjChosseClassCode.Items.Add(reader.GetString("classcode"))
                ModifySubjChosseClassCode.AutoCompleteCustomSource.Add(reader.GetString("classcode"))

            End While

        Catch ex As Exception

            MsgBox(ex.Message)


        Finally
            MySQLConn.Close()
        End Try



    End Sub

    Private Sub ModifySubjChosseClassCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifySubjChosseClassCode.SelectedIndexChanged
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        
        Label11.Show()
        Label12.Show()

        ModifySubjectTboxSubj_desc.Show()


        CheckBoxMo.Show()
        CheckBoxTu.Show()
        CheckBoxWe.Show()
        CheckBoxTh.Show()
        CheckBoxFr.Show()
        CheckBoxSa.Show()
        MaskedTextBoxUnit.Show()
        MaskedTextBoxTimeFrom.Show()
        MaskedTextBoxTimeTo.Show()
        ModifySubjChosseClassCode.Enabled = False
        ModifySubjectCBoxRoom.Show()

        

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "Select * from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode='" & ModifySubjChosseClassCode.Text & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer
            count = 0

            While reader.Read
                ModifySubjectTboxSubj_desc.Text = reader.GetString("subj_desc")
                MaskedTextBoxUnit.Text = reader.GetString("subj_unit")
                daytext = reader.GetString("day")
                MaskedTextBoxTimeFrom.Text = reader.GetString("TimeFrom")
                MaskedTextBoxTimeTo.Text = reader.GetString("TimeTo")
                ModifySubjectCBoxRoom.Text = reader.GetString("room")

            End While

            MySQLConn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()

        End Try

        If daytext.Contains("Mo") Then
            CheckBoxMo.Checked = True
        End If

        If daytext.Contains("Tu") Then
            CheckBoxTu.Checked = True
        End If

        If daytext.Contains("We") Then
            CheckBoxWe.Checked = True
        End If

        If daytext.Contains("Th") Then
            CheckBoxTh.Checked = True
        End If

        If daytext.Contains("Fr") Then
            CheckBoxFr.Checked = True
        End If

        If daytext.Contains("Sa") Then
            CheckBoxSa.Checked = True
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim resetwindow As New DeleteOrEditSubjectWindow
        Me.Dispose()
        resetwindow.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
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

        MySQLConn.ConnectionString = connstring

        Try
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
                query = "select * from  `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` where room='" & ModifySubjectCBoxRoom.Text & "' and day like '%" & daycheck & "%' and ('" & MaskedTextBoxTimeFrom.Text & "' >=TimeFrom and '" & MaskedTextBoxTimeFrom.Text & "' < Timeto) and classcode!='" & ModifySubjChosseClassCode.Text & "'"
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

                    Dim message As Integer
                    message = MsgBox("Are  you sure you want to modify this Subject's details?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Modify")
                    If message = 6 Then

                        MySQLConn.Close()
                        MySQLConn.Open()
                        query = "update `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` set subj_desc='" & ModifySubjectTboxSubj_desc.Text & "', subj_unit='" & MaskedTextBoxUnit.Text & "', day='" & daytext & "', TimeFrom='" & MaskedTextBoxTimeFrom.Text & "', TimeTo='" & MaskedTextBoxTimeTo.Text & "', room='" & ModifySubjectCBoxRoom.Text & "', isassigned='false' where classcode='" & ModifySubjChosseClassCode.Text & "'"
                        comm = New MySqlCommand(query, MySQLConn)
                        reader = comm.ExecuteReader
                        MsgBox("The Subject has been saved to the Database and is now ready to be assigned to a Professor!", MsgBoxStyle.Information, "New Subject")
                        MySQLConn.Close()
                        MySQLConn.Open()
                        query = "delete from`assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode='" & ModifySubjChosseClassCode.Text & "'"
                        comm = New MySqlCommand(query, MySQLConn)
                        reader = comm.ExecuteReader
                        MsgBox("If the subject was previously assigned to a professor, it will be remove from their list of assigned subjects. You need to reassign the subject again to avoid conflicts.", MsgBoxStyle.Information)
                        MySQLConn.Close()

                    End If



                End If

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        query = "update `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` set subj_desc='" & ModifySubjectTboxSubj_desc.Text & "', subj_unit='" & MaskedTextBoxUnit.Text & "', day='" & daytext & "', TimeFrom='" & MaskedTextBoxTimeFrom.Text & "', TimeTo='" & MaskedTextBoxTimeTo.Text & "', room='" & ModifySubjectCBoxRoom.Text & "' where classcode='" & ModifySubjChosseClassCode.Text & "'"
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If ModifySubjChosseClassCode.Text = "" Then
            MsgBox("Please select a classcode first!", MsgBoxStyle.Critical, "No Classcode Selected")
        Else


            MySQLConn.ConnectionString = connstring
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to delete this subject?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete?")
            If ans = 6 Then

                Try
                    MySQLConn.Open()
                    query = "delete from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode='" & ModifySubjChosseClassCode.Text & "'"
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    MsgBox("Subject deleted", MsgBoxStyle.Information)
                    MySQLConn.Close()
                    MySQLConn.Open()
                    query = "delete from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode='" & ModifySubjChosseClassCode.Text & "'"
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    MsgBox("If the subject was previously assigned to a professor, it will be remove from their list of assigned subject.", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    MySQLConn.Dispose()
                End Try
                Dim deletesubject As New DeleteOrEditSubjectWindow
                Me.Dispose()
                deletesubject.ShowDialog()
            Else

            End If
        End If

    End Sub
End Class