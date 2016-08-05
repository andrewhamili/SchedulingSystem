Imports MySql.Data.MySqlClient

Public Class AssignSchedWindow
    Public pendingunit As Integer
    Public timer As Integer

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property

    Private Sub AssignSchedWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        RadioButton1.Checked = True
        AcceptButton = AssignSubjAddToGrid
        CancelButton = ButtonCancelAssignSched

        MySQLConn.ConnectionString = connstring

        LabelProfEmpCode.Hide()
        LabelProfFname.Hide()
        LabelProfLname.Hide()
        AssignSchedLabelSubj_desc.Hide()
        AssignSchedLabelSubj_day.Hide()
        AssignSchedLabelTimeFrom.Hide()
        AssignSchedLabelTimeTo.Hide()
        AssignSchedLabelRoom.Hide()
        AssignSchedLabelUnit.Hide()
        AssignSchedCboxChooseClasscode.Enabled = False
        Timer1.Enabled = True



        Try
            MySQLConn.Open()

            Dim query As String
            query = "select * from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` where isAssigned='false'"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            Dim count As String
            count = 0

            While reader.Read
                Dim classcodes As String = reader.GetString("classcode")
                AssignSchedCboxChooseClasscode.Items.Add(classcodes)
                AssignSchedCboxChooseClasscode.AutoCompleteCustomSource.Add(classcodes)
            End While

            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try


    End Sub

    Private Sub AddSchedCboxEmpNum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignSchedCboxEmpNum.SelectedIndexChanged
        pendingunit = 0
        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()

            Dim query As String
            query = "select * from userlist where lname='" & AssignSchedCboxEmpNum.Text & "'"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            Dim count As String
            count = 0

            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                LabelProfFname.Text = reader.GetString("fname")
                LabelProfLname.Text = reader.GetString("lname")
                LabelProfEmpCode.Text = reader.GetString("empnum")
            End If
            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        LabelProfEmpCode.Show()
        LabelProfFname.Show()
        LabelProfLname.Show()
        AssignSchedCboxChooseClasscode.Enabled = True

        Try
            MySQLConn.Open()
            query = "select * from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where instructor='" & LabelProfLname.Text & ", " & LabelProfFname.Text & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer
            While reader.Read
                count = count + 1
            End While
            If count >= 1 Then
                MySQLConn.Close()
                MySQLConn.Open()
                query = "select sum(units) as 'TotalUnits' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where instructor='" & LabelProfLname.Text & ", " & LabelProfFname.Text & "'"
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader
                While reader.Read
                    pendingunit = reader.GetString("TotalUnits")
                End While

                MySQLConn.Close()
            End If

            MySQLConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ButtonCancelAssignSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelAssignSched.Click

        'AssignSchedCboxChooseClasscode.ResetText()
        'AssignSchedCboxChooseClasscode.ResetText()
        'AssignSubjCboxchooseRoom.ResetText()
        'Me.Hide()
        AssignSchedLabelSubj_desc.Text = ""
        AssignSchedLabelRoom.Text = ""
        AssignSchedCboxChooseClasscode.Text = ""
        AssignSchedLabelSubj_day.Text = ""
        AssignSchedLabelTimeFrom.Text = ""
        AssignSchedLabelTimeTo.Text = ""
        DataGridViewPendingList.Rows.Clear()
        AssignSubejectPendingRowCounter = 0

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
            Form2.DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        Form2.DataGridSched.Focus()


        Me.Dispose()


    End Sub

    Private Sub AssignSchedCboxChooseClasscode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignSchedCboxChooseClasscode.SelectedIndexChanged

        AssignSchedCboxEmpNum.Enabled = False

        Try
            MySQLConn.Open()

            Dim query As String
            query = "select * from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode='" & AssignSchedCboxChooseClasscode.Text & "'"

            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            Dim count As String
            count = 0

            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                AssignSchedLabelSubj_desc.Text = reader.GetString("subj_desc")
                AssignSchedLabelSubj_day.Text = reader.GetString("day")

                Dim timeto As Date = reader.GetString("TimeTo")
                Dim timefrom As Date = reader.GetString("TimeFrom")

                AssignSchedLabelTimeFrom.Text = Format(timefrom, "HH:mm")
                AssignSchedLabelTimeTo.Text = Format(timeto, "HH:mm")
                AssignSchedLabelRoom.Text = reader.GetString("room")
                AssignSchedLabelUnit.Text = reader.GetString("subj_unit")
                'daytext = reader.GetString("day")

            End If
            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        AssignSchedLabelSubj_day.Show()
        AssignSchedLabelUnit.Show()
        AssignSchedLabelSubj_desc.Show()
        AssignSchedLabelSubj_day.Show()
        AssignSchedLabelTimeFrom.Show()
        AssignSchedLabelTimeTo.Show()
        AssignSchedLabelRoom.Show()
        AssignSchedLabelUnit.Show()
        AssignSchedCboxChooseClasscode.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub

    Private Sub ButtonSaveAssignSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveAssignSched.Click






        Dim rownumber As Integer = DataGridViewPendingList.Rows.Count

        Dim conflictclasscode As String = ""
        Dim conflictdesc As String = ""
        Dim conflictday As String = ""
        Dim conflicttimefrom As String = ""
        Dim conflicttimeto As String = ""
        Dim conflictroom As String = ""
        Dim errorcount As Boolean = False

        'MySQLConn.ConnectionString = connstring

        'Dim mo As Boolean = CheckBoxMo.Checked
        'Dim tu As Boolean = CheckBoxTu.Checked
        'Dim we As Boolean = CheckBoxWe.Checked
        'Dim th As Boolean = CheckBoxTh.Checked
        'Dim fr As Boolean = CheckBoxFr.Checked
        'Dim sa As Boolean = CheckBoxSa.Checked
        'daytext = ""

        Dim counter As Integer
        counter = 0
        If rownumber > 0 Then

            While counter <> rownumber

                Dim subjcode As String = DataGridViewPendingList.Rows(counter).Cells("Code").Value
                Dim subjdesc As String = DataGridViewPendingList.Rows(counter).Cells("SubjectDescription").Value
                Dim subjday As String = DataGridViewPendingList.Rows(counter).Cells("Day").Value
                Dim subjtimefrom As String = DataGridViewPendingList.Rows(counter).Cells("TimeFrom").Value
                Dim subjtimeto As String = DataGridViewPendingList.Rows(counter).Cells("TimeTo").Value
                Dim subjroom As String = DataGridViewPendingList.Rows(counter).Cells("Room").Value
                Dim subjunit As String = DataGridViewPendingList.Rows(counter).Cells("Unit").Value
                Dim instrname As String = LabelProfLname.Text & ", " & LabelProfFname.Text

                MySQLConn.ConnectionString = connstring

                Try
                    'MySQLConn.Open()
                    'query = "select * from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where instructor='" & instrname & " and day='" & subjday & "', and ('" & subjtimefrom & "' >=TimeFrom and '" & subjtimefrom & "' < TimeTo)"
                    MySQLConn.Open()
                    query = "select * from  `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where day like '%" & subjday & "%' and ('" & subjtimefrom & "' >=TimeStart and '" & subjtimeto & "' = TimeEnd) and instructor='" & instrname & "'"
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    Dim count As Integer
                    count = 0
                    While reader.Read
                        count = count + 1
                        conflictclasscode = reader.GetString("classcode")
                        conflictdesc = reader.GetString("subj_desc")
                        conflictday = reader.GetString("day")
                        conflicttimefrom = reader.GetString("TimeStart")
                        conflicttimeto = reader.GetString("TimeEnd")
                        conflictroom = reader.GetString("room")
                    End While

                    If count > 0 Then
                        MsgBox("You cannot assign " & subjcode & " to " & instrname & " because the system has detected a conflict! " & vbCrLf & "" & vbCrLf & "Classcode:" & conflictclasscode & "" & vbCrLf & "Subject Dscription:" & conflictdesc & "" & vbCrLf & "DAy:" & conflictday & "" & vbCrLf & "Time From:" & conflicttimefrom & "" & vbCrLf & "Time To::" & conflicttimeto & "" & vbCrLf & "Room:" & conflictroom & "", MsgBoxStyle.Critical)
                        errorcount = True
                        Exit While
                    Else
                        MySQLConn.Close()
                        MySQLConn.Open()
                        query = "insert into `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` values('" & subjcode & "', '" & subjdesc & "', '" & subjday & "', '" & subjroom & "', '" & subjtimefrom & "', '" & subjtimeto & "', '" & instrname & "', '" & subjunit & "')"
                        comm = New MySqlCommand(query, MySQLConn)
                        reader = comm.ExecuteReader
                        MySQLConn.Close()

                        MySQLConn.Open()
                        query = "update `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` set isAssigned='true' where classcode='" & subjcode & "'"
                        comm = New MySqlCommand(query, MySQLConn)
                        reader = comm.ExecuteReader
                        MySQLConn.Close()
                    End If



                Catch ex As Exception

                    MsgBox(ex.Message)

                Finally
                    MySQLConn.Dispose()


                End Try

                counter = counter + 1
            End While

            DataGridViewPendingList.Rows.Clear()
            AssignSubejectPendingRowCounter = 0
        Else
            MsgBox("No subject assigned!", MsgBoxStyle.Information, "Empty")
        End If
        If errorcount = False Then
            MsgBox("Congratuations! You have succesfully assigned all selected subjects to " & LabelProfLname.Text & ", " & LabelProfFname.Text & ". Thank you!", MsgBoxStyle.Information, "Success")
        Else
            MsgBox("Some of the selected subjects were successfully assigned and some were not assigned to " & LabelProfLname.Text & ", " & LabelProfFname.Text & ". because there is a conflict!", MsgBoxStyle.Critical, "Success")
        End If


    End Sub

    Private Sub AssignSubjAddToGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignSubjAddToGrid.Click
        Dim instrname As String = LabelProfLname.Text & ", " & LabelProfFname.Text
        Dim addedunit As Integer = CInt(AssignSchedLabelUnit.Text)
        Dim TotalTime



        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            query = "select * from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where instructor='" & instrname & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer
            count = 0

            While reader.Read
                count += 1
            End While
            If count >= 1 Then
                MySQLConn.Close()
                Dim divider As Integer = AssignSchedLabelSubj_day.Text.Length / 2 - 1

                Dim looper As Integer
                Dim starter As Integer = 0
                Dim stopper As Integer = 0
                Dim daycheck As String
                Dim conflictTimeFrom As String
                Dim conflictTimeTo As String
                Dim conflictClasscode As String
                While looper <= divider
                    daycheck = AssignSchedLabelSubj_day.Text.Substring(starter, 2)
                    MySQLConn.Open()
                    query = "select * from  `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where day like '%" & daytext & "%' and ('" & AssignSchedLabelTimeFrom.Text & "' >=TimeStart and '" & AssignSchedLabelTimeFrom.Text & "' < TimeEnd) and instructor='" & instrname & "'"
                    starter = starter + 2
                    looper = looper + 1
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    While reader.Read
                        conflictTimeFrom = reader.GetString("TimeStart")
                        conflictTimeTo = reader.GetString("TimeEnd")
                        conflictClasscode = reader.GetString("classcode")
                        stopper += 1
                    End While
                    MySQLConn.Close()
                    If stopper > 0 Then
                        MsgBox("The System has detected a conflict! " & vbCrLf & "" & vbCrLf & "Classcode: " & conflictClasscode & "" & vbCrLf & "Start Time: " & conflictTimeFrom & "" & vbCrLf & "End Time: " & conflictTimeTo & "" & vbCrLf & "Day : " & daycheck & "", MsgBoxStyle.Critical, "Occupied")
                        MySQLConn.Close()
                        Exit Sub
                    End If

                End While

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

        If AssignSchedCboxChooseClasscode.Text = "" Then
            MsgBox("No classcode to add. Please choose a classcode first!", MsgBoxStyle.Critical, "No Classcode")
        ElseIf AssignSchedLabelSubj_desc.Text = "" Then

            MsgBox("The Subject does not exist! Please add it in the Subjects Database first.", MsgBoxStyle.Critical, "No Subject.")
        ElseIf pendingunit + addedunit > 24 Then
            Dim warning As Integer
            warning = MsgBox("WARNING! Faculty load for " & LabelProfLname.Text & "will exceed the maximum load allowed. Do you still wamt to assign this subject to " & LabelProfFname.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Overload")
            If warning = 6 Then
                With DataGridViewPendingList
                    ' Write to cell 
                    .Rows.Add()
                    .Rows(AssignSubejectPendingRowCounter).Cells("Code").Value = AssignSchedCboxChooseClasscode.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("SubjectDescription").Value = AssignSchedLabelSubj_desc.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("Day").Value = AssignSchedLabelSubj_day.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("TimeFrom").Value = AssignSchedLabelTimeFrom.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("TimeTo").Value = AssignSchedLabelTimeTo.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("Room").Value = AssignSchedLabelRoom.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("Unit").Value = AssignSchedLabelUnit.Text
                    ListBoxPendingDay.Items.Add(AssignSchedLabelSubj_day.Text)
                    ListBoxPendingRoom.Items.Add(AssignSchedLabelRoom.Text)
                    ListBoxPendingTimeFrom.Items.Add(AssignSchedLabelTimeFrom.Text)
                    ListBoxPendingTimeTo.Items.Add(AssignSchedLabelTimeTo.Text)

                    pendingunit = pendingunit + AssignSchedLabelUnit.Text
                    AssignSubejectPendingRowCounter = AssignSubejectPendingRowCounter + 1
                    Timer2.Enabled = True



                End With

            End If
        Else

            With DataGridViewPendingList
                ' Write to cell 
                .Rows.Add()
                .Rows(AssignSubejectPendingRowCounter).Cells("Code").Value = AssignSchedCboxChooseClasscode.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("SubjectDescription").Value = AssignSchedLabelSubj_desc.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("Day").Value = AssignSchedLabelSubj_day.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("TimeFrom").Value = AssignSchedLabelTimeFrom.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("TimeTo").Value = AssignSchedLabelTimeTo.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("Room").Value = AssignSchedLabelRoom.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("Unit").Value = AssignSchedLabelUnit.Text
                ListBoxPendingDay.Items.Add(AssignSchedLabelSubj_day.Text)
                ListBoxPendingRoom.Items.Add(AssignSchedLabelRoom.Text)
                ListBoxPendingTimeFrom.Items.Add(AssignSchedLabelTimeFrom.Text)
                ListBoxPendingTimeTo.Items.Add(AssignSchedLabelTimeTo.Text)

                pendingunit = pendingunit + AssignSchedLabelUnit.Text
                AssignSubejectPendingRowCounter = AssignSubejectPendingRowCounter + 1




            End With

        End If



        AssignSchedCboxChooseClasscode.AutoCompleteCustomSource.Remove(AssignSchedCboxChooseClasscode.Text)
        AssignSchedCboxChooseClasscode.Items.Remove(AssignSchedCboxChooseClasscode.Text)
        AssignSchedCboxChooseClasscode.Text = ""
        AssignSchedLabelSubj_desc.Text = ""
        AssignSchedLabelSubj_day.Text = ""
        AssignSchedLabelTimeFrom.Text = ""
        AssignSchedLabelTimeTo.Text = ""
        AssignSchedLabelRoom.Text = ""
        AssignSchedLabelUnit.Text = "0"
        AssignSchedCboxChooseClasscode.DropDownStyle = ComboBoxStyle.DropDown
        AssignSchedCboxChooseClasscode.AutoCompleteSource = AutoCompleteSource.CustomSource
        AssignSchedCboxChooseClasscode.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim selected As Integer = DataGridViewPendingList.NewRowIndex
        AssignSchedLabelUnit.Text = selected



    End Sub

    Private Sub DataGridViewPendingList_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPendingList.CellContentDoubleClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridViewPendingList.Rows(e.RowIndex)

            AssignSchedCboxChooseClasscode.Items.Add(row.Cells("Code").Value.ToString)
            AssignSchedCboxChooseClasscode.AutoCompleteCustomSource.Add(row.Cells("Code").Value.ToString)
            pendingunit = pendingunit - row.Cells("Unit").Value.ToString
            DataGridViewPendingList.Rows.RemoveAt(e.RowIndex)
            AssignSubejectPendingRowCounter = AssignSubejectPendingRowCounter - 1




        End If
    End Sub

    Private Sub ButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReset.Click

        Dim refresh As New AssignSchedWindow
        AssignSubejectPendingRowCounter = 0
        Me.Dispose()
        refresh.ShowDialog()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "select lname from userlist where username!='pass' and empnum!='DEFAULT'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            Dim count As Integer

            count = 0

            While reader.Read
                Dim lastnames As String = reader.GetString("lname")
                AssignSchedCboxEmpNum.Items.Remove(lastnames)
                AssignSchedCboxEmpNum.Items.Add(lastnames)
            End While

            MySQLConn.Close()


        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            MySQLConn.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Opacity = 60%
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelTotalLoad.Text = pendingunit
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If pendingunit > 24 Then

            LabelTotalLoad.ForeColor = Color.Red
            If timer = 5 Then

                If LabelTotalLoad.Visible = True Then
                    LabelTotalLoad.Visible = False
                Else
                    LabelTotalLoad.Visible = True
                End If
                timer = 0
            End If
            timer += 1
        Else
            LabelTotalLoad.ForeColor = Color.Black
            LabelTotalLoad.Visible = True
        End If

    End Sub
End Class