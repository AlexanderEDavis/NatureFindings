<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_IDs
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
        Me.Nature_Findings_Database = New Nature_Findings_System.Nature_Findings_Database()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.User_IDs_Table = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contributor_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.About_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_IDs_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
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
        'User_IDs_Table
        '
        Me.User_IDs_Table.AllowUserToAddRows = False
        Me.User_IDs_Table.AllowUserToDeleteRows = False
        Me.User_IDs_Table.AutoGenerateColumns = False
        Me.User_IDs_Table.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.User_IDs_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.User_IDs_Table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Contributor_Name, Me.About_User})
        Me.User_IDs_Table.DataSource = Me.UsersBindingSource
        Me.User_IDs_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.User_IDs_Table.GridColor = System.Drawing.Color.SteelBlue
        Me.User_IDs_Table.Location = New System.Drawing.Point(0, 0)
        Me.User_IDs_Table.Name = "User_IDs_Table"
        Me.User_IDs_Table.ReadOnly = True
        Me.User_IDs_Table.Size = New System.Drawing.Size(463, 288)
        Me.User_IDs_Table.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "User ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Contributor_Name
        '
        Me.Contributor_Name.DataPropertyName = "Contributor Name"
        Me.Contributor_Name.HeaderText = "Contributor Name"
        Me.Contributor_Name.Name = "Contributor_Name"
        Me.Contributor_Name.ReadOnly = True
        '
        'About_User
        '
        Me.About_User.DataPropertyName = "About User"
        Me.About_User.HeaderText = "About User"
        Me.About_User.Name = "About_User"
        Me.About_User.ReadOnly = True
        '
        'User_IDs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 288)
        Me.Controls.Add(Me.User_IDs_Table)
        Me.Name = "User_IDs"
        Me.Text = "User IDs"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_IDs_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents User_IDs_Table As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contributor_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents About_User As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
