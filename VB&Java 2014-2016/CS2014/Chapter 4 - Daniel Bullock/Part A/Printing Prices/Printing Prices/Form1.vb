Public Class Form1

    Private Sub btnPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrice.Click
        Dim Copies As Decimal
        Dim Total As Decimal
        Dim Price As Decimal

        Copies = Val(Me.txtboxCopies.Text)

        If Copies <= 499 Then Price = 0.3
        If Copies <= 749 Then Price = 0.28
        If Copies <= 999 Then Price = 0.27
        If Copies >= 1000 Then Price = 0.25

        Total = Copies * Price

        Me.lblPricePerCopyAnswer.Text = Price
        Me.lblTotalPriceAnswer.Text = Total
    End Sub

    Private Sub txtboxCopies_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxCopies.TextChanged
        Me.lblTotalPriceAnswer.Text = ""
        Me.lblPricePerCopyAnswer.Text = ""
    End Sub
End Class
