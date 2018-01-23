Public Class Math_Game
    'Math Game Form - Daniel Bullock
    Private dblResult As Double
    Dim ScoreCounter As Integer = 0
    Dim intnum1 As Integer
    Dim intnum2 As Integer
    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close() 'Switch between forms
        Main_Menu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Aqua
    End Sub

    Sub NewProblem()
        If ScoreCounter = 10 Then
            MessageBox.Show("Hey, you got 10 points, here's a tip, at the bottom-right corner of the main menu is a sound board!")
        End If

        'Define variables
        Dim strOperators() As String = {"+", "-", "*", "/"}
        Dim strOperator As String

        'random number generator 
        Randomize()

        strOperator = strOperators(Int(Rnd() * 4))

        'select two random numbers between 1 and 10 or 10 and 20 if you want more of a challange
        If rad1to9.Checked = True Then
            intnum1 = Int(Rnd() * 9 + 1)
            intnum2 = Int(Rnd() * 9 + 1)
        ElseIf rad10to20.Checked = True Then
            intnum1 = Int(Rnd() * 20 + 1)
            intnum2 = Int(Rnd() * 20 + 1)
        End If

            'calculation 
            Select Case strOperator
            Case "+" : dblResult = intnum1 + intnum2
                picOperator.Image = My.Resources.Addition
            Case "-" : dblResult = intnum1 - intnum2
                picOperator.Image = My.Resources.Subtraction
            Case "*" : dblResult = intnum1 * intnum2
                picOperator.Image = My.Resources.Multiplication
            Case "/" : dblResult = Math.Round(intnum1 / intnum2, 1)
                picOperator.Image = My.Resources.Division
        End Select

            Dim strProblem As String = intnum1 & " " & strOperator & " " & intnum2 & " = ?"
            lblProblem.Text = strProblem

            'clear and select txtYourAnswer 
            txtYourAnswer.Text = ""
            txtYourAnswer.Select()
        Me.lblScore.Text = "Score: " & ScoreCounter
    End Sub

    Private Sub btnNewProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewProblem.Click
        NewProblem()
        Me.lblCheckAnswer.Text = ""
    End Sub

    Private Sub btnCheckAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAnswer.Click
        If Double.Parse(txtYourAnswer.Text) = dblResult Then
            Me.lblCheckAnswer.Text = "Answer is correct, you get a point."
            ScoreCounter += 1
            NewProblem()
        Else
            Me.lblCheckAnswer.Text = "Incorrect answer, you lose a point. The correct answer was " & dblResult.ToString
            ScoreCounter -= 1
            txtYourAnswer.Text = ""
            txtYourAnswer.Select()
            NewProblem()
        End If

    End Sub

    Private Sub btnShowAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAnswer.Click
        'show correct answer and then generate new problem 
        MessageBox.Show("Correct answer is: " & dblResult.ToString)
        Me.lblCheckAnswer.Text = ""
        ScoreCounter -= 1
        NewProblem()
    End Sub

    Private Sub rad1to9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad1to9.CheckedChanged
        Me.lblProblem.Text = Nothing
    End Sub

    Private Sub rad10to20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad10to20.CheckedChanged
        Me.lblProblem.Text = Nothing
    End Sub
End Class