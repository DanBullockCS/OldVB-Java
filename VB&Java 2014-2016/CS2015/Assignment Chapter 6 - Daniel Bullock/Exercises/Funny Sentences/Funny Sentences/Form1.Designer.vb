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
        Me.btnCreateSentence = New System.Windows.Forms.Button()
        Me.lblNoun = New System.Windows.Forms.Label()
        Me.txtNoun = New System.Windows.Forms.TextBox()
        Me.txtAdjective = New System.Windows.Forms.TextBox()
        Me.txtVerb = New System.Windows.Forms.TextBox()
        Me.lblVerb = New System.Windows.Forms.Label()
        Me.lblAdjective = New System.Windows.Forms.Label()
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCreateSentence
        '
        Me.btnCreateSentence.Location = New System.Drawing.Point(286, 84)
        Me.btnCreateSentence.Name = "btnCreateSentence"
        Me.btnCreateSentence.Size = New System.Drawing.Size(122, 26)
        Me.btnCreateSentence.TabIndex = 0
        Me.btnCreateSentence.Text = "Create Sentence"
        Me.btnCreateSentence.UseVisualStyleBackColor = True
        '
        'lblNoun
        '
        Me.lblNoun.AutoSize = True
        Me.lblNoun.Location = New System.Drawing.Point(22, 41)
        Me.lblNoun.Name = "lblNoun"
        Me.lblNoun.Size = New System.Drawing.Size(71, 13)
        Me.lblNoun.TabIndex = 1
        Me.lblNoun.Text = "Enter a noun:"
        '
        'txtNoun
        '
        Me.txtNoun.Location = New System.Drawing.Point(147, 38)
        Me.txtNoun.Name = "txtNoun"
        Me.txtNoun.Size = New System.Drawing.Size(120, 20)
        Me.txtNoun.TabIndex = 2
        '
        'txtAdjective
        '
        Me.txtAdjective.Location = New System.Drawing.Point(147, 136)
        Me.txtAdjective.Name = "txtAdjective"
        Me.txtAdjective.Size = New System.Drawing.Size(120, 20)
        Me.txtAdjective.TabIndex = 3
        '
        'txtVerb
        '
        Me.txtVerb.Location = New System.Drawing.Point(147, 84)
        Me.txtVerb.Name = "txtVerb"
        Me.txtVerb.Size = New System.Drawing.Size(120, 20)
        Me.txtVerb.TabIndex = 4
        '
        'lblVerb
        '
        Me.lblVerb.AutoSize = True
        Me.lblVerb.Location = New System.Drawing.Point(22, 91)
        Me.lblVerb.Name = "lblVerb"
        Me.lblVerb.Size = New System.Drawing.Size(68, 13)
        Me.lblVerb.TabIndex = 5
        Me.lblVerb.Text = "Enter a verb:"
        '
        'lblAdjective
        '
        Me.lblAdjective.AutoSize = True
        Me.lblAdjective.Location = New System.Drawing.Point(22, 143)
        Me.lblAdjective.Name = "lblAdjective"
        Me.lblAdjective.Size = New System.Drawing.Size(96, 13)
        Me.lblAdjective.TabIndex = 6
        Me.lblAdjective.Text = "Enter an adjective:"
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(22, 185)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(0, 13)
        Me.lblSentence.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 207)
        Me.Controls.Add(Me.lblSentence)
        Me.Controls.Add(Me.lblAdjective)
        Me.Controls.Add(Me.lblVerb)
        Me.Controls.Add(Me.txtVerb)
        Me.Controls.Add(Me.txtAdjective)
        Me.Controls.Add(Me.txtNoun)
        Me.Controls.Add(Me.lblNoun)
        Me.Controls.Add(Me.btnCreateSentence)
        Me.Name = "Form1"
        Me.Text = "Funny Sentences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateSentence As System.Windows.Forms.Button
    Friend WithEvents lblNoun As System.Windows.Forms.Label
    Friend WithEvents txtNoun As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjective As System.Windows.Forms.TextBox
    Friend WithEvents txtVerb As System.Windows.Forms.TextBox
    Friend WithEvents lblVerb As System.Windows.Forms.Label
    Friend WithEvents lblAdjective As System.Windows.Forms.Label
    Friend WithEvents lblSentence As System.Windows.Forms.Label

End Class
