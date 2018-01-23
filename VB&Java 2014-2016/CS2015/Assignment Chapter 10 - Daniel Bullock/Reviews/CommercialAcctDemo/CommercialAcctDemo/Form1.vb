'Daniel Bullock
'Account Demo - Review
Public Class Form1
    Dim comAcct1 As New CommercialAccount("3985", "My Company")

    Private Sub btnBalanceInquiry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBalanceInquiry.Click
        MessageBox.Show("Account " & comAcct1.AcctNum & " has " &
        Format(comAcct1.Balance, "Currency"))
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim textEntered As String
        textEntered = InputBox("Enter amount of deposit:", Me.Text)

        'Test data entered
        Dim transCode As Boolean
        If textEntered = Nothing Then               'Cancel or empty text box
            comAcct1.MakeDeposit(0, transCode)
        Else                                        'characters entered
            comAcct1.MakeDeposit(Val(textEntered), transCode)
        End If

        If transCode Then
            MessageBox.Show("Problem with transaction.")
        End If
    End Sub

    Private Sub btnWithdrawal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWithdrawal.Click
        Dim textEntered As String
        textEntered = InputBox("Enter amount to withdraw:", Me.Text)

        'Test data entered
        Dim transCode As Boolean
        If textEntered = Nothing Then           'Cancel or empty text box
            comAcct1.MakeWithdrawal(0, transCode)
        Else                                    'characters entered
            comAcct1.MakeWithdrawal(Val(textEntered), transCode)
        End If

        If transCode Then
            MessageBox.Show("Problem with transaction.")
        End If
    End Sub

    Private Sub btnTransactions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTransactions.Click
        Me.lstTransactions.Items.Clear()                    'clear previous items
        comAcct1.ShowTransactions(Me.lstTransactions)
    End Sub

    Private Sub btnModifyAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifyAccount.Click
        Dim textEntered As String

        'Change first name
        textEntered = InputBox("First name is: " & comAcct1.FirstName & vbCrLf & "Enter new first name (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new first name
            comAcct1.FirstName = textEntered
        End If

        'Change last name
        textEntered = InputBox("Last name is: " & comAcct1.LastName & vbCrLf & "Enter new last name (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new last name
            comAcct1.LastName = textEntered
        End If

        'Change account number
        textEntered = InputBox("Account number is: " & comAcct1.AcctNum & vbCrLf & "Enter new account number (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new last name
            comAcct1.AcctNum = textEntered
        End If

        'Change company name
        textEntered = InputBox("Company name is: " & comAcct1.CompanyName & vbCrLf & "Enter new company name (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new company name
            comAcct1.CompanyName = textEntered
        End If
    End Sub
End Class
