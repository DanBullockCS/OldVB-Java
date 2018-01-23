Public Class Form2

    'Daniel Bullock | Quiz Form | Form 2 | Version #6
    Public LifeCounter2 As Integer
    Dim intQcounter As Integer
    Dim intAnswer As Integer
    Dim CorrectCounter As Integer
    'Structure
    Structure Quiz
        Dim Question As String
        Dim Ans1 As String
        Dim Ans2 As String
        Dim Ans3 As String
        Dim Correct As Integer
        Dim Used As Boolean
    End Structure
    'Structure array
    Dim Questions(9) As Quiz

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.tmrUp.Stop()
        Form1.tmrDown.Stop()
        Form1.tmrLeft.Stop()
        Form1.tmrRight.Stop()
        Form1.tmrVirus.Stop()
        Form1.tmrNorton.Stop()

        Form1.Visible = False
        LifeCounter2 = Form1.LifeCounter
        Me.lblSecurityLevelRemaining.Text = LifeCounter2
    End Sub
    Private Sub btnBegin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBegin.Click
        Dim intQuestion As Integer
        Dim intQuestion1 As Integer
        Dim intQuestion2 As Integer
        Dim intQuestion3 As Integer
        Dim intQuestion4 As Integer
        Dim intQuestion5 As Integer
        Dim intQuestion6 As Integer
        Dim intQuestion7 As Integer
        Dim intQuestion8 As Integer
        Dim intQuestion9 As Integer
        btnBegin.Text = "New Question"

        Randomize()

        Do
            intQuestion = Int(10 * Rnd() + 1)
        Loop While (intQuestion = intQuestion1 Or intQuestion = intQuestion2 Or intQuestion = intQuestion3 Or intQuestion = intQuestion4 Or intQuestion = intQuestion5 Or intQuestion = intQuestion6 Or intQuestion = intQuestion7 Or intQuestion = intQuestion8 Or intQuestion = intQuestion9)
        If intQcounter = 1 Then intQuestion1 = intQuestion 'remember which question was asked for question 1
        If intQcounter = 2 Then intQuestion2 = intQuestion 'remember which question was asked for question 2... etc
        If intQcounter = 3 Then intQuestion3 = intQuestion
        If intQcounter = 4 Then intQuestion4 = intQuestion
        If intQcounter = 5 Then intQuestion5 = intQuestion
        If intQcounter = 6 Then intQuestion6 = intQuestion
        If intQcounter = 7 Then intQuestion7 = intQuestion
        If intQcounter = 8 Then intQuestion8 = intQuestion
        If intQcounter = 9 Then intQuestion9 = intQuestion

        If intQcounter = 9 Then
            btnBegin.Enabled = True
            btnBegin.Text = "Next Level"
        End If

        If CorrectCounter = 3 Or intQcounter = 9 Then
            btnBegin.Text = "Next Level"
            Form3.Visible = True
        End If

        If intQuestion = 1 Then
            Questions(0).Question = "How many computer viruses are out there that are known?"
            Questions(0).Ans1 = "40000"
            Questions(0).Ans2 = "10000"
            Questions(0).Ans3 = "24000"
            Questions(0).Correct = 2
            Questions(0).Used = False
            Me.lblQuestion.Text = Questions(0).Question
            Me.lblAnswer1.Text = Questions(0).Ans1
            Me.lblAnswer2.Text = Questions(0).Ans2
            Me.lblAnswer3.Text = Questions(0).Ans3
            intAnswer = 2
        ElseIf intQuestion = 2 Then
            Questions(1).Question = "What is Bill Gates’ net worth (2015)?"
            Questions(1).Ans1 = "$79.3 BILLion"
            Questions(1).Ans2 = "$100 BILLion"
            Questions(1).Ans3 = "$1 BILLion"
            Questions(1).Correct = 1
            Questions(1).Used = False
            Me.lblQuestion.Text = Questions(1).Question
            Me.lblAnswer1.Text = Questions(1).Ans1
            Me.lblAnswer2.Text = Questions(1).Ans2
            Me.lblAnswer3.Text = Questions(1).Ans3
            intAnswer = 1
        ElseIf intQuestion = 3 Then
            Questions(2).Question = "Which selection is NOT an anti-virus software?"
            Questions(2).Ans1 = "Obamacare"
            Questions(2).Ans2 = "Norton"
            Questions(2).Ans3 = "McAfee"
            Questions(2).Correct = 1
            Questions(2).Used = False
            Me.lblQuestion.Text = Questions(2).Question
            Me.lblAnswer1.Text = Questions(2).Ans1
            Me.lblAnswer2.Text = Questions(2).Ans2
            Me.lblAnswer3.Text = Questions(2).Ans3
            intAnswer = 1
        ElseIf intQuestion = 4 Then
            Questions(3).Question = "What is the most popular computer operating system?"
            Questions(3).Ans1 = "Macintosh"
            Questions(3).Ans2 = "Linux"
            Questions(3).Ans3 = "Windows"
            Questions(3).Correct = 3
            Questions(3).Used = False
            Me.lblQuestion.Text = Questions(3).Question
            Me.lblAnswer1.Text = Questions(3).Ans1
            Me.lblAnswer2.Text = Questions(3).Ans2
            Me.lblAnswer3.Text = Questions(3).Ans3
            intAnswer = 3
        ElseIf intQuestion = 5 Then
            Questions(4).Question = "Which selection is an outdated item used for computers?"
            Questions(4).Ans1 = "Blu Ray Disk"
            Questions(4).Ans2 = "Floppy Disk"
            Questions(4).Ans3 = "Toast"
            Questions(4).Correct = 2
            Questions(4).Used = False
            Me.lblQuestion.Text = Questions(4).Question
            Me.lblAnswer1.Text = Questions(4).Ans1
            Me.lblAnswer2.Text = Questions(4).Ans2
            Me.lblAnswer3.Text = Questions(4).Ans3
            intAnswer = 2
        ElseIf intQuestion = 6 Then
            Questions(5).Question = "What was Windows originally called?"
            Questions(5).Ans1 = "Interface Manager"
            Questions(5).Ans2 = "Doors"
            Questions(5).Ans3 = "Red Delicious"
            Questions(5).Correct = 1
            Questions(5).Used = False
            Me.lblQuestion.Text = Questions(5).Question
            Me.lblAnswer1.Text = Questions(5).Ans1
            Me.lblAnswer2.Text = Questions(5).Ans2
            Me.lblAnswer3.Text = Questions(5).Ans3
            intAnswer = 1
        ElseIf intQuestion = 7 Then
            Questions(6).Question = "What year was the first digital computer made in?"
            Questions(6).Ans1 = "1942"
            Questions(6).Ans2 = "1930"
            Questions(6).Ans3 = "1945"
            Questions(6).Correct = 3
            Questions(6).Used = False
            Me.lblQuestion.Text = Questions(6).Question
            Me.lblAnswer1.Text = Questions(6).Ans1
            Me.lblAnswer2.Text = Questions(6).Ans2
            Me.lblAnswer3.Text = Questions(6).Ans3
            intAnswer = 3
        ElseIf intQuestion = 8 Then
            Questions(7).Question = "What was the first computer virus?"
            Questions(7).Ans1 = "Codename Xenon"
            Questions(7).Ans2 = "Elk Virus"
            Questions(7).Ans3 = "Dolphin Virus"
            Questions(7).Correct = 2
            Questions(7).Used = False
            Me.lblQuestion.Text = Questions(7).Question
            Me.lblAnswer1.Text = Questions(7).Ans1
            Me.lblAnswer2.Text = Questions(7).Ans2
            Me.lblAnswer3.Text = Questions(7).Ans3
            intAnswer = 2
        ElseIf intQuestion = 9 Then
            Questions(8).Question = "What year did Steve Jobs pass away?"
            Questions(8).Ans1 = "2012"
            Questions(8).Ans2 = "2011"
            Questions(8).Ans3 = "2009"
            Questions(8).Correct = 2
            Questions(8).Used = False
            Me.lblQuestion.Text = Questions(8).Question
            Me.lblAnswer1.Text = Questions(8).Ans1
            Me.lblAnswer2.Text = Questions(8).Ans2
            Me.lblAnswer3.Text = Questions(8).Ans3
            intAnswer = 2
        ElseIf intQuestion = 10 Then
            Questions(9).Question = "Which one of the following does NOT exist?"
            Questions(9).Ans1 = "Windows 95"
            Questions(9).Ans2 = "Windows 10"
            Questions(9).Ans3 = "Windows 9"
            Questions(9).Correct = 3
            Questions(9).Used = False
            Me.lblQuestion.Text = Questions(9).Question
            Me.lblAnswer1.Text = Questions(9).Ans1
            Me.lblAnswer2.Text = Questions(9).Ans2
            Me.lblAnswer3.Text = Questions(9).Ans3
            intAnswer = 3
        End If

        btnBegin.Enabled = False
    End Sub
    Private Sub lblAnswer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer1.Click

        If intAnswer = 1 Then
            lblQuestion.Text = "CORRECT - Your security level INCREASES by 2!"
            LifeCounter2 = LifeCounter2 + 2
            Me.lblSecurityLevelRemaining.Text += 2
            CorrectCounter += 1
        Else
            lblQuestion.Text = "That is NOT the answer - Your security level DECREASES by 2."
            LifeCounter2 = LifeCounter2 - 2
            Me.lblSecurityLevelRemaining.Text -= 2
        End If

        Me.lblAnswer1.Text = Nothing
        Me.lblAnswer2.Text = Nothing
        Me.lblAnswer3.Text = Nothing

        If LifeCounter2 <= 0 Then
            Form3.Visible = True
        End If

        intQcounter += 1

        btnBegin.Enabled = True
    End Sub

    Private Sub lblAnswer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer2.Click

        If intAnswer = 2 Then
            lblQuestion.Text = "CORRECT - Your security level INCREASES by 2!"
            LifeCounter2 = LifeCounter2 + 2
            Me.lblSecurityLevelRemaining.Text += 2
            CorrectCounter += 1
        Else
            lblQuestion.Text = "That is NOT the answer - Your security level DECREASES by 2."
            LifeCounter2 = LifeCounter2 - 2
            Me.lblSecurityLevelRemaining.Text -= 2
        End If

        Me.lblAnswer1.Text = Nothing
        Me.lblAnswer2.Text = Nothing
        Me.lblAnswer3.Text = Nothing

        If LifeCounter2 <= 0 Then
            Form3.Visible = True
        End If

        intQcounter += 1

        btnBegin.Enabled = True
    End Sub
    Private Sub lblAnswer3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer3.Click

        If intAnswer = 3 Then
            lblQuestion.Text = "CORRECT - Your security level INCREASES by 2!"
            LifeCounter2 = LifeCounter2 + 2
            Me.lblSecurityLevelRemaining.Text += 2
            CorrectCounter += 1
        Else
            lblQuestion.Text = "That is NOT the answer - Your security level DECREASES by 2."
            LifeCounter2 = LifeCounter2 - 2
            Me.lblSecurityLevelRemaining.Text -= 2
        End If

        Me.lblAnswer1.Text = Nothing
        Me.lblAnswer2.Text = Nothing
        Me.lblAnswer3.Text = Nothing

        If LifeCounter2 <= 0 Then
            Form3.Visible = True
        End If

        intQcounter += 1

        btnBegin.Enabled = True
    End Sub

    Private Sub lblHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHelp.Click
        MessageBox.Show("Click on the begin button and Click on the answer to the question that you think is correct.") 'Little help button in the top right corner
    End Sub

    Private Sub tmrMonitor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMonitor.Tick
        Me.picMonitor.Visible = True
        Me.picMonitorWithMsg.Visible = False 'Flicker Animation
    End Sub

    Private Sub tmrMonitor2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMonitor2.Tick
        Me.picMonitor.Visible = False
        Me.picMonitorWithMsg.Visible = True  'Flicker Animation
    End Sub
End Class