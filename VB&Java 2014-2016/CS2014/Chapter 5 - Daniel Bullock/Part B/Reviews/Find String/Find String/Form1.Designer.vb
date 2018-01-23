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
        Me.btnFindString = New System.Windows.Forms.Button()
        Me.lblEnterText = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.lblEnterSearchText = New System.Windows.Forms.Label()
        Me.lblPositionsStatement = New System.Windows.Forms.Label()
        Me.lblPositionsOfSearchText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFindString
        '
        Me.btnFindString.Location = New System.Drawing.Point(254, 120)
        Me.btnFindString.Name = "btnFindString"
        Me.btnFindString.Size = New System.Drawing.Size(93, 24)
        Me.btnFindString.TabIndex = 0
        Me.btnFindString.Text = "Find String"
        Me.btnFindString.UseVisualStyleBackColor = True
        '
        'lblEnterText
        '
        Me.lblEnterText.AutoSize = True
        Me.lblEnterText.Location = New System.Drawing.Point(12, 22)
        Me.lblEnterText.Name = "lblEnterText"
        Me.lblEnterText.Size = New System.Drawing.Size(55, 13)
        Me.lblEnterText.TabIndex = 1
        Me.lblEnterText.Text = "Enter text:"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(107, 19)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(240, 20)
        Me.txtText.TabIndex = 2
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(133, 55)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(214, 20)
        Me.txtSearchText.TabIndex = 3
        '
        'lblEnterSearchText
        '
        Me.lblEnterSearchText.AutoSize = True
        Me.lblEnterSearchText.Location = New System.Drawing.Point(12, 58)
        Me.lblEnterSearchText.Name = "lblEnterSearchText"
        Me.lblEnterSearchText.Size = New System.Drawing.Size(90, 13)
        Me.lblEnterSearchText.TabIndex = 4
        Me.lblEnterSearchText.Text = "Enter search text:"
        '
        'lblPositionsStatement
        '
        Me.lblPositionsStatement.AutoSize = True
        Me.lblPositionsStatement.Location = New System.Drawing.Point(12, 126)
        Me.lblPositionsStatement.Name = "lblPositionsStatement"
        Me.lblPositionsStatement.Size = New System.Drawing.Size(114, 13)
        Me.lblPositionsStatement.TabIndex = 5
        Me.lblPositionsStatement.Text = "Position of search text:"
        '
        'lblPositionsOfSearchText
        '
        Me.lblPositionsOfSearchText.AutoSize = True
        Me.lblPositionsOfSearchText.Location = New System.Drawing.Point(130, 126)
        Me.lblPositionsOfSearchText.Name = "lblPositionsOfSearchText"
        Me.lblPositionsOfSearchText.Size = New System.Drawing.Size(0, 13)
        Me.lblPositionsOfSearchText.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 163)
        Me.Controls.Add(Me.lblPositionsOfSearchText)
        Me.Controls.Add(Me.lblPositionsStatement)
        Me.Controls.Add(Me.lblEnterSearchText)
        Me.Controls.Add(Me.txtSearchText)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lblEnterText)
        Me.Controls.Add(Me.btnFindString)
        Me.Name = "Form1"
        Me.Text = "Find String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFindString As System.Windows.Forms.Button
    Friend WithEvents lblEnterText As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchText As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterSearchText As System.Windows.Forms.Label
    Friend WithEvents lblPositionsStatement As System.Windows.Forms.Label
    Friend WithEvents lblPositionsOfSearchText As System.Windows.Forms.Label

End Class
