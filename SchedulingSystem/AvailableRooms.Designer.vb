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
        CType(Me.DataGridAvailableRooms,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridAvailableRooms
        '
        Me.DataGridAvailableRooms.AllowUserToAddRows = false
        Me.DataGridAvailableRooms.AllowUserToDeleteRows = false
        Me.DataGridAvailableRooms.AllowUserToResizeRows = false
        Me.DataGridAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAvailableRooms.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridAvailableRooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridAvailableRooms.Location = New System.Drawing.Point(0, 140)
        Me.DataGridAvailableRooms.Name = "DataGridAvailableRooms"
        Me.DataGridAvailableRooms.ReadOnly = true
        Me.DataGridAvailableRooms.RowHeadersVisible = false
        Me.DataGridAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAvailableRooms.Size = New System.Drawing.Size(1272, 450)
        Me.DataGridAvailableRooms.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = true
        Me.lblName.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Green
        Me.lblName.Location = New System.Drawing.Point(11, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(114, 19)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Logged in as:"
        '
        'lbl_avRoom
        '
        Me.lbl_avRoom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_avRoom.AutoSize = true
        Me.lbl_avRoom.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_avRoom.Location = New System.Drawing.Point(495, 69)
        Me.lbl_avRoom.Name = "lbl_avRoom"
        Me.lbl_avRoom.Size = New System.Drawing.Size(179, 24)
        Me.lbl_avRoom.TabIndex = 5
        Me.lbl_avRoom.Text = "Available Rooms"
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.lbl_user.AutoSize = true
        Me.lbl_user.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Green
        Me.lbl_user.Location = New System.Drawing.Point(121, 13)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(176, 19)
        Me.lbl_user.TabIndex = 6
        Me.lbl_user.Text = "Batallones, Charish A."
        '
        'AvailableRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 590)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_avRoom)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.DataGridAvailableRooms)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "AvailableRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Rooms"
        CType(Me.DataGridAvailableRooms,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents DataGridAvailableRooms As DataGridView
    Friend WithEvents lblName As Label
    Friend WithEvents lbl_avRoom As Label
    Friend WithEvents lbl_user As Label
End Class
