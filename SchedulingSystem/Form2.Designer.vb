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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPage))
        Me.lblName = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ScheduleManagement = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabSchedule = New System.Windows.Forms.TabPage()
        Me.DataGridSched = New System.Windows.Forms.DataGridView()
        Me.TabSubject = New System.Windows.Forms.TabPage()
        Me.btnManageRoom = New System.Windows.Forms.Button()
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
        Me.ExplorerBar1 = New DevComponents.DotNetBar.ExplorerBar()
        Me.ExplorerBarGroupItemSchedule = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonAssignSched = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonRemoveSched = New DevComponents.DotNetBar.ButtonItem()
        Me.ExplorerBarGroupItemAccounts = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonAddAccount = New DevComponents.DotNetBar.ButtonItem()
        Me.ExplorerBarGroupItemPrinting = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.PictureBoxPrintSubjects = New System.Windows.Forms.PictureBox()
        Me.ButtonPrintAssignedSched = New DevComponents.DotNetBar.ButtonItem()
        Me.ExplorerBarGroupItem1 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.TabControl.SuspendLayout()
        Me.ScheduleManagement.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabSchedule.SuspendLayout()
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSubject.SuspendLayout()
        CType(Me.DataGridSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacultyList.SuspendLayout()
        CType(Me.DataGridViewFacultyList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPrintSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl.Location = New System.Drawing.Point(263, 86)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1009, 504)
        Me.TabControl.TabIndex = 1
        '
        'ScheduleManagement
        '
        Me.ScheduleManagement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ScheduleManagement.Controls.Add(Me.TabControl2)
        Me.ScheduleManagement.Location = New System.Drawing.Point(4, 27)
        Me.ScheduleManagement.Name = "ScheduleManagement"
        Me.ScheduleManagement.Padding = New System.Windows.Forms.Padding(3)
        Me.ScheduleManagement.Size = New System.Drawing.Size(1001, 473)
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
        Me.TabControl2.Size = New System.Drawing.Size(995, 474)
        Me.TabControl2.TabIndex = 1
        '
        'TabSchedule
        '
        Me.TabSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabSchedule.Controls.Add(Me.DataGridSched)
        Me.TabSchedule.Location = New System.Drawing.Point(4, 30)
        Me.TabSchedule.Name = "TabSchedule"
        Me.TabSchedule.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSchedule.Size = New System.Drawing.Size(987, 440)
        Me.TabSchedule.TabIndex = 0
        Me.TabSchedule.Text = "View Schedule"
        '
        'DataGridSched
        '
        Me.DataGridSched.AllowUserToAddRows = False
        Me.DataGridSched.AllowUserToDeleteRows = False
        Me.DataGridSched.AllowUserToResizeRows = False
        Me.DataGridSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSched.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSched.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridSched.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridSched.Location = New System.Drawing.Point(3, 176)
        Me.DataGridSched.Name = "DataGridSched"
        Me.DataGridSched.ReadOnly = True
        Me.DataGridSched.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridSched.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSched.Size = New System.Drawing.Size(981, 261)
        Me.DataGridSched.TabIndex = 2
        '
        'TabSubject
        '
        Me.TabSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabSubject.Controls.Add(Me.btnManageRoom)
        Me.TabSubject.Controls.Add(Me.btnManageSchedule)
        Me.TabSubject.Controls.Add(Me.btnAddSchedule)
        Me.TabSubject.Controls.Add(Me.lblTotalSubjects)
        Me.TabSubject.Controls.Add(Me.DataGridSubjects)
        Me.TabSubject.Controls.Add(Me.PictureBoxPrintSubjects)
        Me.TabSubject.Location = New System.Drawing.Point(4, 30)
        Me.TabSubject.Name = "TabSubject"
        Me.TabSubject.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSubject.Size = New System.Drawing.Size(987, 440)
        Me.TabSubject.TabIndex = 1
        Me.TabSubject.Text = "Schedule Maintenance"
        '
        'btnManageRoom
        '
        Me.btnManageRoom.Location = New System.Drawing.Point(724, 75)
        Me.btnManageRoom.Name = "btnManageRoom"
        Me.btnManageRoom.Size = New System.Drawing.Size(133, 50)
        Me.btnManageRoom.TabIndex = 5
        Me.btnManageRoom.Text = "Manage Rooms"
        Me.btnManageRoom.UseVisualStyleBackColor = True
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
        Me.DataGridSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSubjects.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridSubjects.Location = New System.Drawing.Point(3, 134)
        Me.DataGridSubjects.Name = "DataGridSubjects"
        Me.DataGridSubjects.ReadOnly = True
        Me.DataGridSubjects.RowHeadersVisible = False
        Me.DataGridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSubjects.Size = New System.Drawing.Size(981, 303)
        Me.DataGridSubjects.TabIndex = 0
        '
        'FacultyList
        '
        Me.FacultyList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FacultyList.Controls.Add(Me.DataGridViewFacultyList)
        Me.FacultyList.Location = New System.Drawing.Point(4, 27)
        Me.FacultyList.Name = "FacultyList"
        Me.FacultyList.Padding = New System.Windows.Forms.Padding(3)
        Me.FacultyList.Size = New System.Drawing.Size(1001, 473)
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
        Me.DataGridViewFacultyList.Location = New System.Drawing.Point(3, 214)
        Me.DataGridViewFacultyList.Name = "DataGridViewFacultyList"
        Me.DataGridViewFacultyList.ReadOnly = True
        Me.DataGridViewFacultyList.RowHeadersVisible = False
        Me.DataGridViewFacultyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewFacultyList.Size = New System.Drawing.Size(995, 261)
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
        'ExplorerBar1
        '
        Me.ExplorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.ExplorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ExplorerBar1.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ExplorerBar1.BackStyle.BackColor2 = System.Drawing.Color.Gray
        Me.ExplorerBar1.BackStyle.BackColorGradientAngle = 90
        Me.ExplorerBar1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBar1.GroupImages = Nothing
        Me.ExplorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ExplorerBarGroupItemSchedule, Me.ExplorerBarGroupItemAccounts, Me.ExplorerBarGroupItemPrinting, Me.ExplorerBarGroupItem1})
        Me.ExplorerBar1.Images = Nothing
        Me.ExplorerBar1.Location = New System.Drawing.Point(2, 87)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Size = New System.Drawing.Size(262, 504)
        Me.ExplorerBar1.TabIndex = 9
        Me.ExplorerBar1.Text = "ExplorerBar1"
        Me.ExplorerBar1.ThemeAware = True
        '
        'ExplorerBarGroupItemSchedule
        '
        '
        '
        '
        Me.ExplorerBarGroupItemSchedule.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemSchedule.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemSchedule.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSchedule.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemSchedule.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.ExpandForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.Image = Global.SchedulingSystem.My.Resources.Resources.google_calendar_logo
        Me.ExplorerBarGroupItemSchedule.Name = "ExplorerBarGroupItemSchedule"
        Me.ExplorerBarGroupItemSchedule.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonAssignSched, Me.ButtonRemoveSched})
        Me.ExplorerBarGroupItemSchedule.Text = "Schedule"
        '
        '
        '
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSchedule.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItemSchedule.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemSchedule.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemSchedule.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemSchedule.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemSchedule.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSchedule.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemSchedule.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ButtonAssignSched
        '
        Me.ButtonAssignSched.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonAssignSched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAssignSched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonAssignSched.HotFontUnderline = True
        Me.ButtonAssignSched.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonAssignSched.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonAssignSched.Name = "ButtonAssignSched"
        Me.ButtonAssignSched.Text = "Assign Schedule"
        '
        'ButtonRemoveSched
        '
        Me.ButtonRemoveSched.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonRemoveSched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRemoveSched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonRemoveSched.HotFontUnderline = True
        Me.ButtonRemoveSched.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonRemoveSched.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonRemoveSched.Name = "ButtonRemoveSched"
        Me.ButtonRemoveSched.Text = "Remove Schedule"
        '
        'ExplorerBarGroupItemAccounts
        '
        '
        '
        '
        Me.ExplorerBarGroupItemAccounts.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemAccounts.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemAccounts.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemAccounts.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemAccounts.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemAccounts.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemAccounts.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemAccounts.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemAccounts.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemAccounts.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemAccounts.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerBarGroupItemAccounts.ExpandForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ExplorerBarGroupItemAccounts.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerBarGroupItemAccounts.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerBarGroupItemAccounts.Image = Global.SchedulingSystem.My.Resources.Resources.build9600
        Me.ExplorerBarGroupItemAccounts.Name = "ExplorerBarGroupItemAccounts"
        Me.ExplorerBarGroupItemAccounts.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonAddAccount})
        Me.ExplorerBarGroupItemAccounts.Text = "Accounts"
        '
        '
        '
        Me.ExplorerBarGroupItemAccounts.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemAccounts.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemAccounts.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemAccounts.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemAccounts.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemAccounts.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemAccounts.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerBarGroupItemAccounts.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemAccounts.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemAccounts.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemAccounts.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemAccounts.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemAccounts.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemAccounts.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'ButtonAddAccount
        '
        Me.ButtonAddAccount.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonAddAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonAddAccount.HotFontUnderline = True
        Me.ButtonAddAccount.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonAddAccount.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonAddAccount.Name = "ButtonAddAccount"
        Me.ButtonAddAccount.Text = "Add Account"
        '
        'ExplorerBarGroupItemPrinting
        '
        '
        '
        '
        Me.ExplorerBarGroupItemPrinting.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItemPrinting.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItemPrinting.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemPrinting.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerBarGroupItemPrinting.Image = Global.SchedulingSystem.My.Resources.Resources.Printer_small
        Me.ExplorerBarGroupItemPrinting.Name = "ExplorerBarGroupItemPrinting"
        Me.ExplorerBarGroupItemPrinting.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItemPrinting.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonPrintAssignedSched})
        Me.ExplorerBarGroupItemPrinting.Text = "Printing"
        '
        '
        '
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.BackColor2 = System.Drawing.SystemColors.InactiveCaption
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemPrinting.TitleHotStyle.TextColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.ExplorerBarGroupItemPrinting.TitleStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItemPrinting.TitleStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExplorerBarGroupItemPrinting.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItemPrinting.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItemPrinting.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemPrinting.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItemPrinting.TitleStyle.TextColor = System.Drawing.SystemColors.ControlText
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
        'ButtonPrintAssignedSched
        '
        Me.ButtonPrintAssignedSched.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonPrintAssignedSched.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPrintAssignedSched.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonPrintAssignedSched.HotFontUnderline = True
        Me.ButtonPrintAssignedSched.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonPrintAssignedSched.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonPrintAssignedSched.Name = "ButtonPrintAssignedSched"
        Me.ButtonPrintAssignedSched.Text = "Print Assigned Schedules"
        '
        'ExplorerBarGroupItem1
        '
        '
        '
        '
        Me.ExplorerBarGroupItem1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottomColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.BackStyle.BorderBottomWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeftColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.BackStyle.BorderLeftWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderRightColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.BackStyle.BorderRightWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerBarGroupItem1.BackStyle.BorderTopColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.BackStyle.BorderTopWidth = 1
        Me.ExplorerBarGroupItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.Expanded = True
        Me.ExplorerBarGroupItem1.Name = "ExplorerBarGroupItem1"
        Me.ExplorerBarGroupItem1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors
        Me.ExplorerBarGroupItem1.Text = "Subject Management"
        '
        '
        '
        Me.ExplorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.SystemColors.InactiveCaption
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.SystemColors.ActiveCaption
        '
        '
        '
        Me.ExplorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.SystemColors.Window
        Me.ExplorerBarGroupItem1.TitleStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.ExplorerBarGroupItem1.TitleStyle.CornerDiameter = 3
        Me.ExplorerBarGroupItem1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ExplorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.SystemColors.ControlText
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 590)
        Me.Controls.Add(Me.ExplorerBar1)
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
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSubject.ResumeLayout(False)
        Me.TabSubject.PerformLayout()
        CType(Me.DataGridSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacultyList.ResumeLayout(False)
        CType(Me.DataGridViewFacultyList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPrintSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents ScheduleManagement As System.Windows.Forms.TabPage
    Friend WithEvents FacultyList As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabSchedule As System.Windows.Forms.TabPage
    Friend WithEvents DataGridSched As System.Windows.Forms.DataGridView
    Friend WithEvents TabSubject As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentSchoolYear As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentSemester As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeSchoolyearSemester As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnAccountManagement As System.Windows.Forms.Button
    Friend WithEvents DataGridSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotalSubjects As System.Windows.Forms.Label
    Friend WithEvents btnManageSchedule As System.Windows.Forms.Button
    Friend WithEvents btnAddSchedule As System.Windows.Forms.Button
    Friend WithEvents PictureBoxPrintSubjects As System.Windows.Forms.PictureBox
    Friend WithEvents TimerTimeAndDate As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewFacultyList As System.Windows.Forms.DataGridView
    Friend WithEvents btnManageRoom As System.Windows.Forms.Button
    Friend WithEvents ExplorerBar1 As DevComponents.DotNetBar.ExplorerBar
    Friend WithEvents ExplorerBarGroupItemSchedule As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ExplorerBarGroupItemAccounts As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ButtonAssignSched As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonAddAccount As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonRemoveSched As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExplorerBarGroupItemPrinting As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ButtonPrintAssignedSched As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExplorerBarGroupItem1 As DevComponents.DotNetBar.ExplorerBarGroupItem
End Class
