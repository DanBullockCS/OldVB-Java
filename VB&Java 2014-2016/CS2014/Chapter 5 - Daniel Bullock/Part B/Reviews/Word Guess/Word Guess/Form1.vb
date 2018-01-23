Public Class Form1
    'Daniel Bullock

    Private Sub btnPlayGame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayGame.Click
        Const SECRET_WORD As String = "VELOCITY"
        Const FLAG As Char = "!"
        Const GUESS_PROMPT As String = "Enter a letter or " & FLAG & " to guess word:"
        Dim numGuesses As Integer = 0
        Dim numPoints As Integer = 100
        Dim letterGuess As Char
        Dim wordGuess As String
        Dim tempWord As String
        Dim endGame As Boolean

        'Set number of dashes as letters in SECRET_WORD
        Dim wordGuessedSoFar As String = ""
        Dim length As Integer = SECRET_WORD.Length
        wordGuessedSoFar = wordGuessedSoFar.PadLeft(length, "-")
        Me.lblSecretWord.Text = wordGuessedSoFar            'initialize game

        'Get first guess
        Dim tempLetterGuess = InputBox(GUESS_PROMPT, Me.Text)
        'Test data entered
        If tempLetterGuess = Nothing Then
            endGame = True
        Else
            letterGuess = tempLetterGuess
        End If

        Do While letterGuess <> FLAG And wordGuessedSoFar <> SECRET_WORD And Not endGame
            numGuesses += 1
            numPoints -= 10
            For letterPos As Integer = 0 To SECRET_WORD.Length - 1
                If SECRET_WORD.Chars(letterPos) = Char.ToUpper(letterGuess) Then
                    'Remove dash at position of letter guessed
                    tempWord = wordGuessedSoFar.Remove(letterPos, 1)
                    'Insert guessed letter
                    wordGuessedSoFar = tempWord.Insert(letterPos, Char.ToUpper(letterGuess))
                    'Update interface
                    Me.lblSecretWord.Text = wordGuessedSoFar
                End If
            Next letterPos
            'Get next letter if word hasen't been guessed
            If wordGuessedSoFar <> SECRET_WORD Then
                'Get user guess
                tempLetterGuess = InputBox(GUESS_PROMPT, Me.Text)
                'Test data entered
                If tempLetterGuess = "" Then
                    endGame = True
                Else
                    letterGuess = tempLetterGuess
                End If
            End If
        Loop

        If wordGuessedSoFar = SECRET_WORD Then
            MessageBox.Show("You guessed it in " & numGuesses & " guesses!")

        ElseIf letterGuess = FLAG Then
            wordGuess = InputBox("Enter a word: ", Me.Text)
            If wordGuess.ToUpper = SECRET_WORD Then
                MessageBox.Show("You guessed it in " & numGuesses & " guesses!")
                Me.lblSecretWord.Text = SECRET_WORD

            Else
                MessageBox.Show("Sorry you lose.")
            End If
        Else
            MessageBox.Show("Game over.")
        End If

        If numPoints = 0 Then
            endGame = True
        End If

        Me.lblScore.Text = "You have: " & numPoints & " points!"
    End Sub




End Class
