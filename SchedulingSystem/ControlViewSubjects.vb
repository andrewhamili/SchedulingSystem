Imports MySql.Data.MySqlClient
Public Class ControlViewSubjects
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
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'Subject Description', subj_unit as 'Unit(s)' FROM `subjectlist" & schoolyear & "" & semester & "` ORDER BY room ASC", MySQLConn)
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
End Class
