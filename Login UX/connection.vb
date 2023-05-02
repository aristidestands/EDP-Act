Imports System.IO
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Module Connection
    Public myconn As New MySql.Data.MySqlClient.MySqlConnection
    Public myConnectionString As String

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=tj1y9q3tj;" _
                    & "database=edp"

        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()
            'MessageBox.Show("Connection Success!")

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub ExportToExcel(dataGridView As DataGridView)
        If dataGridView IsNot Nothing AndAlso dataGridView.Rows.Count > 0 Then
            ' Create a new workbook and worksheet
            Dim workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Sheet1")

            ' Write column headers to the worksheet
            For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
                worksheet.Cell(1, columnIndex + 1).Value = dataGridView.Columns(columnIndex).HeaderText
            Next

            ' Loop through the rows of the DataGridView and add them to the worksheet
            For rowIndex As Integer = 0 To dataGridView.Rows.Count - 1
                For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
                    worksheet.Cell(rowIndex + 2, columnIndex + 1).Value = If(dataGridView.Rows(rowIndex).Cells(columnIndex).Value IsNot Nothing, dataGridView.Rows(rowIndex).Cells(columnIndex).Value.ToString(), String.Empty)
                Next
            Next

            ' Save the workbook to a file
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (.xlsx)|.xlsx"
            saveFileDialog.DefaultExt = ".xlsx"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim stream As New MemoryStream()
                workbook.SaveAs(stream)
                File.WriteAllBytes(saveFileDialog.FileName, stream.ToArray())
                MessageBox.Show("Data exported to " & saveFileDialog.FileName)
            End If
        Else
            MessageBox.Show("DataGridView is empty")
        End If
    End Sub

End Module
