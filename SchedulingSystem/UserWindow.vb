Imports MySql.Data.MySqlClient
Public Class UserWindow

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property

    Public totalunit As Integer
    Public ownerlabel As String = ""

    Private Sub UserWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If closinglistener = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub UserWindow_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

        MySQLConn.Close()


        Me.Text = activeuserfname + " " + activeusermname + " " + activeuserlname
        Dim loggedinname As String
        loggedinname = activeuserlname + ", " + activeuserfname

        MySQLConn.ConnectionString = connstring
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, TimeStart as 'From', TimeEnd as 'To', instructor as Instructor, units as 'Unit' from assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & " where instructor='" & loggedinname & "' order by day asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridMySched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub UserWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Total Unit(s):"
        LabelTotalUnits.Hide()
        LabelSchoolYear.Text = "School Year:   " & My.Settings.schoolyear
        LabelSemester.Text = "School Year:   " & My.Settings.semester
        MySQLConn.Close()


        Me.Text = activeuserfname + " " + activeusermname + " " + activeuserlname
        Dim loggedinname As String
        loggedinname = activeuserlname + ", " + activeuserfname

        MySQLConn.ConnectionString = connstring
        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try

            MySQLConn.Open()
            printquery = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, Time_format(TimeStart,  '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where instructor='" & loggedinname & "' order by day desc"
            comm = New MySqlCommand(printquery, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridMySched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        Dim myname As String = activeuserlname & ", " & activeuserfname & ""
        Dim today As String = Format(Now, "MMMMM dd, yyyy")

        Dim datagridcontentcount As Integer

        datagridcontentcount = 0

        datagridcontentcount = DataGridMySched.RowCount

        If datagridcontentcount > 0 Then

            Try

                MySQLConn.Open()
                query = "select sum(units) as UnitsAccumulated from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where instructor='" & myname & "'"
                comm = New MySqlCommand(query, MySQLConn)
                comm = New MySqlCommand(query, MySQLConn)
                reader = comm.ExecuteReader

                While reader.Read

                    totalunit = reader.GetString("UnitsAccumulated")

                End While


                MySQLConn.Close()




            Catch ex As MySqlException

                MessageBox.Show(ex.Message)

            Finally
                MySQLConn.Dispose()
            End Try
            LabelTotalUnits.Text = (totalunit)
            MsgBox("The Total Unit(s) assigned to you is  " & totalunit & " as of " & today & "", MsgBoxStyle.Information, "Total Units Assigned")
            LabelTotalUnits.Show()
        Else
            MsgBox("There are no subjects that are cuurently assigned to you, Contact the Administrator for details. Thank you very much!", MsgBoxStyle.Critical, "No Assigned Schedules")
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        closinglistener = True
        Me.Close()
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.Show()
        Form1.TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MySQLConn.ConnectionString = connstring
        Dim myname As String = activeuserlname & ", " & activeuserfname & ""
        Dim totalunit As Integer
        Dim today As String = Format(Now, "MMMMM dd, yyyy")


        Try

            MySQLConn.Open()
            query = "select sum(units) as UnitsAccumulated from assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & " where instructor='" & myname & "'"
            comm = New MySqlCommand(query, MySQLConn)
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            While reader.Read

                totalunit = reader.GetString("UnitsAccumulated")

            End While


            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
        LabelTotalUnits.Text = ("You have accumulated " & totalunit & " unit(s) as of " & today & "")
        MsgBox("" & LabelTotalUnits.Text & "", MsgBoxStyle.Information, "Total Units Accumulated")
        LabelTotalUnits.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Cursor = Cursors.WaitCursor
        reportwindowquery = printquery
        ownerlabel = "Schedule for:"
        ReportWindow.Show()
        Me.Cursor = Cursors.Default
        Me.Hide()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        UserWindowViewSubjects.ShowDialog()
    End Sub
End Class