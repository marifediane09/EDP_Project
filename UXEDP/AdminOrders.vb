﻿Imports MySql.Data.MySqlClient

Public Class AdminOrders
    Private Sub AdminOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call Connect_to_DB()

            ' Create a new DataTable to hold the results
            Dim dt As New DataTable()

            ' Create a SELECT query to retrieve all the records from the "items" table
            Dim query As String = "SELECT * FROM rentals"

            ' Create a new MySqlDataAdapter to execute the query and fill the DataTable
            Using da As New MySqlDataAdapter(query, myconn)
                da.Fill(dt)
            End Using

            ' Bind the DataTable to the DataGridView control
            DataGridView3.DataSource = dt

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)

        Finally
            Disconnect_to_DB()
        End Try
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
        Dim form10 As New Form10()
        form10.Show()
        Me.Hide()
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        Call ImportToExcel(Me.DataGridView3, "ordersReport.xlsx")
    End Sub
End Class