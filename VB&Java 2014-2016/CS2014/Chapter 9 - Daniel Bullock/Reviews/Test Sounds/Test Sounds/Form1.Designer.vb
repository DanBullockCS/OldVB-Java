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
        Me.btnAsterisk = New System.Windows.Forms.Button()
        Me.btnBeep = New System.Windows.Forms.Button()
        Me.btnExclamation = New System.Windows.Forms.Button()
        Me.btnHand = New System.Windows.Forms.Button()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAsterisk
        '
        Me.btnAsterisk.BackColor = System.Drawing.Color.White
        Me.btnAsterisk.Location = New System.Drawing.Point(30, 12)
        Me.btnAsterisk.Name = "btnAsterisk"
        Me.btnAsterisk.Size = New System.Drawing.Size(75, 23)
        Me.btnAsterisk.TabIndex = 0
        Me.btnAsterisk.Text = "Asterisk"
        Me.btnAsterisk.UseVisualStyleBackColor = False
        '
        'btnBeep
        '
        Me.btnBeep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBeep.Location = New System.Drawing.Point(128, 12)
        Me.btnBeep.Name = "btnBeep"
        Me.btnBeep.Size = New System.Drawing.Size(75, 23)
        Me.btnBeep.TabIndex = 1
        Me.btnBeep.Text = "Beep"
        Me.btnBeep.UseVisualStyleBackColor = False
        '
        'btnExclamation
        '
        Me.btnExclamation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExclamation.Location = New System.Drawing.Point(227, 12)
        Me.btnExclamation.Name = "btnExclamation"
        Me.btnExclamation.Size = New System.Drawing.Size(75, 23)
        Me.btnExclamation.TabIndex = 2
        Me.btnExclamation.Text = "Exclamation"
        Me.btnExclamation.UseVisualStyleBackColor = False
        '
        'btnHand
        '
        Me.btnHand.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHand.Location = New System.Drawing.Point(76, 47)
        Me.btnHand.Name = "btnHand"
        Me.btnHand.Size = New System.Drawing.Size(75, 23)
        Me.btnHand.TabIndex = 3
        Me.btnHand.Text = "Hand"
        Me.btnHand.UseVisualStyleBackColor = False
        '
        'btnQuestion
        '
        Me.btnQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnQuestion.Location = New System.Drawing.Point(172, 47)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.Size = New System.Drawing.Size(75, 23)
        Me.btnQuestion.TabIndex = 4
        Me.btnQuestion.Text = "Question"
        Me.btnQuestion.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 82)
        Me.Controls.Add(Me.btnQuestion)
        Me.Controls.Add(Me.btnHand)
        Me.Controls.Add(Me.btnExclamation)
        Me.Controls.Add(Me.btnBeep)
        Me.Controls.Add(Me.btnAsterisk)
        Me.Name = "Form1"
        Me.Text = "Test Sounds"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAsterisk As System.Windows.Forms.Button
    Friend WithEvents btnBeep As System.Windows.Forms.Button
    Friend WithEvents btnExclamation As System.Windows.Forms.Button
    Friend WithEvents btnHand As System.Windows.Forms.Button
    Friend WithEvents btnQuestion As System.Windows.Forms.Button

End Class
