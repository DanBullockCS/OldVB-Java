Public Class Form1
    'Daniel Bullock

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        tmrGreen.Enabled = True
        tmrRed.Enabled = False
        Me.BackColor = Color.Green
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrRed.Enabled = True
        tmrGreen.Enabled = False
        Me.BackColor = Color.Red
    End Sub

    Private Sub tmrGreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGreen.Tick
        If Me.BackColor = Color.Green Then
            Me.BackColor = Color.Lime
        Else
            Me.BackColor = Color.Green
        End If
    End Sub

    Private Sub tmrRed_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRed.Tick
        If Me.BackColor = Color.Red Then
            Me.BackColor = Color.DarkRed
        Else
            Me.BackColor = Color.Red
        End If
    End Sub
End Class
