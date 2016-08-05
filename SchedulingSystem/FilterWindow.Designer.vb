<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterWindow
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Prof = New System.Windows.Forms.TabPage()
        Me.ComboBoxLastname = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Subject = New System.Windows.Forms.TabPage()
        Me.ComboBoxClasscode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Prof.SuspendLayout()
        Me.Subject.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Prof)
        Me.TabControl1.Controls.Add(Me.Subject)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(431, 87)
        Me.TabControl1.TabIndex = 0
        '
        'Prof
        '
        Me.Prof.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Prof.Controls.Add(Me.ComboBoxLastname)
        Me.Prof.Controls.Add(Me.Label1)
        Me.Prof.Controls.Add(Me.Button1)
        Me.Prof.Controls.Add(Me.RadioButton1)
        Me.Prof.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Prof.Location = New System.Drawing.Point(4, 27)
        Me.Prof.Name = "Prof"
        Me.Prof.Padding = New System.Windows.Forms.Padding(3)
        Me.Prof.Size = New System.Drawing.Size(423, 56)
        Me.Prof.TabIndex = 0
        Me.Prof.Text = "Professor"
        '
        'ComboBoxLastname
        '
        Me.ComboBoxLastname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxLastname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxLastname.FormattingEnabled = True
        Me.ComboBoxLastname.Location = New System.Drawing.Point(189, 15)
        Me.ComboBoxLastname.Name = "ComboBoxLastname"
        Me.ComboBoxLastname.Size = New System.Drawing.Size(219, 26)
        Me.ComboBoxLastname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Professor's Lastname:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, -27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(247, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Subject
        '
        Me.Subject.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Subject.Controls.Add(Me.ComboBoxClasscode)
        Me.Subject.Controls.Add(Me.Label2)
        Me.Subject.Location = New System.Drawing.Point(4, 27)
        Me.Subject.Name = "Subject"
        Me.Subject.Padding = New System.Windows.Forms.Padding(3)
        Me.Subject.Size = New System.Drawing.Size(423, 56)
        Me.Subject.TabIndex = 1
        Me.Subject.Text = "Subject"
        '
        'ComboBoxClasscode
        '
        Me.ComboBoxClasscode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxClasscode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxClasscode.FormattingEnabled = True
        Me.ComboBoxClasscode.Location = New System.Drawing.Point(130, 14)
        Me.ComboBoxClasscode.Name = "ComboBoxClasscode"
        Me.ComboBoxClasscode.Size = New System.Drawing.Size(198, 26)
        Me.ComboBoxClasscode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Classcode"
        '
        'FilterWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(431, 87)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FilterWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Filter"
        Me.TabControl1.ResumeLayout(False)
        Me.Prof.ResumeLayout(False)
        Me.Prof.PerformLayout()
        Me.Subject.ResumeLayout(False)
        Me.Subject.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Prof As System.Windows.Forms.TabPage
    Friend WithEvents Subject As System.Windows.Forms.TabPage
    Friend WithEvents ComboBoxLastname As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxClasscode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
