'Daniel Bullock
'Exercise 10 - Chapter 11
Imports System.IO
Public Class Form1

    Private Sub btnMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMerge.Click
        Dim fileName1 As String = Me.txtFile1.Text
        Dim fileName2 As String = Me.txtFile2.Text
        Dim MergedFile As String = "MergedFile.dat"

        Call ReadFile1(fileName1)
        Call ReadFile2(fileName2)
        Call MergeFiles(MergedFile)
    End Sub

    Sub ReadFile1(ByRef fileName1 As String) 'reads file 1
        Dim fs As New FileStream(fileName1, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim lineOfText As String

        Do While textFile.Peek > -1                 'check for the end of file
            lineOfText = textFile.ReadLine()
            'Display line of text
            Me.txtFileReader.Text &= lineOfText & vbCrLf
        Loop

        textFile.Close()
        fs.Close()
    End Sub

    Sub ReadFile2(ByRef fileName2 As String)    'reads file 2
        Dim fs As New FileStream(fileName2, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim lineOfText As String
        Do While textFile.Peek > -1                 'check for the end of file
            lineOfText = textFile.ReadLine()
            'Display line of text
            Me.txtFileReader.Text &= lineOfText & vbCrLf
        Loop

        textFile.Close()
        fs.Close()
    End Sub

    Sub MergeFiles(ByRef MergedFile As String)  'Creates a file from whats in the textbox
        Dim fileName As String = MergedFile
        Dim fs As New FileStream(fileName, FileMode.Create, FileAccess.Write)
        Dim textFile As New StreamWriter(fs)

        textFile.Write(Me.txtFileReader.Text)             'write text box contents to file

        textFile.Close()
        fs.Close()
    End Sub
End Class
