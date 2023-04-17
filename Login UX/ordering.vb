Public Class ordering

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        landing.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrdering_Click(sender As Object, e As EventArgs) Handles btnOrdering.Click
        If sender Is btnOrdering Then
            ordservice.Show()
            Me.Hide()
        End If
    End Sub

End Class