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
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.lblEnterSentence = New System.Windows.Forms.Label()
        Me.lblEnterSearch = New System.Windows.Forms.Label()
        Me.lblEnterReplace = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(106, 14)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(219, 20)
        Me.txtSentence.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(106, 73)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(140, 20)
        Me.txtSearch.TabIndex = 1
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(106, 124)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(140, 20)
        Me.txtReplace.TabIndex = 2
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(294, 121)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(57, 23)
        Me.btnReplace.TabIndex = 3
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'lblEnterSentence
        '
        Me.lblEnterSentence.AutoSize = True
        Me.lblEnterSentence.Location = New System.Drawing.Point(7, 17)
        Me.lblEnterSentence.Name = "lblEnterSentence"
        Me.lblEnterSentence.Size = New System.Drawing.Size(82, 13)
        Me.lblEnterSentence.TabIndex = 4
        Me.lblEnterSentence.Text = "Enter sentence:"
        '
        'lblEnterSearch
        '
        Me.lblEnterSearch.AutoSize = True
        Me.lblEnterSearch.Location = New System.Drawing.Point(7, 76)
        Me.lblEnterSearch.Name = "lblEnterSearch"
        Me.lblEnterSearch.Size = New System.Drawing.Size(90, 13)
        Me.lblEnterSearch.TabIndex = 5
        Me.lblEnterSearch.Text = "Enter search text:"
        '
        'lblEnterReplace
        '
        Me.lblEnterReplace.AutoSize = True
        Me.lblEnterReplace.Location = New System.Drawing.Point(7, 127)
        Me.lblEnterReplace.Name = "lblEnterReplace"
        Me.lblEnterReplace.Size = New System.Drawing.Size(93, 13)
        Me.lblEnterReplace.TabIndex = 6
        Me.lblEnterReplace.Text = "Enter replace text:"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(23, 151)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 186)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblEnterReplace)
        Me.Controls.Add(Me.lblEnterSearch)
        Me.Controls.Add(Me.lblEnterSentence)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtSentence)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Replace String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSentence As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents lblEnterSentence As System.Windows.Forms.Label
    Friend WithEvents lblEnterSearch As System.Windows.Forms.Label
    Friend WithEvents lblEnterReplace As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
