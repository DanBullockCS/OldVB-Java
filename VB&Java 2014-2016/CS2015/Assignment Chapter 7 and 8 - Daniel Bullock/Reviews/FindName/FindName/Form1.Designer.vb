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
        Me.lblNames = New System.Windows.Forms.Label()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFind = New System.Windows.Forms.RadioButton()
        Me.radRemove = New System.Windows.Forms.RadioButton()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(12, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(122, 186)
        Me.lstOutput.TabIndex = 0
        '
        'lblNames
        '
        Me.lblNames.AutoSize = True
        Me.lblNames.Location = New System.Drawing.Point(154, 12)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(38, 13)
        Me.lblNames.TabIndex = 1
        Me.lblNames.Text = "Name:"
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(199, 9)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(112, 20)
        Me.txtNames.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFind)
        Me.GroupBox1.Controls.Add(Me.radRemove)
        Me.GroupBox1.Controls.Add(Me.radAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 61)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'radFind
        '
        Me.radFind.AutoSize = True
        Me.radFind.Location = New System.Drawing.Point(126, 30)
        Me.radFind.Name = "radFind"
        Me.radFind.Size = New System.Drawing.Size(45, 17)
        Me.radFind.TabIndex = 3
        Me.radFind.TabStop = True
        Me.radFind.Text = "Find"
        Me.radFind.UseVisualStyleBackColor = True
        '
        'radRemove
        '
        Me.radRemove.AutoSize = True
        Me.radRemove.Location = New System.Drawing.Point(56, 30)
        Me.radRemove.Name = "radRemove"
        Me.radRemove.Size = New System.Drawing.Size(65, 17)
        Me.radRemove.TabIndex = 2
        Me.radRemove.TabStop = True
        Me.radRemove.Text = "Remove"
        Me.radRemove.UseVisualStyleBackColor = True
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Location = New System.Drawing.Point(6, 30)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(44, 17)
        Me.radAdd.TabIndex = 1
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "Add"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(242, 189)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 4
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 224)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.lblNames)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "Form1"
        Me.Text = "Find Name"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents lblNames As System.Windows.Forms.Label
    Friend WithEvents txtNames As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radFind As System.Windows.Forms.RadioButton
    Friend WithEvents radRemove As System.Windows.Forms.RadioButton
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents btnProcess As System.Windows.Forms.Button

End Class
