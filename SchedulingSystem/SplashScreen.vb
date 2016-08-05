Public Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CancelButton = interrupt


        Me.Cursor = Cursors.WaitCursor

    End Sub

    Private Sub interrupt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles interrupt.Click
        End
    End Sub
End Class