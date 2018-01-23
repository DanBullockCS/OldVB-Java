Public Class Game1
    'Daniel Bullock
    'Game 1 - Memory Match Form

    'I decided not to use this game in the final project as I wasn't sure where to go
    ' from this point and basically ran out of time.
    'The reason I left it in was just because I didn't want to delete something I spent so much time on







    Dim intTime As Integer = 0                  'Timer.
    Dim boolFirstChoice As Boolean = False      'Variable for the playing turn.
    Dim arrButtons(19) As Button                'Dim all the buttons in the game.
    Dim intFiveSeconds As Integer = 0           'Variable for the five seconds you get to memorize the pattern.

#Region "Matching Booleans"
    Dim RedMatched As Boolean = False
    Dim BlueMatched As Boolean = False
    Dim GreenMatched As Boolean = False
    Dim MagentaMatched As Boolean = False
    Dim OrangeMatched As Boolean = False
    Dim PurpleMatched As Boolean = False
    Dim YellowMatched As Boolean = False
    Dim CyanMatched As Boolean = False
    Dim BlackMatched As Boolean = False
    Dim CrimsonMatched As Boolean = False
#End Region

#Region "Answer Key"
    'btn1, btn5 = Red
    'btn2, btn6 = Blue
    'btn3, btn10 = Green
    'btn4, btn20 = Magenta
    'btn11, btn19 = Orange
    'btn12, btn17 = Purple
    'btn7, btn16 = Yellow
    'btn8, btn9 = Cyan
    'btn13, btn15 = Black
    'btn14, btn18 = Crimson
#End Region

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Yellow
    End Sub

    Private Sub lblPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPause.Click
        tmrGameTime.Stop() 'Pause the game
    End Sub

    Private Sub lblPause_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPause.MouseLeave
        lblPause.BackColor = Color.Transparent
    End Sub

    Private Sub lblPause_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblPause.MouseMove
        lblPause.BackColor = Color.Yellow
    End Sub

    Private Sub lblStart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStart.MouseLeave
        lblStart.BackColor = Color.Transparent
    End Sub

    Private Sub lblStart_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblStart.MouseMove
        lblStart.BackColor = Color.Yellow
    End Sub

    Private Sub lblStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStart.Click
        'Make the buttons visible when the game starts.
        arrButtons(0) = btn1
        arrButtons(1) = btn2
        arrButtons(2) = btn3
        arrButtons(3) = btn4
        arrButtons(4) = btn5
        arrButtons(5) = btn6
        arrButtons(6) = btn7
        arrButtons(7) = btn8
        arrButtons(8) = btn9
        arrButtons(9) = btn10
        arrButtons(10) = btn11
        arrButtons(11) = btn12
        arrButtons(12) = btn13
        arrButtons(13) = btn14
        arrButtons(14) = btn15
        arrButtons(15) = btn16
        arrButtons(16) = btn17
        arrButtons(17) = btn18
        arrButtons(18) = btn19
        arrButtons(19) = btn20
        For index As Integer = 0 To arrButtons.Length - 1
            arrButtons(index).Visible = True
        Next
        tmrShowColours.Start() 'Shows the colors then covers them
    End Sub

    Private Sub tmrGameTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGameTime.Tick
        Call GameIsOn()
        tmrShowColours.Stop() 'Finish the opening show colours part
        intTime += 1
        Me.lblTime.Text = intTime
    End Sub
    'Sub for every button in the game
    Private Sub EveryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, _
        btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, _
        btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click
        Call GameIsOn()
    End Sub
    Private Sub tmrShowColours_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShowColours.Tick
        intFiveSeconds += 1
        Me.lblMemorizeColours.Visible = True
        If intFiveSeconds = 5 Then
            Me.lblMemorizeColours.Visible = False
            For index As Integer = 0 To arrButtons.Length - 1
                arrButtons(index).BackColor = Color.White
            Next index
            tmrGameTime.Start() 'Starts the timer
        End If
    End Sub

#Region "Button Colours"

    Private Sub btn1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        btn1.BackColor = Color.Red
    End Sub

    Private Sub btn2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        btn2.BackColor = Color.Blue
    End Sub

    Private Sub btn3_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        btn3.BackColor = Color.Green
    End Sub

    Private Sub btn4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        btn4.BackColor = Color.Magenta
    End Sub

    Private Sub btn5_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        btn5.BackColor = Color.Red
    End Sub

    Private Sub btn6_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        btn6.BackColor = Color.Blue
    End Sub

    Private Sub btn7_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        btn7.BackColor = Color.Yellow
    End Sub

    Private Sub btn8_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        btn8.BackColor = Color.Cyan
    End Sub

    Private Sub btn9_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        btn9.BackColor = Color.Cyan
    End Sub

    Private Sub btn10_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10.Click
        btn10.BackColor = Color.Green
    End Sub

    Private Sub btn11_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        btn11.BackColor = Color.Orange
    End Sub

    Private Sub btn12_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12.Click
        btn12.BackColor = Color.Purple
    End Sub

    Private Sub btn13_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn13.Click
        btn13.BackColor = Color.Black
    End Sub

    Private Sub btn14_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn14.Click
        btn14.BackColor = Color.Crimson
    End Sub

    Private Sub btn15_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn15.Click
        btn15.BackColor = Color.Black
    End Sub

    Private Sub btn16_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn16.Click
        btn16.BackColor = Color.Yellow
    End Sub

    Private Sub btn17_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn17.Click
        btn17.BackColor = Color.Purple
    End Sub

    Private Sub btn18_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn18.Click
        btn18.BackColor = Color.Crimson
    End Sub

    Private Sub btn19_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn19.Click
        btn19.BackColor = Color.Orange
    End Sub

    Private Sub btn20_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn20.Click
        btn20.BackColor = Color.Magenta
    End Sub

#End Region

    Sub GameIsOn()
        If btn1.BackColor <> Color.White And btn2.BackColor <> Color.White And btn2.BackColor <> Color.White And
            _btn3.BackColor <> Color.White And btn4.BackColor <> Color.White And btn5.BackColor <> Color.White And
            _btn6.BackColor <> Color.White And btn7.BackColor <> Color.White And btn8.BackColor <> Color.White And
            _btn9.BackColor <> Color.White And btn10.BackColor <> Color.White And btn11.BackColor <> Color.White And
            _btn12.BackColor <> Color.White And btn13.BackColor <> Color.White And btn14.BackColor <> Color.White And
            _btn15.BackColor <> Color.White And btn16.BackColor <> Color.White And btn17.BackColor <> Color.White And
            _btn18.BackColor <> Color.White And btn19.BackColor <> Color.White And btn20.BackColor <> Color.White Then
            tmrGameTime.Stop()
            Me.lblMemorizeColours.Visible = True
            Me.lblMemorizeColours.Text = "You win! You're time was " & intTime & "."
        End If
    End Sub
End Class