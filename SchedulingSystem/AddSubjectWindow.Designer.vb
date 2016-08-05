<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSubjectWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSubjectWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddSubjectTboxClasscode = New System.Windows.Forms.TextBox()
        Me.AddSubjectTboxSubj_desc = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBoxMo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxTu = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWe = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTh = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFr = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSa = New System.Windows.Forms.CheckBox()
        Me.AddSubjectCBoxRoom = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxTimeFrom = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxTimeTo = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AddSubjectTboxSubj_unit = New System.Windows.Forms.MaskedTextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit(s)"
        '
        'AddSubjectTboxClasscode
        '
        Me.AddSubjectTboxClasscode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddSubjectTboxClasscode.Location = New System.Drawing.Point(247, 69)
        Me.AddSubjectTboxClasscode.Name = "AddSubjectTboxClasscode"
        Me.AddSubjectTboxClasscode.Size = New System.Drawing.Size(234, 26)
        Me.AddSubjectTboxClasscode.TabIndex = 0
        '
        'AddSubjectTboxSubj_desc
        '
        Me.AddSubjectTboxSubj_desc.Location = New System.Drawing.Point(247, 105)
        Me.AddSubjectTboxSubj_desc.Name = "AddSubjectTboxSubj_desc"
        Me.AddSubjectTboxSubj_desc.Size = New System.Drawing.Size(234, 26)
        Me.AddSubjectTboxSubj_desc.TabIndex = 1
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ButtonSave.Location = New System.Drawing.Point(298, 378)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(102, 48)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "Add Subject"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(134, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(186, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Add Schedule"
        '
        'CheckBoxMo
        '
        Me.CheckBoxMo.AutoSize = True
        Me.CheckBoxMo.Location = New System.Drawing.Point(247, 183)
        Me.CheckBoxMo.Name = "CheckBoxMo"
        Me.CheckBoxMo.Size = New System.Drawing.Size(40, 22)
        Me.CheckBoxMo.TabIndex = 3
        Me.CheckBoxMo.Text = "M"
        Me.CheckBoxMo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(172, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Day"
        '
        'CheckBoxTu
        '
        Me.CheckBoxTu.AutoSize = True
        Me.CheckBoxTu.Location = New System.Drawing.Point(349, 183)
        Me.CheckBoxTu.Name = "CheckBoxTu"
        Me.CheckBoxTu.Size = New System.Drawing.Size(36, 22)
        Me.CheckBoxTu.TabIndex = 11
        Me.CheckBoxTu.Text = "T"
        Me.CheckBoxTu.UseVisualStyleBackColor = True
        '
        'CheckBoxWe
        '
        Me.CheckBoxWe.AutoSize = True
        Me.CheckBoxWe.Location = New System.Drawing.Point(439, 183)
        Me.CheckBoxWe.Name = "CheckBoxWe"
        Me.CheckBoxWe.Size = New System.Drawing.Size(42, 22)
        Me.CheckBoxWe.TabIndex = 12
        Me.CheckBoxWe.Text = "W"
        Me.CheckBoxWe.UseVisualStyleBackColor = True
        '
        'CheckBoxTh
        '
        Me.CheckBoxTh.AutoSize = True
        Me.CheckBoxTh.Location = New System.Drawing.Point(247, 211)
        Me.CheckBoxTh.Name = "CheckBoxTh"
        Me.CheckBoxTh.Size = New System.Drawing.Size(44, 22)
        Me.CheckBoxTh.TabIndex = 13
        Me.CheckBoxTh.Text = "Th"
        Me.CheckBoxTh.UseVisualStyleBackColor = True
        '
        'CheckBoxFr
        '
        Me.CheckBoxFr.AutoSize = True
        Me.CheckBoxFr.Location = New System.Drawing.Point(349, 211)
        Me.CheckBoxFr.Name = "CheckBoxFr"
        Me.CheckBoxFr.Size = New System.Drawing.Size(37, 22)
        Me.CheckBoxFr.TabIndex = 14
        Me.CheckBoxFr.Text = "F"
        Me.CheckBoxFr.UseVisualStyleBackColor = True
        '
        'CheckBoxSa
        '
        Me.CheckBoxSa.AutoSize = True
        Me.CheckBoxSa.Location = New System.Drawing.Point(439, 211)
        Me.CheckBoxSa.Name = "CheckBoxSa"
        Me.CheckBoxSa.Size = New System.Drawing.Size(38, 22)
        Me.CheckBoxSa.TabIndex = 15
        Me.CheckBoxSa.Text = "S"
        Me.CheckBoxSa.UseVisualStyleBackColor = True
        '
        'AddSubjectCBoxRoom
        '
        Me.AddSubjectCBoxRoom.AutoCompleteCustomSource.AddRange(New String() {"ISC201", "ISC301", "ISC302", "ISC303", "ISC401", "ISC402", "ISC403", "ISC501", "ISC502", "ISC503", "ISC601", "ISC602", "ISC603"})
        Me.AddSubjectCBoxRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.AddSubjectCBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AddSubjectCBoxRoom.FormattingEnabled = True
        Me.AddSubjectCBoxRoom.Items.AddRange(New Object() {"ISC201", "ISC301", "ISC302", "ISC303", "ISC401", "ISC402", "ISC403", "ISC501", "ISC502", "ISC503", "ISC601", "ISC602", "ISC603"})
        Me.AddSubjectCBoxRoom.Location = New System.Drawing.Point(247, 324)
        Me.AddSubjectCBoxRoom.Name = "AddSubjectCBoxRoom"
        Me.AddSubjectCBoxRoom.Size = New System.Drawing.Size(121, 26)
        Me.AddSubjectCBoxRoom.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Room"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(163, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "From"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(184, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "To"
        '
        'MaskedTextBoxTimeFrom
        '
        Me.MaskedTextBoxTimeFrom.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.MaskedTextBoxTimeFrom.Location = New System.Drawing.Point(247, 247)
        Me.MaskedTextBoxTimeFrom.Mask = "00:00"
        Me.MaskedTextBoxTimeFrom.Name = "MaskedTextBoxTimeFrom"
        Me.MaskedTextBoxTimeFrom.Size = New System.Drawing.Size(50, 26)
        Me.MaskedTextBoxTimeFrom.TabIndex = 4
        '
        'MaskedTextBoxTimeTo
        '
        Me.MaskedTextBoxTimeTo.Location = New System.Drawing.Point(247, 284)
        Me.MaskedTextBoxTimeTo.Mask = "00:00"
        Me.MaskedTextBoxTimeTo.Name = "MaskedTextBoxTimeTo"
        Me.MaskedTextBoxTimeTo.Size = New System.Drawing.Size(50, 26)
        Me.MaskedTextBoxTimeTo.TabIndex = 5
        '
        'Timer1
        '
        '
        'AddSubjectTboxSubj_unit
        '
        Me.AddSubjectTboxSubj_unit.Location = New System.Drawing.Point(247, 144)
        Me.AddSubjectTboxSubj_unit.Mask = "0"
        Me.AddSubjectTboxSubj_unit.Name = "AddSubjectTboxSubj_unit"
        Me.AddSubjectTboxSubj_unit.Size = New System.Drawing.Size(234, 26)
        Me.AddSubjectTboxSubj_unit.TabIndex = 2
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'AddSubjectWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(527, 453)
        Me.Controls.Add(Me.AddSubjectTboxSubj_unit)
        Me.Controls.Add(Me.MaskedTextBoxTimeTo)
        Me.Controls.Add(Me.MaskedTextBoxTimeFrom)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AddSubjectCBoxRoom)
        Me.Controls.Add(Me.CheckBoxSa)
        Me.Controls.Add(Me.CheckBoxFr)
        Me.Controls.Add(Me.CheckBoxTh)
        Me.Controls.Add(Me.CheckBoxWe)
        Me.Controls.Add(Me.CheckBoxTu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBoxMo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.AddSubjectTboxSubj_desc)
        Me.Controls.Add(Me.AddSubjectTboxClasscode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddSubjectWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Schedule"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddSubjectTboxClasscode As System.Windows.Forms.TextBox
    Friend WithEvents AddSubjectTboxSubj_desc As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMo As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxTu As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxWe As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTh As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFr As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSa As System.Windows.Forms.CheckBox
    Friend WithEvents AddSubjectCBoxRoom As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBoxTimeFrom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxTimeTo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AddSubjectTboxSubj_unit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
End Class
