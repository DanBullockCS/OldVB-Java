
Public Class Form1
    Private Sub btnCoins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCoins.Click
        'Step 1: "Define variables"'
        Dim intCents As Integer
        'Step 2: move variables into text box'
        intCents = Val(Me.txtboxChange.Text)
        'Step 3: do calculations
        Debug.WriteLine(intCents Mod 200)
        Debug.WriteLine(intCents Mod 100)
        Debug.WriteLine(intCents Mod 25)
        Debug.WriteLine(intCents Mod 10)
        Debug.WriteLine(intCents Mod 5)
        Debug.WriteLine(intCents Mod 1)
        'Step 4: Move variable into label
        Me.lblTooniesAnswer.Text = 200
        Me.lblLooniesAnswer.Text = 100
        Me.lblQuartersAnswer.Text = 25
        Me.lblDimesAnswer.Text = 10
        Me.lblNickelsAnswer.Text = 5
        Me.lblPenniesAnswer.Text = 1
    End Sub

End Class

