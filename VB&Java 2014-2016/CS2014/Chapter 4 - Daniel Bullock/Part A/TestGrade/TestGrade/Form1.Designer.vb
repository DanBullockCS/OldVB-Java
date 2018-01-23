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
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.lblTestScore = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtboxGrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(107, 89)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(82, 21)
        Me.btnGrade.TabIndex = 0
        Me.btnGrade.Text = "Check Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'lblTestScore
        '
        Me.lblTestScore.AutoSize = True
        Me.lblTestScore.Location = New System.Drawing.Point(61, 22)
        Me.lblTestScore.Name = "lblTestScore"
        Me.lblTestScore.Size = New System.Drawing.Size(93, 13)
        Me.lblTestScore.TabIndex = 1
        Me.lblTestScore.Text = "Enter a test score:"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(124, 59)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(0, 13)
        Me.lblComment.TabIndex = 2
        '
        'txtboxGrade
        '
        Me.txtboxGrade.Location = New System.Drawing.Point(169, 19)
        Me.txtboxGrade.Name = "txtboxGrade"
        Me.txtboxGrade.Size = New System.Drawing.Size(41, 20)
        Me.txtboxGrade.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 131)
        Me.Controls.Add(Me.txtboxGrade)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblTestScore)
        Me.Controls.Add(Me.btnGrade)
        Me.Name = "Form1"
        Me.Text = "Test Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGrade As System.Windows.Forms.Button
    Friend WithEvents lblTestScore As System.Windows.Forms.Label
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents txtboxGrade As System.Windows.Forms.TextBox

End Class
