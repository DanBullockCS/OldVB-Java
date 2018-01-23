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
        Me.btnEnterGrade = New System.Windows.Forms.Button()
        Me.lblEnterGrade = New System.Windows.Forms.Label()
        Me.txtboxGrade = New System.Windows.Forms.TextBox()
        Me.lblQuestionPass = New System.Windows.Forms.Label()
        Me.lblQuestionFail = New System.Windows.Forms.Label()
        Me.lblPassed = New System.Windows.Forms.Label()
        Me.lblFailed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterGrade
        '
        Me.btnEnterGrade.Location = New System.Drawing.Point(145, 23)
        Me.btnEnterGrade.Name = "btnEnterGrade"
        Me.btnEnterGrade.Size = New System.Drawing.Size(89, 25)
        Me.btnEnterGrade.TabIndex = 0
        Me.btnEnterGrade.Text = "Enter Grade"
        Me.btnEnterGrade.UseVisualStyleBackColor = True
        '
        'lblEnterGrade
        '
        Me.lblEnterGrade.AutoSize = True
        Me.lblEnterGrade.Location = New System.Drawing.Point(12, 29)
        Me.lblEnterGrade.Name = "lblEnterGrade"
        Me.lblEnterGrade.Size = New System.Drawing.Size(74, 13)
        Me.lblEnterGrade.TabIndex = 1
        Me.lblEnterGrade.Text = "Enter a grade:"
        '
        'txtboxGrade
        '
        Me.txtboxGrade.Location = New System.Drawing.Point(95, 26)
        Me.txtboxGrade.Name = "txtboxGrade"
        Me.txtboxGrade.Size = New System.Drawing.Size(44, 20)
        Me.txtboxGrade.TabIndex = 2
        '
        'lblQuestionPass
        '
        Me.lblQuestionPass.AutoSize = True
        Me.lblQuestionPass.Location = New System.Drawing.Point(12, 69)
        Me.lblQuestionPass.Name = "lblQuestionPass"
        Me.lblQuestionPass.Size = New System.Drawing.Size(166, 13)
        Me.lblQuestionPass.TabIndex = 3
        Me.lblQuestionPass.Text = "Number of students that passed ="
        '
        'lblQuestionFail
        '
        Me.lblQuestionFail.AutoSize = True
        Me.lblQuestionFail.Location = New System.Drawing.Point(12, 93)
        Me.lblQuestionFail.Name = "lblQuestionFail"
        Me.lblQuestionFail.Size = New System.Drawing.Size(157, 13)
        Me.lblQuestionFail.TabIndex = 4
        Me.lblQuestionFail.Text = "Number of students that failed ="
        '
        'lblPassed
        '
        Me.lblPassed.AutoSize = True
        Me.lblPassed.Location = New System.Drawing.Point(184, 69)
        Me.lblPassed.Name = "lblPassed"
        Me.lblPassed.Size = New System.Drawing.Size(13, 13)
        Me.lblPassed.TabIndex = 5
        Me.lblPassed.Text = "0"
        '
        'lblFailed
        '
        Me.lblFailed.AutoSize = True
        Me.lblFailed.Location = New System.Drawing.Point(175, 93)
        Me.lblFailed.Name = "lblFailed"
        Me.lblFailed.Size = New System.Drawing.Size(13, 13)
        Me.lblFailed.TabIndex = 6
        Me.lblFailed.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 119)
        Me.Controls.Add(Me.lblFailed)
        Me.Controls.Add(Me.lblPassed)
        Me.Controls.Add(Me.lblQuestionFail)
        Me.Controls.Add(Me.lblQuestionPass)
        Me.Controls.Add(Me.txtboxGrade)
        Me.Controls.Add(Me.lblEnterGrade)
        Me.Controls.Add(Me.btnEnterGrade)
        Me.Name = "Form1"
        Me.Text = "Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnterGrade As System.Windows.Forms.Button
    Friend WithEvents lblEnterGrade As System.Windows.Forms.Label
    Friend WithEvents txtboxGrade As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestionPass As System.Windows.Forms.Label
    Friend WithEvents lblQuestionFail As System.Windows.Forms.Label
    Friend WithEvents lblPassed As System.Windows.Forms.Label
    Friend WithEvents lblFailed As System.Windows.Forms.Label

End Class
