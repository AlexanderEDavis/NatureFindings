Public Class Location_IDs

    Private Sub Location_IDs_Load() Handles MyBase.Load
        'Loads the Locations and the IDs associated to them
        Me.LocationTableAdapter.Fill(Me.Nature_Findings_Database.Location)
    End Sub
End Class