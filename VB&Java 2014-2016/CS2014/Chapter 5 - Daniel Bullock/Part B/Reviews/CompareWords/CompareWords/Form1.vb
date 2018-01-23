Public Class Form1
    'Daniel Bullock

    Private Sub btnCompareWords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompareWords.Click
        Dim strFirstWord As String = Me.txtFirstWord.Text
        Dim strSecondWord As String = Me.txtSecondWord.Text

        Select Case String.Compare(strFirstWord, strSecondWord, True)
            Case 0
                Me.lblMessage.Text = strFirstWord & " is the same as " & strSecondWord
            Case Is < 0
                Me.lblMessage.Text = strFirstWord & " comes before " & strSecondWord
            Case Is > 0
                Me.lblMessage.Text = strFirstWord & " comes after " & strSecondWord
        End Select
    End Sub
End Class
