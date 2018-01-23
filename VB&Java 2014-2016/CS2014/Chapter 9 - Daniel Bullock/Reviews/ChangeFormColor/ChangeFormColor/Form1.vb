Public Class Form1
    'Daniel Bullock

    Private Sub btnHoneydew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoneydew.Click
        Me.BackColor = Color.Honeydew
    End Sub

    Private Sub btnThistle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThistle.Click
        Me.BackColor = Color.Thistle
    End Sub

    Private Sub btnSkyBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkyBlue.Click
        Me.BackColor = Color.SkyBlue
    End Sub

    Private Sub btnTurquoise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurquoise.Click
        Me.BackColor = Color.Turquoise
    End Sub

    Private Sub btnDarkKhaki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDarkKhaki.Click
        Me.BackColor = Color.DarkKhaki
    End Sub

    Private Sub btnSalmon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalmon.Click
        Me.BackColor = Color.Salmon
    End Sub

    Private Sub btnChooseColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseColor.Click
        Me.ColorDialog1.ShowDialog()
        Me.BackColor = Me.ColorDialog1.Color
    End Sub
End Class
