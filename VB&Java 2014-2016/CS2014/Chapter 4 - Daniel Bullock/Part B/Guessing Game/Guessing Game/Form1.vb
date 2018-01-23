Public Class Form1
    'Define Constants
    Const MIN As Integer = 1
    Const MAX As Integer = 50

    Private Sub btnCheckGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click
        Randomize()
        'Define variables
        Static secretNumber As Integer = Int((MAX - MIN + 1) * Rnd() + MIN)
        Dim guess As Integer

        guess = Val(Me.txtboxPlayerGuess.Text)
        If guess < MIN Or guess > MAX Then       'invalid guess
            MessageBox.Show("Guess out of range.")
        ElseIf guess = secretNumber Then
            Me.lblMessage.Text = "You guessed it!" 'Correct Answer
        ElseIf guess < secretNumber Then
            Me.lblMessage.Text = "Too low" 'Answer too low
        ElseIf guess > secretNumber Then
            Me.lblMessage.Text = "Too high" 'Answer too high
        End If
    End Sub

    Private Sub txtboxPlayerGuess_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxPlayerGuess.TextChanged
        'Text Changed label
        Me.lblMessage.Text = ""
    End Sub
End Class
