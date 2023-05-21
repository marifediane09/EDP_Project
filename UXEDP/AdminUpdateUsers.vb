Imports MySql.Data.MySqlClient

Public Class AdminUpdateUsers
    Public Property UserId As Integer

    Public Class ItemUser
        Public Property fName As String
        Public Property lName As String
        Public Property Username As String
        'Public Property Email As Integer
        Public Property Role As String
    End Class

    Private Sub AdminUpdateUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Connect to the database
            Connect_to_DB()

            ' Retrieve the item data using the ItemId
            Dim UserData As ItemUser = GetUserDataFromDatabase(UserId)

            ' Populate the TextBoxes on the AdminUpdateItems form with the item data
            firstName.Text = UserData.fName
            lName.Text = UserData.lName
            UName.Text = UserData.Username
            'emailUser.Text = UserData.Email
            UserRole.Text = UserData.Role

            ' Make the TextBoxes read-only initially
            SetTextBoxesReadOnly(True)

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)

        Finally
            ' Disconnect from the database
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub SetTextBoxesReadOnly(isReadOnly As Boolean)
        ' Set the ReadOnly property of the TextBoxes
        firstName.ReadOnly = isReadOnly
        lName.ReadOnly = isReadOnly
        UName.ReadOnly = isReadOnly
        'emailUser.ReadOnly = isReadOnly
        UserRole.ReadOnly = isReadOnly
    End Sub


    Private Sub textBox_Click(sender As Object, e As EventArgs) Handles firstName.Click, lName.Click, UName.Click, UserRole.Click
        ' Enable editing for the clicked TextBox
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        textBox.ReadOnly = False
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        ' Ask the user if they want to save the changes
        Dim result As DialogResult = MessageBox.Show("Do you want to save your changes?", "Confirm Update", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Save the changes to the database
            UpdateUserDataInDatabase()
        End If
    End Sub

    Private Sub UpdateUserDataInDatabase()
        Try
            ' Connect to the database
            Connect_to_DB()

            ' Construct the query to update the item data
            Dim query As String = "UPDATE users SET fname = @fname, lname = @lname, username = @username, user_role = @user_role WHERE user_id = @user_id"

            Using mycmd As New MySqlCommand(query, myconn)
                ' Set the parameter values from the TextBoxes
                mycmd.Parameters.AddWithValue("@fname", firstName.Text)
                mycmd.Parameters.AddWithValue("@lname", lName.Text)
                mycmd.Parameters.AddWithValue("@username", UName.Text)
                mycmd.Parameters.AddWithValue("@user_role", UserRole.Text)

                ' Set the user_id parameter as an Integer
                mycmd.Parameters.AddWithValue("@user_id", UserId)

                ' Execute the update command
                mycmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("User data updated successfully.")

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)

        Finally
            ' Disconnect from the database
            Disconnect_to_DB()
        End Try
    End Sub


    Private Function GetUserDataFromDatabase(UserId As Integer) As ItemUser
        Dim UserData As New ItemUser()

        Try
            ' Connect to the database
            Connect_to_DB()

            ' Construct the query to retrieve item data
            Dim query As String = "SELECT fname, lname, username, user_role FROM users WHERE user_id = @user_id"

            Using mycmd As New MySqlCommand(query, myconn)
                mycmd.Parameters.AddWithValue("@user_id", UserId)

                Using reader As MySqlDataReader = mycmd.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the item data from the database
                        UserData.fName = reader.GetString("fname")
                        UserData.lName = reader.GetString("lname")
                        UserData.Username = reader.GetString("username")
                        UserData.Role = reader.GetString("user_role")
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            ' Disconnect from the database
            Disconnect_to_DB()
        End Try

        Return UserData
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AdminItems As New AdminItems()
        AdminItems.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim AdminCategories As New AdminCategories()
        AdminCategories.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form10 As New Form10()
        form10.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AdminOrders As New AdminOrders()
        AdminOrders.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dashboard As New adminDashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim backupForm As New backupForm1()
        backupForm.Show()
        Me.Hide()
    End Sub
End Class