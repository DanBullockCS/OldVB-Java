Public Class Form1
    'Daniel Bullock

    Private Sub btnDrawShapes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawShapes.Click
        Dim formSurface As Graphics = Me.CreateGraphics
        formSurface.Clear(Me.BackColor)

        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height

        Dim lightSeaGreenPen As New Pen(Color.LightSeaGreen, 2)
        Dim thickerDeepPinkPen As New Pen(Color.DeepPink, 10)
        Dim thickDodgerBluePen As New Pen(Color.DodgerBlue, 5)
        Dim thinRedPen As New Pen(Color.Red, 3)

        formSurface.DrawLine(lightSeaGreenPen, 30, maxY \ 3, maxX - 30, maxY \ 3)

        formSurface.DrawEllipse(thickerDeepPinkPen, maxX \ 2, maxY \ 2, 40, 40)

        thickDodgerBluePen.DashStyle = Drawing.Drawing2D.DashStyle.DashDotDot
        formSurface.DrawRectangle(thickDodgerBluePen, 80, maxY \ 4, maxX \ 3, 70)

        formSurface.DrawArc(thinRedPen, 30, 0, maxX - 60, maxY - 60, 0, 180)
    End Sub
End Class
