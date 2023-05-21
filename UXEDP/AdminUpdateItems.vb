Imports MySql.Data.MySqlClient

Public Class AdminUpdateItems
    Public Property ItemId As Integer

    Public Class Item
        Public Property Name As String
        Public Property Image As String
        Public Property Description As String
        Public Property CategoryId As Integer
        Public Property Price As Decimal
        Public Property OwnerId As Integer
        Public Property Status As String
    End Class

    Private Sub AdminUpdateItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Connect to the database
            Connect_to_DB()

            ' Retrieve the item data using the ItemId
            Dim itemData As Item = GetItemDataFromDatabase(ItemId)

            ' Populate the TextBoxes on the AdminUpdateItems form with the item data
            itemName.Text = itemData.Name
            Image.Text = itemData.Image
            itemDesc.Text = itemData.Description
            catId.Text = itemData.CategoryId.ToString()
            price.Text = itemData.Price.ToString()
            ownerId.Text = itemData.OwnerId.ToString()
            itemStatus.Text = itemData.Status

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
        itemName.ReadOnly = isReadOnly
        Image.ReadOnly = isReadOnly
        itemDesc.ReadOnly = isReadOnly
        catId.ReadOnly = isReadOnly
        price.ReadOnly = isReadOnly
        ownerId.ReadOnly = isReadOnly
        itemStatus.ReadOnly = isReadOnly
    End Sub


    Private Sub textBox_Click(sender As Object, e As EventArgs) Handles itemName.Click, Image.Click, itemDesc.Click, catId.Click, price.Click, ownerId.Click, itemStatus.Click
        ' Enable editing for the clicked TextBox
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        textBox.ReadOnly = False
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        ' Ask the user if they want to save the changes
        Dim result As DialogResult = MessageBox.Show("Do you want to save your changes?", "Confirm Update", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' Save the changes to the database
            UpdateItemDataInDatabase()
        End If
    End Sub

    Private Sub UpdateItemDataInDatabase()
        Try
            ' Connect to the database
            Connect_to_DB()

            ' Construct the query to update the item data
            Dim query As String = "UPDATE items SET item_name = @name, image = @image, item_desc = @description, category_id = @category_id, price = @price, owner_id = @owner_id, item_status = @status WHERE item_id = @item_id"

            Using mycmd As New MySqlCommand(query, myconn)
                ' Set the parameter values from the TextBoxes
                mycmd.Parameters.AddWithValue("@name", itemName.Text)
                mycmd.Parameters.AddWithValue("@image", Image.Text)
                mycmd.Parameters.AddWithValue("@description", itemDesc.Text)
                mycmd.Parameters.AddWithValue("@category_id", Integer.Parse(catId.Text))
                mycmd.Parameters.AddWithValue("@price", Decimal.Parse(price.Text))
                mycmd.Parameters.AddWithValue("@owner_id", Integer.Parse(ownerId.Text))
                mycmd.Parameters.AddWithValue("@status", itemStatus.Text)
                mycmd.Parameters.AddWithValue("@item_id", ItemId)

                ' Execute the update command
                mycmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Item data updated successfully.")

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)

        Finally
            ' Disconnect from the database
            Disconnect_to_DB()
        End Try
    End Sub

    Private Function GetItemDataFromDatabase(itemId As Integer) As Item
        Dim itemData As New Item()

        Try
            ' Connect to the database
            Connect_to_DB()

            ' Construct the query to retrieve item data
            Dim query As String = "SELECT item_name, image, item_desc, category_id, price, owner_id, item_status FROM items WHERE item_id = @item_id"

            Using mycmd As New MySqlCommand(query, myconn)
                mycmd.Parameters.AddWithValue("@item_id", itemId)

                Using reader As MySqlDataReader = mycmd.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the item data from the database
                        itemData.Name = reader.GetString("item_name")
                        itemData.Image = reader.GetString("image")
                        itemData.Description = reader.GetString("item_desc")
                        itemData.CategoryId = reader.GetInt32("category_id")
                        itemData.Price = reader.GetDecimal("price")
                        itemData.OwnerId = reader.GetInt32("owner_id")
                        itemData.Status = reader.GetString("item_status")
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            ' Disconnect from the database
            Disconnect_to_DB()
        End Try

        Return itemData
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