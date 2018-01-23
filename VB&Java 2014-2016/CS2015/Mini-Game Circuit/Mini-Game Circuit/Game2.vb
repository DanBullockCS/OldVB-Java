Public Class Game2
    'Daniel Bullock
    'Game 2 - Tug of War Form

    Dim deciTime As Decimal = 60.0 'Timer as a decimal

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Red
    End Sub

    Private Sub Game2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.A Or Keys.L Then   'Whenever a player starts playing the timer starts
            tmrGameTime.Start()
        End If

        If e.KeyValue = Keys.A And lblRestart.Visible = False Then  'Player 1 pulls left
            picTugOfWar.Left -= 10
        End If
        If e.KeyValue = Keys.L And lblRestart.Visible = False Then  'Player 2 pulls right
            picTugOfWar.Left += 10
        End If

        If picTugOfWar.Location.X > 330 Then    'If player 2 touches the checkered line then player 1 wins
            tmrGameTime.Stop()
            MessageBox.Show("Player 1 Wins!")
            lblRestart.Visible = True
            lblRestart.Enabled = True
        End If

        If picTugOfWar.Location.X < 3 Then      'If player 1 touches the checkered line then player 2 wins
            tmrGameTime.Stop()
            MessageBox.Show("Player 2 Wins!")
            lblRestart.Visible = True
            lblRestart.Enabled = True
        End If
    End Sub

    Private Sub lblRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRestart.Click
        lblRestart.Visible = False
        lblRestart.Enabled = False
        picTugOfWar.Location = New Point(170, 225)  'Start Position
        deciTime = 60.0
    End Sub

    Private Sub lblRestart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRestart.MouseLeave
        lblRestart.BackColor = Color.Transparent
    End Sub

    Private Sub lblRestart_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblRestart.MouseMove
        lblRestart.BackColor = Color.Red
    End Sub

    Private Sub tmrGameTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGameTime.Tick
        deciTime -= 0.01    'timer interval is 1 millisecond so time decreases by 0.01 making it decrease by 1 second per second.
        Me.lblTimeLeft.Text = deciTime

        If Me.lblTimeLeft.Text = "0" Then
            tmrGameTime.Stop()
            MessageBox.Show("It's a tie!")
            lblRestart.Visible = True
            lblRestart.Enabled = True
        End If
    End Sub
End Class