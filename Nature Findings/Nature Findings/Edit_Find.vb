Public Class Edit_Find

    Private Sub Welcome_Screen_Button_Click() Handles Welcome_Screen_Button.Click
        'Loads the Welcome Screen and closes this form.
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub My_Account_Button_Click() Handles My_Account_Button.Click
        'Loads the My Account Screen and closes this form.
        My_Account.Show()
        Me.Close()
    End Sub

    Private Sub User_Species_LinkBindingNavigatorSaveItem_Click() Handles User_Species_LinkBindingNavigatorSaveItem.Click
        'This saves the updated Finds that the user has edited or viewed.
        Me.Validate()
        Me.User_Species_LinkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Nature_Findings_Database)

        'Sends a save confirmation to the user
        MsgBox("Finds Updated")
    End Sub

    Private Sub Edit_Find_Load() Handles MyBase.Load
        'This loads the form with the Finds specific to that user.
        Try
            Me.User_Species_LinkTableAdapter.Fill_Life_List(Nature_Findings_Database.User_Species_Link, Global_Variables.User_ID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class