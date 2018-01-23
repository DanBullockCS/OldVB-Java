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
        Me.btnGenerateOddNumbersSum = New System.Windows.Forms.Button()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblOddNumbersSum = New System.Windows.Forms.Label()
        Me.txtboxMaxNum = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerateOddNumbersSum
        '
        Me.btnGenerateOddNumbersSum.Location = New System.Drawing.Point(52, 83)
        Me.btnGenerateOddNumbersSum.Name = "btnGenerateOddNumbersSum"
        Me.btnGenerateOddNumbersSum.Size = New System.Drawing.Size(159, 27)
        Me.btnGenerateOddNumbersSum.TabIndex = 0
        Me.btnGenerateOddNumbersSum.Text = "Generate Odd Numbers Sum"
        Me.btnGenerateOddNumbersSum.UseVisualStyleBackColor = True
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Location = New System.Drawing.Point(12, 56)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(105, 13)
        Me.lblStatement.TabIndex = 1
        Me.lblStatement.Text = "Odd numbers sum is:"
        '
        'lblOddNumbersSum
        '
        Me.lblOddNumbersSum.AutoSize = True
        Me.lblOddNumbersSum.Location = New System.Drawing.Point(114, 56)
        Me.lblOddNumbersSum.Name = "lblOddNumbersSum"
        Me.lblOddNumbersSum.Size = New System.Drawing.Size(0, 13)
        Me.lblOddNumbersSum.TabIndex = 2
        '
        'txtboxMaxNum
        '
        Me.txtboxMaxNum.Location = New System.Drawing.Point(140, 18)
        Me.txtboxMaxNum.Name = "txtboxMaxNum"
        Me.txtboxMaxNum.Size = New System.Drawing.Size(51, 20)
        Me.txtboxMaxNum.TabIndex = 3
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(12, 21)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(113, 13)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "Enter the max number:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 122)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtboxMaxNum)
        Me.Controls.Add(Me.lblOddNumbersSum)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.btnGenerateOddNumbersSum)
        Me.Name = "Form1"
        Me.Text = "Odd Numbers Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerateOddNumbersSum As System.Windows.Forms.Button
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents lblOddNumbersSum As System.Windows.Forms.Label
    Friend WithEvents txtboxMaxNum As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
