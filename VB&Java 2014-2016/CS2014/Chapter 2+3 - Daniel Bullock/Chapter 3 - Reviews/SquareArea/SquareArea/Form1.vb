Public Class Form1

    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        'Step 1 define the variable
        Dim side As Integer         'side of square
        Dim area As Integer
        'Step 2 move variables into text box'
        side = Val(Me.txtSide.Text)
        'Step 3 do calculations
        area = side * side
        'Step 4 Move variable into label
        Me.lblAnswer.Text = area    'display answer
    End Sub

    Private Sub txtSide_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSide.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
