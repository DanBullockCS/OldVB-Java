
Public Class Form1
    Private Sub btnCoins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCoins.Click
        'Step 1: "Define variables"'
        Const Toonies As Integer = 200
        Const Loonies As Integer = 100
        Const Quarters As Integer = 25
        Const Dimes As Integer = 10
        Const Nickels As Integer = 5
        Const Pennies As Integer = 1
        Dim intCents As Integer
        'Step 2: move variables into text box'
        intCents = Val(Me.txtboxChange.Text)
        'Step 3: do calculations
        intCents()
        'Step 4: Move variable into label


    End Sub

End Class

