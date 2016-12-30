Imports MySql.Data.MySqlClient
Class ManageSchedule

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property
    Public daytext As String

    Private Sub ScheduleManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Classcodes()
        Panel1.Hide()
    End Sub
    Public Sub Load_Classcodes()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        With ComboBoxClasscode
            Try
                MySQLConn.Open()
                comm = New MySqlCommand("SELECT classcode FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "`", MySQLConn)
                reader = comm.ExecuteReader
                While reader.Read
                    .Items.Add(reader.GetString("classcode"))
                    .AutoCompleteCustomSource.Add(reader.GetString("classcode"))
                End While
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End With
    End Sub

    Private Sub ComboBoxClasscode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxClasscode.SelectedIndexChanged


        'Dim mo As Boolean

        'Dim tu As Boolean

        'Dim we As Boolean

        'Dim th As Boolean

        'Dim fr As Boolean

        'Dim sa As Boolean

        ComboBoxClasscode.Enabled = False
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM `subjectlist" & My.Settings.schoolyear & "" & My.Settings.semester & "` WHERE classcode=@classcode", MySQLConn)
            comm.Parameters.AddWithValue("classcode", ComboBoxClasscode.Text)
            reader = comm.ExecuteReader
            While reader.Read
                txtSubjDesc.Text = reader.GetString("subj_desc")
                txtUnit.Text = reader.GetString("subj_unit")
                daytext = reader.GetString("day")
                DateTimePickertimefrom.Text = reader.GetString("TimeFrom")
                DateTimePickertimeto.Text = reader.GetString("TimeTo")
                ComboBoxRoom.Text = reader.GetString("room")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

        If daytext.Contains("Mo") Then
            CheckBoxDay_mo.Checked = True
        End If

        If daytext.Contains("Tu") Then
            CheckBoxDay_tu.Checked = True
        End If

        If daytext.Contains("We") Then
            CheckBoxDay_we.Checked = True
        End If

        If daytext.Contains("Th") Then
            CheckBoxDay_th.Checked = True
        End If

        If daytext.Contains("Fr") Then
            CheckBoxDay_fr.Checked = True
        End If

        If daytext.Contains("Sa") Then
            CheckBoxDay_sa.Checked = True
        End If

        btnCancel.Enabled = False
        Panel1.Show()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim resetWindow As New ManageSchedule
        Me.Dispose()
        resetWindow.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel1.Click
        Me.Dispose()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click

        Dim change As Boolean = False

        Dim tempSubjDesc As String = txtSubjDesc.Text
        Dim tempSubjUnit As String = txtUnit.Text
        Dim tempDaytext As String = daytext
        Dim tempTimeFrom As String = DateTimePickertimefrom.Text
        Dim tempTimeTo As String = DateTimePickertimeto.Text
        Dim tempRoom As String = ComboBoxRoom.Text

        Dim mo As Boolean = CheckBoxDay_mo.Checked

        Dim tu As Boolean = CheckBoxDay_mo.Checked

        Dim we As Boolean = CheckBoxDay_mo.Checked

        Dim th As Boolean = CheckBoxDay_mo.Checked

        Dim fr As Boolean = CheckBoxDay_mo.Checked

        Dim sa As Boolean = CheckBoxDay_mo.Checked

        daytext = ""

        If mo = True Then
            daytext = daytext + "Mo"
        End If

        If tu = True Then
            daytext = daytext + "Tu"
        End If

        If we = True Then
            daytext = daytext + "We"
        End If

        If th = True Then
            daytext = daytext + "Th"
        End If

        If fr = True Then
            daytext = daytext + "Fr"
        End If

        If sa = True Then
            daytext = daytext + "Mo"
        End If

        If tempSubjDesc <> txtSubjDesc.Text Then
            change = True
        End If

        If tempSubjUnit <> txtUnit.Text Then
            change = True
        End If

        If tempDaytext <> daytext Then
            change = True
        End If

        If tempTimeFrom <> txtSubjDesc.Text Then
            change = True
        End If

        If tempTimeTo <> txtSubjDesc.Text Then
            change = True
        End If

        If tempSubjDesc <> txtSubjDesc.Text Then
            change = True
        End If

        If change = True Then
            MsgBox("Change")
        Else
            MsgBox("No modification to be saved", MsgBoxStyle.Information, SystemTitle)
        End If

    End Sub
End Class