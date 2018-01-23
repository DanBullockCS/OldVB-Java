Public Class Form1
    'Daniel Bullock

    Private Sub btnSlow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlow.Click
        tmrSlow.Enabled = True
        tmrAverage.Enabled = False
        tmrFast.Enabled = False
    End Sub

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        tmrSlow.Enabled = False
        tmrAverage.Enabled = True
        tmrFast.Enabled = False
    End Sub

    Private Sub btnFast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFast.Click
        tmrSlow.Enabled = False
        tmrAverage.Enabled = False
        tmrFast.Enabled = True
    End Sub

    Private Sub tmrSlow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSlow.Tick
        Const MAX_IMAGES As Integer = 3
        Static newPosition As Integer = 0
        Static direction As Integer

        Me.picTurtle.Image = My.Resources.turtle1

        If newPosition = 0 Then
            direction = 1
        ElseIf newPosition = MAX_IMAGES - 1 Then
            direction = -1
        End If
        newPosition += direction

        Select Case newPosition
            Case 0
                Me.picTurtle.Image = My.Resources.turtle1
            Case 1
                Me.picTurtle.Image = My.Resources.turtle2
            Case 2
                Me.picTurtle.Image = My.Resources.turtle3
        End Select
    End Sub

    Private Sub tmrAverage_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAverage.Tick
        Const MAX_IMAGES As Integer = 3
        Static newPosition As Integer = 0
        Static direction As Integer

        Me.picTurtle.Image = My.Resources.turtle1

        If newPosition = 0 Then
            direction = 1
        ElseIf newPosition = MAX_IMAGES - 1 Then
            direction = -1
        End If
        newPosition += direction

        Select Case newPosition
            Case 0
                Me.picTurtle.Image = My.Resources.turtle1
            Case 1
                Me.picTurtle.Image = My.Resources.turtle2
            Case 2
                Me.picTurtle.Image = My.Resources.turtle3
        End Select
    End Sub

    Private Sub tmrFast_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFast.Tick
        Const MAX_IMAGES As Integer = 3
        Static newPosition As Integer = 0
        Static direction As Integer

        Me.picTurtle.Image = My.Resources.turtle1

        If newPosition = 0 Then
            direction = 1
        ElseIf newPosition = MAX_IMAGES - 1 Then
            direction = -1
        End If
        newPosition += direction

        Select Case newPosition
            Case 0
                Me.picTurtle.Image = My.Resources.turtle1
            Case 1
                Me.picTurtle.Image = My.Resources.turtle2
            Case 2
                Me.picTurtle.Image = My.Resources.turtle3
        End Select
    End Sub
End Class
