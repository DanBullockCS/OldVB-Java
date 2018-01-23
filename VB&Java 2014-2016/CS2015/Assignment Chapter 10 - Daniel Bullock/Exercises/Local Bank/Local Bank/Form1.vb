'Daniel Bullock
'Local Bank - Form1
Public Class Form1
    Dim activeAcct As Account   'current account to receive transactions
    Dim accounts(-1) As Account 'array of accounts

    Private Sub btnBalanceInquiry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBalanceInquiry.Click
        MessageBox.Show("Account " & activeAcct.AcctNum & " has " &
        Format(activeAcct.Balance, "Currency"))
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim textEntered As String
        textEntered = InputBox("Enter amount of deposit:", Me.Text)

        'Test data entered
        Dim transCode As Boolean
        If textEntered = Nothing Then               'Cancel or empty text box
            activeAcct.MakeDeposit(0, transCode)
        Else                                        'characters entered
            activeAcct.MakeDeposit(Val(textEntered), transCode)
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
            activeAcct.MakeWithdrawal(0, transCode)
        Else                                    'characters entered
            activeAcct.MakeWithdrawal(Val(textEntered), transCode)
        End If

        If transCode Then
            MessageBox.Show("Problem with transaction.")
        End If
    End Sub

    Private Sub btnTransactions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTransactions.Click
        Me.lstTransactions.Items.Clear()                    'clear previous items
        activeAcct.ShowTransactions(Me.lstTransactions)
    End Sub

    Private Sub btnModifyAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifyAccount.Click
        Dim textEntered As String

        'Change first name
        textEntered = InputBox("First name is: " & activeAcct.FirstName & vbCrLf & "Enter new first name (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new first name
            activeAcct.FirstName = textEntered
        End If

        'Change last name
        textEntered = InputBox("Last name is: " & activeAcct.LastName & vbCrLf & "Enter new last name (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new last name
            activeAcct.LastName = textEntered
        End If

        'Change account number
        textEntered = InputBox("Account number is: " & activeAcct.AcctNum & vbCrLf & "Enter new account number (Cancel to keep the same):", Me.Text)
        'Test data entered
        If textEntered <> Nothing Then      'new last name
            activeAcct.AcctNum = textEntered
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.btnModifyAccount.Enabled = False
        Me.btnBalanceInquiry.Enabled = False
        Me.btnDeposit.Enabled = False
        Me.btnWithdrawal.Enabled = False
        Me.btnTransactions.Enabled = False
    End Sub

    Private Sub btnFindAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindAccount.Click
        Dim acctNum As String
        Dim acctIndex As Integer

        acctNum = InputBox("Enter the number of the account to retrieve:", "Find Account")
        acctIndex = GetAcctNum(acctNum)
        If acctIndex <> -1 Then
            'Set active account
            activeAcct = accounts(acctIndex)
            'Enable actions on active account
            Me.btnModifyAccount.Enabled = True
            Me.btnBalanceInquiry.Enabled = True
            Me.btnDeposit.Enabled = True
            Me.btnWithdrawal.Enabled = True
            Me.btnTransactions.Enabled = True
        Else
            MessageBox.Show("Invalid account.")
        End If
    End Sub

    Private Sub btnAddAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAccount.Click
        Dim firstName, lastName As String
        Dim initDeposit As Double
        Dim newAcct As Account

        firstName = InputBox("Enter the account holder's first name:", "First Name")
        lastName = InputBox("Enter the account holder's last name:", "Last Name")
        initDeposit = InputBox("Enter the account holder's initial deposit:", "Initial Deposit")

        'Create a new account and add to array of accounts
        newAcct = New Account(firstName, lastName, initDeposit)
        ReDim Preserve accounts(accounts.Length) 'increase array by 1
        accounts(accounts.length - 1) = newAcct
    End Sub
End Class
