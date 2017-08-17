Public Class Knowledge_Base_Finds

    Private Sub Knowledge_Base_Species_Load() Handles MyBase.Load
        'This loads data into the form.
        Me.User_Species_LinkTableAdapter.Fill(Me.Nature_Findings_Database.User_Species_Link)
    End Sub

    Private Sub Species_ID_Button_Click() Handles Species_ID_Button.Click
        'Displays the available Species and their associated IDs
        Species_IDs.Show()
    End Sub

    Private Sub Location_ID_Button_Click() Handles Location_ID_Button.Click
        'Displays the available Locations and their associated IDs
        Location_IDs.Show()
    End Sub

    Private Sub User_ID_Button_Click() Handles User_ID_Button.Click
        'Displays the available Users and their associated IDs
        User_IDs.Show()
    End Sub

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

    Private Sub Back_Button_Click() Handles Back_Button.Click
        'Loads the Knowledge Base Home Screen and closes this form.
        Knowledge_Base_Home.Show()
        Me.Close()
    End Sub

    Private Sub Search_By_Date_Button_Click() Handles Search_By_Date_Button.Click
        'This loads the search information when someone searches by Date.
        Try
            Me.User_Species_LinkTableAdapter.Fill_Species_By_Date(Me.Nature_Findings_Database.User_Species_Link, CType(Date_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Find_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_User_Button_Click() Handles Search_By_User_Button.Click
        'This loads the search information when someone searches by User.
        Try
            Me.User_Species_LinkTableAdapter.Fill_Species_By_User(Me.Nature_Findings_Database.User_Species_Link, CType(User_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Find_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Species_Button_Click() Handles Search_By_Species_Button.Click
        'This loads the search information when someone searches by Species Name.
        Try
            Me.User_Species_LinkTableAdapter.Fill_Species_By_Name(Me.Nature_Findings_Database.User_Species_Link, CType(Species_Criterial_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Find_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Location_Button_Click() Handles Search_By_Location_Button.Click
        'This loads the search information when someone searches by Location Name.
        Try
            Me.User_Species_LinkTableAdapter.Fill_Species_By_Location(Me.Nature_Findings_Database.User_Species_Link, CType(Location_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Find_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Season_Button_Click() Handles Search_By_Season_Button.Click
        'This loads the search information when someone searches by Season.
        Try
            Me.User_Species_LinkTableAdapter.Fill_Species_By_Season(Me.Nature_Findings_Database.User_Species_Link, CType(Season_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Find_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub
End Class