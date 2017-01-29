<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserWindow))
        Me.lblWelcomeText = New System.Windows.Forms.Label()
        Me.DataGridViewSched = New System.Windows.Forms.DataGridView()
        Me.lblTotalUnit = New System.Windows.Forms.Label()
        Me.PictureBoxPrint = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQueryRooms = New System.Windows.Forms.Button()
        CType(Me.DataGridViewSched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeText
        '
        Me.lblWelcomeText.AutoSize = True
        Me.lblWelcomeText.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcomeText.ForeColor = System.Drawing.Color.Green
        Me.lblWelcomeText.Location = New System.Drawing.Point(13, 13)
        Me.lblWelcomeText.Name = "lblWelcomeText"
        Me.lblWelcomeText.Size = New System.Drawing.Size(194, 29)
        Me.lblWelcomeText.TabIndex = 0
        Me.lblWelcomeText.Text = "lblWelcomeText"
        '
        'DataGridViewSched
        '
        Me.DataGridViewSched.AllowUserToAddRows = False
        Me.DataGridViewSched.AllowUserToDeleteRows = False
        Me.DataGridViewSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSched.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewSched.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewSched.Location = New System.Drawing.Point(0, 260)
        Me.DataGridViewSched.Name = "DataGridViewSched"
        Me.DataGridViewSched.ReadOnly = True
        Me.DataGridViewSched.RowHeadersVisible = False
        Me.DataGridViewSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSched.Size = New System.Drawing.Size(899, 196)
        Me.DataGridViewSched.TabIndex = 1
        '
        'lblTotalUnit
        '
        Me.lblTotalUnit.AutoSize = True
        Me.lblTotalUnit.Location = New System.Drawing.Point(111, 228)
        Me.lblTotalUnit.Name = "lblTotalUnit"
        Me.lblTotalUnit.Size = New System.Drawing.Size(82, 18)
        Me.lblTotalUnit.TabIndex = 2
        Me.lblTotalUnit.Text = "lblTotalUnit"
        '
        'PictureBoxPrint
        '
        Me.PictureBoxPrint.Image = Global.SchedulingSystem.My.Resources.Resources.giphy
        Me.PictureBoxPrint.Location = New System.Drawing.Point(393, 182)
        Me.PictureBoxPrint.Name = "PictureBoxPrint"
        Me.PictureBoxPrint.Size = New System.Drawing.Size(133, 64)
        Me.PictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPrint.TabIndex = 3
        Me.PictureBoxPrint.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "School Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(373, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Semester:"
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.Location = New System.Drawing.Point(471, 40)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.Size = New System.Drawing.Size(102, 18)
        Me.lblSchoolYear.TabIndex = 7
        Me.lblSchoolYear.Text = "lblSchoolYear"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(472, 74)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(91, 18)
        Me.lblSemester.TabIndex = 8
        Me.lblSemester.Text = "lblSemester"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(777, 8)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(110, 45)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "Log-out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Total Unit(s):"
        '
        'btnQueryRooms
        '
        Me.btnQueryRooms.Location = New System.Drawing.Point(777, 60)
        Me.btnQueryRooms.Name = "btnQueryRooms"
        Me.btnQueryRooms.Size = New System.Drawing.Size(110, 52)
        Me.btnQueryRooms.TabIndex = 11
        Me.btnQueryRooms.Text = "Check room availability"
        Me.btnQueryRooms.UseVisualStyleBackColor = True
        '
        'UserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 456)
        Me.Controls.Add(Me.btnQueryRooms)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblSchoolYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBoxPrint)
        Me.Controls.Add(Me.lblTotalUnit)
        Me.Controls.Add(Me.DataGridViewSched)
        Me.Controls.Add(Me.lblWelcomeText)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserWindow"
        CType(Me.DataGridViewSched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcomeText As System.Windows.Forms.Label
    Friend WithEvents DataGridViewSched As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotalUnit As System.Windows.Forms.Label
    Friend WithEvents PictureBoxPrint As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSchoolYear As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnQueryRooms As System.Windows.Forms.Button
End Class
