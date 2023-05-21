Imports System.IO
Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class AdminItems

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim AdminAddItems As New AdminAddItems()
        AdminAddItems.Show()
        Me.Hide()
    End Sub

    Private Sub AdminItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Call Connect_to_DB()

            ' Create a new DataTable to hold the results
            Dim dt As New DataTable()

            ' Create a SELECT query to retrieve all the records from the "items" table
            Dim query As String = "SELECT * FROM items"

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

    Private Sub DeleteSelectedItem()
        ' Prompt the user to enter the item ID
        Dim itemIdInput As String = InputBox("Enter the item ID to delete:", "Delete Item")

        ' Check if the user entered a valid item ID
        If Not String.IsNullOrWhiteSpace(itemIdInput) Then
            Dim itemId As Integer
            If Integer.TryParse(itemIdInput, itemId) Then
                Try
                    Call Connect_to_DB()
                    Dim query As String = "DELETE FROM items WHERE item_id = @item_id"

                    Using mycmd As New MySqlCommand(query, myconn)
                        mycmd.Parameters.AddWithValue("@item_id", itemId)

                        Dim rowsAffected As Integer = mycmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Item deleted successfully.", "Successful Item Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the DataGridView to reflect the changes
                            AdminItems_Load(Nothing, EventArgs.Empty)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim AdminCategories As New AdminCategories()
        AdminCategories.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dashboard As New adminDashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        'Dim excludedColumns As New List(Of Object) From {"passwords"}
        Call ImportToExcel(Me.DataGridView1, "itemsReport.xlsx")
    End Sub

    Private Sub deleteItem_Click(sender As Object, e As EventArgs) Handles deleteItem.Click
        DeleteSelectedItem()
    End Sub

    Private Sub updateItems_Click(sender As Object, e As EventArgs) Handles updateItems.Click
        UpdateItem()
    End Sub

    Private Sub UpdateItem()
        ' Prompt the user to enter the item ID
        Dim itemIdInput As String = InputBox("Enter the item ID to update:", "Update Item")

        ' Check if the user entered a valid item ID
        If Not String.IsNullOrWhiteSpace(itemIdInput) Then
            Dim itemId As Integer
            If Integer.TryParse(itemIdInput, itemId) Then
                ' Create an instance of the AdminUpdateItems form
                Dim adminUpdateItemForm As New AdminUpdateItems()

                ' Set the ItemId property of the AdminUpdateItems form
                adminUpdateItemForm.ItemId = itemId

                ' Show the AdminUpdateItems form
                adminUpdateItemForm.Show()

                ' Assign the ItemId value to the TextBox on the AdminUpdateItems form
                adminUpdateItemForm.UpdateID.Text = adminUpdateItemForm.ItemId.ToString()

                ' Hide the current form
                Me.Hide()

            Else
                MessageBox.Show("Invalid item ID. Please enter a valid numeric ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

End Class