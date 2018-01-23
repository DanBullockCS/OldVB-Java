Public Class Form2

    'Daniel Bullock | Quiz Form | Form 2 | Version #5
    Public LifeCounter2 As Integer
    Dim intQcounter As Integer
    Dim intAnswer As Integer

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

        btnBegin.Text = "New Question"

        Randomize()

        Do
            intQuestion = Int(5 * Rnd() + 1)
        Loop While (intQuestion = intQuestion1 Or intQuestion = intQuestion2) 'make sure no repeat questions
        If intQcounter = 1 Then intQuestion1 = intQuestion 'remember which question was asked for question 1
        If intQcounter = 2 Then intQuestion2 = intQuestion 'remember which question was asked for question 2
        If intQcounter = 2 Then
            btnBegin.Enabled = True
            btnBegin.Text = "Next Level"
        End If

        If intQcounter = 3 Then
            btnBegin.Text = "Next Level"
            Form3.Visible = True
        End If

        If intQuestion = 1 Then
            lblQuestion.Text = "How many computer viruses are out there that are known?"
            lblAnswer1.Text = "40000"
            lblAnswer2.Text = "10000"
            lblAnswer3.Text = "24000"
            intAnswer = 2
        ElseIf intQuestion = 2 Then
            lblQuestion.Text = "Which selection is NOT an anti-virus software?"
            lblAnswer1.Text = "ObamaCare"
            lblAnswer2.Text = "Norton"
            lblAnswer3.Text = "McAfee"
            intAnswer = 1
        ElseIf intQuestion = 3 Then
            lblQuestion.Text = "What is the most popular computer operating system?"
            lblAnswer1.Text = "Macintosh"
            lblAnswer2.Text = "Linux"
            lblAnswer3.Text = "Windows"
            intAnswer = 3
        ElseIf intQuestion = 4 Then
            lblQuestion.Text = "Which selection is a outdated item used for computers?"
            lblAnswer1.Text = "Blu Ray Disk"
            lblAnswer2.Text = "Floppy Disk"
            lblAnswer3.Text = "Toast"
            intAnswer = 2
        ElseIf intQuestion = 5 Then
            lblQuestion.Text = "What was Windows originally called?"
            lblAnswer1.Text = "Interface Manager"
            lblAnswer2.Text = "Doors"
            lblAnswer3.Text = "Red Delicious"
            intAnswer = 1
        End If

        btnBegin.Enabled = False
    End Sub
    Private Sub lblAnswer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswer1.Click

        If intAnswer = 1 Then
            lblQuestion.Text = "CORRECT  - Your security level INCREASES by 2!"
            LifeCounter2 = LifeCounter2 + 2
            Me.lblSecurityLevelRemaining.Text += 2
        Else
            lblQuestion.Text = "That is NOT the answer  - Your security level DECREASES by 2."
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
            lblQuestion.Text = "CORRECT  - Your security level INCREASES by 2!"
            LifeCounter2 = LifeCounter2 + 2
            Me.lblSecurityLevelRemaining.Text += 2
        Else
            lblQuestion.Text = "That is NOT the answer  - Your security level DECREASES by 2."
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
            lblQuestion.Text = "CORRECT  - Your security level INCREASES by 2!"
            LifeCounter2 = LifeCounter2 + 2
            Me.lblSecurityLevelRemaining.Text += 2
        Else
            lblQuestion.Text = "That is NOT the answer  - Your security level DECREASES by 2."
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
        MessageBox.Show("Click on the begin button and Click on the answer to the question that you think is correct.") 'Little help button in the corner
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