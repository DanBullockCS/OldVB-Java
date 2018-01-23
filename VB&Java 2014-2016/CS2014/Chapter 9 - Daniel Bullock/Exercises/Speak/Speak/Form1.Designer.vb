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
        Me.btnCat = New System.Windows.Forms.Button()
        Me.btnDog = New System.Windows.Forms.Button()
        Me.btnFluffy = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnSee = New System.Windows.Forms.Button()
        Me.btnThe = New System.Windows.Forms.Button()
        Me.btnIs = New System.Windows.Forms.Button()
        Me.btnWalk = New System.Windows.Forms.Button()
        Me.btnSpeak = New System.Windows.Forms.Button()
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCat
        '
        Me.btnCat.Location = New System.Drawing.Point(12, 12)
        Me.btnCat.Name = "btnCat"
        Me.btnCat.Size = New System.Drawing.Size(62, 23)
        Me.btnCat.TabIndex = 0
        Me.btnCat.Text = "cat"
        Me.btnCat.UseVisualStyleBackColor = True
        '
        'btnDog
        '
        Me.btnDog.Location = New System.Drawing.Point(80, 12)
        Me.btnDog.Name = "btnDog"
        Me.btnDog.Size = New System.Drawing.Size(62, 23)
        Me.btnDog.TabIndex = 1
        Me.btnDog.Text = "dog"
        Me.btnDog.UseVisualStyleBackColor = True
        '
        'btnFluffy
        '
        Me.btnFluffy.Location = New System.Drawing.Point(148, 12)
        Me.btnFluffy.Name = "btnFluffy"
        Me.btnFluffy.Size = New System.Drawing.Size(62, 23)
        Me.btnFluffy.TabIndex = 2
        Me.btnFluffy.Text = "fluffy"
        Me.btnFluffy.UseVisualStyleBackColor = True
        '
        'btnI
        '
        Me.btnI.Location = New System.Drawing.Point(216, 12)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(62, 23)
        Me.btnI.TabIndex = 3
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'btnSee
        '
        Me.btnSee.Location = New System.Drawing.Point(12, 41)
        Me.btnSee.Name = "btnSee"
        Me.btnSee.Size = New System.Drawing.Size(62, 23)
        Me.btnSee.TabIndex = 4
        Me.btnSee.Text = "see"
        Me.btnSee.UseVisualStyleBackColor = True
        '
        'btnThe
        '
        Me.btnThe.Location = New System.Drawing.Point(80, 41)
        Me.btnThe.Name = "btnThe"
        Me.btnThe.Size = New System.Drawing.Size(62, 23)
        Me.btnThe.TabIndex = 5
        Me.btnThe.Text = "the"
        Me.btnThe.UseVisualStyleBackColor = True
        '
        'btnIs
        '
        Me.btnIs.Location = New System.Drawing.Point(148, 41)
        Me.btnIs.Name = "btnIs"
        Me.btnIs.Size = New System.Drawing.Size(62, 23)
        Me.btnIs.TabIndex = 6
        Me.btnIs.Text = "is"
        Me.btnIs.UseVisualStyleBackColor = True
        '
        'btnWalk
        '
        Me.btnWalk.Location = New System.Drawing.Point(216, 41)
        Me.btnWalk.Name = "btnWalk"
        Me.btnWalk.Size = New System.Drawing.Size(62, 23)
        Me.btnWalk.TabIndex = 7
        Me.btnWalk.Text = "walk"
        Me.btnWalk.UseVisualStyleBackColor = True
        '
        'btnSpeak
        '
        Me.btnSpeak.Location = New System.Drawing.Point(111, 112)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(62, 23)
        Me.btnSpeak.TabIndex = 8
        Me.btnSpeak.Text = "Speak"
        Me.btnSpeak.UseVisualStyleBackColor = True
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(12, 91)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(0, 13)
        Me.lblSentence.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 147)
        Me.Controls.Add(Me.lblSentence)
        Me.Controls.Add(Me.btnSpeak)
        Me.Controls.Add(Me.btnWalk)
        Me.Controls.Add(Me.btnIs)
        Me.Controls.Add(Me.btnThe)
        Me.Controls.Add(Me.btnSee)
        Me.Controls.Add(Me.btnI)
        Me.Controls.Add(Me.btnFluffy)
        Me.Controls.Add(Me.btnDog)
        Me.Controls.Add(Me.btnCat)
        Me.Name = "Form1"
        Me.Text = "Speak"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCat As System.Windows.Forms.Button
    Friend WithEvents btnDog As System.Windows.Forms.Button
    Friend WithEvents btnFluffy As System.Windows.Forms.Button
    Friend WithEvents btnI As System.Windows.Forms.Button
    Friend WithEvents btnSee As System.Windows.Forms.Button
    Friend WithEvents btnThe As System.Windows.Forms.Button
    Friend WithEvents btnIs As System.Windows.Forms.Button
    Friend WithEvents btnWalk As System.Windows.Forms.Button
    Friend WithEvents btnSpeak As System.Windows.Forms.Button
    Friend WithEvents lblSentence As System.Windows.Forms.Label

End Class
