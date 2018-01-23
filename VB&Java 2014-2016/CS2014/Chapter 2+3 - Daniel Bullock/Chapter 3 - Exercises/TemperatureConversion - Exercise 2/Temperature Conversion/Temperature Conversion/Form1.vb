Public Class Form1

    Private Sub btnCelsius_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCelsius.Click
        'Step 1: "Define variables"'
        Dim intCelsius As Integer
        Dim dblFahrenheit As Double
        Dim x As Double
        Dim y As Double
        'Step 2: move variables into text box'
        dblFahrenheit = Val(Me.txtboxFahrenheit.Text)
        'Step 3: do calculations
        x = 5 / 9
        y = dblFahrenheit - 32
        intCelsius = y * x
        'Step 4: Move variable into label
        Me.lblTemp.Text = intCelsius
    End Sub

    Private Sub txtboxFahrenheit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxFahrenheit.TextChanged
        Me.lblTemp.Text = ""
    End Sub

    Private Sub btnFahrenheit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFahrenheit.Click
        'Step 1: "Define variables"'
        Dim intFahrenheit As Integer
        Dim dblCelsius As Double
        Dim x As Double
        Dim y As Double
        'Step 2: move variables into text box'
        dblCelsius = Val(Me.txtboxFahrenheit.Text)
        'Step 3: do calculations
        x = 9 / 5
        y = dblCelsius + 32
        intFahrenheit = y * x
        'Step 4: Move variable into label
        Me.lblTemp.Text = intFahrenheit
    End Sub
End Class
