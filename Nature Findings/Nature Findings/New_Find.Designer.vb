<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Find
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
        Dim Species_IDLabel As System.Windows.Forms.Label
        Dim Location_IDLabel As System.Windows.Forms.Label
        Dim Additional_CommentsLabel As System.Windows.Forms.Label
        Dim SeasonLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim User_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Find))
        Me.Welcome_Screen_Button = New System.Windows.Forms.Button()
        Me.My_Account_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.User_Species_LinkTableAdapter1 = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.User_Species_LinkTableAdapter()
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.User_Species_LinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.User_Species_LinkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.User_Species_LinkBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Species_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Location_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Additional_CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.SeasonComboBox = New System.Windows.Forms.ComboBox()
        Me.Species_ID_Button = New System.Windows.Forms.Button()
        Me.Location_ID_Button = New System.Windows.Forms.Button()
        Me.User_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Sight_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Species_IDLabel = New System.Windows.Forms.Label()
        Location_IDLabel = New System.Windows.Forms.Label()
        Additional_CommentsLabel = New System.Windows.Forms.Label()
        SeasonLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        User_IDLabel = New System.Windows.Forms.Label()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_Species_LinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_Species_LinkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.User_Species_LinkBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Species_IDLabel
        '
        Species_IDLabel.AutoSize = True
        Species_IDLabel.Location = New System.Drawing.Point(12, 123)
        Species_IDLabel.Name = "Species_IDLabel"
        Species_IDLabel.Size = New System.Drawing.Size(62, 13)
        Species_IDLabel.TabIndex = 17
        Species_IDLabel.Text = "Species ID:"
        '
        'Location_IDLabel
        '
        Location_IDLabel.AutoSize = True
        Location_IDLabel.Location = New System.Drawing.Point(9, 149)
        Location_IDLabel.Name = "Location_IDLabel"
        Location_IDLabel.Size = New System.Drawing.Size(65, 13)
        Location_IDLabel.TabIndex = 18
        Location_IDLabel.Text = "Location ID:"
        '
        'Additional_CommentsLabel
        '
        Additional_CommentsLabel.AutoSize = True
        Additional_CommentsLabel.Location = New System.Drawing.Point(9, 205)
        Additional_CommentsLabel.Name = "Additional_CommentsLabel"
        Additional_CommentsLabel.Size = New System.Drawing.Size(108, 13)
        Additional_CommentsLabel.TabIndex = 20
        Additional_CommentsLabel.Text = "Additional Comments:"
        '
        'SeasonLabel
        '
        SeasonLabel.AutoSize = True
        SeasonLabel.Location = New System.Drawing.Point(28, 175)
        SeasonLabel.Name = "SeasonLabel"
        SeasonLabel.Size = New System.Drawing.Size(46, 13)
        SeasonLabel.TabIndex = 21
        SeasonLabel.Text = "Season:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(41, 72)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 16
        DateLabel.Text = "Date:"
        '
        'User_IDLabel
        '
        User_IDLabel.AutoSize = True
        User_IDLabel.Location = New System.Drawing.Point(28, 97)
        User_IDLabel.Name = "User_IDLabel"
        User_IDLabel.Size = New System.Drawing.Size(46, 13)
        User_IDLabel.TabIndex = 24
        User_IDLabel.Text = "User ID:"
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(12, 25)
        Me.Welcome_Screen_Button.Name = "Welcome_Screen_Button"
        Me.Welcome_Screen_Button.Size = New System.Drawing.Size(75, 37)
        Me.Welcome_Screen_Button.TabIndex = 0
        Me.Welcome_Screen_Button.Text = "Welcome Screen"
        Me.Welcome_Screen_Button.UseVisualStyleBackColor = True
        '
        'My_Account_Button
        '
        Me.My_Account_Button.Location = New System.Drawing.Point(210, 25)
        Me.My_Account_Button.Name = "My_Account_Button"
        Me.My_Account_Button.Size = New System.Drawing.Size(75, 37)
        Me.My_Account_Button.TabIndex = 1
        Me.My_Account_Button.Text = "My Account"
        Me.My_Account_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nature Findings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Find"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(197, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'User_Species_LinkTableAdapter1
        '
        Me.User_Species_LinkTableAdapter1.ClearBeforeFill = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.SpeciesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_Species_LinkTableAdapter = Me.User_Species_LinkTableAdapter1
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'User_Species_LinkBindingNavigator
        '
        Me.User_Species_LinkBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.User_Species_LinkBindingNavigator.BindingSource = Me.User_Species_LinkBindingSource
        Me.User_Species_LinkBindingNavigator.CountItem = Nothing
        Me.User_Species_LinkBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.User_Species_LinkBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.User_Species_LinkBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.User_Species_LinkBindingNavigatorSaveItem})
        Me.User_Species_LinkBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.User_Species_LinkBindingNavigator.MoveFirstItem = Nothing
        Me.User_Species_LinkBindingNavigator.MoveLastItem = Nothing
        Me.User_Species_LinkBindingNavigator.MoveNextItem = Nothing
        Me.User_Species_LinkBindingNavigator.MovePreviousItem = Nothing
        Me.User_Species_LinkBindingNavigator.Name = "User_Species_LinkBindingNavigator"
        Me.User_Species_LinkBindingNavigator.PositionItem = Nothing
        Me.User_Species_LinkBindingNavigator.Size = New System.Drawing.Size(305, 25)
        Me.User_Species_LinkBindingNavigator.TabIndex = 15
        Me.User_Species_LinkBindingNavigator.Text = "BindingNavigator1"
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
        'User_Species_LinkBindingNavigatorSaveItem
        '
        Me.User_Species_LinkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.User_Species_LinkBindingNavigatorSaveItem.Image = CType(resources.GetObject("User_Species_LinkBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.User_Species_LinkBindingNavigatorSaveItem.Name = "User_Species_LinkBindingNavigatorSaveItem"
        Me.User_Species_LinkBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.User_Species_LinkBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Species_IDTextBox
        '
        Me.Species_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_Species_LinkBindingSource, "Species_ID", True))
        Me.Species_IDTextBox.Location = New System.Drawing.Point(80, 120)
        Me.Species_IDTextBox.Name = "Species_IDTextBox"
        Me.Species_IDTextBox.Size = New System.Drawing.Size(124, 20)
        Me.Species_IDTextBox.TabIndex = 18
        '
        'Location_IDTextBox
        '
        Me.Location_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_Species_LinkBindingSource, "Location_ID", True))
        Me.Location_IDTextBox.Location = New System.Drawing.Point(80, 146)
        Me.Location_IDTextBox.Name = "Location_IDTextBox"
        Me.Location_IDTextBox.Size = New System.Drawing.Size(124, 20)
        Me.Location_IDTextBox.TabIndex = 19
        '
        'Additional_CommentsTextBox
        '
        Me.Additional_CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_Species_LinkBindingSource, "Additional_Comments", True))
        Me.Additional_CommentsTextBox.Location = New System.Drawing.Point(12, 221)
        Me.Additional_CommentsTextBox.Multiline = True
        Me.Additional_CommentsTextBox.Name = "Additional_CommentsTextBox"
        Me.Additional_CommentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Additional_CommentsTextBox.Size = New System.Drawing.Size(273, 60)
        Me.Additional_CommentsTextBox.TabIndex = 21
        '
        'SeasonComboBox
        '
        Me.SeasonComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_Species_LinkBindingSource, "Season", True))
        Me.SeasonComboBox.FormattingEnabled = True
        Me.SeasonComboBox.Items.AddRange(New Object() {"Spring", "Summer", "Autumn", "Winter"})
        Me.SeasonComboBox.Location = New System.Drawing.Point(80, 172)
        Me.SeasonComboBox.Name = "SeasonComboBox"
        Me.SeasonComboBox.Size = New System.Drawing.Size(205, 21)
        Me.SeasonComboBox.TabIndex = 22
        '
        'Species_ID_Button
        '
        Me.Species_ID_Button.Location = New System.Drawing.Point(210, 118)
        Me.Species_ID_Button.Name = "Species_ID_Button"
        Me.Species_ID_Button.Size = New System.Drawing.Size(75, 23)
        Me.Species_ID_Button.TabIndex = 23
        Me.Species_ID_Button.Text = "Species IDs"
        Me.Species_ID_Button.UseVisualStyleBackColor = True
        '
        'Location_ID_Button
        '
        Me.Location_ID_Button.Location = New System.Drawing.Point(210, 144)
        Me.Location_ID_Button.Name = "Location_ID_Button"
        Me.Location_ID_Button.Size = New System.Drawing.Size(75, 23)
        Me.Location_ID_Button.TabIndex = 24
        Me.Location_ID_Button.Text = "Location IDs"
        Me.Location_ID_Button.UseVisualStyleBackColor = True
        '
        'User_IDTextBox
        '
        Me.User_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_Species_LinkBindingSource, "User_ID", True))
        Me.User_IDTextBox.Location = New System.Drawing.Point(80, 94)
        Me.User_IDTextBox.Name = "User_IDTextBox"
        Me.User_IDTextBox.ReadOnly = True
        Me.User_IDTextBox.Size = New System.Drawing.Size(205, 20)
        Me.User_IDTextBox.TabIndex = 25
        '
        'Sight_DateDateTimePicker
        '
        Me.Sight_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.User_Species_LinkBindingSource, "Sight_Date", True))
        Me.Sight_DateDateTimePicker.Location = New System.Drawing.Point(80, 69)
        Me.Sight_DateDateTimePicker.Name = "Sight_DateDateTimePicker"
        Me.Sight_DateDateTimePicker.Size = New System.Drawing.Size(205, 20)
        Me.Sight_DateDateTimePicker.TabIndex = 26
        '
        'New_Find
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(305, 294)
        Me.Controls.Add(Me.Sight_DateDateTimePicker)
        Me.Controls.Add(User_IDLabel)
        Me.Controls.Add(Me.User_IDTextBox)
        Me.Controls.Add(Me.Location_ID_Button)
        Me.Controls.Add(Me.Species_ID_Button)
        Me.Controls.Add(SeasonLabel)
        Me.Controls.Add(Me.SeasonComboBox)
        Me.Controls.Add(Additional_CommentsLabel)
        Me.Controls.Add(Me.Additional_CommentsTextBox)
        Me.Controls.Add(Location_IDLabel)
        Me.Controls.Add(Me.Location_IDTextBox)
        Me.Controls.Add(Species_IDLabel)
        Me.Controls.Add(Me.Species_IDTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.User_Species_LinkBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.MaximizeBox = False
        Me.Name = "New_Find"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Findings: New Find"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_Species_LinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_Species_LinkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.User_Species_LinkBindingNavigator.ResumeLayout(False)
        Me.User_Species_LinkBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents User_Species_LinkTableAdapter1 As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.User_Species_LinkTableAdapter
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents User_Species_LinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents User_Species_LinkBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents User_Species_LinkBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Species_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Location_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Additional_CommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeasonComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Species_ID_Button As System.Windows.Forms.Button
    Friend WithEvents Location_ID_Button As System.Windows.Forms.Button
    Friend WithEvents User_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sight_DateDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
