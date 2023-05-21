Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class AdminAddItems
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Try
            Call Connect_to_DB()
            Dim query As String = "INSERT INTO items (item_name, item_desc, category_id, price, item_status) VALUES (@item_name, @item_description, @category_id, @price, @item_status)"

            ' Retrieve the category ID based on the selected category name from ComboBox2
            Dim categoryId As Integer
            Dim categoryQuery As String = "SELECT category_id FROM categories WHERE category_name = @category_name"
            Using categoryCmd As New MySqlCommand(categoryQuery, myconn)
                categoryCmd.Parameters.AddWithValue("@category_name", ComboBox2.SelectedItem.ToString())
                categoryId = CInt(categoryCmd.ExecuteScalar())
            End Using

            Using mycmd As New MySqlCommand(query, myconn)
                mycmd.Parameters.AddWithValue("@item_name", itemName.Text)
                mycmd.Parameters.AddWithValue("@item_description", itemDesc.Text)
                mycmd.Parameters.AddWithValue("@category_id", categoryId) ' Use the retrieved category ID
                mycmd.Parameters.AddWithValue("@price", price.Text)
                mycmd.Parameters.AddWithValue("@item_status", ComboBox1.SelectedItem.ToString())

                mycmd.ExecuteNonQuery()
                MessageBox.Show("Item added successfully.", "Successful Item Addition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim newItemId = mycmd.LastInsertedId
                'MessageBox.Show("The new item ID is " & newItemId, "New Item ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub AdminAddItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim status() As String = {"Available", "Unavailable"}
        ComboBox1.Items.AddRange(status)

        Try
            Call Connect_to_DB()
            Dim query As String = "SELECT category_name FROM categories"

            Using mycmd As New MySqlCommand(query, myconn)
                Using reader As MySqlDataReader = mycmd.ExecuteReader()
                    While reader.Read()
                        ComboBox2.Items.Add(reader("category_name").ToString())
                    End While
                End Using
            End Using

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Disconnect_to_DB()
        End Try
    End Sub

    Private Function GetNextCategoryID() As Integer
        Dim query As String = "SELECT MAX(category_id) + 1 AS next_id FROM categories"

        Using mycmd As New MySqlCommand(query, myconn)
            Dim reader As MySqlDataReader = mycmd.ExecuteReader()
            If reader.Read() Then
                GetNextCategoryID = reader("next_id")
            End If
        End Using

        Return GetNextCategoryID
    End Function

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