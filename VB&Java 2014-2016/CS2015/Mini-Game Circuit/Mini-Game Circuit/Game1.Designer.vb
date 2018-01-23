<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game1
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblTimePrompt = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn14 = New System.Windows.Forms.Button()
        Me.btn16 = New System.Windows.Forms.Button()
        Me.btn17 = New System.Windows.Forms.Button()
        Me.btn18 = New System.Windows.Forms.Button()
        Me.btn19 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn15 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.tmrGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblPause = New System.Windows.Forms.Label()
        Me.tmrShowColours = New System.Windows.Forms.Timer(Me.components)
        Me.lblMemorizeColours = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblBackToMenu.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackToMenu.Location = New System.Drawing.Point(521, 344)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(168, 23)
        Me.lblBackToMenu.TabIndex = 24
        Me.lblBackToMenu.Text = "Back to Main Menu"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Red
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1.Location = New System.Drawing.Point(29, 34)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(67, 87)
        Me.btn1.TabIndex = 30
        Me.btn1.Tag = "Red"
        Me.btn1.UseVisualStyleBackColor = False
        Me.btn1.Visible = False
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Font = New System.Drawing.Font("Kristen ITC", 12.0!)
        Me.lblStart.Location = New System.Drawing.Point(559, 111)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(120, 23)
        Me.lblStart.TabIndex = 55
        Me.lblStart.Text = "Click to Start"
        '
        'lblTimePrompt
        '
        Me.lblTimePrompt.AutoSize = True
        Me.lblTimePrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblTimePrompt.Font = New System.Drawing.Font("Kristen ITC", 12.0!)
        Me.lblTimePrompt.Location = New System.Drawing.Point(521, 158)
        Me.lblTimePrompt.Name = "lblTimePrompt"
        Me.lblTimePrompt.Size = New System.Drawing.Size(53, 23)
        Me.lblTimePrompt.TabIndex = 56
        Me.lblTimePrompt.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Kristen ITC", 12.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(642, 158)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 23)
        Me.lblTime.TabIndex = 57
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Blue
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn2.Location = New System.Drawing.Point(102, 34)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(67, 87)
        Me.btn2.TabIndex = 58
        Me.btn2.Tag = "Blue"
        Me.btn2.UseVisualStyleBackColor = False
        Me.btn2.Visible = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Green
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn3.Location = New System.Drawing.Point(175, 34)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(67, 87)
        Me.btn3.TabIndex = 59
        Me.btn3.Tag = "Green"
        Me.btn3.UseVisualStyleBackColor = False
        Me.btn3.Visible = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Magenta
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn4.Location = New System.Drawing.Point(248, 34)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(67, 87)
        Me.btn4.TabIndex = 60
        Me.btn4.Tag = "Magenta"
        Me.btn4.UseVisualStyleBackColor = False
        Me.btn4.Visible = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Blue
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn6.Location = New System.Drawing.Point(29, 127)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(67, 87)
        Me.btn6.TabIndex = 61
        Me.btn6.Tag = "Blue"
        Me.btn6.UseVisualStyleBackColor = False
        Me.btn6.Visible = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.Yellow
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn7.Location = New System.Drawing.Point(102, 127)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(67, 87)
        Me.btn7.TabIndex = 62
        Me.btn7.Tag = "Yellow"
        Me.btn7.UseVisualStyleBackColor = False
        Me.btn7.Visible = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.Cyan
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn8.Location = New System.Drawing.Point(175, 127)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(67, 87)
        Me.btn8.TabIndex = 63
        Me.btn8.Tag = "Cyan"
        Me.btn8.UseVisualStyleBackColor = False
        Me.btn8.Visible = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.Cyan
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn9.Location = New System.Drawing.Point(248, 127)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(67, 87)
        Me.btn9.TabIndex = 64
        Me.btn9.Tag = "Cyan"
        Me.btn9.UseVisualStyleBackColor = False
        Me.btn9.Visible = False
        '
        'btn11
        '
        Me.btn11.BackColor = System.Drawing.Color.Orange
        Me.btn11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn11.Location = New System.Drawing.Point(29, 220)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(67, 87)
        Me.btn11.TabIndex = 65
        Me.btn11.Tag = "Orange"
        Me.btn11.UseVisualStyleBackColor = False
        Me.btn11.Visible = False
        '
        'btn12
        '
        Me.btn12.BackColor = System.Drawing.Color.Purple
        Me.btn12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn12.Location = New System.Drawing.Point(102, 220)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(67, 87)
        Me.btn12.TabIndex = 66
        Me.btn12.Tag = "Purple"
        Me.btn12.UseVisualStyleBackColor = False
        Me.btn12.Visible = False
        '
        'btn13
        '
        Me.btn13.BackColor = System.Drawing.Color.Black
        Me.btn13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn13.Location = New System.Drawing.Point(175, 220)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(67, 87)
        Me.btn13.TabIndex = 67
        Me.btn13.Tag = "Black"
        Me.btn13.UseVisualStyleBackColor = False
        Me.btn13.Visible = False
        '
        'btn14
        '
        Me.btn14.BackColor = System.Drawing.Color.Crimson
        Me.btn14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn14.Location = New System.Drawing.Point(248, 220)
        Me.btn14.Name = "btn14"
        Me.btn14.Size = New System.Drawing.Size(67, 87)
        Me.btn14.TabIndex = 68
        Me.btn14.Tag = "Crimson"
        Me.btn14.UseVisualStyleBackColor = False
        Me.btn14.Visible = False
        '
        'btn16
        '
        Me.btn16.BackColor = System.Drawing.Color.Yellow
        Me.btn16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn16.Location = New System.Drawing.Point(29, 313)
        Me.btn16.Name = "btn16"
        Me.btn16.Size = New System.Drawing.Size(67, 87)
        Me.btn16.TabIndex = 69
        Me.btn16.Tag = "Yellow"
        Me.btn16.UseVisualStyleBackColor = False
        Me.btn16.Visible = False
        '
        'btn17
        '
        Me.btn17.BackColor = System.Drawing.Color.Purple
        Me.btn17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn17.Location = New System.Drawing.Point(102, 313)
        Me.btn17.Name = "btn17"
        Me.btn17.Size = New System.Drawing.Size(67, 87)
        Me.btn17.TabIndex = 70
        Me.btn17.Tag = "Purple"
        Me.btn17.UseVisualStyleBackColor = False
        Me.btn17.Visible = False
        '
        'btn18
        '
        Me.btn18.BackColor = System.Drawing.Color.Crimson
        Me.btn18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn18.Location = New System.Drawing.Point(175, 313)
        Me.btn18.Name = "btn18"
        Me.btn18.Size = New System.Drawing.Size(67, 87)
        Me.btn18.TabIndex = 71
        Me.btn18.Tag = "Crimson"
        Me.btn18.UseVisualStyleBackColor = False
        Me.btn18.Visible = False
        '
        'btn19
        '
        Me.btn19.BackColor = System.Drawing.Color.Orange
        Me.btn19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn19.Location = New System.Drawing.Point(248, 313)
        Me.btn19.Name = "btn19"
        Me.btn19.Size = New System.Drawing.Size(67, 87)
        Me.btn19.TabIndex = 72
        Me.btn19.Tag = "Orange"
        Me.btn19.UseVisualStyleBackColor = False
        Me.btn19.Visible = False
        '
        'btn20
        '
        Me.btn20.BackColor = System.Drawing.Color.Magenta
        Me.btn20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn20.Location = New System.Drawing.Point(321, 313)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(67, 87)
        Me.btn20.TabIndex = 73
        Me.btn20.Tag = "Magenta"
        Me.btn20.UseVisualStyleBackColor = False
        Me.btn20.Visible = False
        '
        'btn15
        '
        Me.btn15.BackColor = System.Drawing.Color.Black
        Me.btn15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn15.Location = New System.Drawing.Point(321, 220)
        Me.btn15.Name = "btn15"
        Me.btn15.Size = New System.Drawing.Size(67, 87)
        Me.btn15.TabIndex = 74
        Me.btn15.Tag = "Black"
        Me.btn15.UseVisualStyleBackColor = False
        Me.btn15.Visible = False
        '
        'btn10
        '
        Me.btn10.BackColor = System.Drawing.Color.Green
        Me.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn10.Location = New System.Drawing.Point(321, 127)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(67, 87)
        Me.btn10.TabIndex = 75
        Me.btn10.Tag = "Green"
        Me.btn10.UseVisualStyleBackColor = False
        Me.btn10.Visible = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Red
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5.Location = New System.Drawing.Point(321, 34)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(67, 87)
        Me.btn5.TabIndex = 76
        Me.btn5.Tag = "Red"
        Me.btn5.UseVisualStyleBackColor = False
        Me.btn5.Visible = False
        '
        'tmrGameTime
        '
        Me.tmrGameTime.Interval = 1000
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.BackColor = System.Drawing.Color.Transparent
        Me.lblPause.Font = New System.Drawing.Font("Kristen ITC", 12.0!)
        Me.lblPause.Location = New System.Drawing.Point(555, 237)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(124, 23)
        Me.lblPause.TabIndex = 79
        Me.lblPause.Text = "Click to Pause"
        '
        'tmrShowColours
        '
        Me.tmrShowColours.Interval = 1000
        '
        'lblMemorizeColours
        '
        Me.lblMemorizeColours.AutoSize = True
        Me.lblMemorizeColours.BackColor = System.Drawing.Color.Transparent
        Me.lblMemorizeColours.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemorizeColours.ForeColor = System.Drawing.Color.Black
        Me.lblMemorizeColours.Location = New System.Drawing.Point(123, 435)
        Me.lblMemorizeColours.Name = "lblMemorizeColours"
        Me.lblMemorizeColours.Size = New System.Drawing.Size(529, 44)
        Me.lblMemorizeColours.TabIndex = 80
        Me.lblMemorizeColours.Text = "MEMORIZE THE COLOURS!"
        Me.lblMemorizeColours.Visible = False
        '
        'Game1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mini_Game_Circuit.My.Resources.Resources.Table_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMemorizeColours)
        Me.Controls.Add(Me.lblPause)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn15)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.btn19)
        Me.Controls.Add(Me.btn18)
        Me.Controls.Add(Me.btn17)
        Me.Controls.Add(Me.btn16)
        Me.Controls.Add(Me.btn14)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTimePrompt)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Match"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblTimePrompt As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn11 As System.Windows.Forms.Button
    Friend WithEvents btn12 As System.Windows.Forms.Button
    Friend WithEvents btn13 As System.Windows.Forms.Button
    Friend WithEvents btn14 As System.Windows.Forms.Button
    Friend WithEvents btn16 As System.Windows.Forms.Button
    Friend WithEvents btn17 As System.Windows.Forms.Button
    Friend WithEvents btn18 As System.Windows.Forms.Button
    Friend WithEvents btn19 As System.Windows.Forms.Button
    Friend WithEvents btn20 As System.Windows.Forms.Button
    Friend WithEvents btn15 As System.Windows.Forms.Button
    Friend WithEvents btn10 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents tmrGameTime As System.Windows.Forms.Timer
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents tmrShowColours As System.Windows.Forms.Timer
    Friend WithEvents lblMemorizeColours As System.Windows.Forms.Label
End Class
