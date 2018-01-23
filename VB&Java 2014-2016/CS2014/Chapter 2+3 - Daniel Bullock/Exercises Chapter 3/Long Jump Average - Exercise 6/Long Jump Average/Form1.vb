Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        'Step 1: "Define variables"'
        Dim dblJump1 As Double
        Dim dblJump2 As Double
        Dim dblJump3 As Double
        Dim dblJump4 As Double
        Dim dblAverage As Double
        Dim dblVariable As Double
        'Step 2: move variables into text box'
        dblJump1 = Val(Me.txtboxJump1.Text)
        dblJump2 = Val(Me.txtboxJump2.Text)
        dblJump3 = Val(Me.txtboxJump3.Text)
        dblJump4 = Val(Me.txtboxJump4.Text)
        'Step 3: do calculations
        dblVariable = dblJump1 + dblJump2 + dblJump3 + dblJump4
        dblAverage = dblVariable / 4
        'Step 4: Move variable into label
        Me.lblAnswer.Text = dblAverage
    End Sub

    Private Sub txtboxJump1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxJump1.TextChanged
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub txtboxJump2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxJump2.TextChanged
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub txtboxJump3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxJump3.TextChanged
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub txtboxJump4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxJump4.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
