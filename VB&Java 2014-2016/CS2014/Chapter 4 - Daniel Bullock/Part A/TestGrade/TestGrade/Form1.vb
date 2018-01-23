Public Class Form1

    Private Sub btnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrade.Click
        'Step 1: "Define variables"'
        Dim Intnumber As Integer
        'Step 2: move variables into text box'
        Intnumber = Val(Me.txtboxGrade.Text)
        'Step 3: If/Case Statement
        Select Case Intnumber
            Case Is >= 101
                MessageBox.Show("Invalid grade")
            Case Is <= 0
                MessageBox.Show("Invalid grade")
            Case Is >= 90
                Me.lblComment.Text = "A"
            Case Is >= 80
                Me.lblComment.Text = "B"
            Case Is >= 70
                Me.lblComment.Text = "C"
            Case Is >= 60
                Me.lblComment.Text = "D"
            Case Is >= 1
                Me.lblComment.Text = "F"
        End Select

    End Sub

    Private Sub txtboxGrade_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxGrade.TextChanged
        Me.lblComment.Text = ""
    End Sub
End Class

