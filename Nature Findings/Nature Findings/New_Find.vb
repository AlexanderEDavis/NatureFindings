Public Class New_Find

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
        If Add_Find_Clicked = True Then

            If Sight_DateDateTimePicker.Text = Nothing Or Species_IDTextBox.Text = Nothing Or Location_IDTextBox.Text = Nothing Or SeasonComboBox.Text = Nothing Then
                MsgBox("Please fill in all the required fields", MsgBoxStyle.Exclamation)
            Else
                'Automatically enters the User ID into the form so the entry is associated to that specific user.
                User_IDTextBox.Text = User_ID

                'This saves the new entry into the database.
                Me.Validate()
                Me.User_Species_LinkBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Nature_Findings_Database)

                'Sends a save confirmation to the user
                MsgBox("Find Added")

                'Resets the Add_Find_Clicked Variable
                Add_Find_Clicked = False
            End If
        Else
            MsgBox("Please Click Add New in the toolbar")
        End If
    End Sub

    Private Sub Species_ID_Button_Click() Handles Species_ID_Button.Click
        'Displays the Species and their assocaiated IDs.
        Species_IDs.Show()
    End Sub

    Private Sub Location_ID_Button_Click() Handles Location_ID_Button.Click
        'Displayes the Locations and their associated IDs
        Location_IDs.Show()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click() Handles BindingNavigatorAddNewItem.Click
        'Allows user to click save without error messages
        Add_Find_Clicked = True
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click() Handles BindingNavigatorDeleteItem.Click
        'Resets the Add_Find_Clicked Variable
        Add_Find_Clicked = False
    End Sub
End Class