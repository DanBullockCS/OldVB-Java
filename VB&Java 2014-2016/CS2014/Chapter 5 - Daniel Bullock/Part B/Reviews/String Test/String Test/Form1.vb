Public Class Form1
    'Daniel Bullock

    Private Sub btnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnData.Click
        'Define variables
        Dim firstletter As Char
        Dim middleletter As Char
        Dim lastletter As Char
        Dim word As String = Me.txtText.Text
        Dim strlength As String
        Dim intlength As String

        strlength = word.Length
        intlength = strlength

        firstletter = word.Substring(0, 1) 'find first letter
        middleletter = Mid(word, intlength / 2 + 0.5) 'the length of the word divided by 2 and added 0.5 equals the middle letter
        lastletter = word.Last 'find last letter

        'Letters into labels
        Me.lblFirstLetter.Text = firstletter
        Me.lblMiddleLetter.Text = middleletter
        Me.lblLastLetter.Text = lastletter

    End Sub
End Class
