<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Species
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
        Dim Species_NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Species))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.My_Account_Button = New System.Windows.Forms.Button()
        Me.Welcome_Screen_Button = New System.Windows.Forms.Button()
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.SpeciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpeciesTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.SpeciesTableAdapter()
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.SpeciesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SpeciesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Species_Name_Input = New System.Windows.Forms.TextBox()
        Species_NameLabel = New System.Windows.Forms.Label()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeciesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpeciesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Species_NameLabel
        '
        Species_NameLabel.AutoSize = True
        Species_NameLabel.Location = New System.Drawing.Point(54, 58)
        Species_NameLabel.Name = "Species_NameLabel"
        Species_NameLabel.Size = New System.Drawing.Size(79, 13)
        Species_NameLabel.TabIndex = 9
        Species_NameLabel.Text = "Species Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "New Species"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nature Findings"
        '
        'My_Account_Button
        '
        Me.My_Account_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.My_Account_Button.Location = New System.Drawing.Point(197, 12)
        Me.My_Account_Button.Name = "My_Account_Button"
        Me.My_Account_Button.Size = New System.Drawing.Size(75, 37)
        Me.My_Account_Button.TabIndex = 6
        Me.My_Account_Button.Text = "My Account"
        Me.My_Account_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(12, 12)
        Me.Welcome_Screen_Button.Name = "Welcome_Screen_Button"
        Me.Welcome_Screen_Button.Size = New System.Drawing.Size(75, 37)
        Me.Welcome_Screen_Button.TabIndex = 5
        Me.Welcome_Screen_Button.Text = "Welcome Screen"
        Me.Welcome_Screen_Button.UseVisualStyleBackColor = True
        '
        'Nature_Findings_Database
        '
        Me.Nature_Findings_Database.DataSetName = "Nature_Findings_Database"
        Me.Nature_Findings_Database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpeciesBindingSource
        '
        Me.SpeciesBindingSource.DataMember = "Species"
        Me.SpeciesBindingSource.DataSource = Me.Nature_Findings_Database
        '
        'SpeciesTableAdapter
        '
        Me.SpeciesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.SpeciesTableAdapter = Me.SpeciesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_Species_LinkTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'SpeciesBindingNavigator
        '
        Me.SpeciesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SpeciesBindingNavigator.BindingSource = Me.SpeciesBindingSource
        Me.SpeciesBindingNavigator.CountItem = Nothing
        Me.SpeciesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SpeciesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SpeciesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SpeciesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeciesBindingNavigatorSaveItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorAddNewItem})
        Me.SpeciesBindingNavigator.Location = New System.Drawing.Point(0, 84)
        Me.SpeciesBindingNavigator.MoveFirstItem = Nothing
        Me.SpeciesBindingNavigator.MoveLastItem = Nothing
        Me.SpeciesBindingNavigator.MoveNextItem = Nothing
        Me.SpeciesBindingNavigator.MovePreviousItem = Nothing
        Me.SpeciesBindingNavigator.Name = "SpeciesBindingNavigator"
        Me.SpeciesBindingNavigator.PositionItem = Nothing
        Me.SpeciesBindingNavigator.Size = New System.Drawing.Size(292, 25)
        Me.SpeciesBindingNavigator.TabIndex = 9
        Me.SpeciesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'SpeciesBindingNavigatorSaveItem
        '
        Me.SpeciesBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SpeciesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SpeciesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SpeciesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SpeciesBindingNavigatorSaveItem.Name = "SpeciesBindingNavigatorSaveItem"
        Me.SpeciesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SpeciesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Species_Name_Input
        '
        Me.Species_Name_Input.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpeciesBindingSource, "Species_Name", True))
        Me.Species_Name_Input.Location = New System.Drawing.Point(139, 55)
        Me.Species_Name_Input.Name = "Species_Name_Input"
        Me.Species_Name_Input.Size = New System.Drawing.Size(100, 20)
        Me.Species_Name_Input.TabIndex = 10
        '
        'New_Species
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.Welcome_Screen_Button
        Me.ClientSize = New System.Drawing.Size(292, 109)
        Me.Controls.Add(Species_NameLabel)
        Me.Controls.Add(Me.Species_Name_Input)
        Me.Controls.Add(Me.SpeciesBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "New_Species"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nature Findings: New Species"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeciesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpeciesBindingNavigator.ResumeLayout(False)
        Me.SpeciesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents SpeciesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpeciesTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.SpeciesTableAdapter
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents SpeciesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SpeciesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Species_Name_Input As System.Windows.Forms.TextBox
End Class
