Public Class WhackAMole
    'Whack-a-mole Form - Daniel Bullock

    Dim Time As Integer = 60 'Timer is 1 minute
    Dim ScoreCounter As Integer = 0 'score starts at 0

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close() 'Switch between forms
        Main_Menu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Green
    End Sub

    Private Sub WhackAMole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Make the mouse in whack-a-mole a hammer
        Dim cur As Icon
        cur = My.Resources.Hammer
        Me.Cursor = New Cursor(cur.Handle)
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        picMole.Image = My.Resources.Mole
        tmrMole.Start()
        tmrTime.Start()
    End Sub

    Private Sub tmrMole_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMole.Tick
        Dim MoleLocation As Integer

        Randomize()

        MoleLocation = Int(9 * Rnd() + 1)
        'Make the mole appear in the different holes
        Select MoleLocation
            Case 1
                picMole.Location = New Point(139, 113)
            Case 2
                picMole.Location = New Point(253, 113)
            Case 3
                picMole.Location = New Point(360, 113)
            Case 4
                picMole.Location = New Point(139, 213)
            Case 5
                picMole.Location = New Point(250, 213)
            Case 6
                picMole.Location = New Point(360, 213)
            Case 7
                picMole.Location = New Point(139, 328)
            Case 8
                picMole.Location = New Point(251, 328)
            Case 9
                picMole.Location = New Point(360, 328)
        End Select
    End Sub

    Private Sub picMole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMole.Click
        My.Computer.Audio.Play(My.Resources.Smack, AudioPlayMode.Background)
        ScoreCounter += 1
        Me.lblWhacks.Text = "Whacks:" & " " & ScoreCounter
    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        Time -= 1
        Me.lblTime.Text = "Time:" & " " & Time

        If Time = 0 Then
            Me.Close()
            MessageBox.Show("Thank you for playing whack a mole, your score was" & " " & ScoreCounter & ", " & "play again or try some of our other games!")
            Main_Menu.Visible = True
        End If
    End Sub

    Private Sub RadEasy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadEasy.CheckedChanged
        tmrMole.Interval = 1000 'Changes from easy, medium and hard mode.
    End Sub

    Private Sub RadMedium_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMedium.CheckedChanged
        tmrMole.Interval = 750
    End Sub

    Private Sub RadHard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadHard.CheckedChanged
        tmrMole.Interval = 500
    End Sub
End Class