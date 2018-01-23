Public Class Main_Menu
    'Main Menu Form - Daniel Bullock

    Private Sub Main_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Arcade_Music, AudioPlayMode.BackgroundLoop) 'Start the game with music
    End Sub

    Private Sub picRockPaperScissors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRockPaperScissors.Click
        'Show the Rock paper scissors game and instructions
        RPS.Show()
        MessageBox.Show("Choose a weapon and fight the computer, first to 10 wins, wins!")
        Me.Visible = False
    End Sub

    Private Sub picWhackAMole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picWhackAMole.Click
        'Show whack a mole game
        WhackAMole.Show()
        Me.Visible = False
    End Sub

    Private Sub picSlotMachine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSlotMachine.Click
        'Show slotmachine and instructions
        SlotMachine.Show()
        MessageBox.Show("Press the spin button to pull the lever and get as many tokens as possible!")
        Me.Visible = False
    End Sub

    Private Sub picMathGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMathGame.Click
        'Show math game and instructions
        Math_Game.Show()
        MessageBox.Show("Press the new problem button and answer in the white box, press the check answer button to see if you are right.")
        Me.Visible = False
    End Sub

    Private Sub picSoundBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSoundBoard.Click
        SoundBoard.Show()
        Me.Visible = False
    End Sub

    Private Sub picQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picQuit.Click
        Application.Exit() 'Quit application when blue button is pushed
    End Sub

    Private Sub picRockPaperScissors_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRockPaperScissors.MouseMove
        picArrow1.Visible = True 'Show arrows when the mouse is over the different games
    End Sub

    Private Sub picRockPaperScissors_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRockPaperScissors.MouseLeave
        picArrow1.Visible = False
    End Sub

    Private Sub picWhackAMole_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhackAMole.MouseMove
        picArrow2.Visible = True
    End Sub

    Private Sub picWhackAMole_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picWhackAMole.MouseLeave
        picArrow2.Visible = False
    End Sub

    Private Sub picSlotMachine_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picSlotMachine.MouseMove
        picArrow3.Visible = True
    End Sub

    Private Sub picSlotMachine_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSlotMachine.MouseLeave
        picArrow3.Visible = False
    End Sub

    Private Sub picMathGame_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picMathGame.MouseMove
        picArrow4.Visible = True
    End Sub

    Private Sub picMathGame_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMathGame.MouseLeave
        picArrow4.Visible = False
    End Sub

    Private Sub picQuit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picQuit.MouseMove
        Me.lblClickToQuit.Text = "Click to quit"
    End Sub

    Private Sub picQuit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picQuit.MouseLeave
        Me.lblClickToQuit.Text = Nothing
    End Sub

    Private Sub picMusicStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMusicStart.Click
        'All the code below is for stopping and starting the music when you click on the red buttons on the main menu form. 
        'Also labels appear when you move over the buttons.
        My.Computer.Audio.Play(My.Resources.Arcade_Music, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub picMusicStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMusicStop.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub picMusicStart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMusicStart.MouseLeave
        Me.lblStartMusic.Visible = False
    End Sub

    Private Sub picMusicStart_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picMusicStart.MouseMove
        Me.lblStartMusic.Visible = True
    End Sub

    Private Sub picMusicStop_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMusicStop.MouseLeave
        Me.lblStopMusic.Visible = False
    End Sub

    Private Sub picMusicStop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picMusicStop.MouseMove
        Me.lblStopMusic.Visible = True
    End Sub
End Class
