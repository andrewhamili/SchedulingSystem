Imports MySql.Data.MySqlClient

Public Class AdminPage

    Public adapter As New MySqlDataAdapter
    Public bsource As New BindingSource
    Public dbdataset As New DataTable

    Public charactersAllowed As String = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
    Public charactersAllowedClasscodeAndRoom As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property
    Private Sub AdminPage_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        LoginPage.Show()
        LoginPage.tboxusername.Focus()
    End Sub

    Private Sub AdminPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Schedules()
        TimerTimeAndDate.Enabled = True
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim ans As DialogResult
        ans = MsgBox("Are you sure you want to log-out now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
        If ans = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnChangeSchoolyearSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeSchoolyearSemester.Click
        SchoolYearSemester.ShowDialog()
    End Sub

    Private Sub btnAssignSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignSched.Click
        AssignSchedule.ShowDialog()
    End Sub
    Public Sub Load_Schedules()
        dbdataset.Clear()
        GroupBoxSearch.Hide()
        lblSearch.Hide()

        'Dim adapter As New MySqlDataAdapter
        'Dim bsource As New BindingSource
        'Dim dbdataset As New DataTable

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If



        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'SubjectDescription', day AS Day, room AS Room, TIME_FORMAT(TimeStart, '%H:%i') AS 'Time Start', TIME_FORMAT(TimeEnd, '%H:%i') AS 'Time End', instructor AS Instructor, units as 'Unit(s)' FROM `assignedsubj" & schoolyear & "" & semester & "` ORDER BY instructor ASC", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            DataGridSched.DataSource = dbdataset
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub Load_Subjects()
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbdataset As New DataTable

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'Subject Description', subj_unit as 'Unit(s)', day AS Day, TIME_FORMAT(TimeFrom, '%H:%i') AS 'Time Start', TIME_FORMAT(TimeTo, '%H:%i') AS 'Time End', room AS Room FROM `subjectlist" & schoolyear & "" & semester & "` ORDER BY room ASC", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            DataGridSubjects.DataSource = dbdataset
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub TabSubject_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabSubject.Enter
        Load_Subjects()
        lblTotalSubjects.Text = "Total Subjects: " + DataGridSubjects.Rows.Count.ToString
    End Sub

    Private Sub btnAddSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSchedule.Click
        AddSchedule.ShowDialog()
    End Sub

    Private Sub btnManageSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageSchedule.Click
        ManageSchedule.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnassignSchedule.ShowDialog()
    End Sub

    Private Sub TabSchedule_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabSchedule.Enter
        Load_Schedules()

    End Sub

    Private Sub AdminPage_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Dim height As Integer = Me.Height
        Dim width As Integer = Me.Width

        If height < 620 And width < 1145 Then
            Me.Size = New Point(1145, 620)
        End If

    End Sub

    Private Sub DataGridSched_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridSched.KeyDown
        If e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control Then
            GroupBoxSearch.Show()
        End If
        Console.WriteLine("Press")
    End Sub

    Private Sub DataGridSched_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridSched.LostFocus
        lblSearch.Hide()
    End Sub

    Private Sub txtSearchClasscode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchClasscode.TextChanged
        Dim theText As String = txtSearchClasscode.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtSearchClasscode.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To txtSearchClasscode.Text.Length - 1
            Letter = txtSearchClasscode.Text.Substring(x, 1)
            If charactersAllowedClasscodeAndRoom.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        txtSearchClasscode.Text = theText
        txtSearchClasscode.Select(SelectionIndex - Change, 0)

        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("Classcode LIKE '%{0}%' and 'Subject Description' LIKE '%{1}%' and Room LIKE '%{2}%'", txtSearchClasscode.Text, txtSearchSubjDesc.Text, txtSearchRoom.Text)
        DataGridSched.DataSource = dv
    End Sub

    Private Sub txtSearchSubjDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchSubjDesc.TextChanged
        Dim theText As String = txtSearchSubjDesc.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtSearchSubjDesc.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To txtSearchSubjDesc.Text.Length - 1
            Letter = txtSearchSubjDesc.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        txtSearchSubjDesc.Text = theText
        txtSearchSubjDesc.Select(SelectionIndex - Change, 0)

        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("Classcode LIKE '%{0}%' and SubjectDescription LIKE '%{1}%' and Room LIKE '%{2}%'", txtSearchClasscode.Text, txtSearchSubjDesc.Text, txtSearchRoom.Text)
        DataGridSched.DataSource = dv
    End Sub

    Private Sub txtSearchRoom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchRoom.TextChanged
        Dim theText As String = txtSearchRoom.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtSearchRoom.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To txtSearchRoom.Text.Length - 1
            Letter = txtSearchRoom.Text.Substring(x, 1)
            If charactersAllowedClasscodeAndRoom.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        txtSearchRoom.Text = theText
        txtSearchRoom.Select(SelectionIndex - Change, 0)

        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("Classcode LIKE '%{0}%' and SubjectDescription LIKE '%{1}%' and Room LIKE '%{2}%'", txtSearchClasscode.Text, txtSearchSubjDesc.Text, txtSearchRoom.Text)
        DataGridSched.DataSource = dv
    End Sub

    Private Sub DataGridSched_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridSched.MouseClick
        lblSearch.Show()
    End Sub

    Private Sub DataGridSched_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridSched.MouseHover
        lblSearch.Show()
        DataGridSched.Focus()
    End Sub

    Private Sub PictureBoxPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxPrintSchedules.Click

        PrintAction = "AllSched"

        PrepareDataForPrintingAllSchedules()

        PrintWindow.ShowDialog()
    End Sub
    Public Sub PrepareDataForPrintingAllSchedules()
        data.Clear()
        Try
            '' Add Table
            'ds.Tables.Add("Test")

            '' Add Columns
            'Dim col As DataColumn
            'For Each dgvCol As DataGridViewColumn In DataGridView1.Columns
            '    col = New DataColumn(dgvCol.Name)
            '    ds.Tables("Invoices").Columns.Add(col)
            'Next

            ' Rows from the datagridview
            Dim row As DataRow
            Dim colcount As Integer = DataGridSched.Columns.Count - 1
            For i As Integer = 0 To DataGridSched.Rows.Count - 1
                row = data.Tables(0).Rows.Add
                For Each column As DataGridViewColumn In DataGridSched.Columns
                    row.Item(column.Index) = DataGridSched.Rows.Item(i).Cells(column.Index).Value
                Next
            Next

        Catch ex As Exception

            MsgBox("CRITICAL ERROR : Exception caught while converting dataGridView to DataSet (dgvtods).. " & Chr(10) & ex.Message)
        End Try
    End Sub

    Private Sub PictureBoxPrintSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxPrintSubjects.Click
        PrintAction = "AllSubjects"
        PrepareDataForPrintingAllSubjects()
        PrintWindow.ShowDialog()
    End Sub
    Public Sub PrepareDataForPrintingAllSubjects()
        data.Clear()
        Try
            '' Add Table
            'ds.Tables.Add("Test")

            '' Add Columns
            'Dim col As DataColumn
            'For Each dgvCol As DataGridViewColumn In DataGridView1.Columns
            '    col = New DataColumn(dgvCol.Name)
            '    ds.Tables("Invoices").Columns.Add(col)
            'Next

            ' Rows from the datagridview
            Dim row As DataRow
            Dim colcount As Integer = DataGridSubjects.Columns.Count - 1
            For i As Integer = 0 To DataGridSubjects.Rows.Count - 1
                row = data.Tables(1).Rows.Add
                For Each column As DataGridViewColumn In DataGridSubjects.Columns
                    row.Item(column.Index) = DataGridSubjects.Rows.Item(i).Cells(column.Index).Value
                Next
            Next

        Catch ex As Exception

            MsgBox("CRITICAL ERROR : Exception caught while converting dataGridView to DataSet (dgvtods).. " & Chr(10) & ex.Message)
        End Try
    End Sub

    Private Sub btnAccountManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccountManagement.Click
        AccountManagement.ShowDialog()
    End Sub
    Public Sub ChangeTab()
        TabControl2.SelectedTab = TabSchedule
    End Sub

    Private Sub TimerTimeAndDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTimeAndDate.Tick
        txtCurrentSchoolYear.Text = SchoolYear
        txtCurrentSemester.Text = Semester
        Me.Text = "Home Page        " & Now.ToString("MMMMM dd, yyyy    HH:mm:ss")
    End Sub
    Public Sub Load_FacultyList()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring & database

        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim dbdataset As New DataTable

        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', username AS Username FROM userlist WHERE username!='pass';", MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridViewFacultyList.DataSource = bsource
            adapter.Update(dbdataset)
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Close()
        End Try
    End Sub

    Private Sub FacultyList_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles FacultyList.Enter
        dbdataset.Clear()
        Load_FacultyList()
    End Sub

    Private Sub DataGridViewFacultyList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            Dim instructor As String
            row = DataGridViewFacultyList.Rows(e.RowIndex)
            instructor = row.Cells("Last Name").Value + ", " + row.Cells("First Name").Value
            FacultySched.instrname = instructor
            FacultySched.ShowDialog()
        End If
    End Sub

    Private Sub DataGridViewFacultyList_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewFacultyList.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            Dim instructor As String = ""
            row = DataGridViewFacultyList.Rows(e.RowIndex)
            instructor = row.Cells("Last Name").Value + ", " + row.Cells("First Name").Value
            FacultySched.instrname = instructor
            FacultySched.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryRoom.Click
        AvailableRooms.ShowDialog()
    End Sub

    Private Sub ScheduleManagement_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScheduleManagement.Enter
        Load_Schedules()
        Load_Subjects()
        lblTotalSubjects.Text = "Total Subjects: " + DataGridSubjects.Rows.Count.ToString
    End Sub

    Private Sub btnManageRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageRoom.Click
        RoomManagement.ShowDialog()
    End Sub
End Class