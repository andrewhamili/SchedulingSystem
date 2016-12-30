Imports MySql.Data.MySqlClient

Public Class AdminPage

    Public adapter As New MySqlDataAdapter
    Public bsource As New BindingSource
    Public dbdataset As New DataTable

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

        'Dim adapter As New MySqlDataAdapter
        'Dim bsource As New BindingSource
        'Dim dbdataset As New DataTable
        dbdataset.Clear()

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If



        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'Subject Description', day AS Day, room AS Room, TimeStart AS 'Time Start', TimeEnd AS 'Time End', instructor AS Instructor, units as 'Unit(s)' FROM `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` ORDER BY instructor ASC", MySQLConn)
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
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'Subject Description', subj_unit as 'Unit(s)', day AS Day, TimeFrom AS 'Time Start', TimeTo AS 'Time End', room AS Room FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` ORDER BY room ASC", MySQLConn)
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

    Private Sub DataGridSched_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridSched.Enter
        Load_Schedules()
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
End Class