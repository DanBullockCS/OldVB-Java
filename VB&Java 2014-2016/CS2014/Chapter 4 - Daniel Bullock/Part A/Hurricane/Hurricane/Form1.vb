Public Class Form1

    Private Sub btnCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategory.Click
        'Step 1: "Define variables"
        Dim intspeed As Integer
        'Step 2: move variables into text box
        intspeed = Val(Me.txtboxMPH.Text)
        'Step 3: do calculations
        Select Case intspeed
            Case Is <= 73
                Me.lblCategory.Text = "Invalid Category"
            Case Is <= 95
                Me.lblCategory.Text = "Category 1: 74-95 mph or 62-82 kt or 119-153 km/hr"
            Case Is <= 110
                Me.lblCategory.Text = "Category 2 96-110 mph or 83-95 kt or 154-177 km/hr"
            Case Is <= 130
                Me.lblCategory.Text = "Category 3 111-130 mph or 96-113 kt or 178-209 km/hr"
            Case Is <= 155
                Me.lblCategory.Text = "Category 4 131-155 mph or 114-135 kt or 210-249 km/hr"
            Case Is > 155
                Me.lblCategory.Text = "Category 5 greater than 155 mph or 135 kt or 249 km/hr"
        End Select
        'Step 4: Move variable into label
    End Sub

    Private Sub txtboxMPH_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtboxMPH.TextChanged
        Me.lblCategory.Text = ""
    End Sub
End Class
