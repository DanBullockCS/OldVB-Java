Imports System.Media
Public Class Form1

    'Daniel Bullock

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        tmrRandomLine.Enabled = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Dim formSurface As Graphics = Me.CreateGraphics

        tmrRandomLine.Enabled = False
        formSurface.Clear(Color.White)
    End Sub

    Private Sub tmrRandomLine_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRandomLine.Tick
        Randomize()
        Dim formSurface As Graphics = Me.CreateGraphics
        Dim bluePen As New Pen(Color.Blue, 3)
        Dim greenPen As New Pen(Color.Green, 3)
        Dim redPen As New Pen(Color.Red, 3)
        Dim RndPoint1 As Integer = Int(300 * Rnd() + 1)
        Dim RndPoint2 As Integer = Int(300 * Rnd() + 1)
        Dim RndPoint3 As Integer = Int(300 * Rnd() + 1)
        Dim RndPoint4 As Integer = Int(300 * Rnd() + 1)
        Dim RndPen As Pen
        Dim LineColor As Integer = Int(3 * Rnd() + 1)

        If LineColor = 1 Then
            RndPen = Pens.Blue
        ElseIf LineColor = 2 Then
            RndPen = Pens.Green
        ElseIf LineColor = 3 Then
            RndPen = Pens.Red
        End If

        formSurface.Clear(Color.White)
        formSurface.DrawLine(RndPen, RndPoint1, RndPoint2, RndPoint3, RndPoint4)

        SystemSounds.Beep.Play()
    End Sub
End Class
