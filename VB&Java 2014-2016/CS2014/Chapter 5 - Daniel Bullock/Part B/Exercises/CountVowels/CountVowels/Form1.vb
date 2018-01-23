Public Class Form1
    'Daniel Bullock

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        Dim strUserInput As String = Me.txtStatement.Text
        Dim strVowels As Integer

        For vowelcount As Integer = 0 To strUserInput.Length - 1
            Select Case strUserInput.Chars(vowelcount)
                Case Is = "a", "e", "i", "o", "u"
                    strVowels += 1
            End Select
        Next
        Me.lblAnswer.Text = "The number of vowels is " & strVowels & " in " & strUserInput

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStatement.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
