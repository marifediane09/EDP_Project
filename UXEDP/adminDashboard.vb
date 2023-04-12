Imports MySql.Data.MySqlClient
Public Class adminDashboard

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form10 As New Form10()
        form10.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form11 As New Form11()
        form11.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Refresh()
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