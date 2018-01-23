'Daniel Bullock
'Chapter 11 Review - Grade Calculator

Imports System.IO

Public Class Form1
    'File containing student data
    Const FILE_NAME As String = "stugrades.txt"

    'Number of grades entered for each students
    Const NUM_GRADES As Integer = 5

    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        'Adds a student name and five (5) grades to a data file. Clears
        'text boxes for a new record
        '
        'post: A data file has been created, if necessary, and opened for adding data
        '(append) to the end of existing data. Student name and five (5)
        'grades (numeric scores) have been added to the end of the file.
        '
        'create a new file if necessary and open file for appending data
        Dim fs As New FileStream(FILE_NAME, FileMode.Append, FileAccess.Write)
        Dim textFile As New StreamWriter(fs)

        'Write student name and data to file
        textFile.WriteLine(Me.txtStudentName.Text)
        textFile.WriteLine(Me.txtGrade1.Text)
        textFile.WriteLine(Me.txtGrade2.Text)
        textFile.WriteLine(Me.txtGrade3.Text)
        textFile.WriteLine(Me.txtGrade4.Text)
        textFile.WriteLine(Me.txtGrade5.Text)

        'Close stream writer and file stream
        textFile.Close()
        fs.Close()

        'Clear text boxes for new data
        Me.txtStudentName.Text = Nothing
        Me.txtGrade1.Text = Nothing
        Me.txtGrade2.Text = Nothing
        Me.txtGrade3.Text = Nothing
        Me.txtGrade4.Text = Nothing
        Me.txtGrade5.Text = Nothing
    End Sub

    Private Sub ShowGradesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowGradesToolStripMenuItem.Click
        'Reads students names and NUM_GRADES grades amd then displays 
        'each student name with an average score in a message box.
        '
        'post: Data has been read from data file and an average score
        'has been computed and displayed for each student.
        '
        Dim fs As New FileStream(FILE_NAME, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim student As String
        Dim totalScore, averageScore As Double

        Do While textFile.Peek > -1
            student = textFile.ReadLine                 'read student name
            totalScore = 0                              'intialize score for each student
            For studentNum As Integer = 1 To NUM_GRADES           'sum grades
                totalScore += Val(textFile.ReadLine)
            Next studentNum
            averageScore = Math.Round((totalScore / NUM_GRADES), 1)
            MessageBox.Show(student & " " & averageScore)
        Loop

        textFile.Close()
        fs.Close()
    End Sub

    Private Sub ClearGradesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearGradesToolStripMenuItem.Click
        'Deletes the existing data file.
        '
        'post: FILE_NAME file has been deleted.
        '
        Dim dataFile As New FileInfo(FILE_NAME)
        dataFile.Delete()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
