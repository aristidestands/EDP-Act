Public Class ordservice
    Private Sub btnDineIn_Click(sender As Object, e As EventArgs) Handles btnDineIn.Click
        payment.Show()
        Me.Hide()
    End Sub

    Private Sub btnTakeOut_Click(sender As Object, e As EventArgs) Handles btnTakeOut.Click
        payment.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        payment.Show()
        Me.Hide()
    End Sub

End Class