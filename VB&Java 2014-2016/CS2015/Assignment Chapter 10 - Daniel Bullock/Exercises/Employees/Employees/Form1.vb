'Daniel Bullock
'Employees Exercise 2

Public Class Form1
    Dim position As Integer = -1 'position (index) in array

    Private Sub AddEmployee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEmployeeNumAndNames.Click, _
        btnEmployeeNumOnly.Click
        Static employees(-1) As Employee
        Dim ButtonClicked As Button = sender

        If Me.txtEmployeeNumber.Text = Nothing Then
            MessageBox.Show("Type the Employee number in the text box")
        Else
            'Check for the name in the array
            For index As Integer = 0 To employees.Length - 1
                If employees(index).FirstName = Me.txtEmployeeNumber.Text Then
                    position = index
                End If
            Next index

            If position = -1 Then 'name was not in the array, so add the student and increase the array's size
                ReDim Preserve employees(employees.Length)
                position = employees.Length - 1
                employees(position) = New Employee(Me.txtEmployeeNumber.Text)
            End If

            Select Case ButtonClicked.Tag
                Case "Employee#only"
            End Select
        End If
    End Sub

    Private Sub DisplayInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplayInfo.Click, btnPaycheck.Click
        Static employees(-1) As Employee
        Dim ButtonClicked As Button = sender
        Select Case ButtonClicked.Tag
            Case "Displayinfo"
                Me.lblOutput.Text = (employees(position).FirstName & employees(position).LastName & employees(position).HourlyRate & employees(position).RegularHours & employees(position).OvertimeHours)
            Case "Paycheck"
                Me.lblMoney.Text = employees(position).ShowPayAmt
        End Select
    End Sub

    Private Sub UpdateEmployeeInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHourlyRate.Click, _
        btnFirstName.Click, btnLastName.Click, btnOvertimeHours.Click, btnRegularHours.Click
        Static employees(-1) As Employee
        Dim ButtonClicked As Button = sender
    End Sub

    Private Sub txtEmployeeNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmployeeNumber.TextChanged
        Me.lblMoney.Text = Nothing
        Me.lblOutput.Text = Nothing
    End Sub
End Class
