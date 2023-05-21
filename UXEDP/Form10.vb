Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.Common
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form10

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call Connect_to_DB()

            ' Create a new DataTable to hold the results
            Dim dt As New DataTable()

            ' Create a SELECT query to retrieve all the records from the "items" table
            Dim query As String = "SELECT * FROM users"

            ' Create a new MySqlDataAdapter to execute the query and fill the DataTable
            Using da As New MySqlDataAdapter(query, myconn)
                da.Fill(dt)
            End Using

            ' Bind the DataTable to the DataGridView control
            DataGridView1.DataSource = dt

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)

        Finally
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub InsertData_Click(sender As Object, e As EventArgs) Handles InsertData.Click
        ' Display an OpenFileDialog to allow the user to select a CSV file
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        openFileDialog1.Title = "Select a CSV File"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Call Connect_to_DB()

                ' Read the selected CSV file into a DataTable
                Dim dt As New DataTable()
                Using reader As New StreamReader(openFileDialog1.FileName)
                    ' Read the first line of the file to get the column names
                    Dim line As String = reader.ReadLine()
                    Dim columns As String() = line.Split(","c)

                    ' Add the columns to the DataTable
                    For Each column As String In columns
                        dt.Columns.Add(column.Trim())
                    Next

                    ' Read the rest of the file to get the data rows
                    While Not reader.EndOfStream
                        line = reader.ReadLine()
                        Dim values As String() = line.Split(","c)

                        ' Add a new row to the DataTable
                        Dim row As DataRow = dt.NewRow()
                        For i As Integer = 0 To values.Length - 1
                            row(i) = values(i).Trim()
                        Next
                        dt.Rows.Add(row)
                    End While
                End Using

                ' Save the DataTable to the database
                Dim query As String = "INSERT INTO users (fname, lname, username, email, user_password, user_role) VALUES (@fname, @lname, @username, @email, @user_password, @user_role)"
                Using cmd As New MySqlCommand(query, myconn)
                    For Each row As DataRow In dt.Rows
                        cmd.Parameters.Clear()
                        'cmd.Parameters.AddWithValue("@user_id", row("user_id"))
                        cmd.Parameters.AddWithValue("@fname", row("fname"))
                        cmd.Parameters.AddWithValue("@lname", row("lname"))
                        cmd.Parameters.AddWithValue("@username", row("username"))
                        cmd.Parameters.AddWithValue("@email", row("email"))
                        cmd.Parameters.AddWithValue("@user_password", row("user_password"))
                        cmd.Parameters.AddWithValue("@user_role", row("user_role"))
                        cmd.ExecuteNonQuery()
                    Next
                End Using

                ' Display a message box indicating that the data was successfully inserted
                MessageBox.Show("Data inserted to database successfully!")

                ' Reload the data from the database and bind it to the DataGridView control
                dt.Clear()
                Using da As New MySqlDataAdapter("SELECT * FROM users", myconn)
                    da.Fill(dt)
                End Using
                DataGridView1.DataSource = dt

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)

            Finally
                Disconnect_to_DB()
            End Try
        End If
    End Sub

    Private Sub DeleteSelectedUser()
        ' Prompt the user to enter the item ID
        Dim userIdInput As String = InputBox("Enter the user ID to delete:", "Delete User")

        ' Check if the user entered a valid item ID
        If Not String.IsNullOrWhiteSpace(userIdInput) Then
            Dim userId As Integer
            If Integer.TryParse(userIdInput, userId) Then
                Try
                    Call Connect_to_DB()
                    Dim query As String = "DELETE FROM users WHERE user_id = @user_id"

                    Using mycmd As New MySqlCommand(query, myconn)
                        mycmd.Parameters.AddWithValue("@user_id", userId)

                        Dim rowsAffected As Integer = mycmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("User deleted successfully.", "Successful User Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the DataGridView to reflect the changes
                            Form10_Load(Nothing, EventArgs.Empty)
                        Else
                            MessageBox.Show("No user found with the specified ID.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using

                Catch ex As MySqlException
                    MsgBox(ex.Number & " " & ex.Message)
                Finally
                    Disconnect_to_DB()
                End Try
            Else
                MessageBox.Show("Invalid user ID. Please enter a valid numeric ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub UpdateUser()
        ' Prompt the user to enter the category ID
        Dim userIdInput As String = InputBox("Enter the user ID to update:", "Update User")

        ' Check if the user entered a valid item ID
        If Not String.IsNullOrWhiteSpace(userIdInput) Then
            Dim userId As Integer
            If Integer.TryParse(userIdInput, userId) Then
                ' Create an instance of the AdminUpdateItems form
                Dim adminUpdateUserForm As New AdminUpdateUsers()

                ' Set the ItemId property of the AdminUpdateItems form
                adminUpdateUserForm.UserId = userId

                ' Show the AdminUpdateItems form
                adminUpdateUserForm.Show()

                ' Assign the ItemId value to the TextBox on the AdminUpdateItems form
                adminUpdateUserForm.UpdateID.Text = adminUpdateUserForm.UserId.ToString()

                ' Hide the current form
                Me.Hide()

            Else
                MessageBox.Show("Invalid item ID. Please enter a valid numeric ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dashboard As New adminDashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AdminOrders As New AdminOrders()
        AdminOrders.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim backupForm As New backupForm1()
        backupForm.Show()
        Me.Hide()
    End Sub

    Private Sub bthPrint_Click(sender As Object, e As EventArgs) Handles bthPrint.Click
        'MsgBox(currentDate.ToString)
        Call ImportToExcel(Me.DataGridView1, "userReport.xlsx")
        'Dim excludedColumns As New List(Of Object) From {"user_password"}
        'Call ImportToExcel(Me.DataGridView1, "itemsReport.xlsx", excludedColumns)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        UpdateUser()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        DeleteSelectedUser()
    End Sub
End Class