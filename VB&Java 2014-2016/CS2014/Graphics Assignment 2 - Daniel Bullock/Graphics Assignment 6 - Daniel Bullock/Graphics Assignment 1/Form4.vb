Public Class Form4
    'Daniel Bullock | Shooting form | Form 4 | Version #6


    Private Sub tmrSpaceTime_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrSpaceTime.Tick

        Dim MForm As Point = Me.PointToClient(MousePosition)

        If MForm.X > Me.Width Then
            picSpace.Left = picSpace.Left - 5
        End If

        If MForm.X < 0 Then
            picSpace.Left = picSpace.Left + 5
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form3.Visible = False
    End Sub
End Class