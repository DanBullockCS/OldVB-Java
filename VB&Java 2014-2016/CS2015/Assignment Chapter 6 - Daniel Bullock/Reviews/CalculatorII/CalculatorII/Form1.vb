Public Class Form1
    'Daniel Bullock
    'CalculatorII

    Dim operand1 As Double = 0
    Dim operand2 As Double = 0
    Dim op As String = Nothing
    Dim newOperand As Boolean = True

    'Updates the calculator display
    '
    'pre: Global variable newOperand is True when the current display should be changed to a 
    'new number and False when the current display should be updated with a new digit.
    'The Tag property of the button clicked contains the number corresponding to the 
    'number on the button.
    'post: The calculator display has been updated to show a new number or an
    'additional digit.
    '
    Private Sub Number_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
    btnDot.Click, btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, _
    btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim btnNumberClicked As Button = sender
        If newOperand Then
            Me.txtDisplay.Text = btnNumberClicked.Tag
            newOperand = False
        Else
            Me.txtDisplay.Text &= btnNumberClicked.Tag
        End If
    End Sub

    'Clears the calculator display
    '
    'post: The calculator display has been changed to 0 and the global variables 
    'have been reinitialized.
    '
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtDisplay.Text = "0"
        operand1 = 0
        operand2 = 0
        newOperand = True
        op = Nothing
    End Sub

    'Ends the applications
    '
    'post: The application is ended
    '
    Private Sub btnOff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOff.Click
        Application.Exit()
    End Sub

    'Updates the value of the operands and updates the calculator display to show the result of a 
    'calculation if two operands have been entered
    '
    'post: The calculator display has been changed to show the result of a calculation if a second 
    'operator had been clicked, otherwise the display has not been changed.
    '
    Private Sub btnOperator_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlus.Click, btnMinus.Click, btnTimes.Click, btnDivide.Click, btnEqual.Click, btnIntegerDivide.Click
        Dim operatorSelected As Button = sender

        'No operator previously clicked or a calculation just performed
        If (operand1 = 0 And op = Nothing) Or op = "=" Then
            operand1 = Val(Me.txtDisplay.Text)
        Else    'second operand entered and a second operator clicked
            operand2 = Val(Me.txtDisplay.Text)
            operand1 = Calculate(operand1, operand2, op)
            Me.txtDisplay.Text = operand1
        End If

        'Store operator for use when the next operator is clicked
        op = operatorSelected.Tag
        newOperand = True
    End Sub

    'Performs a calculation using two operands and an operator
    '
    'post: The result of a calculation has been returned
    '
    Function Calculate(ByVal firstOperand As Double, ByVal secondOperand As Double, ByVal op As String) As Double
        Select Case op
            Case "+"
                Return (firstOperand + secondOperand)
            Case "-"
                Return (firstOperand - secondOperand)
            Case "x"
                Return (firstOperand * secondOperand)
            Case "/"
                If secondOperand = 0 Then
                    MessageBox.Show("ERROR")
                Else
                    Return (firstOperand / secondOperand)
                End If
            Case "\"
                If secondOperand = 0 Then
                    MessageBox.Show("ERROR")
                Else
                    Return (firstOperand \ secondOperand)
                End If

        End Select
    End Function
End Class
