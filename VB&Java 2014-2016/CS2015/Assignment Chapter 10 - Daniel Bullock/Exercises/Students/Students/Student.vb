'Student Class

Public Class Student

    'Private Members

    Private Maximum As Integer
    Private Minimum As Integer
    Private Average As Integer

    'Property Members

    Property FirstName As String
    Property LastName As String

    'Constructor

    Sub New(ByVal FirstName As String, ByVal lastName As String)
        Me.FirstName = FirstName
        Me.LastName = lastName
    End Sub

    ReadOnly Property FullName As String
        Get
            FullName = FirstName & " " & LastName
            Return FullName
        End Get
    End Property

    ReadOnly Property Avg As Integer
        Get
            Return Average
        End Get
    End Property

    ReadOnly Property Max As Integer
        Get
            Return Maximum
        End Get
    End Property

    ReadOnly Property Min As Integer
        Get
            Return Minimum
        End Get
    End Property

    'Public Method

    Public Sub NewScore(ByVal score As Integer)
        Static ScoreEntered As Integer = 0
        Static Total As Integer

        If ScoreEntered = 0 Then
            Minimum = score
            Maximum = score
        End If

        If Maximum < score Then
            Maximum = score
        End If

        If Minimum > score Then
            Minimum = score
        End If

        ScoreEntered += 1
        Total += score
        Average = Total / ScoreEntered
    End Sub
End Class
