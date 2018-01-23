'Daniel Bullock
'Chapter 11 Review - WriteFile

Imports System.IO
Public Class TextEditor

    Private Sub NewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.txtFileContents.Text = Nothing
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.txtFileContents.Text = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Me.SaveFileDialog1.ShowDialog()                         'display Save as dialog box
        Dim fileName As String = Me.SaveFileDialog1.FileName    'get file name
        Dim fs As New FileStream(fileName, FileMode.Create, FileAccess.Write)
        Dim textFile As New StreamWriter(fs)

        textFile.Write(Me.txtFileContents.Text)             'write text box contents to file

        textFile.Close()
        fs.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenFileDialog1.ShowDialog()         'open dialog box

        'Assign selected file name
        Dim fileName As String = Me.OpenFileDialog1.FileName

        'Display file contents
        If fileName <> Nothing Then
            Call ShowFileContents(fileName)
        End If
    End Sub

    Sub ShowFileContents(ByVal FileName As String)
        Dim fs As New FileStream(FileName, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim lineOfText As String

        'Clear text box of previous contents
        Me.txtFileContents.Text = Nothing

        Do While textFile.Peek > -1                 'check for the end of file
            lineOfText = textFile.ReadLine()
            'Display line of text
            Me.txtFileContents.Text &= lineOfText & vbCrLf
        Loop

        textFile.Close()
        fs.Close()
    End Sub

End Class
