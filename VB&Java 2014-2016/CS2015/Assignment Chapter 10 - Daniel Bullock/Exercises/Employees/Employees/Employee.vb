Public Class Employee

    'Private field members

    Private employee As PersonalInfo
    Private payroll As PayrollInfo

    Private Structure PersonalInfo
        Dim employeeNum As String
        Dim firstName As String
        Dim lastName As String
    End Structure

    Private Structure PayrollInfo
        Dim hourlyRate As Decimal
        Dim regularHours As Decimal
        Dim overtimeHours As Decimal
    End Structure

    'Constructors

    Sub New(ByVal empNum As String)
        Me.employee.employeeNum = empNum
        Me.payroll.hourlyRate = 5
        Me.payroll.regularHours = 40
    End Sub

    Sub New(ByVal empNum As String, ByVal first As String, ByVal last As String)
        Me.employee.employeeNum = empNum
        Me.employee.firstName = first
        Me.employee.lastName = last
        Me.payroll.hourlyRate = 5
        Me.payroll.regularHours = 40
    End Sub

    'Property members

    Property EmployeeNum() As String
        Get
            Return employee.employeeNum
        End Get
        Set(ByVal value As String)
            employee.employeeNum = value
        End Set
    End Property

    Property FirstName() As String
        Get
            Return employee.firstName
        End Get
        Set(ByVal value As String)
            employee.firstName = value
        End Set
    End Property

    Property LastName() As String
        Get
            Return employee.lastName
        End Get
        Set(ByVal value As String)
            employee.lastName = value
        End Set
    End Property

    Property HourlyRate() As Decimal
        Get
            Return payroll.hourlyRate
        End Get
        Set(ByVal value As Decimal)
            payroll.hourlyRate = value
        End Set
    End Property

    Property RegularHours() As Decimal

    Property OvertimeHours() As Decimal

    'Public methods

    Public Function ShowPayAmt() As Decimal
        Return (RegularHours * HourlyRate + OvertimeHours * (HourlyRate * 1.5))
    End Function
End Class