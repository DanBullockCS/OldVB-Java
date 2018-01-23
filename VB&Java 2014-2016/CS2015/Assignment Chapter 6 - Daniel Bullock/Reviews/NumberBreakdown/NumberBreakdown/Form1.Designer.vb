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
        Me.btnBreakdown = New System.Windows.Forms.Button()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBreakdown
        '
        Me.btnBreakdown.Location = New System.Drawing.Point(97, 130)
        Me.btnBreakdown.Name = "btnBreakdown"
        Me.btnBreakdown.Size = New System.Drawing.Size(81, 25)
        Me.btnBreakdown.TabIndex = 0
        Me.btnBreakdown.Text = "Breakdown"
        Me.btnBreakdown.UseVisualStyleBackColor = True
        '
        'lblDigits
        '
        Me.lblDigits.AutoSize = True
        Me.lblDigits.Location = New System.Drawing.Point(21, 52)
        Me.lblDigits.Name = "lblDigits"
        Me.lblDigits.Size = New System.Drawing.Size(0, 13)
        Me.lblDigits.TabIndex = 1
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(21, 20)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(157, 13)
        Me.lblPrompt.TabIndex = 2
        Me.lblPrompt.Text = "Enter a number less than 1 000:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(208, 17)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(51, 20)
        Me.txtNumber.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 179)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblDigits)
        Me.Controls.Add(Me.btnBreakdown)
        Me.Name = "Form1"
        Me.Text = "Number Breakdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBreakdown As System.Windows.Forms.Button
    Friend WithEvents lblDigits As System.Windows.Forms.Label
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox

End Class
