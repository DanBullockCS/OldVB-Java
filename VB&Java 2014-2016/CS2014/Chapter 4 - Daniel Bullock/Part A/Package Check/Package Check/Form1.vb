Public Class Form1

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim intKilo As Integer
        Dim intLength As Integer
        Dim intWidth As Integer
        Dim intHeight As Integer

        intKilo = Val(Me.txtboxKilo.Text)
        intLength = Val(Me.txtboxCentiLength.Text)
        intWidth = Val(Me.txtboxCentiWidth.Text)
        intHeight = Val(Me.txtboxCentiHeight.Text)

        If intKilo >= 30 Then Me.lblAnswerWeight.Text = "Rejected: Too heavy"
        If intKilo < 30 Then Me.lblAnswerWeight.Text = "The Weight is acceptable"
        If intHeight + intLength + intWidth >= 100000 Then Me.lblAnswerSize.Text = "Rejected Too large"
        If intHeight + intLength + intWidth < 100000 Then Me.lblAnswerSize.Text = "The Size is acceptable"


    End Sub

    Private Sub txtboxCentiHeight_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxCentiHeight.TextChanged
        Me.lblAnswerSize.Text = ""
        Me.lblAnswerWeight.Text = ""
    End Sub

    Private Sub txtboxCentiLength_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxCentiLength.TextChanged
        Me.lblAnswerSize.Text = ""
        Me.lblAnswerWeight.Text = ""
    End Sub

    Private Sub txtboxCentiWidth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxCentiWidth.TextChanged
        Me.lblAnswerSize.Text = ""
        Me.lblAnswerWeight.Text = ""
    End Sub

    Private Sub txtboxKilo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxKilo.TextChanged
        Me.lblAnswerSize.Text = ""
        Me.lblAnswerWeight.Text = ""
    End Sub
End Class
