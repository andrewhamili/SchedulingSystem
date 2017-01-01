Imports MySql.Data.MySqlClient
Class UnassignSchedule

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property
    Private Sub UnassignSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBoxClasscode
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        End With
        lblSubjDesc.Text = ""
        lblSubjDay.Text = ""
        lblTimeStart.Text = ""
        lblTimeEnd.Text = ""
        lblUnits.Text = ""
        lblProfessor.Text = ""
        lblSubjRoom.Text = ""
        Load_Assigned_Classcodes()
    End Sub

    Private Sub UnassignSchedule_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Public Sub Load_Assigned_Classcodes()
        ComboBoxClasscode.Items.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "`", MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ComboBoxClasscode.Items.Add(reader.GetString("classcode"))
                ComboBoxClasscode.AutoCompleteCustomSource.Add(reader.GetString("classcode"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btnUnassign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnassign.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        If ComboBoxClasscode.Text = "" Then
            MsgBox("Please choose a classcode first!", MsgBoxStyle.Critical, SystemTitle)
        ElseIf lblSubjDesc.Text = "" Then
            MsgBox("The Classcode you have entered is either not yet assigned to a Professor or it does not exist! Please try again.", MsgBoxStyle.Critical, SystemTitle)
        Else
            Dim answer As DialogResult
            answer = MsgBox("Are you sure you want to Unassign this subject to " & lblProfessor.Text & "", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
            If answer = Windows.Forms.DialogResult.Yes Then
                Try
                    MySQLConn.Open()
                    comm = New MySqlCommand("DELETE FROM `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE classcode=@classcode;", MySQLConn)
                    comm.Parameters.AddWithValue("classcode", ComboBoxClasscode.Text)
                    comm.ExecuteReader()
                    MySQLConn.Close()
                    MySQLConn.Open()
                    comm = New MySqlCommand("UPDATE `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` SET isAssigned='false' WHERE classcode=@classcode", MySQLConn)
                    comm.Parameters.AddWithValue("classcode", ComboBoxClasscode.Text)
                    comm.ExecuteReader()
                    With ComboBoxClasscode
                        .AutoCompleteCustomSource.Remove(ComboBoxClasscode.Text)
                        .Items.Remove(ComboBoxClasscode.Text)
                        .AutoCompleteCustomSource.Remove(ComboBoxClasscode.Text)
                        .Enabled = True
                    End With
                    MySQLConn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    MySQLConn.Dispose()
                End Try
            End If
        End If
        lblSubjDesc.Text = ""
        lblSubjDay.Text = ""
        lblTimeStart.Text = ""
        lblTimeEnd.Text = ""
        lblUnits.Text = ""
        lblProfessor.Text = ""
        lblSubjRoom.Text = ""
        With ComboBoxClasscode
            .Enabled = True
            .Text = ""
        End With
        AdminPage.dbdataset.Clear()
        AdminPage.Load_Schedules()
        ComboBoxClasscode.Focus()
    End Sub
    Private Sub ComboBoxClasscode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxClasscode.SelectedIndexChanged
        ComboBoxClasscode.Enabled = False
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring & database
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM `assignedsubj" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE classcode=@classcode", MySQLConn)
            comm.Parameters.AddWithValue("classcode", ComboBoxClasscode.Text)
            reader = comm.ExecuteReader
            While reader.Read
                lblSubjDesc.Text = reader.GetString("subj_desc")
                lblSubjDay.Text = reader.GetString("day")
                lblSubjRoom.Text = reader.GetString("room")
                lblTimeStart.Text = reader.GetString("TimeStart")
                lblTimeEnd.Text = reader.GetString("TimeEnd")
                lblProfessor.Text = reader.GetString("instructor")
                lblUnits.Text = reader.GetString("units")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class