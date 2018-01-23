Public Class Form1
    'Daniel Bullock

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim Firstletter As String = InputBox("Enter the first letter", "Letter")
        Dim Secondletter As String = InputBox("Enter the second letter", "Letter")
        Dim Thirdletter As String = InputBox("Enter the third letter", "Letter")
        Dim Fourthletter As String = InputBox("Enter the fourth letter", "Letter")
        Dim Fifthletter As String = InputBox("Enter the fifth letter", "Letter")
        Dim Sixthletter As String = InputBox("Enter the sixth letter", "Letter")
        Dim finalcode As String

        Firstletter = Firstletter.ToLower
        Secondletter = Secondletter.ToLower
        Thirdletter = Thirdletter.ToLower
        Fourthletter = Fourthletter.ToLower
        Fifthletter = Fifthletter.ToLower
        Sixthletter = Sixthletter.ToLower

        Firstletter = AscW(Firstletter)
        Secondletter = AscW(Secondletter)
        Thirdletter = AscW(Thirdletter)
        Fourthletter = AscW(Fourthletter)
        Fifthletter = AscW(Fifthletter)
        Sixthletter = AscW(Sixthletter)

        'Statement
        finalcode = Firstletter & Secondletter & Thirdletter & Fourthletter & Fifthletter & Sixthletter

        Me.lblMessage.Text = finalcode
    End Sub
End Class
