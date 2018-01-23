Public Class Form1
    'Daniel Bullock
   
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Static previousPoint As Point
        Dim formSurface As Graphics = Me.CreateGraphics
        Dim orangeRedPen As New Pen(Color.OrangeRed, 3)
        Dim mouseClick As Point

        mouseClick.X = e.X
        mouseClick.Y = e.Y

        formSurface.DrawLine(orangeRedPen, previousPoint, mouseClick)

        previousPoint = mouseClick
    End Sub
End Class
