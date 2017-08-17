Public Class Knowledge_Base_Home

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

    Private Sub Search_Location_Button_Click() Handles Search_Location_Button.Click
        'Loads the Search Locations Screen and closes this form.
        Knowledge_Base_Locations.Show()
        Me.Close()
    End Sub

    Private Sub Search_Finds_Button_Click() Handles Search_Finds_Button.Click
        'Loads the Search Finds Screen and closes this form.
        Knowledge_Base_Finds.Show()
        Me.Close()
    End Sub
End Class