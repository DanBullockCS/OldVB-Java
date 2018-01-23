
Public Class EnterName
    Dim PlayerName As String

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Form1.Show()
        Me.Visible = False
    End Sub

    Private Sub txtPlayerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlayerName.TextChanged
        If Me.txtPlayerName.Text <> Nothing Then
            btnOk.Enabled = True
            PlayerName = Me.txtPlayerName.Text
        ElseIf Me.txtPlayerName.Text = Nothing Then
            btnOk.Enabled = False
        End If
    End Sub
End Class