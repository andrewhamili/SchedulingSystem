<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlViewSubjects
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridSubjects = New System.Windows.Forms.DataGridView()
        Me.txtClassCodeFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridSubjects
        '
        Me.DataGridSubjects.AllowUserToAddRows = False
        Me.DataGridSubjects.AllowUserToDeleteRows = False
        Me.DataGridSubjects.AllowUserToResizeRows = False
        Me.DataGridSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSubjects.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridSubjects.Location = New System.Drawing.Point(0, 117)
        Me.DataGridSubjects.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridSubjects.Name = "DataGridSubjects"
        Me.DataGridSubjects.ReadOnly = True
        Me.DataGridSubjects.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridSubjects.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSubjects.Size = New System.Drawing.Size(535, 217)
        Me.DataGridSubjects.TabIndex = 5
        '
        'txtClassCodeFilter
        '
        Me.txtClassCodeFilter.Location = New System.Drawing.Point(267, 10)
        Me.txtClassCodeFilter.Name = "txtClassCodeFilter"
        Me.txtClassCodeFilter.Size = New System.Drawing.Size(134, 20)
        Me.txtClassCodeFilter.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Filter by Classcode"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtClassCodeFilter)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 51)
        Me.Panel1.TabIndex = 7
        '
        'ControlViewSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridSubjects)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ControlViewSubjects"
        Me.Size = New System.Drawing.Size(535, 334)
        CType(Me.DataGridSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents txtClassCodeFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
