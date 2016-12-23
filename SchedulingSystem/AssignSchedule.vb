Imports MySql.Data.MySqlClient
Public Class AssignSchedule


    Public pendingunit As Integer
    Public timer As Integer
    Public AssignSubejectPendingRowCounter As Integer = 0


    Private Sub AssignSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Employee_Lastnames()
        Load_Classcodes()
        Timer_OverloadBlinker.Enabled = True
        Timer_TotalUnitOutput.Enabled = True
    End Sub
    Public Sub Load_Employee_Lastnames()
        ComboBoxEmployeeLastname.Items.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM userlist WHERE empnum!='DEFAULT'", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ComboBoxEmployeeLastname.Items.Add(reader.GetString("lname"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub
    Public Sub Load_Classcodes()
        ComboBoxClasscode.Items.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE isAssigned!='true'", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ComboBoxClasscode.Items.Add(reader.GetString("classcode"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btnChooseClasscode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseClasscode.Click
        Dim instrname As String = LabelProfLname.Text & ", " & LabelProfFname.Text
        Dim addedunit As Integer = CInt(lblUnit.Text)
        Dim TotalTime



        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("select * from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where instructor=@instructorname", MySQLConn)
            comm.Parameters.AddWithValue("instructorname", instrname)
            reader = comm.ExecuteReader
            Dim count As Integer
            count = 0

            While reader.Read
                count += 1
            End While
            If count >= 1 Then
                MySQLConn.Close()
                Dim divider As Integer = lblDay.Text.Length / 2 - 1

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
                    'comm = New MySqlCommand("SELECT * FROM  `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE day LIKE '%" & daytext & "%' and ('" & AssignSchedLabelTimeFrom.Text & "' >=TimeStart  '" & AssignSchedLabelTimeFrom.Text & "' < TimeEnd) and instructor='" & instrname & "'", MySQLConn)
                    comm = New MySqlCommand("SELECT * FROM `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE day like '%" & daycheck & "%' AND TimeStart > @timefrom and TimeEnd < @timeto AND instructor=@instructorname;", MySQLConn)
                    comm.Parameters.AddWithValue("instructorname", instrname)
                    comm.Parameters.AddWithValue("timeto", lblTimeTo)
                    comm.Parameters.AddWithValue("timefrom", lblTimeFrom)
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

        If ComboBoxClasscode.Text = "" Then
            MsgBox("No classcode to add. Please choose a classcode first!", MsgBoxStyle.Critical, "No Classcode")
        ElseIf lblSubjDesc.Text = "" Then

            MsgBox("The Subject does not exist! Please add it in the Subjects Database first.", MsgBoxStyle.Critical, "No Subject.")
        ElseIf pendingunit + addedunit > 24 Then
            Dim warning As Integer
            warning = MsgBox("WARNING! Faculty load for " & LabelProfLname.Text & "will exceed the maximum load allowed. Do you still wamt to assign this subject to " & LabelProfFname.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Overload")
            If warning = 6 Then
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
                    AssignSubejectPendingRowCounter = AssignSubejectPendingRowCounter + 1
                    Timer_OverloadBlinker.Enabled = True



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


                pendingunit = pendingunit + lblunit.Text
                AssignSubejectPendingRowCounter = AssignSubejectPendingRowCounter + 1




            End With

        End If




        With ComboBoxClasscode
            .AutoCompleteCustomSource.Remove(ComboBoxClasscode.Text)
            .Items.Remove(ComboBoxClasscode.Text)
            .Text = ""
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With


        lblSubjDesc.Text = ""
        lblDay.Text = ""
        lblTimeTo.Text = ""
        lblTimeFrom.Text = ""
        lblRoom.Text = ""
        lblUnit.Text = "0"

    End Sub

    Private Sub ComboBoxEmployeeLastname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEmployeeLastname.SelectedIndexChanged
        pendingunit = 0
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
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
            comm = New MySqlCommand("SELECT * FROM `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE instructor=@instructorname", MySQLConn)
            comm.Parameters.AddWithValue("instructorname", instructor)
            reader = comm.ExecuteReader
            Dim count1 As Integer
            While reader.Read
                count1 += 1
            End While
            If count1 >= 1 Then
                MySQLConn.Close()
                MySQLConn.Open()
                comm = New MySqlCommand("SELECT sum(units) AS TotalUnits FROM `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE instructor=@instructorname", MySQLConn)
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

        Try
            MySQLConn.Open()

            comm = New MySqlCommand("SELECT * FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE classcode=@selectedClassCode", MySQLConn)
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
End Class