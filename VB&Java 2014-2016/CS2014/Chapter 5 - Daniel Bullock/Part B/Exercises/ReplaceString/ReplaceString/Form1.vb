Public Class Form1
    'Daniel Bullock

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Dim strUserInput As String = Me.txtSentence.Text
        Dim strAnswer As String
        Dim strSearch As String = Me.txtSearch.Text
        Dim strReplace As String = Me.txtReplace.Text

        strAnswer = strUserInput.Replace(strSearch, strReplace)
       
        Me.lblAnswer.Text = strAnswer
    End Sub

    Private Sub txtReplace_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReplace.TextChanged
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub txtSentence_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSentence.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class