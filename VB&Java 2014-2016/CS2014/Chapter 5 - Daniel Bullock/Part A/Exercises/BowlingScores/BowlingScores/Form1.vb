Public Class Form1
    'Daniel Bullock

    Dim intHighScore As Integer = 0
    Dim intLowScore As Integer = 0
    Dim intCount As Integer = 0
    Dim intAverage As Integer 
    Private Sub BtnEnterScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterScores.Click
        'Define variables
        Dim intBowlingScores As Integer
        Dim PROMPT As String = "Enter bowling scores: (-1 to stop)"
        Dim TITLE As String = "Enter scores"
        Dim FLAG As Integer = -1
        
        Do While intBowlingScores <> FLAG
            intBowlingScores = InputBox(PROMPT, TITLE)

            If intBowlingScores >= intHighScore And intHighScore <> FLAG Then
                intHighScore = intBowlingScores
            End If

            If intLowScore >= intBowlingScores And intLowScore <> FLAG Then
                intLowScore = intBowlingScores
            End If

            If intBowlingScores <> FLAG Then
                intAverage = intAverage + intBowlingScores
                intCount += 1
            End If

        Loop
    End Sub

    Private Sub BtnStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStats.Click
        'High and low scores
        Me.lblAnswer1.Text = "The High score is " & intHighScore & " and "
        Me.lblAnswer2.Text = "the Low score is " & intLowScore
        'Average
        intAverage = intAverage / intCount
        Me.lblAverage.Text = "The average is " & intAverage
    End Sub

End Class
