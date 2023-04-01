Imports MySql.Data.MySqlClient

Public Class Form1
    Public user_name As String
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand
        Dim myreader As MySqlDataReader

        strSQL = "SELECT * FROM users WHERE username = @username AND user_password = md5(@user_password)"
        mycmd.CommandText = strSQL
        mycmd.Parameters.AddWithValue("@username", username_txt.Text)
        mycmd.Parameters.AddWithValue("@user_password", password_txt.Text)
        mycmd.Connection = myconn

        Try
            myreader = mycmd.ExecuteReader()
            If myreader.HasRows Then
                myreader.Read()
                Dim username As String = myreader.GetString("username")
                user_name = username
                Dim userRole As String = myreader.GetString("user_role")
                If userRole = "admin" Then
                    MessageBox.Show("Welcome to EasyRent, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    adminDashboard.Show()
                Else
                    MessageBox.Show("Welcome to EasyRent, " & username & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Form6.Show()
                End If
            Else
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            Call Disconnect_to_DB()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If CheckBox1.CheckState = CheckState.Checked Then
            password_txt.UseSystemPasswordChar = False
        Else
            password_txt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'HIDE THE TEXT OF THE TextBox3 ON THE FIRST LOAD
        password_txt.UseSystemPasswordChar = True
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Blue ' Change the label's color to blue
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Black ' Change the label's color to black
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' Create a new instance of Form2
        Dim form2 As New Form2()

        ' Show Form2 and hide Form1
        form2.Show()
        Me.Hide()
    End Sub
End Class
