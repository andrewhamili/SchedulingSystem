<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageSchedule
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
        Me.ComboBoxClasscode = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DateTimePickertimeto = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickertimefrom = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxDay_sa = New System.Windows.Forms.CheckBox()
        Me.btnCancel1 = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.ComboBoxRoom = New System.Windows.Forms.ComboBox()
        Me.CheckBoxDay_th = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDay_tu = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDay_fr = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDay_we = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDay_mo = New System.Windows.Forms.CheckBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtSubjDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxClasscode
        '
        Me.ComboBoxClasscode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxClasscode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxClasscode.FormattingEnabled = True
        Me.ComboBoxClasscode.Location = New System.Drawing.Point(129, 45)
        Me.ComboBoxClasscode.Name = "ComboBoxClasscode"
        Me.ComboBoxClasscode.Size = New System.Drawing.Size(254, 26)
        Me.ComboBoxClasscode.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Classcode"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(201, 103)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 40)
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.DateTimePickertimeto)
        Me.Panel1.Controls.Add(Me.DateTimePickertimefrom)
        Me.Panel1.Controls.Add(Me.CheckBoxDay_sa)
        Me.Panel1.Controls.Add(Me.btnCancel1)
        Me.Panel1.Controls.Add(Me.btnModify)
        Me.Panel1.Controls.Add(Me.ComboBoxRoom)
        Me.Panel1.Controls.Add(Me.CheckBoxDay_th)
        Me.Panel1.Controls.Add(Me.CheckBoxDay_tu)
        Me.Panel1.Controls.Add(Me.CheckBoxDay_fr)
        Me.Panel1.Controls.Add(Me.CheckBoxDay_we)
        Me.Panel1.Controls.Add(Me.CheckBoxDay_mo)
        Me.Panel1.Controls.Add(Me.txtUnit)
        Me.Panel1.Controls.Add(Me.txtSubjDesc)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(2, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 379)
        Me.Panel1.TabIndex = 67
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(144, 336)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(113, 39)
        Me.btnReset.TabIndex = 66
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(263, 290)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 40)
        Me.btnDelete.TabIndex = 65
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DateTimePickertimeto
        '
        Me.DateTimePickertimeto.CustomFormat = "HH:mm"
        Me.DateTimePickertimeto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickertimeto.Location = New System.Drawing.Point(139, 216)
        Me.DateTimePickertimeto.Name = "DateTimePickertimeto"
        Me.DateTimePickertimeto.ShowUpDown = True
        Me.DateTimePickertimeto.Size = New System.Drawing.Size(76, 26)
        Me.DateTimePickertimeto.TabIndex = 64
        Me.DateTimePickertimeto.Value = New Date(2016, 12, 20, 0, 0, 0, 0)
        '
        'DateTimePickertimefrom
        '
        Me.DateTimePickertimefrom.CustomFormat = "HH:mm"
        Me.DateTimePickertimefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickertimefrom.Location = New System.Drawing.Point(139, 183)
        Me.DateTimePickertimefrom.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickertimefrom.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickertimefrom.Name = "DateTimePickertimefrom"
        Me.DateTimePickertimefrom.ShowUpDown = True
        Me.DateTimePickertimefrom.Size = New System.Drawing.Size(76, 26)
        Me.DateTimePickertimefrom.TabIndex = 63
        Me.DateTimePickertimefrom.Value = New Date(2016, 12, 20, 0, 0, 0, 0)
        '
        'CheckBoxDay_sa
        '
        Me.CheckBoxDay_sa.AutoSize = True
        Me.CheckBoxDay_sa.Location = New System.Drawing.Point(334, 129)
        Me.CheckBoxDay_sa.Name = "CheckBoxDay_sa"
        Me.CheckBoxDay_sa.Size = New System.Drawing.Size(38, 22)
        Me.CheckBoxDay_sa.TabIndex = 62
        Me.CheckBoxDay_sa.Text = "S"
        Me.CheckBoxDay_sa.UseVisualStyleBackColor = True
        '
        'btnCancel1
        '
        Me.btnCancel1.Location = New System.Drawing.Point(18, 292)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(118, 38)
        Me.btnCancel1.TabIndex = 61
        Me.btnCancel1.Text = "Cancel"
        Me.btnCancel1.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(142, 290)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(115, 40)
        Me.btnModify.TabIndex = 60
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'ComboBoxRoom
        '
        Me.ComboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRoom.FormattingEnabled = True
        Me.ComboBoxRoom.Items.AddRange(New Object() {"ISC201", "ISC301", "ISC302", "ISC303", "ISC401", "ISC402", "ISC403", "ISC501", "ISC502", "ISC503", "ISC601", "ISC602", "ISC603"})
        Me.ComboBoxRoom.Location = New System.Drawing.Point(115, 255)
        Me.ComboBoxRoom.Name = "ComboBoxRoom"
        Me.ComboBoxRoom.Size = New System.Drawing.Size(121, 26)
        Me.ComboBoxRoom.TabIndex = 59
        '
        'CheckBoxDay_th
        '
        Me.CheckBoxDay_th.AutoSize = True
        Me.CheckBoxDay_th.Location = New System.Drawing.Point(171, 129)
        Me.CheckBoxDay_th.Name = "CheckBoxDay_th"
        Me.CheckBoxDay_th.Size = New System.Drawing.Size(44, 22)
        Me.CheckBoxDay_th.TabIndex = 58
        Me.CheckBoxDay_th.Text = "Th"
        Me.CheckBoxDay_th.UseVisualStyleBackColor = True
        '
        'CheckBoxDay_tu
        '
        Me.CheckBoxDay_tu.AutoSize = True
        Me.CheckBoxDay_tu.Location = New System.Drawing.Point(252, 103)
        Me.CheckBoxDay_tu.Name = "CheckBoxDay_tu"
        Me.CheckBoxDay_tu.Size = New System.Drawing.Size(36, 22)
        Me.CheckBoxDay_tu.TabIndex = 57
        Me.CheckBoxDay_tu.Text = "T"
        Me.CheckBoxDay_tu.UseVisualStyleBackColor = True
        '
        'CheckBoxDay_fr
        '
        Me.CheckBoxDay_fr.AutoSize = True
        Me.CheckBoxDay_fr.Location = New System.Drawing.Point(252, 129)
        Me.CheckBoxDay_fr.Name = "CheckBoxDay_fr"
        Me.CheckBoxDay_fr.Size = New System.Drawing.Size(37, 22)
        Me.CheckBoxDay_fr.TabIndex = 56
        Me.CheckBoxDay_fr.Text = "F"
        Me.CheckBoxDay_fr.UseVisualStyleBackColor = True
        '
        'CheckBoxDay_we
        '
        Me.CheckBoxDay_we.AutoSize = True
        Me.CheckBoxDay_we.Location = New System.Drawing.Point(333, 103)
        Me.CheckBoxDay_we.Name = "CheckBoxDay_we"
        Me.CheckBoxDay_we.Size = New System.Drawing.Size(42, 22)
        Me.CheckBoxDay_we.TabIndex = 55
        Me.CheckBoxDay_we.Text = "W"
        Me.CheckBoxDay_we.UseVisualStyleBackColor = True
        '
        'CheckBoxDay_mo
        '
        Me.CheckBoxDay_mo.AutoSize = True
        Me.CheckBoxDay_mo.Location = New System.Drawing.Point(171, 103)
        Me.CheckBoxDay_mo.Name = "CheckBoxDay_mo"
        Me.CheckBoxDay_mo.Size = New System.Drawing.Size(40, 22)
        Me.CheckBoxDay_mo.TabIndex = 54
        Me.CheckBoxDay_mo.Text = "M"
        Me.CheckBoxDay_mo.UseVisualStyleBackColor = True
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(171, 59)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(210, 26)
        Me.txtUnit.TabIndex = 53
        '
        'txtSubjDesc
        '
        Me.txtSubjDesc.Location = New System.Drawing.Point(171, 12)
        Me.txtSubjDesc.Name = "txtSubjDesc"
        Me.txtSubjDesc.Size = New System.Drawing.Size(210, 26)
        Me.txtSubjDesc.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Room"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Time To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Time From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Unit(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Subject Description"
        '
        'ManageSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxClasscode)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "ManageSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScheduleManagement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxClasscode As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DateTimePickertimeto As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickertimefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxDay_sa As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel1 As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents ComboBoxRoom As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxDay_th As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDay_tu As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDay_fr As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDay_we As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDay_mo As System.Windows.Forms.CheckBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
