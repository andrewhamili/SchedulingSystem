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

    'Private Sub txtSearchClasscode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim theText As String = txtSearchClasscode.Text
    '    Dim Letter As String
    '    Dim SelectionIndex As Integer = txtSearchClasscode.SelectionStart
    '    Dim Change As Integer

    '    For x As Integer = 0 To txtSearchClasscode.Text.Length - 1
    '        Letter = txtSearchClasscode.Text.Substring(x, 1)
    '        If charactersAllowedClasscodeAndRoom.Contains(Letter) = False Then
    '            theText = theText.Replace(Letter, String.Empty)
    '            Change = 1
    '        End If
    '    Next

    '    txtSearchClasscode.Text = theText
    '    txtSearchClasscode.Select(SelectionIndex - Change, 0)

    '    Dim dv As New DataView(dbdataset)
    '    dv.RowFilter = String.Format("Classcode LIKE '%{0}%' and 'Subject Description' LIKE '%{1}%' and Room LIKE '%{2}%'", txtSearchClasscode.Text, txtSearchSubjDesc.Text, txtSearchRoom.Text)
    '    DataGridSched.DataSource = dv
    'End Sub

    'Private Sub txtSearchSubjDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim theText As String = txtSearchSubjDesc.Text
    '    Dim Letter As String
    '    Dim SelectionIndex As Integer = txtSearchSubjDesc.SelectionStart
    '    Dim Change As Integer

    '    For x As Integer = 0 To txtSearchSubjDesc.Text.Length - 1
    '        Letter = txtSearchSubjDesc.Text.Substring(x, 1)
    '        If charactersAllowed.Contains(Letter) = False Then
    '            theText = theText.Replace(Letter, String.Empty)
    '            Change = 1
    '        End If
    '    Next

    '    txtSearchSubjDesc.Text = theText
    '    txtSearchSubjDesc.Select(SelectionIndex - Change, 0)

    '    Dim dv As New DataView(dbdataset)
    '    dv.RowFilter = String.Format("Classcode LIKE '%{0}%' and SubjectDescription LIKE '%{1}%' and Room LIKE '%{2}%'", txtSearchClasscode.Text, txtSearchSubjDesc.Text, txtSearchRoom.Text)
    '    DataGridSched.DataSource = dv
    'End Sub

    'Private Sub txtSearchRoom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim theText As String = txtSearchRoom.Text
    '    Dim Letter As String
    '    Dim SelectionIndex As Integer = txtSearchRoom.SelectionStart
    '    Dim Change As Integer

    '    For x As Integer = 0 To txtSearchRoom.Text.Length - 1
    '        Letter = txtSearchRoom.Text.Substring(x, 1)
    '        If charactersAllowedClasscodeAndRoom.Contains(Letter) = False Then
    '            theText = theText.Replace(Letter, String.Empty)
    '            Change = 1
    '        End If
    '    Next

    '    txtSearchRoom.Text = theText
    '    txtSearchRoom.Select(SelectionIndex - Change, 0)

    '    Dim dv As New DataView(dbdataset)
    '    dv.RowFilter = String.Format("Classcode LIKE '%{0}%' and SubjectDescription LIKE '%{1}%' and Room LIKE '%{2}%'", txtSearchClasscode.Text, txtSearchSubjDesc.Text, txtSearchRoom.Text)
    '    DataGridSched.DataSource = dv
    'End Sub

    'Private Sub DataGridSched_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridSched.MouseClick
    '    lblSearch.Show()
    'End Sub

    'Private Sub DataGridSched_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridSched.MouseHover
    '    lblSearch.Show()
    '    DataGridSched.Focus()
    'End Sub
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
    End Sub

    Private Sub ButtonRemoveSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemoveSched.Click
        UnassignSchedule.ShowDialog()
    End Sub

    Private Sub ButtonItemViewAssignedSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemViewAssignedSched.Click
        ControlViewAssignedSchedule1.Show()
        ControlViewAssignedSchedule1.Load_Schedules()
        GroupBoxContainer.Text = "Assigned Schedules"
    End Sub

    Private Sub ExplorerBarGroupItemLogout_ExpandChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExplorerBarGroupItemLogout.ExpandChange
        Dim ans As DialogResult
        ans = MsgBox("Are you sure you want to log-out now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
        If ans = Windows.Forms.DialogResult.Yes Then
            RemoveHandler ExplorerBarGroupItemLogout.ExpandChange, AddressOf ExplorerBarGroupItemLogout_ExpandChange
            Me.Close()
        End If
    End Sub

    Private Sub ButtonAddAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAddAccount.Click
        EntryText = "Add"
        AccountManagement.Show()
    End Sub
End Class