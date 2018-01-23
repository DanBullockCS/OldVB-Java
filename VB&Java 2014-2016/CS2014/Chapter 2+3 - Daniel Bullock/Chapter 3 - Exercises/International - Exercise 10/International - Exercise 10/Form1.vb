Public Class Form1
    'NOTE: tooltips are created by the tool they are attached to.
    Private Sub radFrench_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFrench.Click
        Me.lblMyNameIs.Text = "Mon nom est:"
    End Sub

    Private Sub radSpanish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSpanish.Click
        Me.lblMyNameIs.Text = "Mi nombre es:"
    End Sub

    Private Sub radEnglish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radEnglish.Click
        Me.lblMyNameIs.Text = "My name is:"
    End Sub
End Class