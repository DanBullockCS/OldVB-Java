Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        'Step 1: "Define variables"'
        Dim length As Double
        Dim width As Double
        Dim area As Double
        Dim perimeter As Double
        'Step 2: move variables into text box'
        length = Val(Me.txtboxLength.Text)
        width = Val(Me.txtboxWidth.Text)
        'Step 3: do calculations
        area = length * width
        perimeter = length + length + width + width
        'Step 4: Move variable into label
        Me.lblArea.Text = area
        Me.lblPerimeter.Text = perimeter
    End Sub

    Private Sub txtboxLength_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxLength.TextChanged
        Me.lblPerimeter.Text = ""
        Me.lblArea.Text = ""
    End Sub

    Private Sub txtboxWidth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxWidth.TextChanged
        Me.lblPerimeter.Text = ""
        Me.lblArea.Text = ""
    End Sub
End Class
