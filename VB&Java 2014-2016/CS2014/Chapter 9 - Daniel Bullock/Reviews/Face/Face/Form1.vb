Public Class Form1
    'Daniel Bullock

    Private Sub btnHappy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHappy.Click
        Dim formSurface As Graphics = Me.CreateGraphics

        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim pinkBrush As New SolidBrush(Color.Pink)
        Dim khakiBrush As New SolidBrush(Color.Khaki)
        Dim lightGrayBrush As New SolidBrush(Color.LightGray)


        formSurface.FillRectangle(khakiBrush, 60, 50, 200, 200) 'Back rectangle
        formSurface.FillPie(lightGrayBrush, 60, 50, 200, 200, 50, 360) 'large circle
        formSurface.FillPie(blueBrush, 100, 90, 40, 40, 50, 360) 'left eye
        formSurface.FillPie(blueBrush, 180, 90, 40, 40, 50, 360) 'right eye
        formSurface.FillPie(redBrush, 145, 140, 25, 25, 50, 360) 'nose
        formSurface.FillPie(pinkBrush, 120, 140, 75, 75, 360, 180) 'mouth

    End Sub

    Private Sub btnSad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSad.Click
        Dim formSurface As Graphics = Me.CreateGraphics

        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim pinkBrush As New SolidBrush(Color.Pink)
        Dim khakiBrush As New SolidBrush(Color.Khaki)
        Dim lightGrayBrush As New SolidBrush(Color.LightGray)


        formSurface.FillRectangle(khakiBrush, 60, 50, 200, 200) 'rectangle background
        formSurface.FillPie(lightGrayBrush, 60, 50, 200, 200, 50, 360) 'large circle
        formSurface.FillPie(blueBrush, 100, 90, 40, 40, 50, 360) 'left eye
        formSurface.FillPie(blueBrush, 180, 90, 40, 40, 50, 360) 'right eye
        formSurface.FillPie(redBrush, 145, 140, 25, 25, 50, 360) 'nose
        formSurface.FillPie(pinkBrush, 120, 180, 75, 75, 180, 180) 'mouth
    End Sub
End Class
