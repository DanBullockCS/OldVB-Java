Public Class Form1
    'Define global variables
    Dim PlayerTotal As Integer
    Dim CompTotal As Integer
    Dim PlayerCard1 As Integer
    Dim PlayerCard2 As Integer
    Dim PlayerCard3 As Integer
    Dim CompCard1 As Integer
    Dim CompCard2 As Integer
    Dim CompCard3 As Integer
    Private Sub PlayGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayGameToolStripMenuItem.Click
        Randomize() 'Random function
        'Create random numbers for cards
        Me.lblPlayerCard1.Text = Int(10 * Rnd() + 1)
        Me.lblPlayerCard2.Text = Int(10 * Rnd() + 1)
        Me.lblPlayerCard3.Text = Int(10 * Rnd() + 1)
        Me.lblCompCard1.Text = Int(10 * Rnd() + 1)
        Me.lblCompCard2.Text = Int(10 * Rnd() + 1)
        Me.lblCompCard3.Text = Int(10 * Rnd() + 1)
        'don't show the computers cards and your optional 3rd
        Me.lblCompCard1.Visible = False
        Me.lblCompCard2.Visible = False
        Me.lblCompCard3.Visible = False
        Me.lblPlayerCard3.Visible = False
    End Sub

    Private Sub btnDrawCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawCard.Click
        Me.lblPlayerCard3.Text = Int(10 * Rnd() + 1) 'created optional 3rd card
        Me.lblPlayerCard3.Visible = True 'show that optional 3rd card
        PlayerCard3 = Me.lblPlayerCard3.Text

    End Sub

    Private Sub btnCheckScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckScores.Click
        'Move cards into variables
        PlayerCard1 = Me.lblPlayerCard1.Text
        PlayerCard2 = Me.lblPlayerCard2.Text
        CompCard1 = Me.lblCompCard1.Text
        CompCard2 = Me.lblCompCard2.Text
        CompCard3 = Me.lblCompCard3.Text
        'show computers cards
        Me.lblCompCard1.Visible = True
        Me.lblCompCard2.Visible = True
        Me.lblCompCard3.Visible = True
        'Add cards into total
        PlayerTotal = PlayerCard1 + PlayerCard2 + PlayerCard3
        CompTotal = CompCard1 + CompCard2 + CompCard3
        'Move total labels into total variables
        Me.lblPlayersScore.Text = PlayerTotal
        Me.lblCompsScore.Text = CompTotal
        'If statements of possible outcomes
        If PlayerTotal < 21 And PlayerTotal > CompTotal Then
            MessageBox.Show("Player wins.")
        ElseIf CompTotal > 21 And PlayerTotal < 21 Then
            MessageBox.Show("Player wins.")
        ElseIf CompTotal > 21 And CompTotal < 21 Then
            MessageBox.Show("Player wins.")
        ElseIf PlayerTotal = 21 And CompTotal <> 21 Then
            MessageBox.Show("Player wins.")
        ElseIf CompTotal < 21 And CompTotal > PlayerTotal Then
            MessageBox.Show("Computer wins.")
        ElseIf PlayerTotal > 21 And CompTotal < 21 Then
            MessageBox.Show("Computer wins.")
        ElseIf CompTotal = 21 And PlayerTotal <> 21 Then
            MessageBox.Show("Computer wins.")
        ElseIf CompTotal = PlayerTotal Then
            MessageBox.Show("Draw.")
        ElseIf PlayerTotal > 21 And CompTotal > 21 Then
            MessageBox.Show("Draw.")
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit() 'Close application
    End Sub
End Class
