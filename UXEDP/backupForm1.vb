Imports MySql.Data.MySqlClient
Imports System.IO

Public Class backupForm1
    Private connectionString As String = "server=localhost;userid=root;password=mdbanares;database=rental_db;"
    Private backupPath As String = ""

    Private Sub BrowseLoc_Click(sender As Object, e As EventArgs) Handles BrowseLoc.Click
        Dim folderDialog As New FolderBrowserDialog()
        If folderDialog.ShowDialog() = DialogResult.OK Then
            backupPath = folderDialog.SelectedPath
            TextBox1.Text = backupPath
        End If
    End Sub

    Private Sub BackupBtn_Click(sender As Object, e As EventArgs) Handles BackupBtn.Click
        If String.IsNullOrEmpty(backupPath) Then
            MessageBox.Show("Please select backup location.")
            Return
        End If

        BackupBtn.Enabled = False

        Using conn As New MySqlConnection(connectionString)
            Dim backupFileName As String = String.Format("database-{0}.bak", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"))
            Dim backupFilePath As String = Path.Combine(backupPath, backupFileName)

            Using cmd As New MySqlCommand()
                Using backup As New MySqlBackup(cmd)
                    cmd.Connection = conn
                    conn.Open()

                    backup.ExportToFile(backupFilePath)

                    conn.Close()
                End Using
            End Using
        End Using

        MessageBox.Show("Backup completed successfully.")

        BackupBtn.Enabled = True
    End Sub

    Private Sub ItemsBtn_Click(sender As Object, e As EventArgs) Handles ItemsBtn.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Hide()
    End Sub

    Private Sub CategoriesBtn_Click(sender As Object, e As EventArgs) Handles CategoriesBtn.Click
        Dim form9 As New Form9()
        form9.Show()
        Me.Hide()
    End Sub

    Private Sub UsersBtn_Click(sender As Object, e As EventArgs) Handles UsersBtn.Click
        Dim form10 As New Form10()
        form10.Show()
        Me.Hide()
    End Sub

    Private Sub OrdersBtn_Click(sender As Object, e As EventArgs) Handles OrdersBtn.Click
        Dim form11 As New Form11()
        form11.Show()
        Me.Hide()
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        Dim adminDashboard As New adminDashboard()
        adminDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        Me.Refresh()
    End Sub

    Private Sub backupForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim items() As String = {"Items", "Users", "Orders", "Category Sales"}
        ComboBox1.Items.AddRange(items)
    End Sub
End Class