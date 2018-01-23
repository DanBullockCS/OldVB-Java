Public Class Form1

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        'Define variables
        Dim intHours As Integer
        Dim dblRate As Double
        Dim dblNumber As Double
        Dim dblAnswer As Double
        'Insert variables into labels
        intHours = Me.txtboxHoursWorked.Text
        dblRate = Me.txtboxHourlyRate.Text
        'Calculations
        dblAnswer = intHours * dblRate
        'If/Then statement
        If radbtnNo.Checked Then
            dblNumber = dblAnswer * 0.18
            dblAnswer = dblAnswer - dblNumber
            Me.lblNoTaxDeductions.Text = ""
        ElseIf radbtnYes.Checked Then
            dblAnswer = intHours * dblRate
            Me.lblNoTaxDeductions.Text = "NO TAXES DEDUCTED"
        End If


        Me.lblGrossWages.Text = dblAnswer
    End Sub

    Private Sub txtboxHourlyRate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxHourlyRate.TextChanged
        Me.lblGrossWages.Text = ""
        Me.radbtnYes.Checked = False
        Me.radbtnNo.Checked = False
    End Sub

    Private Sub txtboxHoursWorked_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxHoursWorked.TextChanged
        Me.lblGrossWages.Text = ""
        Me.radbtnYes.Checked = False
        Me.radbtnNo.Checked = False
    End Sub
End Class
