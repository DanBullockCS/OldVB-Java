Public Class Form1

    'Daniel Bullock - Version #1

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                tmrRight.Stop()
                tmrUp.Stop()
                tmrDown.Stop()
                tmrLeft.Start()
            Case Keys.Right
                tmrLeft.Stop()
                tmrUp.Stop()
                tmrDown.Stop()
                tmrRight.Start()
            Case Keys.Up
                tmrRight.Stop()
                tmrLeft.Stop()
                tmrDown.Stop()
                tmrUp.Start()
            Case Keys.Down
                tmrRight.Stop()
                tmrLeft.Stop()
                tmrUp.Stop()
                tmrDown.Start()
        End Select
    End Sub

    Private Sub tmrUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUp.Tick
        picMouseCursor.Location = New Point(picMouseCursor.Location.X, picMouseCursor.Location.Y - 8)

        If picMouseCursor.Location.Y < 0 Then
            picMouseCursor.Location = New Point(picMouseCursor.Location.X, 0)
        End If
    End Sub

    Private Sub tmrDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDown.Tick
        picMouseCursor.Location = New Point(picMouseCursor.Location.X, picMouseCursor.Location.Y + 8)

        If picMouseCursor.Location.Y > (Me.Height - picMouseCursor.Height) Then
            picMouseCursor.Location = New Point(picMouseCursor.Location.X, Me.Height - picMouseCursor.Height)
        End If
    End Sub

    Private Sub tmrLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLeft.Tick
        picMouseCursor.Location = New Point(picMouseCursor.Location.X - 8, picMouseCursor.Location.Y)

        If picMouseCursor.Location.X < 0 Then
            picMouseCursor.Location = New Point(0, picMouseCursor.Location.Y)
        End If
    End Sub

    Private Sub tmrRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRight.Tick
        picMouseCursor.Location = New Point(picMouseCursor.Location.X + 8, picMouseCursor.Location.Y)

        If picMouseCursor.Location.X > (Me.Width - picMouseCursor.Width) Then
            picMouseCursor.Location = New Point(Me.Width - picMouseCursor.Width, picMouseCursor.Location.Y)
        End If
    End Sub
End Class
