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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleInitial = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.lblClassRanking = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleInitial = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.lstClassRanking = New System.Windows.Forms.ListBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnShowStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 10)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstName.TabIndex = 9
        Me.lblFirstName.Text = "First name:"
        '
        'lblMiddleInitial
        '
        Me.lblMiddleInitial.AutoSize = True
        Me.lblMiddleInitial.Location = New System.Drawing.Point(198, 10)
        Me.lblMiddleInitial.Name = "lblMiddleInitial"
        Me.lblMiddleInitial.Size = New System.Drawing.Size(68, 13)
        Me.lblMiddleInitial.TabIndex = 10
        Me.lblMiddleInitial.Text = "Middle Initial:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 49)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(59, 13)
        Me.lblLastName.TabIndex = 11
        Me.lblLastName.Text = "Last name:"
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(12, 87)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(32, 13)
        Me.lblGPA.TabIndex = 12
        Me.lblGPA.Text = "GPA:"
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Location = New System.Drawing.Point(120, 87)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(42, 13)
        Me.lblCredits.TabIndex = 13
        Me.lblCredits.Text = "Credits:"
        '
        'lblClassRanking
        '
        Me.lblClassRanking.AutoSize = True
        Me.lblClassRanking.Location = New System.Drawing.Point(12, 124)
        Me.lblClassRanking.Name = "lblClassRanking"
        Me.lblClassRanking.Size = New System.Drawing.Size(73, 13)
        Me.lblClassRanking.TabIndex = 14
        Me.lblClassRanking.Text = "Class ranking:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(87, 7)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(95, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Location = New System.Drawing.Point(272, 7)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(25, 20)
        Me.txtMiddleInitial.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(77, 46)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(85, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtGPA
        '
        Me.txtGPA.Location = New System.Drawing.Point(50, 84)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(49, 20)
        Me.txtGPA.TabIndex = 4
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(168, 82)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(44, 20)
        Me.txtCredits.TabIndex = 5
        '
        'lstClassRanking
        '
        Me.lstClassRanking.FormattingEnabled = True
        Me.lstClassRanking.Items.AddRange(New Object() {"Freshman", "Sophomore", "Junior", "Senior"})
        Me.lstClassRanking.Location = New System.Drawing.Point(91, 124)
        Me.lstClassRanking.Name = "lstClassRanking"
        Me.lstClassRanking.Size = New System.Drawing.Size(137, 17)
        Me.lstClassRanking.TabIndex = 6
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(244, 77)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(93, 23)
        Me.btnAddStudent.TabIndex = 7
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnShowStudent
        '
        Me.btnShowStudent.Location = New System.Drawing.Point(244, 119)
        Me.btnShowStudent.Name = "btnShowStudent"
        Me.btnShowStudent.Size = New System.Drawing.Size(93, 26)
        Me.btnShowStudent.TabIndex = 8
        Me.btnShowStudent.Text = "Show Student"
        Me.btnShowStudent.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 158)
        Me.Controls.Add(Me.btnShowStudent)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lstClassRanking)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleInitial)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblClassRanking)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblMiddleInitial)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "Form1"
        Me.Text = "Students"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblMiddleInitial As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblGPA As System.Windows.Forms.Label
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents lblClassRanking As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleInitial As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtGPA As System.Windows.Forms.TextBox
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents lstClassRanking As System.Windows.Forms.ListBox
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents btnShowStudent As System.Windows.Forms.Button

End Class
