<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.New_Location_Button = New System.Windows.Forms.Button()
        Me.Edit_Location_Button = New System.Windows.Forms.Button()
        Me.New_Find_Button = New System.Windows.Forms.Button()
        Me.Edit_Find_Button = New System.Windows.Forms.Button()
        Me.Knowledge_Base_Button = New System.Windows.Forms.Button()
        Me.Welcome_Screen_Heading = New System.Windows.Forms.Label()
        Me.New_Species_Button = New System.Windows.Forms.Button()
        Me.My_Account_Button = New System.Windows.Forms.Button()
        Me.Welcome_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'New_Location_Button
        '
        Me.New_Location_Button.Location = New System.Drawing.Point(31, 108)
        Me.New_Location_Button.Name = "New_Location_Button"
        Me.New_Location_Button.Size = New System.Drawing.Size(75, 37)
        Me.New_Location_Button.TabIndex = 0
        Me.New_Location_Button.Text = "Add New Location"
        Me.New_Location_Button.UseVisualStyleBackColor = True
        '
        'Edit_Location_Button
        '
        Me.Edit_Location_Button.Location = New System.Drawing.Point(112, 108)
        Me.Edit_Location_Button.Name = "Edit_Location_Button"
        Me.Edit_Location_Button.Size = New System.Drawing.Size(75, 37)
        Me.Edit_Location_Button.TabIndex = 1
        Me.Edit_Location_Button.Text = "Edit Location"
        Me.Edit_Location_Button.UseVisualStyleBackColor = True
        '
        'New_Find_Button
        '
        Me.New_Find_Button.Location = New System.Drawing.Point(31, 151)
        Me.New_Find_Button.Name = "New_Find_Button"
        Me.New_Find_Button.Size = New System.Drawing.Size(75, 37)
        Me.New_Find_Button.TabIndex = 2
        Me.New_Find_Button.Text = "Add New Find"
        Me.New_Find_Button.UseVisualStyleBackColor = True
        '
        'Edit_Find_Button
        '
        Me.Edit_Find_Button.Location = New System.Drawing.Point(111, 151)
        Me.Edit_Find_Button.Name = "Edit_Find_Button"
        Me.Edit_Find_Button.Size = New System.Drawing.Size(75, 37)
        Me.Edit_Find_Button.TabIndex = 3
        Me.Edit_Find_Button.Text = "Edit Find"
        Me.Edit_Find_Button.UseVisualStyleBackColor = True
        '
        'Knowledge_Base_Button
        '
        Me.Knowledge_Base_Button.Location = New System.Drawing.Point(235, 65)
        Me.Knowledge_Base_Button.Name = "Knowledge_Base_Button"
        Me.Knowledge_Base_Button.Size = New System.Drawing.Size(75, 37)
        Me.Knowledge_Base_Button.TabIndex = 4
        Me.Knowledge_Base_Button.Text = "Knowledge Base"
        Me.Knowledge_Base_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Screen_Heading
        '
        Me.Welcome_Screen_Heading.AutoSize = True
        Me.Welcome_Screen_Heading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome_Screen_Heading.Location = New System.Drawing.Point(88, 9)
        Me.Welcome_Screen_Heading.Name = "Welcome_Screen_Heading"
        Me.Welcome_Screen_Heading.Size = New System.Drawing.Size(165, 26)
        Me.Welcome_Screen_Heading.TabIndex = 5
        Me.Welcome_Screen_Heading.Text = "Nature Findings"
        '
        'New_Species_Button
        '
        Me.New_Species_Button.Location = New System.Drawing.Point(72, 65)
        Me.New_Species_Button.Name = "New_Species_Button"
        Me.New_Species_Button.Size = New System.Drawing.Size(75, 37)
        Me.New_Species_Button.TabIndex = 6
        Me.New_Species_Button.Text = "Add New Species"
        Me.New_Species_Button.UseVisualStyleBackColor = True
        '
        'My_Account_Button
        '
        Me.My_Account_Button.Location = New System.Drawing.Point(253, 12)
        Me.My_Account_Button.Name = "My_Account_Button"
        Me.My_Account_Button.Size = New System.Drawing.Size(75, 37)
        Me.My_Account_Button.TabIndex = 7
        Me.My_Account_Button.Text = "My Account"
        Me.My_Account_Button.UseVisualStyleBackColor = True
        '
        'Welcome_Label
        '
        Me.Welcome_Label.AutoSize = True
        Me.Welcome_Label.Location = New System.Drawing.Point(13, 41)
        Me.Welcome_Label.Name = "Welcome_Label"
        Me.Welcome_Label.Size = New System.Drawing.Size(84, 13)
        Me.Welcome_Label.TabIndex = 8
        Me.Welcome_Label.Text = "Welcome_Label"
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(340, 200)
        Me.Controls.Add(Me.Welcome_Label)
        Me.Controls.Add(Me.My_Account_Button)
        Me.Controls.Add(Me.New_Species_Button)
        Me.Controls.Add(Me.Welcome_Screen_Heading)
        Me.Controls.Add(Me.Knowledge_Base_Button)
        Me.Controls.Add(Me.Edit_Find_Button)
        Me.Controls.Add(Me.New_Find_Button)
        Me.Controls.Add(Me.Edit_Location_Button)
        Me.Controls.Add(Me.New_Location_Button)
        Me.MaximizeBox = False
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nature Findings: Welcome Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents New_Location_Button As System.Windows.Forms.Button
    Friend WithEvents Edit_Location_Button As System.Windows.Forms.Button
    Friend WithEvents New_Find_Button As System.Windows.Forms.Button
    Friend WithEvents Edit_Find_Button As System.Windows.Forms.Button
    Friend WithEvents Knowledge_Base_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Screen_Heading As System.Windows.Forms.Label
    Friend WithEvents New_Species_Button As System.Windows.Forms.Button
    Friend WithEvents My_Account_Button As System.Windows.Forms.Button
    Friend WithEvents Welcome_Label As System.Windows.Forms.Label
End Class
