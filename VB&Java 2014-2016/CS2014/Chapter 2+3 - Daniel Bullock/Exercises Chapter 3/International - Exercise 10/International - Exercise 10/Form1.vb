Public Class Form1

    Private Sub radFrench_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFrench.Click
        Me.lblMyNameIs.Text = "Mon nom est:"
    End Sub

    Private Sub radSpanish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSpanish.Click
        Me.lblMyNameIs.Text = "Mi nombre es:"
    End Sub

    Private Sub radEnglish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radEnglish.Click
        Me.lblMyNameIs.Text = "My name is:"
    End Sub

    Private Sub radFrench_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFrench.MouseHover
        Me.ToolTipFrench.ToolTipTitle = "Display the text in french."
    End Sub

    Private Sub radSpanish_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSpanish.MouseHover

    End Sub

    Private Sub radEnglish_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles radEnglish.MouseHover

    End Sub
End Class