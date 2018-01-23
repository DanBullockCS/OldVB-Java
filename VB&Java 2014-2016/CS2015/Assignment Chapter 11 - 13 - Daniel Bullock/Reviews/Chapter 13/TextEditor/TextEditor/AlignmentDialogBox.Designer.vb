<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlignmentDialogBox
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
        Me.grpAlignment = New System.Windows.Forms.GroupBox()
        Me.radRight = New System.Windows.Forms.RadioButton()
        Me.radCenter = New System.Windows.Forms.RadioButton()
        Me.radLeft = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpAlignment.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAlignment
        '
        Me.grpAlignment.Controls.Add(Me.radRight)
        Me.grpAlignment.Controls.Add(Me.radCenter)
        Me.grpAlignment.Controls.Add(Me.radLeft)
        Me.grpAlignment.Location = New System.Drawing.Point(27, 12)
        Me.grpAlignment.Name = "grpAlignment"
        Me.grpAlignment.Size = New System.Drawing.Size(188, 49)
        Me.grpAlignment.TabIndex = 0
        Me.grpAlignment.TabStop = False
        Me.grpAlignment.Text = "Choose Alignment"
        '
        'radRight
        '
        Me.radRight.AutoSize = True
        Me.radRight.Location = New System.Drawing.Point(126, 19)
        Me.radRight.Name = "radRight"
        Me.radRight.Size = New System.Drawing.Size(50, 17)
        Me.radRight.TabIndex = 2
        Me.radRight.TabStop = True
        Me.radRight.Text = "Right"
        Me.radRight.UseVisualStyleBackColor = True
        '
        'radCenter
        '
        Me.radCenter.AutoSize = True
        Me.radCenter.Location = New System.Drawing.Point(64, 19)
        Me.radCenter.Name = "radCenter"
        Me.radCenter.Size = New System.Drawing.Size(56, 17)
        Me.radCenter.TabIndex = 1
        Me.radCenter.TabStop = True
        Me.radCenter.Text = "Center"
        Me.radCenter.UseVisualStyleBackColor = True
        '
        'radLeft
        '
        Me.radLeft.AutoSize = True
        Me.radLeft.Location = New System.Drawing.Point(15, 19)
        Me.radLeft.Name = "radLeft"
        Me.radLeft.Size = New System.Drawing.Size(43, 17)
        Me.radLeft.TabIndex = 0
        Me.radLeft.TabStop = True
        Me.radLeft.Text = "Left"
        Me.radLeft.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(27, 67)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(132, 67)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AlignmentDialogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpAlignment)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AlignmentDialogBox"
        Me.Text = "Alignment"
        Me.grpAlignment.ResumeLayout(False)
        Me.grpAlignment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAlignment As System.Windows.Forms.GroupBox
    Friend WithEvents radRight As System.Windows.Forms.RadioButton
    Friend WithEvents radCenter As System.Windows.Forms.RadioButton
    Friend WithEvents radLeft As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
