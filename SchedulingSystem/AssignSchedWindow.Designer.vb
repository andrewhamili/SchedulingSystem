<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignSchedWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignSchedWindow))
        Me.AssignSchedCboxEmpNum = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelProfEmpCode = New System.Windows.Forms.Label()
        Me.LabelProfLname = New System.Windows.Forms.Label()
        Me.LabelProfFname = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AssignSchedCboxChooseClasscode = New System.Windows.Forms.ComboBox()
        Me.ButtonCancelAssignSched = New System.Windows.Forms.Button()
        Me.ButtonSaveAssignSched = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.DataGridViewPendingList = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignSubjAddToGrid = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AssignSchedLabelSubj_desc = New System.Windows.Forms.Label()
        Me.AssignSchedLabelSubj_day = New System.Windows.Forms.Label()
        Me.AssignSchedLabelTimeFrom = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AssignSchedLabelTimeTo = New System.Windows.Forms.Label()
        Me.AssignSchedLabelRoom = New System.Windows.Forms.Label()
        Me.AssignSchedLabelUnit = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBoxRefreshClassCode = New System.Windows.Forms.PictureBox()
        Me.PictureBoxRefreshLname = New System.Windows.Forms.PictureBox()
        Me.ListBoxPendingTimeFrom = New System.Windows.Forms.ListBox()
        Me.ListBoxPendingTimeTo = New System.Windows.Forms.ListBox()
        Me.ListBoxPendingDay = New System.Windows.Forms.ListBox()
        Me.ListBoxPendingRoom = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelTotalLoad = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewPendingList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRefreshClassCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRefreshLname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssignSchedCboxEmpNum
        '
        Me.AssignSchedCboxEmpNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AssignSchedCboxEmpNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AssignSchedCboxEmpNum.FormattingEnabled = True
        Me.AssignSchedCboxEmpNum.Location = New System.Drawing.Point(190, 23)
        Me.AssignSchedCboxEmpNum.Margin = New System.Windows.Forms.Padding(4)
        Me.AssignSchedCboxEmpNum.Name = "AssignSchedCboxEmpNum"
        Me.AssignSchedCboxEmpNum.Size = New System.Drawing.Size(206, 26)
        Me.AssignSchedCboxEmpNum.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LabelProfEmpCode)
        Me.GroupBox1.Controls.Add(Me.LabelProfLname)
        Me.GroupBox1.Controls.Add(Me.LabelProfFname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(694, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(337, 122)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Professor's Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Employee Code"
        '
        'LabelProfEmpCode
        '
        Me.LabelProfEmpCode.AutoSize = True
        Me.LabelProfEmpCode.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelProfEmpCode.Location = New System.Drawing.Point(142, 35)
        Me.LabelProfEmpCode.Name = "LabelProfEmpCode"
        Me.LabelProfEmpCode.Size = New System.Drawing.Size(39, 23)
        Me.LabelProfEmpCode.TabIndex = 5
        Me.LabelProfEmpCode.Text = "N/A"
        '
        'LabelProfLname
        '
        Me.LabelProfLname.AutoSize = True
        Me.LabelProfLname.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelProfLname.Location = New System.Drawing.Point(141, 91)
        Me.LabelProfLname.Name = "LabelProfLname"
        Me.LabelProfLname.Size = New System.Drawing.Size(39, 23)
        Me.LabelProfLname.TabIndex = 4
        Me.LabelProfLname.Text = "N/A"
        '
        'LabelProfFname
        '
        Me.LabelProfFname.AutoSize = True
        Me.LabelProfFname.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelProfFname.Location = New System.Drawing.Point(141, 63)
        Me.LabelProfFname.Name = "LabelProfFname"
        Me.LabelProfFname.Size = New System.Drawing.Size(39, 23)
        Me.LabelProfFname.TabIndex = 3
        Me.LabelProfFname.Text = "N/A"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Last Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee's Lastname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ClassCode"
        '
        'AssignSchedCboxChooseClasscode
        '
        Me.AssignSchedCboxChooseClasscode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AssignSchedCboxChooseClasscode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.AssignSchedCboxChooseClasscode.FormattingEnabled = True
        Me.AssignSchedCboxChooseClasscode.Location = New System.Drawing.Point(190, 66)
        Me.AssignSchedCboxChooseClasscode.Name = "AssignSchedCboxChooseClasscode"
        Me.AssignSchedCboxChooseClasscode.Size = New System.Drawing.Size(207, 26)
        Me.AssignSchedCboxChooseClasscode.TabIndex = 8
        '
        'ButtonCancelAssignSched
        '
        Me.ButtonCancelAssignSched.Location = New System.Drawing.Point(707, 315)
        Me.ButtonCancelAssignSched.Name = "ButtonCancelAssignSched"
        Me.ButtonCancelAssignSched.Size = New System.Drawing.Size(117, 65)
        Me.ButtonCancelAssignSched.TabIndex = 25
        Me.ButtonCancelAssignSched.Text = "Close"
        Me.ButtonCancelAssignSched.UseVisualStyleBackColor = True
        '
        'ButtonSaveAssignSched
        '
        Me.ButtonSaveAssignSched.Location = New System.Drawing.Point(948, 315)
        Me.ButtonSaveAssignSched.Name = "ButtonSaveAssignSched"
        Me.ButtonSaveAssignSched.Size = New System.Drawing.Size(117, 65)
        Me.ButtonSaveAssignSched.TabIndex = 26
        Me.ButtonSaveAssignSched.Text = "Assign"
        Me.ButtonSaveAssignSched.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(830, 315)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(112, 65)
        Me.ButtonReset.TabIndex = 27
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'DataGridViewPendingList
        '
        Me.DataGridViewPendingList.AllowUserToAddRows = False
        Me.DataGridViewPendingList.AllowUserToDeleteRows = False
        Me.DataGridViewPendingList.AllowUserToOrderColumns = True
        Me.DataGridViewPendingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPendingList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridViewPendingList.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewPendingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPendingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.SubjectDescription, Me.Day, Me.TimeFrom, Me.TimeTo, Me.Room, Me.Unit})
        Me.DataGridViewPendingList.GridColor = System.Drawing.Color.Black
        Me.DataGridViewPendingList.Location = New System.Drawing.Point(2, 405)
        Me.DataGridViewPendingList.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewPendingList.MultiSelect = False
        Me.DataGridViewPendingList.Name = "DataGridViewPendingList"
        Me.DataGridViewPendingList.ReadOnly = True
        Me.DataGridViewPendingList.RowHeadersVisible = False
        Me.DataGridViewPendingList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewPendingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPendingList.Size = New System.Drawing.Size(1225, 280)
        Me.DataGridViewPendingList.TabIndex = 28
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        '
        'SubjectDescription
        '
        Me.SubjectDescription.HeaderText = "SubjectDescription"
        Me.SubjectDescription.Name = "SubjectDescription"
        Me.SubjectDescription.ReadOnly = True
        '
        'Day
        '
        Me.Day.HeaderText = "Day"
        Me.Day.Name = "Day"
        Me.Day.ReadOnly = True
        '
        'TimeFrom
        '
        Me.TimeFrom.HeaderText = "TimeFrom"
        Me.TimeFrom.Name = "TimeFrom"
        Me.TimeFrom.ReadOnly = True
        '
        'TimeTo
        '
        Me.TimeTo.HeaderText = "TimeTo"
        Me.TimeTo.Name = "TimeTo"
        Me.TimeTo.ReadOnly = True
        '
        'Room
        '
        Me.Room.HeaderText = "Room"
        Me.Room.Name = "Room"
        Me.Room.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'AssignSubjAddToGrid
        '
        Me.AssignSubjAddToGrid.Location = New System.Drawing.Point(12, 283)
        Me.AssignSubjAddToGrid.Name = "AssignSubjAddToGrid"
        Me.AssignSubjAddToGrid.Size = New System.Drawing.Size(117, 50)
        Me.AssignSubjAddToGrid.TabIndex = 29
        Me.AssignSubjAddToGrid.Text = "Add"
        Me.AssignSubjAddToGrid.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Subject Descripton"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Room"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 18)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Unit(s)"
        '
        'AssignSchedLabelSubj_desc
        '
        Me.AssignSchedLabelSubj_desc.AutoSize = True
        Me.AssignSchedLabelSubj_desc.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.AssignSchedLabelSubj_desc.Location = New System.Drawing.Point(187, 103)
        Me.AssignSchedLabelSubj_desc.Name = "AssignSchedLabelSubj_desc"
        Me.AssignSchedLabelSubj_desc.Size = New System.Drawing.Size(0, 23)
        Me.AssignSchedLabelSubj_desc.TabIndex = 35
        '
        'AssignSchedLabelSubj_day
        '
        Me.AssignSchedLabelSubj_day.AutoSize = True
        Me.AssignSchedLabelSubj_day.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.AssignSchedLabelSubj_day.Location = New System.Drawing.Point(187, 139)
        Me.AssignSchedLabelSubj_day.Name = "AssignSchedLabelSubj_day"
        Me.AssignSchedLabelSubj_day.Size = New System.Drawing.Size(0, 23)
        Me.AssignSchedLabelSubj_day.TabIndex = 36
        '
        'AssignSchedLabelTimeFrom
        '
        Me.AssignSchedLabelTimeFrom.AutoSize = True
        Me.AssignSchedLabelTimeFrom.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.AssignSchedLabelTimeFrom.Location = New System.Drawing.Point(186, 173)
        Me.AssignSchedLabelTimeFrom.Name = "AssignSchedLabelTimeFrom"
        Me.AssignSchedLabelTimeFrom.Size = New System.Drawing.Size(0, 23)
        Me.AssignSchedLabelTimeFrom.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(251, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 18)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "-"
        '
        'AssignSchedLabelTimeTo
        '
        Me.AssignSchedLabelTimeTo.AutoSize = True
        Me.AssignSchedLabelTimeTo.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.AssignSchedLabelTimeTo.Location = New System.Drawing.Point(270, 173)
        Me.AssignSchedLabelTimeTo.Name = "AssignSchedLabelTimeTo"
        Me.AssignSchedLabelTimeTo.Size = New System.Drawing.Size(0, 23)
        Me.AssignSchedLabelTimeTo.TabIndex = 39
        '
        'AssignSchedLabelRoom
        '
        Me.AssignSchedLabelRoom.AutoSize = True
        Me.AssignSchedLabelRoom.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.AssignSchedLabelRoom.Location = New System.Drawing.Point(191, 211)
        Me.AssignSchedLabelRoom.Name = "AssignSchedLabelRoom"
        Me.AssignSchedLabelRoom.Size = New System.Drawing.Size(0, 23)
        Me.AssignSchedLabelRoom.TabIndex = 40
        '
        'AssignSchedLabelUnit
        '
        Me.AssignSchedLabelUnit.AutoSize = True
        Me.AssignSchedLabelUnit.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.AssignSchedLabelUnit.Location = New System.Drawing.Point(191, 243)
        Me.AssignSchedLabelUnit.Name = "AssignSchedLabelUnit"
        Me.AssignSchedLabelUnit.Size = New System.Drawing.Size(21, 23)
        Me.AssignSchedLabelUnit.TabIndex = 41
        Me.AssignSchedLabelUnit.Text = "0"
        '
        'Timer1
        '
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(9, 374)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(441, 23)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Double-click  a Classcode to remove from the list"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(1213, 1)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBoxRefreshClassCode
        '
        Me.PictureBoxRefreshClassCode.Image = CType(resources.GetObject("PictureBoxRefreshClassCode.Image"), System.Drawing.Image)
        Me.PictureBoxRefreshClassCode.Location = New System.Drawing.Point(403, 71)
        Me.PictureBoxRefreshClassCode.Name = "PictureBoxRefreshClassCode"
        Me.PictureBoxRefreshClassCode.Size = New System.Drawing.Size(22, 21)
        Me.PictureBoxRefreshClassCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRefreshClassCode.TabIndex = 43
        Me.PictureBoxRefreshClassCode.TabStop = False
        '
        'PictureBoxRefreshLname
        '
        Me.PictureBoxRefreshLname.Image = CType(resources.GetObject("PictureBoxRefreshLname.Image"), System.Drawing.Image)
        Me.PictureBoxRefreshLname.Location = New System.Drawing.Point(403, 26)
        Me.PictureBoxRefreshLname.Name = "PictureBoxRefreshLname"
        Me.PictureBoxRefreshLname.Size = New System.Drawing.Size(22, 21)
        Me.PictureBoxRefreshLname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRefreshLname.TabIndex = 43
        Me.PictureBoxRefreshLname.TabStop = False
        '
        'ListBoxPendingTimeFrom
        '
        Me.ListBoxPendingTimeFrom.FormattingEnabled = True
        Me.ListBoxPendingTimeFrom.ItemHeight = 18
        Me.ListBoxPendingTimeFrom.Location = New System.Drawing.Point(70, 498)
        Me.ListBoxPendingTimeFrom.Name = "ListBoxPendingTimeFrom"
        Me.ListBoxPendingTimeFrom.Size = New System.Drawing.Size(120, 94)
        Me.ListBoxPendingTimeFrom.TabIndex = 46
        '
        'ListBoxPendingTimeTo
        '
        Me.ListBoxPendingTimeTo.FormattingEnabled = True
        Me.ListBoxPendingTimeTo.ItemHeight = 18
        Me.ListBoxPendingTimeTo.Location = New System.Drawing.Point(274, 498)
        Me.ListBoxPendingTimeTo.Name = "ListBoxPendingTimeTo"
        Me.ListBoxPendingTimeTo.Size = New System.Drawing.Size(120, 94)
        Me.ListBoxPendingTimeTo.TabIndex = 47
        '
        'ListBoxPendingDay
        '
        Me.ListBoxPendingDay.FormattingEnabled = True
        Me.ListBoxPendingDay.ItemHeight = 18
        Me.ListBoxPendingDay.Location = New System.Drawing.Point(274, 498)
        Me.ListBoxPendingDay.Name = "ListBoxPendingDay"
        Me.ListBoxPendingDay.Size = New System.Drawing.Size(120, 94)
        Me.ListBoxPendingDay.TabIndex = 48
        '
        'ListBoxPendingRoom
        '
        Me.ListBoxPendingRoom.FormattingEnabled = True
        Me.ListBoxPendingRoom.ItemHeight = 18
        Me.ListBoxPendingRoom.Location = New System.Drawing.Point(579, 459)
        Me.ListBoxPendingRoom.Name = "ListBoxPendingRoom"
        Me.ListBoxPendingRoom.Size = New System.Drawing.Size(120, 94)
        Me.ListBoxPendingRoom.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(135, 299)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 18)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Total Load:"
        '
        'LabelTotalLoad
        '
        Me.LabelTotalLoad.AutoSize = True
        Me.LabelTotalLoad.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelTotalLoad.Location = New System.Drawing.Point(225, 296)
        Me.LabelTotalLoad.Name = "LabelTotalLoad"
        Me.LabelTotalLoad.Size = New System.Drawing.Size(21, 23)
        Me.LabelTotalLoad.TabIndex = 51
        Me.LabelTotalLoad.Text = "0"
        '
        'Timer2
        '
        '
        'AssignSchedWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1227, 687)
        Me.Controls.Add(Me.LabelTotalLoad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBoxRefreshClassCode)
        Me.Controls.Add(Me.PictureBoxRefreshLname)
        Me.Controls.Add(Me.AssignSchedLabelUnit)
        Me.Controls.Add(Me.AssignSchedLabelRoom)
        Me.Controls.Add(Me.AssignSchedLabelTimeTo)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AssignSchedLabelTimeFrom)
        Me.Controls.Add(Me.AssignSchedLabelSubj_day)
        Me.Controls.Add(Me.AssignSchedLabelSubj_desc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AssignSubjAddToGrid)
        Me.Controls.Add(Me.DataGridViewPendingList)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonSaveAssignSched)
        Me.Controls.Add(Me.ButtonCancelAssignSched)
        Me.Controls.Add(Me.AssignSchedCboxChooseClasscode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AssignSchedCboxEmpNum)
        Me.Controls.Add(Me.ListBoxPendingTimeFrom)
        Me.Controls.Add(Me.ListBoxPendingTimeTo)
        Me.Controls.Add(Me.ListBoxPendingDay)
        Me.Controls.Add(Me.ListBoxPendingRoom)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssignSchedWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Schedule"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewPendingList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRefreshClassCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRefreshLname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AssignSchedCboxEmpNum As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AssignSchedCboxChooseClasscode As System.Windows.Forms.ComboBox
    Friend WithEvents LabelProfLname As System.Windows.Forms.Label
    Friend WithEvents LabelProfFname As System.Windows.Forms.Label
    Friend WithEvents ButtonCancelAssignSched As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveAssignSched As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents LabelProfEmpCode As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewPendingList As System.Windows.Forms.DataGridView
    Friend WithEvents AssignSubjAddToGrid As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AssignSchedLabelSubj_desc As System.Windows.Forms.Label
    Friend WithEvents AssignSchedLabelSubj_day As System.Windows.Forms.Label
    Friend WithEvents AssignSchedLabelTimeFrom As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AssignSchedLabelTimeTo As System.Windows.Forms.Label
    Friend WithEvents AssignSchedLabelRoom As System.Windows.Forms.Label
    Friend WithEvents AssignSchedLabelUnit As System.Windows.Forms.Label
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBoxRefreshLname As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxRefreshClassCode As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ListBoxPendingTimeFrom As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxPendingTimeTo As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxPendingDay As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxPendingRoom As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LabelTotalLoad As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
