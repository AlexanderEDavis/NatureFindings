<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Knowledge_Base_Locations
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
        Me.Search_By_Name_Button = New System.Windows.Forms.Button()
        Me.Name_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.Location_Search_Results = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.LocationTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.LocationTableAdapter()
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.Search_Finds_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Search_By_Date_Button = New System.Windows.Forms.Button()
        Me.Date_Criteria_Input = New System.Windows.Forms.DateTimePicker()
        Me.Search_By_Address_Button = New System.Windows.Forms.Button()
        Me.Address_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.Search_By_Owner_Button = New System.Windows.Forms.Button()
        Me.Owner_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.Opening_Times_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.Search_By_Opening_Time_Button = New System.Windows.Forms.Button()
        Me.Contact_Details_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.Search_By_Contact_Details_Button = New System.Windows.Forms.Button()
        Me.Website_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.Search_By_Website_Button = New System.Windows.Forms.Button()
        Me.Price_Criteria_Input = New System.Windows.Forms.TextBox()
        Me.Search_By_Entry_Price_Button = New System.Windows.Forms.Button()
        CType(Me.Location_Search_Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(414, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Location Search"
        '
        'My_Account_Button
        '
        Me.My_Account_Button.Location = New System.Drawing.Point(527, 12)
        Me.My_Account_Button.Name = "My_Account_Button"
        Me.My_Account_Button.Size = New System.Drawing.Size(75, 37)
        Me.My_Account_Button.TabIndex = 25
        Me.My_Account_Button.Text = "My Account"
        Me.My_Account_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(255, 12)
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
        Me.Label1.Location = New System.Drawing.Point(417, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nature Findings"
        '
        'Search_By_Name_Button
        '
        Me.Search_By_Name_Button.Location = New System.Drawing.Point(317, 57)
        Me.Search_By_Name_Button.Name = "Search_By_Name_Button"
        Me.Search_By_Name_Button.Size = New System.Drawing.Size(141, 23)
        Me.Search_By_Name_Button.TabIndex = 28
        Me.Search_By_Name_Button.Text = "Search By Location Name"
        Me.Search_By_Name_Button.UseVisualStyleBackColor = True
        '
        'Name_Criteria_Input
        '
        Me.Name_Criteria_Input.Location = New System.Drawing.Point(12, 58)
        Me.Name_Criteria_Input.Name = "Name_Criteria_Input"
        Me.Name_Criteria_Input.Size = New System.Drawing.Size(299, 20)
        Me.Name_Criteria_Input.TabIndex = 29
        '
        'Location_Search_Results
        '
        Me.Location_Search_Results.AllowUserToAddRows = False
        Me.Location_Search_Results.AllowUserToDeleteRows = False
        Me.Location_Search_Results.AutoGenerateColumns = False
        Me.Location_Search_Results.BackgroundColor = System.Drawing.Color.MediumPurple
        Me.Location_Search_Results.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Location_Search_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Location_Search_Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Location_Search_Results.DataSource = Me.LocationBindingSource
        Me.Location_Search_Results.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Location_Search_Results.GridColor = System.Drawing.Color.Purple
        Me.Location_Search_Results.Location = New System.Drawing.Point(0, 161)
        Me.Location_Search_Results.Name = "Location_Search_Results"
        Me.Location_Search_Results.ReadOnly = True
        Me.Location_Search_Results.Size = New System.Drawing.Size(953, 272)
        Me.Location_Search_Results.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Location_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Location_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Location_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Location_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Location_Owner"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Location_Owner"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Opening_Times"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Opening_Times"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Contact_Details"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contact_Details"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Website"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Website"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Entry_Price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Entry_Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Opening_Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Opening_Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.Nature_Findings_Database
        '
        'Nature_Findings_Database
        '
        Me.Nature_Findings_Database.DataSetName = "Nature_Findings_Database"
        Me.Nature_Findings_Database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationTableAdapter
        '
        Me.LocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LocationTableAdapter = Me.LocationTableAdapter
        Me.TableAdapterManager.SpeciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_Species_LinkTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Search_Finds_Button
        '
        Me.Search_Finds_Button.Location = New System.Drawing.Point(608, 12)
        Me.Search_Finds_Button.Name = "Search_Finds_Button"
        Me.Search_Finds_Button.Size = New System.Drawing.Size(75, 37)
        Me.Search_Finds_Button.TabIndex = 32
        Me.Search_Finds_Button.Text = "Search Finds"
        Me.Search_Finds_Button.UseVisualStyleBackColor = True
        '
        'Back_Button
        '
        Me.Back_Button.Location = New System.Drawing.Point(336, 12)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(75, 37)
        Me.Back_Button.TabIndex = 44
        Me.Back_Button.Text = "Back"
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Search_By_Date_Button
        '
        Me.Search_By_Date_Button.Location = New System.Drawing.Point(768, 132)
        Me.Search_By_Date_Button.Name = "Search_By_Date_Button"
        Me.Search_By_Date_Button.Size = New System.Drawing.Size(141, 23)
        Me.Search_By_Date_Button.TabIndex = 53
        Me.Search_By_Date_Button.Text = "Search By Date"
        Me.Search_By_Date_Button.UseVisualStyleBackColor = True
        '
        'Date_Criteria_Input
        '
        Me.Date_Criteria_Input.Location = New System.Drawing.Point(464, 133)
        Me.Date_Criteria_Input.Name = "Date_Criteria_Input"
        Me.Date_Criteria_Input.Size = New System.Drawing.Size(299, 20)
        Me.Date_Criteria_Input.TabIndex = 49
        '
        'Search_By_Address_Button
        '
        Me.Search_By_Address_Button.Location = New System.Drawing.Point(317, 82)
        Me.Search_By_Address_Button.Name = "Search_By_Address_Button"
        Me.Search_By_Address_Button.Size = New System.Drawing.Size(141, 23)
        Me.Search_By_Address_Button.TabIndex = 54
        Me.Search_By_Address_Button.Text = "Search By Address"
        Me.Search_By_Address_Button.UseVisualStyleBackColor = True
        '
        'Address_Criteria_Input
        '
        Me.Address_Criteria_Input.Location = New System.Drawing.Point(12, 83)
        Me.Address_Criteria_Input.Name = "Address_Criteria_Input"
        Me.Address_Criteria_Input.Size = New System.Drawing.Size(299, 20)
        Me.Address_Criteria_Input.TabIndex = 55
        '
        'Search_By_Owner_Button
        '
        Me.Search_By_Owner_Button.Location = New System.Drawing.Point(317, 107)
        Me.Search_By_Owner_Button.Name = "Search_By_Owner_Button"
        Me.Search_By_Owner_Button.Size = New System.Drawing.Size(141, 23)
        Me.Search_By_Owner_Button.TabIndex = 56
        Me.Search_By_Owner_Button.Text = "Search By Owners"
        Me.Search_By_Owner_Button.UseVisualStyleBackColor = True
        '
        'Owner_Criteria_Input
        '
        Me.Owner_Criteria_Input.Location = New System.Drawing.Point(13, 108)
        Me.Owner_Criteria_Input.Name = "Owner_Criteria_Input"
        Me.Owner_Criteria_Input.Size = New System.Drawing.Size(298, 20)
        Me.Owner_Criteria_Input.TabIndex = 57
        '
        'Opening_Times_Criteria_Input
        '
        Me.Opening_Times_Criteria_Input.Location = New System.Drawing.Point(13, 133)
        Me.Opening_Times_Criteria_Input.Name = "Opening_Times_Criteria_Input"
        Me.Opening_Times_Criteria_Input.Size = New System.Drawing.Size(298, 20)
        Me.Opening_Times_Criteria_Input.TabIndex = 59
        '
        'Search_By_Opening_Time_Button
        '
        Me.Search_By_Opening_Time_Button.Location = New System.Drawing.Point(317, 132)
        Me.Search_By_Opening_Time_Button.Name = "Search_By_Opening_Time_Button"
        Me.Search_By_Opening_Time_Button.Size = New System.Drawing.Size(141, 23)
        Me.Search_By_Opening_Time_Button.TabIndex = 58
        Me.Search_By_Opening_Time_Button.Text = "Search By Opening Times"
        Me.Search_By_Opening_Time_Button.UseVisualStyleBackColor = True
        '
        'Contact_Details_Criteria_Input
        '
        Me.Contact_Details_Criteria_Input.Location = New System.Drawing.Point(464, 55)
        Me.Contact_Details_Criteria_Input.Name = "Contact_Details_Criteria_Input"
        Me.Contact_Details_Criteria_Input.Size = New System.Drawing.Size(298, 20)
        Me.Contact_Details_Criteria_Input.TabIndex = 61
        '
        'Search_By_Contact_Details_Button
        '
        Me.Search_By_Contact_Details_Button.Location = New System.Drawing.Point(768, 54)
        Me.Search_By_Contact_Details_Button.Name = "Search_By_Contact_Details_Button"
        Me.Search_By_Contact_Details_Button.Size = New System.Drawing.Size(141, 23)
        Me.Search_By_Contact_Details_Button.TabIndex = 60
        Me.Search_By_Contact_Details_Button.Text = "Search By Contact Details"
        Me.Search_By_Contact_Details_Button.UseVisualStyleBackColor = True
        '
        'Website_Criteria_Input
        '
        Me.Website_Criteria_Input.Location = New System.Drawing.Point(464, 81)
        Me.Website_Criteria_Input.Name = "Website_Criteria_Input"
        Me.Website_Criteria_Input.Size = New System.Drawing.Size(298, 20)
        Me.Website_Criteria_Input.TabIndex = 63
        '
        'Search_By_Website_Button
        '
        Me.Search_By_Website_Button.Location = New System.Drawing.Point(768, 80)
        Me.Search_By_Website_Button.Name = "Search_By_Website_Button"
        Me.Search_By_Website_Button.Size = New System.Drawing.Size(141, 23)
        Me.Search_By_Website_Button.TabIndex = 62
        Me.Search_By_Website_Button.Text = "Search By Website"
        Me.Search_By_Website_Button.UseVisualStyleBackColor = True
        '
        'Price_Criteria_Input
        '
        Me.Price_Criteria_Input.Location = New System.Drawing.Point(464, 107)
        Me.Price_Criteria_Input.Name = "Price_Criteria_Input"
        Me.Price_Criteria_Input.Size = New System.Drawing.Size(298, 20)
        Me.Price_Criteria_Input.TabIndex = 65
        '
        'Search_By_Entry_Price_Button
        '
        Me.Search_By_Entry_Price_Button.Location = New System.Drawing.Point(768, 106)
        Me.Search_By_Entry_Price_Button.Name = "Search_By_Entry_Price_Button"
        Me.Search_By_Entry_Price_Button.Size = New System.Drawing.Size(141, 23)
        Me.Search_By_Entry_Price_Button.TabIndex = 64
        Me.Search_By_Entry_Price_Button.Text = "Search By Entry Price"
        Me.Search_By_Entry_Price_Button.UseVisualStyleBackColor = True
        '
        'Knowledge_Base_Locations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(953, 433)
        Me.Controls.Add(Me.Price_Criteria_Input)
        Me.Controls.Add(Me.Search_By_Entry_Price_Button)
        Me.Controls.Add(Me.Website_Criteria_Input)
        Me.Controls.Add(Me.Search_By_Website_Button)
        Me.Controls.Add(Me.Contact_Details_Criteria_Input)
        Me.Controls.Add(Me.Search_By_Contact_Details_Button)
        Me.Controls.Add(Me.Opening_Times_Criteria_Input)
        Me.Controls.Add(Me.Search_By_Opening_Time_Button)
        Me.Controls.Add(Me.Owner_Criteria_Input)
        Me.Controls.Add(Me.Search_By_Owner_Button)
        Me.Controls.Add(Me.Address_Criteria_Input)
        Me.Controls.Add(Me.Search_By_Address_Button)
        Me.Controls.Add(Me.Search_By_Date_Button)
        Me.Controls.Add(Me.Date_Criteria_Input)
        Me.Controls.Add(Me.Back_Button)
        Me.Controls.Add(Me.Search_Finds_Button)
        Me.Controls.Add(Me.Location_Search_Results)
        Me.Controls.Add(Me.Name_Criteria_Input)
        Me.Controls.Add(Me.Search_By_Name_Button)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Knowledge_Base_Locations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Findings: Search Location"
        CType(Me.Location_Search_Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Search_By_Name_Button As System.Windows.Forms.Button
    Friend WithEvents Name_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents LocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.LocationTableAdapter
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents Location_Search_Results As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Search_Finds_Button As System.Windows.Forms.Button
    Friend WithEvents Back_Button As System.Windows.Forms.Button
    Friend WithEvents Search_By_Date_Button As System.Windows.Forms.Button
    Friend WithEvents Date_Criteria_Input As System.Windows.Forms.DateTimePicker
    Friend WithEvents Search_By_Address_Button As System.Windows.Forms.Button
    Friend WithEvents Address_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents Search_By_Owner_Button As System.Windows.Forms.Button
    Friend WithEvents Owner_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents Opening_Times_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents Search_By_Opening_Time_Button As System.Windows.Forms.Button
    Friend WithEvents Contact_Details_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents Search_By_Contact_Details_Button As System.Windows.Forms.Button
    Friend WithEvents Website_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents Search_By_Website_Button As System.Windows.Forms.Button
    Friend WithEvents Price_Criteria_Input As System.Windows.Forms.TextBox
    Friend WithEvents Search_By_Entry_Price_Button As System.Windows.Forms.Button
End Class
