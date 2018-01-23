Public Class Form1
    'Daniel Bullock

    Private Sub PictureBoxRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxRed.Click
        Me.BackgroundImage = My.Resources.red
    End Sub

    Private Sub PictureBoxPink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxPink.Click
        Me.BackgroundImage = My.Resources.pink
    End Sub

    Private Sub PictureBoxOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxOrange.Click
        Me.BackgroundImage = My.Resources.orange
    End Sub

    Private Sub PictureBoxGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxGreen.Click
        Me.BackgroundImage = My.Resources.green
    End Sub
End Class
