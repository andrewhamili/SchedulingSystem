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
        End If
    End Sub
    Public Sub AllSched()
        Dim schoolyeartext As String = "SchoolYear: " & My.Settings.schoolyear
        Dim semestertext As String = "Semester: " & My.Settings.semester
        Dim schoolyear As New ReportParameter("ReportParameterSchoolYear", schoolyeartext)
        Dim semester As New ReportParameter("ReportParameterSemester", semestertext)

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Schedules.rdlc"

        ReportViewer1.LocalReport.SetParameters(schoolyear)
        ReportViewer1.LocalReport.SetParameters(semester)

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data.Tables(0)))

        ReportViewer1.DocumentMapCollapsed = True
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 75

        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub AllSubjects()
        Dim schoolyeartext As String = "SchoolYear: " & My.Settings.schoolyear
        Dim semestertext As String = "Semester: " & My.Settings.semester
        Dim schoolyear As New ReportParameter("ReportParameterSchoolYear", schoolyeartext)
        Dim semester As New ReportParameter("ReportParameterSemester", semestertext)

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\Subjects.rdlc"

        ReportViewer1.LocalReport.SetParameters(schoolyear)
        ReportViewer1.LocalReport.SetParameters(semester)

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data.Tables(1)))

        ReportViewer1.DocumentMapCollapsed = True
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 75

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class