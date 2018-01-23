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
        Me.txtColor1 = New System.Windows.Forms.TextBox()
        Me.lblEnterColors = New System.Windows.Forms.Label()
        Me.txtColor2 = New System.Windows.Forms.TextBox()
        Me.txtColor3 = New System.Windows.Forms.TextBox()
        Me.lblColorsCorrect = New System.Windows.Forms.Label()
        Me.lblPositionsCorrect = New System.Windows.Forms.Label()
        Me.btnCheckGuess = New System.Windows.Forms.Button()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtColor1
        '
        Me.txtColor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor1.Location = New System.Drawing.Point(175, 12)
        Me.txtColor1.Multiline = True
        Me.txtColor1.Name = "txtColor1"
        Me.txtColor1.Size = New System.Drawing.Size(34, 40)
        Me.txtColor1.TabIndex = 0
        '
        'lblEnterColors
        '
        Me.lblEnterColors.AutoSize = True
        Me.lblEnterColors.Location = New System.Drawing.Point(12, 25)
        Me.lblEnterColors.Name = "lblEnterColors"
        Me.lblEnterColors.Size = New System.Drawing.Size(66, 13)
        Me.lblEnterColors.TabIndex = 1
        Me.lblEnterColors.Text = "Enter colors:"
        '
        'txtColor2
        '
        Me.txtColor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor2.Location = New System.Drawing.Point(109, 12)
        Me.txtColor2.Multiline = True
        Me.txtColor2.Name = "txtColor2"
        Me.txtColor2.Size = New System.Drawing.Size(34, 40)
        Me.txtColor2.TabIndex = 2
        '
        'txtColor3
        '
        Me.txtColor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor3.Location = New System.Drawing.Point(238, 12)
        Me.txtColor3.Multiline = True
        Me.txtColor3.Name = "txtColor3"
        Me.txtColor3.Size = New System.Drawing.Size(34, 40)
        Me.txtColor3.TabIndex = 3
        '
        'lblColorsCorrect
        '
        Me.lblColorsCorrect.AutoSize = True
        Me.lblColorsCorrect.Location = New System.Drawing.Point(12, 96)
        Me.lblColorsCorrect.Name = "lblColorsCorrect"
        Me.lblColorsCorrect.Size = New System.Drawing.Size(82, 13)
        Me.lblColorsCorrect.TabIndex = 4
        Me.lblColorsCorrect.Text = "Colors Correct ="
        '
        'lblPositionsCorrect
        '
        Me.lblPositionsCorrect.AutoSize = True
        Me.lblPositionsCorrect.Location = New System.Drawing.Point(12, 131)
        Me.lblPositionsCorrect.Name = "lblPositionsCorrect"
        Me.lblPositionsCorrect.Size = New System.Drawing.Size(95, 13)
        Me.lblPositionsCorrect.TabIndex = 5
        Me.lblPositionsCorrect.Text = "Positions Correct ="
        '
        'btnCheckGuess
        '
        Me.btnCheckGuess.Location = New System.Drawing.Point(207, 131)
        Me.btnCheckGuess.Name = "btnCheckGuess"
        Me.btnCheckGuess.Size = New System.Drawing.Size(86, 21)
        Me.btnCheckGuess.TabIndex = 6
        Me.btnCheckGuess.Text = "Check Guess"
        Me.btnCheckGuess.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(106, 96)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(0, 13)
        Me.lblColor.TabIndex = 7
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(113, 131)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(0, 13)
        Me.lblPosition.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 168)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.btnCheckGuess)
        Me.Controls.Add(Me.lblPositionsCorrect)
        Me.Controls.Add(Me.lblColorsCorrect)
        Me.Controls.Add(Me.txtColor3)
        Me.Controls.Add(Me.txtColor2)
        Me.Controls.Add(Me.lblEnterColors)
        Me.Controls.Add(Me.txtColor1)
        Me.Name = "Form1"
        Me.Text = "Guess The Blocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtColor1 As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterColors As System.Windows.Forms.Label
    Friend WithEvents txtColor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtColor3 As System.Windows.Forms.TextBox
    Friend WithEvents lblColorsCorrect As System.Windows.Forms.Label
    Friend WithEvents lblPositionsCorrect As System.Windows.Forms.Label
    Friend WithEvents btnCheckGuess As System.Windows.Forms.Button
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label

End Class
