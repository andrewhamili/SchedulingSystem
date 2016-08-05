Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms


Public Class ReportWindow





    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Param As CreateParams = MyBase.CreateParams
            Param.ClassStyle = Param.ClassStyle Or &H200
            Return Param
        End Get
    End Property

    Private Sub ReportWindow_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate

    End Sub
    Private Sub ReportWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim loggedinname As String = activeuserlname + ", " + activeuserfname

        Dim TotalUnitAssigned As New ReportParameter("TotalUnits", UserWindow.totalunit)
        Dim UserRealName As New ReportParameter("ProfName", loggedinname)
        Dim labeltotalunits As New ReportParameter("ReportTotalUnitsText", UserWindow.Label2.Text)
        Dim reportowner As New ReportParameter("ReportOwnerLabel", UserWindow.ownerlabel)
        Dim SchedSchoolYear As New ReportParameter("ReportParameterSchoolYear", "School Year:  " & My.Settings.schoolyear)
        Dim SchedSemester As New ReportParameter("ReportParameterSemester", "Semester:  " & My.Settings.semester)
        MySQLConn.ConnectionString = connstring

        Try


            If MySQLConn.State = ConnectionState.Closed Then
                MySQLConn.Open()
            End If


        Catch ex As Exception

            MsgBox("There was a problem connecting to MySQL Server." & ex.Message & "", MsgBoxStyle.Critical)

        End Try

        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet1
        adapter.SelectCommand = New MySqlCommand(reportwindowquery, MySQLConn)
        adapter.Fill(ds.Tables(0))


        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()



        If activeusertype = "User" Then
            ReportViewer1.LocalReport.SetParameters(UserRealName)
            ReportViewer1.LocalReport.SetParameters(TotalUnitAssigned)
        End If
        ReportViewer1.LocalReport.SetParameters(labeltotalunits)
        ReportViewer1.LocalReport.SetParameters(reportowner)
        ReportViewer1.LocalReport.SetParameters(SchedSchoolYear)
        ReportViewer1.LocalReport.SetParameters(SchedSemester)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

        '
        ReportViewer1.DocumentMapCollapsed = True



        ReportViewer1.RefreshReport()


    End Sub

    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click

        MySQLConn.Close()
        MySQLConn.Dispose()

        If activeusertype = "Administrator" Then
            Me.Dispose()
            Form2.Show()
        Else
            Me.Dispose()
            UserWindow.Show()
        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class