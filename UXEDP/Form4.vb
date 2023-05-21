Imports System.IO
Imports System.Windows
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form4
    Public Class Item
        Public Property Id As Integer
        Public Property Name As String
        Public Property Image As Image
        Public Property Price As Decimal
        Public Sub New(id As Integer, name As String, image As Image, price As Decimal)
            Me.Id = id
            Me.Name = name
            Me.Image = image
            Me.Price = price
        End Sub
    End Class

    ' Define a list of items
    Dim items As List(Of Item)

    ' Define a list of selected items for the user's cart
    Public Property SelectedItems As New List(Of Item)

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()
        items = New List(Of Item)
        Dim query As String = "SELECT item_id, item_name, image, price FROM items"
        Using mycmd As New MySqlCommand(query, myconn)
            Dim myreader As MySqlDataReader
            myreader = mycmd.ExecuteReader()
            While myreader.Read()
                ' Get the image file name from the database
                Dim imageName As String = myreader("image").ToString()

                'Dim imagePath As String = $"{Application.StartupPath}Resources\{imageName}"
                Dim currentDirectory As String = System.IO.Directory.GetCurrentDirectory()
                Dim imagePath As String = System.IO.Directory.GetParent(currentDirectory).ToString()
                Dim imagePath1 As String = System.IO.Directory.GetParent(imagePath).ToString()
                Dim imagePath2 As String = System.IO.Directory.GetParent(imagePath1).ToString()

                'Dim imagePath3 As String = imagePath2 & "\Resources\"
                Dim imagePath3 As String = Path.Combine(imagePath2, "Resources", imageName)

                ' Create an Item object and add it to the list
                'Dim item As New Item With {
                '.Id = Convert.ToInt32(myreader("item_id")),
                '.Name = myreader("item_name").ToString(),
                '.Image = Image.FromFile(imagePath),
                '.Price = Convert.ToDecimal(myreader("price"))
                '}
                ' Create an Item object and add it to the list
                Dim item As Item = Nothing
                Try
                    item = New Item(Convert.ToInt32(myreader("item_id")), myreader("item_name").ToString(), Image.FromFile(imagePath3), Convert.ToDecimal(myreader("price")))
                Catch ex As Exception
                    ' Handle the exception
                    MessageBox.Show($"Error loading image: {ex.Message}")
                End Try

                If item IsNot Nothing Then
                    items.Add(item)
                    AvailableItemsListBox.Items.Add(myreader("item_name").ToString())
                End If

                'Dim item As New Item(Convert.ToInt32(myreader("item_id")), myreader("item_name").ToString(), Image.FromFile(imagePath3), Convert.ToDecimal(myreader("price")))
                'items.Add(item)

                ' Add the item name to the ListBox control
                AvailableItemsListBox.Items.Add(myreader("item_name").ToString())
            End While
            myreader.Close()
            Disconnect_to_DB()
        End Using
    End Sub

    Private Sub AvailableItemsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AvailableItemsListBox.SelectedIndexChanged
        ' Get the selected item from the ListBox
        Dim selectedItem As Item = items(AvailableItemsListBox.SelectedIndex)

        ' Display the details of the selected item in the panel
        ItemName.Text = selectedItem.Name
        ItemImage.Image = selectedItem.Image
        ItemPrice.Text = selectedItem.Price.ToString("C")
    End Sub

    Private Sub RentButton_Click(sender As Object, e As EventArgs) Handles RentButton.Click
        ' Get the selected item from the AvailableItemsListBox.
        Try
            ' Get the selected item from the AvailableItemsListBox.
            Dim selectedItem As Item = items(AvailableItemsListBox.SelectedIndex)

            ' Create a new instance of the CartForm and pass in the SelectedItems list.
            Dim cartForm As New CartForm(SelectedItems)

            ' Add the selected item to the SelectedItems list in the CartForm.
            cartForm.SelectedItems.Add(selectedItem)

            ' Show the details of the selected item in the DataGridView on the CartForm.
            cartForm.DataGridView1.Rows.Add(selectedItem.Name, selectedItem.Price.ToString("C"))

            MessageBox.Show("The item has been added to your cart. View them in 'Orders'.")
            'cartForm.ShowDialog()
        Catch ex As Exception
            ' Handle the exception
            MessageBox.Show($"Error adding item to cart: {ex.Message}")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form5 As New CartForm(SelectedItems)
        form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim UserCategories As New UserCategories()
        UserCategories.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim UserProfile As New UserProfile()
        UserProfile.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Refresh()
    End Sub
End Class