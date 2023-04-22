Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Security.Cryptography

Public Class RegisterForm
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'HIDE THE TEXT OF THE TextBox3 ON THE FIRST LOAD
        password.UseSystemPasswordChar = True
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Try
            Call Connect_to_DB()

            Dim query As String = "INSERT INTO users (fname, lname, username, email, user_password, user_role) VALUES (@first_name, @last_name, @username, @email, @password, @role)"

            Using mycmd As New MySqlCommand(query, myconn)
                mycmd.Parameters.AddWithValue("@first_name", fname.Text)
                mycmd.Parameters.AddWithValue("@last_name", lname.Text)
                mycmd.Parameters.AddWithValue("@username", username.Text)
                mycmd.Parameters.AddWithValue("@email", email.Text)
                mycmd.Parameters.AddWithValue("@password", password.Text)
                mycmd.Parameters.AddWithValue("@role", "renter")
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Welcome to EasyRent!", "Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                UserProfile.Show()
            End Using

        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If CheckBox1.CheckState = CheckState.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Blue
    End Sub
    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim form1 As New Form1()

        form1.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim form1 As New Form1()
        form1.Show()
    End Sub
End Class