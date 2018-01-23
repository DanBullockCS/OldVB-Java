'Daniel Bullock
'MyFile Chapter 11 Review

Imports System.IO
Public Class Form1
    Const FILE_NAME As String = "myfile.txt"

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Dim testFile As New FileInfo(FILE_NAME)
        If Not testFile.Exists Then                 'file does not exist
            testfile.Create()                       'create an empty file
            MessageBox.Show("New file created.")
            'display full path, name, and file size
            MessageBox.Show(testFile.FullName & " exists. File size: " & testFile.Length)
        End If
    End Sub

    Private Sub btnDeleteFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteFile.Click
        Dim testFile As New FileInfo(FILE_NAME)
        testFile.Delete()
        MessageBox.Show(testFile.FullName & " deleted.")
    End Sub
End Class
