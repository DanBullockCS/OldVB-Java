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
        Me.btnNewProblem = New System.Windows.Forms.Button()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.txtYourAnswer = New System.Windows.Forms.TextBox()
        Me.lblProblem = New System.Windows.Forms.Label()
        Me.lblCheckAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNewProblem
        '
        Me.btnNewProblem.Location = New System.Drawing.Point(195, 21)
        Me.btnNewProblem.Name = "btnNewProblem"
        Me.btnNewProblem.Size = New System.Drawing.Size(89, 24)
        Me.btnNewProblem.TabIndex = 0
        Me.btnNewProblem.Text = "New Problem"
        Me.btnNewProblem.UseVisualStyleBackColor = True
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.Location = New System.Drawing.Point(195, 67)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(89, 24)
        Me.btnCheckAnswer.TabIndex = 1
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(195, 113)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(89, 24)
        Me.btnShowAnswer.TabIndex = 2
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'txtYourAnswer
        '
        Me.txtYourAnswer.Location = New System.Drawing.Point(126, 42)
        Me.txtYourAnswer.Name = "txtYourAnswer"
        Me.txtYourAnswer.Size = New System.Drawing.Size(39, 20)
        Me.txtYourAnswer.TabIndex = 3
        '
        'lblProblem
        '
        Me.lblProblem.AutoSize = True
        Me.lblProblem.Location = New System.Drawing.Point(12, 45)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(0, 13)
        Me.lblProblem.TabIndex = 4
        '
        'lblCheckAnswer
        '
        Me.lblCheckAnswer.AutoSize = True
        Me.lblCheckAnswer.Location = New System.Drawing.Point(12, 113)
        Me.lblCheckAnswer.Name = "lblCheckAnswer"
        Me.lblCheckAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblCheckAnswer.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 149)
        Me.Controls.Add(Me.lblCheckAnswer)
        Me.Controls.Add(Me.lblProblem)
        Me.Controls.Add(Me.txtYourAnswer)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.btnNewProblem)
        Me.Name = "Form1"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewProblem As System.Windows.Forms.Button
    Friend WithEvents btnCheckAnswer As System.Windows.Forms.Button
    Friend WithEvents btnShowAnswer As System.Windows.Forms.Button
    Friend WithEvents txtYourAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblProblem As System.Windows.Forms.Label
    Friend WithEvents lblCheckAnswer As System.Windows.Forms.Label

End Class
