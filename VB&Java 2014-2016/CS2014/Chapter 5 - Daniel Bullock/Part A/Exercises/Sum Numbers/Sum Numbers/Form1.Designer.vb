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
        Me.lblStart = New System.Windows.Forms.Label()
        Me.btnCalculateSum = New System.Windows.Forms.Button()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(44, 31)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(110, 13)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Enter starting number:"
        '
        'btnCalculateSum
        '
        Me.btnCalculateSum.Location = New System.Drawing.Point(141, 154)
        Me.btnCalculateSum.Name = "btnCalculateSum"
        Me.btnCalculateSum.Size = New System.Drawing.Size(89, 23)
        Me.btnCalculateSum.TabIndex = 1
        Me.btnCalculateSum.Text = "Calculate Sum"
        Me.btnCalculateSum.UseVisualStyleBackColor = True
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(160, 28)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(70, 20)
        Me.txtStart.TabIndex = 2
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(44, 67)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(108, 13)
        Me.lblEnd.TabIndex = 3
        Me.lblEnd.Text = "Enter ending number:"
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(160, 64)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(70, 20)
        Me.txtEnd.TabIndex = 4
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(75, 121)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 13)
        Me.lblSum.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 189)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.btnCalculateSum)
        Me.Controls.Add(Me.lblStart)
        Me.Name = "Form1"
        Me.Text = "Sum Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents btnCalculateSum As System.Windows.Forms.Button
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents lblSum As System.Windows.Forms.Label

End Class
