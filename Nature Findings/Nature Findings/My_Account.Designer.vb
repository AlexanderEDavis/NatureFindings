<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_Account
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
        Me.components = New System.ComponentModel.Container()
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Contributor_NameLabel As System.Windows.Forms.Label
        Dim About_UserLabel As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Welcome_Screen_Button = New System.Windows.Forms.Button()
        Me.UsersTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.UsersTableAdapter()
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Contributor_NameTextBox = New System.Windows.Forms.TextBox()
        Me.About_UserTextBox = New System.Windows.Forms.TextBox()
        User_IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Contributor_NameLabel = New System.Windows.Forms.Label()
        About_UserLabel = New System.Windows.Forms.Label()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Location = New System.Drawing.Point(8, 84)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.Size = New System.Drawing.Size(46, 13)
        User_IDLabel.TabIndex = 38
        User_IDLabel.Text = "User ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(8, 110)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 40
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(10, 136)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 41
        PasswordLabel.Text = "Password:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(9, 162)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(76, 13)
        Email_AddressLabel.TabIndex = 42
        Email_AddressLabel.Text = "Email Address:"
        '
        'Contributor_NameLabel
        '
        Contributor_NameLabel.AutoSize = True
        Contributor_NameLabel.Location = New System.Drawing.Point(10, 188)
        Contributor_NameLabel.Name = "Contributor_NameLabel"
        Contributor_NameLabel.Size = New System.Drawing.Size(92, 13)
        Contributor_NameLabel.TabIndex = 43
        Contributor_NameLabel.Text = "Contributor Name:"
        '
        'About_UserLabel
        '
        About_UserLabel.AutoSize = True
        About_UserLabel.Location = New System.Drawing.Point(39, 214)
        About_UserLabel.Name = "About_UserLabel"
        About_UserLabel.Size = New System.Drawing.Size(63, 13)
        About_UserLabel.TabIndex = 44
        About_UserLabel.Text = "About User:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "My Account"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nature Findings"
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(12, 12)
        Me.Welcome_Screen_Button.Name = "Welcome_Screen_Button"
        Me.Welcome_Screen_Button.Size = New System.Drawing.Size(75, 37)
        Me.Welcome_Screen_Button.TabIndex = 15
        Me.Welcome_Screen_Button.Text = "Welcome Screen"
        Me.Welcome_Screen_Button.UseVisualStyleBackColor = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'Nature_Findings_Database
        '
        Me.Nature_Findings_Database.DataSetName = "Nature_Findings_Database"
        Me.Nature_Findings_Database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.Nature_Findings_Database
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.SpeciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_Species_LinkTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "User_ID", True))
        Me.User_IDTextBox.Location = New System.Drawing.Point(108, 81)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.ReadOnly = True
        Me.User_IDTextBox.Size = New System.Drawing.Size(196, 20)
        Me.User_IDTextBox.TabIndex = 39
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(229, 278)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 40
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(108, 107)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(196, 20)
        Me.UsernameTextBox.TabIndex = 41
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(108, 133)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(196, 20)
        Me.PasswordTextBox.TabIndex = 42
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Email_Address", True))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(108, 159)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(196, 20)
        Me.Email_AddressTextBox.TabIndex = 43
        '
        'Contributor_NameTextBox
        '
        Me.Contributor_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "Contributor_Name", True))
        Me.Contributor_NameTextBox.Location = New System.Drawing.Point(108, 185)
        Me.Contributor_NameTextBox.Name = "Contributor_NameTextBox"
        Me.Contributor_NameTextBox.Size = New System.Drawing.Size(196, 20)
        Me.Contributor_NameTextBox.TabIndex = 44
        '
        'About_UserTextBox
        '
        Me.About_UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "About_User", True))
        Me.About_UserTextBox.Location = New System.Drawing.Point(108, 211)
        Me.About_UserTextBox.Multiline = True
        Me.About_UserTextBox.Name = "About_UserTextBox"
        Me.About_UserTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.About_UserTextBox.Size = New System.Drawing.Size(196, 61)
        Me.About_UserTextBox.TabIndex = 45
        '
        'My_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(327, 321)
        Me.Controls.Add(About_UserLabel)
        Me.Controls.Add(Me.About_UserTextBox)
        Me.Controls.Add(Contributor_NameLabel)
        Me.Controls.Add(Me.Contributor_NameTextBox)
        Me.Controls.Add(Email_AddressLabel)
        Me.Controls.Add(Me.Email_AddressTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(User_IDLabel)
        Me.Controls.Add(Me.User_IDTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.Controls.Add(Me.Label1)
        Me.Name = "My_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Findings: My Account"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents UsersTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.UsersTableAdapter
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents User_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contributor_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents About_UserTextBox As System.Windows.Forms.TextBox
End Class
