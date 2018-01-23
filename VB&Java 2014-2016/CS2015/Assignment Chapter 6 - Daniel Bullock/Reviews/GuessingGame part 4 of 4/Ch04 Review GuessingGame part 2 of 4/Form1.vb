'GuessingGame part 4 of 4
'Daniel Bullock

Public Class Form1

    Const MIN As Integer = 1
    Const MAX As Integer = 50

    Private Sub btnCheckGuess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click
        Randomize()
        Static secretNumber As Integer = Int((MAX - MIN + 1) * Rnd() + MIN)
        Dim guess As Integer

        guess = Val(Me.txtPlayerGuess.Text)
        If guess < MIN Or guess > MAX Then
            Me.lblMessage.Text = "Guess out of range."
        ElseIf guess = secretNumber Then            'correct
            Me.lblMessage.Text = "You guessed it!"
        Else
            Call GiveHint(secretNumber, guess)
        End If
    End Sub

    Private Sub txtPlayerGuess_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlayerGuess.TextChanged
        Me.lblMessage.Text = Nothing
    End Sub

    Sub GiveHint(ByVal firstNum As Integer, ByVal secondNum As Integer)
        If firstNum > secondNum Then
            Me.lblMessage.Text = "Too low."
        Else
            Me.lblMessage.Text = "Too high."
        End If
    End Sub
End Class