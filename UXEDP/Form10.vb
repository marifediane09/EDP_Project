Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form10
    Private dt As New DataTable() ' Declare the DataTable as a private field

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if the DataTable has already been loaded from a file or database
        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = dt ' Bind the DataTable to the DataGridView
        End If
    End Sub

    Private Sub InsertData_Click(sender As Object, e As EventArgs) Handles InsertData.Click
        ' Display an OpenFileDialog to allow the user to select a CSV file
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        openFileDialog1.Title = "Select a CSV File"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Read the selected CSV file into a DataTable
            dt = New DataTable()
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

            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = dt

            ' Save the DataTable to a file or database
            ' ...
        End If
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
        Dim form7 As New Form7()
        form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form9 As New Form9()
        form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form11 As New Form11()
        form11.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Refresh()
    End Sub

End Class