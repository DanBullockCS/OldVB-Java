<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculations
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
        Me.btnExpression1 = New System.Windows.Forms.Button()
        Me.btnExpression2 = New System.Windows.Forms.Button()
        Me.btnExpression3 = New System.Windows.Forms.Button()
        Me.btnExpression4 = New System.Windows.Forms.Button()
        Me.lblExpression1 = New System.Windows.Forms.Label()
        Me.lblExpression2 = New System.Windows.Forms.Label()
        Me.lblExpression3 = New System.Windows.Forms.Label()
        Me.lblExpression4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExpression1
        '
        Me.btnExpression1.Location = New System.Drawing.Point(13, 12)
        Me.btnExpression1.Name = "btnExpression1"
        Me.btnExpression1.Size = New System.Drawing.Size(74, 26)
        Me.btnExpression1.TabIndex = 0
        Me.btnExpression1.Text = "5 + 2^3"
        Me.btnExpression1.UseVisualStyleBackColor = True
        '
        'btnExpression2
        '
        Me.btnExpression2.Location = New System.Drawing.Point(13, 44)
        Me.btnExpression2.Name = "btnExpression2"
        Me.btnExpression2.Size = New System.Drawing.Size(74, 26)
        Me.btnExpression2.TabIndex = 1
        Me.btnExpression2.Text = "4/2 + 5"
        Me.btnExpression2.UseVisualStyleBackColor = True
        '
        'btnExpression3
        '
        Me.btnExpression3.Location = New System.Drawing.Point(12, 76)
        Me.btnExpression3.Name = "btnExpression3"
        Me.btnExpression3.Size = New System.Drawing.Size(74, 26)
        Me.btnExpression3.TabIndex = 2
        Me.btnExpression3.Text = "3 + 4*2"
        Me.btnExpression3.UseVisualStyleBackColor = True
        '
        'btnExpression4
        '
        Me.btnExpression4.Location = New System.Drawing.Point(12, 108)
        Me.btnExpression4.Name = "btnExpression4"
        Me.btnExpression4.Size = New System.Drawing.Size(74, 26)
        Me.btnExpression4.TabIndex = 3
        Me.btnExpression4.Text = "7 - 3 + 2"
        Me.btnExpression4.UseVisualStyleBackColor = True
        '
        'lblExpression1
        '
        Me.lblExpression1.AutoSize = True
        Me.lblExpression1.Location = New System.Drawing.Point(106, 23)
        Me.lblExpression1.Name = "lblExpression1"
        Me.lblExpression1.Size = New System.Drawing.Size(0, 13)
        Me.lblExpression1.TabIndex = 4
        '
        'lblExpression2
        '
        Me.lblExpression2.AutoSize = True
        Me.lblExpression2.Location = New System.Drawing.Point(106, 57)
        Me.lblExpression2.Name = "lblExpression2"
        Me.lblExpression2.Size = New System.Drawing.Size(0, 13)
        Me.lblExpression2.TabIndex = 5
        '
        'lblExpression3
        '
        Me.lblExpression3.AutoSize = True
        Me.lblExpression3.Location = New System.Drawing.Point(106, 83)
        Me.lblExpression3.Name = "lblExpression3"
        Me.lblExpression3.Size = New System.Drawing.Size(0, 13)
        Me.lblExpression3.TabIndex = 6
        '
        'lblExpression4
        '
        Me.lblExpression4.AutoSize = True
        Me.lblExpression4.Location = New System.Drawing.Point(106, 108)
        Me.lblExpression4.Name = "lblExpression4"
        Me.lblExpression4.Size = New System.Drawing.Size(0, 13)
        Me.lblExpression4.TabIndex = 7
        '
        'Calculations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 144)
        Me.Controls.Add(Me.lblExpression4)
        Me.Controls.Add(Me.lblExpression3)
        Me.Controls.Add(Me.lblExpression2)
        Me.Controls.Add(Me.lblExpression1)
        Me.Controls.Add(Me.btnExpression4)
        Me.Controls.Add(Me.btnExpression3)
        Me.Controls.Add(Me.btnExpression2)
        Me.Controls.Add(Me.btnExpression1)
        Me.Name = "Calculations"
        Me.Text = "Calculations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExpression1 As System.Windows.Forms.Button
    Friend WithEvents btnExpression2 As System.Windows.Forms.Button
    Friend WithEvents btnExpression3 As System.Windows.Forms.Button
    Friend WithEvents btnExpression4 As System.Windows.Forms.Button
    Friend WithEvents lblExpression1 As System.Windows.Forms.Label
    Friend WithEvents lblExpression2 As System.Windows.Forms.Label
    Friend WithEvents lblExpression3 As System.Windows.Forms.Label
    Friend WithEvents lblExpression4 As System.Windows.Forms.Label

End Class
