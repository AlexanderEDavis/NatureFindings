Public Class Knowledge_Base_Locations

    Private Sub Welcome_Screen_Button_Click() Handles Welcome_Screen_Button.Click
        'Loads the My Account Screen and closes this form.
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub My_Account_Button_Click() Handles My_Account_Button.Click
        'Loads the My Account Screen and closes this form.
        My_Account.Show()
        Me.Close()
    End Sub

    Private Sub Search_Finds_Button_Click() Handles Search_Finds_Button.Click
        'Loads the Search Finds Screen and closes this form.
        Knowledge_Base_Finds.Show()
        Me.Close()
    End Sub

    Private Sub Back_Button_Click() Handles Back_Button.Click
        'Loads the Knowledge Base Home Screen and close this form.
        Knowledge_Base_Home.Show()
        Me.Close()
    End Sub

    Private Sub Search_By_Name_Button_Click() Handles Search_By_Name_Button.Click
        'This loads the search information when someone searches by Location Name.
        Try
            Me.LocationTableAdapter.Fill_Location_By_Name(Me.Nature_Findings_Database.Location, CType(Name_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Location_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Address_Button_Click() Handles Search_By_Address_Button.Click
        'This loads the search information when someone searches by Location Address.
        Try
            Me.LocationTableAdapter.Fill_Location_By_Address(Me.Nature_Findings_Database.Location, CType(Address_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Location_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Owner_Button_Click() Handles Search_By_Owner_Button.Click
        'This loads the search information when someone searches by Location Owners.
        Try
            Me.LocationTableAdapter.Fill_Location_By_Owner(Me.Nature_Findings_Database.Location, CType(Owner_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Location_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Opening_Time_Button_Click() Handles Search_By_Opening_Time_Button.Click
        'This loads the search information when someone searches by Opening Times.
        Try
            Me.LocationTableAdapter.Fill_Location_By_Opening_Times(Me.Nature_Findings_Database.Location, CType(Opening_Times_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Location_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Contact_Details_Button_Click() Handles Search_By_Contact_Details_Button.Click
        'This loads the search information when someone searches by Contact Details.
        Try
            Me.LocationTableAdapter.Fill_Location_By_Contact_Details(Me.Nature_Findings_Database.Location, CType(Contact_Details_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Location_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Website_Button_Click() Handles Search_By_Website_Button.Click
        'This loads the search information when someone searches by Website.
        Try
            Me.LocationTableAdapter.Fill_Location_By_Website(Me.Nature_Findings_Database.Location, CType(Website_Criteria_Input.Text, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Location_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Entry_Price_Button_Click() Handles Search_By_Entry_Price_Button.Click
        'This loads the search information when someone searches by Entry Price.
        Try
            Me.LocationTableAdapter.Fill_Location_By_Entry_Price(Me.Nature_Findings_Database.Location, CType(Price_Criteria_Input.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Location_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub

    Private Sub Search_By_Date_Button_Click() Handles Search_By_Date_Button.Click
        'This loads the search information when someone searches by Opening Date.
        Try
            Me.LocationTableAdapter.Fill_Location_By_Date(Me.Nature_Findings_Database.Location, CType(Date_Criteria_Input.Text, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Lets the user know there are no search results
        If Location_Search_Results.RowCount = Nothing Then
            MsgBox("No Results Found")
        End If
    End Sub
End Class