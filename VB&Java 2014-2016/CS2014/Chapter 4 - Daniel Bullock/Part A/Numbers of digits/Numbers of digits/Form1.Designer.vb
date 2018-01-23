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
        Me.btnCheckNumber = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtboxNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCheckNumber
        '
        Me.btnCheckNumber.Location = New System.Drawing.Point(133, 90)
        Me.btnCheckNumber.Name = "btnCheckNumber"
        Me.btnCheckNumber.Size = New System.Drawing.Size(118, 23)
        Me.btnCheckNumber.TabIndex = 0
        Me.btnCheckNumber.Text = "Check Number"
        Me.btnCheckNumber.UseVisualStyleBackColor = True
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(37, 15)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(148, 13)
        Me.lblNumber.TabIndex = 1
        Me.lblNumber.Text = "Enter a number less than 100:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(37, 63)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 2
        '
        'txtboxNumber
        '
        Me.txtboxNumber.Location = New System.Drawing.Point(191, 12)
        Me.txtboxNumber.Name = "txtboxNumber"
        Me.txtboxNumber.Size = New System.Drawing.Size(50, 20)
        Me.txtboxNumber.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 136)
        Me.Controls.Add(Me.txtboxNumber)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.btnCheckNumber)
        Me.Name = "Form1"
        Me.Text = "Number of Digits"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCheckNumber As System.Windows.Forms.Button
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents txtboxNumber As System.Windows.Forms.TextBox

End Class
