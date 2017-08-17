Public Class New_Location
    Private Location_Check As String

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

    Private Sub LocationBindingNavigatorSaveItem_Click() Handles LocationBindingNavigatorSaveItem.Click

        If Add_Location_Clicked = True Then

            'This checks if the Species already exists in the system
            Location_Check = Me.LocationTableAdapter.Location_Check(Location_NameTextBox.Text)
            If Location_Check = Nothing Then
                Does_Location_Exist = False
            Else
                Does_Location_Exist = True
            End If

            If Does_Species_Exist = False Then

                If Location_NameTextBox Is Nothing Then
                    MsgBox("Please enter a location name")
                Else
                    If AddressTextBox Is Nothing Then
                        MsgBox("Please enter a location address")
                    Else
                        'Saves the New Location entry to the database.
                        Me.Validate()
                        Me.LocationBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.Nature_Findings_Database)

                        'Sends a save confirmation to the user
                        MsgBox("Location Added")
                    End If
                    'Resets the Add_New_Location and the Does_Location_Exist variable
                    Add_Location_Clicked = False
                    Does_Location_Exist = False
                End If
            Else
                MsgBox("This Location already exists")
            End If
        Else
            MsgBox("Please Click Add New in the toolbar")
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click() Handles BindingNavigatorAddNewItem.Click
        'Allows user to click save without error messages
        Add_Location_Clicked = True
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click() Handles BindingNavigatorDeleteItem.Click
        'Resets the Add_Find_Clicked Variable
        Add_Location_Clicked = False
    End Sub
End Class