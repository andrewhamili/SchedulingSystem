<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSchedule))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_AddSchedule_Classcode = New System.Windows.Forms.TextBox()
        Me.txt_AddSchedule_SubjDesc = New System.Windows.Forms.TextBox()
        Me.txt_AddSchedule_Unit = New System.Windows.Forms.TextBox()
        Me.CheckBox_AddSchedule_Day_mo = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AddSchedule_Day_we = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AddSchedule_Day_fr = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AddSchedule_Day_tu = New System.Windows.Forms.CheckBox()
        Me.CheckBox_AddSchedule_Day_th = New System.Windows.Forms.CheckBox()
        Me.CboxChooseRoom = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.CheckBox_AddSchedule_Day_sa = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker_AddSchedule_timefrom = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_AddSchedule_timeto = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit(s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Room"
        '
        'txt_AddSchedule_Classcode
        '
        Me.txt_AddSchedule_Classcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_AddSchedule_Classcode.Location = New System.Drawing.Point(168, 12)
        Me.txt_AddSchedule_Classcode.MaxLength = 255
        Me.txt_AddSchedule_Classcode.Name = "txt_AddSchedule_Classcode"
        Me.txt_AddSchedule_Classcode.Size = New System.Drawing.Size(197, 26)
        Me.txt_AddSchedule_Classcode.TabIndex = 7
        '
        'txt_AddSchedule_SubjDesc
        '
        Me.txt_AddSchedule_SubjDesc.Location = New System.Drawing.Point(168, 56)
        Me.txt_AddSchedule_SubjDesc.MaxLength = 255
        Me.txt_AddSchedule_SubjDesc.Name = "txt_AddSchedule_SubjDesc"
        Me.txt_AddSchedule_SubjDesc.Size = New System.Drawing.Size(197, 26)
        Me.txt_AddSchedule_SubjDesc.TabIndex = 8
        '
        'txt_AddSchedule_Unit
        '
        Me.txt_AddSchedule_Unit.Location = New System.Drawing.Point(168, 103)
        Me.txt_AddSchedule_Unit.MaxLength = 2
        Me.txt_AddSchedule_Unit.Name = "txt_AddSchedule_Unit"
        Me.txt_AddSchedule_Unit.Size = New System.Drawing.Size(35, 26)
        Me.txt_AddSchedule_Unit.TabIndex = 9
        '
        'CheckBox_AddSchedule_Day_mo
        '
        Me.CheckBox_AddSchedule_Day_mo.AutoSize = True
        Me.CheckBox_AddSchedule_Day_mo.Location = New System.Drawing.Point(168, 147)
        Me.CheckBox_AddSchedule_Day_mo.Name = "CheckBox_AddSchedule_Day_mo"
        Me.CheckBox_AddSchedule_Day_mo.Size = New System.Drawing.Size(40, 22)
        Me.CheckBox_AddSchedule_Day_mo.TabIndex = 10
        Me.CheckBox_AddSchedule_Day_mo.Text = "M"
        Me.CheckBox_AddSchedule_Day_mo.UseVisualStyleBackColor = True
        '
        'CheckBox_AddSchedule_Day_we
        '
        Me.CheckBox_AddSchedule_Day_we.AutoSize = True
        Me.CheckBox_AddSchedule_Day_we.Location = New System.Drawing.Point(330, 147)
        Me.CheckBox_AddSchedule_Day_we.Name = "CheckBox_AddSchedule_Day_we"
        Me.CheckBox_AddSchedule_Day_we.Size = New System.Drawing.Size(42, 22)
        Me.CheckBox_AddSchedule_Day_we.TabIndex = 11
        Me.CheckBox_AddSchedule_Day_we.Text = "W"
        Me.CheckBox_AddSchedule_Day_we.UseVisualStyleBackColor = True
        '
        'CheckBox_AddSchedule_Day_fr
        '
        Me.CheckBox_AddSchedule_Day_fr.AutoSize = True
        Me.CheckBox_AddSchedule_Day_fr.Location = New System.Drawing.Point(249, 173)
        Me.CheckBox_AddSchedule_Day_fr.Name = "CheckBox_AddSchedule_Day_fr"
        Me.CheckBox_AddSchedule_Day_fr.Size = New System.Drawing.Size(37, 22)
        Me.CheckBox_AddSchedule_Day_fr.TabIndex = 12
        Me.CheckBox_AddSchedule_Day_fr.Text = "F"
        Me.CheckBox_AddSchedule_Day_fr.UseVisualStyleBackColor = True
        '
        'CheckBox_AddSchedule_Day_tu
        '
        Me.CheckBox_AddSchedule_Day_tu.AutoSize = True
        Me.CheckBox_AddSchedule_Day_tu.Location = New System.Drawing.Point(249, 147)
        Me.CheckBox_AddSchedule_Day_tu.Name = "CheckBox_AddSchedule_Day_tu"
        Me.CheckBox_AddSchedule_Day_tu.Size = New System.Drawing.Size(36, 22)
        Me.CheckBox_AddSchedule_Day_tu.TabIndex = 13
        Me.CheckBox_AddSchedule_Day_tu.Text = "T"
        Me.CheckBox_AddSchedule_Day_tu.UseVisualStyleBackColor = True
        '
        'CheckBox_AddSchedule_Day_th
        '
        Me.CheckBox_AddSchedule_Day_th.AutoSize = True
        Me.CheckBox_AddSchedule_Day_th.Location = New System.Drawing.Point(168, 173)
        Me.CheckBox_AddSchedule_Day_th.Name = "CheckBox_AddSchedule_Day_th"
        Me.CheckBox_AddSchedule_Day_th.Size = New System.Drawing.Size(44, 22)
        Me.CheckBox_AddSchedule_Day_th.TabIndex = 14
        Me.CheckBox_AddSchedule_Day_th.Text = "Th"
        Me.CheckBox_AddSchedule_Day_th.UseVisualStyleBackColor = True
        '
        'CboxChooseRoom
        '
        Me.CboxChooseRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboxChooseRoom.FormattingEnabled = True
        Me.CboxChooseRoom.Location = New System.Drawing.Point(111, 278)
        Me.CboxChooseRoom.Name = "CboxChooseRoom"
        Me.CboxChooseRoom.Size = New System.Drawing.Size(121, 26)
        Me.CboxChooseRoom.TabIndex = 17
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(250, 332)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 40)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(67, 334)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(118, 38)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CheckBox_AddSchedule_Day_sa
        '
        Me.CheckBox_AddSchedule_Day_sa.AutoSize = True
        Me.CheckBox_AddSchedule_Day_sa.Location = New System.Drawing.Point(331, 173)
        Me.CheckBox_AddSchedule_Day_sa.Name = "CheckBox_AddSchedule_Day_sa"
        Me.CheckBox_AddSchedule_Day_sa.Size = New System.Drawing.Size(38, 22)
        Me.CheckBox_AddSchedule_Day_sa.TabIndex = 20
        Me.CheckBox_AddSchedule_Day_sa.Text = "S"
        Me.CheckBox_AddSchedule_Day_sa.UseVisualStyleBackColor = True
        '
        'DateTimePicker_AddSchedule_timefrom
        '
        Me.DateTimePicker_AddSchedule_timefrom.CustomFormat = "HH:mm"
        Me.DateTimePicker_AddSchedule_timefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_AddSchedule_timefrom.Location = New System.Drawing.Point(168, 227)
        Me.DateTimePicker_AddSchedule_timefrom.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker_AddSchedule_timefrom.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_AddSchedule_timefrom.Name = "DateTimePicker_AddSchedule_timefrom"
        Me.DateTimePicker_AddSchedule_timefrom.ShowUpDown = True
        Me.DateTimePicker_AddSchedule_timefrom.Size = New System.Drawing.Size(76, 26)
        Me.DateTimePicker_AddSchedule_timefrom.TabIndex = 21
        Me.DateTimePicker_AddSchedule_timefrom.Value = New Date(2016, 12, 20, 0, 0, 0, 0)
        '
        'DateTimePicker_AddSchedule_timeto
        '
        Me.DateTimePicker_AddSchedule_timeto.CustomFormat = "HH:mm"
        Me.DateTimePicker_AddSchedule_timeto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_AddSchedule_timeto.Location = New System.Drawing.Point(272, 227)
        Me.DateTimePicker_AddSchedule_timeto.Name = "DateTimePicker_AddSchedule_timeto"
        Me.DateTimePicker_AddSchedule_timeto.ShowUpDown = True
        Me.DateTimePicker_AddSchedule_timeto.Size = New System.Drawing.Size(76, 26)
        Me.DateTimePicker_AddSchedule_timeto.TabIndex = 22
        Me.DateTimePicker_AddSchedule_timeto.Value = New Date(2016, 12, 20, 0, 0, 0, 0)
        '
        'AddSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(394, 394)
        Me.Controls.Add(Me.DateTimePicker_AddSchedule_timeto)
        Me.Controls.Add(Me.DateTimePicker_AddSchedule_timefrom)
        Me.Controls.Add(Me.CheckBox_AddSchedule_Day_sa)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CboxChooseRoom)
        Me.Controls.Add(Me.CheckBox_AddSchedule_Day_th)
        Me.Controls.Add(Me.CheckBox_AddSchedule_Day_tu)
        Me.Controls.Add(Me.CheckBox_AddSchedule_Day_fr)
        Me.Controls.Add(Me.CheckBox_AddSchedule_Day_we)
        Me.Controls.Add(Me.CheckBox_AddSchedule_Day_mo)
        Me.Controls.Add(Me.txt_AddSchedule_Unit)
        Me.Controls.Add(Me.txt_AddSchedule_SubjDesc)
        Me.Controls.Add(Me.txt_AddSchedule_Classcode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddSchedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_AddSchedule_Classcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_AddSchedule_SubjDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_AddSchedule_Unit As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox_AddSchedule_Day_mo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_AddSchedule_Day_we As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_AddSchedule_Day_fr As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_AddSchedule_Day_tu As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_AddSchedule_Day_th As System.Windows.Forms.CheckBox
    Friend WithEvents CboxChooseRoom As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents CheckBox_AddSchedule_Day_sa As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker_AddSchedule_timefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_AddSchedule_timeto As System.Windows.Forms.DateTimePicker
End Class
