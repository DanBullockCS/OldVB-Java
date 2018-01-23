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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDrawCard = New System.Windows.Forms.Button()
        Me.btnCheckScores = New System.Windows.Forms.Button()
        Me.lblPlayerIsDealtQuestion = New System.Windows.Forms.Label()
        Me.lblPlayersScoreQuestion = New System.Windows.Forms.Label()
        Me.lblPlayersScore = New System.Windows.Forms.Label()
        Me.lblCompIsDealtQuestion = New System.Windows.Forms.Label()
        Me.lblCompsScoreQuestion = New System.Windows.Forms.Label()
        Me.lblCompCard3 = New System.Windows.Forms.Label()
        Me.lblCompsScore = New System.Windows.Forms.Label()
        Me.lblCompCard1 = New System.Windows.Forms.Label()
        Me.lblCompCard2 = New System.Windows.Forms.Label()
        Me.lblPlayerCard2 = New System.Windows.Forms.Label()
        Me.lblPlayerCard1 = New System.Windows.Forms.Label()
        Me.lblPlayerCard3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(337, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'PlayGameToolStripMenuItem
        '
        Me.PlayGameToolStripMenuItem.Name = "PlayGameToolStripMenuItem"
        Me.PlayGameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PlayGameToolStripMenuItem.Text = "Play Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnDrawCard
        '
        Me.btnDrawCard.Location = New System.Drawing.Point(215, 75)
        Me.btnDrawCard.Name = "btnDrawCard"
        Me.btnDrawCard.Size = New System.Drawing.Size(88, 22)
        Me.btnDrawCard.TabIndex = 2
        Me.btnDrawCard.Text = "Draw Card"
        Me.btnDrawCard.UseVisualStyleBackColor = True
        '
        'btnCheckScores
        '
        Me.btnCheckScores.Location = New System.Drawing.Point(12, 117)
        Me.btnCheckScores.Name = "btnCheckScores"
        Me.btnCheckScores.Size = New System.Drawing.Size(91, 21)
        Me.btnCheckScores.TabIndex = 3
        Me.btnCheckScores.Text = "Check Scores"
        Me.btnCheckScores.UseVisualStyleBackColor = True
        '
        'lblPlayerIsDealtQuestion
        '
        Me.lblPlayerIsDealtQuestion.AutoSize = True
        Me.lblPlayerIsDealtQuestion.Location = New System.Drawing.Point(25, 46)
        Me.lblPlayerIsDealtQuestion.Name = "lblPlayerIsDealtQuestion"
        Me.lblPlayerIsDealtQuestion.Size = New System.Drawing.Size(96, 13)
        Me.lblPlayerIsDealtQuestion.TabIndex = 4
        Me.lblPlayerIsDealtQuestion.Text = "The player is dealt:"
        '
        'lblPlayersScoreQuestion
        '
        Me.lblPlayersScoreQuestion.AutoSize = True
        Me.lblPlayersScoreQuestion.Location = New System.Drawing.Point(25, 84)
        Me.lblPlayersScoreQuestion.Name = "lblPlayersScoreQuestion"
        Me.lblPlayersScoreQuestion.Size = New System.Drawing.Size(75, 13)
        Me.lblPlayersScoreQuestion.TabIndex = 5
        Me.lblPlayersScoreQuestion.Text = "Players Score:"
        '
        'lblPlayersScore
        '
        Me.lblPlayersScore.AutoSize = True
        Me.lblPlayersScore.Location = New System.Drawing.Point(106, 84)
        Me.lblPlayersScore.Name = "lblPlayersScore"
        Me.lblPlayersScore.Size = New System.Drawing.Size(0, 13)
        Me.lblPlayersScore.TabIndex = 6
        '
        'lblCompIsDealtQuestion
        '
        Me.lblCompIsDealtQuestion.AutoSize = True
        Me.lblCompIsDealtQuestion.Location = New System.Drawing.Point(12, 159)
        Me.lblCompIsDealtQuestion.Name = "lblCompIsDealtQuestion"
        Me.lblCompIsDealtQuestion.Size = New System.Drawing.Size(112, 13)
        Me.lblCompIsDealtQuestion.TabIndex = 7
        Me.lblCompIsDealtQuestion.Text = "The computer is dealt:"
        '
        'lblCompsScoreQuestion
        '
        Me.lblCompsScoreQuestion.AutoSize = True
        Me.lblCompsScoreQuestion.Location = New System.Drawing.Point(9, 214)
        Me.lblCompsScoreQuestion.Name = "lblCompsScoreQuestion"
        Me.lblCompsScoreQuestion.Size = New System.Drawing.Size(93, 13)
        Me.lblCompsScoreQuestion.TabIndex = 8
        Me.lblCompsScoreQuestion.Text = "Computer's Score:"
        '
        'lblCompCard3
        '
        Me.lblCompCard3.AutoSize = True
        Me.lblCompCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompCard3.Location = New System.Drawing.Point(248, 159)
        Me.lblCompCard3.Name = "lblCompCard3"
        Me.lblCompCard3.Size = New System.Drawing.Size(0, 25)
        Me.lblCompCard3.TabIndex = 9
        '
        'lblCompsScore
        '
        Me.lblCompsScore.AutoSize = True
        Me.lblCompsScore.Location = New System.Drawing.Point(106, 214)
        Me.lblCompsScore.Name = "lblCompsScore"
        Me.lblCompsScore.Size = New System.Drawing.Size(0, 13)
        Me.lblCompsScore.TabIndex = 10
        '
        'lblCompCard1
        '
        Me.lblCompCard1.AutoSize = True
        Me.lblCompCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompCard1.Location = New System.Drawing.Point(146, 159)
        Me.lblCompCard1.Name = "lblCompCard1"
        Me.lblCompCard1.Size = New System.Drawing.Size(0, 25)
        Me.lblCompCard1.TabIndex = 11
        '
        'lblCompCard2
        '
        Me.lblCompCard2.AutoSize = True
        Me.lblCompCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompCard2.Location = New System.Drawing.Point(197, 159)
        Me.lblCompCard2.Name = "lblCompCard2"
        Me.lblCompCard2.Size = New System.Drawing.Size(0, 25)
        Me.lblCompCard2.TabIndex = 12
        '
        'lblPlayerCard2
        '
        Me.lblPlayerCard2.AutoSize = True
        Me.lblPlayerCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerCard2.Location = New System.Drawing.Point(197, 46)
        Me.lblPlayerCard2.Name = "lblPlayerCard2"
        Me.lblPlayerCard2.Size = New System.Drawing.Size(0, 25)
        Me.lblPlayerCard2.TabIndex = 13
        '
        'lblPlayerCard1
        '
        Me.lblPlayerCard1.AutoSize = True
        Me.lblPlayerCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerCard1.Location = New System.Drawing.Point(146, 46)
        Me.lblPlayerCard1.Name = "lblPlayerCard1"
        Me.lblPlayerCard1.Size = New System.Drawing.Size(0, 25)
        Me.lblPlayerCard1.TabIndex = 14
        '
        'lblPlayerCard3
        '
        Me.lblPlayerCard3.AutoSize = True
        Me.lblPlayerCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerCard3.Location = New System.Drawing.Point(248, 46)
        Me.lblPlayerCard3.Name = "lblPlayerCard3"
        Me.lblPlayerCard3.Size = New System.Drawing.Size(0, 25)
        Me.lblPlayerCard3.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 251)
        Me.Controls.Add(Me.lblPlayerCard3)
        Me.Controls.Add(Me.lblPlayerCard1)
        Me.Controls.Add(Me.lblPlayerCard2)
        Me.Controls.Add(Me.lblCompCard2)
        Me.Controls.Add(Me.lblCompCard1)
        Me.Controls.Add(Me.lblCompsScore)
        Me.Controls.Add(Me.lblCompCard3)
        Me.Controls.Add(Me.lblCompsScoreQuestion)
        Me.Controls.Add(Me.lblCompIsDealtQuestion)
        Me.Controls.Add(Me.lblPlayersScore)
        Me.Controls.Add(Me.lblPlayersScoreQuestion)
        Me.Controls.Add(Me.lblPlayerIsDealtQuestion)
        Me.Controls.Add(Me.btnCheckScores)
        Me.Controls.Add(Me.btnDrawCard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Game of 21"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDrawCard As System.Windows.Forms.Button
    Friend WithEvents btnCheckScores As System.Windows.Forms.Button
    Friend WithEvents lblPlayerIsDealtQuestion As System.Windows.Forms.Label
    Friend WithEvents lblPlayersScoreQuestion As System.Windows.Forms.Label
    Friend WithEvents lblPlayersScore As System.Windows.Forms.Label
    Friend WithEvents lblCompIsDealtQuestion As System.Windows.Forms.Label
    Friend WithEvents lblCompsScoreQuestion As System.Windows.Forms.Label
    Friend WithEvents lblCompCard3 As System.Windows.Forms.Label
    Friend WithEvents lblCompsScore As System.Windows.Forms.Label
    Friend WithEvents lblCompCard1 As System.Windows.Forms.Label
    Friend WithEvents lblCompCard2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerCard2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerCard1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerCard3 As System.Windows.Forms.Label

End Class
