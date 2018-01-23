Public Class Form1

    'Daniel Bullock - Version #2

    Dim LifeCounter As Integer = 10
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
        picMouseCursor.Location = New Point(picMouseCursor.Location.X, picMouseCursor.Location.Y - 6)

        If picMouseCursor.Location.Y < 0 Then
            picMouseCursor.Location = New Point(picMouseCursor.Location.X, 0)
        End If
    End Sub

    Private Sub tmrDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDown.Tick
        picMouseCursor.Location = New Point(picMouseCursor.Location.X, picMouseCursor.Location.Y + 6)

        If picMouseCursor.Location.Y > (Me.Height - picMouseCursor.Height) Then
            picMouseCursor.Location = New Point(picMouseCursor.Location.X, Me.Height - picMouseCursor.Height)
        End If
    End Sub

    Private Sub tmrLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLeft.Tick
        picMouseCursor.Location = New Point(picMouseCursor.Location.X - 6, picMouseCursor.Location.Y)

        If picMouseCursor.Location.X < 0 Then
            picMouseCursor.Location = New Point(0, picMouseCursor.Location.Y)
        End If
    End Sub

    Private Sub tmrRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRight.Tick
        picMouseCursor.Location = New Point(picMouseCursor.Location.X + 6, picMouseCursor.Location.Y)

        If picMouseCursor.Location.X > (Me.Width - picMouseCursor.Width) Then
            picMouseCursor.Location = New Point(Me.Width - picMouseCursor.Width, picMouseCursor.Location.Y)
        End If
    End Sub

    Private Sub tmrVirus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrVirus.Tick
        Randomize()

        If PicVirus.Location.X > picMouseCursor.Location.X Then
            PicVirus.Location = New Point(PicVirus.Location.X - 4, PicVirus.Location.Y)
        Else
            PicVirus.Location = New Point(PicVirus.Location.X + 4, PicVirus.Location.Y)
        End If

        If PicVirus.Location.Y > picMouseCursor.Location.Y Then
            PicVirus.Location = New Point(PicVirus.Location.X, PicVirus.Location.Y - 4)
        Else
            PicVirus.Location = New Point(PicVirus.Location.X, PicVirus.Location.Y + 4)
        End If

        Dim intMouseCursorX As Integer
        Dim intMouseCursorY As Integer
        Dim intVirusX As Integer
        Dim intVirusY As Integer
        Dim intOffX As Integer
        Dim intOffY As Integer

        Me.lblSecurityLevelNumber.Text = LifeCounter

        intMouseCursorX = (picMouseCursor.Location.X + picMouseCursor.Width) \ 2
        intMouseCursorY = (picMouseCursor.Location.Y + picMouseCursor.Height) \ 2

        intVirusX = (PicVirus.Location.X + PicVirus.Width) \ 2
        intVirusY = (PicVirus.Location.Y + PicVirus.Height) \ 2

        If (intVirusX < intMouseCursorX + 30 And intVirusX > intMouseCursorX - 30) And (intVirusY < intMouseCursorY + 30 And intVirusY > intMouseCursorY - 30) Then

            LifeCounter = LifeCounter - 1

            lblSecurityLevelNumber.Text = LifeCounter

            Do
                intOffX = Int(Rnd() * 3 * Me.Width) - Me.Width
            Loop While intOffX > 0 And intOffX < Me.Width
            Do
                intOffY = Int(Rnd() * 3 * Me.Height) - Me.Height
            Loop While intOffY > 0 And intOffY < Me.Height

            PicVirus.Location = New Point(intOffX, intOffY)

        End If

        If Me.lblSecurityLevelNumber.Text = 0 Then
            Application.Exit()
        End If
    End Sub
    
End Class
