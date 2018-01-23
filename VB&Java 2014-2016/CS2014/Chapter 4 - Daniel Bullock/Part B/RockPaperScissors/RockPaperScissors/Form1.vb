Public Class Form1

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        'Define variables
        Const ROCK As Integer = 1
        Const PAPER As Integer = 2
        Const SCISSORS As Integer = 3
        Dim computerThrow As Integer
        Static Wins As Integer = 0
        Static Losses As Integer = 0
        Static Draws As Integer = 0

        'Generate computer throw
        Randomize()
        computerThrow = Int(3 * Rnd() + 1)

        Select Case computerThrow
            Case ROCK
                If Me.radRock.Checked Then
                    Me.lblWinner.Text = "Computer throws Rock. It's a Draw!"  'Rock to rock
                    Draws += 1
                ElseIf Me.radPaper.Checked Then
                    Me.lblWinner.Text = "Computer throws Rock. You win!" 'Rock to paper
                    Wins += 1
                ElseIf Me.radScissors.Checked Then
                    Me.lblWinner.Text = "Computer throws Rock. Computer wins!" 'Rock to scissors
                    Losses += 1
                End If
            Case PAPER
                If Me.radRock.Checked Then
                    Me.lblWinner.Text = "Computer throws Paper. Computer wins!" 'Paper to rock
                    Losses += 1
                ElseIf Me.radPaper.Checked Then
                    Me.lblWinner.Text = "Computer throws Paper. It's a Draw!" 'Paper to paper
                    Draws += 1
                ElseIf Me.radScissors.Checked Then
                    Me.lblWinner.Text = "Computer throws Paper. You win!" 'Paper to scissors
                    Wins += 1
                End If
            Case SCISSORS
                If Me.radRock.Checked Then
                    Me.lblWinner.Text = "Computer throws Scissors. You win!" 'scissors to rock
                    Wins += 1
                ElseIf Me.radPaper.Checked Then
                    Me.lblWinner.Text = "Computer throws Scissors. Computer wins!" 'scissors to paper
                    Losses += 1
                ElseIf Me.radScissors.Checked Then
                    Me.lblWinner.Text = "Computer throws Scissors. It's a Draw!" 'scissors to scissors
                    Draws += 1
                End If
        End Select

        Me.lblWins.Text = "Wins: " & Wins
        Me.lblLosses.Text = "Losses: " & Losses
        Me.lblDraws.Text = "Draws: " & Draws

    End Sub
End Class
