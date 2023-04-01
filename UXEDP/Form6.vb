Imports MySql.Data.MySqlClient
Public Class Form6
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each control As Control In Controls
            Dim textBox As TextBox = TryCast(control, TextBox)
            If textBox IsNot Nothing Then
                textBox.ReadOnly = True
                AddHandler textBox.Click, AddressOf TextBox_Click
                AddHandler textBox.Leave, AddressOf TextBox_Leave
            End If
        Next
    End Sub
    Private Sub TextBox_Click(sender As Object, e As EventArgs)
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.ReadOnly = False
        textBox.Tag = textBox.Text ' Save the original text
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs)
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.ReadOnly = True
        If textBox.Text <> textBox.Tag?.ToString() Then
            ' The text has changed, save the changes
            MessageBox.Show($"Text changed to {textBox.Text}")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Dim form5 As New CartForm(SelectedItems)
        'form5.Show()
        'Me.Hide()
    End Sub
End Class