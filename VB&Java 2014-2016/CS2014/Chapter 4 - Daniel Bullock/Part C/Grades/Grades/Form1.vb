Public Class Form1

    Private Sub btnEnterGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterGrade.Click
        'Define variables
        Static IntPass As Integer = 0
        Static IntFail As Integer = 0
        Dim Grade As Char = UCase(Me.txtboxGrade.Text) 'Upper case all letters

        Me.txtboxGrade.Text = Grade
        'If Statement
        If Me.txtboxGrade.Text = "A" Then
            IntPass += 1
        ElseIf Me.txtboxGrade.Text = "B" Then
            IntPass += 1
        ElseIf Me.txtboxGrade.Text = "C" Then
            IntPass += 1
        ElseIf Me.txtboxGrade.Text = "D" Then
            IntPass += 1
        ElseIf Me.txtboxGrade.Text = "F" Then
            IntFail += 1
        End If

        Me.lblPassed.Text = IntPass
        Me.lblFailed.Text = IntFail
    End Sub
End Class