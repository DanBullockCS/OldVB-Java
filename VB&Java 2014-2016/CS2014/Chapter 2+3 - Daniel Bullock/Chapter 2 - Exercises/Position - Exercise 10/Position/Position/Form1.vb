Public Class Form1

    Private Sub TopLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopLeftToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.TopLeft
    End Sub

    Private Sub TopCenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopCenterToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub TopRightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopRightToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.TopRight
    End Sub

    Private Sub MiddleLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleLeftToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub MiddleCenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleCenterToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub MiddleRightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleRightToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub BottomLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomLeftToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.BottomLeft
    End Sub

    Private Sub BottomCenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomCenterToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.BottomCenter
    End Sub

    Private Sub BottomRightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomRightToolStripMenuItem.Click
        Me.lbl1.TextAlign = ContentAlignment.BottomRight
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
