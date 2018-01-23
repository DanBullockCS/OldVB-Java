Public Class Form1
    'Daniel Bullock

    Private Sub btnCalculateSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateSum.Click
        Dim StartNum As Integer = Val(Me.txtStart.Text)
        Dim EndNum As Integer = Val(Me.txtEnd.Text)
        Dim Sum As Integer

        For counter As Integer = StartNum To EndNum Step 1
            Sum += counter
        Next

        Me.lblSum.Text = StartNum & " + " & " Numbers in between + " & EndNum & " = " & Sum
    End Sub

    Private Sub txtEnd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnd.TextChanged
        Me.lblSum.Text = Nothing
    End Sub

    Private Sub txtStart_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStart.TextChanged
        Me.lblSum.Text = Nothing
    End Sub
End Class
