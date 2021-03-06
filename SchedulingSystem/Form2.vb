﻿Imports MySql.Data.MySqlClient

Public Class Form2

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
        ButtonItemViewAssignedSched.RaiseClick()
        ControlViewAssignedSchedule1.Hide()
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

    Private Sub ButtonViewSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub ExplorerBarGroupItemFacultyManagement_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        FacultyManagement.ShowDialog()
    End Sub

    Private Sub ExplorerBarGroupItemLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExplorerBarGroupItemLogout.Click
        Dim ans As DialogResult
        ans = MsgBox("Are you sure you want to log-out now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
        If ans = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonPrintAssignedSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrintAssignedSched.Click
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
            Dim colcount As Integer = ControlViewAssignedSchedule1.DataGridSched.Columns.Count - 1
            For i As Integer = 0 To ControlViewAssignedSchedule1.DataGridSched.Rows.Count - 1
                row = data.Tables(0).Rows.Add
                For Each column As DataGridViewColumn In ControlViewAssignedSchedule1.DataGridSched.Columns
                    row.Item(column.Index) = ControlViewAssignedSchedule1.DataGridSched.Rows.Item(i).Cells(column.Index).Value
                Next
            Next

        Catch ex As Exception

            MsgBox("CRITICAL ERROR : Exception caught while converting dataGridView to DataSet (dgvtods).. " & Chr(10) & ex.Message)
        End Try
    End Sub

    Private Sub ButtonItemViewSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemViewSubjects.Click
        GroupBoxContainer.Text = "Subjects list"
        ControlViewAssignedSchedule1.Hide()
        ControlViewSubjects1.Show()
        ControlViewSubjects1.Load_Subjects()
        lblNavigate.SendToBack()
    End Sub

    Private Sub ButtonItemModifySubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemModifySubjects.Click
        ManageSchedule.ShowDialog()
    End Sub

    Private Sub ButtonItemAddSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItemAddSchedule.Click
        AddSchedule.ShowDialog()
    End Sub

    Private Sub ExplorerBarGroupItemRoomList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplorerBarGroupItemRoomList.Click
        RoomManagement.ShowDialog()
    End Sub

End Class