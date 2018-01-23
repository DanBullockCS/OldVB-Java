Public Class Form1

    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        'Step 1 Define variables
        Dim length1 As Double
        Dim length2 As Double
        Dim length3 As Double
        Dim Distance As Double
        'Step 2 move info into variable
        length1 = Val(Me.txtbox1.Text)
        length2 = Val(Me.txtbox2.Text)
        length3 = Val(Me.txtbox3.Text)
        'Step 3 do calculations
        Distance = length1 + length2 + length3
        'Step 4 move variables into label
        Me.lblAnswer.Text = Distance
    End Sub

    Private Sub txtbox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbox1.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
    Private Sub txtbox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbox2.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
    Private Sub txtbox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbox3.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
