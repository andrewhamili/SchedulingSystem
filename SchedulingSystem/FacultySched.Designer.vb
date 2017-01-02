<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacultySched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacultySched))
        Me.DataGridViewSched = New System.Windows.Forms.DataGridView()
        Me.LabelFacultyName = New System.Windows.Forms.Label()
        Me.lbltotalunit = New System.Windows.Forms.Label()
        Me.PictureBoxPrint = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewSched, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewSched
        '
        Me.DataGridViewSched.AllowUserToAddRows = False
        Me.DataGridViewSched.AllowUserToDeleteRows = False
        Me.DataGridViewSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSched.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewSched.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewSched.Location = New System.Drawing.Point(0, 203)
        Me.DataGridViewSched.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridViewSched.Name = "DataGridViewSched"
        Me.DataGridViewSched.ReadOnly = True
        Me.DataGridViewSched.RowHeadersVisible = False
        Me.DataGridViewSched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSched.Size = New System.Drawing.Size(894, 208)
        Me.DataGridViewSched.TabIndex = 0
        '
        'LabelFacultyName
        '
        Me.LabelFacultyName.AutoSize = True
        Me.LabelFacultyName.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.LabelFacultyName.Location = New System.Drawing.Point(378, 28)
        Me.LabelFacultyName.Name = "LabelFacultyName"
        Me.LabelFacultyName.Size = New System.Drawing.Size(176, 23)
        Me.LabelFacultyName.TabIndex = 1
        Me.LabelFacultyName.Text = "LabelFacultyName"
        '
        'lbltotalunit
        '
        Me.lbltotalunit.AutoSize = True
        Me.lbltotalunit.Location = New System.Drawing.Point(12, 181)
        Me.lbltotalunit.Name = "lbltotalunit"
        Me.lbltotalunit.Size = New System.Drawing.Size(76, 18)
        Me.lbltotalunit.TabIndex = 2
        Me.lbltotalunit.Text = "lbltotalunit"
        '
        'PictureBoxPrint
        '
        Me.PictureBoxPrint.Image = Global.SchedulingSystem.My.Resources.Resources.giphy
        Me.PictureBoxPrint.Location = New System.Drawing.Point(382, 109)
        Me.PictureBoxPrint.Name = "PictureBoxPrint"
        Me.PictureBoxPrint.Size = New System.Drawing.Size(182, 78)
        Me.PictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPrint.TabIndex = 3
        Me.PictureBoxPrint.TabStop = False
        '
        'FacultySched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(894, 411)
        Me.Controls.Add(Me.PictureBoxPrint)
        Me.Controls.Add(Me.lbltotalunit)
        Me.Controls.Add(Me.LabelFacultyName)
        Me.Controls.Add(Me.DataGridViewSched)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacultySched"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FacultySched"
        CType(Me.DataGridViewSched, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewSched As System.Windows.Forms.DataGridView
    Friend WithEvents LabelFacultyName As System.Windows.Forms.Label
    Friend WithEvents lbltotalunit As System.Windows.Forms.Label
    Friend WithEvents PictureBoxPrint As System.Windows.Forms.PictureBox
End Class
