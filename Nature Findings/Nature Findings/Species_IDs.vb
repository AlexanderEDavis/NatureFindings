Public Class Species_IDs

    Private Sub Species_IDs_Load() Handles MyBase.Load
        'Shows the Species and their associated IDs
        Me.SpeciesTableAdapter.Fill(Me.Nature_Findings_Database.Species)
    End Sub
End Class