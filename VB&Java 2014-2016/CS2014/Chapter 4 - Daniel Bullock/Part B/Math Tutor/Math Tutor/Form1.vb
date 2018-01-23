Public Class Form1
    Private dblResult As Double

    Sub NewProblem()
        'Define variables
        Dim arrOperators() As String = {"+", "-", "*", "/"}
        Dim strOperator As String
        Dim INTnbr1 As Integer
        Dim INTnbr2 As Integer

        'random number generator 
        Randomize()

        strOperator = arrOperators(CInt(Rnd() * 3))

        'select two random numbers between 1 and 10 
        INTnbr1 = CInt(Rnd() * 9 + 1)
        INTnbr2 = CInt(Rnd() * 9 + 1)

        'calculation 
        Select Case strOperator
            Case "+" : dblResult = INTnbr1 + INTnbr2
            Case "-" : dblResult = INTnbr1 - INTnbr2
            Case "*" : dblResult = INTnbr1 * INTnbr2
            Case "/" : dblResult = Math.Round(INTnbr1 / INTnbr2, 1)
        End Select

        Dim strProblem As String = INTnbr1 & " " & strOperator & " " & INTnbr2 & " = ?"
        lblProblem.Text = strProblem

        'clear and select txtYourAnswer 
        txtYourAnswer.Text = ""
        txtYourAnswer.Select()

    End Sub

    Private Sub btnNewProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewProblem.Click
        NewProblem()
        Me.lblCheckAnswer.Text = ""
    End Sub


    Private Sub btnCheckAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAnswer.Click
        If Double.Parse(txtYourAnswer.Text) = dblResult Then
            Me.lblCheckAnswer.Text = "Answer is correct"
        Else
            Me.lblCheckAnswer.Text = "Incorrect answer. try again"
            txtYourAnswer.Text = ""
            txtYourAnswer.Select()
            NewProblem()
        End If
    End Sub


    Private Sub btnShowAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAnswer.Click
        'show correct answer and then generate new problem 
        MessageBox.Show("Correct answer is: " & dblResult.ToString)
        Me.lblCheckAnswer.Text = ""
        NewProblem()
    End Sub
End Class