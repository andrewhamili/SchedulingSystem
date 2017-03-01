Imports MySql.Data.MySqlClient
Public Class ControlViewSubjects
    Public dbdataset As New DataTable
    Public Sub Load_Subjects()
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        dbdataset.Clear()

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'Subject Description', subj_unit as 'Unit(s)' FROM `subjectlist" & SchoolYear & "" & Semester & "` ORDER BY room ASC", MySQLConn)
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

    Private Sub txtClassCodeFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClassCodeFilter.TextChanged
        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("Classcode LIKE '%{0}%'", txtClassCodeFilter.Text)
        DataGridSubjects.DataSource = dv
    End Sub
End Class
