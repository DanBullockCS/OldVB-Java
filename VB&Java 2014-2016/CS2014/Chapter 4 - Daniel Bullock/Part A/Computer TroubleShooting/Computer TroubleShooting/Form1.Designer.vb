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
        Me.btnWhatToDo = New System.Windows.Forms.Button()
        Me.lblComputerBeep = New System.Windows.Forms.Label()
        Me.txtboxBeep = New System.Windows.Forms.TextBox()
        Me.txtboxSpin = New System.Windows.Forms.TextBox()
        Me.lblHardDrive = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnWhatToDo
        '
        Me.btnWhatToDo.Location = New System.Drawing.Point(214, 111)
        Me.btnWhatToDo.Name = "btnWhatToDo"
        Me.btnWhatToDo.Size = New System.Drawing.Size(93, 25)
        Me.btnWhatToDo.TabIndex = 0
        Me.btnWhatToDo.Text = "What to do?"
        Me.btnWhatToDo.UseVisualStyleBackColor = True
        '
        'lblComputerBeep
        '
        Me.lblComputerBeep.AutoSize = True
        Me.lblComputerBeep.Location = New System.Drawing.Point(29, 27)
        Me.lblComputerBeep.Name = "lblComputerBeep"
        Me.lblComputerBeep.Size = New System.Drawing.Size(212, 13)
        Me.lblComputerBeep.TabIndex = 1
        Me.lblComputerBeep.Text = "Does the computer beep on start up (Y/N)?"
        '
        'txtboxBeep
        '
        Me.txtboxBeep.Location = New System.Drawing.Point(247, 24)
        Me.txtboxBeep.Name = "txtboxBeep"
        Me.txtboxBeep.Size = New System.Drawing.Size(16, 20)
        Me.txtboxBeep.TabIndex = 2
        '
        'txtboxSpin
        '
        Me.txtboxSpin.Location = New System.Drawing.Point(192, 67)
        Me.txtboxSpin.Name = "txtboxSpin"
        Me.txtboxSpin.Size = New System.Drawing.Size(16, 20)
        Me.txtboxSpin.TabIndex = 3
        '
        'lblHardDrive
        '
        Me.lblHardDrive.AutoSize = True
        Me.lblHardDrive.Location = New System.Drawing.Point(29, 70)
        Me.lblHardDrive.Name = "lblHardDrive"
        Me.lblHardDrive.Size = New System.Drawing.Size(157, 13)
        Me.lblHardDrive.TabIndex = 4
        Me.lblHardDrive.Text = "Does the hard drive spin (Y/N)?"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(29, 117)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 148)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblHardDrive)
        Me.Controls.Add(Me.txtboxSpin)
        Me.Controls.Add(Me.txtboxBeep)
        Me.Controls.Add(Me.lblComputerBeep)
        Me.Controls.Add(Me.btnWhatToDo)
        Me.Name = "Form1"
        Me.Text = "Computer Troubleshooting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWhatToDo As System.Windows.Forms.Button
    Friend WithEvents lblComputerBeep As System.Windows.Forms.Label
    Friend WithEvents txtboxBeep As System.Windows.Forms.TextBox
    Friend WithEvents txtboxSpin As System.Windows.Forms.TextBox
    Friend WithEvents lblHardDrive As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
