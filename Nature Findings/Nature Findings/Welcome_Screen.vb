Public Class Welcome

    Private Sub New_Location_Button_Click() Handles New_Location_Button.Click
        'Loads the New Location Screen and closes this form.
        New_Location.Show()
        Me.Close()
    End Sub

    Private Sub Edit_Location_Button_Click() Handles Edit_Location_Button.Click
        'Loads the Edit Location Screen and closes this form.
        Edit_Location.Show()
        Me.Close()
    End Sub

    Private Sub New_Find_Button_Click() Handles New_Find_Button.Click
        'Loads the New Find Screen and closes this form.
        New_Find.Show()
        Me.Close()
    End Sub

    Private Sub Edit_Find_Button_Click() Handles Edit_Find_Button.Click
        'Loads the Edit Find Screen and closes this form.
        Edit_Find.Show()
        Me.Close()
    End Sub

    Private Sub Knowledge_Base_Button_Click() Handles Knowledge_Base_Button.Click
        'Loads the Knowledge Base Home Screen and closes this form.
        Knowledge_Base_Home.Show()
        Me.Close()
    End Sub

    Private Sub New_Species_Button_Click() Handles New_Species_Button.Click
        'Displays the New Species Screen ontop of this form.
        New_Species.ShowDialog()
    End Sub

    Private Sub My_Account_Button_Click() Handles My_Account_Button.Click
        'Loads the My Account Screen and closes this form.
        My_Account.Show()
        Me.Close()
    End Sub

    Private Sub Welcome_Load() Handles MyBase.Load
        'Displays a welcome message to the user
        Welcome_Label.Text = "Hello " & Global_Variables.Contributor_Name
    End Sub
End Class