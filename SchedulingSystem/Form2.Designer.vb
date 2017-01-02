<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPage))
        Me.lblName = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ScheduleManagement = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabSchedule = New System.Windows.Forms.TabPage()
        Me.GroupBoxSearch = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchSubjDesc = New System.Windows.Forms.TextBox()
        Me.txtSearchRoom = New System.Windows.Forms.TextBox()
        Me.txtSearchClasscode = New System.Windows.Forms.TextBox()
        Me.PictureBoxPrintSchedules = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAssignSched = New System.Windows.Forms.Button()
        Me.DataGridSched = New System.Windows.Forms.DataGridView()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.TabSubject = New System.Windows.Forms.TabPage()
        Me.PictureBoxPrintSubjects = New System.Windows.Forms.PictureBox()
        Me.btnManageSchedule = New System.Windows.Forms.Button()
        Me.btnAddSchedule = New System.Windows.Forms.Button()
        Me.lblTotalSubjects = New System.Windows.Forms.Label()
        Me.DataGridSubjects = New System.Windows.Forms.DataGridView()
        Me.FacultyList = New System.Windows.Forms.TabPage()
        Me.DataGridViewFacultyList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCurrentSchoolYear = New System.Windows.Forms.TextBox()
        Me.txtCurrentSemester = New System.Windows.Forms.TextBox()
        Me.btnChangeSchoolyearSemester = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAccountManagement = New System.Windows.Forms.Button()
        Me.TimerTimeAndDate = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl.SuspendLayout()
        Me.ScheduleManagement.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabSchedule.SuspendLayout()
        Me.GroupBoxSearch.SuspendLayout()
        CType(Me.PictureBoxPrintSchedules, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSubject.SuspendLayout()
        CType(Me.PictureBoxPrintSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacultyList.SuspendLayout()
        CType(Me.DataGridViewFacultyList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(232, 29)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Welcome!, Group 3"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.ScheduleManagement)
        Me.TabControl.Controls.Add(Me.FacultyList)
        Me.TabControl.Location = New System.Drawing.Point(0, 86)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1272, 504)
        Me.TabControl.TabIndex = 1
        '
        'ScheduleManagement
        '
        Me.ScheduleManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ScheduleManagement.Controls.Add(Me.TabControl2)
        Me.ScheduleManagement.Location = New System.Drawing.Point(4, 27)
        Me.ScheduleManagement.Name = "ScheduleManagement"
        Me.ScheduleManagement.Padding = New System.Windows.Forms.Padding(3)
        Me.ScheduleManagement.Size = New System.Drawing.Size(1264, 473)
        Me.ScheduleManagement.TabIndex = 0
        Me.ScheduleManagement.Text = "Schedule Management"
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.TabSchedule)
        Me.TabControl2.Controls.Add(Me.TabSubject)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl2.Location = New System.Drawing.Point(3, -4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1258, 474)
        Me.TabControl2.TabIndex = 1
        '
        'TabSchedule
        '
        Me.TabSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabSchedule.Controls.Add(Me.GroupBoxSearch)
        Me.TabSchedule.Controls.Add(Me.PictureBoxPrintSchedules)
        Me.TabSchedule.Controls.Add(Me.Button1)
        Me.TabSchedule.Controls.Add(Me.btnAssignSched)
        Me.TabSchedule.Controls.Add(Me.DataGridSched)
        Me.TabSchedule.Controls.Add(Me.lblSearch)
        Me.TabSchedule.Location = New System.Drawing.Point(4, 30)
        Me.TabSchedule.Name = "TabSchedule"
        Me.TabSchedule.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSchedule.Size = New System.Drawing.Size(1250, 440)
        Me.TabSchedule.TabIndex = 0
        Me.TabSchedule.Text = "View Schedule"
        '
        'GroupBoxSearch
        '
        Me.GroupBoxSearch.Controls.Add(Me.Label5)
        Me.GroupBoxSearch.Controls.Add(Me.Label4)
        Me.GroupBoxSearch.Controls.Add(Me.Label3)
        Me.GroupBoxSearch.Controls.Add(Me.txtSearchSubjDesc)
        Me.GroupBoxSearch.Controls.Add(Me.txtSearchRoom)
        Me.GroupBoxSearch.Controls.Add(Me.txtSearchClasscode)
        Me.GroupBoxSearch.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.GroupBoxSearch.Location = New System.Drawing.Point(10, 21)
        Me.GroupBoxSearch.Name = "GroupBoxSearch"
        Me.GroupBoxSearch.Size = New System.Drawing.Size(570, 120)
        Me.GroupBoxSearch.TabIndex = 6
        Me.GroupBoxSearch.TabStop = False
        Me.GroupBoxSearch.Text = "Search"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(408, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Room"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(210, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(50, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Classcode"
        '
        'txtSearchSubjDesc
        '
        Me.txtSearchSubjDesc.Location = New System.Drawing.Point(187, 60)
        Me.txtSearchSubjDesc.Name = "txtSearchSubjDesc"
        Me.txtSearchSubjDesc.Size = New System.Drawing.Size(144, 30)
        Me.txtSearchSubjDesc.TabIndex = 2
        '
        'txtSearchRoom
        '
        Me.txtSearchRoom.Location = New System.Drawing.Point(355, 60)
        Me.txtSearchRoom.Name = "txtSearchRoom"
        Me.txtSearchRoom.Size = New System.Drawing.Size(152, 30)
        Me.txtSearchRoom.TabIndex = 1
        '
        'txtSearchClasscode
        '
        Me.txtSearchClasscode.Location = New System.Drawing.Point(17, 60)
        Me.txtSearchClasscode.Name = "txtSearchClasscode"
        Me.txtSearchClasscode.Size = New System.Drawing.Size(151, 30)
        Me.txtSearchClasscode.TabIndex = 0
        '
        'PictureBoxPrintSchedules
        '
        Me.PictureBoxPrintSchedules.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxPrintSchedules.Image = Global.SchedulingSystem.My.Resources.Resources.giphy
        Me.PictureBoxPrintSchedules.Location = New System.Drawing.Point(1135, 118)
        Me.PictureBoxPrintSchedules.Name = "PictureBoxPrintSchedules"
        Me.PictureBoxPrintSchedules.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxPrintSchedules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPrintSchedules.TabIndex = 5
        Me.PictureBoxPrintSchedules.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1005, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 52)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Unassign Schedule"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAssignSched
        '
        Me.btnAssignSched.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAssignSched.Location = New System.Drawing.Point(888, 118)
        Me.btnAssignSched.Name = "btnAssignSched"
        Me.btnAssignSched.Size = New System.Drawing.Size(111, 52)
        Me.btnAssignSched.TabIndex = 3
        Me.btnAssignSched.Text = "Assign Schedule"
        Me.btnAssignSched.UseVisualStyleBackColor = True
        '
        'DataGridSched
        '
        Me.DataGridSched.AllowUserToAddRows = False
        Me.DataGridSched.AllowUserToDeleteRows = False
        Me.DataGridSched.AllowUserToResizeRows = False
        Me.DataGridSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSched.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridSched.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridSched.Location = New System.Drawing.Point(3, 176)
        Me.DataGridSched.Name = "DataGridSched"
        Me.DataGridSched.ReadOnly = True
        Me.DataGridSched.RowHeadersVisible = False
        Me.DataGridSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSched.Size = New System.Drawing.Size(1244, 261)
        Me.DataGridSched.TabIndex = 2
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblSearch.Location = New System.Drawing.Point(6, 81)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(225, 23)
        Me.lblSearch.TabIndex = 7
        Me.lblSearch.Text = "Press CTRL+F to Search"
        '
        'TabSubject
        '
        Me.TabSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabSubject.Controls.Add(Me.PictureBoxPrintSubjects)
        Me.TabSubject.Controls.Add(Me.btnManageSchedule)
        Me.TabSubject.Controls.Add(Me.btnAddSchedule)
        Me.TabSubject.Controls.Add(Me.lblTotalSubjects)
        Me.TabSubject.Controls.Add(Me.DataGridSubjects)
        Me.TabSubject.Location = New System.Drawing.Point(4, 30)
        Me.TabSubject.Name = "TabSubject"
        Me.TabSubject.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSubject.Size = New System.Drawing.Size(1250, 440)
        Me.TabSubject.TabIndex = 1
        Me.TabSubject.Text = "Schedule Maintenance"
        '
        'PictureBoxPrintSubjects
        '
        Me.PictureBoxPrintSubjects.Image = Global.SchedulingSystem.My.Resources.Resources.giphy
        Me.PictureBoxPrintSubjects.Location = New System.Drawing.Point(1120, 75)
        Me.PictureBoxPrintSubjects.Name = "PictureBoxPrintSubjects"
        Me.PictureBoxPrintSubjects.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxPrintSubjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPrintSubjects.TabIndex = 4
        Me.PictureBoxPrintSubjects.TabStop = False
        '
        'btnManageSchedule
        '
        Me.btnManageSchedule.Location = New System.Drawing.Point(991, 77)
        Me.btnManageSchedule.Name = "btnManageSchedule"
        Me.btnManageSchedule.Size = New System.Drawing.Size(122, 49)
        Me.btnManageSchedule.TabIndex = 3
        Me.btnManageSchedule.Text = "Edit / Delete Schedule"
        Me.btnManageSchedule.UseVisualStyleBackColor = True
        '
        'btnAddSchedule
        '
        Me.btnAddSchedule.Location = New System.Drawing.Point(863, 75)
        Me.btnAddSchedule.Name = "btnAddSchedule"
        Me.btnAddSchedule.Size = New System.Drawing.Size(122, 51)
        Me.btnAddSchedule.TabIndex = 2
        Me.btnAddSchedule.Text = "Add Schedule"
        Me.btnAddSchedule.UseVisualStyleBackColor = True
        '
        'lblTotalSubjects
        '
        Me.lblTotalSubjects.AutoSize = True
        Me.lblTotalSubjects.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblTotalSubjects.Location = New System.Drawing.Point(6, 103)
        Me.lblTotalSubjects.Name = "lblTotalSubjects"
        Me.lblTotalSubjects.Size = New System.Drawing.Size(155, 23)
        Me.lblTotalSubjects.TabIndex = 1
        Me.lblTotalSubjects.Text = "lblTotalSubjects"
        '
        'DataGridSubjects
        '
        Me.DataGridSubjects.AllowUserToAddRows = False
        Me.DataGridSubjects.AllowUserToDeleteRows = False
        Me.DataGridSubjects.AllowUserToResizeRows = False
        Me.DataGridSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSubjects.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridSubjects.Location = New System.Drawing.Point(3, 134)
        Me.DataGridSubjects.Name = "DataGridSubjects"
        Me.DataGridSubjects.ReadOnly = True
        Me.DataGridSubjects.RowHeadersVisible = False
        Me.DataGridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSubjects.Size = New System.Drawing.Size(1244, 303)
        Me.DataGridSubjects.TabIndex = 0
        '
        'FacultyList
        '
        Me.FacultyList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FacultyList.Controls.Add(Me.DataGridViewFacultyList)
        Me.FacultyList.Location = New System.Drawing.Point(4, 27)
        Me.FacultyList.Name = "FacultyList"
        Me.FacultyList.Padding = New System.Windows.Forms.Padding(3)
        Me.FacultyList.Size = New System.Drawing.Size(1264, 473)
        Me.FacultyList.TabIndex = 1
        Me.FacultyList.Text = "Faculty"
        '
        'DataGridViewFacultyList
        '
        Me.DataGridViewFacultyList.AllowUserToAddRows = False
        Me.DataGridViewFacultyList.AllowUserToDeleteRows = False
        Me.DataGridViewFacultyList.AllowUserToResizeRows = False
        Me.DataGridViewFacultyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewFacultyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFacultyList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewFacultyList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewFacultyList.Location = New System.Drawing.Point(3, 209)
        Me.DataGridViewFacultyList.Name = "DataGridViewFacultyList"
        Me.DataGridViewFacultyList.ReadOnly = True
        Me.DataGridViewFacultyList.RowHeadersVisible = False
        Me.DataGridViewFacultyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewFacultyList.Size = New System.Drawing.Size(1258, 261)
        Me.DataGridViewFacultyList.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(512, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "School Year:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(512, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Semester:"
        '
        'txtCurrentSchoolYear
        '
        Me.txtCurrentSchoolYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentSchoolYear.Enabled = False
        Me.txtCurrentSchoolYear.Location = New System.Drawing.Point(652, 15)
        Me.txtCurrentSchoolYear.Name = "txtCurrentSchoolYear"
        Me.txtCurrentSchoolYear.Size = New System.Drawing.Size(100, 26)
        Me.txtCurrentSchoolYear.TabIndex = 4
        Me.txtCurrentSchoolYear.Text = "2015-2016"
        '
        'txtCurrentSemester
        '
        Me.txtCurrentSemester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentSemester.Enabled = False
        Me.txtCurrentSemester.Location = New System.Drawing.Point(652, 49)
        Me.txtCurrentSemester.Name = "txtCurrentSemester"
        Me.txtCurrentSemester.Size = New System.Drawing.Size(100, 26)
        Me.txtCurrentSemester.TabIndex = 5
        Me.txtCurrentSemester.Text = "1st"
        '
        'btnChangeSchoolyearSemester
        '
        Me.btnChangeSchoolyearSemester.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangeSchoolyearSemester.Location = New System.Drawing.Point(758, 28)
        Me.btnChangeSchoolyearSemester.Name = "btnChangeSchoolyearSemester"
        Me.btnChangeSchoolyearSemester.Size = New System.Drawing.Size(74, 29)
        Me.btnChangeSchoolyearSemester.TabIndex = 6
        Me.btnChangeSchoolyearSemester.Text = "Change"
        Me.btnChangeSchoolyearSemester.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.Location = New System.Drawing.Point(1099, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(161, 45)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log-out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAccountManagement
        '
        Me.btnAccountManagement.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccountManagement.Location = New System.Drawing.Point(1099, 59)
        Me.btnAccountManagement.Name = "btnAccountManagement"
        Me.btnAccountManagement.Size = New System.Drawing.Size(161, 45)
        Me.btnAccountManagement.TabIndex = 8
        Me.btnAccountManagement.Text = "Account Management"
        Me.btnAccountManagement.UseVisualStyleBackColor = True
        '
        'TimerTimeAndDate
        '
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 590)
        Me.Controls.Add(Me.btnAccountManagement)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnChangeSchoolyearSemester)
        Me.Controls.Add(Me.txtCurrentSemester)
        Me.Controls.Add(Me.txtCurrentSchoolYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "AdminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.TabControl.ResumeLayout(False)
        Me.ScheduleManagement.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabSchedule.ResumeLayout(False)
        Me.TabSchedule.PerformLayout()
        Me.GroupBoxSearch.ResumeLayout(False)
        Me.GroupBoxSearch.PerformLayout()
        CType(Me.PictureBoxPrintSchedules, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSubject.ResumeLayout(False)
        Me.TabSubject.PerformLayout()
        CType(Me.PictureBoxPrintSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacultyList.ResumeLayout(False)
        CType(Me.DataGridViewFacultyList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents ScheduleManagement As System.Windows.Forms.TabPage
    Friend WithEvents FacultyList As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabSchedule As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAssignSched As System.Windows.Forms.Button
    Friend WithEvents DataGridSched As System.Windows.Forms.DataGridView
    Friend WithEvents TabSubject As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentSchoolYear As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentSemester As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeSchoolyearSemester As System.Windows.Forms.Button
    Friend WithEvents PictureBoxPrintSchedules As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAccountManagement As System.Windows.Forms.Button
    Friend WithEvents DataGridSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotalSubjects As System.Windows.Forms.Label
    Friend WithEvents btnManageSchedule As System.Windows.Forms.Button
    Friend WithEvents btnAddSchedule As System.Windows.Forms.Button
    Friend WithEvents GroupBoxSearch As System.Windows.Forms.GroupBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearchSubjDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchRoom As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchClasscode As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxPrintSubjects As System.Windows.Forms.PictureBox
    Friend WithEvents TimerTimeAndDate As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewFacultyList As System.Windows.Forms.DataGridView
End Class
