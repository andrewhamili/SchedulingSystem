Imports Microsoft.Reporting.WinForms

Public Class PrintWindow

    Private Sub PrintWindow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub PrintWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If PrintAction = "AllSched" Then
            AllSched()
        ElseIf PrintAction = "AllSubjects" Then
            AllSubjects()
        ElseIf PrintAction = "Single" Then
            SingleSched()
        ElseIf PrintAction = "Single-user" Then
            SingleSched2()
        End If
    End Sub
    Public Sub AllSched()
        Dim schoolyeartext As String = "SchoolYear: " & schoolyear & ""
        Dim semestertext As String = "Semester: " & semester & ""
        Dim schoolyeartexts As New ReportParameter("ReportParameterSchoolYear", schoolyeartext)
        Dim semestertexts As New ReportParameter("ReportParameterSemester", semestertext)
        

        

        With ReportViewer1
            .LocalReport.DataSources.Clear()
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Schedules.rdlc"

            .LocalReport.SetParameters(schoolyeartexts)
            .LocalReport.SetParameters(semestertexts)
            

            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data.Tables(0)))

            .DocumentMapCollapsed = True
            .SetDisplayMode(DisplayMode.PrintLayout)
            .ZoomMode = ZoomMode.Percent
            .ZoomPercent = 75

        End With
        

        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub AllSubjects()
        Dim schoolyeartext As String = "SchoolYear: " & schoolyear
        Dim semestertext As String = "Semester: " & semester
        Dim schoolyeartexts As New ReportParameter("ReportParameterSchoolYear", schoolyeartext)
        Dim semestertexts As New ReportParameter("ReportParameterSemester", semestertext)

        With ReportViewer1
            .LocalReport.DataSources.Clear()
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Subjects.rdlc"

            .LocalReport.SetParameters(schoolyeartexts)
            .LocalReport.SetParameters(semestertexts)

            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data.Tables(1)))

            .DocumentMapCollapsed = True
            .SetDisplayMode(DisplayMode.PrintLayout)
            .ZoomMode = ZoomMode.Percent
            .ZoomPercent = 75
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub SingleSched()
        Dim schoolyeartext As String = "SchoolYear: " & SchoolYear
        Dim semestertext As String = "Semester: " & Semester
        Dim schoolyeartexts As New ReportParameter("ReportParameterSchoolYear", schoolyeartext)
        Dim semestertexts As New ReportParameter("ReportParameterSemester", semestertext)

        Dim profname As New ReportParameter("ProfName", FacultySched.instrname)
        Dim totalunit As New ReportParameter("TotalUnits", FacultySched.lbltotalunit.Text)


        With ReportViewer1
            .LocalReport.DataSources.Clear()
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Schedule-Single.rdlc"

            .LocalReport.SetParameters(schoolyeartexts)
            .LocalReport.SetParameters(semestertexts)
            .LocalReport.SetParameters(profname)
            .LocalReport.SetParameters(totalunit)


            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data.Tables(2)))

            .DocumentMapCollapsed = True
            .SetDisplayMode(DisplayMode.PrintLayout)
            .ZoomMode = ZoomMode.Percent
            .ZoomPercent = 75
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub SingleSched2()
        Dim schoolyeartext As String = "SchoolYear: " & SchoolYear
        Dim semestertext As String = "Semester: " & Semester
        Dim schoolyeartexts As New ReportParameter("ReportParameterSchoolYear", schoolyeartext)
        Dim semestertexts As New ReportParameter("ReportParameterSemester", semestertext)

        Dim profname As New ReportParameter("ProfName", UserWindow.instrname)
        Dim totalunit As New ReportParameter("TotalUnits", UserWindow.lblTotalUnit.Text)


        With ReportViewer1
            .LocalReport.DataSources.Clear()
            .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            .LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Schedule-Single.rdlc"

            .LocalReport.SetParameters(schoolyeartexts)
            .LocalReport.SetParameters(semestertexts)
            .LocalReport.SetParameters(profname)
            .LocalReport.SetParameters(totalunit)


            .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data.Tables(2)))

            .DocumentMapCollapsed = True
            .SetDisplayMode(DisplayMode.PrintLayout)
            .ZoomMode = ZoomMode.Percent
            .ZoomPercent = 75
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class