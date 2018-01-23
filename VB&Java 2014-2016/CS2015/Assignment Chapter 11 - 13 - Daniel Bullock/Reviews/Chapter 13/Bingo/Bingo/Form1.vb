'Bingo
'Chapter 13 case study
'Lawrenceville Press
'February 16, 2011

Public Class Form1

    'File menu commands

    Private Sub Player1ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Player1ToolStripMenuItem.Click
        Static cardNum As Integer = 0
        Dim card As New BingoCard

        card.MdiParent = Me
        cardNum += 1
        card.Text = "Player 1 Card " & cardNum
        Call GenerateBingoCard(card)

        card.Show()
    End Sub

    Private Sub Player2ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Player2ToolStripMenuItem.Click
        Static cardNum As Integer = 0
        Dim card As New BingoCard

        card.MdiParent = Me
        cardNum += 1
        card.Text = "Player 2 Card " & cardNum
        Call GenerateBingoCard(card)

        card.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Windows menu commands

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    'Help menu commands

    Private Sub AboutBingoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutBingoToolStripMenuItem.Click
        Dim aboutDB As New AboutDialogBox
        aboutDB.ShowDialog()
    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HowToPlayToolStripMenuItem.Click
        Dim helpDB As New HelpDialogBox
        helpDB.ShowDialog()
    End Sub

    'Other procedures

    'Generates a bingo card of random, unique numbers
    '
    'pre: newCard has 5 columns of 5 buttons each.
    'post: Each newCard button has been assigned a unique random number
    'in the appropriate range for columns B, I, N, G, and O
    '
    Sub GenerateBingoCard(ByRef newCard As BingoCard)
        Dim bColumn() As Button = {newCard.btnBSlot1, newCard.btnBSlot2, newCard.btnBSlot3,
        newCard.btnBSlot4, newCard.btnBSlot5}
        Call GenerateColumn(bColumn, 1)

        Dim iColumn() As Button = {newCard.btnISlot1, newCard.btnISlot2, newCard.btnISlot3,
        newCard.btnISlot4, newCard.btnISlot5}
        Call GenerateColumn(iColumn, 16)

        Dim nColumn() As Button = {newCard.btnNSlot1, newCard.btnNSlot2, newCard.btnNSlot3,
        newCard.btnNSlot4, newCard.btnNSlot5}
        Call GenerateColumn(nColumn, 31)
        newCard.btnNSlot3.Text = "Free Space"

        Dim gColumn() As Button = {newCard.btnGSlot1, newCard.btnGSlot2, newCard.btnGSlot3,
        newCard.btnGSlot4, newCard.btnGSlot5}
        Call GenerateColumn(gColumn, 46)

        Dim oColumn() As Button = {newCard.btnOSlot1, newCard.btnOSlot2, newCard.btnOSlot3,
        newCard.btnOSlot4, newCard.btnOSlot5}
        Call GenerateColumn(oColumn, 61)
    End Sub

    'Sets the text for each button of btnArray to a unique random number
    'ranging from 0 to 14, offset by offset
    '
    'pre: btnArray contains 5 button objects
    'post: Each button in btnArray has been assigned a unique random 
    'number in the appropriate range
    '
    Sub GenerateColumn(ByRef btnArray() As Button, ByRef offset As Integer)
        Dim numbers(4) As Integer

        'Get a unique set of numbers
        Call UniqueNumbersArray(15, numbers)
        'Assign numbers to buttons
        For buttonNum As Integer = 0 To btnArray.Length - 1
            btnArray(buttonNum).Text = numbers(buttonNum) + offset
        Next buttonNum
    End Sub

    'Fills numArray with unique numbers ranging from 0 to maxValue.
    '
    'post: numArray contains unique integers ranging in value from 
    '0 to maxValue.
    '
    Sub UniqueNumbersArray(ByVal maxValue As Integer, ByRef numArray() As Integer)
        Dim numChecker(maxValue - 1) As Boolean    'defaults to False values
        Dim indexToCheck As Integer
        Dim index As Integer

        Randomize()
        'Generate numArray.Length - 1 unique numbers
        For num As Integer = 0 To numArray.Length - 1
            'Generate a random number until one that has not
            'already been generated comes up
            Do
                indexToCheck = Int(Rnd() * maxValue)
            Loop While numChecker(indexToCheck)
            numChecker(indexToCheck) = True
        Next num

        'Store selected index values in array
        For trueNum As Integer = 0 To numChecker.Length - 1
            If numChecker(trueNum) Then
                numArray(index) = trueNum
                'increment numArray index to store next number
                index += 1
            End If
        Next trueNum
    End Sub

    Private Sub btnNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNumber.Click
        Const RANGE As Integer = 75
        Static possibleCalls(RANGE - 1) As Boolean   'defaults to False values
        Dim callNumber As Integer

        'Generate Bingo call
        Randomize()
        Do
            'Generate random values until one that 
            'has not been called is generated
            callNumber = Int(Rnd() * RANGE)
        Loop While possibleCalls(callNumber)
        possibleCalls(callNumber) = True

        'Make call
        Select Case callNumber
            Case 0 To 14
                Me.btnNumber.Text = "B" & callNumber + 1
            Case 15 To 29
                Me.btnNumber.Text = "I" & callNumber + 1
            Case 30 To 44
                Me.btnNumber.Text = "N" & callNumber + 1
            Case 45 To 59
                Me.btnNumber.Text = "G" & callNumber + 1
            Case 60 To 74
                Me.btnNumber.Text = "O" & callNumber + 1
        End Select

        'Add call to numbers called list
        Me.lblCalled.Text &= Me.btnNumber.Text & vbCrLf
    End Sub
End Class
