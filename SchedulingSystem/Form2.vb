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
        ControlViewSubjects1.Hide()
        ControlViewAssignedSchedule1.Hide()
        GroupBoxContainer.Text = ""
        TimerTimeAndDate.Enabled = True
    End Sub

    Private Sub btnChangeSchoolyearSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchoolYearSemester.ShowDialog()
    End Sub
    Private Sub btnAssignSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AssignSchedule.ShowDialog()
    End Sub
    Private Sub btnAddSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddSchedule.ShowDialog()
    End Sub
    Private Sub btnManageSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ManageSchedule.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UnassignSchedule.ShowDialog()
    End Sub
    Private Sub AdminPage_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        Dim height As Integer = Me.Height
        Dim width As Integer = Me.Width

        If height < 620 And width < 1145 Then
            Me.Size = New Point(1145, 620)
        End If

    End Sub
    Private Sub btnAccountManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AccountManagement.ShowDialog()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AvailableRooms.ShowDialog()
    End Sub
    Private Sub btnManageRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RoomManagement.ShowDialog()
    End Sub

    Private Sub ButtonAssignSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAssignSched.Click
        AssignSchedule.ShowDialog()
        lblNavigate.SendToBack()
    End Sub

    Private Sub ButtonRemoveSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemoveSched.Click
        UnassignSchedule.ShowDialog()
        lblNavigate.SendToBack()
    End Sub

    Private Sub ButtonItemViewAssignedSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemViewAssignedSched.Click
        ControlViewAssignedSchedule1.Show()
        ControlViewAssignedSchedule1.Load_Schedules()
        ControlViewSubjects1.Hide()
        GroupBoxContainer.Text = "Assigned Schedules"
        lblNavigate.SendToBack()

    End Sub

    Private Sub ButtonAddAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAddAccount.Click
        EntryText = "Add"
        AccountManagement.Show()
    End Sub

    Private Sub ButtonViewSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonViewSubjects.Click
        GroupBoxContainer.Text = "Subjects list"
        ControlViewAssignedSchedule1.Hide()
        ControlViewSubjects1.Show()
        ControlViewSubjects1.Load_Subjects()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemSchoolYearSemester.Click
        SchoolYearSemester.ShowDialog()
    End Sub

    Private Sub ButtonItemEditOrDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemEditOrDelete.Click
        EntryText = "Edit"
        AccountManagement.ShowDialog()
    End Sub

    Private Sub ExplorerBarGroupItemFacultyManagement_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExplorerBarGroupItemFacultyManagement.Click
        FacultyManagement.ShowDialog()
    End Sub

    Private Sub ExplorerBarGroupItemLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExplorerBarGroupItemLogout.Click
        Dim ans As DialogResult
        ans = MsgBox("Are you sure you want to log-out now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
        If ans = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class