<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserWindow
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserWindow))
        Me.WelcomeText = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridMySched = New System.Windows.Forms.DataGridView()
        Me.LabelTotalUnits = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelSchoolYear = New System.Windows.Forms.Label()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        CType(Me.DataGridMySched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WelcomeText
        '
        Me.WelcomeText.AutoSize = True
        Me.WelcomeText.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeText.ForeColor = System.Drawing.Color.Green
        Me.WelcomeText.Location = New System.Drawing.Point(13, 13)
        Me.WelcomeText.Name = "WelcomeText"
        Me.WelcomeText.Size = New System.Drawing.Size(461, 29)
        Me.WelcomeText.TabIndex = 0
        Me.WelcomeText.Text = "Welcome!, Patrick Jenkin Chan Go Wu "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(941, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Log-out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridMySched
        '
        Me.DataGridMySched.AllowUserToAddRows = False
        Me.DataGridMySched.AllowUserToDeleteRows = False
        Me.DataGridMySched.AllowUserToResizeRows = False
        Me.DataGridMySched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridMySched.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridMySched.BackgroundColor = System.Drawing.Color.White
        Me.DataGridMySched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMySched.Location = New System.Drawing.Point(0, 170)
        Me.DataGridMySched.Name = "DataGridMySched"
        Me.DataGridMySched.ReadOnly = True
        Me.DataGridMySched.RowHeadersVisible = False
        Me.DataGridMySched.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridMySched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridMySched.Size = New System.Drawing.Size(1090, 403)
        Me.DataGridMySched.TabIndex = 2
        '
        'LabelTotalUnits
        '
        Me.LabelTotalUnits.AutoSize = True
        Me.LabelTotalUnits.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.LabelTotalUnits.Location = New System.Drawing.Point(1046, 576)
        Me.LabelTotalUnits.Name = "LabelTotalUnits"
        Me.LabelTotalUnits.Size = New System.Drawing.Size(32, 23)
        Me.LabelTotalUnits.TabIndex = 5
        Me.LabelTotalUnits.Text = "18"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 577)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Your Schedule may change anytime."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(925, 577)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Unit(s)"
        '
        'LabelSchoolYear
        '
        Me.LabelSchoolYear.AutoSize = True
        Me.LabelSchoolYear.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelSchoolYear.Location = New System.Drawing.Point(30, 46)
        Me.LabelSchoolYear.Name = "LabelSchoolYear"
        Me.LabelSchoolYear.Size = New System.Drawing.Size(227, 23)
        Me.LabelSchoolYear.TabIndex = 8
        Me.LabelSchoolYear.Text = "SchoolYear:   2015_2016"
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelSemester.Location = New System.Drawing.Point(34, 73)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(144, 23)
        Me.LabelSemester.TabIndex = 9
        Me.LabelSemester.Text = "Semester:   1st"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SchedulingSystem.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(479, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(881, 69)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(197, 95)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX1.TabIndex = 11
        Me.ButtonX1.Text = "View all Subjects for the current Semester"
        '
        'UserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 602)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelSemester)
        Me.Controls.Add(Me.LabelSchoolYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTotalUnits)
        Me.Controls.Add(Me.DataGridMySched)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WelcomeText)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserWindow"
        Me.TitleText = "User Window"
        CType(Me.DataGridMySched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WelcomeText As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridMySched As System.Windows.Forms.DataGridView
    Friend WithEvents LabelTotalUnits As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelSchoolYear As System.Windows.Forms.Label
    Friend WithEvents LabelSemester As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
