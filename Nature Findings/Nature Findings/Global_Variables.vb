Module Global_Variables
    Public Username As String 'Stores the Username for use within the program.
    Public User_ID As Integer 'Stores the User ID for use within the program.
    Public Contributor_Name As String 'Stores the Contributor Name for the Welcome Screen Message.

    'Specific for the Add Species Screen
    Public Add_Species_Clicked As Boolean 'Tells the program if the user has pressed Add New on the Add New Species Screen
    Public Does_Species_Exist As Boolean 'Tells the program if the Species already exists in the database

    'Specific for the Add Location Screen
    Public Add_Location_Clicked As Boolean 'Tells the program if the user has pressed Add New on the Add New Location Screen
    Public Does_Location_Exist As Boolean 'Tells the program if the Location already exists in the database

    'Specific for the Add Find Screen
    Public Add_Find_Clicked As Boolean 'Tells the program if the user has pressed Add New on the Add New Find Screen
End Module
