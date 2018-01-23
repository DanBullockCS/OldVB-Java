Public Class Scores

    Private Sub btnDeleteMoreViruses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteMoreViruses.Click
        Me.Close()
        Form1.Visible = True
        Form1.tmrUp.Start()
        Form1.tmrDown.Start()
        Form1.tmrLeft.Start()
        Form1.tmrRight.Start()
        Form1.tmrNorton.Start()
        Form1.tmrVirus.Start()
    End Sub
End Class