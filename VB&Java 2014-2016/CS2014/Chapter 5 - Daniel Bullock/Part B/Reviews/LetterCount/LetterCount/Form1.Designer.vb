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
        Me.lblEnterText = New System.Windows.Forms.Label()
        Me.lblSearchLetter = New System.Windows.Forms.Label()
        Me.lblStatementNumTimesLetterOccurs = New System.Windows.Forms.Label()
        Me.lblNumberOfTimesLetterOccurs = New System.Windows.Forms.Label()
        Me.txtEnterLetter = New System.Windows.Forms.TextBox()
        Me.txtEnterText = New System.Windows.Forms.TextBox()
        Me.btnCountLetter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterText
        '
        Me.lblEnterText.AutoSize = True
        Me.lblEnterText.Location = New System.Drawing.Point(9, 15)
        Me.lblEnterText.Name = "lblEnterText"
        Me.lblEnterText.Size = New System.Drawing.Size(55, 13)
        Me.lblEnterText.TabIndex = 0
        Me.lblEnterText.Text = "Enter text:"
        '
        'lblSearchLetter
        '
        Me.lblSearchLetter.AutoSize = True
        Me.lblSearchLetter.Location = New System.Drawing.Point(266, 15)
        Me.lblSearchLetter.Name = "lblSearchLetter"
        Me.lblSearchLetter.Size = New System.Drawing.Size(123, 13)
        Me.lblSearchLetter.TabIndex = 1
        Me.lblSearchLetter.Text = "Enter letter to search for:"
        '
        'lblStatementNumTimesLetterOccurs
        '
        Me.lblStatementNumTimesLetterOccurs.AutoSize = True
        Me.lblStatementNumTimesLetterOccurs.Location = New System.Drawing.Point(12, 61)
        Me.lblStatementNumTimesLetterOccurs.Name = "lblStatementNumTimesLetterOccurs"
        Me.lblStatementNumTimesLetterOccurs.Size = New System.Drawing.Size(147, 13)
        Me.lblStatementNumTimesLetterOccurs.TabIndex = 2
        Me.lblStatementNumTimesLetterOccurs.Text = "Number of times letter occurs:"
        '
        'lblNumberOfTimesLetterOccurs
        '
        Me.lblNumberOfTimesLetterOccurs.AutoSize = True
        Me.lblNumberOfTimesLetterOccurs.Location = New System.Drawing.Point(161, 61)
        Me.lblNumberOfTimesLetterOccurs.Name = "lblNumberOfTimesLetterOccurs"
        Me.lblNumberOfTimesLetterOccurs.Size = New System.Drawing.Size(0, 13)
        Me.lblNumberOfTimesLetterOccurs.TabIndex = 3
        '
        'txtEnterLetter
        '
        Me.txtEnterLetter.Location = New System.Drawing.Point(395, 12)
        Me.txtEnterLetter.Name = "txtEnterLetter"
        Me.txtEnterLetter.Size = New System.Drawing.Size(55, 20)
        Me.txtEnterLetter.TabIndex = 4
        '
        'txtEnterText
        '
        Me.txtEnterText.Location = New System.Drawing.Point(70, 12)
        Me.txtEnterText.Name = "txtEnterText"
        Me.txtEnterText.Size = New System.Drawing.Size(190, 20)
        Me.txtEnterText.TabIndex = 5
        '
        'btnCountLetter
        '
        Me.btnCountLetter.Location = New System.Drawing.Point(375, 61)
        Me.btnCountLetter.Name = "btnCountLetter"
        Me.btnCountLetter.Size = New System.Drawing.Size(75, 23)
        Me.btnCountLetter.TabIndex = 6
        Me.btnCountLetter.Text = "Count Letter"
        Me.btnCountLetter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 112)
        Me.Controls.Add(Me.btnCountLetter)
        Me.Controls.Add(Me.txtEnterText)
        Me.Controls.Add(Me.txtEnterLetter)
        Me.Controls.Add(Me.lblNumberOfTimesLetterOccurs)
        Me.Controls.Add(Me.lblStatementNumTimesLetterOccurs)
        Me.Controls.Add(Me.lblSearchLetter)
        Me.Controls.Add(Me.lblEnterText)
        Me.Name = "Form1"
        Me.Text = "Letter Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterText As System.Windows.Forms.Label
    Friend WithEvents lblSearchLetter As System.Windows.Forms.Label
    Friend WithEvents lblStatementNumTimesLetterOccurs As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfTimesLetterOccurs As System.Windows.Forms.Label
    Friend WithEvents txtEnterLetter As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterText As System.Windows.Forms.TextBox
    Friend WithEvents btnCountLetter As System.Windows.Forms.Button

End Class
