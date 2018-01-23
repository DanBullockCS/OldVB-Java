Public Class Account

    'Public field members

    Public Const MIN_REQUIRED_BALANCE As Decimal = 100 '$100
    Public Const LOW_BALANCE_FEE As Decimal = 1        '$1

    'Private field member

    Public Const DEFAULT_ACCT_NUM As String = "0000"

    'Protected data members

    Protected acctNumber As String
    Protected acctBalance As Decimal

    'Private data members

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

    Sub New()
        Me.New(DEFAULT_ACCT_NUM)
    End Sub

    Sub New(ByVal num As String)
        Me.acctNumber = num
        Me.acctBalance = 0
        Me.AddTransaction("New Account", False, acctBalance)
    End Sub

    Sub New(ByVal initialDeposit As Decimal)
        Me.acctNumber = DEFAULT_ACCT_NUM
        Me.acctBalance = initialDeposit
        Me.AddTransaction("New Account", False, acctBalance)
    End Sub

    Sub New(ByVal num As String, ByVal fName As String, ByVal lName As String)

        Me.acctNumber = num
        Me.acctBalance = 0
        Me.FirstName = fName
        Me.LastName = lName
        Me.AddTransaction("New Account", False, acctBalance)
    End Sub

    'Property members

    Property AcctNum As String
        Get
            Return acctNumber
        End Get
        Set(ByVal value As String)
            Const PASSWORD As String = "money"
            Dim passwordEntered As String = InputBox("Enter password:")
            If passwordEntered = PASSWORD Then
                acctNumber = value
            End If
        End Set
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

        displayBox.Items.Add("Error" & vbTab & "Transactions" & vbTab & "Balance")
        For transNum As Integer = 0 To activity.Length - 1
            currentTransaction = activity(transNum)
            displayBox.Items.Add(currentTransaction.transCode & vbTab &
            currentTransaction.transType & vbTab & vbTab & currentTransaction.endingBalance)
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

    Public Overridable Sub MakeWithdrawal(ByVal withdrawalAmt As Decimal, ByRef errorCode As Boolean)
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
