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
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtbox3 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(211, 80)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(80, 22)
        Me.btnAnswer.TabIndex = 0
        Me.btnAnswer.Text = "Distance"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(30, 85)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 1
        '
        'txtbox3
        '
        Me.txtbox3.Location = New System.Drawing.Point(211, 43)
        Me.txtbox3.Name = "txtbox3"
        Me.txtbox3.Size = New System.Drawing.Size(55, 20)
        Me.txtbox3.TabIndex = 2
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(122, 43)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(55, 20)
        Me.txtbox2.TabIndex = 3
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(33, 43)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(55, 20)
        Me.txtbox1.TabIndex = 4
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(13, 18)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(306, 13)
        Me.lblQuestion.TabIndex = 5
        Me.lblQuestion.Text = "Please enter the lengths for each of the 3 segments in the race:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 121)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.txtbox3)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnAnswer)
        Me.Name = "Form1"
        Me.Text = "Total Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents txtbox3 As System.Windows.Forms.TextBox
    Friend WithEvents txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestion As System.Windows.Forms.Label

End Class
