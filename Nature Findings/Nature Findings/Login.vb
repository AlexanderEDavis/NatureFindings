Public Class Login

    Public Sub Login_Button_Click() Handles Login_Button.Click
        'Resets the Add_Find_Clicked Variables
        Add_Location_Clicked = False
        Add_Species_Clicked = False
        Add_Find_Clicked = False
        Does_Species_Exist = False
        Does_Location_Exist = False

        Username = UsernameInput.Text 'This sets the global variables Username
        User_ID = Me.UsersTableAdapter.Get_User_ID(Global_Variables.Username) 'This sets the global variables User_ID
        Contributor_Name = Me.UsersTableAdapter.Get_Contributor_Name(Global_Variables.Username) 'This sets the global variable Contributor Name for the welcome screen message.

        'This checks if the user details are correct in the database
        'Remember to update the database WITHIN the solution files!
        Dim login = Me.UsersTableAdapter.Login_Check(UsernameInput.Text, PasswordInput.Text)

        If login Is Nothing Then
            MsgBox("Incorrect Login Information")
            PasswordInput.Text = ""
        Else
            Welcome.Show()
            Me.Close()
        End If
    End Sub
End Class
