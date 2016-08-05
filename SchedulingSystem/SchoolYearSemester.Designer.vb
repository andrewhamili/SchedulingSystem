<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchoolYearSemester
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchoolYearSemester))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxSemester = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Labeltip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ComboBoxSchoolyear = New System.Windows.Forms.ComboBox()
        Me.Backup = New System.Windows.Forms.Button()
        Me.Rrestore = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(122, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "School Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Semester"
        '
        'ComboBoxSemester
        '
        Me.ComboBoxSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSemester.FormattingEnabled = True
        Me.ComboBoxSemester.Items.AddRange(New Object() {"1st", "2nd", "summer"})
        Me.ComboBoxSemester.Location = New System.Drawing.Point(237, 141)
        Me.ComboBoxSemester.Name = "ComboBoxSemester"
        Me.ComboBoxSemester.Size = New System.Drawing.Size(121, 26)
        Me.ComboBoxSemester.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(75, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Create/Activate SchoolYear and Semester"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 70)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 44)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Load"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 44)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Create"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(170, 221)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 44)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Labeltip, Me.ProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 288)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(504, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Labeltip
        '
        Me.Labeltip.Name = "Labeltip"
        Me.Labeltip.Size = New System.Drawing.Size(0, 17)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ComboBoxSchoolyear
        '
        Me.ComboBoxSchoolyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSchoolyear.FormattingEnabled = True
        Me.ComboBoxSchoolyear.Items.AddRange(New Object() {"2015-2016", "2016-2017", "2017-2018", "2018-2019", "2019-2020", "2020-2021", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2025-2026", "2026-2027", "2027-2028", "2028-2029", "2029-2030"})
        Me.ComboBoxSchoolyear.Location = New System.Drawing.Point(237, 98)
        Me.ComboBoxSchoolyear.MaxDropDownItems = 10
        Me.ComboBoxSchoolyear.Name = "ComboBoxSchoolyear"
        Me.ComboBoxSchoolyear.Size = New System.Drawing.Size(121, 26)
        Me.ComboBoxSchoolyear.Sorted = True
        Me.ComboBoxSchoolyear.TabIndex = 0
        '
        'Backup
        '
        Me.Backup.Location = New System.Drawing.Point(402, 80)
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(75, 44)
        Me.Backup.TabIndex = 10
        Me.Backup.Text = "Backup"
        Me.Backup.UseVisualStyleBackColor = True
        '
        'Rrestore
        '
        Me.Rrestore.Location = New System.Drawing.Point(402, 168)
        Me.Rrestore.Name = "Rrestore"
        Me.Rrestore.Size = New System.Drawing.Size(75, 44)
        Me.Rrestore.TabIndex = 11
        Me.Rrestore.Text = "Restore"
        Me.Rrestore.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Last Backup Created:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 13
        '
        'SchoolYearSemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 310)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Rrestore)
        Me.Controls.Add(Me.Backup)
        Me.Controls.Add(Me.ComboBoxSchoolyear)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxSemester)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SchoolYearSemester"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Semester/School Year"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSemester As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Labeltip As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ComboBoxSchoolyear As System.Windows.Forms.ComboBox
    Friend WithEvents Backup As System.Windows.Forms.Button
    Friend WithEvents Rrestore As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
