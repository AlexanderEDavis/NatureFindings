Public Class New_Species
    Private Species_Check As String
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

    Private Sub SpeciesBindingNavigatorSaveItem_Click() Handles SpeciesBindingNavigatorSaveItem.Click

        If Add_Species_Clicked = True Then

            'This checks if the Species already exists in the system
            Species_Check = Me.SpeciesTableAdapter.Species_Check(Species_Name_Input.Text)
            If Species_Check = Nothing Then
                Does_Species_Exist = False
            Else
                Does_Species_Exist = True
            End If

            If Does_Species_Exist = False Then

                If Species_Name_Input Is Nothing Then
                    MsgBox("Please enter a species name")
                Else
                    'Saves the New Species entry to the database.
                    Me.Validate()
                    Me.SpeciesBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.Nature_Findings_Database)

                    'Sends a save confirmation to the user
                    MsgBox("Species Added")

                    'Resets the Add_New_Species and the Does_Species_Exist variable
                    Add_Species_Clicked = False
                    Does_Species_Exist = False
                End If

            Else
                MsgBox("This Species already exists")
            End If

        Else
            MsgBox("Please Click Add New in the toolbar")
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click() Handles BindingNavigatorAddNewItem.Click
        'Allows user to click save without error messages
        Add_Species_Clicked = True
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click() Handles BindingNavigatorDeleteItem.Click
        'Resets the Add_Find_Clicked Variable
        Add_Species_Clicked = False
    End Sub
End Class