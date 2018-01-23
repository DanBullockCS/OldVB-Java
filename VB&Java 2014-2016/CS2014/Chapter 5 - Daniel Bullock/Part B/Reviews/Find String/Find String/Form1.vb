Public Class Form1
    'Daniel Bullock

    Private Sub btnFindString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindString.Click
        Dim strText As String = Me.txtText.Text
        Dim strSearchText As String = Me.txtSearchText.Text
        Dim intPosition As Integer

        For Each Str As String In strText
            intPosition = InStr(strText, strSearchText) 'In the string text search for the text and that becomes the position.
        Next


        Me.lblPositionsOfSearchText.Text = intPosition
    End Sub
End Class
