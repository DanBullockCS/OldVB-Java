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
        Me.btnGenerateNumbers = New System.Windows.Forms.Button()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.lblNumberOfLoops = New System.Windows.Forms.Label()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerateNumbers
        '
        Me.btnGenerateNumbers.Location = New System.Drawing.Point(47, 131)
        Me.btnGenerateNumbers.Name = "btnGenerateNumbers"
        Me.btnGenerateNumbers.Size = New System.Drawing.Size(117, 23)
        Me.btnGenerateNumbers.TabIndex = 0
        Me.btnGenerateNumbers.Text = "Generate Numbers"
        Me.btnGenerateNumbers.UseVisualStyleBackColor = True
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(51, 26)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(0, 25)
        Me.lblNum1.TabIndex = 1
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(107, 26)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(0, 25)
        Me.lblNum2.TabIndex = 2
        '
        'lblNum3
        '
        Me.lblNum3.AutoSize = True
        Me.lblNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.Location = New System.Drawing.Point(165, 26)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(0, 25)
        Me.lblNum3.TabIndex = 3
        '
        'lblNumberOfLoops
        '
        Me.lblNumberOfLoops.AutoSize = True
        Me.lblNumberOfLoops.Location = New System.Drawing.Point(32, 87)
        Me.lblNumberOfLoops.Name = "lblNumberOfLoops"
        Me.lblNumberOfLoops.Size = New System.Drawing.Size(0, 13)
        Me.lblNumberOfLoops.TabIndex = 4
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Location = New System.Drawing.Point(53, 87)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(157, 26)
        Me.lblStatement.TabIndex = 5
        Me.lblStatement.Text = "loop iterations were needed to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "generate three unique numbers."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 180)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.lblNumberOfLoops)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.btnGenerateNumbers)
        Me.Name = "Form1"
        Me.Text = "Unique Random Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerateNumbers As System.Windows.Forms.Button
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblNum3 As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfLoops As System.Windows.Forms.Label
    Friend WithEvents lblStatement As System.Windows.Forms.Label

End Class
