Public Class Edit_Location

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
        'Saves the edited locations users have entered.
        Me.Validate()
        Me.LocationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Nature_Findings_Database)

        'Sends a save confirmation to the user
        MsgBox("Locations Updated")
    End Sub

    Private Sub Edit_Location_Load() Handles MyBase.Load
        'This loads data into the form.
        Me.LocationTableAdapter.Fill(Me.Nature_Findings_Database.Location)

    End Sub
End Class