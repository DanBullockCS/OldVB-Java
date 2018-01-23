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
        Me.NumUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.lblMultiply = New System.Windows.Forms.Label()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        CType(Me.NumUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumUpDown1
        '
        Me.NumUpDown1.Location = New System.Drawing.Point(12, 26)
        Me.NumUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumUpDown1.Name = "NumUpDown1"
        Me.NumUpDown1.Size = New System.Drawing.Size(44, 20)
        Me.NumUpDown1.TabIndex = 0
        '
        'NumUpDown2
        '
        Me.NumUpDown2.Location = New System.Drawing.Point(82, 26)
        Me.NumUpDown2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumUpDown2.Name = "NumUpDown2"
        Me.NumUpDown2.Size = New System.Drawing.Size(44, 20)
        Me.NumUpDown2.TabIndex = 2
        '
        'lblMultiply
        '
        Me.lblMultiply.AutoSize = True
        Me.lblMultiply.Location = New System.Drawing.Point(62, 28)
        Me.lblMultiply.Name = "lblMultiply"
        Me.lblMultiply.Size = New System.Drawing.Size(14, 13)
        Me.lblMultiply.TabIndex = 3
        Me.lblMultiply.Text = "X"
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(141, 24)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(28, 21)
        Me.btnEquals.TabIndex = 4
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(186, 28)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 69)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.lblMultiply)
        Me.Controls.Add(Me.NumUpDown2)
        Me.Controls.Add(Me.NumUpDown1)
        Me.Name = "Form1"
        Me.Text = "Basic Multiplication"
        CType(Me.NumUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMultiply As System.Windows.Forms.Label
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
