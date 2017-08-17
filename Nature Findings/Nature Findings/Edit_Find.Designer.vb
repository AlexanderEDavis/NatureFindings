<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Find
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Find))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.My_Account_Button = New System.Windows.Forms.Button()
        Me.Welcome_Screen_Button = New System.Windows.Forms.Button()
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.User_Species_LinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_Species_LinkTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.User_Species_LinkTableAdapter()
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.User_Species_LinkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.User_Species_LinkBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Finds = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_Species_LinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_Species_LinkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.User_Species_LinkBindingNavigator.SuspendLayout()
        CType(Me.Finds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Edit Find"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nature Findings"
        '
        'My_Account_Button
        '
        Me.My_Account_Button.Location = New System.Drawing.Point(392, 12)
        Me.My_Account_Button.Name = "My_Account_Button"
        Me.My_Account_Button.Size = New System.Drawing.Size(75, 37)
        Me.My_Account_Button.TabIndex = 16
        Me.My_Account_Button.Text = "My Account"
        Me.My_Account_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(207, 12)
        Me.Welcome_Screen_Button.Name = "Welcome_Screen_Button"
        Me.Welcome_Screen_Button.Size = New System.Drawing.Size(75, 37)
        Me.Welcome_Screen_Button.TabIndex = 15
        Me.Welcome_Screen_Button.Text = "Welcome Screen"
        Me.Welcome_Screen_Button.UseVisualStyleBackColor = True
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
        'User_Species_LinkBindingNavigator
        '
        Me.User_Species_LinkBindingNavigator.AddNewItem = Nothing
        Me.User_Species_LinkBindingNavigator.BindingSource = Me.User_Species_LinkBindingSource
        Me.User_Species_LinkBindingNavigator.CountItem = Nothing
        Me.User_Species_LinkBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.User_Species_LinkBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.User_Species_LinkBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.User_Species_LinkBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.User_Species_LinkBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem})
        Me.User_Species_LinkBindingNavigator.Location = New System.Drawing.Point(0, 354)
        Me.User_Species_LinkBindingNavigator.MoveFirstItem = Nothing
        Me.User_Species_LinkBindingNavigator.MoveLastItem = Nothing
        Me.User_Species_LinkBindingNavigator.MoveNextItem = Nothing
        Me.User_Species_LinkBindingNavigator.MovePreviousItem = Nothing
        Me.User_Species_LinkBindingNavigator.Name = "User_Species_LinkBindingNavigator"
        Me.User_Species_LinkBindingNavigator.PositionItem = Nothing
        Me.User_Species_LinkBindingNavigator.Size = New System.Drawing.Size(675, 25)
        Me.User_Species_LinkBindingNavigator.TabIndex = 20
        Me.User_Species_LinkBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'User_Species_LinkBindingNavigatorSaveItem
        '
        Me.User_Species_LinkBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.User_Species_LinkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.User_Species_LinkBindingNavigatorSaveItem.Image = CType(resources.GetObject("User_Species_LinkBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.User_Species_LinkBindingNavigatorSaveItem.Name = "User_Species_LinkBindingNavigatorSaveItem"
        Me.User_Species_LinkBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.User_Species_LinkBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Finds
        '
        Me.Finds.AutoGenerateColumns = False
        Me.Finds.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.Finds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Finds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Finds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8})
        Me.Finds.DataSource = Me.User_Species_LinkBindingSource
        Me.Finds.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Finds.GridColor = System.Drawing.Color.SteelBlue
        Me.Finds.Location = New System.Drawing.Point(0, 55)
        Me.Finds.Name = "Finds"
        Me.Finds.Size = New System.Drawing.Size(675, 299)
        Me.Finds.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Species_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Species_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "User_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "User_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Location_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Location_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Season"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Season"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Additional_Comments"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Additional_Comments"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Edit_Find
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(675, 379)
        Me.Controls.Add(Me.Finds)
        Me.Controls.Add(Me.User_Species_LinkBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Edit_Find"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Findings: Edit Find"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_Species_LinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_Species_LinkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.User_Species_LinkBindingNavigator.ResumeLayout(False)
        Me.User_Species_LinkBindingNavigator.PerformLayout()
        CType(Me.Finds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents User_Species_LinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents User_Species_LinkTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.User_Species_LinkTableAdapter
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents User_Species_LinkBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents User_Species_LinkBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Finds As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
