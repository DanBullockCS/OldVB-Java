Imports System.IO

Public Class Scores
    'Daniel Bullock
    'Scores Form

    Private Sub lblBackToMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBackToMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub lblBackToMenu_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBackToMenu.MouseLeave
        lblBackToMenu.BackColor = Color.Transparent
    End Sub

    Private Sub lblBackToMenu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblBackToMenu.MouseMove
        lblBackToMenu.BackColor = Color.Cyan
    End Sub

    Private Sub Scores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lstScores.Items.Clear()

        Dim fileName As String = "Scores.txt"
        Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim lineOfText As String
        Dim strArray(9) As String

        Do While textFile.Peek > -1                 'check for the end of file
            lineOfText = textFile.ReadLine()
            'Display line of text
            Me.lstScores.Items.Add(lineOfText & vbCrLf)
        Loop

        Call BubbleSort(strArray)

        textFile.Close()
        fs.Close()

    End Sub

    Sub BubbleSort(ByRef strArray() As String)
        Dim temp As String
        Dim swapRequired As Boolean = True          'flag

        Do While swapRequired
            swapRequired = False
            For testItem As Integer = 0 To strArray.Length - 2
                If strArray(testItem) > strArray(testItem + 1) Then
                    'Swap elements
                    temp = strArray(testItem)
                    strArray(testItem + 1) = temp
                    swapRequired = True
                End If
            Next testItem
        Loop
    End Sub
End Class