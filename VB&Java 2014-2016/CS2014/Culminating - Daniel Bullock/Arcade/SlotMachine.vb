Public Class SlotMachine
    'Slot Machine Form - Daniel Bullock

    Dim Spins As Integer = 0
    Dim Tokens As Integer = 100
    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close() 'Switch between forms
        Main_Menu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Blue 'make backcolor appear when mouse is over it
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub picSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSpin.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim number3 As Integer

        Tokens -= 1
        Spins += 1
        Me.lblNumberOfSpins.Text = "Number of spins:  " & Spins

        Randomize()
        '3 numbers from 1 to 3
        number1 = Int(3 * Rnd() + 1)
        number2 = Int(3 * Rnd() + 1)
        number3 = Int(3 * Rnd() + 1)
        'Make pictures appear when slots spin
        If number1 = 1 Then
            picSlot1.Image = My.Resources.grape_icon
        ElseIf number1 = 2 Then
            picSlot1.Image = My.Resources.strawberry_icon
        ElseIf number1 = 3 Then
            picSlot1.Image = My.Resources._7
        End If

        If number2 = 1 Then
            picSlot2.Image = My.Resources.grape_icon
        ElseIf number2 = 2 Then
            picSlot2.Image = My.Resources.strawberry_icon
        ElseIf number2 = 3 Then
            picSlot2.Image = My.Resources._7
        End If

        If number3 = 1 Then
            picSlot3.Image = My.Resources.grape_icon
        ElseIf number3 = 2 Then
            picSlot3.Image = My.Resources.strawberry_icon
        ElseIf number3 = 3 Then
            picSlot3.Image = My.Resources._7
        End If


        If number1 = 1 And number2 = 1 And number3 = 1 Then
            Tokens += 7
            Me.lblMessage.Text = "You get 7 tokens!"
        ElseIf number1 = 2 And number2 = 2 And number3 = 2 Then
            Tokens += 10
            Me.lblMessage.Text = "You get 10 tokens!"
        ElseIf number1 = 3 And number2 = 3 And number3 = 3 Then
            Tokens += 12
            Me.lblMessage.Text = "You get 12 tokens!"
        Else
            Me.lblMessage.Text = "No reward this time..."
        End If

        Me.lblTokens.Text = Tokens

        If Me.lblTokens.Text = 0 Then
            Application.Exit()
        End If
    End Sub
End Class