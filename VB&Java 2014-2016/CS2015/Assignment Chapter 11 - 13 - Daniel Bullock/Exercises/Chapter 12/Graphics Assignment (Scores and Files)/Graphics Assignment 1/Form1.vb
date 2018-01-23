Imports System.IO

Public Class Form1

    'Daniel Bullock - Chapter 12 Edition

    Public LifeCounter As Integer = 10
    Public intPlay As Integer = 15
    Dim intFormX As Integer
    Dim intFormY As Integer
    Dim arrTopScores(100) As String
    Dim arrTop10Scores(9) As String

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

        If (intVirusX < intMouseCursorX + 40 And intVirusX > intMouseCursorX - 35) And (intVirusY < intMouseCursorY + 35 And intVirusY > intMouseCursorY - 35) Then
            LifeCounter -= 1

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
            Dim fileName As String = "Scores.txt"
            Dim fs As New FileStream(fileName, FileMode.Append, FileAccess.Write)
            Dim textFile As New StreamWriter(fs)

            textFile.Write(vbCrLf & Me.lblSecurityLevelNumber.Text & " points - " & EnterName.txtPlayerName.Text)

            textFile.Close()
            fs.Close()

            tmrDown.Stop()
            tmrUp.Stop()
            tmrLeft.Stop()
            tmrRight.Stop()
            tmrNorton.Stop()
            tmrVirus.Stop()
            PlayAgain.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub tmrNorton_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrNorton.Tick
        intPlay = intPlay - 1
        lblTime.Text = intPlay
        If intPlay = 0 Then
            Dim fileName As String = "Scores.txt"
            Dim fs As New FileStream(fileName, FileMode.Append, FileAccess.Write)
            Dim textFile As New StreamWriter(fs)

            textFile.Write(vbCrLf & Me.lblSecurityLevelNumber.Text & " points - " & EnterName.txtPlayerName.Text)

            textFile.Close()
            fs.Close()

            tmrDown.Stop()
            tmrUp.Stop()
            tmrLeft.Stop()
            tmrRight.Stop()
            tmrNorton.Stop()
            tmrVirus.Stop()
            PlayAgain.Show()
            Me.Visible = False
        End If

        intFormX = Int(Rnd() * 850) + 1
        intFormY = Int(Rnd() * 600) + 1

        PicNorton.Location = New Point(intFormX, intFormY)

    End Sub

    Private Sub PicNorton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicNorton.Click
        LifeCounter += 1
        PicNorton.Location = New Point(intFormX, intFormY)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PicNorton.Location = New Point(-200, -200) 'Make Sure the norton picture starts the game off the form

        Dim PlayerName As String
        PlayerName = EnterName.txtPlayerName.Text
    End Sub

    Private Sub NamesAndScoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NamesAndScoresToolStripMenuItem.Click
        Scores.lstScores.Items.Clear()

        Dim fileName As String = "Scores.txt"
        Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim lineOfText As String

        Do While textFile.Peek > -1                 'check for the end of file
            lineOfText = textFile.ReadLine()
            'Display line of text
            Scores.lstScores.Items.Add(lineOfText & vbCrLf)
        Loop

        textFile.Close()
        fs.Close()

        tmrDown.Stop()
        tmrUp.Stop()
        tmrLeft.Stop()
        tmrRight.Stop()
        tmrNorton.Stop()
        tmrVirus.Stop()

        Scores.Show()
        Me.Visible = False
    End Sub

    Private Sub Top10ScoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top10ScoresToolStripMenuItem.Click
        Scores.lstScores.Items.Clear()

        Dim fileName As String = "Scores.txt"
        Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim lineOfText As String

        Do While textFile.Peek > -1                 'check for the end of file
            lineOfText = textFile.ReadLine()
            'Display line of text
            Scores.lstScores.Items.Add(lineOfText & vbCrLf)
        Loop

        textFile.Close()
        fs.Close()

        tmrDown.Stop()
        tmrUp.Stop()
        tmrLeft.Stop()
        tmrRight.Stop()
        tmrNorton.Stop()
        tmrVirus.Stop()

        Scores.Show()
        Me.Visible = False
    End Sub

    Sub BubbleSort(ByRef intArray() As String)
        Dim temp As Integer
        Dim swapRequired As Boolean = True          'flag

        Do While swapRequired
            swapRequired = False
            For testItem As Integer = 0 To intArray.Length - 2
                If intArray(testItem) > intArray(testItem + 1) Then
                    'Swap elements
                    temp = intArray(testItem)
                    intArray(testItem + 1) = temp
                    swapRequired = True
                End If
            Next testItem
        Loop
    End Sub
End Class
