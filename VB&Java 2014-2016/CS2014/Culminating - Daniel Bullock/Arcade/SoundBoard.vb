Public Class SoundBoard
    'Sound board Form - Daniel Bullock

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close() 'Switch between forms
        Main_Menu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Magenta
    End Sub
    'Play sounds
    Private Sub btnSound1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound1.Click
        My.Computer.Audio.Play(My.Resources.Air_Horn, AudioPlayMode.Background)
    End Sub

    Private Sub btnSound2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound2.Click
        My.Computer.Audio.Play(My.Resources.Iggy_Azalea___Fancy, AudioPlayMode.Background)
    End Sub

    Private Sub btnSound3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound3.Click
        My.Computer.Audio.Play(My.Resources.inceptionbutton, AudioPlayMode.Background)
    End Sub

    Private Sub btnSound4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound4.Click
        My.Computer.Audio.Play(My.Resources.Jaws, AudioPlayMode.Background)
    End Sub

    Private Sub btnSound5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound5.Click
        My.Computer.Audio.Play(My.Resources.Record_Scratch, AudioPlayMode.Background)
    End Sub

    Private Sub btnSound6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound6.Click
        My.Computer.Audio.Play(My.Resources.Victory_Fanfare, AudioPlayMode.Background)
    End Sub

    Private Sub btnSound7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound7.Click
        My.Computer.Audio.Play(My.Resources.Whip, AudioPlayMode.Background)
    End Sub

    Private Sub btnSound8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound8.Click
        My.Computer.Audio.Play(My.Resources._749a13_Ba_Dum_Tss_Sound_Effect, AudioPlayMode.Background)
    End Sub

    Private Sub btnSound9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSound9.Click
        My.Computer.Audio.Play(My.Resources.the_price_is_right_losing_horn, AudioPlayMode.Background)
    End Sub
End Class