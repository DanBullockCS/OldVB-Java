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
        Me.components = New System.ComponentModel.Container()
        Me.lblMyNameIs = New System.Windows.Forms.Label()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.grpboxlanguage = New System.Windows.Forms.GroupBox()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radSpanish = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.ToolTipSpanish = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipEnglish = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipFrench = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpboxlanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMyNameIs
        '
        Me.lblMyNameIs.AutoSize = True
        Me.lblMyNameIs.Location = New System.Drawing.Point(25, 23)
        Me.lblMyNameIs.Name = "lblMyNameIs"
        Me.lblMyNameIs.Size = New System.Drawing.Size(63, 13)
        Me.lblMyNameIs.TabIndex = 0
        Me.lblMyNameIs.Text = "My name is:"
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(103, 20)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(102, 20)
        Me.txtboxName.TabIndex = 1
        '
        'grpboxlanguage
        '
        Me.grpboxlanguage.Controls.Add(Me.radEnglish)
        Me.grpboxlanguage.Controls.Add(Me.radSpanish)
        Me.grpboxlanguage.Controls.Add(Me.radFrench)
        Me.grpboxlanguage.Location = New System.Drawing.Point(28, 65)
        Me.grpboxlanguage.Name = "grpboxlanguage"
        Me.grpboxlanguage.Size = New System.Drawing.Size(246, 49)
        Me.grpboxlanguage.TabIndex = 2
        Me.grpboxlanguage.TabStop = False
        Me.grpboxlanguage.Text = "Select Language"
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(16, 19)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 5
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.ToolTipEnglish.SetToolTip(Me.radEnglish, "Displays the prompt in English.")
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radSpanish
        '
        Me.radSpanish.AutoSize = True
        Me.radSpanish.Location = New System.Drawing.Point(93, 19)
        Me.radSpanish.Name = "radSpanish"
        Me.radSpanish.Size = New System.Drawing.Size(63, 17)
        Me.radSpanish.TabIndex = 4
        Me.radSpanish.TabStop = True
        Me.radSpanish.Text = "Spanish"
        Me.ToolTipSpanish.SetToolTip(Me.radSpanish, "Displays the prompt in Spanish.")
        Me.radSpanish.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(174, 19)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 3
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.ToolTipFrench.SetToolTip(Me.radFrench, "Displays the prompt in French.")
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 127)
        Me.Controls.Add(Me.grpboxlanguage)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.lblMyNameIs)
        Me.Name = "Form1"
        Me.Text = "My Name International"
        Me.grpboxlanguage.ResumeLayout(False)
        Me.grpboxlanguage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMyNameIs As System.Windows.Forms.Label
    Friend WithEvents txtboxName As System.Windows.Forms.TextBox
    Friend WithEvents grpboxlanguage As System.Windows.Forms.GroupBox
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents radSpanish As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTipSpanish As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipEnglish As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipFrench As System.Windows.Forms.ToolTip

End Class
