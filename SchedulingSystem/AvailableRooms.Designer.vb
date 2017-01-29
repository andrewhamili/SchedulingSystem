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
        Me.DTP_date = New System.Windows.Forms.DateTimePicker()
        Me.DTP_timestart = New System.Windows.Forms.DateTimePicker()
        Me.ListBoxRooms = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_timeend = New System.Windows.Forms.DateTimePicker()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DTP_date
        '
        Me.DTP_date.CustomFormat = "MM/dd/yyyy"
        Me.DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_date.Location = New System.Drawing.Point(133, 12)
        Me.DTP_date.Name = "DTP_date"
        Me.DTP_date.Size = New System.Drawing.Size(105, 26)
        Me.DTP_date.TabIndex = 4
        '
        'DTP_timestart
        '
        Me.DTP_timestart.CustomFormat = "HH:mm"
        Me.DTP_timestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_timestart.Location = New System.Drawing.Point(244, 12)
        Me.DTP_timestart.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTP_timestart.Name = "DTP_timestart"
        Me.DTP_timestart.ShowUpDown = True
        Me.DTP_timestart.Size = New System.Drawing.Size(64, 26)
        Me.DTP_timestart.TabIndex = 5
        '
        'ListBoxRooms
        '
        Me.ListBoxRooms.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListBoxRooms.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.ListBoxRooms.FormattingEnabled = True
        Me.ListBoxRooms.ItemHeight = 22
        Me.ListBoxRooms.Location = New System.Drawing.Point(0, 108)
        Me.ListBoxRooms.Name = "ListBoxRooms"
        Me.ListBoxRooms.Size = New System.Drawing.Size(483, 290)
        Me.ListBoxRooms.TabIndex = 6
        Me.ListBoxRooms.UseTabStops = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Date and Time"
        '
        'DTP_timeend
        '
        Me.DTP_timeend.CustomFormat = "HH:mm"
        Me.DTP_timeend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_timeend.Location = New System.Drawing.Point(314, 11)
        Me.DTP_timeend.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.DTP_timeend.Name = "DTP_timeend"
        Me.DTP_timeend.ShowUpDown = True
        Me.DTP_timeend.Size = New System.Drawing.Size(64, 26)
        Me.DTP_timeend.TabIndex = 5
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(384, 11)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 27)
        Me.btnShow.TabIndex = 8
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'AvailableRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(483, 398)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxRooms)
        Me.Controls.Add(Me.DTP_timeend)
        Me.Controls.Add(Me.DTP_timestart)
        Me.Controls.Add(Me.DTP_date)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AvailableRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Rooms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTP_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_timestart As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBoxRooms As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_timeend As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
