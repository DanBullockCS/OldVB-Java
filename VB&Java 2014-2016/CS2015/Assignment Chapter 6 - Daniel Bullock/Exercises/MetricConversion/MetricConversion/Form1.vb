Public Class Form1
    'Daniel Bullock

    Dim NumberEntered As Double                                         'Global variable

    Private Sub btnItoC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItoC.Click
        NumberEntered = Me.txtEnteredNumber.Text
        lblAnswer.Text = NumberEntered & " inches equals " & ItoC(NumberEntered) & " centimeters."
    End Sub

    Private Sub btnCtoI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtoI.Click
        NumberEntered = Me.txtEnteredNumber.Text
        lblAnswer.Text = NumberEntered & " centimeters equals " & CtoI(NumberEntered) & " inches."
    End Sub

    Private Sub btnFtoC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFtoC.Click
        NumberEntered = Me.txtEnteredNumber.Text
        lblAnswer.Text = NumberEntered & " feet equals " & FtoC(NumberEntered) & " centimeters."
    End Sub

    Private Sub btnCtoF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtoF.Click
        NumberEntered = Me.txtEnteredNumber.Text
        lblAnswer.Text = NumberEntered & " centimeters equals " & CtoF(NumberEntered) & " feet."
    End Sub

    Private Sub btnYtoM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYtoM.Click
        NumberEntered = Me.txtEnteredNumber.Text
        lblAnswer.Text = NumberEntered & " yards equals " & YtoM(NumberEntered) & " meters."
    End Sub

    Private Sub btnMtoY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMtoY.Click
        NumberEntered = Me.txtEnteredNumber.Text
        lblAnswer.Text = NumberEntered & " meters equals " & MtoY(NumberEntered) & " yards."
    End Sub

    Private Sub btnMtoK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMtoK.Click
        NumberEntered = Me.txtEnteredNumber.Text
        lblAnswer.Text = NumberEntered & " meters equals " & MtoK(NumberEntered) & " kilometers."
    End Sub

    Private Sub btnKtoM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKtoM.Click
        NumberEntered = Me.txtEnteredNumber.Text
        lblAnswer.Text = NumberEntered & " kilometers equals " & KtoM(NumberEntered) & " meters."
    End Sub
    'Functions:
    Function ItoC(ByVal NumberEntered As Double)
        NumberEntered = Me.txtEnteredNumber.Text
        NumberEntered = NumberEntered * 2.54 'Functions are the formulas.
        Return NumberEntered
    End Function

    Function CtoI(ByVal NumberEntered As Double)
        NumberEntered = Me.txtEnteredNumber.Text
        NumberEntered = NumberEntered / 2.54
        Return NumberEntered
    End Function

    Function FtoC(ByVal NumberEntered As Double)
        NumberEntered = Me.txtEnteredNumber.Text
        NumberEntered = NumberEntered * 30
        Return NumberEntered
    End Function

    Function CtoF(ByVal NumberEntered As Double)
        NumberEntered = Me.txtEnteredNumber.Text
        NumberEntered = NumberEntered / 30
        Return NumberEntered
    End Function

    Function YtoM(ByVal NumberEntered As Double)
        NumberEntered = Me.txtEnteredNumber.Text
        NumberEntered = NumberEntered * 0.91
        Return NumberEntered
    End Function

    Function MtoY(ByVal NumberEntered As Double)
        NumberEntered = Me.txtEnteredNumber.Text
        NumberEntered = NumberEntered / 0.91
        Return NumberEntered
    End Function

    Function MtoK(ByVal NumberEntered As Double)
        NumberEntered = Me.txtEnteredNumber.Text
        NumberEntered = NumberEntered * 1.6
        Return NumberEntered
    End Function

    Function KtoM(ByVal NumberEntered As Double)
        NumberEntered = Me.txtEnteredNumber.Text
        NumberEntered = NumberEntered / 1.6
        Return NumberEntered
    End Function
    'Text Changed:
    Private Sub txtEnteredNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEnteredNumber.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub
End Class
