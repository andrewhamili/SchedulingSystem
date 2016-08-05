Imports MySql.Data.MySqlClient

Public Class UserWindowViewSubjects

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property
    

    Public adapter As New MySqlDataAdapter
    Public dbdataset As New DataTable
    Dim bsource As New BindingSource

    Private Sub UserWindowViewSubjects_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        closinglistener = False
    End Sub

    Private Sub UserWindowViewSubjects_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If closinglistener = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub UserWindowViewSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MySQLConn.ConnectionString = connstring
        'Dim adapter As New MySqlDataAdapter
        'Dim dbdataset As New DataTable
        'Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeFrom, '%H:%i') as 'From', time_format(TimeTo, '%H:%i') as 'To', subj_unit as 'Unit' from `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by room asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridViewAllSubj.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim dv As New DataView(dbdataset)
        dv.RowFilter = String.Format("Room  Like '%{0}%'", TextBox1.Text)
        DataGridViewAllSubj.DataSource = dv
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        closinglistener = True
        Me.Dispose()
    End Sub
End Class