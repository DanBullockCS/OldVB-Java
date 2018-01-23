Public Class Form1
    'Daniel Bullock

    Dim Tokens As Integer = 100
    Private Sub btnPull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPull.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim number3 As Integer

        Tokens -= 1
        Me.lblTokens.Text = Tokens

        Randomize()

        number1 = Int(3 * Rnd() + 1)
        number2 = Int(3 * Rnd() + 1)
        number3 = Int(3 * Rnd() + 1)
        Me.lblNum1.Text = number1
        Me.lblNum2.Text = number2
        Me.lblNum3.Text = number3

        If number1 = 1 And number2 = 1 And number3 = 1 Then
            Tokens += 4
            MessageBox.Show("You get 4 tokens!")
        ElseIf number1 = 2 And number2 = 2 And number3 = 2 Then
            Tokens += 8
            MessageBox.Show("You get 8 tokens!")
        ElseIf number1 = 3 And number2 = 3 And number3 = 3 Then
            Tokens += 12
            MessageBox.Show("You get 12 tokens!")
        Else
            MessageBox.Show("You Lost")
        End If

        If Me.lblTokens.Text = 0 Then
            Application.Exit()
        End If
    End Sub
End Class
