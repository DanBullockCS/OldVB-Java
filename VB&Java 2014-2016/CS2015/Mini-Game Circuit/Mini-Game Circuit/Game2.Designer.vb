<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game2
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
        Me.picTugOfWar = New System.Windows.Forms.PictureBox()
        Me.lblRestart = New System.Windows.Forms.Label()
        Me.lblTimeLeftPrompt = New System.Windows.Forms.Label()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.tmrGameTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTugOfWar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblBackToMenu.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackToMenu.Location = New System.Drawing.Point(620, 9)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(168, 23)
        Me.lblBackToMenu.TabIndex = 25
        Me.lblBackToMenu.Text = "Back to Main Menu"
        '
        'picTugOfWar
        '
        Me.picTugOfWar.BackColor = System.Drawing.Color.Transparent
        Me.picTugOfWar.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Tug_Of_War
        Me.picTugOfWar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTugOfWar.Location = New System.Drawing.Point(170, 225)
        Me.picTugOfWar.Name = "picTugOfWar"
        Me.picTugOfWar.Size = New System.Drawing.Size(452, 142)
        Me.picTugOfWar.TabIndex = 0
        Me.picTugOfWar.TabStop = False
        '
        'lblRestart
        '
        Me.lblRestart.AutoSize = True
        Me.lblRestart.BackColor = System.Drawing.Color.Transparent
        Me.lblRestart.Enabled = False
        Me.lblRestart.Font = New System.Drawing.Font("Kristen ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestart.ForeColor = System.Drawing.Color.Yellow
        Me.lblRestart.Location = New System.Drawing.Point(236, 64)
        Me.lblRestart.Name = "lblRestart"
        Me.lblRestart.Size = New System.Drawing.Size(299, 88)
        Me.lblRestart.TabIndex = 26
        Me.lblRestart.Text = "Restart?"
        Me.lblRestart.Visible = False
        '
        'lblTimeLeftPrompt
        '
        Me.lblTimeLeftPrompt.AutoSize = True
        Me.lblTimeLeftPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeLeftPrompt.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeftPrompt.ForeColor = System.Drawing.Color.Red
        Me.lblTimeLeftPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblTimeLeftPrompt.Name = "lblTimeLeftPrompt"
        Me.lblTimeLeftPrompt.Size = New System.Drawing.Size(87, 23)
        Me.lblTimeLeftPrompt.TabIndex = 27
        Me.lblTimeLeftPrompt.Text = "Time left:"
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.AutoSize = True
        Me.lblTimeLeft.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeLeft.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.ForeColor = System.Drawing.Color.Red
        Me.lblTimeLeft.Location = New System.Drawing.Point(102, 9)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(0, 23)
        Me.lblTimeLeft.TabIndex = 28
        '
        'tmrGameTime
        '
        Me.tmrGameTime.Interval = 10
        '
        'Game2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Plains_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblTimeLeftPrompt)
        Me.Controls.Add(Me.lblRestart)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.Controls.Add(Me.picTugOfWar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tug of war"
        CType(Me.picTugOfWar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTugOfWar As System.Windows.Forms.PictureBox
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents lblRestart As System.Windows.Forms.Label
    Friend WithEvents lblTimeLeftPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTimeLeft As System.Windows.Forms.Label
    Friend WithEvents tmrGameTime As System.Windows.Forms.Timer
End Class
