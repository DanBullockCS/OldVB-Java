Public Class MainMenu
    'Daniel Bullock
    'Main Menu Form
    ' __  __ _       _                                  
    '|  \/  (_)_ __ (_)       __ _  __ _ _ __ ___   ___ 
    '| |\/| | | '_ \| |_____ / _` |/ _` | '_ ` _ \ / _ \
    '| |  | | | | | | |_____| (_| | (_| | | | | | |  __/
    '|_|  |_|_|_| |_|_|      \__, |\__,_|_| |_| |_|\___|
    '                        |___/                      
    '  ____ _                _ _   
    ' / ___(_)_ __ ___ _   _(_) |_ 
    '| |   | | '__/ __| | | | | __|
    '| |___| | | | (__| |_| | | |_ 
    ' \____|_|_|  \___|\__,_|_|\__|

    Public PlayerName As String 'The Players Name

    Private Sub lblGame2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGame2.Click
        Game2.Show()
        Me.Visible = False
    End Sub

    Private Sub lblGame3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGame3.Click
        Game3.Show()
        Me.Visible = False
    End Sub

    Private Sub lblGame4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGame4.Click
        Game4.Show()
        Me.Visible = False
    End Sub

    Private Sub lblHowToPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHowToPlay.Click
        HowToPlay.Show()
        Me.Visible = False
    End Sub

    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub lblScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblScores.Click
        Scores.Show()
        Me.Visible = False
    End Sub

#Region "Brackets"
    Private Sub lblGame2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGame2.MouseLeave
        picBracketGame2L.Visible = False
        picBracketGame2R.Visible = False
    End Sub

    Private Sub lblGame2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblGame2.MouseMove
        picBracketGame2L.Visible = True
        picBracketGame2R.Visible = True
    End Sub

    Private Sub lblGame3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGame3.MouseLeave
        picBracketGame3L.Visible = False
        picBracketGame3R.Visible = False
    End Sub

    Private Sub lblGame3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblGame3.MouseMove
        picBracketGame3L.Visible = True
        picBracketGame3R.Visible = True
    End Sub

    Private Sub lblGame4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGame4.MouseLeave
        picBracketGame4L.Visible = False
        picBracketGame4R.Visible = False
    End Sub

    Private Sub lblGame4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblGame4.MouseMove
        picBracketGame4L.Visible = True
        picBracketGame4R.Visible = True
    End Sub

    Private Sub lblExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblExit.MouseLeave
        picBracketExitL.Visible = False
        picBracketExitR.Visible = False
    End Sub

    Private Sub lblExit_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblExit.MouseMove
        picBracketExitL.Visible = True
        picBracketExitR.Visible = True
    End Sub

    Private Sub lblHowToPlay_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblHowToPlay.MouseLeave
        picBracketHowToPlayL.Visible = False
        picBracketHowToPlayR.Visible = False
    End Sub

    Private Sub lblHowToPlay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHowToPlay.MouseMove
        picBracketHowToPlayL.Visible = True
        picBracketHowToPlayR.Visible = True
    End Sub

    Private Sub lblScores_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblScores.MouseLeave
        picBracketScoresL.Visible = False
        picBracketScoresR.Visible = False
    End Sub

    Private Sub lblScores_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblScores.MouseMove
        picBracketScoresL.Visible = True
        picBracketScoresR.Visible = True
    End Sub
#End Region

    Private Sub MainMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.Background_Music, AudioPlayMode.BackgroundLoop) 'Background music
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Me.txtName.Text = Nothing Then
            MessageBox.Show("Please enter your name") 'Make sure the player enters their name
        ElseIf Me.txtName.Text <> Nothing Then
            PlayerName = Me.txtName.Text    'Add the name to the variable and let them start the games.
            Me.lblGame2.Enabled = True
            Me.lblGame3.Enabled = True
            Me.lblGame4.Enabled = True
            Me.txtName.Enabled = False
        End If
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyValue = Keys.Enter Then 'Let the user press the enter button after entering their name if they wish.
            btnOk.PerformClick()
        End If
    End Sub
End Class