Public Class Form1
    'Daniel Bullock

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'Initialize input boxes
        Dim strfirstname As String = InputBox("Enter your first name", "First name")
        Dim strlastname As String = InputBox("Enter your last name", "Last name")
        Dim strFullname As String

        strFullname = strfirstname & " " & " " & strlastname
        Me.lblFullName.Text = strFullname
    End Sub
End Class
