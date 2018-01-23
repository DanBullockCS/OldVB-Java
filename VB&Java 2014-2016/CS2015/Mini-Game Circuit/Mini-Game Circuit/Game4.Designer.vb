<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game4
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
        Me.lblBackToMenu = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.tmrStartGame = New System.Windows.Forms.Timer(Me.components)
        Me.picShape1 = New System.Windows.Forms.PictureBox()
        Me.picShape2 = New System.Windows.Forms.PictureBox()
        Me.picShape6 = New System.Windows.Forms.PictureBox()
        Me.picShape7 = New System.Windows.Forms.PictureBox()
        Me.picShape3 = New System.Windows.Forms.PictureBox()
        Me.tmrEndGame = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShapes = New System.Windows.Forms.Timer(Me.components)
        Me.picShape5 = New System.Windows.Forms.PictureBox()
        Me.picShape4 = New System.Windows.Forms.PictureBox()
        Me.picShape8 = New System.Windows.Forms.PictureBox()
        Me.lblCurtainDown = New System.Windows.Forms.Label()
        Me.lblAnswersRightPrompt = New System.Windows.Forms.Label()
        Me.lblAnswersWrongPrompt = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.picCover = New System.Windows.Forms.PictureBox()
        Me.lblHelp = New System.Windows.Forms.Label()
        CType(Me.picShape1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.BackColor = System.Drawing.Color.White
        Me.lblBackToMenu.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackToMenu.Location = New System.Drawing.Point(12, 455)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(123, 23)
        Me.lblBackToMenu.TabIndex = 0
        Me.lblBackToMenu.Text = "Back to Menu"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.White
        Me.lblStart.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(736, 455)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(52, 23)
        Me.lblStart.TabIndex = 5
        Me.lblStart.Text = "Start"
        '
        'tmrStartGame
        '
        Me.tmrStartGame.Interval = 1
        '
        'picShape1
        '
        Me.picShape1.BackColor = System.Drawing.Color.Transparent
        Me.picShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShape1.Location = New System.Drawing.Point(124, 92)
        Me.picShape1.Name = "picShape1"
        Me.picShape1.Size = New System.Drawing.Size(141, 124)
        Me.picShape1.TabIndex = 6
        Me.picShape1.TabStop = False
        '
        'picShape2
        '
        Me.picShape2.BackColor = System.Drawing.Color.Transparent
        Me.picShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShape2.Location = New System.Drawing.Point(250, 92)
        Me.picShape2.Name = "picShape2"
        Me.picShape2.Size = New System.Drawing.Size(141, 124)
        Me.picShape2.TabIndex = 10
        Me.picShape2.TabStop = False
        '
        'picShape6
        '
        Me.picShape6.BackColor = System.Drawing.Color.Transparent
        Me.picShape6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShape6.Location = New System.Drawing.Point(250, 210)
        Me.picShape6.Name = "picShape6"
        Me.picShape6.Size = New System.Drawing.Size(141, 124)
        Me.picShape6.TabIndex = 12
        Me.picShape6.TabStop = False
        '
        'picShape7
        '
        Me.picShape7.BackColor = System.Drawing.Color.Transparent
        Me.picShape7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShape7.Location = New System.Drawing.Point(386, 210)
        Me.picShape7.Name = "picShape7"
        Me.picShape7.Size = New System.Drawing.Size(141, 124)
        Me.picShape7.TabIndex = 13
        Me.picShape7.TabStop = False
        '
        'picShape3
        '
        Me.picShape3.BackColor = System.Drawing.Color.Transparent
        Me.picShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShape3.Location = New System.Drawing.Point(386, 92)
        Me.picShape3.Name = "picShape3"
        Me.picShape3.Size = New System.Drawing.Size(141, 124)
        Me.picShape3.TabIndex = 14
        Me.picShape3.TabStop = False
        '
        'tmrEndGame
        '
        Me.tmrEndGame.Interval = 1
        '
        'tmrGame
        '
        Me.tmrGame.Enabled = True
        Me.tmrGame.Interval = 1000
        '
        'tmrShapes
        '
        Me.tmrShapes.Enabled = True
        Me.tmrShapes.Interval = 1000
        '
        'picShape5
        '
        Me.picShape5.BackColor = System.Drawing.Color.Transparent
        Me.picShape5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShape5.Location = New System.Drawing.Point(124, 201)
        Me.picShape5.Name = "picShape5"
        Me.picShape5.Size = New System.Drawing.Size(141, 124)
        Me.picShape5.TabIndex = 16
        Me.picShape5.TabStop = False
        '
        'picShape4
        '
        Me.picShape4.BackColor = System.Drawing.Color.Transparent
        Me.picShape4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShape4.Location = New System.Drawing.Point(533, 92)
        Me.picShape4.Name = "picShape4"
        Me.picShape4.Size = New System.Drawing.Size(141, 124)
        Me.picShape4.TabIndex = 18
        Me.picShape4.TabStop = False
        '
        'picShape8
        '
        Me.picShape8.BackColor = System.Drawing.Color.Transparent
        Me.picShape8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShape8.Location = New System.Drawing.Point(532, 209)
        Me.picShape8.Name = "picShape8"
        Me.picShape8.Size = New System.Drawing.Size(141, 124)
        Me.picShape8.TabIndex = 19
        Me.picShape8.TabStop = False
        '
        'lblCurtainDown
        '
        Me.lblCurtainDown.AutoSize = True
        Me.lblCurtainDown.BackColor = System.Drawing.Color.White
        Me.lblCurtainDown.Enabled = False
        Me.lblCurtainDown.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurtainDown.Location = New System.Drawing.Point(239, 455)
        Me.lblCurtainDown.Name = "lblCurtainDown"
        Me.lblCurtainDown.Size = New System.Drawing.Size(364, 23)
        Me.lblCurtainDown.TabIndex = 22
        Me.lblCurtainDown.Text = "Click on me when you've got it all memorized!"
        Me.lblCurtainDown.Visible = False
        '
        'lblAnswersRightPrompt
        '
        Me.lblAnswersRightPrompt.AutoSize = True
        Me.lblAnswersRightPrompt.BackColor = System.Drawing.Color.White
        Me.lblAnswersRightPrompt.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswersRightPrompt.Location = New System.Drawing.Point(12, 360)
        Me.lblAnswersRightPrompt.Name = "lblAnswersRightPrompt"
        Me.lblAnswersRightPrompt.Size = New System.Drawing.Size(129, 23)
        Me.lblAnswersRightPrompt.TabIndex = 23
        Me.lblAnswersRightPrompt.Text = "Answers Right:"
        '
        'lblAnswersWrongPrompt
        '
        Me.lblAnswersWrongPrompt.AutoSize = True
        Me.lblAnswersWrongPrompt.BackColor = System.Drawing.Color.White
        Me.lblAnswersWrongPrompt.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswersWrongPrompt.Location = New System.Drawing.Point(12, 406)
        Me.lblAnswersWrongPrompt.Name = "lblAnswersWrongPrompt"
        Me.lblAnswersWrongPrompt.Size = New System.Drawing.Size(137, 23)
        Me.lblAnswersWrongPrompt.TabIndex = 24
        Me.lblAnswersWrongPrompt.Text = "Answers Wrong:"
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.BackColor = System.Drawing.Color.White
        Me.lblRight.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRight.Location = New System.Drawing.Point(147, 360)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(0, 23)
        Me.lblRight.TabIndex = 25
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.BackColor = System.Drawing.Color.White
        Me.lblWrong.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.Location = New System.Drawing.Point(155, 406)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(0, 23)
        Me.lblWrong.TabIndex = 26
        '
        'picCover
        '
        Me.picCover.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Curtains
        Me.picCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCover.Location = New System.Drawing.Point(0, -2)
        Me.picCover.Name = "picCover"
        Me.picCover.Size = New System.Drawing.Size(800, 341)
        Me.picCover.TabIndex = 2
        Me.picCover.TabStop = False
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.BackColor = System.Drawing.Color.White
        Me.lblHelp.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(539, 374)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(249, 46)
        Me.lblHelp.TabIndex = 27
        Me.lblHelp.Text = "Remember to answer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " with the number ""1"" not ""one"""
        '
        'Game4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Brick_wall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblAnswersWrongPrompt)
        Me.Controls.Add(Me.lblAnswersRightPrompt)
        Me.Controls.Add(Me.lblCurtainDown)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.picCover)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.Controls.Add(Me.picShape3)
        Me.Controls.Add(Me.picShape7)
        Me.Controls.Add(Me.picShape6)
        Me.Controls.Add(Me.picShape2)
        Me.Controls.Add(Me.picShape1)
        Me.Controls.Add(Me.picShape8)
        Me.Controls.Add(Me.picShape4)
        Me.Controls.Add(Me.picShape5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Count!"
        CType(Me.picShape1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents tmrStartGame As System.Windows.Forms.Timer
    Friend WithEvents picShape1 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape2 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape6 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape7 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape3 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrEndGame As System.Windows.Forms.Timer
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents tmrShapes As System.Windows.Forms.Timer
    Friend WithEvents picShape5 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape4 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape8 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCurtainDown As System.Windows.Forms.Label
    Friend WithEvents lblAnswersRightPrompt As System.Windows.Forms.Label
    Friend WithEvents lblAnswersWrongPrompt As System.Windows.Forms.Label
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblWrong As System.Windows.Forms.Label
    Friend WithEvents picCover As System.Windows.Forms.PictureBox
    Friend WithEvents lblHelp As System.Windows.Forms.Label
End Class
