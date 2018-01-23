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
        Me.lblIntegerPrompt = New System.Windows.Forms.Label()
        Me.txtInteger = New System.Windows.Forms.TextBox()
        Me.lblPrimeResult = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIntegerPrompt
        '
        Me.lblIntegerPrompt.AutoSize = True
        Me.lblIntegerPrompt.Location = New System.Drawing.Point(24, 22)
        Me.lblIntegerPrompt.Name = "lblIntegerPrompt"
        Me.lblIntegerPrompt.Size = New System.Drawing.Size(85, 13)
        Me.lblIntegerPrompt.TabIndex = 0
        Me.lblIntegerPrompt.Text = "Enter an integer:"
        '
        'txtInteger
        '
        Me.txtInteger.Location = New System.Drawing.Point(115, 19)
        Me.txtInteger.Name = "txtInteger"
        Me.txtInteger.Size = New System.Drawing.Size(31, 20)
        Me.txtInteger.TabIndex = 1
        '
        'lblPrimeResult
        '
        Me.lblPrimeResult.AutoSize = True
        Me.lblPrimeResult.Location = New System.Drawing.Point(163, 22)
        Me.lblPrimeResult.Name = "lblPrimeResult"
        Me.lblPrimeResult.Size = New System.Drawing.Size(0, 13)
        Me.lblPrimeResult.TabIndex = 2
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(27, 53)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(62, 22)
        Me.btnTest.TabIndex = 3
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 97)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lblPrimeResult)
        Me.Controls.Add(Me.txtInteger)
        Me.Controls.Add(Me.lblIntegerPrompt)
        Me.Name = "Form1"
        Me.Text = "Prime Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntegerPrompt As System.Windows.Forms.Label
    Friend WithEvents txtInteger As System.Windows.Forms.TextBox
    Friend WithEvents lblPrimeResult As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button

End Class
