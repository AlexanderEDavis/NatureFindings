<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Location
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
        Dim Location_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Location_OwnerLabel As System.Windows.Forms.Label
        Dim Opening_TimesLabel As System.Windows.Forms.Label
        Dim Contact_DetailsLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim Entry_PriceLabel As System.Windows.Forms.Label
        Dim Opening_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Location))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.My_Account_Button = New System.Windows.Forms.Button()
        Me.Welcome_Screen_Button = New System.Windows.Forms.Button()
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.LocationTableAdapter()
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.LocationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.LocationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Location_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Location_OwnerTextBox = New System.Windows.Forms.TextBox()
        Me.Opening_TimesTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.Entry_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Opening_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Location_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Location_OwnerLabel = New System.Windows.Forms.Label()
        Opening_TimesLabel = New System.Windows.Forms.Label()
        Contact_DetailsLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        Entry_PriceLabel = New System.Windows.Forms.Label()
        Opening_DateLabel = New System.Windows.Forms.Label()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LocationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Location_NameLabel
        '
        Location_NameLabel.AutoSize = True
        Location_NameLabel.Location = New System.Drawing.Point(12, 74)
        Location_NameLabel.Name = "Location_NameLabel"
        Location_NameLabel.Size = New System.Drawing.Size(82, 13)
        Location_NameLabel.TabIndex = 41
        Location_NameLabel.Text = "Location Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 100)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 42
        AddressLabel.Text = "Address:"
        '
        'Location_OwnerLabel
        '
        Location_OwnerLabel.AutoSize = True
        Location_OwnerLabel.Location = New System.Drawing.Point(12, 126)
        Location_OwnerLabel.Name = "Location_OwnerLabel"
        Location_OwnerLabel.Size = New System.Drawing.Size(85, 13)
        Location_OwnerLabel.TabIndex = 43
        Location_OwnerLabel.Text = "Location Owner:"
        '
        'Opening_TimesLabel
        '
        Opening_TimesLabel.AutoSize = True
        Opening_TimesLabel.Location = New System.Drawing.Point(12, 153)
        Opening_TimesLabel.Name = "Opening_TimesLabel"
        Opening_TimesLabel.Size = New System.Drawing.Size(81, 13)
        Opening_TimesLabel.TabIndex = 44
        Opening_TimesLabel.Text = "Opening Times:"
        '
        'Contact_DetailsLabel
        '
        Contact_DetailsLabel.AutoSize = True
        Contact_DetailsLabel.Location = New System.Drawing.Point(12, 179)
        Contact_DetailsLabel.Name = "Contact_DetailsLabel"
        Contact_DetailsLabel.Size = New System.Drawing.Size(82, 13)
        Contact_DetailsLabel.TabIndex = 45
        Contact_DetailsLabel.Text = "Contact Details:"
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Location = New System.Drawing.Point(12, 205)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        WebsiteLabel.TabIndex = 46
        WebsiteLabel.Text = "Website:"
        '
        'Entry_PriceLabel
        '
        Entry_PriceLabel.AutoSize = True
        Entry_PriceLabel.Location = New System.Drawing.Point(12, 231)
        Entry_PriceLabel.Name = "Entry_PriceLabel"
        Entry_PriceLabel.Size = New System.Drawing.Size(61, 13)
        Entry_PriceLabel.TabIndex = 47
        Entry_PriceLabel.Text = "Entry Price:"
        '
        'Opening_DateLabel
        '
        Opening_DateLabel.AutoSize = True
        Opening_DateLabel.Location = New System.Drawing.Point(12, 260)
        Opening_DateLabel.Name = "Opening_DateLabel"
        Opening_DateLabel.Size = New System.Drawing.Size(76, 13)
        Opening_DateLabel.TabIndex = 48
        Opening_DateLabel.Text = "Opening Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "New Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nature Findings"
        '
        'My_Account_Button
        '
        Me.My_Account_Button.Location = New System.Drawing.Point(245, 28)
        Me.My_Account_Button.Name = "My_Account_Button"
        Me.My_Account_Button.Size = New System.Drawing.Size(75, 37)
        Me.My_Account_Button.TabIndex = 37
        Me.My_Account_Button.Text = "My Account"
        Me.My_Account_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(61, 28)
        Me.Welcome_Screen_Button.Name = "Welcome_Screen_Button"
        Me.Welcome_Screen_Button.Size = New System.Drawing.Size(75, 37)
        Me.Welcome_Screen_Button.TabIndex = 36
        Me.Welcome_Screen_Button.Text = "Welcome Screen"
        Me.Welcome_Screen_Button.UseVisualStyleBackColor = True
        '
        'Nature_Findings_Database
        '
        Me.Nature_Findings_Database.DataSetName = "Nature_Findings_Database"
        Me.Nature_Findings_Database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataMember = "Location"
        Me.LocationBindingSource.DataSource = Me.Nature_Findings_Database
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
        'LocationBindingNavigator
        '
        Me.LocationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LocationBindingNavigator.BindingSource = Me.LocationBindingSource
        Me.LocationBindingNavigator.CountItem = Nothing
        Me.LocationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LocationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LocationBindingNavigatorSaveItem})
        Me.LocationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LocationBindingNavigator.MoveFirstItem = Nothing
        Me.LocationBindingNavigator.MoveLastItem = Nothing
        Me.LocationBindingNavigator.MoveNextItem = Nothing
        Me.LocationBindingNavigator.MovePreviousItem = Nothing
        Me.LocationBindingNavigator.Name = "LocationBindingNavigator"
        Me.LocationBindingNavigator.PositionItem = Nothing
        Me.LocationBindingNavigator.Size = New System.Drawing.Size(380, 25)
        Me.LocationBindingNavigator.TabIndex = 41
        Me.LocationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'LocationBindingNavigatorSaveItem
        '
        Me.LocationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LocationBindingNavigatorSaveItem.Image = CType(resources.GetObject("LocationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LocationBindingNavigatorSaveItem.Name = "LocationBindingNavigatorSaveItem"
        Me.LocationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LocationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Location_NameTextBox
        '
        Me.Location_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocationBindingSource, "Location_Name", True))
        Me.Location_NameTextBox.Location = New System.Drawing.Point(100, 71)
        Me.Location_NameTextBox.Name = "Location_NameTextBox"
        Me.Location_NameTextBox.Size = New System.Drawing.Size(268, 20)
        Me.Location_NameTextBox.TabIndex = 42
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocationBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(100, 97)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(268, 20)
        Me.AddressTextBox.TabIndex = 43
        '
        'Location_OwnerTextBox
        '
        Me.Location_OwnerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocationBindingSource, "Location_Owner", True))
        Me.Location_OwnerTextBox.Location = New System.Drawing.Point(100, 123)
        Me.Location_OwnerTextBox.Name = "Location_OwnerTextBox"
        Me.Location_OwnerTextBox.Size = New System.Drawing.Size(268, 20)
        Me.Location_OwnerTextBox.TabIndex = 44
        '
        'Opening_TimesTextBox
        '
        Me.Opening_TimesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocationBindingSource, "Opening_Times", True))
        Me.Opening_TimesTextBox.Location = New System.Drawing.Point(100, 150)
        Me.Opening_TimesTextBox.Name = "Opening_TimesTextBox"
        Me.Opening_TimesTextBox.Size = New System.Drawing.Size(268, 20)
        Me.Opening_TimesTextBox.TabIndex = 45
        '
        'Contact_DetailsTextBox
        '
        Me.Contact_DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocationBindingSource, "Contact_Details", True))
        Me.Contact_DetailsTextBox.Location = New System.Drawing.Point(100, 176)
        Me.Contact_DetailsTextBox.Name = "Contact_DetailsTextBox"
        Me.Contact_DetailsTextBox.Size = New System.Drawing.Size(268, 20)
        Me.Contact_DetailsTextBox.TabIndex = 46
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocationBindingSource, "Website", True))
        Me.WebsiteTextBox.Location = New System.Drawing.Point(100, 202)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(268, 20)
        Me.WebsiteTextBox.TabIndex = 47
        '
        'Entry_PriceTextBox
        '
        Me.Entry_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocationBindingSource, "Entry_Price", True))
        Me.Entry_PriceTextBox.Location = New System.Drawing.Point(100, 228)
        Me.Entry_PriceTextBox.Name = "Entry_PriceTextBox"
        Me.Entry_PriceTextBox.Size = New System.Drawing.Size(268, 20)
        Me.Entry_PriceTextBox.TabIndex = 48
        '
        'Opening_DateDateTimePicker
        '
        Me.Opening_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LocationBindingSource, "Opening_Date", True))
        Me.Opening_DateDateTimePicker.Location = New System.Drawing.Point(100, 254)
        Me.Opening_DateDateTimePicker.Name = "Opening_DateDateTimePicker"
        Me.Opening_DateDateTimePicker.Size = New System.Drawing.Size(268, 20)
        Me.Opening_DateDateTimePicker.TabIndex = 49
        '
        'New_Location
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(380, 289)
        Me.Controls.Add(Opening_DateLabel)
        Me.Controls.Add(Me.Opening_DateDateTimePicker)
        Me.Controls.Add(Entry_PriceLabel)
        Me.Controls.Add(Me.Entry_PriceTextBox)
        Me.Controls.Add(WebsiteLabel)
        Me.Controls.Add(Me.WebsiteTextBox)
        Me.Controls.Add(Contact_DetailsLabel)
        Me.Controls.Add(Me.Contact_DetailsTextBox)
        Me.Controls.Add(Opening_TimesLabel)
        Me.Controls.Add(Me.Opening_TimesTextBox)
        Me.Controls.Add(Location_OwnerLabel)
        Me.Controls.Add(Me.Location_OwnerTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Location_NameLabel)
        Me.Controls.Add(Me.Location_NameTextBox)
        Me.Controls.Add(Me.LocationBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.Name = "New_Location"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Findings: New Loaction"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LocationBindingNavigator.ResumeLayout(False)
        Me.LocationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents LocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.LocationTableAdapter
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents LocationBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Location_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Location_OwnerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Opening_TimesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contact_DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Entry_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Opening_DateDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
