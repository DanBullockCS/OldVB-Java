Public Class Form1
    'Daniel Bullock

    Private Sub btnCountLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCountLetter.Click
        Dim strChar As String = Me.txtEnterLetter.Text
        Dim strMessage As String = Me.txtEnterText.Text
        Dim intAmount As Integer
        Dim IntCharAmount As Integer
        
        Do While intAmount < strMessage.Length
            If strMessage.Chars(intAmount) = strChar Then
                IntCharAmount += 1
                Me.lblNumberOfTimesLetterOccurs.Text = IntCharAmount
            End If
            intAmount += 1
        Loop
    End Sub

    Private Sub txtEnterLetter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnterLetter.TextChanged
        Me.lblNumberOfTimesLetterOccurs.Text = Nothing
    End Sub

    Private Sub txtEnterText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnterText.TextChanged
        Me.lblNumberOfTimesLetterOccurs.Text = Nothing
    End Sub
End Class
