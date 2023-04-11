Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form10

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Call Connect_to_DB()

            ' Create a new DataTable to hold the results
            Dim dt As New DataTable()

            ' Create a SELECT query to retrieve all the records from the "items" table
            Dim query As String = "SELECT * FROM users"

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

    Private Sub InsertData_Click(sender As Object, e As EventArgs) Handles InsertData.Click
        ' Display an OpenFileDialog to allow the user to select a CSV file
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        openFileDialog1.Title = "Select a CSV File"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Call Connect_to_DB()

                ' Read the selected CSV file into a DataTable
                Dim dt As New DataTable()
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

                ' Save the DataTable to the database
                Dim query As String = "INSERT INTO users (fname, lname, username, email, user_password, user_role) VALUES (@fname, @lname, @username, @email, @user_password, @user_role)"
                Using cmd As New MySqlCommand(query, myconn)
                    For Each row As DataRow In dt.Rows
                        cmd.Parameters.Clear()
                        'cmd.Parameters.AddWithValue("@user_id", row("user_id"))
                        cmd.Parameters.AddWithValue("@fname", row("fname"))
                        cmd.Parameters.AddWithValue("@lname", row("lname"))
                        cmd.Parameters.AddWithValue("@username", row("username"))
                        cmd.Parameters.AddWithValue("@email", row("email"))
                        cmd.Parameters.AddWithValue("@user_password", row("user_password"))
                        cmd.Parameters.AddWithValue("@user_role", row("user_role"))
                        cmd.ExecuteNonQuery()
                    Next
                End Using

                ' Display a message box indicating that the data was successfully inserted
                MessageBox.Show("Data inserted to database successfully!")

                ' Reload the data from the database and bind it to the DataGridView control
                dt.Clear()
                Using da As New MySqlDataAdapter("SELECT * FROM users", myconn)
                    da.Fill(dt)
                End Using
                DataGridView1.DataSource = dt

            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)

            Finally
                Disconnect_to_DB()
            End Try
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