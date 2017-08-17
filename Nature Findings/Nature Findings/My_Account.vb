Public Class My_Account

    Private Sub Save_Button_Click() Handles Save_Button.Click
        'This saves the user information to the database.
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Nature_Findings_Database)
        MsgBox("User Information Saved")
    End Sub

    Public Sub My_Account_Load() Handles MyBase.Load
        'This loads the current Users information.
        Try
            Me.UsersTableAdapter.Fill_Account_Information(Me.Nature_Findings_Database.Users, CType(Global_Variables.Username, String))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Welcome_Screen_Button_Click() Handles Welcome_Screen_Button.Click
        'Loads the Welcome Screen and closes this form.
        Welcome.Show()
        Me.Close()
    End Sub
End Class