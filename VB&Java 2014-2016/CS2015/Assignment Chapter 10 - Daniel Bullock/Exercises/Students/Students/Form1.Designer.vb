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
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnDisplayFullname = New System.Windows.Forms.Button()
        Me.btnEnterScore = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnMinScore = New System.Windows.Forms.Button()
        Me.btnMaxScore = New System.Windows.Forms.Button()
        Me.btnAverageScore = New System.Windows.Forms.Button()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(27, 27)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(27, 60)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(59, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(95, 24)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(95, 57)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 3
        '
        'btnDisplayFullname
        '
        Me.btnDisplayFullname.Location = New System.Drawing.Point(244, 21)
        Me.btnDisplayFullname.Name = "btnDisplayFullname"
        Me.btnDisplayFullname.Size = New System.Drawing.Size(99, 23)
        Me.btnDisplayFullname.TabIndex = 4
        Me.btnDisplayFullname.Tag = "Display"
        Me.btnDisplayFullname.Text = "Display Full Name"
        Me.btnDisplayFullname.UseVisualStyleBackColor = True
        '
        'btnEnterScore
        '
        Me.btnEnterScore.Location = New System.Drawing.Point(81, 105)
        Me.btnEnterScore.Name = "btnEnterScore"
        Me.btnEnterScore.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterScore.TabIndex = 5
        Me.btnEnterScore.Tag = "Enter Score"
        Me.btnEnterScore.Text = "Enter Score"
        Me.btnEnterScore.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(241, 92)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(0, 13)
        Me.lblFullName.TabIndex = 6
        '
        'btnMinScore
        '
        Me.btnMinScore.Location = New System.Drawing.Point(30, 147)
        Me.btnMinScore.Name = "btnMinScore"
        Me.btnMinScore.Size = New System.Drawing.Size(93, 23)
        Me.btnMinScore.TabIndex = 8
        Me.btnMinScore.Tag = "Minimum Score"
        Me.btnMinScore.Text = "Minimum Score"
        Me.btnMinScore.UseVisualStyleBackColor = True
        '
        'btnMaxScore
        '
        Me.btnMaxScore.Location = New System.Drawing.Point(137, 147)
        Me.btnMaxScore.Name = "btnMaxScore"
        Me.btnMaxScore.Size = New System.Drawing.Size(93, 23)
        Me.btnMaxScore.TabIndex = 9
        Me.btnMaxScore.Tag = "Maximum Score"
        Me.btnMaxScore.Text = "Maximum Score"
        Me.btnMaxScore.UseVisualStyleBackColor = True
        '
        'btnAverageScore
        '
        Me.btnAverageScore.Location = New System.Drawing.Point(244, 147)
        Me.btnAverageScore.Name = "btnAverageScore"
        Me.btnAverageScore.Size = New System.Drawing.Size(93, 23)
        Me.btnAverageScore.TabIndex = 10
        Me.btnAverageScore.Tag = "Average Score"
        Me.btnAverageScore.Text = "Average Score"
        Me.btnAverageScore.UseVisualStyleBackColor = True
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(64, 184)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(0, 13)
        Me.lblMin.TabIndex = 11
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(173, 184)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(0, 13)
        Me.lblMax.TabIndex = 12
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(279, 184)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverage.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 207)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.btnAverageScore)
        Me.Controls.Add(Me.btnMaxScore)
        Me.Controls.Add(Me.btnMinScore)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.btnEnterScore)
        Me.Controls.Add(Me.btnDisplayFullname)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "Form1"
        Me.Text = "Students"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayFullname As System.Windows.Forms.Button
    Friend WithEvents btnEnterScore As System.Windows.Forms.Button
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents btnMinScore As System.Windows.Forms.Button
    Friend WithEvents btnMaxScore As System.Windows.Forms.Button
    Friend WithEvents btnAverageScore As System.Windows.Forms.Button
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
