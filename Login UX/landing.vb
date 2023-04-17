Imports MySql.Data.MySqlClient

Public Class landing
    Private Sub btnOrdNow_Click(sender As Object, e As EventArgs) Handles btnOrdNow.Click
        ordering.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Close()
        upload.Show()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call Connect_to_DB()
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            myconn.Close()
            MessageBox.Show("Database Successfully Backup!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

    End Sub
End Class

Friend Class MySqlBackup
    Private cmd As MySqlCommand

    Public Sub New(cmd As MySqlCommand)
        Me.cmd = cmd
    End Sub

    Friend Sub ExportToFile(fileName As String)
        Throw New NotImplementedException()
    End Sub
End Class