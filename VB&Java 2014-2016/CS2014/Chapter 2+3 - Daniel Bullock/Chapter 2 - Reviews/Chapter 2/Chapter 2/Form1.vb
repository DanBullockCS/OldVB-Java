Public Class Message

    Private Sub Message_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmileToolStripMenuItem.Click
        Me.lblmessage.Text = "Smile"
    End Sub

    Private Sub HelloWorldToolStripMenuItem_Click_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelloWorldToolStripMenuItem_Click.Click
        Me.lblmessage.Text = "Hello, world!"
    End Sub

    Private Sub lblmessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmessage.Click

    End Sub
End Class
