Public Class Form1
    'Daniel Bullock

    Private Sub tmrAnimateBall_Tick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrAnimateBall.Tick
        Const MAX_IMAGES As Integer = 4
        Static newPosition As Integer = 0
        Static direction As Integer

        Me.picBall.Image = My.Resources.ball0

        If newPosition = 0 Then
            direction = 1
        ElseIf newPosition = MAX_IMAGES - 1 Then
            direction = -1
        End If
        newPosition += direction

        Select Case newPosition
            Case 0
                Me.picBall.Image = My.Resources.ball0
            Case 1
                Me.picBall.Image = My.Resources.ball1
            Case 2
                Me.picBall.Image = My.Resources.ball2
            Case 3
                Me.picBall.Image = My.Resources.ball3
        End Select
    End Sub

End Class
