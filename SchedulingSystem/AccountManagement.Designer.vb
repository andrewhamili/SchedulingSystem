<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountManagement))
        Me.PanelEditOrDelete = New System.Windows.Forms.Panel()
        Me.PanelCreate = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxUsertype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtRetypePassword = New System.Windows.Forms.TextBox()
        Me.PanelTools = New System.Windows.Forms.Panel()
        Me.DataGridViewAccounts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEditOrDelete.SuspendLayout()
        Me.PanelCreate.SuspendLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEditOrDelete
        '
        Me.PanelEditOrDelete.Controls.Add(Me.PanelCreate)
        Me.PanelEditOrDelete.Controls.Add(Me.PanelTools)
        Me.PanelEditOrDelete.Controls.Add(Me.DataGridViewAccounts)
        Me.PanelEditOrDelete.Controls.Add(Me.Label1)
        Me.PanelEditOrDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEditOrDelete.Location = New System.Drawing.Point(0, 0)
        Me.PanelEditOrDelete.Name = "PanelEditOrDelete"
        Me.PanelEditOrDelete.Size = New System.Drawing.Size(550, 535)
        Me.PanelEditOrDelete.TabIndex = 22
        '
        'PanelCreate
        '
        Me.PanelCreate.Controls.Add(Me.Label2)
        Me.PanelCreate.Controls.Add(Me.txtFname)
        Me.PanelCreate.Controls.Add(Me.btnDelete)
        Me.PanelCreate.Controls.Add(Me.txtUsername)
        Me.PanelCreate.Controls.Add(Me.Label8)
        Me.PanelCreate.Controls.Add(Me.Label4)
        Me.PanelCreate.Controls.Add(Me.btnSave)
        Me.PanelCreate.Controls.Add(Me.Label5)
        Me.PanelCreate.Controls.Add(Me.txtPassword)
        Me.PanelCreate.Controls.Add(Me.btnCancel)
        Me.PanelCreate.Controls.Add(Me.txtLname)
        Me.PanelCreate.Controls.Add(Me.Label7)
        Me.PanelCreate.Controls.Add(Me.Label3)
        Me.PanelCreate.Controls.Add(Me.ComboBoxUsertype)
        Me.PanelCreate.Controls.Add(Me.Label6)
        Me.PanelCreate.Controls.Add(Me.txtMname)
        Me.PanelCreate.Controls.Add(Me.txtRetypePassword)
        Me.PanelCreate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCreate.Location = New System.Drawing.Point(0, 0)
        Me.PanelCreate.Name = "PanelCreate"
        Me.PanelCreate.Size = New System.Drawing.Size(550, 535)
        Me.PanelCreate.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "First Name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(201, 120)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(200, 26)
        Me.txtFname.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(229, 363)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 44)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Clear"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(201, 219)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 26)
        Me.txtUsername.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "User Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Last Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(115, 363)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 44)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(201, 251)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 26)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(332, 363)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 44)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(201, 186)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(200, 26)
        Me.txtLname.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Re-type Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Middle Name"
        '
        'ComboBoxUsertype
        '
        Me.ComboBoxUsertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUsertype.FormattingEnabled = True
        Me.ComboBoxUsertype.Items.AddRange(New Object() {"Administrator", "User"})
        Me.ComboBoxUsertype.Location = New System.Drawing.Point(200, 316)
        Me.ComboBoxUsertype.Name = "ComboBoxUsertype"
        Me.ComboBoxUsertype.Size = New System.Drawing.Size(200, 26)
        Me.ComboBoxUsertype.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Password"
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(201, 153)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(200, 26)
        Me.txtMname.TabIndex = 2
        '
        'txtRetypePassword
        '
        Me.txtRetypePassword.Location = New System.Drawing.Point(201, 283)
        Me.txtRetypePassword.Name = "txtRetypePassword"
        Me.txtRetypePassword.Size = New System.Drawing.Size(200, 26)
        Me.txtRetypePassword.TabIndex = 7
        Me.txtRetypePassword.UseSystemPasswordChar = True
        '
        'PanelTools
        '
        Me.PanelTools.Location = New System.Drawing.Point(3, 200)
        Me.PanelTools.Name = "PanelTools"
        Me.PanelTools.Size = New System.Drawing.Size(544, 323)
        Me.PanelTools.TabIndex = 21
        '
        'DataGridViewAccounts
        '
        Me.DataGridViewAccounts.AllowUserToAddRows = False
        Me.DataGridViewAccounts.AllowUserToDeleteRows = False
        Me.DataGridViewAccounts.AllowUserToResizeRows = False
        Me.DataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewAccounts.Location = New System.Drawing.Point(3, 0)
        Me.DataGridViewAccounts.Name = "DataGridViewAccounts"
        Me.DataGridViewAccounts.ReadOnly = True
        Me.DataGridViewAccounts.RowHeadersVisible = False
        Me.DataGridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAccounts.Size = New System.Drawing.Size(550, 150)
        Me.DataGridViewAccounts.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Double-click a row to edit (Only Password and User type is editable)"
        '
        'AccountManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEditOrDelete)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AccountManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountManagement"
        Me.PanelEditOrDelete.ResumeLayout(False)
        Me.PanelEditOrDelete.PerformLayout()
        Me.PanelCreate.ResumeLayout(False)
        Me.PanelCreate.PerformLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEditOrDelete As System.Windows.Forms.Panel
    Friend WithEvents PanelTools As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewAccounts As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelCreate As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxUsertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txtRetypePassword As System.Windows.Forms.TextBox
End Class
