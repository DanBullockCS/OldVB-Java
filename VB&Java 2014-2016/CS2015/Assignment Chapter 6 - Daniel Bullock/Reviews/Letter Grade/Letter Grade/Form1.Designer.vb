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
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnLetterGrade = New System.Windows.Forms.Button()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.AutoSize = True
        Me.lblLetterGrade.Location = New System.Drawing.Point(23, 65)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(0, 13)
        Me.lblLetterGrade.TabIndex = 0
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 24)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(93, 13)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter a test score:"
        '
        'btnLetterGrade
        '
        Me.btnLetterGrade.Location = New System.Drawing.Point(155, 19)
        Me.btnLetterGrade.Name = "btnLetterGrade"
        Me.btnLetterGrade.Size = New System.Drawing.Size(86, 23)
        Me.btnLetterGrade.TabIndex = 2
        Me.btnLetterGrade.Text = "Letter Grade"
        Me.btnLetterGrade.UseVisualStyleBackColor = True
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(111, 21)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(31, 20)
        Me.txtScore.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 110)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.btnLetterGrade)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblLetterGrade)
        Me.Name = "Form1"
        Me.Text = "Letter Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLetterGrade As System.Windows.Forms.Label
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents btnLetterGrade As System.Windows.Forms.Button
    Friend WithEvents txtScore As System.Windows.Forms.TextBox

End Class
