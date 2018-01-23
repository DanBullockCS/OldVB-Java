'WordGuessII
'Chapter 11 case study
'Lawrenceville Press
'February 16, 2011

Imports System.IO

Public Class Form1

    Private Sub btnPlayGame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayGame.Click
        Const FLAG As Char = "!"
        Const GUESS_PROMPT As String = "Enter a letter or " & FLAG & " to guess word:"
        Dim numGuesses As Integer = 0
        Dim letterGuess As Char
        Dim wordGuess As String
        Dim tempWord As String
        Dim endGame As Boolean

        'Get secret word
        Dim secretWord As String = RandomSecretWord()
        secretWord = secretWord.ToUpper

        'Set number of dashes as letters in SECRETWORD
        Dim wordGuessedSoFar As String = ""
        Dim length As Integer = secretWord.Length
        wordGuessedSoFar = wordGuessedSoFar.PadLeft(length, "-")
        Me.lblSecretWord.Text = wordGuessedSoFar          'initialize game

        'Get first guess
        Dim tempLetterGuess = InputBox(GUESS_PROMPT, Me.Text)
        'Test data entered
        If tempLetterGuess = Nothing Then
            endGame = True
        Else
            letterGuess = tempLetterGuess
        End If

        Do While letterGuess <> FLAG And wordGuessedSoFar <> secretWord And Not endGame
            numGuesses += 1
            For letterPos As Integer = 0 To secretWord.Length - 1
                If secretWord.Chars(letterPos) = Char.ToUpper(letterGuess) Then
                    'Remove dash at position of letter guessed
                    tempWord = wordGuessedSoFar.Remove(letterPos, 1)
                    'Insert guessed letter
                    wordGuessedSoFar = tempWord.Insert(letterPos, Char.ToUpper(letterGuess))
                    'Update interface
                    Me.lblSecretWord.Text = wordGuessedSoFar
                End If
            Next letterPos

            'Get next letter if word hasn't been guessed
            If wordGuessedSoFar <> secretWord Then
                'Get user guess
                tempLetterGuess = InputBox(GUESS_PROMPT, Me.Text)
                'Test data entered
                If tempLetterGuess = Nothing Then
                    endGame = True
                Else
                    letterGuess = tempLetterGuess
                End If
            End If
        Loop

        If wordGuessedSoFar = secretWord Then
            MessageBox.Show("You guessed it in " & numGuesses & " guesses!")
        ElseIf letterGuess = FLAG Then
            wordGuess = InputBox("Enter a word: ", Me.Text)
            If wordGuess.ToUpper = secretWord Then
                MessageBox.Show("You guessed it in " & numGuesses & " guesses!")
                Me.lblSecretWord.Text = secretWord
            Else
                MessageBox.Show("Sorry you lose.")
            End If
        Else
            MessageBox.Show("Game over.")
        End If
    End Sub

    'Reads a random word from a file with 25 words stored one word per line.
    '
    'pre: the file contains one word per line.
    'post: a word has been randomly selected from a file and returned.
    '
    Function RandomSecretWord() As String
        Dim fs As New FileStream("secretwords.txt", FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)

        Randomize()

        'Read word from file
        Dim wordNum As Integer = Int(25 * Rnd())
        For lineNum As Integer = 1 To wordNum - 1
            textFile.ReadLine()
        Next lineNum
        Return textFile.ReadLine    'return word at position intWord

        textFile.Close()
        fs.Close()
    End Function

    Private Sub AddWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddWordToolStripMenuItem.Click
        Dim fileName As String = "secretwords.txt"    'get file name
        Dim fs As New FileStream(fileName, FileMode.Append, FileAccess.Write)
        Dim textFile As New StreamWriter(fs)

        textFile.WriteLine(vbNewLine & InputBox("Enter a new word to add."))  'write Input box contents to file

        textFile.Close()
        fs.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim fileName As String = "secretwords.txt"    'get file name
        Dim fs As New FileStream(fileName, FileMode.Create, FileAccess.Write)
        Dim textFile As New StreamWriter(fs)
        Dim NumOfWords As Integer = 0

        NumOfWords = InputBox("Enter the number of new words to add") 'write Input box contents to file

        For index As Integer = 0 To NumOfWords - 1
            textFile.WriteLine(InputBox("Enter a new word to add"))
        Next

        textFile.Close()
        fs.Close()
    End Sub
End Class
