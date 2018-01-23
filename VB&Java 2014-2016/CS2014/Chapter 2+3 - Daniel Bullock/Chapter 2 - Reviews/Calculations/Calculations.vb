Public Class Calculations

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExpression1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression1.Click
        Me.lblExpression1.Text = 5 + 2 ^ 3
        Me.lblExpression1.Visible = True
        Me.lblExpression2.Visible = False
        Me.lblExpression3.Visible = False
        Me.lblExpression4.Visible = False
    End Sub

    Private Sub btnExpression2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression2.Click
        Me.lblExpression2.Text = 4 / 2 + 5
        Me.lblExpression1.Visible = False
        Me.lblExpression2.Visible = True
        Me.lblExpression3.Visible = False
        Me.lblExpression4.Visible = False
    End Sub

    Private Sub btnExpression3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression3.Click
        Me.lblExpression3.Text = 3 + 4 * 2
        Me.lblExpression1.Visible = False
        Me.lblExpression2.Visible = False
        Me.lblExpression3.Visible = True
        Me.lblExpression4.Visible = False
    End Sub

    Private Sub btnExpression4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression4.Click
        Me.lblExpression4.Text = 7 - 3 + 2
        Me.lblExpression1.Visible = False
        Me.lblExpression2.Visible = False
        Me.lblExpression3.Visible = False
        Me.lblExpression4.Visible = True
    End Sub
End Class
