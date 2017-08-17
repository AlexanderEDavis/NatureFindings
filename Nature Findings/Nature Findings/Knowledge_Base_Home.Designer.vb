<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Knowledge_Base_Home
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
        Me.NatureFindingsDatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Search_Finds_Button = New System.Windows.Forms.Button()
        Me.Search_Location_Button = New System.Windows.Forms.Button()
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NatureFindingsDatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Search"
        '
        'My_Account_Button
        '
        Me.My_Account_Button.Location = New System.Drawing.Point(197, 12)
        Me.My_Account_Button.Name = "My_Account_Button"
        Me.My_Account_Button.Size = New System.Drawing.Size(75, 37)
        Me.My_Account_Button.TabIndex = 21
        Me.My_Account_Button.Text = "My Account"
        Me.My_Account_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Screen_Button
        '
        Me.Welcome_Screen_Button.Location = New System.Drawing.Point(12, 12)
        Me.Welcome_Screen_Button.Name = "Welcome_Screen_Button"
        Me.Welcome_Screen_Button.Size = New System.Drawing.Size(75, 37)
        Me.Welcome_Screen_Button.TabIndex = 20
        Me.Welcome_Screen_Button.Text = "Welcome Screen"
        Me.Welcome_Screen_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nature Findings"
        '
        'Nature_Findings_Database
        '
        Me.Nature_Findings_Database.DataSetName = "Nature_Findings_Database"
        Me.Nature_Findings_Database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NatureFindingsDatabaseBindingSource
        '
        Me.NatureFindingsDatabaseBindingSource.DataSource = Me.Nature_Findings_Database
        Me.NatureFindingsDatabaseBindingSource.Position = 0
        '
        'Search_Finds_Button
        '
        Me.Search_Finds_Button.Location = New System.Drawing.Point(145, 55)
        Me.Search_Finds_Button.Name = "Search_Finds_Button"
        Me.Search_Finds_Button.Size = New System.Drawing.Size(75, 37)
        Me.Search_Finds_Button.TabIndex = 27
        Me.Search_Finds_Button.Text = "Search Finds"
        Me.Search_Finds_Button.UseVisualStyleBackColor = True
        '
        'Search_Location_Button
        '
        Me.Search_Location_Button.Location = New System.Drawing.Point(64, 55)
        Me.Search_Location_Button.Name = "Search_Location_Button"
        Me.Search_Location_Button.Size = New System.Drawing.Size(75, 37)
        Me.Search_Location_Button.TabIndex = 26
        Me.Search_Location_Button.Text = "Search Location"
        Me.Search_Location_Button.UseVisualStyleBackColor = True
        '
        'Knowledge_Base_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(284, 96)
        Me.Controls.Add(Me.Search_Finds_Button)
        Me.Controls.Add(Me.Search_Location_Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.Welcome_Screen_Button)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Knowledge_Base_Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Findings: Search Home"
        CType(Me.Nature_Findings_Database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NatureFindingsDatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Screen_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nature_Findings_Database As Nature_Findings_System.Nature_Findings_Database
    Friend WithEvents NatureFindingsDatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Search_Finds_Button As System.Windows.Forms.Button
    Friend WithEvents Search_Location_Button As System.Windows.Forms.Button
End Class
