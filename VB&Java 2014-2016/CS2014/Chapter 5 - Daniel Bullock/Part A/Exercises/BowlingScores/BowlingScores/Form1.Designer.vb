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
        Me.lblAnswer1 = New System.Windows.Forms.Label()
        Me.btnEnterScores = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.lblAnswer2 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAnswer1
        '
        Me.lblAnswer1.AutoSize = True
        Me.lblAnswer1.Location = New System.Drawing.Point(35, 32)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer1.TabIndex = 0
        '
        'btnEnterScores
        '
        Me.btnEnterScores.Location = New System.Drawing.Point(35, 91)
        Me.btnEnterScores.Name = "btnEnterScores"
        Me.btnEnterScores.Size = New System.Drawing.Size(115, 23)
        Me.btnEnterScores.TabIndex = 1
        Me.btnEnterScores.Text = "Enter Score"
        Me.btnEnterScores.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(184, 91)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(112, 23)
        Me.btnStats.TabIndex = 2
        Me.btnStats.Text = "Statistics"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'lblAnswer2
        '
        Me.lblAnswer2.AutoSize = True
        Me.lblAnswer2.Location = New System.Drawing.Point(163, 32)
        Me.lblAnswer2.Name = "lblAnswer2"
        Me.lblAnswer2.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer2.TabIndex = 3
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(35, 64)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverage.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 135)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblAnswer2)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnEnterScores)
        Me.Controls.Add(Me.lblAnswer1)
        Me.Name = "Form1"
        Me.Text = "Bowling Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnswer1 As System.Windows.Forms.Label
    Friend WithEvents btnEnterScores As System.Windows.Forms.Button
    Friend WithEvents btnStats As System.Windows.Forms.Button
    Friend WithEvents lblAnswer2 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class
