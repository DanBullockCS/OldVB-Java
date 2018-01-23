<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.lblBackToMenu = New System.Windows.Forms.Label()
        Me.lblBalloonTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstScores
        '
        Me.lstScores.BackColor = System.Drawing.SystemColors.Desktop
        Me.lstScores.Font = New System.Drawing.Font("Kristen ITC", 12.0!)
        Me.lstScores.ForeColor = System.Drawing.Color.Orange
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 23
        Me.lstScores.Location = New System.Drawing.Point(262, 77)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(267, 326)
        Me.lstScores.TabIndex = 0
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.Font = New System.Drawing.Font("Kristen ITC", 14.25!)
        Me.lblBackToMenu.ForeColor = System.Drawing.Color.Yellow
        Me.lblBackToMenu.Location = New System.Drawing.Point(644, 464)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(144, 27)
        Me.lblBackToMenu.TabIndex = 5
        Me.lblBackToMenu.Text = "Back to Menu"
        '
        'lblBalloonTitle
        '
        Me.lblBalloonTitle.AutoSize = True
        Me.lblBalloonTitle.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Underline)
        Me.lblBalloonTitle.ForeColor = System.Drawing.Color.Cyan
        Me.lblBalloonTitle.Location = New System.Drawing.Point(301, 47)
        Me.lblBalloonTitle.Name = "lblBalloonTitle"
        Me.lblBalloonTitle.Size = New System.Drawing.Size(191, 27)
        Me.lblBalloonTitle.TabIndex = 6
        Me.lblBalloonTitle.Text = "Balloon Pop Scores"
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblBalloonTitle)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.Controls.Add(Me.lstScores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Scores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstScores As System.Windows.Forms.ListBox
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents lblBalloonTitle As System.Windows.Forms.Label
End Class
