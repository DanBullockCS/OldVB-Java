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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblScoresMessage = New System.Windows.Forms.Label()
        Me.btnEnterScores = New System.Windows.Forms.Button()
        Me.btnAverageScore = New System.Windows.Forms.Button()
        Me.lblNumberOfScores = New System.Windows.Forms.Label()
        Me.lblAverageMessage = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(32, 24)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(230, 39)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Select Enter Scores to enter test scores. Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Average Scores to display the a" & _
            "verage of the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "scores entered."
        '
        'lblScoresMessage
        '
        Me.lblScoresMessage.AutoSize = True
        Me.lblScoresMessage.Location = New System.Drawing.Point(163, 116)
        Me.lblScoresMessage.Name = "lblScoresMessage"
        Me.lblScoresMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblScoresMessage.TabIndex = 1
        '
        'btnEnterScores
        '
        Me.btnEnterScores.Location = New System.Drawing.Point(35, 112)
        Me.btnEnterScores.Name = "btnEnterScores"
        Me.btnEnterScores.Size = New System.Drawing.Size(108, 21)
        Me.btnEnterScores.TabIndex = 2
        Me.btnEnterScores.Text = "Enter Scores"
        Me.btnEnterScores.UseVisualStyleBackColor = True
        '
        'btnAverageScore
        '
        Me.btnAverageScore.Location = New System.Drawing.Point(35, 148)
        Me.btnAverageScore.Name = "btnAverageScore"
        Me.btnAverageScore.Size = New System.Drawing.Size(108, 21)
        Me.btnAverageScore.TabIndex = 3
        Me.btnAverageScore.Text = "Average Score"
        Me.btnAverageScore.UseVisualStyleBackColor = True
        '
        'lblNumberOfScores
        '
        Me.lblNumberOfScores.AutoSize = True
        Me.lblNumberOfScores.Location = New System.Drawing.Point(242, 116)
        Me.lblNumberOfScores.Name = "lblNumberOfScores"
        Me.lblNumberOfScores.Size = New System.Drawing.Size(0, 13)
        Me.lblNumberOfScores.TabIndex = 4
        '
        'lblAverageMessage
        '
        Me.lblAverageMessage.AutoSize = True
        Me.lblAverageMessage.Location = New System.Drawing.Point(163, 152)
        Me.lblAverageMessage.Name = "lblAverageMessage"
        Me.lblAverageMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverageMessage.TabIndex = 5
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(242, 152)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverage.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 201)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblAverageMessage)
        Me.Controls.Add(Me.lblNumberOfScores)
        Me.Controls.Add(Me.btnAverageScore)
        Me.Controls.Add(Me.btnEnterScores)
        Me.Controls.Add(Me.lblScoresMessage)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "Form1"
        Me.Text = "Average Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblScoresMessage As System.Windows.Forms.Label
    Friend WithEvents btnEnterScores As System.Windows.Forms.Button
    Friend WithEvents btnAverageScore As System.Windows.Forms.Button
    Friend WithEvents lblNumberOfScores As System.Windows.Forms.Label
    Friend WithEvents lblAverageMessage As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class
