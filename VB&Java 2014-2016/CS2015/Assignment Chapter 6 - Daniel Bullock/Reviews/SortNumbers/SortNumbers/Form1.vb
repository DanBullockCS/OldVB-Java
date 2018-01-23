Public Class Form1
    'Daniel Bullock

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim FirstNum As Integer
        Dim SecondNum As Integer

        FirstNum = Val(Me.txtFirstNumber.Text)
        SecondNum = Val(Me.txtSecondNumber.Text)

        Call Sorting(Me.lblOrder, FirstNum, SecondNum)
    End Sub

    Sub Sorting(ByRef lblOrder As Label, ByRef FirstNum As Integer, ByRef SecondNum As Integer)
        If FirstNum < SecondNum Then
            lblOrder.Text = FirstNum & ", " & SecondNum
        Else
            lblOrder.Text = SecondNum & ", " & FirstNum
        End If
    End Sub

    Private Sub txtFirstNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirstNumber.TextChanged
        Me.lblOrder.Text = Nothing
    End Sub

    Private Sub txtSecondNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSecondNumber.TextChanged
        Me.lblOrder.Text = Nothing
    End Sub
End Class