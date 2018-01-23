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
        Me.lblFirstWord = New System.Windows.Forms.Label()
        Me.btnCompareWords = New System.Windows.Forms.Button()
        Me.txtFirstWord = New System.Windows.Forms.TextBox()
        Me.txtSecondWord = New System.Windows.Forms.TextBox()
        Me.lblSecondWord = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirstWord
        '
        Me.lblFirstWord.AutoSize = True
        Me.lblFirstWord.Location = New System.Drawing.Point(21, 20)
        Me.lblFirstWord.Name = "lblFirstWord"
        Me.lblFirstWord.Size = New System.Drawing.Size(80, 13)
        Me.lblFirstWord.TabIndex = 0
        Me.lblFirstWord.Text = "Enter first word:"
        '
        'btnCompareWords
        '
        Me.btnCompareWords.Location = New System.Drawing.Point(118, 115)
        Me.btnCompareWords.Name = "btnCompareWords"
        Me.btnCompareWords.Size = New System.Drawing.Size(111, 22)
        Me.btnCompareWords.TabIndex = 1
        Me.btnCompareWords.Text = "Compare Words"
        Me.btnCompareWords.UseVisualStyleBackColor = True
        '
        'txtFirstWord
        '
        Me.txtFirstWord.Location = New System.Drawing.Point(134, 17)
        Me.txtFirstWord.Name = "txtFirstWord"
        Me.txtFirstWord.Size = New System.Drawing.Size(183, 20)
        Me.txtFirstWord.TabIndex = 2
        '
        'txtSecondWord
        '
        Me.txtSecondWord.Location = New System.Drawing.Point(134, 58)
        Me.txtSecondWord.Name = "txtSecondWord"
        Me.txtSecondWord.Size = New System.Drawing.Size(139, 20)
        Me.txtSecondWord.TabIndex = 3
        '
        'lblSecondWord
        '
        Me.lblSecondWord.AutoSize = True
        Me.lblSecondWord.Location = New System.Drawing.Point(21, 61)
        Me.lblSecondWord.Name = "lblSecondWord"
        Me.lblSecondWord.Size = New System.Drawing.Size(99, 13)
        Me.lblSecondWord.TabIndex = 4
        Me.lblSecondWord.Text = "Enter second word:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(21, 93)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 149)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblSecondWord)
        Me.Controls.Add(Me.txtSecondWord)
        Me.Controls.Add(Me.txtFirstWord)
        Me.Controls.Add(Me.btnCompareWords)
        Me.Controls.Add(Me.lblFirstWord)
        Me.Name = "Form1"
        Me.Text = "Compare Words"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstWord As System.Windows.Forms.Label
    Friend WithEvents btnCompareWords As System.Windows.Forms.Button
    Friend WithEvents txtFirstWord As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondWord As System.Windows.Forms.TextBox
    Friend WithEvents lblSecondWord As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
