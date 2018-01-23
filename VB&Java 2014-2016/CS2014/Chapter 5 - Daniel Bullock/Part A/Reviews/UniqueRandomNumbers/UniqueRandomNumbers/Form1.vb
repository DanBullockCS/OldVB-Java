Public Class Form1
    'Daniel Bullock

    Private Sub btnGenerateNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateNumbers.Click
        Const TITLE As String = "Your Number"
        Const PROMPT As String = "Enter a number greater then 3"
        Dim Max As String = InputBox(PROMPT, TITLE)
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Num3 As Integer
        Dim numberOfLoops As Integer = 0

        Do
            Num1 = Int(Max * Rnd() + 1)
            Num2 = Int(Max * Rnd() + 1)
            Num3 = Int(Max * Rnd() + 1)
            numberOfLoops += 1
        Loop While Num1 = Num2 Or Num1 = Num3 Or Num2 = Num3

        Me.lblNum1.Text = Num1
        Me.lblNum2.Text = Num2
        Me.lblNum3.Text = Num3
        Me.lblNumberOfLoops.Text = numberOfLoops
    End Sub
End Class
