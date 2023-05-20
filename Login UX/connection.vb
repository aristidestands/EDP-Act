Imports ClosedXML.Excel
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


    Public Sub ExportToExcel3(ByVal dgv As DataGridView, ByVal templatefilenames As String)

        If dgv IsNot Nothing AndAlso dgv.Rows.Count > 0 Then
            Dim workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Sheet1")

            For columnIndex As Integer = 0 To dgv.Columns.Count - 1
                worksheet.Cell(1, columnIndex + 1).Value = dgv.Columns(columnIndex).HeaderText
            Next

            For rowIndex As Integer = 0 To dgv.Rows.Count - 1
                For columnIndex As Integer = 0 To dgv.Columns.Count - 1
                    worksheet.Cell(rowIndex + 2, columnIndex + 1).Value = If(dgv.Rows(rowIndex).Cells(columnIndex).Value IsNot Nothing, dgv.Rows(rowIndex).Cells(columnIndex).Value.ToString(), String.Empty)
                Next
            Next
            Dim templatefilename As String = "example_template.xlsx"
            Dim filePath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExcelTable", templatefilename)
            workbook.SaveAs(filePath)


            MessageBox.Show("Exported to:" & filePath)

        Else
            MessageBox.Show("Empty Data")
        End If

    End Sub

End Module