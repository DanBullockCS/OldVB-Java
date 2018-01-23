Public Class Form1
    'Daniel Bullock
    Private Sub btnMonogram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonogram.Click
        Dim name As String
        Dim intfirst As String
        Dim intmiddle As String
        Dim intlast As String
        Dim intspaces As Integer

        name = Me.txtNames.Text
        intspaces = name.IndexOf(" ")
        intfirst = name.Substring(0, 1)

        If intspaces = -1 Then
            intmiddle = Nothing
        Else
            intmiddle = name.Substring(intspaces + 1, 1)
            intspaces = name.IndexOf(" ", intspaces + 1)
        End If

        If intspaces = -1 Then
            intlast = Nothing
        Else
            intlast = name.Substring(intspaces + 1, 1)
        End If

        Me.lblAnswer.Text = String.Concat(intfirst.ToLower, intlast.ToUpper, intmiddle.ToLower)

    End Sub
End Class
