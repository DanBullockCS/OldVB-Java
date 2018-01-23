'TriangleCalculator
'Chapter 10 Case Study
'Lawrenceville Press
'February 16, 2011

Public Class TriangleCalculator

    Private Sub Calculate(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles btnArea.Click, btnPerimeter.Click, btnType.Click, btnHeight.Click
        Dim sideA As Double = Val(Me.txtSideA.Text)
        Dim sideB As Double = Val(Me.txtSideB.Text)
        Dim sideC As Double = Val(Me.txtSideC.Text)
        Dim userTriangle As New Triangle(sideA, sideB, sideC)
        Dim btnButtonClicked As Button = sender

        Select Case btnButtonClicked.Tag
            Case "Area"
                If userTriangle.GetArea = -1 Then
                    Me.lblArea.Text = "Invalid Measurements"
                Else
                    Me.lblArea.Text = userTriangle.GetArea
                End If
            Case "Perimeter"
                Me.lblPerimeter.Text = userTriangle.s * 2
            Case "Type"
                Me.lblType.Text = userTriangle.GetName
            Case "Height"
                If userTriangle.GetHeight = -1 Then
                    Me.lblHeight.Text = "Invalid Measurements"
                Else
                    Me.lblHeight.Text = userTriangle.GetHeight
                End If
        End Select
    End Sub

    Private Sub SideChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSideA.TextChanged,
    txtSideB.TextChanged, txtSideC.TextChanged
        Me.lblArea.Text = Nothing
        Me.lblPerimeter.Text = Nothing
        Me.lblType.Text = Nothing
        Me.lblHeight.Text = Nothing
    End Sub
End Class
