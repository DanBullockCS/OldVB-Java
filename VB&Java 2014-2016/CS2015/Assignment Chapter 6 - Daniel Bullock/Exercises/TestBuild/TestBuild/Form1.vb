Public Class Form1
    'Daniel Bullock
    'Test Build

    Private Sub btnBreakUpRebuild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBreakUpRebuild.Click
        Dim Number As Integer = 100
        Dim DigitOne As Integer
        Dim DigitTwo As Integer
        Dim DigitThree As Integer

        Do While Number <= 125
            Call ThreeDigits(Number, DigitOne, DigitTwo, DigitThree)
            lblDigitOne.Text += DigitOne & vbCrLf
            lblDigitTwo.Text += DigitTwo & vbCrLf
            lblDigitThree.Text += DigitThree & vbCrLf
            lblRebuild.Text += (DigitOne * 100) + (DigitTwo * 10) + DigitThree & vbCrLf
            Number = Number + 1
        Loop
    End Sub

    Sub TwoDigits(ByVal num As Integer, ByRef firstDigit As Integer, ByRef secondDigit As Integer)
        firstDigit = num \ 10
        secondDigit = num Mod 10
    End Sub

    Sub ThreeDigits(ByVal num As Integer, ByRef firstDigit As Integer, ByRef secondDigit As Integer, ByRef thirdDigit As Integer)
        firstDigit = num \ 100
        num = num Mod 100
        Call TwoDigits(num, secondDigit, thirdDigit)
    End Sub
End Class
