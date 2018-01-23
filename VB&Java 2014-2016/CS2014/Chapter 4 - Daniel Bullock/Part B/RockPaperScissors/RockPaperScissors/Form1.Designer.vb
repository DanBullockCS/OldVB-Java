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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.grpboxThrows = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblLosses = New System.Windows.Forms.Label()
        Me.lblDraws = New System.Windows.Forms.Label()
        Me.grpboxThrows.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(113, 149)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(76, 22)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'grpboxThrows
        '
        Me.grpboxThrows.Controls.Add(Me.radScissors)
        Me.grpboxThrows.Controls.Add(Me.radPaper)
        Me.grpboxThrows.Controls.Add(Me.radRock)
        Me.grpboxThrows.Location = New System.Drawing.Point(21, 12)
        Me.grpboxThrows.Name = "grpboxThrows"
        Me.grpboxThrows.Size = New System.Drawing.Size(259, 66)
        Me.grpboxThrows.TabIndex = 1
        Me.grpboxThrows.TabStop = False
        Me.grpboxThrows.Text = "Choose Your Throw"
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(179, 28)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 2
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(101, 28)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 1
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(17, 28)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Location = New System.Drawing.Point(35, 109)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(0, 13)
        Me.lblWinner.TabIndex = 2
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Location = New System.Drawing.Point(18, 212)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(34, 13)
        Me.lblWins.TabIndex = 3
        Me.lblWins.Text = "Wins:"
        '
        'lblLosses
        '
        Me.lblLosses.AutoSize = True
        Me.lblLosses.Location = New System.Drawing.Point(119, 212)
        Me.lblLosses.Name = "lblLosses"
        Me.lblLosses.Size = New System.Drawing.Size(43, 13)
        Me.lblLosses.TabIndex = 4
        Me.lblLosses.Text = "Losses:"
        '
        'lblDraws
        '
        Me.lblDraws.AutoSize = True
        Me.lblDraws.Location = New System.Drawing.Point(225, 212)
        Me.lblDraws.Name = "lblDraws"
        Me.lblDraws.Size = New System.Drawing.Size(40, 13)
        Me.lblDraws.TabIndex = 5
        Me.lblDraws.Text = "Draws:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 234)
        Me.Controls.Add(Me.lblDraws)
        Me.Controls.Add(Me.lblLosses)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.grpboxThrows)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.grpboxThrows.ResumeLayout(False)
        Me.grpboxThrows.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents grpboxThrows As System.Windows.Forms.GroupBox
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents lblLosses As System.Windows.Forms.Label
    Friend WithEvents lblDraws As System.Windows.Forms.Label

End Class
