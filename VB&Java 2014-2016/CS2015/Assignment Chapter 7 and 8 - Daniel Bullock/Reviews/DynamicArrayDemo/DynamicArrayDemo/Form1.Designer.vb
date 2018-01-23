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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFind = New System.Windows.Forms.RadioButton()
        Me.radRemove = New System.Windows.Forms.RadioButton()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(12, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(114, 173)
        Me.lstOutput.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFind)
        Me.GroupBox1.Controls.Add(Me.radRemove)
        Me.GroupBox1.Controls.Add(Me.radAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 59)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'radFind
        '
        Me.radFind.AutoSize = True
        Me.radFind.Location = New System.Drawing.Point(122, 19)
        Me.radFind.Name = "radFind"
        Me.radFind.Size = New System.Drawing.Size(45, 17)
        Me.radFind.TabIndex = 2
        Me.radFind.TabStop = True
        Me.radFind.Text = "Find"
        Me.radFind.UseVisualStyleBackColor = True
        '
        'radRemove
        '
        Me.radRemove.AutoSize = True
        Me.radRemove.Location = New System.Drawing.Point(51, 19)
        Me.radRemove.Name = "radRemove"
        Me.radRemove.Size = New System.Drawing.Size(65, 17)
        Me.radRemove.TabIndex = 1
        Me.radRemove.TabStop = True
        Me.radRemove.Text = "Remove"
        Me.radRemove.UseVisualStyleBackColor = True
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(6, 19)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(44, 17)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "Add"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(203, 23)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(39, 20)
        Me.txtValue.TabIndex = 2
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(158, 26)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(37, 13)
        Me.lblValue.TabIndex = 3
        Me.lblValue.Text = "Value:"
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(266, 177)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(72, 23)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 212)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "Form1"
        Me.Text = "Dynamic Array Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radFind As System.Windows.Forms.RadioButton
    Friend WithEvents radRemove As System.Windows.Forms.RadioButton
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button

End Class
