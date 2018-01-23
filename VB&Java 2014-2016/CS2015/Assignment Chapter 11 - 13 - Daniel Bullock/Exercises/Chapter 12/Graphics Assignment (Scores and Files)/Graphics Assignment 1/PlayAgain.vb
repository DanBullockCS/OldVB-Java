Public Class PlayAgain
    'Daniel Bullock
    'Play Again Form

    Private Sub btnDeleteMoreViruses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteMoreViruses.Click
        Me.Close()
        Form1.Show()
        Form1.tmrUp.Start()
        Form1.tmrDown.Start()
        Form1.tmrLeft.Start()
        Form1.tmrRight.Start()
        Form1.tmrNorton.Start()
        Form1.tmrVirus.Start()
        Form1.picMouseCursor.Location = New Point(464, 245) 'Return mouse to center position
        Form1.intPlay = 16
        Form1.LifeCounter = 10
        'For some reason the timer starts at minus one what I put it as when I play again, so this fixes it.
    End Sub

    Private Sub btnNope_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNope.Click
        Application.Exit()
    End Sub
End Class