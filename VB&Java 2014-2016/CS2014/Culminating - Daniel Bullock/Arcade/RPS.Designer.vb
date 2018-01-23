<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPS
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
        Me.lblBackToMenu = New System.Windows.Forms.Label()
        Me.btnThrow = New System.Windows.Forms.Button()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblLosses = New System.Windows.Forms.Label()
        Me.lblDraws = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.lblBackToMenu.Location = New System.Drawing.Point(376, 9)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(196, 23)
        Me.lblBackToMenu.TabIndex = 1
        Me.lblBackToMenu.Text = "Back to Main Menu"
        '
        'btnThrow
        '
        Me.btnThrow.BackColor = System.Drawing.Color.Lime
        Me.btnThrow.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.btnThrow.Location = New System.Drawing.Point(263, 254)
        Me.btnThrow.Name = "btnThrow"
        Me.btnThrow.Size = New System.Drawing.Size(106, 90)
        Me.btnThrow.TabIndex = 5
        Me.btnThrow.Text = "Throw!"
        Me.btnThrow.UseVisualStyleBackColor = False
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.25!)
        Me.radPaper.Location = New System.Drawing.Point(410, 175)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(67, 22)
        Me.radPaper.TabIndex = 6
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.25!)
        Me.radScissors.Location = New System.Drawing.Point(66, 177)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(81, 22)
        Me.radScissors.TabIndex = 7
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.25!)
        Me.radRock.Location = New System.Drawing.Point(236, 177)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(60, 22)
        Me.radRock.TabIndex = 8
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.lblWins.Location = New System.Drawing.Point(26, 494)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(57, 20)
        Me.lblWins.TabIndex = 9
        Me.lblWins.Text = "Wins:"
        '
        'lblLosses
        '
        Me.lblLosses.AutoSize = True
        Me.lblLosses.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.lblLosses.Location = New System.Drawing.Point(243, 494)
        Me.lblLosses.Name = "lblLosses"
        Me.lblLosses.Size = New System.Drawing.Size(72, 20)
        Me.lblLosses.TabIndex = 10
        Me.lblLosses.Text = "Losses:"
        '
        'lblDraws
        '
        Me.lblDraws.AutoSize = True
        Me.lblDraws.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.lblDraws.Location = New System.Drawing.Point(456, 494)
        Me.lblDraws.Name = "lblDraws"
        Me.lblDraws.Size = New System.Drawing.Size(69, 20)
        Me.lblDraws.TabIndex = 11
        Me.lblDraws.Text = "Draws:"
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.lblWinner.Location = New System.Drawing.Point(97, 404)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(0, 20)
        Me.lblWinner.TabIndex = 12
        '
        'picPaper
        '
        Me.picPaper.Image = Global.Arcade.My.Resources.Resources.Paper
        Me.picPaper.Location = New System.Drawing.Point(401, 69)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(110, 100)
        Me.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPaper.TabIndex = 4
        Me.picPaper.TabStop = False
        '
        'picRock
        '
        Me.picRock.Image = Global.Arcade.My.Resources.Resources.Rock
        Me.picRock.Location = New System.Drawing.Point(236, 69)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(106, 102)
        Me.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRock.TabIndex = 3
        Me.picRock.TabStop = False
        '
        'picScissors
        '
        Me.picScissors.Image = Global.Arcade.My.Resources.Resources.Scissors
        Me.picScissors.Location = New System.Drawing.Point(66, 69)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(105, 102)
        Me.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picScissors.TabIndex = 2
        Me.picScissors.TabStop = False
        '
        'RPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(584, 552)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblDraws)
        Me.Controls.Add(Me.lblLosses)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.radRock)
        Me.Controls.Add(Me.radScissors)
        Me.Controls.Add(Me.radPaper)
        Me.Controls.Add(Me.btnThrow)
        Me.Controls.Add(Me.picPaper)
        Me.Controls.Add(Me.picRock)
        Me.Controls.Add(Me.picScissors)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RPS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RPS"
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents picScissors As System.Windows.Forms.PictureBox
    Friend WithEvents picRock As System.Windows.Forms.PictureBox
    Friend WithEvents picPaper As System.Windows.Forms.PictureBox
    Friend WithEvents btnThrow As System.Windows.Forms.Button
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents lblLosses As System.Windows.Forms.Label
    Friend WithEvents lblDraws As System.Windows.Forms.Label
    Friend WithEvents lblWinner As System.Windows.Forms.Label
End Class
