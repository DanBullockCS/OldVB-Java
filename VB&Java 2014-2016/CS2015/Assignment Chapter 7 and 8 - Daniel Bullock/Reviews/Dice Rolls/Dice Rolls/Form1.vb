'Dice Rolls
'Daniel Bullock

Public Class Form1

    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click
        Dim counts(12) As Integer
        Dim numRolls As Integer = Val(Me.txtRolls.Text)

        Call CountTrials(numRolls, counts)
        Call DisplayRollsCounts(counts, Me.lstRolls)
    End Sub

    'Simulates numRolls rolls of two dice and keeps a count of the 
    'outcomes.
    '
    'pre: counts has elements with at least index values 2 through 12.
    'post: numRolls dice rolls have been simulated. Counts of numRolls 
    'simulated dice rolls has been stored in counts.
    '
    Sub CountTrials(ByVal numRolls As Integer, ByRef counts() As Integer)
        Dim rollOutcome As Integer

        Randomize()
        For roll As Integer = 1 To numRolls
            rollOutcome = (Int(6 * Rnd() + 1)) + (Int(6 * Rnd() + 1))
            counts(rollOutcome) += 1
        Next roll
    End Sub

    'Displays the contents of counts() in a list box.
    '
    'pre: counts has elements with at least index values 2 through 12.
    'post: Elements of counts() have been displayed in a list box.
    '
    Sub DisplayRollsCounts(ByRef counts() As Integer, ByRef lstList As ListBox)

        For rollOutcome As Integer = 2 To 12
            lstList.Items.Add(rollOutcome & vbTab & counts(rollOutcome))
        Next rollOutcome
    End Sub

    Private Sub txtRolls_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lstRolls.Items.Clear()
    End Sub
End Class

