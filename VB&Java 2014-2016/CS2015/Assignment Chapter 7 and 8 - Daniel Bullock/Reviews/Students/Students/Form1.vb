Public Class Form1
    'Daniel Bullock
    'Students

    Structure Student
        Dim firstName As String
        Dim lastName As String
        Dim middleInitial As Char
        Dim gpa As Single
        Dim credits As Integer
        Dim stuYear As Level
    End Structure

    Dim Students(99) As Student
    Dim NewStudent As Student
   
    Enum Level
        Freshman = 0
        Sophomore = 1
        Junior = 2
        Senior = 3
    End Enum

    Private Sub btnAddStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        For firstname As Integer = 0 To Students.Length - 1
            NewStudent.firstName = Me.txtFirstName.Text
        Next firstname

        For lastname As Integer = 0 To Students.Length - 1
            NewStudent.lastName = Me.txtLastName.Text
        Next lastname

        For middleinitial As Integer = 0 To Students.Length - 1
            NewStudent.middleInitial = Me.txtMiddleInitial.Text
        Next middleinitial

        For gpa As Integer = 0 To Students.Length - 1
            NewStudent.gpa = Me.txtGPA.Text
        Next gpa

        For credits As Integer = 0 To Students.Length - 1
            NewStudent.credits = Me.txtCredits.Text
        Next credits

        For stuYear As Integer = 0 To Students.Length - 1
            NewStudent.stuYear = lstClassRanking.SelectedIndex
        Next
    End Sub

    Sub AddItem(ByRef studentArray() As String, ByVal NameToAdd As String)

    End Sub

    Private Sub btnShowStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowStudent.Click
        If InputBox("Enter the students last name:") = NewStudent.lastName Then
            MessageBox.Show("First name: " & NewStudent.firstName & vbCrLf & "Middle initial: " & NewStudent.middleInitial & vbCrLf & "Last name: " & NewStudent.lastName & vbCrLf & "GPA: " & NewStudent.gpa & vbCrLf & "Credits: " & NewStudent.credits & vbCrLf & "Class rank: " & StudentYear(NewStudent.stuYear))
        Else
            MessageBox.Show("Student not in the database.")
        End If
    End Sub

    Function StudentYear(ByRef stuYear As Level) As String
        Select Case stuYear
            Case Level.Freshman
                Return "Freshman"
            Case Level.Sophomore
                Return "Sophomore"
            Case Level.Junior
                Return "Junior"
            Case Level.Senior
                Return "Senior"
        End Select
        Return stuYear
    End Function

    Function FindItemIndex(

    End Function
End Class
