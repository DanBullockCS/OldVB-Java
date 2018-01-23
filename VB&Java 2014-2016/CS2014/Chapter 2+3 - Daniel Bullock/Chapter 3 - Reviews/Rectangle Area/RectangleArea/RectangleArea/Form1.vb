Public Class Form1

    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        'Step 1: "Define variables"'
        Dim side1 As Integer
        Dim side2 As Integer
        Dim area As Integer
        'Step 2: move variables into text box'
        side1 = Val(Me.txtbox1.Text)
        side2 = Val(Me.txtbox2.Text)
        'Step 3: do calculations
        area = side1 * side2
        'Step 4: Move variable into label
        Me.lblAnswer.Text = area
    End Sub

    Private Sub txtbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox1.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
