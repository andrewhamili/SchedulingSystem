Imports MySql.Data.MySqlClient
Public Class UserWindow
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property
    Public instrname As String = ""
    Private Sub UserWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTotalUnit.Text = ""
        lblWelcomeText.Text = instrname
        lblSchoolYear.Text = SchoolYear
        lblSemester.Text = Semester
        Load_Sched()
    End Sub
    Public Sub Load_Sched()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT classcode AS Classcode, subj_desc AS 'Subject Description', day AS Day, room AS Room, TIME_FORMAT(TimeStart, '%H:%i') AS 'Time Start', TIME_FORMAT(TimeEnd, '%H:%i') AS 'Time End', units as 'Unit(s)'FROM `assignedsubj" & SchoolYear & "" & Semester & "` WHERE instructor=@instructor ORDER BY day, TimeStart ASC", MySQLConn)

            adapter.SelectCommand = comm
            adapter.SelectCommand.Parameters.AddWithValue("instructor", instrname)
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridViewSched.DataSource = bsource
            adapter.Update(dbdataset)
            MySQLConn.Close()
            If DataGridViewSched.Rows.Count > 0 Then
                MySQLConn.Open()
                comm = New MySqlCommand("SELECT SUM(units) AS total FROM `assignedsubj" & SchoolYear & "" & Semester & "` WHERE instructor=@instructor;", MySQLConn)
                comm.Parameters.AddWithValue("instructor", instrname)
                reader = comm.ExecuteReader
                While reader.Read
                    lblTotalUnit.Text = reader.GetString("total")
                End While
                MySQLConn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub PrepareDataForPrint()
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
            Dim colcount As Integer = DataGridViewSched.Columns.Count - 1
            For i As Integer = 0 To DataGridViewSched.Rows.Count - 1
                row = data.Tables(2).Rows.Add
                For Each column As DataGridViewColumn In DataGridViewSched.Columns
                    row.Item(column.Index) = DataGridViewSched.Rows.Item(i).Cells(column.Index).Value
                Next
            Next
        Catch ex As Exception
            MsgBox("CRITICAL ERROR : Exception caught while converting dataGridView to DataSet (dgvtods).. " & Chr(10) & ex.Message)
        End Try
    End Sub

    Private Sub PictureBoxPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxPrint.Click
        PrintAction = "Single-user"
        PrepareDataForPrint()
        PrintWindow.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Dispose()
        LoginPage.Show()
        LoginPage.tboxusername.Focus()
    End Sub

    Private Sub btnQueryRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryRooms.Click
        AvailableRooms.ShowDialog()
    End Sub
End Class