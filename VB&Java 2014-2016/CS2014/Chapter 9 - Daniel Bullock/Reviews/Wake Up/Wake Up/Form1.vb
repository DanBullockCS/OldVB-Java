Public Class Form1
    'Daniel Bullock

    Private Sub picRooster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRooster.Click
        Static crow As Boolean = False

        crow = Not crow
        If crow Then
            My.Computer.Audio.Play(My.Resources.rooster_crow, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub
End Class
