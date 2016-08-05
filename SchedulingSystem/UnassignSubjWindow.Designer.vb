<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnassignSubjWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnassignSubjWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxClasscode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelSubj_desc = New System.Windows.Forms.Label()
        Me.LabelSubj_unit = New System.Windows.Forms.Label()
        Me.LabelSubj_day = New System.Windows.Forms.Label()
        Me.LabelSubJ_TImeFrom = New System.Windows.Forms.Label()
        Me.LabelRoom = New System.Windows.Forms.Label()
        Me.LabelSubj_TimeTo = New System.Windows.Forms.Label()
        Me.LabelColon = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelProfName = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class code"
        '
        'ComboBoxClasscode
        '
        Me.ComboBoxClasscode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxClasscode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxClasscode.FormattingEnabled = True
        Me.ComboBoxClasscode.Location = New System.Drawing.Point(217, 27)
        Me.ComboBoxClasscode.Name = "ComboBoxClasscode"
        Me.ComboBoxClasscode.Size = New System.Drawing.Size(236, 26)
        Me.ComboBoxClasscode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subject Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Unit(s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Room"
        '
        'LabelSubj_desc
        '
        Me.LabelSubj_desc.AutoSize = True
        Me.LabelSubj_desc.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelSubj_desc.Location = New System.Drawing.Point(213, 81)
        Me.LabelSubj_desc.Name = "LabelSubj_desc"
        Me.LabelSubj_desc.Size = New System.Drawing.Size(0, 23)
        Me.LabelSubj_desc.TabIndex = 7
        '
        'LabelSubj_unit
        '
        Me.LabelSubj_unit.AutoSize = True
        Me.LabelSubj_unit.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelSubj_unit.Location = New System.Drawing.Point(213, 131)
        Me.LabelSubj_unit.Name = "LabelSubj_unit"
        Me.LabelSubj_unit.Size = New System.Drawing.Size(0, 23)
        Me.LabelSubj_unit.TabIndex = 8
        '
        'LabelSubj_day
        '
        Me.LabelSubj_day.AutoSize = True
        Me.LabelSubj_day.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelSubj_day.Location = New System.Drawing.Point(213, 177)
        Me.LabelSubj_day.Name = "LabelSubj_day"
        Me.LabelSubj_day.Size = New System.Drawing.Size(0, 23)
        Me.LabelSubj_day.TabIndex = 9
        '
        'LabelSubJ_TImeFrom
        '
        Me.LabelSubJ_TImeFrom.AutoSize = True
        Me.LabelSubJ_TImeFrom.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelSubJ_TImeFrom.Location = New System.Drawing.Point(213, 223)
        Me.LabelSubJ_TImeFrom.Name = "LabelSubJ_TImeFrom"
        Me.LabelSubJ_TImeFrom.Size = New System.Drawing.Size(0, 23)
        Me.LabelSubJ_TImeFrom.TabIndex = 10
        '
        'LabelRoom
        '
        Me.LabelRoom.AutoSize = True
        Me.LabelRoom.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelRoom.Location = New System.Drawing.Point(213, 272)
        Me.LabelRoom.Name = "LabelRoom"
        Me.LabelRoom.Size = New System.Drawing.Size(0, 23)
        Me.LabelRoom.TabIndex = 11
        '
        'LabelSubj_TimeTo
        '
        Me.LabelSubj_TimeTo.AutoSize = True
        Me.LabelSubj_TimeTo.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelSubj_TimeTo.Location = New System.Drawing.Point(286, 223)
        Me.LabelSubj_TimeTo.Name = "LabelSubj_TimeTo"
        Me.LabelSubj_TimeTo.Size = New System.Drawing.Size(0, 23)
        Me.LabelSubj_TimeTo.TabIndex = 12
        '
        'LabelColon
        '
        Me.LabelColon.AutoSize = True
        Me.LabelColon.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelColon.Location = New System.Drawing.Point(271, 222)
        Me.LabelColon.Name = "LabelColon"
        Me.LabelColon.Size = New System.Drawing.Size(15, 23)
        Me.LabelColon.TabIndex = 13
        Me.LabelColon.Text = "-"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(571, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 43)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Unassign"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Assigned to:"
        '
        'LabelProfName
        '
        Me.LabelProfName.AutoSize = True
        Me.LabelProfName.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelProfName.Location = New System.Drawing.Point(213, 321)
        Me.LabelProfName.Name = "LabelProfName"
        Me.LabelProfName.Size = New System.Drawing.Size(0, 23)
        Me.LabelProfName.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(571, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 42)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UnassignSubjWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(717, 366)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LabelProfName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelColon)
        Me.Controls.Add(Me.LabelSubj_TimeTo)
        Me.Controls.Add(Me.LabelRoom)
        Me.Controls.Add(Me.LabelSubJ_TImeFrom)
        Me.Controls.Add(Me.LabelSubj_day)
        Me.Controls.Add(Me.LabelSubj_unit)
        Me.Controls.Add(Me.LabelSubj_desc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxClasscode)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UnassignSubjWindow"
        Me.Text = "Unassign Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxClasscode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelSubj_desc As System.Windows.Forms.Label
    Friend WithEvents LabelSubj_unit As System.Windows.Forms.Label
    Friend WithEvents LabelSubj_day As System.Windows.Forms.Label
    Friend WithEvents LabelSubJ_TImeFrom As System.Windows.Forms.Label
    Friend WithEvents LabelRoom As System.Windows.Forms.Label
    Friend WithEvents LabelSubj_TimeTo As System.Windows.Forms.Label
    Friend WithEvents LabelColon As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelProfName As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
