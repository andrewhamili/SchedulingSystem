<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnassignSchedule
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
        Me.btnUnassign = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSubjDesc = New System.Windows.Forms.Label()
        Me.lblSubjDay = New System.Windows.Forms.Label()
        Me.lblTimeStart = New System.Windows.Forms.Label()
        Me.lblTimeEnd = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblProfessor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSubjRoom = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxClasscode
        '
        Me.ComboBoxClasscode.FormattingEnabled = True
        Me.ComboBoxClasscode.Location = New System.Drawing.Point(103, 56)
        Me.ComboBoxClasscode.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxClasscode.Name = "ComboBoxClasscode"
        Me.ComboBoxClasscode.Size = New System.Drawing.Size(180, 26)
        Me.ComboBoxClasscode.TabIndex = 0
        '
        'btnUnassign
        '
        Me.btnUnassign.Location = New System.Drawing.Point(420, 12)
        Me.btnUnassign.Name = "btnUnassign"
        Me.btnUnassign.Size = New System.Drawing.Size(119, 48)
        Me.btnUnassign.TabIndex = 1
        Me.btnUnassign.Text = "Unassign"
        Me.btnUnassign.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Subject Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time Start"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Time End"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Professor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Unit(s)"
        '
        'lblSubjDesc
        '
        Me.lblSubjDesc.AutoSize = True
        Me.lblSubjDesc.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblSubjDesc.Location = New System.Drawing.Point(183, 135)
        Me.lblSubjDesc.Name = "lblSubjDesc"
        Me.lblSubjDesc.Size = New System.Drawing.Size(114, 23)
        Me.lblSubjDesc.TabIndex = 8
        Me.lblSubjDesc.Text = "lblSubjDesc"
        '
        'lblSubjDay
        '
        Me.lblSubjDay.AutoSize = True
        Me.lblSubjDay.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblSubjDay.Location = New System.Drawing.Point(183, 170)
        Me.lblSubjDay.Name = "lblSubjDay"
        Me.lblSubjDay.Size = New System.Drawing.Size(103, 23)
        Me.lblSubjDay.TabIndex = 9
        Me.lblSubjDay.Text = "lblSubjDay"
        '
        'lblTimeStart
        '
        Me.lblTimeStart.AutoSize = True
        Me.lblTimeStart.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblTimeStart.Location = New System.Drawing.Point(184, 253)
        Me.lblTimeStart.Name = "lblTimeStart"
        Me.lblTimeStart.Size = New System.Drawing.Size(119, 23)
        Me.lblTimeStart.TabIndex = 10
        Me.lblTimeStart.Text = "lblTimeStart"
        '
        'lblTimeEnd
        '
        Me.lblTimeEnd.AutoSize = True
        Me.lblTimeEnd.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblTimeEnd.Location = New System.Drawing.Point(187, 286)
        Me.lblTimeEnd.Name = "lblTimeEnd"
        Me.lblTimeEnd.Size = New System.Drawing.Size(109, 23)
        Me.lblTimeEnd.TabIndex = 11
        Me.lblTimeEnd.Text = "lblTimeEnd"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblUnits.Location = New System.Drawing.Point(187, 326)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(77, 23)
        Me.lblUnits.TabIndex = 12
        Me.lblUnits.Text = "lblUnits"
        '
        'lblProfessor
        '
        Me.lblProfessor.AutoSize = True
        Me.lblProfessor.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblProfessor.Location = New System.Drawing.Point(184, 364)
        Me.lblProfessor.Name = "lblProfessor"
        Me.lblProfessor.Size = New System.Drawing.Size(116, 23)
        Me.lblProfessor.TabIndex = 13
        Me.lblProfessor.Text = "lblProfessor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Classcode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Room"
        '
        'lblSubjRoom
        '
        Me.lblSubjRoom.AutoSize = True
        Me.lblSubjRoom.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.lblSubjRoom.Location = New System.Drawing.Point(188, 206)
        Me.lblSubjRoom.Name = "lblSubjRoom"
        Me.lblSubjRoom.Size = New System.Drawing.Size(120, 23)
        Me.lblSubjRoom.TabIndex = 16
        Me.lblSubjRoom.Text = "lblSubjRoom"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(420, 66)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 52)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'UnassignSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 421)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblSubjRoom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblProfessor)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblTimeEnd)
        Me.Controls.Add(Me.lblTimeStart)
        Me.Controls.Add(Me.lblSubjDay)
        Me.Controls.Add(Me.lblSubjDesc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUnassign)
        Me.Controls.Add(Me.ComboBoxClasscode)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UnassignSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UnassignSchedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxClasscode As System.Windows.Forms.ComboBox
    Friend WithEvents btnUnassign As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSubjDesc As System.Windows.Forms.Label
    Friend WithEvents lblSubjDay As System.Windows.Forms.Label
    Friend WithEvents lblTimeStart As System.Windows.Forms.Label
    Friend WithEvents lblTimeEnd As System.Windows.Forms.Label
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents lblProfessor As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSubjRoom As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
