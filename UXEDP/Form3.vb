Public Class Form3

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form6 As New Form6()
        form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Dim form5 As New CartForm(SelectedItems)
        'form5.Show()
        'Me.Hide()
    End Sub
End Class