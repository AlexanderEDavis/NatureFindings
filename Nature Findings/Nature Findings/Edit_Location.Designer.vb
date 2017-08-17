<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Location
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Location))
        Me.Welcome_Screen_Button = New System.Windows.Forms.Button()
        Me.My_Account_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.LocationTableAdapter()
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.LocationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.LocationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LocationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LocationBindingNavigator.SuspendLayout()
        CType(Me.LocationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(336, 12)
        Me.Welcome_Screen_Button.Name = "Welcome_Screen_Button"
        Me.Welcome_Screen_Button.Size = New System.Drawing.Size(75, 37)
        Me.Welcome_Screen_Button.TabIndex = 0
        Me.Welcome_Screen_Button.Text = "Welcome Screen"
        Me.Welcome_Screen_Button.UseVisualStyleBackColor = True
        '
        'My_Account_Button
        '
        Me.My_Account_Button.Location = New System.Drawing.Point(534, 12)
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
        Me.Label1.Location = New System.Drawing.Point(417, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nature Findings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Edit Location"
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
        Me.LocationBindingNavigator.AddNewItem = Nothing
        Me.LocationBindingNavigator.BindingSource = Me.LocationBindingSource
        Me.LocationBindingNavigator.CountItem = Nothing
        Me.LocationBindingNavigator.DeleteItem = Nothing
        Me.LocationBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LocationBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.LocationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocationBindingNavigatorSaveItem})
        Me.LocationBindingNavigator.Location = New System.Drawing.Point(0, 418)
        Me.LocationBindingNavigator.MoveFirstItem = Nothing
        Me.LocationBindingNavigator.MoveLastItem = Nothing
        Me.LocationBindingNavigator.MoveNextItem = Nothing
        Me.LocationBindingNavigator.MovePreviousItem = Nothing
        Me.LocationBindingNavigator.Name = "LocationBindingNavigator"
        Me.LocationBindingNavigator.PositionItem = Nothing
        Me.LocationBindingNavigator.Size = New System.Drawing.Size(944, 25)
        Me.LocationBindingNavigator.TabIndex = 4
        Me.LocationBindingNavigator.Text = "BindingNavigator1"
        '
        'LocationBindingNavigatorSaveItem
        '
        Me.LocationBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LocationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LocationBindingNavigatorSaveItem.Image = CType(resources.GetObject("LocationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LocationBindingNavigatorSaveItem.Name = "LocationBindingNavigatorSaveItem"
        Me.LocationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LocationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LocationDataGridView
        '
        Me.LocationDataGridView.AllowUserToAddRows = False
        Me.LocationDataGridView.AutoGenerateColumns = False
        Me.LocationDataGridView.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.LocationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LocationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.LocationDataGridView.DataSource = Me.LocationBindingSource
        Me.LocationDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LocationDataGridView.GridColor = System.Drawing.Color.SteelBlue
        Me.LocationDataGridView.Location = New System.Drawing.Point(0, 55)
        Me.LocationDataGridView.Name = "LocationDataGridView"
        Me.LocationDataGridView.Size = New System.Drawing.Size(944, 363)
        Me.LocationDataGridView.TabIndex = 5
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
        'Edit_Location
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(944, 443)
        Me.Controls.Add(Me.LocationDataGridView)
        Me.Controls.Add(Me.LocationBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.Name = "Edit_Location"
        Me.Text = "Nature Findings: Edit Location"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LocationBindingNavigator.ResumeLayout(False)
        Me.LocationBindingNavigator.PerformLayout()
        CType(Me.LocationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents LocationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.LocationTableAdapter
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents LocationBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents LocationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LocationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
