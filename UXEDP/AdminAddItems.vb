Imports MySql.Data.MySqlClient

Public Class AdminAddItems
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Try
            Call Connect_to_DB()
            Dim query As String = "INSERT INTO items (item_id, item_name, item_desc, category_id, price, item_status) VALUES (@item_id, @item_name, @item_description, @category_id, @price, @item_status)"

            Using mycmd As New MySqlCommand(query, myconn)
                mycmd.Parameters.AddWithValue("@item_id", itemId.Text)
                mycmd.Parameters.AddWithValue("@item_name", itemName.Text)
                mycmd.Parameters.AddWithValue("@item_description", itemDesc.Text)
                mycmd.Parameters.AddWithValue("@category_id", category.Text)
                mycmd.Parameters.AddWithValue("@price", price.Text)
                mycmd.Parameters.AddWithValue("@item_status", status.Text)
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Item added successfully.", "Successful Item Addition", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim AdminCategories As New AdminCategories()
        AdminCategories.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AdminItems As New AdminItems()
        AdminItems.Show()
        Me.Hide()
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
End Class