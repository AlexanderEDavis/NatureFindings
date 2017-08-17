Public Class User_IDs

    Private Sub User_IDs_Load() Handles MyBase.Load
        'Shows the Users and their associated IDs
        Me.UsersTableAdapter.Fill(Me.Nature_Findings_Database.Users)
    End Sub
End Class