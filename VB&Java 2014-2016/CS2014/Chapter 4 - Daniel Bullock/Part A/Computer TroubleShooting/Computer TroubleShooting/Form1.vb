Public Class Form1

    Private Sub btnWhatToDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhatToDo.Click
        If UCase(Me.txtboxBeep.Text) = "Y" And UCase(Me.txtboxSpin.Text) = "Y" Then
            Me.lblMessage.Text = "Contact tech support"
        ElseIf UCase(Me.txtboxBeep.Text) = "Y" And UCase(Me.txtboxSpin.Text) = "N" Then
            Me.lblMessage.Text = "Check drive contacts"
        ElseIf UCase(Me.txtboxBeep.Text) = "N" And UCase(Me.txtboxSpin.Text) = "N" Then
            Me.lblMessage.Text = "Bring Computer To Repair Center"
        ElseIf UCase(Me.txtboxBeep.Text) = "N" And UCase(Me.txtboxSpin.Text) = "Y" Then
            Me.lblMessage.Text = "Check the speaker connections"
        End If
    End Sub

    Private Sub txtboxBeep_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxBeep.TextChanged
        Me.lblMessage.Text = ""
    End Sub

    Private Sub txtboxSpin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxSpin.TextChanged
        Me.lblMessage.Text = ""
    End Sub
End Class
