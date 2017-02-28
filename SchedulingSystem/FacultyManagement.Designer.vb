<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacultyManagement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewFaculty = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Empid = New System.Windows.Forms.TextBox()
        Me.txt_Fname = New System.Windows.Forms.TextBox()
        Me.txt_Mname = New System.Windows.Forms.TextBox()
        Me.txt_Lname = New System.Windows.Forms.TextBox()
        Me.txt_SchoolCollege = New System.Windows.Forms.TextBox()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewFaculty)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 275)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Records"
        '
        'DataGridViewFaculty
        '
        Me.DataGridViewFaculty.AllowUserToAddRows = False
        Me.DataGridViewFaculty.AllowUserToDeleteRows = False
        Me.DataGridViewFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFaculty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFaculty.Location = New System.Drawing.Point(3, 22)
        Me.DataGridViewFaculty.MultiSelect = False
        Me.DataGridViewFaculty.Name = "DataGridViewFaculty"
        Me.DataGridViewFaculty.ReadOnly = True
        Me.DataGridViewFaculty.RowHeadersVisible = False
        Me.DataGridViewFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewFaculty.Size = New System.Drawing.Size(866, 250)
        Me.DataGridViewFaculty.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(748, 24)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(115, 30)
        Me.btn_Save.TabIndex = 4
        Me.btn_Save.Text = "Register"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Employee ID"
        '
        'btn_Update
        '
        Me.btn_Update.Location = New System.Drawing.Point(748, 24)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(115, 30)
        Me.btn_Update.TabIndex = 6
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = True
        Me.btn_Update.Visible = False
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(748, 135)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(115, 30)
        Me.btn_Close.TabIndex = 7
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "School/College"
        '
        'txt_Empid
        '
        Me.txt_Empid.Location = New System.Drawing.Point(156, 33)
        Me.txt_Empid.Name = "txt_Empid"
        Me.txt_Empid.Size = New System.Drawing.Size(199, 26)
        Me.txt_Empid.TabIndex = 11
        '
        'txt_Fname
        '
        Me.txt_Fname.Location = New System.Drawing.Point(156, 62)
        Me.txt_Fname.Name = "txt_Fname"
        Me.txt_Fname.Size = New System.Drawing.Size(199, 26)
        Me.txt_Fname.TabIndex = 12
        '
        'txt_Mname
        '
        Me.txt_Mname.Location = New System.Drawing.Point(156, 91)
        Me.txt_Mname.Name = "txt_Mname"
        Me.txt_Mname.Size = New System.Drawing.Size(199, 26)
        Me.txt_Mname.TabIndex = 13
        '
        'txt_Lname
        '
        Me.txt_Lname.Location = New System.Drawing.Point(156, 120)
        Me.txt_Lname.Name = "txt_Lname"
        Me.txt_Lname.Size = New System.Drawing.Size(199, 26)
        Me.txt_Lname.TabIndex = 14
        '
        'txt_SchoolCollege
        '
        Me.txt_SchoolCollege.Location = New System.Drawing.Point(525, 36)
        Me.txt_SchoolCollege.Name = "txt_SchoolCollege"
        Me.txt_SchoolCollege.Size = New System.Drawing.Size(159, 26)
        Me.txt_SchoolCollege.TabIndex = 15
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(748, 97)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(115, 30)
        Me.btn_Delete.TabIndex = 16
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(748, 59)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(115, 30)
        Me.btn_Clear.TabIndex = 17
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'FacultyManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(903, 463)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.txt_SchoolCollege)
        Me.Controls.Add(Me.txt_Lname)
        Me.Controls.Add(Me.txt_Mname)
        Me.Controls.Add(Me.txt_Fname)
        Me.Controls.Add(Me.txt_Empid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_Update)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FacultyManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faculty Registration"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewFaculty As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Empid As TextBox
    Friend WithEvents txt_Fname As TextBox
    Friend WithEvents txt_Mname As TextBox
    Friend WithEvents txt_Lname As TextBox
    Friend WithEvents txt_SchoolCollege As TextBox
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
End Class
