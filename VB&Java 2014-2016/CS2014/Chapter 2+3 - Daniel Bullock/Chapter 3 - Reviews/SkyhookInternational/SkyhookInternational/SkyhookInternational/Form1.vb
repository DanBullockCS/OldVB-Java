Public Class Form1

    Private Sub btnShip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShip.Click
        'Step 1 "Define variables"'  
        Const FIT As Integer = 3
        Dim intHooks As Integer
        Dim intBoxes As Integer
        Dim intEnvelopes As Integer
        'Step 2 move variables into text box'
        intHooks = Me.txtboxShips.Text

        'Step 3 do calculations
        intBoxes = intHooks \ FIT

        intEnvelopes = intHooks Mod FIT
        'Step 4 Move variable into label
        Me.lblBoxes.Text = intBoxes & " Boxes"
        Me.lblEnvelopes.Text = intEnvelopes & " Envelopes"
    End Sub

    Private Sub txtboxShips_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxShips.TextChanged
        Me.lblBoxes.Text = ""
        Me.lblEnvelopes.Text = ""
    End Sub
End Class
