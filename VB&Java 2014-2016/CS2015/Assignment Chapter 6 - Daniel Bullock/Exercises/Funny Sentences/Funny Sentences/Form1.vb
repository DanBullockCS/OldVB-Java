Public Class Form1
    'Daniel Bullock
    'Funny Sentences

    Dim Noun As String
    Dim Verb As String
    Dim Adjective As String

    Private Sub btnCreateSentence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSentence.Click
        Dim Sentence As Integer
      
        Noun = Me.txtNoun.Text
        Verb = Me.txtVerb.Text
        Adjective = Me.txtAdjective.Text

        Call CreateSentence(Sentence)
    End Sub

    Sub CreateSentence(ByVal RandomNum As Integer)
        Randomize()
        RandomNum = Int(5 * Rnd() + 1) 'random sentences from 1 to 5

        Select Case RandomNum 'Give random sentences
            Case 1
                Me.lblSentence.Text = "The " & Adjective & " " & Noun & " " & Verb & " the sandwich."
            Case 2
                Me.lblSentence.Text = Adjective & " " & Noun & " " & Verb & " to the scary mountain."
            Case 3
                Me.lblSentence.Text = "Jake and " & Adjective & " " & Noun & " " & Verb & " to" & " Albuquerque " & "."
            Case 4
                Me.lblSentence.Text = "The " & Adjective & " " & Noun & " " & Verb & " to a cliff."
            Case 5
                Me.lblSentence.Text = "23 " & Adjective & " " & Noun & "s " & Verb & " to the building."
        End Select
    End Sub
End Class
