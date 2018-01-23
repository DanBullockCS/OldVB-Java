Public Class Form1
    'Daniel Bullock

    Private Sub btnCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat.Click
        Me.lblSentence.Text = Me.lblSentence.Text & " " & "cat"
        My.Computer.Audio.Play(My.Resources.word_cat, AudioPlayMode.Background)
    End Sub

    Private Sub btnDog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDog.Click
        Me.lblSentence.Text = Me.lblSentence.Text & " " & "dog"
        My.Computer.Audio.Play(My.Resources.word_dog, AudioPlayMode.Background)
    End Sub

    Private Sub btnFluffy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFluffy.Click
        Me.lblSentence.Text = Me.lblSentence.Text & " " & "fluffy"
        My.Computer.Audio.Play(My.Resources.word_fluffy, AudioPlayMode.Background)
    End Sub

    Private Sub btnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnI.Click
        Me.lblSentence.Text = Me.lblSentence.Text & " " & "I"
        My.Computer.Audio.Play(My.Resources.word_I, AudioPlayMode.Background)
    End Sub

    Private Sub btnSee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSee.Click
        Me.lblSentence.Text = Me.lblSentence.Text & " " & "see"
        My.Computer.Audio.Play(My.Resources.word_see, AudioPlayMode.Background)
    End Sub

    Private Sub btnThe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThe.Click
        Me.lblSentence.Text = Me.lblSentence.Text & " " & "the"
        My.Computer.Audio.Play(My.Resources.word_the, AudioPlayMode.Background)
    End Sub

    Private Sub btnIs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIs.Click
        Me.lblSentence.Text = Me.lblSentence.Text & " " & "is"
        My.Computer.Audio.Play(My.Resources.word_is, AudioPlayMode.Background)
    End Sub

    Private Sub btnWalk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWalk.Click
        Me.lblSentence.Text = Me.lblSentence.Text & " " & "walk"
        My.Computer.Audio.Play(My.Resources.word_walk, AudioPlayMode.Background)
    End Sub

End Class
