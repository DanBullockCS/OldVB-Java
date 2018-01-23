Public Class HowToPlay
    'Daniel Bullock
    'How To Play Form

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Cyan
    End Sub
End Class