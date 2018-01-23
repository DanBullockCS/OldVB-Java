Imports System.Media
Public Class Form1
    'Daniel Bullock
    Private Sub btnAsterisk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsterisk.Click
        SystemSounds.Asterisk.Play()
    End Sub

    Private Sub btnBeep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeep.Click
        SystemSounds.Beep.Play()
    End Sub

    Private Sub btnExclamation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExclamation.Click
        SystemSounds.Exclamation.Play()
    End Sub

    Private Sub btnHand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHand.Click
        SystemSounds.Hand.Play()
    End Sub

    Private Sub btnQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuestion.Click
        SystemSounds.Question.Play()
    End Sub
End Class
