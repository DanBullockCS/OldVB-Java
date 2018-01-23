Public Class Form1
    'Daniel Bullock

    Private Sub btnBreakdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBreakdown.Click
        Dim numberEntered As Integer
        Dim onesDigit As Integer
        Dim tensDigit As Integer
        Dim hundredsDigit As Integer

        numberEntered = Val(Me.txtNumber.Text)
        If numberEntered < 10 Then
            Me.lblDigits.Text = "The first digit is: " & numberEntered
        ElseIf numberEntered < 100 Then
            Call TwoDigits(numberEntered, tensDigit, onesDigit)
            Me.lblDigits.Text = "The first digit is: " & tensDigit & vbCrLf & "The second digit is: " & onesDigit
        ElseIf numberEntered < 1000 Then
            Call ThreeDigits(numberEntered, hundredsDigit, tensDigit, onesDigit)
            Me.lblDigits.Text = "The first digit is: " & hundredsDigit & vbCrLf & "The second digit is: " & tensDigit & vbCrLf & "The third digit is: " & onesDigit
        Else
            Me.lblDigits.Text = "Invalid entry."
        End If

    End Sub

    Sub TwoDigits(ByVal num As Integer, ByRef firstDigit As Integer, ByRef secondDigit As Integer)
        firstDigit = num \ 10
        secondDigit = num Mod 10
    End Sub

    Sub threeDigits(ByVal num As Integer, ByRef firstDigit As Integer, ByRef secondDigit As Integer, ByRef thirdDigit As Integer)
        firstDigit = num \ 100
        num = num Mod 100
        Call TwoDigits(num, secondDigit, thirdDigit)
    End Sub

    Private Sub txtNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.TextChanged
        Me.lblDigits.Text = Nothing
    End Sub
End Class
