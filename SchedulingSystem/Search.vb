Imports MySql.Data.MySqlClient

Public Class Search

    Public adapter As New MySqlDataAdapter
    Public dbdataset As New DataTable
    Dim bsource As New BindingSource

    Private Sub Search_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Dispose()
    End Sub

    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AcceptButton = Button1
        CancelButton = Button1
        Try

            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeFrom, '%H:%i') as 'From', time_format(TimeTo, '%H:%i') as 'To', subj_unit as 'Unit' from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by room asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            Form2.DataGridSubj.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim dv As New DataView(dbdataset)
            dv.RowFilter = String.Format("Code  Like '%{0}%'", TextBox1.Text)
            Form2.DataGridSubj.DataSource = dv
        Catch ex As Exception
            MsgBox(TextBox1.Text & " is an invalid character!", MsgBoxStyle.Critical)
        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class