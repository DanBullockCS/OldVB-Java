Public Class Form3
    'Daniel Bullock | Drag and Drop level Form | Form 3 | Version #5

    Dim StartPoint As Point

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Visible = False
        Form2.tmrMonitor.Enabled = False
        Form2.tmrMonitor2.Enabled = False
        lblLife.Text = Form2.LifeCounter2
        MoveFolder.Enabled = True
    End Sub

    Private Sub picFolder1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picFolder1.MouseDown
        picRecycleBin.BackgroundImage = My.Resources.Recycle_Bin_Empty
        DragTimer.Enabled = True
        MoveFolder.Enabled = False
        StartPoint = picFolder1.Location
    End Sub

    Private Sub DragTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DragTimer.Tick
        Dim M As Point = Me.PointToClient(MousePosition)
        picFolder1.Location = M
        If picFolder1.Left > (picRecycleBin.Left - 150) And picFolder1.Top > (picFolder1.Top - 150) Then
            picRecycleBin.BackgroundImage = My.Resources.Recycle_Bin_Open   'open head if mouse is near
        End If

    End Sub

    Private Sub picFolder1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picFolder1.MouseUp
        DragTimer.Enabled = False
        MoveFolder.Enabled = True
        Dim M As Point = Me.PointToClient(MousePosition) 'Mouse position at drop 
        If (M.X > picRecycleBin.Left And M.X < picRecycleBin.Left + picRecycleBin.Width) And
           (M.Y > picRecycleBin.Top And M.Y < picRecycleBin.Top + picRecycleBin.Height) Then

            Dim Life As Integer = Int(Rnd() * 2)
            If Life = 1 Then
                picRecycleBin.BackgroundImage = My.Resources.Recycle_Bin_Happy      'change pic to happy face
                Form2.LifeCounter2 = Form2.LifeCounter2 + 2   'bump up score
            Else
                picRecycleBin.BackgroundImage = My.Resources.Recycle_Bin_Sad     'change pic to happy face
                Form2.LifeCounter2 = Form2.LifeCounter2 - 2
            End If
            lblLife.Text = Form2.LifeCounter2
        Else
            picRecycleBin.BackgroundImage = My.Resources.Recycle_Bin_Open
        End If
        If Form2.LifeCounter2 = 0 Then Application.Exit()
        picFolder1.Location = StartPoint
    End Sub

    Private Sub MoveFolder_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveFolder.Tick
        picFolder1.Left = picFolder1.Left + 1
        picFolder1.Top = 130 * Math.Sin(picFolder1.Left / 18) + 250
        If picFolder1.Left > 250 Then
            picFolder1.Left = 30
            picFolder1.Top = 200
        End If
    End Sub

    Private Sub tmrColor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrColor.Tick
        If Me.lblMsg.ForeColor = Color.Lime Then
            Me.lblMsg.ForeColor = Color.Aqua
        ElseIf Me.lblMsg.ForeColor = Color.Aqua Then
            Me.lblMsg.ForeColor = Color.Yellow
        ElseIf Me.lblMsg.ForeColor = Color.Yellow Then
            Me.lblMsg.ForeColor = Color.Lime
        End If
    End Sub

    Private Sub lblNextLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNextLevel.Click
        Application.Exit()
    End Sub
End Class