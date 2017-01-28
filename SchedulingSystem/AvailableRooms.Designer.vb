<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailableRooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvailableRooms))
        Me.DataGridAvailableRooms = New System.Windows.Forms.DataGridView()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lbl_avRoom = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        CType(Me.DataGridAvailableRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridAvailableRooms
        '
        Me.DataGridAvailableRooms.AllowUserToAddRows = False
        Me.DataGridAvailableRooms.AllowUserToDeleteRows = False
        Me.DataGridAvailableRooms.AllowUserToResizeRows = False
        Me.DataGridAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAvailableRooms.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridAvailableRooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridAvailableRooms.Location = New System.Drawing.Point(0, 119)
        Me.DataGridAvailableRooms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridAvailableRooms.Name = "DataGridAvailableRooms"
        Me.DataGridAvailableRooms.ReadOnly = True
        Me.DataGridAvailableRooms.RowHeadersVisible = False
        Me.DataGridAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAvailableRooms.Size = New System.Drawing.Size(1362, 623)
        Me.DataGridAvailableRooms.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Location = New System.Drawing.Point(16, 17)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(114, 19)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Logged in as:"
        '
        'lbl_avRoom
        '
        Me.lbl_avRoom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_avRoom.AutoSize = True
        Me.lbl_avRoom.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_avRoom.Location = New System.Drawing.Point(742, 96)
        Me.lbl_avRoom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_avRoom.Name = "lbl_avRoom"
        Me.lbl_avRoom.Size = New System.Drawing.Size(179, 24)
        Me.lbl_avRoom.TabIndex = 5
        Me.lbl_avRoom.Text = "Available Rooms"
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Green
        Me.lbl_user.Location = New System.Drawing.Point(138, 17)
        Me.lbl_user.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(0, 19)
        Me.lbl_user.TabIndex = 6
        '
        'AvailableRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_avRoom)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.DataGridAvailableRooms)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AvailableRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Rooms"
        CType(Me.DataGridAvailableRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridAvailableRooms As DataGridView
    Friend WithEvents lblName As Label
    Friend WithEvents lbl_avRoom As Label
    Friend WithEvents lbl_user As Label
End Class
