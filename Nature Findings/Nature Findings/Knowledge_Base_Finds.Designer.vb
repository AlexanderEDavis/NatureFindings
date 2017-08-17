<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Knowledge_Base_Finds
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.My_Account_Button = New System.Windows.Forms.Button()
        Me.Welcome_Screen_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.User_Species_LinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_Species_LinkTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.User_Species_LinkTableAdapter()
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.Find_Search_Results = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location_ID_Button = New System.Windows.Forms.Button()
        Me.Species_ID_Button = New System.Windows.Forms.Button()
        Me.Location_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.Species_Criterial_Input = New System.Windows.Forms.TextBox()
        Me.Date_Criteria_Input = New System.Windows.Forms.DateTimePicker()
        Me.Season_Criteria_Input = New System.Windows.Forms.ComboBox()
        Me.User_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.User_ID_Button = New System.Windows.Forms.Button()
        Me.Search_By_Date_Button = New System.Windows.Forms.Button()
        Me.Search_By_User_Button = New System.Windows.Forms.Button()
        Me.Search_By_Species_Button = New System.Windows.Forms.Button()
        Me.Search_By_Location_Button = New System.Windows.Forms.Button()
        Me.Search_By_Season_Button = New System.Windows.Forms.Button()
        Me.Search_Location_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_Species_LinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Find_Search_Results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(473, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Find Search"
        '
        'My_Account_Button
        '
        Me.My_Account_Button.Location = New System.Drawing.Point(571, 12)
        Me.My_Account_Button.Name = "My_Account_Button"
        Me.My_Account_Button.Size = New System.Drawing.Size(75, 37)
        Me.My_Account_Button.TabIndex = 25
        Me.My_Account_Button.Text = "My Account"
        Me.My_Account_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(299, 12)
        Me.Welcome_Screen_Button.Name = "Welcome_Screen_Button"
        Me.Welcome_Screen_Button.Size = New System.Drawing.Size(75, 37)
        Me.Welcome_Screen_Button.TabIndex = 24
        Me.Welcome_Screen_Button.Text = "Welcome Screen"
        Me.Welcome_Screen_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nature Findings"
        '
        'Nature_Findings_Database
        '
        Me.Nature_Findings_Database.DataSetName = "Nature_Findings_Database"
        Me.Nature_Findings_Database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_Species_LinkBindingSource
        '
        Me.User_Species_LinkBindingSource.DataMember = "User_Species_Link"
        Me.User_Species_LinkBindingSource.DataSource = Me.Nature_Findings_Database
        '
        'User_Species_LinkTableAdapter
        '
        Me.User_Species_LinkTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.SpeciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_Species_LinkTableAdapter = Me.User_Species_LinkTableAdapter
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Find_Search_Results
        '
        Me.Find_Search_Results.AllowUserToAddRows = False
        Me.Find_Search_Results.AllowUserToDeleteRows = False
        Me.Find_Search_Results.AutoGenerateColumns = False
        Me.Find_Search_Results.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.Find_Search_Results.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Find_Search_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Find_Search_Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Find_Search_Results.DataSource = Me.User_Species_LinkBindingSource
        Me.Find_Search_Results.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Find_Search_Results.GridColor = System.Drawing.Color.Purple
        Me.Find_Search_Results.Location = New System.Drawing.Point(0, 132)
        Me.Find_Search_Results.Name = "Find_Search_Results"
        Me.Find_Search_Results.ReadOnly = True
        Me.Find_Search_Results.Size = New System.Drawing.Size(1028, 442)
        Me.Find_Search_Results.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "User_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "User_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Species_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Species_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Location_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Location_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Season"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Season"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Additional_Comments"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Additional_Comments"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Location_ID_Button
        '
        Me.Location_ID_Button.Location = New System.Drawing.Point(946, 53)
        Me.Location_ID_Button.Name = "Location_ID_Button"
        Me.Location_ID_Button.Size = New System.Drawing.Size(75, 23)
        Me.Location_ID_Button.TabIndex = 30
        Me.Location_ID_Button.Text = "Location IDs"
        Me.Location_ID_Button.UseVisualStyleBackColor = True
        '
        'Species_ID_Button
        '
        Me.Species_ID_Button.Location = New System.Drawing.Point(431, 103)
        Me.Species_ID_Button.Name = "Species_ID_Button"
        Me.Species_ID_Button.Size = New System.Drawing.Size(75, 23)
        Me.Species_ID_Button.TabIndex = 29
        Me.Species_ID_Button.Text = "Species IDs"
        Me.Species_ID_Button.UseVisualStyleBackColor = True
        '
        'Location_Criteria_Input
        '
        Me.Location_Criteria_Input.Location = New System.Drawing.Point(527, 55)
        Me.Location_Criteria_Input.Name = "Location_Criteria_Input"
        Me.Location_Criteria_Input.Size = New System.Drawing.Size(299, 20)
        Me.Location_Criteria_Input.TabIndex = 31
        '
        'Species_Criterial_Input
        '
        Me.Species_Criterial_Input.Location = New System.Drawing.Point(12, 105)
        Me.Species_Criterial_Input.Name = "Species_Criterial_Input"
        Me.Species_Criterial_Input.Size = New System.Drawing.Size(299, 20)
        Me.Species_Criterial_Input.TabIndex = 32
        '
        'Date_Criteria_Input
        '
        Me.Date_Criteria_Input.Location = New System.Drawing.Point(12, 52)
        Me.Date_Criteria_Input.Name = "Date_Criteria_Input"
        Me.Date_Criteria_Input.Size = New System.Drawing.Size(299, 20)
        Me.Date_Criteria_Input.TabIndex = 33
        '
        'Season_Criteria_Input
        '
        Me.Season_Criteria_Input.FormattingEnabled = True
        Me.Season_Criteria_Input.Items.AddRange(New Object() {"Spring", "Summer", "Autumn", "Winter"})
        Me.Season_Criteria_Input.Location = New System.Drawing.Point(527, 81)
        Me.Season_Criteria_Input.Name = "Season_Criteria_Input"
        Me.Season_Criteria_Input.Size = New System.Drawing.Size(299, 21)
        Me.Season_Criteria_Input.TabIndex = 34
        '
        'User_Criteria_Input
        '
        Me.User_Criteria_Input.Location = New System.Drawing.Point(12, 79)
        Me.User_Criteria_Input.Name = "User_Criteria_Input"
        Me.User_Criteria_Input.Size = New System.Drawing.Size(299, 20)
        Me.User_Criteria_Input.TabIndex = 35
        '
        'User_ID_Button
        '
        Me.User_ID_Button.Location = New System.Drawing.Point(431, 77)
        Me.User_ID_Button.Name = "User_ID_Button"
        Me.User_ID_Button.Size = New System.Drawing.Size(75, 23)
        Me.User_ID_Button.TabIndex = 36
        Me.User_ID_Button.Text = "User IDs"
        Me.User_ID_Button.UseVisualStyleBackColor = True
        '
        'Search_By_Date_Button
        '
        Me.Search_By_Date_Button.Location = New System.Drawing.Point(317, 53)
        Me.Search_By_Date_Button.Name = "Search_By_Date_Button"
        Me.Search_By_Date_Button.Size = New System.Drawing.Size(108, 23)
        Me.Search_By_Date_Button.TabIndex = 37
        Me.Search_By_Date_Button.Text = "Search By Date"
        Me.Search_By_Date_Button.UseVisualStyleBackColor = True
        '
        'Search_By_User_Button
        '
        Me.Search_By_User_Button.Location = New System.Drawing.Point(317, 77)
        Me.Search_By_User_Button.Name = "Search_By_User_Button"
        Me.Search_By_User_Button.Size = New System.Drawing.Size(108, 23)
        Me.Search_By_User_Button.TabIndex = 38
        Me.Search_By_User_Button.Text = "Search By User"
        Me.Search_By_User_Button.UseVisualStyleBackColor = True
        '
        'Search_By_Species_Button
        '
        Me.Search_By_Species_Button.Location = New System.Drawing.Point(317, 103)
        Me.Search_By_Species_Button.Name = "Search_By_Species_Button"
        Me.Search_By_Species_Button.Size = New System.Drawing.Size(108, 23)
        Me.Search_By_Species_Button.TabIndex = 39
        Me.Search_By_Species_Button.Text = "Search By Species"
        Me.Search_By_Species_Button.UseVisualStyleBackColor = True
        '
        'Search_By_Location_Button
        '
        Me.Search_By_Location_Button.Location = New System.Drawing.Point(832, 53)
        Me.Search_By_Location_Button.Name = "Search_By_Location_Button"
        Me.Search_By_Location_Button.Size = New System.Drawing.Size(108, 23)
        Me.Search_By_Location_Button.TabIndex = 40
        Me.Search_By_Location_Button.Text = "Search By Location"
        Me.Search_By_Location_Button.UseVisualStyleBackColor = True
        '
        'Search_By_Season_Button
        '
        Me.Search_By_Season_Button.Location = New System.Drawing.Point(832, 79)
        Me.Search_By_Season_Button.Name = "Search_By_Season_Button"
        Me.Search_By_Season_Button.Size = New System.Drawing.Size(108, 23)
        Me.Search_By_Season_Button.TabIndex = 41
        Me.Search_By_Season_Button.Text = "Search By Season"
        Me.Search_By_Season_Button.UseVisualStyleBackColor = True
        '
        'Search_Location_Button
        '
        Me.Search_Location_Button.Location = New System.Drawing.Point(652, 12)
        Me.Search_Location_Button.Name = "Search_Location_Button"
        Me.Search_Location_Button.Size = New System.Drawing.Size(75, 37)
        Me.Search_Location_Button.TabIndex = 42
        Me.Search_Location_Button.Text = "Search Location"
        Me.Search_Location_Button.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(380, 12)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(75, 37)
        Me.Back_Button.TabIndex = 43
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Knowledge_Base_Finds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(1028, 574)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Search_Location_Button)
        Me.Controls.Add(Me.Search_By_Season_Button)
        Me.Controls.Add(Me.Search_By_Location_Button)
        Me.Controls.Add(Me.Search_By_Species_Button)
        Me.Controls.Add(Me.Search_By_User_Button)
        Me.Controls.Add(Me.Search_By_Date_Button)
        Me.Controls.Add(Me.User_ID_Button)
        Me.Controls.Add(Me.User_Criteria_Input)
        Me.Controls.Add(Me.Season_Criteria_Input)
        Me.Controls.Add(Me.Date_Criteria_Input)
        Me.Controls.Add(Me.Species_Criterial_Input)
        Me.Controls.Add(Me.Location_Criteria_Input)
        Me.Controls.Add(Me.Location_ID_Button)
        Me.Controls.Add(Me.Species_ID_Button)
        Me.Controls.Add(Me.Find_Search_Results)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Knowledge_Base_Finds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Findings: Search Finds"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_Species_LinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Find_Search_Results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents User_Species_LinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents User_Species_LinkTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.User_Species_LinkTableAdapter
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents Find_Search_Results As System.Windows.Forms.DataGridView
    Friend WithEvents Location_ID_Button As System.Windows.Forms.Button
    Friend WithEvents Species_ID_Button As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Location_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents Species_Criterial_Input As System.Windows.Forms.TextBox
    Friend WithEvents Date_Criteria_Input As System.Windows.Forms.DateTimePicker
    Friend WithEvents Season_Criteria_Input As System.Windows.Forms.ComboBox
    Friend WithEvents User_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents User_ID_Button As System.Windows.Forms.Button
    Friend WithEvents Search_By_Date_Button As System.Windows.Forms.Button
    Friend WithEvents Search_By_User_Button As System.Windows.Forms.Button
    Friend WithEvents Search_By_Species_Button As System.Windows.Forms.Button
    Friend WithEvents Search_By_Location_Button As System.Windows.Forms.Button
    Friend WithEvents Search_By_Season_Button As System.Windows.Forms.Button
    Friend WithEvents Search_Location_Button As System.Windows.Forms.Button
    Friend WithEvents Back_Button As System.Windows.Forms.Button
End Class
