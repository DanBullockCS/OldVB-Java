'Daniel Bullock
'Chapter 11 - Exercise 2

Imports System.IO
Public Class Form1
    Dim TotalScore As Double
    Dim AverageScore As Double
    Dim Number_Of_Numbers As Integer

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Me.lblTotal.Text = TotalScore 'label equals total score
    End Sub

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Me.lblAverage.Text = AverageScore 'label equals average score
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
        Dim value As Double

        'Clear text box of previous contents
        Me.txtStats.Text = Nothing

        Do While textFile.Peek > -1                 'check for the end of file
            lineOfText = textFile.ReadLine()
            'Display line of text
            If Double.TryParse(lineOfText, value) Then  'converts String into a double
                TotalScore += value
            End If
            AverageScore = TotalScore / Number_Of_Numbers
            Me.txtStats.Text &= lineOfText & vbCrLf
        Loop

        textFile.Close()    'Close files
        fs.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()  'close program
    End Sub
End Class
