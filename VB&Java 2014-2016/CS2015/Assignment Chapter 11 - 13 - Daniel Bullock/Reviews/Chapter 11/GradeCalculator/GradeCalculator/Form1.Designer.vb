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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStuNamePrompt = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblGrade1Prompt = New System.Windows.Forms.Label()
        Me.lblGrade2Prompt = New System.Windows.Forms.Label()
        Me.lblGrade3Prompt = New System.Windows.Forms.Label()
        Me.lblGrade4Prompt = New System.Windows.Forms.Label()
        Me.lblGrade5Prompt = New System.Windows.Forms.Label()
        Me.txtGrade1 = New System.Windows.Forms.TextBox()
        Me.txtGrade2 = New System.Windows.Forms.TextBox()
        Me.txtGrade3 = New System.Windows.Forms.TextBox()
        Me.txtGrade4 = New System.Windows.Forms.TextBox()
        Me.txtGrade5 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(251, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.ClearGradesToolStripMenuItem, Me.ShowGradesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'ClearGradesToolStripMenuItem
        '
        Me.ClearGradesToolStripMenuItem.Name = "ClearGradesToolStripMenuItem"
        Me.ClearGradesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearGradesToolStripMenuItem.Text = "Clear Grades"
        '
        'ShowGradesToolStripMenuItem
        '
        Me.ShowGradesToolStripMenuItem.Name = "ShowGradesToolStripMenuItem"
        Me.ShowGradesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowGradesToolStripMenuItem.Text = "Show Grades"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblStuNamePrompt
        '
        Me.lblStuNamePrompt.AutoSize = True
        Me.lblStuNamePrompt.Location = New System.Drawing.Point(12, 44)
        Me.lblStuNamePrompt.Name = "lblStuNamePrompt"
        Me.lblStuNamePrompt.Size = New System.Drawing.Size(78, 13)
        Me.lblStuNamePrompt.TabIndex = 1
        Me.lblStuNamePrompt.Text = "Student Name:"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(96, 41)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(112, 20)
        Me.txtStudentName.TabIndex = 2
        '
        'lblGrade1Prompt
        '
        Me.lblGrade1Prompt.AutoSize = True
        Me.lblGrade1Prompt.Location = New System.Drawing.Point(12, 68)
        Me.lblGrade1Prompt.Name = "lblGrade1Prompt"
        Me.lblGrade1Prompt.Size = New System.Drawing.Size(48, 13)
        Me.lblGrade1Prompt.TabIndex = 3
        Me.lblGrade1Prompt.Text = "Grade 1:"
        '
        'lblGrade2Prompt
        '
        Me.lblGrade2Prompt.AutoSize = True
        Me.lblGrade2Prompt.Location = New System.Drawing.Point(12, 93)
        Me.lblGrade2Prompt.Name = "lblGrade2Prompt"
        Me.lblGrade2Prompt.Size = New System.Drawing.Size(48, 13)
        Me.lblGrade2Prompt.TabIndex = 4
        Me.lblGrade2Prompt.Text = "Grade 2:"
        '
        'lblGrade3Prompt
        '
        Me.lblGrade3Prompt.AutoSize = True
        Me.lblGrade3Prompt.Location = New System.Drawing.Point(12, 119)
        Me.lblGrade3Prompt.Name = "lblGrade3Prompt"
        Me.lblGrade3Prompt.Size = New System.Drawing.Size(48, 13)
        Me.lblGrade3Prompt.TabIndex = 5
        Me.lblGrade3Prompt.Text = "Grade 3:"
        '
        'lblGrade4Prompt
        '
        Me.lblGrade4Prompt.AutoSize = True
        Me.lblGrade4Prompt.Location = New System.Drawing.Point(12, 147)
        Me.lblGrade4Prompt.Name = "lblGrade4Prompt"
        Me.lblGrade4Prompt.Size = New System.Drawing.Size(48, 13)
        Me.lblGrade4Prompt.TabIndex = 6
        Me.lblGrade4Prompt.Text = "Grade 4:"
        '
        'lblGrade5Prompt
        '
        Me.lblGrade5Prompt.AutoSize = True
        Me.lblGrade5Prompt.Location = New System.Drawing.Point(12, 177)
        Me.lblGrade5Prompt.Name = "lblGrade5Prompt"
        Me.lblGrade5Prompt.Size = New System.Drawing.Size(48, 13)
        Me.lblGrade5Prompt.TabIndex = 7
        Me.lblGrade5Prompt.Text = "Grade 5:"
        '
        'txtGrade1
        '
        Me.txtGrade1.Location = New System.Drawing.Point(66, 65)
        Me.txtGrade1.Name = "txtGrade1"
        Me.txtGrade1.Size = New System.Drawing.Size(43, 20)
        Me.txtGrade1.TabIndex = 8
        '
        'txtGrade2
        '
        Me.txtGrade2.Location = New System.Drawing.Point(66, 90)
        Me.txtGrade2.Name = "txtGrade2"
        Me.txtGrade2.Size = New System.Drawing.Size(43, 20)
        Me.txtGrade2.TabIndex = 9
        '
        'txtGrade3
        '
        Me.txtGrade3.Location = New System.Drawing.Point(66, 116)
        Me.txtGrade3.Name = "txtGrade3"
        Me.txtGrade3.Size = New System.Drawing.Size(43, 20)
        Me.txtGrade3.TabIndex = 10
        '
        'txtGrade4
        '
        Me.txtGrade4.Location = New System.Drawing.Point(66, 144)
        Me.txtGrade4.Name = "txtGrade4"
        Me.txtGrade4.Size = New System.Drawing.Size(43, 20)
        Me.txtGrade4.TabIndex = 11
        '
        'txtGrade5
        '
        Me.txtGrade5.Location = New System.Drawing.Point(66, 174)
        Me.txtGrade5.Name = "txtGrade5"
        Me.txtGrade5.Size = New System.Drawing.Size(43, 20)
        Me.txtGrade5.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 208)
        Me.Controls.Add(Me.txtGrade5)
        Me.Controls.Add(Me.txtGrade4)
        Me.Controls.Add(Me.txtGrade3)
        Me.Controls.Add(Me.txtGrade2)
        Me.Controls.Add(Me.txtGrade1)
        Me.Controls.Add(Me.lblGrade5Prompt)
        Me.Controls.Add(Me.lblGrade4Prompt)
        Me.Controls.Add(Me.lblGrade3Prompt)
        Me.Controls.Add(Me.lblGrade2Prompt)
        Me.Controls.Add(Me.lblGrade1Prompt)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.lblStuNamePrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Grade Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStuNamePrompt As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblGrade2Prompt As System.Windows.Forms.Label
    Friend WithEvents lblGrade3Prompt As System.Windows.Forms.Label
    Friend WithEvents lblGrade4Prompt As System.Windows.Forms.Label
    Friend WithEvents lblGrade5Prompt As System.Windows.Forms.Label
    Friend WithEvents txtGrade1 As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade3 As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade4 As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade5 As System.Windows.Forms.TextBox

End Class
