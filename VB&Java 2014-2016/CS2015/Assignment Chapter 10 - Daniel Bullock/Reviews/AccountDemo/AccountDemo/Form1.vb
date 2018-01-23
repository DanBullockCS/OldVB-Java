'Daniel Bullock
'Account Demo - Review
Public Class Form1
    Dim acct1 As New Account("1234")

    Private Sub btnBalanceInquiry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBalanceInquiry.Click
        MessageBox.Show("Account " & acct1.AcctNum & " has " &
        Format(acct1.Balance, "Currency"))
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim textEntered As String
        textEntered = InputBox("Enter amount of deposit:", Me.Text)

        'Test data entered
        Dim transCode As Boolean
        If textEntered = Nothing Then               'Cancel or empty text box
            acct1.MakeDeposit(0, transCode)
        Else                                        'characters entered
            acct1.MakeDeposit(Val(textEntered), transCode)
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
            acct1.MakeWithdrawal(0, transCode)
        Else                                    'characters entered
            acct1.MakeWithdrawal(Val(textEntered), transCode)
        End If

        If transCode Then
            MessageBox.Show("Problem with transaction.")
        End If
    End Sub

    Private Sub btnTransactions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTransactions.Click
        Me.lstTransactions.Items.Clear()                    'clear previous items
        acct1.ShowTransactions(Me.lstTransactions)
    End Sub

    Private Sub btnModifyAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifyAccount.Click
        Dim textEntered As String

        'Change first name
        textEntered = InputBox("First name is: " & acct1.FirstName & vbCrLf & "Enter new first name (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new first name
            acct1.FirstName = textEntered
        End If

        'Change last name
        textEntered = InputBox("Last name is: " & acct1.LastName & vbCrLf & "Enter new last name (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new last name
            acct1.LastName = textEntered
        End If

        'Change account number
        textEntered = InputBox("Account number is: " & acct1.AcctNum & vbCrLf & "Enter new account number (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new last name
            acct1.AcctNum = textEntered
        End If

    End Sub
End Class
