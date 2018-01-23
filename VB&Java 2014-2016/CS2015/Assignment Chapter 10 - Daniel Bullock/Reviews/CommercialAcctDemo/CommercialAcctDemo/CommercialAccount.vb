Public Class CommercialAccount

    Inherits Account

    'Public field members

    Shadows Const MIN_REQUIRED_BALANCE As Decimal = 500 '$500
    Shadows Const LOW_BALANCE_FEE As Decimal = 10       '$10

    'Private data member

    Private commercialAcctName As String

    'Constructor

    Sub New(ByVal num As String, ByVal acctName As String)
        MyBase.New(num)         'call base class
        Me.commercialAcctName = acctName
    End Sub

    'Property member

    Property CompanyName() As String

    'Public method

    Public Sub Withdrawal(ByVal withdrawalAmt As Decimal, ByRef errorCode As Boolean)
        If withdrawalAmt <= acctBalance Then        'make withdrawal
            acctBalance -= withdrawalAmt
            errorCode = False
            AddTransaction("Withdrawal", errorCode, acctBalance)
            'Determine if balance has fallen below required amount
            If acctBalance < MIN_REQUIRED_BALANCE Then      'service charge
                acctBalance -= LOW_BALANCE_FEE
                errorCode = False
                AddTransaction("Low Bal Fee", errorCode, acctBalance)
            End If
        End If
    End Sub
End Class
