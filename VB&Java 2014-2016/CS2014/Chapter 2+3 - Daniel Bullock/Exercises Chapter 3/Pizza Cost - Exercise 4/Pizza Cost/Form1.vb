Public Class Form1

    Private Sub btnCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCost.Click
        'Step 1: "Define variables"'
        Dim Inches As Integer
        Dim diameter As Integer
        Dim cost As Double
        Dim materials As Double
        'Step 2: move variables into text box'
        Inches = diameter
        diameter = Val(Me.txtboxInches.Text)
        'Step 3: do calculations
        materials = 0.05 * diameter * diameter
        cost = 1.75 + materials
        'Step 4: Move variable into label
        Me.lblAnswer.Text = cost
    End Sub

    Private Sub txtboxInches_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxInches.TextChanged
        Me.lblAnswer.Text = ""
    End Sub
End Class
