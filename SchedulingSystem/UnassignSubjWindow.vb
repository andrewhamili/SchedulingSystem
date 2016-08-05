Imports MySql.Data.MySqlClient

Public Class UnassignSubjWindow

    Public subjectcount As Integer
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property

    Private Sub UnassignSubjWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = Button1
        CancelButton = Button2
        MySQLConn.ConnectionString = connstring

        Try
            ComboBoxClasscode.Items.Clear()
            MySQLConn.Open()
            query = "Select * from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by classcode asc"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            While reader.Read
                ComboBoxClasscode.Items.Add(reader.GetString("classcode"))
                ComboBoxClasscode.AutoCompleteCustomSource.Add(reader.GetString("classcode"))
                subjectcount += 1
            End While
            MySQLConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxClasscode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxClasscode.SelectedIndexChanged
        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "select classcode, subj_desc, day, room, time_format(TimeStart, '%H:%i') as 'TimeStart', time_format(TimeEnd, '%H:%i') as 'TimeEnd', units, instructor  from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode='" & ComboBoxClasscode.Text & "'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader

            While reader.Read
                LabelSubj_desc.Text = reader.GetString("subj_desc")
                LabelSubj_unit.Text = reader.GetString("units")
                LabelSubj_day.Text = reader.GetString("day")
                LabelSubJ_TImeFrom.Text = reader.GetString("TimeStart")
                LabelSubj_TimeTo.Text = reader.GetString("TimeEnd")
                LabelRoom.Text = reader.GetString("room")
                LabelProfName.Text = reader.GetString("instructor")
            End While

            MySQLConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()

        End Try
        ComboBoxClasscode.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If LabelSubj_desc.Text <> "" Then

            Dim prompt As Integer
            prompt = MsgBox("Are you sure you want to Unassign this subject to " & LabelProfName.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Unassign?")
            If prompt = 6 Then

                MySQLConn.ConnectionString = connstring

                Try
                    MySQLConn.Open()
                    query = "delete from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` where classcode='" & ComboBoxClasscode.Text & "'"
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MySQLConn.Open()
                    query = "update `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` set isassigned='false' where classcode='" & ComboBoxClasscode.Text & "'"
                    comm = New MySqlCommand(query, MySQLConn)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    ComboBoxClasscode.AutoCompleteCustomSource.Remove(ComboBoxClasscode.Text)
                    ComboBoxClasscode.Items.Remove(ComboBoxClasscode.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    MySQLConn.Dispose()

                End Try
            End If
            LabelSubj_desc.Text = ""
            LabelSubj_day.Text = ""
            LabelSubJ_TImeFrom.Text = ""
            LabelSubj_TimeTo.Text = ""
            LabelSubj_unit.Text = ""
            LabelProfName.Text = ""
            LabelRoom.Text = ""
        Else
            MsgBox("No Classcode selected!", MsgBoxStyle.Critical, "Error")
        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        MySQLConn.ConnectionString = connstring

        Dim adapter As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try



            MySQLConn.Open()
            query = "SELECT classcode as 'Code', subj_desc as 'Description', day as Day, room as Room, time_format(TimeStart, '%H:%i') as 'From', time_format(TimeEnd, '%H:%i') as 'To', instructor as Instructor, units as 'Unit' from `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` order by classcode asc"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            Form2.DataGridSched.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try

        Form2.DataGridSched.Focus()


        Me.Dispose()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class