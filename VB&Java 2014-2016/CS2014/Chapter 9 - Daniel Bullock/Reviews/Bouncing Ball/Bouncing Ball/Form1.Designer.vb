<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.tmrAnimateBall = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBall
        '
        Me.picBall.Location = New System.Drawing.Point(12, 4)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(134, 47)
        Me.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBall.TabIndex = 0
        Me.picBall.TabStop = False
        '
        'tmrAnimateBall
        '
        Me.tmrAnimateBall.Enabled = True
        Me.tmrAnimateBall.Interval = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(206, 60)
        Me.Controls.Add(Me.picBall)
        Me.Name = "Form1"
        Me.Text = "Bouncing Ball"
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBall As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAnimateBall As System.Windows.Forms.Timer

End Class
