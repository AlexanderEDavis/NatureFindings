<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Species_IDs
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
        Me.SpeciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpeciesTableAdapter = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.SpeciesTableAdapter()
        Me.TableAdapterManager = New Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager()
        Me.Species_ID_Table = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Species_ID_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Species_ID_Table
        '
        Me.Species_ID_Table.AllowUserToAddRows = False
        Me.Species_ID_Table.AllowUserToDeleteRows = False
        Me.Species_ID_Table.AutoGenerateColumns = False
        Me.Species_ID_Table.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.Species_ID_Table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Species_ID_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Species_ID_Table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Species_ID_Table.DataSource = Me.SpeciesBindingSource
        Me.Species_ID_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Species_ID_Table.GridColor = System.Drawing.Color.SteelBlue
        Me.Species_ID_Table.Location = New System.Drawing.Point(0, 0)
        Me.Species_ID_Table.Name = "Species_ID_Table"
        Me.Species_ID_Table.ReadOnly = True
        Me.Species_ID_Table.Size = New System.Drawing.Size(249, 284)
        Me.Species_ID_Table.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Species_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Species ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Species_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Species Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Species_IDs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 284)
        Me.Controls.Add(Me.Species_ID_Table)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Species_IDs"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Species IDs"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Species_ID_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents SpeciesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpeciesTableAdapter As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.SpeciesTableAdapter
    Friend WithEvents TableAdapterManager As Nature_Findings_System.Nature_Findings_DatabaseTableAdapters.TableAdapterManager
    Friend WithEvents Species_ID_Table As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
