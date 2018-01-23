Public Class Form1
    'Daniel Bullock

    Private Sub btnDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraw.Click
        Dim formSurface As Graphics = Me.CreateGraphics

        'Create brushes and pens
        Dim lightSkyBlueBrush As New SolidBrush(Color.LightSkyBlue)
        Dim CoralBrush As New SolidBrush(Color.Coral)
        Dim bluePen As New Pen(Color.Blue, 2)
        Dim whiteBrush As New SolidBrush(Color.White)
        Dim blackPen As New Pen(Color.Black, 2)

        'Define points
        Dim curvePointsBoat() As Point = {New Point(90, 180), New Point(100, 220), New Point(185, 210), New Point(230, 170)}
        Dim curvePointsWaves1() As Point = {New Point(0, 210), New Point(20, 225), New Point(40, 230), New Point(60, 210)}
        Dim curvePointsWaves2() As Point = {New Point(60, 210), New Point(80, 225), New Point(100, 230), New Point(120, 210)}
        Dim curvePointsWaves3() As Point = {New Point(120, 210), New Point(140, 225), New Point(160, 230), New Point(180, 210)}
        Dim curvePointsWaves4() As Point = {New Point(180, 210), New Point(200, 225), New Point(220, 230), New Point(240, 210)}
        Dim curvePointsWaves5() As Point = {New Point(240, 210), New Point(260, 225), New Point(280, 230), New Point(300, 210)}
        Dim curvePointsSail1() As Point = {New Point(154, 105), New Point(164, 125), New Point(154, 185), New Point(184, 115)}
        Dim curvePointsSail2() As Point = {New Point(146, 85), New Point(115, 155), New Point(146, 180), New Point(143, 145)}

        formSurface.FillRectangle(lightSkyBlueBrush, 0, 0, 500, 500)                  'sky background
        formSurface.DrawCurve(bluePen, curvePointsWaves1)                             'first wave
        formSurface.DrawCurve(bluePen, curvePointsWaves2)                             'second wave
        formSurface.DrawCurve(bluePen, curvePointsWaves3)                             'third wave
        formSurface.DrawCurve(bluePen, curvePointsWaves4)                             'fourth wave
        formSurface.DrawCurve(bluePen, curvePointsWaves5)                             'fifth wave
        formSurface.FillPolygon(CoralBrush, curvePointsBoat)                          'boat base
        formSurface.FillClosedCurve(whiteBrush, curvePointsSail1)                     'first part of sail
        formSurface.FillClosedCurve(whiteBrush, curvePointsSail2)                     'second part of sail
        formSurface.DrawLine(blackPen, 150, 190, 150, 100)                            'Black line
    End Sub
End Class
