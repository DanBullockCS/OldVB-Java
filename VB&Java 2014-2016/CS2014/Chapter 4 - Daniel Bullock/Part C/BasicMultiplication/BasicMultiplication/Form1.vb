Public Class Form1

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        'Define Variables
        Dim IntNum1 As Integer
        Dim IntNum2 As Integer
        Dim Answer As Integer

        'Move variables into NumericUpDown
        IntNum1 = Me.NumUpDown1.Value
        IntNum2 = Me.NumUpDown2.Value

        'Calulation
        Answer = IntNum1 * IntNum2

        'Move Answer into label
        Me.lblAnswer.Text = Answer
    End Sub
End Class
