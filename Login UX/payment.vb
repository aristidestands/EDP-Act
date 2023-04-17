Public Class payment
    Private Sub btnPay_Click(ByVal sender As Object, e As EventArgs) Handles btnPay.Click
        If sender Is btnPay Then
            MsgBox("Payment Successful!")
            ordering.Show()
        End If
    End Sub

End Class