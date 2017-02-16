<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpForm
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
        Me.Btnout = New System.Windows.Forms.Button()
        Me.Btndata = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridSched = New System.Windows.Forms.DataGridView()
        Me.ListBoxRooms = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageRoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnout
        '
        Me.Btnout.Location = New System.Drawing.Point(915, 49)
        Me.Btnout.Name = "Btnout"
        Me.Btnout.Size = New System.Drawing.Size(182, 48)
        Me.Btnout.TabIndex = 0
        Me.Btnout.Text = "Log-out"
        Me.Btnout.UseVisualStyleBackColor = True
        '
        'Btndata
        '
        Me.Btndata.Location = New System.Drawing.Point(693, 49)
        Me.Btndata.Name = "Btndata"
        Me.Btndata.Size = New System.Drawing.Size(182, 48)
        Me.Btndata.TabIndex = 1
        Me.Btndata.Text = "Download Data"
        Me.Btndata.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridSched)
        Me.GroupBox1.Controls.Add(Me.ListBoxRooms)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1080, 445)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'DataGridSched
        '
        Me.DataGridSched.AllowUserToAddRows = False
        Me.DataGridSched.AllowUserToDeleteRows = False
        Me.DataGridSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridSched.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSched.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridSched.Location = New System.Drawing.Point(281, 34)
        Me.DataGridSched.Name = "DataGridSched"
        Me.DataGridSched.ReadOnly = True
        Me.DataGridSched.RowHeadersVisible = False
        Me.DataGridSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSched.Size = New System.Drawing.Size(777, 363)
        Me.DataGridSched.TabIndex = 1
        '
        'ListBoxRooms
        '
        Me.ListBoxRooms.FormattingEnabled = True
        Me.ListBoxRooms.ItemHeight = 18
        Me.ListBoxRooms.Location = New System.Drawing.Point(44, 33)
        Me.ListBoxRooms.Name = "ListBoxRooms"
        Me.ListBoxRooms.Size = New System.Drawing.Size(198, 364)
        Me.ListBoxRooms.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(260, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome to Centro Escolar University"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Moccasin
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(196, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(469, 56)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Faculty Workload Scheduling System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SchedulingSystem.My.Resources.Resources.CEU_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduleToolStripMenuItem, Me.RoomToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1173, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssignToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ScheduleToolStripMenuItem.Text = "Schedule"
        '
        'AssignToolStripMenuItem
        '
        Me.AssignToolStripMenuItem.Name = "AssignToolStripMenuItem"
        Me.AssignToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AssignToolStripMenuItem.Text = "Assign"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageRoomsToolStripMenuItem})
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'ManageRoomsToolStripMenuItem
        '
        Me.ManageRoomsToolStripMenuItem.Name = "ManageRoomsToolStripMenuItem"
        Me.ManageRoomsToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ManageRoomsToolStripMenuItem.Text = "Manage Rooms"
        '
        'UpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1173, 644)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btndata)
        Me.Controls.Add(Me.Btnout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnout As System.Windows.Forms.Button
    Friend WithEvents Btndata As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridSched As System.Windows.Forms.DataGridView
    Friend WithEvents ListBoxRooms As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageRoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
