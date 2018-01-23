Public Class Form1
    'Daniel Bullock
    'Customers

    Structure Customer      'Build Structure
        Dim Name As String
        Dim Balance As Decimal
    End Structure

    Dim Customers(4) As Customer     '5 customers
    Dim CustomerName As String
    Dim Average As Decimal
    Dim HighestBal As Decimal

    Private Sub btnCustomerInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerInfo.Click

        Customers(0).Name = InputBox("Enter first customers name:")                  'Enter 1st name
        Customers(0).Balance = InputBox("Enter first customers balance:")            'Enter 1st balance
        Customers(1).Name = InputBox("Enter second customers name:")                 'Enter 2nd name
        Customers(1).Balance = InputBox("Enter second customers balance:")           'Enter 2nd balance
        Customers(2).Name = InputBox("Enter third customers name:")                  'Enter 3rd name
        Customers(2).Balance = InputBox("Enter third customers balance:")            'Enter 3rd balance
        Customers(3).Name = InputBox("Enter fourth customers name:")                 'Enter 4th name
        Customers(3).Balance = InputBox("Enter fourth customers balance:")           'Enter 4th balance
        Customers(4).Name = InputBox("Enter fifth customers name:")                  'Enter 5th name
        Customers(4).Balance = InputBox("Enter fifth customers balance:")            'Enter 5th balance

        'Calling Procedures
        Call HighestBalance(HighestBal, CustomerName, Customers(0).Balance, Customers(1).Balance, Customers(2).Balance, Customers(3).Balance, Customers(4).Balance)
        Call AverageBalance(Average, Customers(0).Balance, Customers(1).Balance, Customers(2).Balance, Customers(3).Balance, Customers(4).Balance)

        'Move to labels:
        Me.lblHighestAccount.Text = "The customer with the highest account " & vbCrLf & " balance is: " & CustomerName & " with " & "$" & HighestBal
        Me.lblAverageAccount.Text = "The average account balance is: " & "$" & Average
    End Sub

    Sub HighestBalance(ByRef HighestBal As Decimal, ByRef CustomerName As String, ByVal Bal1 As Decimal, ByVal Bal2 As Decimal, ByVal Bal3 As Decimal, ByVal Bal4 As Decimal, ByVal Bal5 As Decimal)
        If Bal1 > Bal2 And Bal3 And Bal4 And Bal5 Then        'Tests for highest Balance
            HighestBal = Bal1
        ElseIf Bal2 > Bal1 And Bal3 And Bal4 And Bal5 Then
            HighestBal = Bal2
        ElseIf Bal3 > Bal1 And Bal2 And Bal4 And Bal5 Then
            HighestBal = Bal3
        ElseIf Bal4 > Bal1 And Bal2 And Bal3 And Bal5 Then
            HighestBal = Bal4
        ElseIf Bal5 > Bal1 And Bal2 And Bal3 And Bal4 Then
            HighestBal = Bal5
        End If

        If HighestBal = Bal1 Then                       'Finds the customer with the highest balances name
            CustomerName = Customers(0).Name
        ElseIf HighestBal = Bal2 Then
            CustomerName = Customers(1).Name
        ElseIf HighestBal = Bal3 Then
            CustomerName = Customers(2).Name
        ElseIf HighestBal = Bal4 Then
            CustomerName = Customers(3).Name
        ElseIf HighestBal = Bal5 Then
            CustomerName = Customers(4).Name
        End If
    End Sub

    Sub AverageBalance(ByRef Average As Decimal, ByVal Bal1 As Decimal, ByVal Bal2 As Decimal, ByVal Bal3 As Decimal, ByVal Bal4 As Decimal, ByVal Bal5 As Decimal)
        Average = (Bal1 + Bal2 + Bal3 + Bal4 + Bal5) / 5    'Find Average of balances
    End Sub
End Class
