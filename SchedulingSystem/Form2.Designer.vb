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
        Me.lblName = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ScheduleManagement = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabSchedule = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAssignSched = New System.Windows.Forms.Button()
        Me.DataGridSched = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Radiosortthenprofessor = New System.Windows.Forms.RadioButton()
        Me.Radiosortthenday = New System.Windows.Forms.RadioButton()
        Me.Radiosortthenroom = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radiosortbyprofessor = New System.Windows.Forms.RadioButton()
        Me.Radiosortbyroom = New System.Windows.Forms.RadioButton()
        Me.Radiosortbyday = New System.Windows.Forms.RadioButton()
        Me.TabSubject = New System.Windows.Forms.TabPage()
        Me.btnManageSchedule = New System.Windows.Forms.Button()
        Me.btnAddSchedule = New System.Windows.Forms.Button()
        Me.lblTotalSubjects = New System.Windows.Forms.Label()
        Me.DataGridSubjects = New System.Windows.Forms.DataGridView()
        Me.FacultyList = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCurrentSchoolYear = New System.Windows.Forms.TextBox()
        Me.txtCurrentSemester = New System.Windows.Forms.TextBox()
        Me.btnChangeSchoolyearSemester = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAccountManagement = New System.Windows.Forms.Button()
        Me.DataGridViewFacultyList = New System.Windows.Forms.DataGridView()
        Me.TabControl.SuspendLayout()
        Me.ScheduleManagement.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabSchedule.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabSubject.SuspendLayout()
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
        Me.TabControl.Controls.Add(Me.ScheduleManagement)
        Me.TabControl.Controls.Add(Me.FacultyList)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Bottom
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
        Me.TabSchedule.Controls.Add(Me.PictureBox1)
        Me.TabSchedule.Controls.Add(Me.Button1)
        Me.TabSchedule.Controls.Add(Me.btnAssignSched)
        Me.TabSchedule.Controls.Add(Me.DataGridSched)
        Me.TabSchedule.Controls.Add(Me.GroupBox2)
        Me.TabSchedule.Controls.Add(Me.GroupBox1)
        Me.TabSchedule.Location = New System.Drawing.Point(4, 30)
        Me.TabSchedule.Name = "TabSchedule"
        Me.TabSchedule.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSchedule.Size = New System.Drawing.Size(1250, 440)
        Me.TabSchedule.TabIndex = 0
        Me.TabSchedule.Text = "View Schedule"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SchedulingSystem.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(1126, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(993, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 52)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Unassign Schedule"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAssignSched
        '
        Me.btnAssignSched.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAssignSched.Location = New System.Drawing.Point(876, 109)
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
        Me.DataGridSched.Location = New System.Drawing.Point(3, 162)
        Me.DataGridSched.Name = "DataGridSched"
        Me.DataGridSched.ReadOnly = True
        Me.DataGridSched.RowHeadersVisible = False
        Me.DataGridSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSched.Size = New System.Drawing.Size(1244, 275)
        Me.DataGridSched.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Radiosortthenprofessor)
        Me.GroupBox2.Controls.Add(Me.Radiosortthenday)
        Me.GroupBox2.Controls.Add(Me.Radiosortthenroom)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 65)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Then"
        '
        'Radiosortthenprofessor
        '
        Me.Radiosortthenprofessor.AutoSize = True
        Me.Radiosortthenprofessor.Location = New System.Drawing.Point(157, 29)
        Me.Radiosortthenprofessor.Name = "Radiosortthenprofessor"
        Me.Radiosortthenprofessor.Size = New System.Drawing.Size(113, 27)
        Me.Radiosortthenprofessor.TabIndex = 2
        Me.Radiosortthenprofessor.TabStop = True
        Me.Radiosortthenprofessor.Text = "Professor"
        Me.Radiosortthenprofessor.UseVisualStyleBackColor = True
        '
        'Radiosortthenday
        '
        Me.Radiosortthenday.AutoSize = True
        Me.Radiosortthenday.Location = New System.Drawing.Point(6, 29)
        Me.Radiosortthenday.Name = "Radiosortthenday"
        Me.Radiosortthenday.Size = New System.Drawing.Size(61, 27)
        Me.Radiosortthenday.TabIndex = 0
        Me.Radiosortthenday.TabStop = True
        Me.Radiosortthenday.Text = "Day"
        Me.Radiosortthenday.UseVisualStyleBackColor = True
        '
        'Radiosortthenroom
        '
        Me.Radiosortthenroom.AutoSize = True
        Me.Radiosortthenroom.Location = New System.Drawing.Point(73, 29)
        Me.Radiosortthenroom.Name = "Radiosortthenroom"
        Me.Radiosortthenroom.Size = New System.Drawing.Size(78, 27)
        Me.Radiosortthenroom.TabIndex = 1
        Me.Radiosortthenroom.TabStop = True
        Me.Radiosortthenroom.Text = "Room"
        Me.Radiosortthenroom.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Radiosortbyprofessor)
        Me.GroupBox1.Controls.Add(Me.Radiosortbyroom)
        Me.GroupBox1.Controls.Add(Me.Radiosortbyday)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "By"
        '
        'Radiosortbyprofessor
        '
        Me.Radiosortbyprofessor.AutoSize = True
        Me.Radiosortbyprofessor.Location = New System.Drawing.Point(157, 29)
        Me.Radiosortbyprofessor.Name = "Radiosortbyprofessor"
        Me.Radiosortbyprofessor.Size = New System.Drawing.Size(113, 27)
        Me.Radiosortbyprofessor.TabIndex = 2
        Me.Radiosortbyprofessor.TabStop = True
        Me.Radiosortbyprofessor.Text = "Professor"
        Me.Radiosortbyprofessor.UseVisualStyleBackColor = True
        '
        'Radiosortbyroom
        '
        Me.Radiosortbyroom.AutoSize = True
        Me.Radiosortbyroom.Location = New System.Drawing.Point(73, 29)
        Me.Radiosortbyroom.Name = "Radiosortbyroom"
        Me.Radiosortbyroom.Size = New System.Drawing.Size(78, 27)
        Me.Radiosortbyroom.TabIndex = 1
        Me.Radiosortbyroom.TabStop = True
        Me.Radiosortbyroom.Text = "Room"
        Me.Radiosortbyroom.UseVisualStyleBackColor = True
        '
        'Radiosortbyday
        '
        Me.Radiosortbyday.AutoSize = True
        Me.Radiosortbyday.Location = New System.Drawing.Point(6, 29)
        Me.Radiosortbyday.Name = "Radiosortbyday"
        Me.Radiosortbyday.Size = New System.Drawing.Size(61, 27)
        Me.Radiosortbyday.TabIndex = 0
        Me.Radiosortbyday.TabStop = True
        Me.Radiosortbyday.Text = "Day"
        Me.Radiosortbyday.UseVisualStyleBackColor = True
        '
        'TabSubject
        '
        Me.TabSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
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
        'btnManageSchedule
        '
        Me.btnManageSchedule.Location = New System.Drawing.Point(1122, 77)
        Me.btnManageSchedule.Name = "btnManageSchedule"
        Me.btnManageSchedule.Size = New System.Drawing.Size(122, 49)
        Me.btnManageSchedule.TabIndex = 3
        Me.btnManageSchedule.Text = "Edit / Delete Schedule"
        Me.btnManageSchedule.UseVisualStyleBackColor = True
        '
        'btnAddSchedule
        '
        Me.btnAddSchedule.Location = New System.Drawing.Point(994, 75)
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
        'DataGridViewFacultyList
        '
        Me.DataGridViewFacultyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFacultyList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewFacultyList.Location = New System.Drawing.Point(3, 320)
        Me.DataGridViewFacultyList.Name = "DataGridViewFacultyList"
        Me.DataGridViewFacultyList.Size = New System.Drawing.Size(1258, 150)
        Me.DataGridViewFacultyList.TabIndex = 0
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "AdminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TabControl.ResumeLayout(False)
        Me.ScheduleManagement.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabSchedule.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabSubject.ResumeLayout(False)
        Me.TabSubject.PerformLayout()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Radiosortthenprofessor As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosortthenday As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosortthenroom As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Radiosortbyprofessor As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosortbyroom As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosortbyday As System.Windows.Forms.RadioButton
    Friend WithEvents TabSubject As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentSchoolYear As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentSemester As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeSchoolyearSemester As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAccountManagement As System.Windows.Forms.Button
    Friend WithEvents DataGridSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotalSubjects As System.Windows.Forms.Label
    Friend WithEvents btnManageSchedule As System.Windows.Forms.Button
    Friend WithEvents btnAddSchedule As System.Windows.Forms.Button
    Friend WithEvents DataGridViewFacultyList As System.Windows.Forms.DataGridView
End Class
