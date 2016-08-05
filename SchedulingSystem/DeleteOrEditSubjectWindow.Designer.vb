<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteOrEditSubjectWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteOrEditSubjectWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModifySubjChosseClassCode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ModifySubjectCBoxRoom = New System.Windows.Forms.ComboBox()
        Me.CheckBoxSa = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFr = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTh = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWe = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTu = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxMo = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ModifySubjectTboxSubj_desc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.MaskedTextBoxUnit = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxTimeFrom = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxTimeTo = New System.Windows.Forms.MaskedTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(141, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delete / Edit Schedule"
        '
        'ModifySubjChosseClassCode
        '
        Me.ModifySubjChosseClassCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ModifySubjChosseClassCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ModifySubjChosseClassCode.FormattingEnabled = True
        Me.ModifySubjChosseClassCode.ItemHeight = 18
        Me.ModifySubjChosseClassCode.Location = New System.Drawing.Point(239, 73)
        Me.ModifySubjChosseClassCode.Name = "ModifySubjChosseClassCode"
        Me.ModifySubjChosseClassCode.Size = New System.Drawing.Size(198, 26)
        Me.ModifySubjChosseClassCode.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Class Code"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(154, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Time To"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(133, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 18)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Time From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Room"
        '
        'ModifySubjectCBoxRoom
        '
        Me.ModifySubjectCBoxRoom.AutoCompleteCustomSource.AddRange(New String() {"ISC201", "ISC301", "ISC302", "ISC303", "ISC401", "ISC402", "ISC403", "ISC501", "ISC502", "ISC503", "ISC601", "ISC602", "ISC603"})
        Me.ModifySubjectCBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModifySubjectCBoxRoom.FormattingEnabled = True
        Me.ModifySubjectCBoxRoom.Items.AddRange(New Object() {"ISC201", "ISC301", "ISC302", "ISC303", "ISC401", "ISC402", "ISC403", "ISC501", "ISC502", "ISC503", "ISC601", "ISC602", "ISC603"})
        Me.ModifySubjectCBoxRoom.Location = New System.Drawing.Point(239, 363)
        Me.ModifySubjectCBoxRoom.Name = "ModifySubjectCBoxRoom"
        Me.ModifySubjectCBoxRoom.Size = New System.Drawing.Size(121, 26)
        Me.ModifySubjectCBoxRoom.TabIndex = 13
        '
        'CheckBoxSa
        '
        Me.CheckBoxSa.AutoSize = True
        Me.CheckBoxSa.Location = New System.Drawing.Point(332, 244)
        Me.CheckBoxSa.Name = "CheckBoxSa"
        Me.CheckBoxSa.Size = New System.Drawing.Size(38, 22)
        Me.CheckBoxSa.TabIndex = 8
        Me.CheckBoxSa.Text = "S"
        Me.CheckBoxSa.UseVisualStyleBackColor = True
        '
        'CheckBoxFr
        '
        Me.CheckBoxFr.AutoSize = True
        Me.CheckBoxFr.Location = New System.Drawing.Point(289, 244)
        Me.CheckBoxFr.Name = "CheckBoxFr"
        Me.CheckBoxFr.Size = New System.Drawing.Size(37, 22)
        Me.CheckBoxFr.TabIndex = 7
        Me.CheckBoxFr.Text = "F"
        Me.CheckBoxFr.UseVisualStyleBackColor = True
        '
        'CheckBoxTh
        '
        Me.CheckBoxTh.AutoSize = True
        Me.CheckBoxTh.Location = New System.Drawing.Point(239, 244)
        Me.CheckBoxTh.Name = "CheckBoxTh"
        Me.CheckBoxTh.Size = New System.Drawing.Size(44, 22)
        Me.CheckBoxTh.TabIndex = 6
        Me.CheckBoxTh.Text = "Th"
        Me.CheckBoxTh.UseVisualStyleBackColor = True
        '
        'CheckBoxWe
        '
        Me.CheckBoxWe.AutoSize = True
        Me.CheckBoxWe.Location = New System.Drawing.Point(332, 216)
        Me.CheckBoxWe.Name = "CheckBoxWe"
        Me.CheckBoxWe.Size = New System.Drawing.Size(42, 22)
        Me.CheckBoxWe.TabIndex = 5
        Me.CheckBoxWe.Text = "W"
        Me.CheckBoxWe.UseVisualStyleBackColor = True
        '
        'CheckBoxTu
        '
        Me.CheckBoxTu.AutoSize = True
        Me.CheckBoxTu.Location = New System.Drawing.Point(290, 216)
        Me.CheckBoxTu.Name = "CheckBoxTu"
        Me.CheckBoxTu.Size = New System.Drawing.Size(36, 22)
        Me.CheckBoxTu.TabIndex = 4
        Me.CheckBoxTu.Text = "T"
        Me.CheckBoxTu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Day"
        '
        'CheckBoxMo
        '
        Me.CheckBoxMo.AutoSize = True
        Me.CheckBoxMo.Location = New System.Drawing.Point(239, 216)
        Me.CheckBoxMo.Name = "CheckBoxMo"
        Me.CheckBoxMo.Size = New System.Drawing.Size(40, 22)
        Me.CheckBoxMo.TabIndex = 3
        Me.CheckBoxMo.Text = "M"
        Me.CheckBoxMo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(260, 409)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(102, 48)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "&Modify"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ModifySubjectTboxSubj_desc
        '
        Me.ModifySubjectTboxSubj_desc.Location = New System.Drawing.Point(239, 123)
        Me.ModifySubjectTboxSubj_desc.Name = "ModifySubjectTboxSubj_desc"
        Me.ModifySubjectTboxSubj_desc.Size = New System.Drawing.Size(198, 26)
        Me.ModifySubjectTboxSubj_desc.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Unit(s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Subject Description"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(379, 409)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(102, 48)
        Me.ButtonDelete.TabIndex = 48
        Me.ButtonDelete.Text = "&Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxUnit
        '
        Me.MaskedTextBoxUnit.Location = New System.Drawing.Point(239, 175)
        Me.MaskedTextBoxUnit.Mask = "0"
        Me.MaskedTextBoxUnit.Name = "MaskedTextBoxUnit"
        Me.MaskedTextBoxUnit.Size = New System.Drawing.Size(198, 26)
        Me.MaskedTextBoxUnit.TabIndex = 49
        '
        'MaskedTextBoxTimeFrom
        '
        Me.MaskedTextBoxTimeFrom.Location = New System.Drawing.Point(239, 279)
        Me.MaskedTextBoxTimeFrom.Mask = "00:00"
        Me.MaskedTextBoxTimeFrom.Name = "MaskedTextBoxTimeFrom"
        Me.MaskedTextBoxTimeFrom.Size = New System.Drawing.Size(50, 26)
        Me.MaskedTextBoxTimeFrom.TabIndex = 50
        '
        'MaskedTextBoxTimeTo
        '
        Me.MaskedTextBoxTimeTo.Location = New System.Drawing.Point(239, 321)
        Me.MaskedTextBoxTimeTo.Mask = "00:00"
        Me.MaskedTextBoxTimeTo.Name = "MaskedTextBoxTimeTo"
        Me.MaskedTextBoxTimeTo.Size = New System.Drawing.Size(50, 26)
        Me.MaskedTextBoxTimeTo.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 48)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "&Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DeleteOrEditSubjectWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(506, 481)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MaskedTextBoxTimeTo)
        Me.Controls.Add(Me.MaskedTextBoxTimeFrom)
        Me.Controls.Add(Me.MaskedTextBoxUnit)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ModifySubjectCBoxRoom)
        Me.Controls.Add(Me.CheckBoxSa)
        Me.Controls.Add(Me.CheckBoxFr)
        Me.Controls.Add(Me.CheckBoxTh)
        Me.Controls.Add(Me.CheckBoxWe)
        Me.Controls.Add(Me.CheckBoxTu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBoxMo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ModifySubjectTboxSubj_desc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ModifySubjChosseClassCode)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteOrEditSubjectWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete / Edit Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ModifySubjChosseClassCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ModifySubjectCBoxRoom As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxSa As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFr As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTh As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxWe As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTu As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMo As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ModifySubjectTboxSubj_desc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBoxUnit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxTimeFrom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxTimeTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
