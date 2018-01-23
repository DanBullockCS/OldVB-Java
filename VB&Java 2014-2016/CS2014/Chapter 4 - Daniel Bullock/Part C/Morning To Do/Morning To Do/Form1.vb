Public Class Form1

    Private Sub chkLunch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLunch.Click
        If chkLunch.Checked Then
            MessageBox.Show("Don't forget bottled water!")
        End If
    End Sub

    Private Sub btnAllDone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAllDone.Click
        If Not (Me.chkBed.Checked And Me.chkLunch.Checked And Me.chkHomework.Checked And Me.chkTeeth.Checked) Then
            MessageBox.Show("Did you forget something?")
        Else
            Application.Exit()  'Close program
        End If
    End Sub
End Class
