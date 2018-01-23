Public Class Form1
    Dim x As Integer = 10
    'Step 1: "Define variables"'
    Private Sub btnProc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProc1.Click
        Dim x As Integer = 3
        'Step 2: move variables into text box'
        Me.lblAnswer.Text = x
    End Sub

    Private Sub btnProc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProc2.Click
        Me.lblAnswer.Text = x
        'Step 3: do calculations
        'null
        'Step 4: Move variable into label
        'null
    End Sub
End Class
