Public Class AdminPage

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
End Class