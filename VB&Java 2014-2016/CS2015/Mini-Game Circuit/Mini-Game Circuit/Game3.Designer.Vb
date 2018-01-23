<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game3
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
        Me.picBlueBalloon = New System.Windows.Forms.PictureBox()
        Me.picGreenBalloon = New System.Windows.Forms.PictureBox()
        Me.picRedBalloon = New System.Windows.Forms.PictureBox()
        Me.picYellowBalloon = New System.Windows.Forms.PictureBox()
        Me.lblBackToMenu = New System.Windows.Forms.Label()
        Me.lblScorePrompt = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTimePrompt = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblStartPause = New System.Windows.Forms.Label()
        Me.tmrBlueBalloon = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGreenBalloon = New System.Windows.Forms.Timer(Me.components)
        Me.tmrYellowBalloon = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRedBalloon = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblRestart = New System.Windows.Forms.Label()
        CType(Me.picBlueBalloon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreenBalloon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRedBalloon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYellowBalloon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBlueBalloon
        '
        Me.picBlueBalloon.BackColor = System.Drawing.Color.Transparent
        Me.picBlueBalloon.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Blue_balloon
        Me.picBlueBalloon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picBlueBalloon.Enabled = False
        Me.picBlueBalloon.Location = New System.Drawing.Point(12, 12)
        Me.picBlueBalloon.Name = "picBlueBalloon"
        Me.picBlueBalloon.Size = New System.Drawing.Size(80, 76)
        Me.picBlueBalloon.TabIndex = 0
        Me.picBlueBalloon.TabStop = False
        Me.picBlueBalloon.Visible = False
        '
        'picGreenBalloon
        '
        Me.picGreenBalloon.BackColor = System.Drawing.Color.Transparent
        Me.picGreenBalloon.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Green_balloon
        Me.picGreenBalloon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picGreenBalloon.Enabled = False
        Me.picGreenBalloon.Location = New System.Drawing.Point(554, 12)
        Me.picGreenBalloon.Name = "picGreenBalloon"
        Me.picGreenBalloon.Size = New System.Drawing.Size(80, 76)
        Me.picGreenBalloon.TabIndex = 1
        Me.picGreenBalloon.TabStop = False
        Me.picGreenBalloon.Visible = False
        '
        'picRedBalloon
        '
        Me.picRedBalloon.BackColor = System.Drawing.Color.Transparent
        Me.picRedBalloon.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Red_balloon
        Me.picRedBalloon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picRedBalloon.Enabled = False
        Me.picRedBalloon.Location = New System.Drawing.Point(554, 412)
        Me.picRedBalloon.Name = "picRedBalloon"
        Me.picRedBalloon.Size = New System.Drawing.Size(80, 76)
        Me.picRedBalloon.TabIndex = 2
        Me.picRedBalloon.TabStop = False
        Me.picRedBalloon.Visible = False
        '
        'picYellowBalloon
        '
        Me.picYellowBalloon.BackColor = System.Drawing.Color.Transparent
        Me.picYellowBalloon.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Yellow_balloon
        Me.picYellowBalloon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picYellowBalloon.Enabled = False
        Me.picYellowBalloon.Location = New System.Drawing.Point(12, 412)
        Me.picYellowBalloon.Name = "picYellowBalloon"
        Me.picYellowBalloon.Size = New System.Drawing.Size(80, 76)
        Me.picYellowBalloon.TabIndex = 3
        Me.picYellowBalloon.TabStop = False
        Me.picYellowBalloon.Visible = False
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.BackColor = System.Drawing.Color.White
        Me.lblBackToMenu.Font = New System.Drawing.Font("Kristen ITC", 11.0!)
        Me.lblBackToMenu.Location = New System.Drawing.Point(663, 106)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(111, 22)
        Me.lblBackToMenu.TabIndex = 5
        Me.lblBackToMenu.Text = "Back to menu"
        '
        'lblScorePrompt
        '
        Me.lblScorePrompt.AutoSize = True
        Me.lblScorePrompt.BackColor = System.Drawing.Color.White
        Me.lblScorePrompt.Font = New System.Drawing.Font("Kristen ITC", 11.0!)
        Me.lblScorePrompt.Location = New System.Drawing.Point(653, 213)
        Me.lblScorePrompt.Name = "lblScorePrompt"
        Me.lblScorePrompt.Size = New System.Drawing.Size(57, 22)
        Me.lblScorePrompt.TabIndex = 6
        Me.lblScorePrompt.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.Font = New System.Drawing.Font("Kristen ITC", 11.0!)
        Me.lblScore.Location = New System.Drawing.Point(716, 213)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 22)
        Me.lblScore.TabIndex = 7
        '
        'lblTimePrompt
        '
        Me.lblTimePrompt.AutoSize = True
        Me.lblTimePrompt.BackColor = System.Drawing.Color.White
        Me.lblTimePrompt.Font = New System.Drawing.Font("Kristen ITC", 11.0!)
        Me.lblTimePrompt.Location = New System.Drawing.Point(648, 252)
        Me.lblTimePrompt.Name = "lblTimePrompt"
        Me.lblTimePrompt.Size = New System.Drawing.Size(50, 22)
        Me.lblTimePrompt.TabIndex = 8
        Me.lblTimePrompt.Text = "Time:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Cloud
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(640, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 502)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.White
        Me.lblTime.Font = New System.Drawing.Font("Kristen ITC", 11.0!)
        Me.lblTime.Location = New System.Drawing.Point(710, 252)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 22)
        Me.lblTime.TabIndex = 9
        '
        'lblStartPause
        '
        Me.lblStartPause.AutoSize = True
        Me.lblStartPause.BackColor = System.Drawing.Color.White
        Me.lblStartPause.Font = New System.Drawing.Font("Kristen ITC", 11.0!)
        Me.lblStartPause.Location = New System.Drawing.Point(699, 328)
        Me.lblStartPause.Name = "lblStartPause"
        Me.lblStartPause.Size = New System.Drawing.Size(48, 22)
        Me.lblStartPause.TabIndex = 10
        Me.lblStartPause.Text = "Start"
        '
        'tmrBlueBalloon
        '
        Me.tmrBlueBalloon.Interval = 1000
        '
        'tmrGreenBalloon
        '
        Me.tmrGreenBalloon.Interval = 750
        '
        'tmrYellowBalloon
        '
        Me.tmrYellowBalloon.Interval = 600
        '
        'tmrRedBalloon
        '
        Me.tmrRedBalloon.Interval = 1250
        '
        'tmrGameTime
        '
        Me.tmrGameTime.Interval = 1000
        '
        'lblRestart
        '
        Me.lblRestart.AutoSize = True
        Me.lblRestart.BackColor = System.Drawing.Color.Transparent
        Me.lblRestart.Enabled = False
        Me.lblRestart.Font = New System.Drawing.Font("Kristen ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestart.ForeColor = System.Drawing.Color.Yellow
        Me.lblRestart.Location = New System.Drawing.Point(254, 224)
        Me.lblRestart.Name = "lblRestart"
        Me.lblRestart.Size = New System.Drawing.Size(274, 88)
        Me.lblRestart.TabIndex = 11
        Me.lblRestart.Text = "Restart"
        Me.lblRestart.Visible = False
        '
        'Game3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Sky_background
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblRestart)
        Me.Controls.Add(Me.lblStartPause)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTimePrompt)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScorePrompt)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.Controls.Add(Me.picYellowBalloon)
        Me.Controls.Add(Me.picRedBalloon)
        Me.Controls.Add(Me.picGreenBalloon)
        Me.Controls.Add(Me.picBlueBalloon)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game3"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game3"
        CType(Me.picBlueBalloon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreenBalloon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRedBalloon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYellowBalloon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBlueBalloon As System.Windows.Forms.PictureBox
    Friend WithEvents picGreenBalloon As System.Windows.Forms.PictureBox
    Friend WithEvents picRedBalloon As System.Windows.Forms.PictureBox
    Friend WithEvents picYellowBalloon As System.Windows.Forms.PictureBox
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents lblScorePrompt As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblTimePrompt As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblStartPause As System.Windows.Forms.Label
    Friend WithEvents tmrBlueBalloon As System.Windows.Forms.Timer
    Friend WithEvents tmrGreenBalloon As System.Windows.Forms.Timer
    Friend WithEvents tmrYellowBalloon As System.Windows.Forms.Timer
    Friend WithEvents tmrRedBalloon As System.Windows.Forms.Timer
    Friend WithEvents tmrGameTime As System.Windows.Forms.Timer
    Friend WithEvents lblRestart As System.Windows.Forms.Label
End Class
