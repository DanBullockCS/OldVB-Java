Public Class Form1


    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Me.lbl1.Text = "(a + b) + c = a + (b + c)"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Me.lbl1.Text = "a + b = b + a"
    End Sub

    Private Sub CommutativeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommutativeToolStripMenuItem.Click
        Me.lbl1.Text = "a + b = b + a"
    End Sub

    Private Sub AssociativeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssociativeToolStripMenuItem.Click
        Me.lbl1.Text = "(a + b) + c = a + (b + c)"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class