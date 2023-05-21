Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class AdminCategories
    Private Sub addCatBtn_Click(sender As Object, e As EventArgs) Handles addCatBtn.Click
        Try
            Call Connect_to_DB()
            Dim query As String = "INSERT INTO categories (category_id, category_name) VALUES (@cat_id, @cat_name)"

            Using mycmd As New MySqlCommand(query, myconn)
                mycmd.Parameters.AddWithValue("@cat_id", catId.Text)
                mycmd.Parameters.AddWithValue("@cat_name", catName.Text)
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Item added successfully.", "Successful Item Addition", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub AdminCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call Connect_to_DB()

            ' Create a new DataTable to hold the results
            Dim dt As New DataTable()

            ' Create a SELECT query to retrieve all the records from the "items" table
            Dim query As String = "SELECT * FROM categories"

            ' Create a new MySqlDataAdapter to execute the query and fill the DataTable
            Using da As New MySqlDataAdapter(query, myconn)
                da.Fill(dt)
            End Using

            ' Bind the DataTable to the DataGridView control
            DataGridView2.DataSource = dt

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)

        Finally
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub DeleteSelectedCat()
        ' Prompt the user to enter the item ID
        Dim itemIdInput As String = InputBox("Enter the category ID to delete:", "Delete Category")

        ' Check if the user entered a valid item ID
        If Not String.IsNullOrWhiteSpace(itemIdInput) Then
            Dim catId As Integer
            If Integer.TryParse(itemIdInput, catId) Then
                Try
                    Call Connect_to_DB()
                    Dim query As String = "DELETE FROM categories WHERE category_id = @item_id"

                    Using mycmd As New MySqlCommand(query, myconn)
                        mycmd.Parameters.AddWithValue("@item_id", catId)

                        Dim rowsAffected As Integer = mycmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Category deleted successfully.", "Successful Item Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the DataGridView to reflect the changes
                            AdminCategories_Load(Nothing, EventArgs.Empty)
                        Else
                            MessageBox.Show("No item found with the specified ID.", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using

                Catch ex As MySqlException
                    MsgBox(ex.Number & " " & ex.Message)
                Finally
                    Disconnect_to_DB()
                End Try
            Else
                MessageBox.Show("Invalid item ID. Please enter a valid numeric ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub UpdateCategory()
        ' Prompt the user to enter the category ID
        Dim categoryIdInput As String = InputBox("Enter the category ID to update:", "Update Category")

        ' Check if the user entered a valid category ID
        If Not String.IsNullOrWhiteSpace(categoryIdInput) Then
            Dim categoryId As Integer
            If Integer.TryParse(categoryIdInput, categoryId) Then
                ' Prompt the user to enter the new category name
                Dim newCategoryName As String = InputBox("Enter the new category name:", "Update Category")

                ' Check if the user entered a category name
                If Not String.IsNullOrWhiteSpace(newCategoryName) Then
                    ' Update the category name in the database using the category ID
                    UpdateCategoryName(categoryId, newCategoryName)

                    ' Display a success message
                    MessageBox.Show("Category name updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Invalid category name. Please enter a valid name.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Invalid category ID. Please enter a valid numeric ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub UpdateCategoryName(categoryId As Integer, newName As String)
        Try
            Call Connect_to_DB()

            ' Prepare the SQL update statement
            Dim updateQuery As String = "UPDATE categories SET category_name = @newCat WHERE category_id = @categoryId"

            ' Create a command object
            Dim command As New MySqlCommand(updateQuery, myconn)

            ' Add parameters to the command
            command.Parameters.AddWithValue("@newCat", newName)
            command.Parameters.AddWithValue("@categoryId", categoryId)

            ' Execute the update command
            command.ExecuteNonQuery()

            ' Display a success message
            MessageBox.Show("Category name updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As MySqlException
            MessageBox.Show("An error occurred while updating the category name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Disconnect_to_DB()
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AdminItems As New AdminItems()
        AdminItems.Show()
        Me.Hide()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dashboard As New adminDashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AdminOrders As New AdminOrders()
        AdminOrders.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form10 As New Form10()
        form10.Show()
        Me.Hide()
    End Sub

    Private Sub deleteCat_Click(sender As Object, e As EventArgs) Handles deleteCat.Click
        DeleteSelectedCat()
    End Sub

    Private Sub updateCat_Click(sender As Object, e As EventArgs) Handles updateCat.Click
        UpdateCategory()
    End Sub
End Class