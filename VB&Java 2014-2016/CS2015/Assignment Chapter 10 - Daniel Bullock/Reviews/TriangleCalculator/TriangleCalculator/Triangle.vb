'Triangle class
'Chapter 10 Case Study
'Lawrenceville Press
'February 16, 2011

Public Class Triangle

    'Private data members

    Private sideA As Double
    Private sideB As Double
    Private sideC As Double
    Private semiperimeter As Double

    'Constructor

    Sub New(ByVal a As Double, ByVal b As Double, ByVal c As Double)
        Me.sideA = a
        Me.sideB = b
        Me.sideC = c
        Me.semiperimeter = 0.5 * (sideA + sideB + sideC)
    End Sub

    'Property members

    Property Side_a() As Double
        
    Property Side_b() As Double
       
    Property Side_c() As Double
       
    ReadOnly Property s() As Double
        Get
            Return semiperimeter
        End Get
    End Property

    'Private method

    'Returns True if sides a, b, and c are valid for a triangle.
    '
    'pre: side a < side b < side c
    'post: True has been returned if the sum of sides a and b
    'are greater than side c. False has been returned otherwise.
    '
    Private Function IsValidTriangle() As Boolean
        If sideA + sideB > sideC Then
            Return True
        Else
            Return False
        End If
    End Function

    'Public methods

    'Returns the area of a valid triangle, -1 returned otherwise.
    '
    'post: The area of this triangle has been returned if sides
    'a, b, and c make up a valid triangle. -1 has been returned 
    'otherwise.
    '
    Public Function GetArea() As Double
        If IsValidTriangle() Then
            'Heron's formula
            Return Math.Sqrt(semiperimeter * (semiperimeter - sideA) * _
            (semiperimeter - sideB) * (semiperimeter - sideC))
        Else
            Return -1
        End If
    End Function

    'Returns the type (right, acute, or obtuse) of a valid
    'triangle, Not Valid returned otherwise.
    '
    'post: The type of the triangle has been returned if sides
    'a, b, and c make up a valid triangle. Not Valid has been
    'returned otherwise.
    '
    Public Function GetName() As String
        If IsValidTriangle() Then
            Select Case sideC ^ 2
                Case sideA ^ 2 + sideB ^ 2
                    Return "Right Triangle"
                Case Is < sideA ^ 2 + sideB ^ 2
                    Return "Acute Triangle"
                Case Else
                    Return "Obtuse Triangle"
            End Select
        Else
            Return "Not Valid"
        End If
    End Function

    'Public methods

    'Returns the height of a valid triangle, -1 returned otherwise.

    Public Function GetHeight() As Double
        If IsValidTriangle() Then
            Return GetArea() * 2 / sideC
        Else
            Return -1
        End If
    End Function
End Class
