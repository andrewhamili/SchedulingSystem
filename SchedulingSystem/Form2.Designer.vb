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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAssignSched = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Radiosortthenprofessor = New System.Windows.Forms.RadioButton()
        Me.Radiosortthenday = New System.Windows.Forms.RadioButton()
        Me.Radiosortthenroom = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radiosortbyprofessor = New System.Windows.Forms.RadioButton()
        Me.Radiosortbyroom = New System.Windows.Forms.RadioButton()
        Me.Radiosortbyday = New System.Windows.Forms.RadioButton()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.FacultyList = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnChangeSchoolyearSemester = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAccountManagement = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.ScheduleManagement.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
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
        Me.TabControl.Location = New System.Drawing.Point(1, 83)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1268, 504)
        Me.TabControl.TabIndex = 1
        '
        'ScheduleManagement
        '
        Me.ScheduleManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ScheduleManagement.Controls.Add(Me.TabControl2)
        Me.ScheduleManagement.Location = New System.Drawing.Point(4, 27)
        Me.ScheduleManagement.Name = "ScheduleManagement"
        Me.ScheduleManagement.Padding = New System.Windows.Forms.Padding(3)
        Me.ScheduleManagement.Size = New System.Drawing.Size(1260, 473)
        Me.ScheduleManagement.TabIndex = 0
        Me.ScheduleManagement.Text = "Schedule Management"
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(0, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1260, 474)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.PictureBox1)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.btnAssignSched)
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1252, 440)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "View Schedule"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SchedulingSystem.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(1126, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(993, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 52)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Unassign Schedule"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAssignSched
        '
        Me.btnAssignSched.Location = New System.Drawing.Point(876, 104)
        Me.btnAssignSched.Name = "btnAssignSched"
        Me.btnAssignSched.Size = New System.Drawing.Size(111, 52)
        Me.btnAssignSched.TabIndex = 3
        Me.btnAssignSched.Text = "Assign Schedule"
        Me.btnAssignSched.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1246, 275)
        Me.DataGridView1.TabIndex = 2
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
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 30)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1252, 440)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Schedule Maintenance"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'FacultyList
        '
        Me.FacultyList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FacultyList.Location = New System.Drawing.Point(4, 27)
        Me.FacultyList.Name = "FacultyList"
        Me.FacultyList.Padding = New System.Windows.Forms.Padding(3)
        Me.FacultyList.Size = New System.Drawing.Size(1260, 473)
        Me.FacultyList.TabIndex = 1
        Me.FacultyList.Text = "Faculty"
        '
        'Label1
        '
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
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(512, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Semester:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(652, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "2015-2016"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(652, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "1st"
        '
        'btnChangeSchoolyearSemester
        '
        Me.btnChangeSchoolyearSemester.Location = New System.Drawing.Point(758, 28)
        Me.btnChangeSchoolyearSemester.Name = "btnChangeSchoolyearSemester"
        Me.btnChangeSchoolyearSemester.Size = New System.Drawing.Size(74, 29)
        Me.btnChangeSchoolyearSemester.TabIndex = 6
        Me.btnChangeSchoolyearSemester.Text = "Change"
        Me.btnChangeSchoolyearSemester.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1099, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(161, 45)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log-out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnAccountManagement
        '
        Me.btnAccountManagement.Location = New System.Drawing.Point(1099, 59)
        Me.btnAccountManagement.Name = "btnAccountManagement"
        Me.btnAccountManagement.Size = New System.Drawing.Size(161, 45)
        Me.btnAccountManagement.TabIndex = 8
        Me.btnAccountManagement.Text = "Account Management"
        Me.btnAccountManagement.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TabControl.ResumeLayout(False)
        Me.ScheduleManagement.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents ScheduleManagement As System.Windows.Forms.TabPage
    Friend WithEvents FacultyList As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAssignSched As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Radiosortthenprofessor As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosortthenday As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosortthenroom As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Radiosortbyprofessor As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosortbyroom As System.Windows.Forms.RadioButton
    Friend WithEvents Radiosortbyday As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeSchoolyearSemester As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAccountManagement As System.Windows.Forms.Button
End Class
