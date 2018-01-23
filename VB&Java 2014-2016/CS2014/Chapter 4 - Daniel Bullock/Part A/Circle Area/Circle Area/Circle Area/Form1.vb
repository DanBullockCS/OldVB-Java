Public Class Form1

    Private Sub btnArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArea.Click
        'Step 1: "Define variables"'
        Const PI As Double = 3.14
        Dim radius As Double
        Dim Area As Double
        'Step 2: move variables into text box'
        radius = Val(Me.txtboxRadius.Text)
        'Step 3: do calculations
        Area = PI * radius * radius
        'Step 4: Move variable into label
        Me.lblAnswer.Text = Area

        If txtboxRadius.Text <= 0 Then
            Me.lblAnswer.Text = "Negative radii are illegal"
        End If
    End Sub

    Private Sub txtboxRadius_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxRadius.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
