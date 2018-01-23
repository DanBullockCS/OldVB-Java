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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbllengthjump1 = New System.Windows.Forms.Label()
        Me.lbllengthjump2 = New System.Windows.Forms.Label()
        Me.lbllengthjump3 = New System.Windows.Forms.Label()
        Me.lbllengthjump4 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.txtboxJump1 = New System.Windows.Forms.TextBox()
        Me.txtboxJump2 = New System.Windows.Forms.TextBox()
        Me.txtboxJump3 = New System.Windows.Forms.TextBox()
        Me.txtboxJump4 = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(240, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lbllengthjump1
        '
        Me.lbllengthjump1.AutoSize = True
        Me.lbllengthjump1.Location = New System.Drawing.Point(26, 50)
        Me.lbllengthjump1.Name = "lbllengthjump1"
        Me.lbllengthjump1.Size = New System.Drawing.Size(121, 13)
        Me.lbllengthjump1.TabIndex = 1
        Me.lbllengthjump1.Text = "Enter length of 1st jump:"
        '
        'lbllengthjump2
        '
        Me.lbllengthjump2.AutoSize = True
        Me.lbllengthjump2.Location = New System.Drawing.Point(26, 85)
        Me.lbllengthjump2.Name = "lbllengthjump2"
        Me.lbllengthjump2.Size = New System.Drawing.Size(125, 13)
        Me.lbllengthjump2.TabIndex = 2
        Me.lbllengthjump2.Text = "Enter length of 2nd jump:"
        '
        'lbllengthjump3
        '
        Me.lbllengthjump3.AutoSize = True
        Me.lbllengthjump3.Location = New System.Drawing.Point(26, 122)
        Me.lbllengthjump3.Name = "lbllengthjump3"
        Me.lbllengthjump3.Size = New System.Drawing.Size(122, 13)
        Me.lbllengthjump3.TabIndex = 3
        Me.lbllengthjump3.Text = "Enter length of 3rd jump:"
        '
        'lbllengthjump4
        '
        Me.lbllengthjump4.AutoSize = True
        Me.lbllengthjump4.Location = New System.Drawing.Point(26, 159)
        Me.lbllengthjump4.Name = "lbllengthjump4"
        Me.lbllengthjump4.Size = New System.Drawing.Size(122, 13)
        Me.lbllengthjump4.TabIndex = 4
        Me.lbllengthjump4.Text = "Enter length of 4th jump:"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(26, 192)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(47, 13)
        Me.lblAverage.TabIndex = 5
        Me.lblAverage.Text = "Average"
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(127, 186)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(85, 24)
        Me.btnAverage.TabIndex = 6
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'txtboxJump1
        '
        Me.txtboxJump1.Location = New System.Drawing.Point(155, 47)
        Me.txtboxJump1.Name = "txtboxJump1"
        Me.txtboxJump1.Size = New System.Drawing.Size(57, 20)
        Me.txtboxJump1.TabIndex = 7
        '
        'txtboxJump2
        '
        Me.txtboxJump2.Location = New System.Drawing.Point(155, 82)
        Me.txtboxJump2.Name = "txtboxJump2"
        Me.txtboxJump2.Size = New System.Drawing.Size(57, 20)
        Me.txtboxJump2.TabIndex = 8
        '
        'txtboxJump3
        '
        Me.txtboxJump3.Location = New System.Drawing.Point(155, 119)
        Me.txtboxJump3.Name = "txtboxJump3"
        Me.txtboxJump3.Size = New System.Drawing.Size(57, 20)
        Me.txtboxJump3.TabIndex = 9
        '
        'txtboxJump4
        '
        Me.txtboxJump4.Location = New System.Drawing.Point(155, 152)
        Me.txtboxJump4.Name = "txtboxJump4"
        Me.txtboxJump4.Size = New System.Drawing.Size(57, 20)
        Me.txtboxJump4.TabIndex = 10
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(79, 192)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 240)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtboxJump4)
        Me.Controls.Add(Me.txtboxJump3)
        Me.Controls.Add(Me.txtboxJump2)
        Me.Controls.Add(Me.txtboxJump1)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lbllengthjump4)
        Me.Controls.Add(Me.lbllengthjump3)
        Me.Controls.Add(Me.lbllengthjump2)
        Me.Controls.Add(Me.lbllengthjump1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Long Jump Average"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbllengthjump1 As System.Windows.Forms.Label
    Friend WithEvents lbllengthjump2 As System.Windows.Forms.Label
    Friend WithEvents lbllengthjump3 As System.Windows.Forms.Label
    Friend WithEvents lbllengthjump4 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents txtboxJump1 As System.Windows.Forms.TextBox
    Friend WithEvents txtboxJump2 As System.Windows.Forms.TextBox
    Friend WithEvents txtboxJump3 As System.Windows.Forms.TextBox
    Friend WithEvents txtboxJump4 As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
