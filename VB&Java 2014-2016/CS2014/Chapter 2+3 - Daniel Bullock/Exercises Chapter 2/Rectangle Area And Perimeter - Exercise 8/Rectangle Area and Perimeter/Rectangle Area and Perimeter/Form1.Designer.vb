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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.txtboxLength = New System.Windows.Forms.TextBox()
        Me.txtboxWidth = New System.Windows.Forms.TextBox()
        Me.lblAreaAnswer = New System.Windows.Forms.Label()
        Me.lblPerimeterAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(310, 24)
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
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(183, 74)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(80, 24)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Answer"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(12, 34)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(85, 13)
        Me.lblLength.TabIndex = 2
        Me.lblLength.Text = "Enter the length:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(83, 60)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(0, 13)
        Me.lblArea.TabIndex = 3
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Location = New System.Drawing.Point(83, 80)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(0, 13)
        Me.lblPerimeter.TabIndex = 4
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(163, 34)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(81, 13)
        Me.lblWidth.TabIndex = 5
        Me.lblWidth.Text = "Enter the width:"
        '
        'txtboxLength
        '
        Me.txtboxLength.Location = New System.Drawing.Point(103, 31)
        Me.txtboxLength.Name = "txtboxLength"
        Me.txtboxLength.Size = New System.Drawing.Size(41, 20)
        Me.txtboxLength.TabIndex = 6
        '
        'txtboxWidth
        '
        Me.txtboxWidth.Location = New System.Drawing.Point(257, 31)
        Me.txtboxWidth.Name = "txtboxWidth"
        Me.txtboxWidth.Size = New System.Drawing.Size(41, 20)
        Me.txtboxWidth.TabIndex = 7
        '
        'lblAreaAnswer
        '
        Me.lblAreaAnswer.AutoSize = True
        Me.lblAreaAnswer.Location = New System.Drawing.Point(34, 60)
        Me.lblAreaAnswer.Name = "lblAreaAnswer"
        Me.lblAreaAnswer.Size = New System.Drawing.Size(38, 13)
        Me.lblAreaAnswer.TabIndex = 9
        Me.lblAreaAnswer.Text = "Area ="
        '
        'lblPerimeterAnswer
        '
        Me.lblPerimeterAnswer.AutoSize = True
        Me.lblPerimeterAnswer.Location = New System.Drawing.Point(17, 80)
        Me.lblPerimeterAnswer.Name = "lblPerimeterAnswer"
        Me.lblPerimeterAnswer.Size = New System.Drawing.Size(60, 13)
        Me.lblPerimeterAnswer.TabIndex = 8
        Me.lblPerimeterAnswer.Text = "Perimeter ="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 117)
        Me.Controls.Add(Me.lblAreaAnswer)
        Me.Controls.Add(Me.lblPerimeterAnswer)
        Me.Controls.Add(Me.txtboxWidth)
        Me.Controls.Add(Me.txtboxLength)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Rectangle Area and Perimeter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblPerimeter As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents txtboxLength As System.Windows.Forms.TextBox
    Friend WithEvents txtboxWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblAreaAnswer As System.Windows.Forms.Label
    Friend WithEvents lblPerimeterAnswer As System.Windows.Forms.Label

End Class
