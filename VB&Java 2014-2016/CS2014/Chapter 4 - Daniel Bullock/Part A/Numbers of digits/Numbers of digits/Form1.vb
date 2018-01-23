Public Class Form1

    Private Sub btnCheckNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckNumber.Click
        'Step 1 Define Variables
        Dim intNumber As Integer
        'Step 2 Move variable into textbox
        intNumber = Val(Me.txtboxNumber.Text)
        'Step 3 Do Calculations/If Then Statement
        If intNumber <= 9 Then Me.lblAnswer.Text = "The number is a one digit number."
        If intNumber >= 10 Then Me.lblAnswer.Text = "The number is a two digit number."
        If intNumber >= 100 Then Me.lblAnswer.Text = "Please put in a number less than 100."
    End Sub
End Class
