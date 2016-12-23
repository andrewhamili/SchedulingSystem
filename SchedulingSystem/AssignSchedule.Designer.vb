<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignSchedule
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
        Me.ComboBoxEmployeeLastname = New System.Windows.Forms.ComboBox()
        Me.ComboBoxClasscode = New System.Windows.Forms.ComboBox()
        Me.btnChooseClasscode = New System.Windows.Forms.Button()
        Me.DataGridViewPendingList = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSaveSchedule = New System.Windows.Forms.Button()
        Me.LabelProfLname = New System.Windows.Forms.Label()
        Me.LabelProfFname = New System.Windows.Forms.Label()
        Me.GroupBoxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalUnits = New System.Windows.Forms.Label()
        Me.lblSubjDesc = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblTimeFrom = New System.Windows.Forms.Label()
        Me.lblTimeTo = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.Timer_OverloadBlinker = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_TotalUnitOutput = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridViewPendingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxEmployeeInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxEmployeeLastname
        '
        Me.ComboBoxEmployeeLastname.FormattingEnabled = True
        Me.ComboBoxEmployeeLastname.Location = New System.Drawing.Point(87, 12)
        Me.ComboBoxEmployeeLastname.Name = "ComboBoxEmployeeLastname"
        Me.ComboBoxEmployeeLastname.Size = New System.Drawing.Size(196, 26)
        Me.ComboBoxEmployeeLastname.TabIndex = 0
        '
        'ComboBoxClasscode
        '
        Me.ComboBoxClasscode.FormattingEnabled = True
        Me.ComboBoxClasscode.Location = New System.Drawing.Point(87, 60)
        Me.ComboBoxClasscode.Name = "ComboBoxClasscode"
        Me.ComboBoxClasscode.Size = New System.Drawing.Size(196, 26)
        Me.ComboBoxClasscode.TabIndex = 1
        '
        'btnChooseClasscode
        '
        Me.btnChooseClasscode.BackColor = System.Drawing.Color.LightGreen
        Me.btnChooseClasscode.Location = New System.Drawing.Point(1, 350)
        Me.btnChooseClasscode.Name = "btnChooseClasscode"
        Me.btnChooseClasscode.Size = New System.Drawing.Size(155, 40)
        Me.btnChooseClasscode.TabIndex = 2
        Me.btnChooseClasscode.Text = "Select"
        Me.btnChooseClasscode.UseVisualStyleBackColor = False
        '
        'DataGridViewPendingList
        '
        Me.DataGridViewPendingList.AllowUserToAddRows = False
        Me.DataGridViewPendingList.AllowUserToDeleteRows = False
        Me.DataGridViewPendingList.AllowUserToResizeRows = False
        Me.DataGridViewPendingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPendingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPendingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.SubjectDescription, Me.Day, Me.TimeFrom, Me.TimeTO, Me.Room, Me.Unit})
        Me.DataGridViewPendingList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewPendingList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewPendingList.Location = New System.Drawing.Point(0, 409)
        Me.DataGridViewPendingList.Name = "DataGridViewPendingList"
        Me.DataGridViewPendingList.ReadOnly = True
        Me.DataGridViewPendingList.RowHeadersVisible = False
        Me.DataGridViewPendingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPendingList.Size = New System.Drawing.Size(857, 150)
        Me.DataGridViewPendingList.TabIndex = 3
        '
        'Code
        '
        Me.Code.HeaderText = "Class Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        '
        'SubjectDescription
        '
        Me.SubjectDescription.HeaderText = "Subject Description"
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
        Me.TimeFrom.HeaderText = "Start Time"
        Me.TimeFrom.Name = "TimeFrom"
        Me.TimeFrom.ReadOnly = True
        '
        'TimeTO
        '
        Me.TimeTO.HeaderText = "End Time"
        Me.TimeTO.Name = "TimeTO"
        Me.TimeTO.ReadOnly = True
        '
        'Room
        '
        Me.Room.HeaderText = "Room"
        Me.Room.Name = "Room"
        Me.Room.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit(s)"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'btnSaveSchedule
        '
        Me.btnSaveSchedule.Location = New System.Drawing.Point(530, 350)
        Me.btnSaveSchedule.Name = "btnSaveSchedule"
        Me.btnSaveSchedule.Size = New System.Drawing.Size(109, 40)
        Me.btnSaveSchedule.TabIndex = 4
        Me.btnSaveSchedule.Text = "Save"
        Me.btnSaveSchedule.UseVisualStyleBackColor = True
        '
        'LabelProfLname
        '
        Me.LabelProfLname.AutoSize = True
        Me.LabelProfLname.Location = New System.Drawing.Point(118, 29)
        Me.LabelProfLname.Name = "LabelProfLname"
        Me.LabelProfLname.Size = New System.Drawing.Size(124, 18)
        Me.LabelProfLname.TabIndex = 5
        Me.LabelProfLname.Text = "LabelProfLname"
        '
        'LabelProfFname
        '
        Me.LabelProfFname.AutoSize = True
        Me.LabelProfFname.Location = New System.Drawing.Point(118, 59)
        Me.LabelProfFname.Name = "LabelProfFname"
        Me.LabelProfFname.Size = New System.Drawing.Size(125, 18)
        Me.LabelProfFname.TabIndex = 6
        Me.LabelProfFname.Text = "LabelProfFname"
        '
        'GroupBoxEmployeeInfo
        '
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.Label8)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.Label7)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.LabelProfLname)
        Me.GroupBoxEmployeeInfo.Controls.Add(Me.LabelProfFname)
        Me.GroupBoxEmployeeInfo.Location = New System.Drawing.Point(495, 12)
        Me.GroupBoxEmployeeInfo.Name = "GroupBoxEmployeeInfo"
        Me.GroupBoxEmployeeInfo.Size = New System.Drawing.Size(350, 94)
        Me.GroupBoxEmployeeInfo.TabIndex = 7
        Me.GroupBoxEmployeeInfo.TabStop = False
        Me.GroupBoxEmployeeInfo.Text = "Employee Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(7, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(7, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Last Name"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(646, 350)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Subject Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Room"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Unit(s)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(163, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Unit(s):"
        '
        'lblTotalUnits
        '
        Me.lblTotalUnits.AutoSize = True
        Me.lblTotalUnits.Location = New System.Drawing.Point(293, 366)
        Me.lblTotalUnits.Name = "lblTotalUnits"
        Me.lblTotalUnits.Size = New System.Drawing.Size(90, 18)
        Me.lblTotalUnits.TabIndex = 15
        Me.lblTotalUnits.Text = "lblTotalUnits"
        '
        'lblSubjDesc
        '
        Me.lblSubjDesc.AutoSize = True
        Me.lblSubjDesc.Location = New System.Drawing.Point(201, 129)
        Me.lblSubjDesc.Name = "lblSubjDesc"
        Me.lblSubjDesc.Size = New System.Drawing.Size(91, 18)
        Me.lblSubjDesc.TabIndex = 16
        Me.lblSubjDesc.Text = "lblSubjDesc"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(200, 172)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(51, 18)
        Me.lblDay.TabIndex = 17
        Me.lblDay.Text = "lblDay"
        '
        'lblTimeFrom
        '
        Me.lblTimeFrom.AutoSize = True
        Me.lblTimeFrom.Location = New System.Drawing.Point(202, 210)
        Me.lblTimeFrom.Name = "lblTimeFrom"
        Me.lblTimeFrom.Size = New System.Drawing.Size(94, 18)
        Me.lblTimeFrom.TabIndex = 18
        Me.lblTimeFrom.Text = "lblTimeFrom"
        '
        'lblTimeTo
        '
        Me.lblTimeTo.AutoSize = True
        Me.lblTimeTo.Location = New System.Drawing.Point(264, 210)
        Me.lblTimeTo.Name = "lblTimeTo"
        Me.lblTimeTo.Size = New System.Drawing.Size(73, 18)
        Me.lblTimeTo.TabIndex = 19
        Me.lblTimeTo.Text = "lblTimeTo"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(200, 255)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(65, 18)
        Me.lblRoom.TabIndex = 20
        Me.lblRoom.Text = "lblRoom"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Location = New System.Drawing.Point(200, 297)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(50, 18)
        Me.lblUnit.TabIndex = 21
        Me.lblUnit.Text = "lblUnit"
        '
        'Timer_OverloadBlinker
        '
        '
        'Timer_TotalUnitOutput
        '
        '
        'AssignSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(857, 559)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.lblTimeTo)
        Me.Controls.Add(Me.lblTimeFrom)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblSubjDesc)
        Me.Controls.Add(Me.lblTotalUnits)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBoxEmployeeInfo)
        Me.Controls.Add(Me.btnSaveSchedule)
        Me.Controls.Add(Me.DataGridViewPendingList)
        Me.Controls.Add(Me.btnChooseClasscode)
        Me.Controls.Add(Me.ComboBoxClasscode)
        Me.Controls.Add(Me.ComboBoxEmployeeLastname)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AssignSchedule"
        Me.Text = "AssignSchedule"
        CType(Me.DataGridViewPendingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxEmployeeInfo.ResumeLayout(False)
        Me.GroupBoxEmployeeInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxEmployeeLastname As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxClasscode As System.Windows.Forms.ComboBox
    Friend WithEvents btnChooseClasscode As System.Windows.Forms.Button
    Friend WithEvents DataGridViewPendingList As System.Windows.Forms.DataGridView
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Day As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Room As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSaveSchedule As System.Windows.Forms.Button
    Friend WithEvents LabelProfLname As System.Windows.Forms.Label
    Friend WithEvents LabelProfFname As System.Windows.Forms.Label
    Friend WithEvents GroupBoxEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalUnits As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSubjDesc As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblTimeFrom As System.Windows.Forms.Label
    Friend WithEvents lblTimeTo As System.Windows.Forms.Label
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents Timer_OverloadBlinker As System.Windows.Forms.Timer
    Friend WithEvents Timer_TotalUnitOutput As System.Windows.Forms.Timer
End Class
