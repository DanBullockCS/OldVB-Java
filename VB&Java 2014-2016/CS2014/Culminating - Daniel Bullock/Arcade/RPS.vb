Public Class RPS
    'Rock, Paper, Scissors Form - Daniel Bullock

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close() 'Switch between forms
        Main_Menu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Red
    End Sub

    Private Sub btnThrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrow.Click
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

        If Wins = 10 Then 'If you win 10 times the game ends
            MessageBox.Show("You got 10 wins, you win, thanks for playing!")
            Me.Close()
            Main_Menu.Show()
        End If

        If Losses = 10 Then 'If you lose 10 times the game ends
            MessageBox.Show("Sorry the computer won 10 games, you lose, thanks for playing.")
            Me.Close()
            Main_Menu.Show()
        End If

    End Sub

    Private Sub radScissors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radScissors.CheckedChanged
        picScissors.Image = My.Resources.Red_Scissors
        picRock.Image = My.Resources.Rock
        picPaper.Image = My.Resources.Paper
    End Sub

    Private Sub radRock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRock.CheckedChanged
        picRock.Image = My.Resources.Red_Rock
        picPaper.Image = My.Resources.Paper
        picScissors.Image = My.Resources.Scissors
    End Sub

    Private Sub radPaper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPaper.CheckedChanged
        picPaper.Image = My.Resources.Red_Paper
        picRock.Image = My.Resources.Rock
        picScissors.Image = My.Resources.Scissors
    End Sub
End Class