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
        CType(Me.DataGridSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridSubjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridSubjects.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridSubjects.Location = New System.Drawing.Point(0, 0)
        Me.DataGridSubjects.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridSubjects.Name = "DataGridSubjects"
        Me.DataGridSubjects.ReadOnly = True
        Me.DataGridSubjects.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridSubjects.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSubjects.Size = New System.Drawing.Size(479, 334)
        Me.DataGridSubjects.TabIndex = 5
        '
        'ControlViewSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridSubjects)
        Me.Name = "ControlViewSubjects"
        Me.Size = New System.Drawing.Size(479, 334)
        CType(Me.DataGridSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridSubjects As System.Windows.Forms.DataGridView

End Class
