Public Class Form1
    'Student Names
    'Daniel Bullock

    Private Sub btnAddNames_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNames.Click
        Const NUM_NAMES As Integer = 5
        Dim stuNames(NUM_NAMES - 1) As String

        'Get student names from user
        For nameCount As Integer = 0 To stuNames.Length - 1
            stuNames(nameCount) = InputBox("Enter student's first name:", "Students")
        Next nameCount

        'Add names to list box
        For nameCount As Integer = 0 To stuNames.Length - 1
            Me.lstStuNames.Items.Add(stuNames(nameCount))
        Next nameCount
    End Sub
End Class
