Public Class Form1
    'Daniel Bullock

    Private Sub btnGenerateOddNumbersSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateOddNumbersSum.Click
        Dim MaxNumber As String = Val(Me.txtboxMaxNum.Text)
        Dim Sum As Integer = 0
        Dim IntNumber As Integer = 0

        For IntNumber = 1 To MaxNumber Step 2
            Sum += IntNumber
        Next

        Me.lblOddNumbersSum.Text = Sum

    End Sub

    Private Sub txtboxMaxNum_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxMaxNum.TextChanged
        Me.lblOddNumbersSum.Text = Nothing
    End Sub
End Class
