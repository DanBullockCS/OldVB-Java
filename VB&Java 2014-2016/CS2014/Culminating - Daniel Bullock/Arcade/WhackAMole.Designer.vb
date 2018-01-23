<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhackAMole
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
        Me.picMole = New System.Windows.Forms.PictureBox()
        Me.lblHowToPlay = New System.Windows.Forms.Label()
        Me.tmrMole = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblWhacks = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.RadEasy = New System.Windows.Forms.RadioButton()
        Me.RadMedium = New System.Windows.Forms.RadioButton()
        Me.RadHard = New System.Windows.Forms.RadioButton()
        CType(Me.picMole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.lblBackToMenu.ForeColor = System.Drawing.Color.Yellow
        Me.lblBackToMenu.Location = New System.Drawing.Point(376, 9)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(196, 23)
        Me.lblBackToMenu.TabIndex = 2
        Me.lblBackToMenu.Text = "Back to Main Menu"
        '
        'picMole
        '
        Me.picMole.BackColor = System.Drawing.Color.Transparent
        Me.picMole.Location = New System.Drawing.Point(252, 211)
        Me.picMole.Name = "picMole"
        Me.picMole.Size = New System.Drawing.Size(86, 86)
        Me.picMole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMole.TabIndex = 3
        Me.picMole.TabStop = False
        '
        'lblHowToPlay
        '
        Me.lblHowToPlay.AutoSize = True
        Me.lblHowToPlay.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.0!)
        Me.lblHowToPlay.ForeColor = System.Drawing.Color.Yellow
        Me.lblHowToPlay.Location = New System.Drawing.Point(12, 509)
        Me.lblHowToPlay.Name = "lblHowToPlay"
        Me.lblHowToPlay.Size = New System.Drawing.Size(408, 54)
        Me.lblHowToPlay.TabIndex = 4
        Me.lblHowToPlay.Text = "Choose a difficulty on the right and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "whack the mole with your hammer (mouse) to" & _
            " get points. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Got it? press start."
        '
        'tmrMole
        '
        Me.tmrMole.Interval = 500
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Cyan
        Me.btnStart.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(469, 524)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(103, 25)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblWhacks
        '
        Me.lblWhacks.AutoSize = True
        Me.lblWhacks.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.lblWhacks.ForeColor = System.Drawing.Color.Yellow
        Me.lblWhacks.Location = New System.Drawing.Point(12, 9)
        Me.lblWhacks.Name = "lblWhacks"
        Me.lblWhacks.Size = New System.Drawing.Size(114, 23)
        Me.lblWhacks.TabIndex = 6
        Me.lblWhacks.Text = "Whacks: 0"
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.Yellow
        Me.lblTime.Location = New System.Drawing.Point(248, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(64, 23)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "Time:"
        '
        'RadEasy
        '
        Me.RadEasy.AutoSize = True
        Me.RadEasy.Checked = True
        Me.RadEasy.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.RadEasy.Location = New System.Drawing.Point(480, 202)
        Me.RadEasy.Name = "RadEasy"
        Me.RadEasy.Size = New System.Drawing.Size(66, 24)
        Me.RadEasy.TabIndex = 8
        Me.RadEasy.TabStop = True
        Me.RadEasy.Text = "Easy"
        Me.RadEasy.UseVisualStyleBackColor = True
        '
        'RadMedium
        '
        Me.RadMedium.AutoSize = True
        Me.RadMedium.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.RadMedium.Location = New System.Drawing.Point(479, 242)
        Me.RadMedium.Name = "RadMedium"
        Me.RadMedium.Size = New System.Drawing.Size(96, 24)
        Me.RadMedium.TabIndex = 9
        Me.RadMedium.TabStop = True
        Me.RadMedium.Text = "Medium"
        Me.RadMedium.UseVisualStyleBackColor = True
        '
        'RadHard
        '
        Me.RadHard.AutoSize = True
        Me.RadHard.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.RadHard.Location = New System.Drawing.Point(479, 282)
        Me.RadHard.Name = "RadHard"
        Me.RadHard.Size = New System.Drawing.Size(71, 24)
        Me.RadHard.TabIndex = 10
        Me.RadHard.TabStop = True
        Me.RadHard.Text = "Hard"
        Me.RadHard.UseVisualStyleBackColor = True
        '
        'WhackAMole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImage = Global.Arcade.My.Resources.Resources.Background_WAM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.RadHard)
        Me.Controls.Add(Me.RadMedium)
        Me.Controls.Add(Me.RadEasy)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblWhacks)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblHowToPlay)
        Me.Controls.Add(Me.picMole)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "WhackAMole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WhackAMole"
        CType(Me.picMole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents picMole As System.Windows.Forms.PictureBox
    Friend WithEvents lblHowToPlay As System.Windows.Forms.Label
    Friend WithEvents tmrMole As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblWhacks As System.Windows.Forms.Label
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents RadEasy As System.Windows.Forms.RadioButton
    Friend WithEvents RadMedium As System.Windows.Forms.RadioButton
    Friend WithEvents RadHard As System.Windows.Forms.RadioButton
End Class
