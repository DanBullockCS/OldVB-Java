Public Class Form1
    Dim Color1 As String
    Dim Color2 As String
    Dim Color3 As String
    Dim ColorOrder As Integer
    Dim RndColorPick1 As Integer = Int(4 * Rnd() + 1)
    Dim RndColorPick2 As Integer = Int(4 * Rnd() + 1)
    Dim RndColorPick3 As Integer = Int(4 * Rnd() + 1)
    Dim RndColorPick4 As Integer = Int(4 * Rnd() + 1)

    Private Sub btnCheckGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click
        Randomize()

        If Color1 = 1 Then
            Color1 = R
        ElseIf Color1 = 2 Then
            Color1 = G
        ElseIf Color1 = 3 Then
            Color1 = B
        ElseIf Color1 = 4 Then
            Color1 = Y
        End If

        If Color2 = 1 Then
            Color2 = R
        ElseIf Color2 = 2 Then
            Color2 = G
        ElseIf Color2 = 3 Then
            Color2 = B
        ElseIf Color2 = 4 Then
            Color2 = Y
        End If

        If Color3 = 1 Then
            Color3 = R
        ElseIf Color3 = 2 Then
            Color3 = G
        ElseIf Color3 = 3 Then
            Color3 = B
        ElseIf Color3 = 4 Then
            Color3 = Y
        End If

        If Me.txtColor1.Text = Color1 Then
            Me.lblColor.Text += 1
        End If
        If Me.txtColor2.Text = Color2 Then
            Me.lblColor.Text += 1
        End If
        If Me.txtColor3.Text = Color3 Then
            Me.lblColor.Text += 1
        End If


    End Sub
End Class
