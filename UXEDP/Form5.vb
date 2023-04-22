Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Public Class CartForm
    Public Property SelectedItems As List(Of Form4.Item)
    Private totalAmount As Double = 0 ' declare totalAmount as a field of the form

    Public Sub New(selectedItems As List(Of Form4.Item))
        InitializeComponent()

        ' Initialize the SelectedItems list.
        Me.SelectedItems = selectedItems

        ' Show the details of the selected item in the DataGridView on the CartForm.
        For Each selectedItem In selectedItems
            Dim rowIndex As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(rowIndex).Cells(0).Value = selectedItem.Name
            DataGridView1.Rows(rowIndex).Cells(1).Value = selectedItem.Price.ToString("C")
            totalAmount += selectedItem.Price ' add the price of the item to the totalAmount
        Next

        ' Set the value of the TextBox to the total amount
        txtTotalAmount.Text = totalAmount.ToString("C2")

        ' Make the TextBox read-only
        txtTotalAmount.ReadOnly = True

        ' Add a handler for the RowsAdded event of the DataGridView
        AddHandler DataGridView1.RowsAdded, AddressOf DataGridView1_RowsAdded
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        ' Loop through each row in the DataGridView and add the value in the "Price" column to the total amount
        For Each row As DataGridViewRow In DataGridView1.Rows
            totalAmount += CDbl(row.Cells("Column2").Value)
        Next

        ' Set the value of the TextBox to the total amount
        txtTotalAmount.Text = totalAmount.ToString("C2")
    End Sub

    Private Sub btnConfirmOrder_Click(sender As Object, e As EventArgs) Handles btnConfirmOrder.Click

        ' Add the items to the rentals table in the database
        Call Connect_to_DB()
        For Each item In SelectedItems
            Dim query As String = $"INSERT INTO rentals (item_id) VALUES ({item.Id})"
            Dim cmd As New MySqlCommand(query, myconn)
            cmd.ExecuteNonQuery()
        Next
        'End Using

        ' Show a confirmation message box
        MessageBox.Show("Your order has been confirmed.")

        ' Clear the SelectedItems list and close the form
        'SelectedItems.Clear()
        'Me.Close()
        Disconnect_to_DB()
        MessageBox.Show("Your order has been placed successfully!")
        SelectedItems.Clear()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form4 As New Form4()
        form4.Show()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Refresh()
    End Sub
End Class