Public Class Form1
    'Daniel Bullock
    'Tuition Calculator part 3 of 3

    Private Sub DataChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Const UNDERGRADUATE_PER_HOUR As Decimal = 75
        Const GRADUATE_PER_HOUR As Decimal = 145
        Const THESIS_PER_HOUR As Decimal = 160
        Dim creditHours As Integer
        Dim tuition As Decimal

        If Me.cboCreditHours.SelectedIndex >= 0 Then 'list item selected
            creditHours = Val(Me.cboCreditHours.SelectedItem)
        Else
            creditHours = Val(Me.cboCreditHours.Text) 'value typed
        End If

        Select Case Me.lstCourseLevels.SelectedItem
            Case "Undergraduate"
                tuition = UNDERGRADUATE_PER_HOUR * creditHours
            Case "Graduate"
                tuition = GRADUATE_PER_HOUR * creditHours
            Case "Thesis and Dissertation"
                tuition = THESIS_PER_HOUR * creditHours
        End Select

        Me.lblTuition.Text = "Tuition is " & Format(tuition, "Currency")
    End Sub

    Private Sub cboCreditHours_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCreditHours.Click, lstCourseLevels.Click, cboCreditHours.TextChanged
        btnCalculate.Enabled = True
    End Sub

    Private Sub lstCourseLevels_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCourseLevels.SelectedIndexChanged, cboCreditHours.SelectedIndexChanged, cboCreditHours.TextChanged
        Me.lblTuition.Text = Nothing
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnCalculate.Enabled = False
    End Sub
End Class