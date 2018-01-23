Public Class Form1

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radEnglish.Click
        Me.lblGreeting.Text = "Hello, world!"
    End Sub

    Private Sub radSpanish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSpanish.Click
        Me.lblGreeting.Text = "Hola, mundo!"
    End Sub

    Private Sub radFrench_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFrench.Click
        Me.lblGreeting.Text = "Bonjour le monde!"
    End Sub

    Private Sub BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlackToolStripMenuItem.Click
        Me.lblGreeting.ForeColor = Color.Black
    End Sub

    Private Sub RedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedToolStripMenuItem.Click
        Me.lblGreeting.ForeColor = Color.Red
    End Sub

    Private Sub BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        Me.lblGreeting.ForeColor = Color.Blue
    End Sub
End Class
