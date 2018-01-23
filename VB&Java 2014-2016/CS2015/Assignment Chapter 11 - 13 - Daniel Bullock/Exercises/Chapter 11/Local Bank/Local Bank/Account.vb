'Daniel Bullock
'Local Bank - Account
Public Class Account

    'Public field members

    Public Const MIN_REQUIRED_BALANCE As Decimal = 100 '$100
    Public Const LOW_BALANCE_FEE As Decimal = 1        '$1

    'Private data members

    Private acctNumber As String
    Private acctBalance As Decimal
    Private activity(-1) As Transaction
    Private customer As PersonalInfo

    Private Structure Transaction
        Dim transType As String
        Dim transCode As Boolean        'false if no errors
        Dim endingBalance As Decimal
    End Structure

    Private Structure PersonalInfo
        Dim firstName As String
        Dim lastName As String
    End Structure

    'Constructor

    Sub New(ByVal num As Double, ByVal FName As String, ByVal LName As String)
        Me.acctBalance = num
        Me.FirstName = FName
        Me.LastName = LName
        Me.acctNumber = (GetChar(FName, 1) & GetChar(LastName, 1) & GetChar(LastName, 2) & GetChar(LastName, 3) & GetChar(LastName, 4) & GetChar(LastName, 5))
        Me.AddTransaction("New Account", False, acctBalance)
    End Sub

    'Property members

    ReadOnly Property AcctNum As String
        Get
            Return acctNumber
        End Get
    End Property

    Property LastName() As String
    Property FirstName() As String

    ReadOnly Property Balance() As Decimal
        Get
            Return acctBalance
        End Get
    End Property

    'Protected methods

    Protected Sub AddTransaction(ByVal transaction As String, ByVal code As Boolean, ByVal currentBalance As Decimal)
        'Use Length to size array because the value is one greater than the
        'current highest index value
        ReDim Preserve activity(activity.Length)
        Dim newTransaction As Integer = activity.Length - 1

        activity(newTransaction).transType = transaction
        activity(newTransaction).transCode = code
        activity(newTransaction).endingBalance = currentBalance
    End Sub

    'Public methods

    Public Sub ShowTransactions(ByRef displayBox As ListBox)
        Dim currentTransaction As Transaction

        displayBox.Items.Add("Error" & vbTab & "Transaction" & vbTab & "Balance")
        For transNum As Integer = 0 To activity.Length - 1
            currentTransaction = activity(transNum)
            displayBox.Items.Add(currentTransaction.transCode & vbTab & currentTransaction.transType & vbTab & vbTab & currentTransaction.endingBalance)
        Next transNum
    End Sub

    Public Sub MakeDeposit(ByVal depositAmt As Decimal, ByRef errorCode As Boolean)
        If depositAmt > 0 Then          'valid deposit
            acctBalance += depositAmt
            errorCode = False
        Else                            'deposit not valid
            errorCode = True
        End If
        AddTransaction("Deposit", errorCode, acctBalance)
    End Sub

    Public Sub MakeWithdrawal(ByVal withdrawalAmt As Decimal, ByRef errorCode As Boolean)
        If withdrawalAmt <= acctBalance Then                        'make withdrawal
            acctBalance -= withdrawalAmt
            errorCode = False
            AddTransaction("Withdrawal", errorCode, acctBalance)
            'Determine if balance has fallen below required amount
            If acctBalance < MIN_REQUIRED_BALANCE Then      'service charge
                acctBalance -= LOW_BALANCE_FEE
                errorCode = False
                AddTransaction("Low Bal Fee", errorCode, acctBalance)
            End If
        Else
            errorCode = True
            AddTransaction("Withdrawal", errorCode, acctBalance)
        End If
    End Sub
End Class
