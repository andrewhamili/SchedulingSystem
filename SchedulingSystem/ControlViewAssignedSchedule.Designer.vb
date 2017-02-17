<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlViewAssignedSchedule
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridSched = New System.Windows.Forms.DataGridView()
        Me.TabControlContainer = New System.Windows.Forms.TabControl()
        Me.TabAll = New System.Windows.Forms.TabPage()
        Me.TabSpecific = New System.Windows.Forms.TabPage()
        Me.DataGridFaculty = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlContainer.SuspendLayout()
        Me.TabAll.SuspendLayout()
        Me.TabSpecific.SuspendLayout()
        CType(Me.DataGridFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridSched
        '
        Me.DataGridSched.AllowUserToAddRows = False
        Me.DataGridSched.AllowUserToDeleteRows = False
        Me.DataGridSched.AllowUserToResizeRows = False
        Me.DataGridSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSched.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSched.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridSched.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridSched.Location = New System.Drawing.Point(3, 3)
        Me.DataGridSched.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridSched.Name = "DataGridSched"
        Me.DataGridSched.ReadOnly = True
        Me.DataGridSched.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridSched.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSched.Size = New System.Drawing.Size(850, 525)
        Me.DataGridSched.TabIndex = 4
        '
        'TabControlContainer
        '
        Me.TabControlContainer.Controls.Add(Me.TabAll)
        Me.TabControlContainer.Controls.Add(Me.TabSpecific)
        Me.TabControlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlContainer.Location = New System.Drawing.Point(0, 0)
        Me.TabControlContainer.Name = "TabControlContainer"
        Me.TabControlContainer.SelectedIndex = 0
        Me.TabControlContainer.Size = New System.Drawing.Size(864, 562)
        Me.TabControlContainer.TabIndex = 5
        '
        'TabAll
        '
        Me.TabAll.Controls.Add(Me.DataGridSched)
        Me.TabAll.Location = New System.Drawing.Point(4, 27)
        Me.TabAll.Name = "TabAll"
        Me.TabAll.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAll.Size = New System.Drawing.Size(856, 531)
        Me.TabAll.TabIndex = 0
        Me.TabAll.Text = "All"
        Me.TabAll.UseVisualStyleBackColor = True
        '
        'TabSpecific
        '
        Me.TabSpecific.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabSpecific.Controls.Add(Me.Label1)
        Me.TabSpecific.Controls.Add(Me.DataGridFaculty)
        Me.TabSpecific.Location = New System.Drawing.Point(4, 27)
        Me.TabSpecific.Name = "TabSpecific"
        Me.TabSpecific.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSpecific.Size = New System.Drawing.Size(856, 531)
        Me.TabSpecific.TabIndex = 1
        Me.TabSpecific.Text = "Specific Employee"
        '
        'DataGridFaculty
        '
        Me.DataGridFaculty.AllowUserToAddRows = False
        Me.DataGridFaculty.AllowUserToDeleteRows = False
        Me.DataGridFaculty.AllowUserToResizeRows = False
        Me.DataGridFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridFaculty.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFaculty.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridFaculty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridFaculty.Location = New System.Drawing.Point(3, 277)
        Me.DataGridFaculty.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridFaculty.Name = "DataGridFaculty"
        Me.DataGridFaculty.ReadOnly = True
        Me.DataGridFaculty.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridFaculty.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridFaculty.Size = New System.Drawing.Size(850, 251)
        Me.DataGridFaculty.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Double-Click a row to view"
        '
        'ControlViewAssignedSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlContainer)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ControlViewAssignedSchedule"
        Me.Size = New System.Drawing.Size(864, 562)
        CType(Me.DataGridSched, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlContainer.ResumeLayout(False)
        Me.TabAll.ResumeLayout(False)
        Me.TabSpecific.ResumeLayout(False)
        Me.TabSpecific.PerformLayout()
        CType(Me.DataGridFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridSched As System.Windows.Forms.DataGridView
    Friend WithEvents TabControlContainer As System.Windows.Forms.TabControl
    Friend WithEvents TabAll As System.Windows.Forms.TabPage
    Friend WithEvents TabSpecific As System.Windows.Forms.TabPage
    Friend WithEvents DataGridFaculty As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
