Imports MySql.Data.MySqlClient
Public Class AssignSchedule


    Public pendingunit As Integer
    Public timer As Integer
    Public AssignSubejectPendingRowCounter As Integer = 0
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property
    Private Sub AssignSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancelButton = btnCancel
        Load_Employee_Lastnames()
        Load_Classcodes()
        Timer_OverloadBlinker.Enabled = True
        Timer_TotalUnitOutput.Enabled = True
        lblSubjDesc.Text = ""
        lblDay.Text = ""
        lblTimeTo.Text = ""
        lblTimeFrom.Text = ""
        lblRoom.Text = ""
        lblUnit.Text = "0"
        LabelProfFname.Text = ""
        LabelProfLname.Text = ""
        ComboBoxClasscode.Enabled = False
        With ComboBoxClasscode
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        AcceptButton = btnChooseClasscode
    End Sub
    Public Sub Load_Employee_Lastnames()
        ComboBoxEmployeeLastname.Items.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database

        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM userlist WHERE username!='pass'", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ComboBoxEmployeeLastname.Items.Add(reader.GetString("lname"))
                ComboBoxEmployeeLastname.AutoCompleteCustomSource.Add(reader.GetString("lname"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub
    Public Sub Load_Classcodes()

        With ComboBoxClasscode
            .Items.Clear()
            .AutoCompleteCustomSource.Clear()
            If MySQLConn.State = ConnectionState.Open Then
                MySQLConn.Close()
            End If
            MySQLConn.ConnectionString = connstring & database
            Try
                MySQLConn.Open()
                comm = New MySqlCommand("SELECT classcode FROM `subjectlist" & schoolyear & "" & Semester & "` WHERE isAssigned!='true'", MySQLConn)
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

    Private Sub btnChooseClasscode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseClasscode.Click
        AssignSubejectPendingRowCounter = DataGridViewPendingList.Rows.Count
        'AssignSubejectPendingRowCounter = (DataGridViewPendingList.Rows.Count) - 1
        'lblSubjDesc.Text = ""
        'lblDay.Text = ""
        'lblTimeTo.Text = ""
        'lblTimeFrom.Text = ""
        'lblRoom.Text = ""
        'lblUnit.Text = "0"

        Dim instrname As String = LabelProfLname.Text & ", " & LabelProfFname.Text
        Dim addedunit As Integer = Val(lblUnit.Text)



        MySQLConn.ConnectionString = connstring & database
        Try
            'To Check if there are exisiting subject that is already assigned to the selected employee
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT DISTINCT * FROM `assignedsubj" & schoolyear & "" & Semester & "` WHERE instructor=@instructorname", MySQLConn)
            comm.Parameters.AddWithValue("instructorname", instrname)
            reader = comm.ExecuteReader
            Dim count As Integer
            count = 0

            While reader.Read
                count += 1
            End While

            If count >= 1 Then
                'If there were subject that are previously assigned to the selected employee, the system will now start to read the selected subject for Conflict test.
                MySQLConn.Close()

                Dim divider As Integer = lblDay.Text.Length / 2 - 1 'Divides the Days to two characters. for searching by Day
                Dim looper As Integer
                Dim starter As Integer = 0
                Dim stopper As Integer = 0
                Dim daycheck As String
                Dim conflictTimeFrom As String
                Dim conflictTimeTo As String
                Dim conflictClasscode As String
                While looper <= divider
                    daycheck = lblDay.Text.Substring(starter, 2)

                    MySQLConn.Open()

                    starter = starter + 2
                    looper = looper + 1

                    comm = New MySqlCommand("SELECT * FROM `assignedsubj" & schoolyear & "" & Semester & "` WHERE day like '%" & daycheck & "%' AND TimeEnd > @timefrom and TimeStart < @timeto AND instructor=@instructorname;", MySQLConn)

                    'SELECT * FROM `assignedsubj2015-20161st` WHERE day like '%Mo%' AND (TimeEnd > '14:00' AND TimeStart <'15:00') AND instructor='Ayo, Eliza'
                    comm.Parameters.AddWithValue("instructorname", instrname)
                    comm.Parameters.AddWithValue("timeto", lblTimeTo.Text)
                    comm.Parameters.AddWithValue("timefrom", lblTimeFrom.Text)
                    reader = comm.ExecuteReader
                    While reader.Read
                        'If the System detects a conflict...
                        conflictTimeFrom = reader.GetString("TimeStart")
                        conflictTimeTo = reader.GetString("TimeEnd")
                        conflictClasscode = reader.GetString("classcode")
                        '...the System will increment the variable "Stopper" to 1.
                        stopper += 1
                    End While
                    MySQLConn.Close()
                    'If the "sttopper" variable is greater that 1, there is a conflicting schedule.
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

        If ComboBoxClasscode.Text = "" Then
            MsgBox("No classcode to add. Please choose a classcode first!", MsgBoxStyle.Critical, "No Classcode")
        ElseIf lblSubjDesc.Text = "" Then

            MsgBox("The Subject does not exist! Please add it in the Subjects Database first.", MsgBoxStyle.Critical, "No Subject.")
        ElseIf pendingunit + addedunit > 24 Then

            Dim warning As DialogResult
            warning = MsgBox("WARNING! Faculty load for " & LabelProfLname.Text & "will exceed the maximum load allowed. Do you still wamt to assign this subject to " & LabelProfFname.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Overload")

            If warning = Windows.Forms.DialogResult.Yes Then
                With DataGridViewPendingList
                    ' Write to cell 
                    .Rows.Add()
                    .Rows(AssignSubejectPendingRowCounter).Cells("Code").Value = ComboBoxClasscode.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("SubjectDescription").Value = lblSubjDesc.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("Day").Value = lblDay.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("TimeFrom").Value = lblTimeFrom.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("TimeTo").Value = lblTimeTo.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("Room").Value = lblRoom.Text
                    .Rows(AssignSubejectPendingRowCounter).Cells("Unit").Value = lblUnit.Text


                    pendingunit = pendingunit + lblUnit.Text
                    'AssignSubejectPendingRowCounter = AssignSubejectPendingRowCounter + 1
                    Timer_OverloadBlinker.Enabled = True

                    With ComboBoxClasscode
                        .AutoCompleteCustomSource.Remove(ComboBoxClasscode.Text)
                        .Items.Remove(ComboBoxClasscode.Text)
                        .DropDownStyle = ComboBoxStyle.DropDown
                        .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    End With


                End With

            End If
        Else

            With DataGridViewPendingList
                ' Write to cell 
                .Rows.Add()
                .Rows(AssignSubejectPendingRowCounter).Cells("Code").Value = ComboBoxClasscode.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("SubjectDescription").Value = lblSubjDesc.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("Day").Value = lblDay.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("TimeFrom").Value = lblTimeFrom.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("TimeTo").Value = lblTimeTo.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("Room").Value = lblRoom.Text
                .Rows(AssignSubejectPendingRowCounter).Cells("Unit").Value = lblUnit.Text


                pendingunit = pendingunit + lblUnit.Text
                'AssignSubejectPendingRowCounter = AssignSubejectPendingRowCounter + 1

                With ComboBoxClasscode
                    .AutoCompleteCustomSource.Remove(ComboBoxClasscode.Text)
                    .Items.Remove(ComboBoxClasscode.Text)
                    .DropDownStyle = ComboBoxStyle.DropDown
                    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                End With


            End With

        End If







        lblSubjDesc.Text = ""
        lblDay.Text = ""
        lblTimeTo.Text = ""
        lblTimeFrom.Text = ""
        lblRoom.Text = ""
        lblUnit.Text = "0"

    End Sub

    Private Sub ComboBoxEmployeeLastname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEmployeeLastname.SelectedIndexChanged
        ComboBoxClasscode.Enabled = True
        ComboBoxEmployeeLastname.Enabled = False
        pendingunit = 0
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM userlist WHERE lname=@selectedLastName", MySQLConn)
            comm.Parameters.AddWithValue("selectedlastname", ComboBoxEmployeeLastname.Text)
            reader = comm.ExecuteReader
            Dim count As Integer
            While reader.Read
                count += 1
            End While
            If count > 0 Then
                LabelProfLname.Text = reader.GetString("lname")
                LabelProfFname.Text = reader.GetString("fname")
            End If
            MySQLConn.Close()
            MySQLConn.Open()
            Dim instructor As String = LabelProfLname.Text + ", " + LabelProfFname.Text
            comm = New MySqlCommand("SELECT * FROM `assignedsubj" & schoolyear & "" & Semester & "` WHERE instructor=@instructorname", MySQLConn)
            comm.Parameters.AddWithValue("instructorname", instructor)
            reader = comm.ExecuteReader
            Dim count1 As Integer
            While reader.Read
                count1 += 1
            End While
            If count1 >= 1 Then
                MySQLConn.Close()
                MySQLConn.Open()
                comm = New MySqlCommand("SELECT sum(units) AS TotalUnits FROM `assignedsubj" & schoolyear & "" & Semester & "` WHERE instructor=@instructorname", MySQLConn)
                comm.Parameters.AddWithValue("instructorname", instructor)
                reader = comm.ExecuteReader
                Dim count2 As Integer
                While reader.Read
                    pendingunit = reader.GetString("TotalUnits")
                End While
                MySQLConn.Close()
            End If
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_OverloadBlinker.Tick
        If pendingunit > 24 Then

            lblTotalUnits.ForeColor = Color.Red
            If timer = 5 Then

                If lblTotalUnits.Visible = True Then
                    lblTotalUnits.Visible = False
                Else
                    lblTotalUnits.Visible = True
                End If
                timer = 0
            End If
            timer += 1
        Else
            lblTotalUnits.ForeColor = Color.Black
            lblTotalUnits.Visible = True
        End If

    End Sub
    Private Sub ComboBoxClasscode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxClasscode.SelectedIndexChanged
        ComboBoxEmployeeLastname.Enabled = False
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring & database

        Try
            MySQLConn.Open()

            comm = New MySqlCommand("SELECT * FROM `subjectlist" & schoolyear & "" & Semester & "` WHERE classcode=@selectedClassCode", MySQLConn)
            comm.Parameters.AddWithValue("selectedClassCode", ComboBoxClasscode.Text)
            reader = comm.ExecuteReader

            Dim count As String
            count = 0

            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                lblSubjDesc.Text = reader.GetString("subj_desc")
                lblDay.Text = reader.GetString("day")

                Dim timeto As Date = reader.GetString("TimeTo")
                Dim timefrom As Date = reader.GetString("TimeFrom")

                lblTimeFrom.Text = Format(timefrom, "HH:mm")
                lblTimeTo.Text = Format(timeto, "HH:mm")
                lblRoom.Text = reader.GetString("room")
                lblUnit.Text = reader.GetString("subj_unit")
                'daytext = reader.GetString("day")

            End If
            MySQLConn.Close()

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        lblDay.Show()
        lblUnit.Show()
        lblSubjDesc.Show()
        lblDay.Show()
        lblTimeFrom.Show()
        lblTimeTo.Show()
        lblRoom.Show()
        lblUnit.Show()
        ComboBoxClasscode.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Timer_TotalUnitOutput_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_TotalUnitOutput.Tick
        lblTotalUnits.Text = pendingunit
    End Sub

    Private Sub DataGridViewPendingList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPendingList.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridViewPendingList.Rows(e.RowIndex)

            ComboBoxClasscode.Items.Add(row.Cells("Code").Value.ToString)
            ComboBoxClasscode.AutoCompleteCustomSource.Add(row.Cells("Code").Value.ToString)
            pendingunit = pendingunit - row.Cells("Unit").Value.ToString
            DataGridViewPendingList.Rows.RemoveAt(e.RowIndex)
            AssignSubejectPendingRowCounter = AssignSubejectPendingRowCounter - 1




        End If
    End Sub

    Private Sub btnSaveSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSchedule.Click

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring & database

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

                Dim subjcode As String = DataGridViewPendingList.Rows(0).Cells("Code").Value
                Dim subjdesc As String = DataGridViewPendingList.Rows(0).Cells("SubjectDescription").Value
                Dim subjday As String = DataGridViewPendingList.Rows(0).Cells("Day").Value
                Dim subjtimefrom As String = DataGridViewPendingList.Rows(0).Cells("TimeFrom").Value
                Dim subjtimeto As String = DataGridViewPendingList.Rows(0).Cells("TimeTo").Value
                Dim subjroom As String = DataGridViewPendingList.Rows(0).Cells("Room").Value
                Dim subjunit As String = DataGridViewPendingList.Rows(0).Cells("Unit").Value
                Dim instrname As String = LabelProfLname.Text & ", " & LabelProfFname.Text

                MySQLConn.ConnectionString = connstring & database
                Dim starter As Integer = 0
                Dim divider As Integer = subjday.Length / 2 - 1
                Dim looper As Integer = 0
                Dim daycheck As String

                While looper <= divider
                    daycheck = subjday.Substring(starter, 2)
                    looper += 1
                    starter += 2
                    Try
                        MySQLConn.Open()
                        comm = New MySqlCommand("SELECT * FROM `assignedsubj" & schoolyear & "" & Semester & "` WHERE day like '%" & daycheck & "%' AND TimeEnd > @timefrom and TimeStart < @timeto AND instructor=@instructorname;", MySQLConn)

                        'SELECT * FROM `assignedsubj2015-20161st` WHERE day like '%Mo%' AND (TimeEnd > '14:00' AND TimeStart <'15:00') AND instructor='Ayo, Eliza'
                        comm.Parameters.AddWithValue("instructorname", instrname)
                        comm.Parameters.AddWithValue("timeto", subjtimeto)
                        comm.Parameters.AddWithValue("timefrom", subjtimefrom)
                        reader = comm.ExecuteReader
                        Dim count As Integer = 0
                        While reader.Read
                            count = count + 1
                            conflictclasscode = reader.GetString("classcode")
                            conflictdesc = reader.GetString("subj_desc")
                            conflictday = reader.GetString("day")
                            conflicttimefrom = reader.GetString("TimeStart")
                            conflicttimeto = reader.GetString("TimeEnd")
                            conflictroom = reader.GetString("room")
                        End While
                        MySQLConn.Close()
                        If count > 0 Then
                            MsgBox("You cannot assign " & subjcode & " to " & instrname & " because the system has detected a conflict! " & vbCrLf & "" & vbCrLf & "Classcode: " & conflictclasscode & "" & vbCrLf & "Subject Dscription: " & conflictdesc & "" & vbCrLf & "Day: " & conflictday & "" & vbCrLf & "Time From: " & conflicttimefrom & "" & vbCrLf & "Time To: " & conflicttimeto & "" & vbCrLf & "Room: " & conflictroom & "", MsgBoxStyle.Critical)
                            errorcount = True
                            Exit While
                        End If


                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        MySQLConn.Dispose()
                    End Try
                End While
                If errorcount = False Then
                    MySQLConn.Close()
                    MySQLConn.Open()
                    comm = New MySqlCommand("INSERT INTO `assignedsubj" & schoolyear & "" & Semester & "` VALUES(@classcode, @subjdesc, @subjday, @subjroom, @TImeStart, @TimeEnd, @instructor, @units)", MySQLConn)
                    comm.Parameters.AddWithValue("classcode", subjcode)
                    comm.Parameters.AddWithValue("subjdesc", subjdesc)
                    comm.Parameters.AddWithValue("subjday", subjday)
                    comm.Parameters.AddWithValue("subjroom", subjroom)
                    comm.Parameters.AddWithValue("TimeStart", subjtimefrom)
                    comm.Parameters.AddWithValue("TimeEnd", subjtimeto)
                    comm.Parameters.AddWithValue("instructor", instrname)
                    comm.Parameters.AddWithValue("units", subjunit)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MySQLConn.Open()
                    comm = New MySqlCommand("UPDATE `subjectlist" & schoolyear & "" & Semester & "` SET isAssigned='true' WHERE classcode=@classcode", MySQLConn)
                    comm.Parameters.AddWithValue("classcode", subjcode)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    DataGridViewPendingList.Rows.RemoveAt(0)
                Else
                    Exit While
                End If



                counter = counter + 1
            End While

            If errorcount = False Then
                MsgBox("Congratuations! You have succesfully assigned all selected subjects to " & LabelProfLname.Text & ", " & LabelProfFname.Text & ". Thank you!", MsgBoxStyle.Information, "Success")
            Else
                MsgBox("Some of the selected subjects were successfully assigned and some were not assigned to " & LabelProfLname.Text & ", " & LabelProfFname.Text & ". because there is a conflict!", MsgBoxStyle.Critical, "Success")
            End If
        Else
            MsgBox("No subject assigned!", MsgBoxStyle.Information, "Empty")
        End If
        AdminPage.dbdataset.Clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub AssignSchedule_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Dim SizeX As Integer = Me.Width
        Dim SizeY As Integer = Me.Height
        If SizeX < 873 And SizeY < 597 Then
            Me.Size = New Point(873, 597)
        End If
    End Sub
End Class