Public Class Form1

    Private Sub radbtn5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radbtn5.Click
        Me.lbl1.Text = "Chris Martin - Vocals / Piano / Guitar"
        Me.lbl2.Text = "Jonny Buckland - Guitar"
        Me.lbl3.Text = "Guy Berryman - Bassist"
        Me.lbl4.Text = "Will Champion - Drums"
        Me.lbl5.Text = ""
        Me.PictureBox1.Image = My.Resources.Coldplay_coldplay_132647_1024_768
    End Sub

    Private Sub radbtn4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radbtn4.Click
        Me.lbl1.Text = "Brad Arnold - Vocal / Drums"
        Me.lbl2.Text = "Todd Harrell - Bassist"
        Me.lbl3.Text = "Matt Roberts - Guitar"
        Me.lbl4.Text = "Chris Henderson - Guitar"
        Me.lbl5.Text = ""
        Me.PictureBox1.Image = My.Resources._3_Doors_Down
    End Sub

    Private Sub radbtn3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radbtn3.Click
        Me.lbl1.Text = "Ryan Tedder - Lead Vocals / Rhythm Guitar"
        Me.lbl2.Text = "Zach Filkins - Lead Guitar / Acoustic Guitar"
        Me.lbl3.Text = "Eddie Fisher - Rhythm Guitar / Keyboard"
        Me.lbl4.Text = "Brent Kutzle - Drums / Percussion"
        Me.lbl5.Text = "Drew Brown - Bass Guitar / Cello"
        Me.PictureBox1.Image = My.Resources.OneRepublic
    End Sub

    Private Sub radbtn2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radbtn2.Click
        Me.lbl1.Text = "Dave Grohl - Lead Vocals"
        Me.lbl2.Text = "Nate Mendel - Bass Guitar"
        Me.lbl3.Text = "Pat Smear - Rhythm Guitar"
        Me.lbl4.Text = "Taylor Hawkins - Drums"
        Me.lbl5.Text = "Chris Shiflett - Lead Guitar"
        Me.PictureBox1.Image = My.Resources.Foo_Fighters
    End Sub

    Private Sub radbtn1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radbtn1.Click
        Me.lbl1.Text = "Adam Levine - Lead Vocals"
        Me.lbl2.Text = "Jesse Carmichael - Keyboard"
        Me.lbl3.Text = "Mickey Madden - Bass Guitar"
        Me.lbl4.Text = "James Valentine - Lead and Rhythm Guitar"
        Me.lbl5.Text = "Matt Flynn - Drums / Percussion"
        Me.PictureBox1.Image = My.Resources.maroon_5_hd
    End Sub
End Class