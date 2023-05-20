Imports MySql.Data.MySqlClient

Public Class print_data
    ReadOnly cmd As New MySqlCommand

    Private Sub print_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd.Connection = myconn

            cmd.CommandText = $"select * from users;"
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim name = reader.GetString(0)
                Dim pass = reader.GetString(1)

                ' Add a new row to the DataGridView and populate it with the record data
                DataGridView1.Rows.Add(name, pass)
            End While

            reader.Close()
            myconn.Close()


        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ExportToExcel3(DataGridView1, "tandoy.xlxs")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class