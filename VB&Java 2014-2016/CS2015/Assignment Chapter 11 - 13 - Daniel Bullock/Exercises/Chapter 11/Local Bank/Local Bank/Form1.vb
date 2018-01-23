'Daniel Bullock
'Local Bank - Form1 (Chapter 11 Version)

Imports System.IO
Public Class Form1
    Dim ActiveAcct As Account           'current account to receive transactions
    Dim Accounts(-1) As Account         'array as account

    Private Sub btnBalanceInquiry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBalanceInquiry.Click
        MessageBox.Show("Account " & ActiveAcct.AcctNum & " has " & Format(ActiveAcct.Balance, "Currency"))
    End Sub

    Private Sub btnDeposit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        Dim textEntered As String
        textEntered = InputBox("Enter amount of deposit:", Me.Text)

        'test data entered
        Dim transCode As Boolean
        If textEntered = Nothing Then      'cancel or empty text box
            ActiveAcct.MakeDeposit(0, transCode)
        Else                                'characters entered
            ActiveAcct.MakeDeposit(Val(textEntered), transCode)
        End If

        If transCode Then
            MessageBox.Show("Problem with transaction.")
        End If
    End Sub

    Private Sub btnWithdrawal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWithdrawal.Click
        Dim textEntered As String
        textEntered = InputBox("Enter amount to withdraw:", Me.Text)

        'test data entered
        Dim transCode As Boolean
        If textEntered = Nothing Then               'cancel or empty text box
            ActiveAcct.MakeWithdrawal(0, transCode)
        Else                                        'characters entered 
            ActiveAcct.MakeWithdrawal(Val(textEntered), transCode)
        End If

        If transCode Then
            MessageBox.Show("Problem with transaction.")
        End If
    End Sub

    Private Sub btnTransactions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTransactions.Click
        Me.lstTransactions.Items.Clear()            'clear previous items
        lstTransactions.Items.Add("Account: " & ActiveAcct.AcctNum)
        ActiveAcct.ShowTransactions(Me.lstTransactions)
    End Sub

    Private Sub btnModifyAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModifyAccount.Click
        Dim textEntered As String

        'Change first name
        textEntered = InputBox("First name is: " & ActiveAcct.FirstName & vbCrLf & "Enter new first name(Cancel to keep the same):", Me.Text)
        'test data entered
        If textEntered <> Nothing Then      'new first name
            ActiveAcct.FirstName = textEntered
        End If

        'change last name
        textEntered = InputBox("Last name is: " & ActiveAcct.LastName & vbCrLf & "Enter new last name (Cancel to keep the same):", Me.Text)
        'test data entered
        If textEntered <> Nothing Then      'new last name
            ActiveAcct.LastName = textEntered
        End If

    End Sub
    Function GetAcctNum(ByVal FindNum As String) As Integer
        Dim index As Integer

        Do Until Accounts(index).AcctNum = FindNum Or index = Accounts.Length
            index += 1
        Loop
        If index = Accounts.Length Then
            Return -1
        Else
            Return index
        End If
    End Function

    Private Sub btnFindAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFindAccount.Click
        Dim acctNum As String
        Dim acctIndex As String

        acctNum = InputBox("Enter the first initial of the first name and the first five letters of the last name of the account to retrieve:", "Find Account")
        acctIndex = GetAcctNum(acctNum)
        If acctIndex <> -1 Then
            'Set active account
            ActiveAcct = Accounts(acctIndex)
            'Enable actions on active account
            Me.btnBalanceInquiry.Enabled = True
            Me.btnDeposit.Enabled = True
            Me.btnModifyAccount.Enabled = True
            Me.btnTransactions.Enabled = True
            Me.btnWithdrawal.Enabled = True
        Else
            MessageBox.Show("Invalid account.")
        End If
    End Sub

    Private Sub btnAddAccount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddAccount.Click
        Dim firstName, lastName As String
        Dim initDeposite As Double
        Dim newAcct As Account

        firstName = InputBox("Enter the account holder's first name:", "First Name")
        lastName = InputBox("Enter the account holder's last name:", "Last Name")
        initDeposite = InputBox("Enter the account holder's initial deposit:", "Initial Deposit")

        'Create new account and add to array of accounts
        newAcct = New Account(initDeposite, firstName, lastName)
        ReDim Preserve Accounts(Accounts.Length)     'increase array by 1
        Accounts(Accounts.Length - 1) = newAcct

    End Sub

    Private Sub OpenAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAccountsToolStripMenuItem.Click
        Dim fileName As String = Me.OpenFileDialog1.FileName
        Dim fs As New FileStream(FileName, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim lineOfText As String
        Me.OpenFileDialog1.ShowDialog()         'open dialog box

        Do While textFile.Peek > -1                 'check for the end of file
            lineOfText = textFile.ReadLine()
        Loop

    End Sub

    Private Sub CloseAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAccountsToolStripMenuItem.Click

    End Sub
End Class
