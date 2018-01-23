Imports System.IO

Public Class Game3
    'Daniel Bullock
    'Game 3 - Balloon Pop Form

    Dim intGameX As Integer 'X point relative to the form
    Dim intGameY As Integer 'Y point relative to the form
    Dim intScore As Integer = 0 'Player Score
    Dim intGameTime As Integer = 30 'Game Time

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close()
        MainMenu.Visible = True
        My.Computer.Audio.Play(My.Resources.Background_Music, AudioPlayMode.BackgroundLoop)
    End Sub

    'Red Balloon = 1 Point
    'Blue Balloon = 2 Points
    'Green Balloon = 3 Points
    'Yellow Balloon = 5 Points
    'The more points the balloon gives you the faster its timer is (making itself faster and harder to pop).

#Region "MouseHovering Code"
    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.White
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Yellow
    End Sub

    Private Sub lblStartPause_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStartPause.MouseLeave
        lblStartPause.BackColor = Color.White
    End Sub

    Private Sub lblStartPause_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblStartPause.MouseMove
        lblStartPause.BackColor = Color.Yellow
    End Sub

    Private Sub lblRestart_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRestart.MouseLeave
        Me.lblRestart.BackColor = Color.Transparent
    End Sub

    Private Sub lblRestart_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblRestart.MouseMove
        Me.lblRestart.BackColor = Color.Red
    End Sub
#End Region

    Private Sub lblStartPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStartPause.Click
        If Me.lblStartPause.Text = "Start" Then 'Starting and pausing the game
            tmrRedBalloon.Enabled = True
            tmrBlueBalloon.Enabled = True
            tmrGreenBalloon.Enabled = True
            tmrYellowBalloon.Enabled = True
            tmrGameTime.Enabled = True
            Me.lblStartPause.Text = "Pause"
        ElseIf Me.lblStartPause.Text = "Pause" Then
            tmrRedBalloon.Enabled = False
            tmrBlueBalloon.Enabled = False
            tmrGreenBalloon.Enabled = False
            tmrYellowBalloon.Enabled = False
            tmrGameTime.Enabled = False
            Me.lblStartPause.Text = "Start"
        End If
    End Sub
    'Timers for 4 different balloons
    Private Sub tmrBlueBalloon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBlueBalloon.Tick
        picBlueBalloon.Enabled = True
        picBlueBalloon.Visible = True
        Randomize()
        intGameX = Int(Rnd() * 554) + 1 'Form size
        intGameY = Int(Rnd() * 412) + 1

        picBlueBalloon.Location = New Point(intGameX, intGameY)
    End Sub

    Private Sub tmrGreenBalloon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGreenBalloon.Tick
        picGreenBalloon.Enabled = True
        picGreenBalloon.Visible = True
        Randomize()
        intGameX = Int(Rnd() * 554) + 1
        intGameY = Int(Rnd() * 412) + 1

        picGreenBalloon.Location = New Point(intGameX, intGameY)
    End Sub

    Private Sub tmrYellowBalloon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrYellowBalloon.Tick
        picYellowBalloon.Enabled = True
        picYellowBalloon.Visible = True
        Randomize()
        intGameX = Int(Rnd() * 554) + 1
        intGameY = Int(Rnd() * 412) + 1

        picYellowBalloon.Location = New Point(intGameX, intGameY)
    End Sub

    Private Sub tmrRedBalloon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRedBalloon.Tick
        picRedBalloon.Enabled = True
        picRedBalloon.Visible = True
        Randomize()
        intGameX = Int(Rnd() * 554) + 1
        intGameY = Int(Rnd() * 412) + 1

        picRedBalloon.Location = New Point(intGameX, intGameY)
    End Sub

    Private Sub picBlueBalloon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBlueBalloon.Click
        intScore += 2   'Example: 2 points for a blue balloon
        Me.lblScore.Text = intScore
        picBlueBalloon.Enabled = False
        picBlueBalloon.Visible = False
        My.Computer.Audio.Play(My.Resources.Balloon_Pop, AudioPlayMode.Background)
    End Sub

    Private Sub picGreenBalloon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGreenBalloon.Click
        intScore += 3
        Me.lblScore.Text = intScore
        picGreenBalloon.Enabled = False
        picGreenBalloon.Visible = False
        My.Computer.Audio.Play(My.Resources.Balloon_Pop, AudioPlayMode.Background)
    End Sub

    Private Sub picYellowBalloon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picYellowBalloon.Click
        intScore += 5
        Me.lblScore.Text = intScore
        picYellowBalloon.Enabled = False
        picYellowBalloon.Visible = False
        My.Computer.Audio.Play(My.Resources.Balloon_Pop, AudioPlayMode.Background)
    End Sub

    Private Sub picRedBalloon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRedBalloon.Click
        intScore += 1
        Me.lblScore.Text = intScore
        picRedBalloon.Enabled = False
        picRedBalloon.Visible = False
        My.Computer.Audio.Play(My.Resources.Balloon_Pop, AudioPlayMode.Background)
    End Sub

    Private Sub tmrGameTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGameTime.Tick
        intGameTime -= 1
        Me.lblTime.Text = intGameTime
        If intGameTime = 0 Then 'If the time runs out then make everything disabled and invisible except for the restart button.
            tmrRedBalloon.Enabled = False
            tmrBlueBalloon.Enabled = False
            tmrGreenBalloon.Enabled = False
            tmrYellowBalloon.Enabled = False
            tmrGameTime.Enabled = False
            picBlueBalloon.Visible = False
            picGreenBalloon.Visible = False
            picRedBalloon.Visible = False
            picYellowBalloon.Visible = False
            picBlueBalloon.Enabled = False
            picGreenBalloon.Enabled = False
            picRedBalloon.Enabled = False
            picYellowBalloon.Enabled = False
            MessageBox.Show("Game over! Your score is " & intScore & ".")
            Me.lblRestart.Visible = True
            Me.lblRestart.Enabled = True

            Dim fileName As String = "Scores.txt"   'get file name
            Dim fs As New FileStream(fileName, FileMode.Append, FileAccess.Write)
            Dim textFile As New StreamWriter(fs)

            textFile.Write(vbNewLine & intScore & " - " & MainMenu.PlayerName)             'write score to file

            textFile.Close()
            fs.Close()
        End If
    End Sub

    Private Sub lblRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRestart.Click
        lblRestart.Visible = False  'Restart the game
        lblRestart.Enabled = False
        intScore = 0
        Me.lblScore.Text = intScore
        intGameTime = 30
        Me.lblTime.Text = intGameTime
        tmrRedBalloon.Enabled = True
        tmrBlueBalloon.Enabled = True
        tmrGreenBalloon.Enabled = True
        tmrYellowBalloon.Enabled = True
        tmrGameTime.Enabled = True
    End Sub

    Private Sub Game3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Make the mouse a push pin
        Dim cur As Icon
        cur = My.Resources.Pin
        Me.Cursor = New Cursor(cur.Handle)

        My.Computer.Audio.Stop()
    End Sub
End Class