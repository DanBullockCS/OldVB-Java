Public Class Game4
    'Daniel Bullock
    'Game 4 - Count Form

    Dim intQuestion As Integer 'The amount of questions asked.
    Dim intAnswer As String 'The number that is the answer (number of that specific shape and colour).
    Dim PlayerAnswer As String 'Players answer.
    Dim intCorrect As Integer = 0 'How many answers were correct counter.
    Dim intIncorrect As Integer = 0 'How many answers were incorrect counter.

    Dim RScount As Integer = 0 'Example Red Square count, this integer is to add
    Dim RCcount As Integer = 0 '1 whenever there is a red square on the picture boxes
    Dim RTcount As Integer = 0
    Dim BScount As Integer = 0
    Dim BCcount As Integer = 0
    Dim BTcount As Integer = 0
    Dim YScount As Integer = 0
    Dim YCcount As Integer = 0
    Dim YTcount As Integer = 0

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub

#Region "Label Colours"
    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        Me.lblBackToMenu.BackColor = Color.White
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        Me.lblBackToMenu.BackColor = Color.Orange
    End Sub

    Private Sub lblStart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStart.MouseLeave
        Me.lblStart.BackColor = Color.White
    End Sub

    Private Sub lblStart_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblStart.MouseMove
        Me.lblStart.BackColor = Color.Orange
    End Sub

    Private Sub lblCurtainDown_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCurtainDown.MouseLeave
        Me.lblCurtainDown.BackColor = Color.White
    End Sub

    Private Sub lblCurtainDown_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCurtainDown.MouseMove
        Me.lblCurtainDown.BackColor = Color.Orange
    End Sub
#End Region

    Private Sub lblStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.Click
        tmrStartGame.Start()   'When game starts the curtain lifts
        Me.lblStart.Enabled = False
        Me.lblStart.Visible = False
        Dim Shape1Number As Integer = Int(9 * Rnd() + 1)
        Dim Shape2Number As Integer = Int(9 * Rnd() + 1)
        Dim Shape3Number As Integer = Int(9 * Rnd() + 1)
        Dim Shape4Number As Integer = Int(9 * Rnd() + 1)
        Dim Shape5Number As Integer = Int(9 * Rnd() + 1)
        Dim Shape6Number As Integer = Int(9 * Rnd() + 1)
        Dim Shape7Number As Integer = Int(9 * Rnd() + 1)
        Dim Shape8Number As Integer = Int(9 * Rnd() + 1)
        RScount = 0
        RCcount = 0
        RTcount = 0
        BScount = 0
        BCcount = 0
        BTcount = 0
        YScount = 0
        YCcount = 0
        YTcount = 0

        'Each If statement is for each picture box generating a new random picture of the 9 pictures
        'Each counter counts how many of that shape and colour there is for the answer in the end

        If Shape1Number = 1 Then
            picShape1.BackgroundImage = My.Resources.Red_Square
            RScount += 1
        ElseIf Shape1Number = 2 Then
            picShape1.BackgroundImage = My.Resources.Red_Circle
            RCcount += 1
        ElseIf Shape1Number = 3 Then
            picShape1.BackgroundImage = My.Resources.Red_Triangle
            RTcount += 1
        ElseIf Shape1Number = 4 Then
            picShape1.BackgroundImage = My.Resources.Blue_Square
            BScount += 1
        ElseIf Shape1Number = 5 Then
            picShape1.BackgroundImage = My.Resources.Blue_Circle
            BCcount += 1
        ElseIf Shape1Number = 6 Then
            picShape1.BackgroundImage = My.Resources.Blue_Triangle
            BTcount += 1
        ElseIf Shape1Number = 7 Then
            picShape1.BackgroundImage = My.Resources.Yellow_Square
            YScount += 1
        ElseIf Shape1Number = 8 Then
            picShape1.BackgroundImage = My.Resources.Yellow_Circle
            YCcount += 1
        ElseIf Shape1Number = 9 Then
            picShape1.BackgroundImage = My.Resources.Yellow_Triangle
            YTcount += 1
        End If

        If Shape2Number = 1 Then
            picShape2.BackgroundImage = My.Resources.Red_Square
            RScount += 1
        ElseIf Shape2Number = 2 Then
            picShape2.BackgroundImage = My.Resources.Red_Circle
            RCcount += 1
        ElseIf Shape2Number = 3 Then
            picShape2.BackgroundImage = My.Resources.Red_Triangle
            RTcount += 1
        ElseIf Shape2Number = 4 Then
            picShape2.BackgroundImage = My.Resources.Blue_Square
            BScount += 1
        ElseIf Shape2Number = 5 Then
            picShape2.BackgroundImage = My.Resources.Blue_Circle
            BCcount += 1
        ElseIf Shape2Number = 6 Then
            picShape2.BackgroundImage = My.Resources.Blue_Triangle
            BTcount += 1
        ElseIf Shape2Number = 7 Then
            picShape2.BackgroundImage = My.Resources.Yellow_Square
            YScount += 1
        ElseIf Shape2Number = 8 Then
            picShape2.BackgroundImage = My.Resources.Yellow_Circle
            YCcount += 1
        ElseIf Shape2Number = 9 Then
            picShape2.BackgroundImage = My.Resources.Yellow_Triangle
            YTcount += 1
        End If

        If Shape3Number = 1 Then
            picShape3.BackgroundImage = My.Resources.Red_Square
            RScount += 1
        ElseIf Shape3Number = 2 Then
            picShape3.BackgroundImage = My.Resources.Red_Circle
            RCcount += 1
        ElseIf Shape3Number = 3 Then
            picShape3.BackgroundImage = My.Resources.Red_Triangle
            RTcount += 1
        ElseIf Shape3Number = 4 Then
            picShape3.BackgroundImage = My.Resources.Blue_Square
            BScount += 1
        ElseIf Shape3Number = 5 Then
            picShape3.BackgroundImage = My.Resources.Blue_Circle
            BCcount += 1
        ElseIf Shape3Number = 6 Then
            picShape3.BackgroundImage = My.Resources.Blue_Triangle
            BTcount += 1
        ElseIf Shape3Number = 7 Then
            picShape3.BackgroundImage = My.Resources.Yellow_Square
            YScount += 1
        ElseIf Shape3Number = 8 Then
            picShape3.BackgroundImage = My.Resources.Yellow_Circle
            YCcount += 1
        ElseIf Shape3Number = 9 Then
            picShape3.BackgroundImage = My.Resources.Yellow_Triangle
            YTcount += 1
        End If

        If Shape4Number = 1 Then
            picShape4.BackgroundImage = My.Resources.Red_Square
            RScount += 1
        ElseIf Shape4Number = 2 Then
            picShape4.BackgroundImage = My.Resources.Red_Circle
            RCcount += 1
        ElseIf Shape4Number = 3 Then
            picShape4.BackgroundImage = My.Resources.Red_Triangle
            RTcount += 1
        ElseIf Shape4Number = 4 Then
            picShape4.BackgroundImage = My.Resources.Blue_Square
            BScount += 1
        ElseIf Shape4Number = 5 Then
            picShape4.BackgroundImage = My.Resources.Blue_Circle
            BCcount += 1
        ElseIf Shape4Number = 6 Then
            picShape4.BackgroundImage = My.Resources.Blue_Triangle
            BTcount += 1
        ElseIf Shape4Number = 7 Then
            picShape4.BackgroundImage = My.Resources.Yellow_Square
            YScount += 1
        ElseIf Shape4Number = 8 Then
            picShape4.BackgroundImage = My.Resources.Yellow_Circle
            YCcount += 1
        ElseIf Shape4Number = 9 Then
            picShape4.BackgroundImage = My.Resources.Yellow_Triangle
            YTcount += 1
        End If

        If Shape5Number = 1 Then
            picShape5.BackgroundImage = My.Resources.Red_Square
            RScount += 1
        ElseIf Shape5Number = 2 Then
            picShape5.BackgroundImage = My.Resources.Red_Circle
            RCcount += 1
        ElseIf Shape5Number = 3 Then
            picShape5.BackgroundImage = My.Resources.Red_Triangle
            RTcount += 1
        ElseIf Shape5Number = 4 Then
            picShape5.BackgroundImage = My.Resources.Blue_Square
            BScount += 1
        ElseIf Shape5Number = 5 Then
            picShape5.BackgroundImage = My.Resources.Blue_Circle
            BCcount += 1
        ElseIf Shape5Number = 6 Then
            picShape5.BackgroundImage = My.Resources.Blue_Triangle
            BTcount += 1
        ElseIf Shape5Number = 7 Then
            picShape5.BackgroundImage = My.Resources.Yellow_Square
            YScount += 1
        ElseIf Shape5Number = 8 Then
            picShape5.BackgroundImage = My.Resources.Yellow_Circle
            YCcount += 1
        ElseIf Shape5Number = 9 Then
            picShape5.BackgroundImage = My.Resources.Yellow_Triangle
            YTcount += 1
        End If

        If Shape6Number = 1 Then
            picShape6.BackgroundImage = My.Resources.Red_Square
            RScount += 1
        ElseIf Shape6Number = 2 Then
            picShape6.BackgroundImage = My.Resources.Red_Circle
            RCcount += 1
        ElseIf Shape6Number = 3 Then
            picShape6.BackgroundImage = My.Resources.Red_Triangle
            RTcount += 1
        ElseIf Shape6Number = 4 Then
            picShape6.BackgroundImage = My.Resources.Blue_Square
            BScount += 1
        ElseIf Shape6Number = 5 Then
            picShape6.BackgroundImage = My.Resources.Blue_Circle
            BCcount += 1
        ElseIf Shape6Number = 6 Then
            picShape6.BackgroundImage = My.Resources.Blue_Triangle
            BTcount += 1
        ElseIf Shape6Number = 7 Then
            picShape6.BackgroundImage = My.Resources.Yellow_Square
            YScount += 1
        ElseIf Shape6Number = 8 Then
            picShape6.BackgroundImage = My.Resources.Yellow_Circle
            YCcount += 1
        ElseIf Shape6Number = 9 Then
            picShape6.BackgroundImage = My.Resources.Yellow_Triangle
            YTcount += 1
        End If

        If Shape7Number = 1 Then
            picShape7.BackgroundImage = My.Resources.Red_Square
            RScount += 1
        ElseIf Shape7Number = 2 Then
            picShape7.BackgroundImage = My.Resources.Red_Circle
            RCcount += 1
        ElseIf Shape7Number = 3 Then
            picShape7.BackgroundImage = My.Resources.Red_Triangle
            RTcount += 1
        ElseIf Shape7Number = 4 Then
            picShape7.BackgroundImage = My.Resources.Blue_Square
            BScount += 1
        ElseIf Shape7Number = 5 Then
            picShape7.BackgroundImage = My.Resources.Blue_Circle
            BCcount += 1
        ElseIf Shape7Number = 6 Then
            picShape7.BackgroundImage = My.Resources.Blue_Triangle
            BTcount += 1
        ElseIf Shape7Number = 7 Then
            picShape7.BackgroundImage = My.Resources.Yellow_Square
            YScount += 1
        ElseIf Shape7Number = 8 Then
            picShape7.BackgroundImage = My.Resources.Yellow_Circle
            YCcount += 1
        ElseIf Shape7Number = 9 Then
            picShape7.BackgroundImage = My.Resources.Yellow_Triangle
            YTcount += 1
        End If

        If Shape8Number = 1 Then
            picShape8.BackgroundImage = My.Resources.Red_Square
            RScount += 1
        ElseIf Shape8Number = 2 Then
            picShape8.BackgroundImage = My.Resources.Red_Circle
            RCcount += 1
        ElseIf Shape8Number = 3 Then
            picShape8.BackgroundImage = My.Resources.Red_Triangle
            RTcount += 1
        ElseIf Shape8Number = 4 Then
            picShape8.BackgroundImage = My.Resources.Blue_Square
            BScount += 1
        ElseIf Shape8Number = 5 Then
            picShape8.BackgroundImage = My.Resources.Blue_Circle
            BCcount += 1
        ElseIf Shape8Number = 6 Then
            picShape8.BackgroundImage = My.Resources.Blue_Triangle
            BTcount += 1
        ElseIf Shape8Number = 7 Then
            picShape8.BackgroundImage = My.Resources.Yellow_Square
            YScount += 1
        ElseIf Shape8Number = 8 Then
            picShape8.BackgroundImage = My.Resources.Yellow_Circle
            YCcount += 1
        ElseIf Shape8Number = 9 Then
            picShape8.BackgroundImage = My.Resources.Yellow_Triangle
            YTcount += 1
        End If
    End Sub

    Private Sub tmrStartGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStartGame.Tick
        picCover.Top -= 5   'Lifts curtain
        If picCover.Location.Y < -271 Then
            tmrStartGame.Stop()
            Me.lblCurtainDown.Enabled = True
            Me.lblCurtainDown.Visible = True
        End If
    End Sub

    Private Sub tmrEndGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEndGame.Tick
        picCover.Top += 5   'Drops curtain
        If picCover.Location.Y > 0 Then
            tmrEndGame.Stop()
        End If
    End Sub

    Private Sub lblCurtainDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCurtainDown.Click
        tmrEndGame.Start()
        Me.lblCurtainDown.Enabled = False
        Me.lblStart.Enabled = True
        Me.lblCurtainDown.Visible = False
        Me.lblStart.Visible = True

        'Random integer for the 9 possible questions

        intQuestion = Int(9 * Rnd() + 1)
        If intQuestion = 1 Then
            PlayerAnswer = InputBox("How many red squares did you see?")
            intAnswer = RScount
        ElseIf intQuestion = 2 Then
            PlayerAnswer = InputBox("How many blue squares did you see?")
            intAnswer = BScount
        ElseIf intQuestion = 3 Then
            PlayerAnswer = InputBox("How many yellow squares did you see?")
            intAnswer = YScount
        ElseIf intQuestion = 4 Then
            PlayerAnswer = InputBox("How many red circles did you see?")
            intAnswer = RCcount
        ElseIf intQuestion = 5 Then
            PlayerAnswer = InputBox("How many blue circles did you see?")
            intAnswer = BCcount
        ElseIf intQuestion = 6 Then
            PlayerAnswer = InputBox("How many yellow circles did you see?")
            intAnswer = YCcount
        ElseIf intQuestion = 7 Then
            PlayerAnswer = InputBox("How many red triangles did you see?")
            intAnswer = RTcount
        ElseIf intQuestion = 8 Then
            PlayerAnswer = InputBox("How many blue triangles did you see?")
            intAnswer = BTcount
        ElseIf intQuestion = 9 Then
            PlayerAnswer = InputBox("How many yellow triangles did you see?")
            intAnswer = YTcount
        End If

        If PlayerAnswer = intAnswer Then    'If correct give player one correct.
            intCorrect += 1
            Me.lblRight.Text = intCorrect
        ElseIf PlayerAnswer <> intAnswer Then   'If incorrect give player one wrong.
            intIncorrect += 1
            Me.lblWrong.Text = intIncorrect
        End If
    End Sub
End Class