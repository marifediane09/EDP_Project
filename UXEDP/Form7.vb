Imports System.IO
Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Form7
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim form8 As New Form8()
        form8.Show()
        Me.Hide()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form9 As New Form9()
        form9.Show()
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
        Dim form11 As New Form11()
        form11.Show()
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

End Class