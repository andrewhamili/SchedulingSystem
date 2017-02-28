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
        Me.DataGridViewAccounts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTools = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFnameEdit = New System.Windows.Forms.TextBox()
        Me.btn_ClearEdit = New System.Windows.Forms.Button()
        Me.txtUsernameEdit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPasswordEdit = New System.Windows.Forms.TextBox()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.txtLnameEdit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBoxUsertypeEdit = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMnameEdit = New System.Windows.Forms.TextBox()
        Me.txtRetypePasswordEdit = New System.Windows.Forms.TextBox()
        Me.btn_SaveEdit = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
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
        Me.PanelEditOrDelete.SuspendLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTools.SuspendLayout()
        Me.PanelCreate.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEditOrDelete
        '
        Me.PanelEditOrDelete.Controls.Add(Me.DataGridViewAccounts)
        Me.PanelEditOrDelete.Controls.Add(Me.Label1)
        Me.PanelEditOrDelete.Controls.Add(Me.PanelTools)
        Me.PanelEditOrDelete.Controls.Add(Me.BtnClose)
        Me.PanelEditOrDelete.Location = New System.Drawing.Point(1, 3)
        Me.PanelEditOrDelete.Name = "PanelEditOrDelete"
        Me.PanelEditOrDelete.Size = New System.Drawing.Size(518, 520)
        Me.PanelEditOrDelete.TabIndex = 22
        Me.PanelEditOrDelete.Visible = False
        '
        'DataGridViewAccounts
        '
        Me.DataGridViewAccounts.AllowUserToAddRows = False
        Me.DataGridViewAccounts.AllowUserToDeleteRows = False
        Me.DataGridViewAccounts.AllowUserToResizeRows = False
        Me.DataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewAccounts.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewAccounts.Name = "DataGridViewAccounts"
        Me.DataGridViewAccounts.ReadOnly = True
        Me.DataGridViewAccounts.RowHeadersVisible = False
        Me.DataGridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAccounts.Size = New System.Drawing.Size(518, 150)
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
        'PanelTools
        '
        Me.PanelTools.Controls.Add(Me.Label9)
        Me.PanelTools.Controls.Add(Me.txtFnameEdit)
        Me.PanelTools.Controls.Add(Me.btn_ClearEdit)
        Me.PanelTools.Controls.Add(Me.txtUsernameEdit)
        Me.PanelTools.Controls.Add(Me.Label10)
        Me.PanelTools.Controls.Add(Me.Label11)
        Me.PanelTools.Controls.Add(Me.Label12)
        Me.PanelTools.Controls.Add(Me.txtPasswordEdit)
        Me.PanelTools.Controls.Add(Me.btn_Cancel)
        Me.PanelTools.Controls.Add(Me.txtLnameEdit)
        Me.PanelTools.Controls.Add(Me.Label13)
        Me.PanelTools.Controls.Add(Me.Label14)
        Me.PanelTools.Controls.Add(Me.ComboBoxUsertypeEdit)
        Me.PanelTools.Controls.Add(Me.Label15)
        Me.PanelTools.Controls.Add(Me.txtMnameEdit)
        Me.PanelTools.Controls.Add(Me.txtRetypePasswordEdit)
        Me.PanelTools.Controls.Add(Me.btn_SaveEdit)
        Me.PanelTools.Location = New System.Drawing.Point(3, 190)
        Me.PanelTools.Name = "PanelTools"
        Me.PanelTools.Size = New System.Drawing.Size(515, 343)
        Me.PanelTools.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(109, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 18)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "First Name"
        '
        'txtFnameEdit
        '
        Me.txtFnameEdit.Enabled = False
        Me.txtFnameEdit.Location = New System.Drawing.Point(214, 13)
        Me.txtFnameEdit.Name = "txtFnameEdit"
        Me.txtFnameEdit.Size = New System.Drawing.Size(200, 26)
        Me.txtFnameEdit.TabIndex = 21
        '
        'btn_ClearEdit
        '
        Me.btn_ClearEdit.Location = New System.Drawing.Point(214, 268)
        Me.btn_ClearEdit.Name = "btn_ClearEdit"
        Me.btn_ClearEdit.Size = New System.Drawing.Size(97, 44)
        Me.btn_ClearEdit.TabIndex = 29
        Me.btn_ClearEdit.Text = "Clear"
        Me.btn_ClearEdit.UseVisualStyleBackColor = True
        '
        'txtUsernameEdit
        '
        Me.txtUsernameEdit.Enabled = False
        Me.txtUsernameEdit.Location = New System.Drawing.Point(214, 112)
        Me.txtUsernameEdit.Name = "txtUsernameEdit"
        Me.txtUsernameEdit.Size = New System.Drawing.Size(200, 26)
        Me.txtUsernameEdit.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(115, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "User Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(109, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Last Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(113, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Username"
        '
        'txtPasswordEdit
        '
        Me.txtPasswordEdit.Location = New System.Drawing.Point(214, 144)
        Me.txtPasswordEdit.Name = "txtPasswordEdit"
        Me.txtPasswordEdit.Size = New System.Drawing.Size(200, 26)
        Me.txtPasswordEdit.TabIndex = 25
        Me.txtPasswordEdit.UseSystemPasswordChar = True
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(317, 268)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(100, 44)
        Me.btn_Cancel.TabIndex = 30
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = True
        '
        'txtLnameEdit
        '
        Me.txtLnameEdit.Enabled = False
        Me.txtLnameEdit.Location = New System.Drawing.Point(214, 79)
        Me.txtLnameEdit.Name = "txtLnameEdit"
        Me.txtLnameEdit.Size = New System.Drawing.Size(200, 26)
        Me.txtLnameEdit.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(57, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 18)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Re-type Password"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(93, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 18)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Middle Name"
        '
        'ComboBoxUsertypeEdit
        '
        Me.ComboBoxUsertypeEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUsertypeEdit.FormattingEnabled = True
        Me.ComboBoxUsertypeEdit.Items.AddRange(New Object() {"Administrator", "User"})
        Me.ComboBoxUsertypeEdit.Location = New System.Drawing.Point(213, 209)
        Me.ComboBoxUsertypeEdit.Name = "ComboBoxUsertypeEdit"
        Me.ComboBoxUsertypeEdit.Size = New System.Drawing.Size(200, 26)
        Me.ComboBoxUsertypeEdit.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(113, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 18)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Password"
        '
        'txtMnameEdit
        '
        Me.txtMnameEdit.Enabled = False
        Me.txtMnameEdit.Location = New System.Drawing.Point(214, 46)
        Me.txtMnameEdit.Name = "txtMnameEdit"
        Me.txtMnameEdit.Size = New System.Drawing.Size(200, 26)
        Me.txtMnameEdit.TabIndex = 22
        '
        'txtRetypePasswordEdit
        '
        Me.txtRetypePasswordEdit.Location = New System.Drawing.Point(214, 176)
        Me.txtRetypePasswordEdit.Name = "txtRetypePasswordEdit"
        Me.txtRetypePasswordEdit.Size = New System.Drawing.Size(200, 26)
        Me.txtRetypePasswordEdit.TabIndex = 26
        Me.txtRetypePasswordEdit.UseSystemPasswordChar = True
        '
        'btn_SaveEdit
        '
        Me.btn_SaveEdit.Location = New System.Drawing.Point(100, 268)
        Me.btn_SaveEdit.Name = "btn_SaveEdit"
        Me.btn_SaveEdit.Size = New System.Drawing.Size(108, 44)
        Me.btn_SaveEdit.TabIndex = 28
        Me.btn_SaveEdit.Text = "Save"
        Me.btn_SaveEdit.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(188, 257)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(176, 48)
        Me.BtnClose.TabIndex = 22
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
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
        Me.PanelCreate.Location = New System.Drawing.Point(1, 3)
        Me.PanelCreate.Name = "PanelCreate"
        Me.PanelCreate.Size = New System.Drawing.Size(518, 484)
        Me.PanelCreate.TabIndex = 22
        Me.PanelCreate.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "First Name"
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(223, 78)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(200, 26)
        Me.txtFname.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(229, 394)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 44)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Clear"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(223, 209)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 26)
        Me.txtUsername.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "User Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Last Name"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(115, 394)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 44)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(223, 252)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 26)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(332, 394)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 44)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(223, 166)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(200, 26)
        Me.txtLname.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Re-type Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 124)
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
        Me.ComboBoxUsertype.Location = New System.Drawing.Point(222, 339)
        Me.ComboBoxUsertype.Name = "ComboBoxUsertype"
        Me.ComboBoxUsertype.Size = New System.Drawing.Size(200, 26)
        Me.ComboBoxUsertype.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Password"
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(223, 121)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(200, 26)
        Me.txtMname.TabIndex = 2
        '
        'txtRetypePassword
        '
        Me.txtRetypePassword.Location = New System.Drawing.Point(223, 294)
        Me.txtRetypePassword.Name = "txtRetypePassword"
        Me.txtRetypePassword.Size = New System.Drawing.Size(200, 26)
        Me.txtRetypePassword.TabIndex = 7
        Me.txtRetypePassword.UseSystemPasswordChar = True
        '
        'AccountManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEditOrDelete)
        Me.Controls.Add(Me.PanelCreate)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AccountManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Management"
        Me.PanelEditOrDelete.ResumeLayout(False)
        Me.PanelEditOrDelete.PerformLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTools.ResumeLayout(False)
        Me.PanelTools.PerformLayout()
        Me.PanelCreate.ResumeLayout(False)
        Me.PanelCreate.PerformLayout()
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFnameEdit As System.Windows.Forms.TextBox
    Friend WithEvents btn_ClearEdit As System.Windows.Forms.Button
    Friend WithEvents txtUsernameEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_SaveEdit As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordEdit As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents txtLnameEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxUsertypeEdit As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMnameEdit As System.Windows.Forms.TextBox
    Friend WithEvents txtRetypePasswordEdit As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
