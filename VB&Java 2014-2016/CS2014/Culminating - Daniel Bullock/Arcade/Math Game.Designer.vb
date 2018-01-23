<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Math_Game
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
        Me.btnNewProblem = New System.Windows.Forms.Button()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.lblProblem = New System.Windows.Forms.Label()
        Me.txtYourAnswer = New System.Windows.Forms.TextBox()
        Me.lblCheckAnswer = New System.Windows.Forms.Label()
        Me.rad1to9 = New System.Windows.Forms.RadioButton()
        Me.rad10to20 = New System.Windows.Forms.RadioButton()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.picOperator = New System.Windows.Forms.PictureBox()
        Me.lblPutAnswerHere = New System.Windows.Forms.Label()
        CType(Me.picOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.lblBackToMenu.Location = New System.Drawing.Point(376, 9)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(196, 23)
        Me.lblBackToMenu.TabIndex = 0
        Me.lblBackToMenu.Text = "Back to Main Menu"
        '
        'btnNewProblem
        '
        Me.btnNewProblem.BackColor = System.Drawing.Color.Aqua
        Me.btnNewProblem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.0!)
        Me.btnNewProblem.Location = New System.Drawing.Point(28, 417)
        Me.btnNewProblem.Name = "btnNewProblem"
        Me.btnNewProblem.Size = New System.Drawing.Size(137, 104)
        Me.btnNewProblem.TabIndex = 1
        Me.btnNewProblem.Text = "New Problem"
        Me.btnNewProblem.UseVisualStyleBackColor = False
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.BackColor = System.Drawing.Color.Lime
        Me.btnCheckAnswer.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.0!)
        Me.btnCheckAnswer.Location = New System.Drawing.Point(216, 417)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(137, 104)
        Me.btnCheckAnswer.TabIndex = 2
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = False
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.BackColor = System.Drawing.Color.Red
        Me.btnShowAnswer.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.0!)
        Me.btnShowAnswer.Location = New System.Drawing.Point(397, 417)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(137, 104)
        Me.btnShowAnswer.TabIndex = 3
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = False
        '
        'lblProblem
        '
        Me.lblProblem.AutoSize = True
        Me.lblProblem.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!)
        Me.lblProblem.Location = New System.Drawing.Point(38, 83)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(0, 30)
        Me.lblProblem.TabIndex = 4
        '
        'txtYourAnswer
        '
        Me.txtYourAnswer.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.txtYourAnswer.Location = New System.Drawing.Point(333, 165)
        Me.txtYourAnswer.Multiline = True
        Me.txtYourAnswer.Name = "txtYourAnswer"
        Me.txtYourAnswer.Size = New System.Drawing.Size(200, 64)
        Me.txtYourAnswer.TabIndex = 5
        '
        'lblCheckAnswer
        '
        Me.lblCheckAnswer.AutoSize = True
        Me.lblCheckAnswer.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.lblCheckAnswer.Location = New System.Drawing.Point(13, 277)
        Me.lblCheckAnswer.Name = "lblCheckAnswer"
        Me.lblCheckAnswer.Size = New System.Drawing.Size(0, 20)
        Me.lblCheckAnswer.TabIndex = 6
        '
        'rad1to9
        '
        Me.rad1to9.AutoSize = True
        Me.rad1to9.Checked = True
        Me.rad1to9.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.rad1to9.Location = New System.Drawing.Point(334, 67)
        Me.rad1to9.Name = "rad1to9"
        Me.rad1to9.Size = New System.Drawing.Size(73, 27)
        Me.rad1to9.TabIndex = 7
        Me.rad1to9.TabStop = True
        Me.rad1to9.Text = "Easy"
        Me.rad1to9.UseVisualStyleBackColor = True
        '
        'rad10to20
        '
        Me.rad10to20.AutoSize = True
        Me.rad10to20.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.rad10to20.Location = New System.Drawing.Point(334, 90)
        Me.rad10to20.Name = "rad10to20"
        Me.rad10to20.Size = New System.Drawing.Size(79, 27)
        Me.rad10to20.TabIndex = 8
        Me.rad10to20.Text = "Hard"
        Me.rad10to20.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!)
        Me.lblScore.ForeColor = System.Drawing.Color.Red
        Me.lblScore.Location = New System.Drawing.Point(12, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(95, 30)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "Score:"
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.lblDifficulty.Location = New System.Drawing.Point(348, 44)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(185, 23)
        Me.lblDifficulty.TabIndex = 10
        Me.lblDifficulty.Text = "Select a difficulty"
        '
        'picOperator
        '
        Me.picOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picOperator.Location = New System.Drawing.Point(233, 9)
        Me.picOperator.Name = "picOperator"
        Me.picOperator.Size = New System.Drawing.Size(95, 84)
        Me.picOperator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOperator.TabIndex = 11
        Me.picOperator.TabStop = False
        '
        'lblPutAnswerHere
        '
        Me.lblPutAnswerHere.AutoSize = True
        Me.lblPutAnswerHere.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.lblPutAnswerHere.Location = New System.Drawing.Point(329, 139)
        Me.lblPutAnswerHere.Name = "lblPutAnswerHere"
        Me.lblPutAnswerHere.Size = New System.Drawing.Size(250, 23)
        Me.lblPutAnswerHere.TabIndex = 12
        Me.lblPutAnswerHere.Text = "Put your answer in here"
        '
        'Math_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.lblPutAnswerHere)
        Me.Controls.Add(Me.picOperator)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.rad10to20)
        Me.Controls.Add(Me.rad1to9)
        Me.Controls.Add(Me.lblCheckAnswer)
        Me.Controls.Add(Me.txtYourAnswer)
        Me.Controls.Add(Me.lblProblem)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.btnNewProblem)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.Name = "Math_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Math Game"
        CType(Me.picOperator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents btnNewProblem As System.Windows.Forms.Button
    Friend WithEvents btnCheckAnswer As System.Windows.Forms.Button
    Friend WithEvents btnShowAnswer As System.Windows.Forms.Button
    Friend WithEvents lblProblem As System.Windows.Forms.Label
    Friend WithEvents txtYourAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblCheckAnswer As System.Windows.Forms.Label
    Friend WithEvents rad1to9 As System.Windows.Forms.RadioButton
    Friend WithEvents rad10to20 As System.Windows.Forms.RadioButton
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblDifficulty As System.Windows.Forms.Label
    Friend WithEvents picOperator As System.Windows.Forms.PictureBox
    Friend WithEvents lblPutAnswerHere As System.Windows.Forms.Label
End Class
