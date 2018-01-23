Public Class Form1

    Private Sub btnPlaceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        
        Dim SandwichPrice As Decimal = 0

        If Me.radbtnSmall.Checked = True Then
            SandwichPrice += 2.5
        ElseIf Me.radbtnLarge.Checked = True Then
            SandwichPrice += 4
        End If

        If Me.chkMustard.Checked = True Then
            SandwichPrice += 0
        End If
        If Me.chkMayonaise.Checked = True Then
            SandwichPrice += 0
        End If
        If Me.chkOnion.Checked = True Then
            SandwichPrice += 0.1
        End If
        If Me.chkLettuce.Checked = True Then
            SandwichPrice += 0.1
        End If
        If Me.chkTomato.Checked = True Then
            SandwichPrice += 0.25
        End If
        If Me.chkCheese.Checked = True Then
            SandwichPrice += 0.5
        End If

        Me.lblTotalPrice.Text = SandwichPrice
    End Sub

    Private Sub chkLettuce_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLettuce.CheckedChanged
        Me.lblTotalPrice.Text = Nothing
    End Sub

    Private Sub chkTomato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTomato.CheckedChanged
        Me.lblTotalPrice.Text = Nothing
    End Sub

    Private Sub chkMustard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMustard.CheckedChanged
        Me.lblTotalPrice.Text = Nothing
    End Sub

    Private Sub chkOnion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOnion.CheckedChanged
        Me.lblTotalPrice.Text = Nothing
    End Sub

    Private Sub chkCheese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheese.CheckedChanged
        Me.lblTotalPrice.Text = Nothing
    End Sub

    Private Sub chkMayonaise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMayonaise.CheckedChanged
        Me.lblTotalPrice.Text = Nothing
    End Sub

    Private Sub radbtnSmall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnSmall.CheckedChanged
        Me.lblTotalPrice.Text = Nothing
    End Sub

    Private Sub radbtnLarge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnLarge.CheckedChanged
        Me.lblTotalPrice.Text = Nothing
    End Sub
End Class
