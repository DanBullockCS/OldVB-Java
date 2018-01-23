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
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.lblStatementFirst = New System.Windows.Forms.Label()
        Me.lblFirstLetter = New System.Windows.Forms.Label()
        Me.lblStatementMid = New System.Windows.Forms.Label()
        Me.lblMiddleLetter = New System.Windows.Forms.Label()
        Me.lblStatementLast = New System.Windows.Forms.Label()
        Me.lblLastLetter = New System.Windows.Forms.Label()
        Me.btnData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterText
        '
        Me.lblEnterText.AutoSize = True
        Me.lblEnterText.Location = New System.Drawing.Point(12, 15)
        Me.lblEnterText.Name = "lblEnterText"
        Me.lblEnterText.Size = New System.Drawing.Size(55, 13)
        Me.lblEnterText.TabIndex = 0
        Me.lblEnterText.Text = "Enter text:"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(88, 12)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(167, 20)
        Me.txtText.TabIndex = 1
        '
        'lblStatementFirst
        '
        Me.lblStatementFirst.AutoSize = True
        Me.lblStatementFirst.Location = New System.Drawing.Point(12, 51)
        Me.lblStatementFirst.Name = "lblStatementFirst"
        Me.lblStatementFirst.Size = New System.Drawing.Size(55, 13)
        Me.lblStatementFirst.TabIndex = 2
        Me.lblStatementFirst.Text = "First letter:"
        '
        'lblFirstLetter
        '
        Me.lblFirstLetter.AutoSize = True
        Me.lblFirstLetter.Location = New System.Drawing.Point(73, 51)
        Me.lblFirstLetter.Name = "lblFirstLetter"
        Me.lblFirstLetter.Size = New System.Drawing.Size(0, 13)
        Me.lblFirstLetter.TabIndex = 3
        '
        'lblStatementMid
        '
        Me.lblStatementMid.AutoSize = True
        Me.lblStatementMid.Location = New System.Drawing.Point(12, 78)
        Me.lblStatementMid.Name = "lblStatementMid"
        Me.lblStatementMid.Size = New System.Drawing.Size(67, 13)
        Me.lblStatementMid.TabIndex = 4
        Me.lblStatementMid.Text = "Middle letter:"
        '
        'lblMiddleLetter
        '
        Me.lblMiddleLetter.AutoSize = True
        Me.lblMiddleLetter.Location = New System.Drawing.Point(82, 78)
        Me.lblMiddleLetter.Name = "lblMiddleLetter"
        Me.lblMiddleLetter.Size = New System.Drawing.Size(0, 13)
        Me.lblMiddleLetter.TabIndex = 5
        '
        'lblStatementLast
        '
        Me.lblStatementLast.AutoSize = True
        Me.lblStatementLast.Location = New System.Drawing.Point(12, 109)
        Me.lblStatementLast.Name = "lblStatementLast"
        Me.lblStatementLast.Size = New System.Drawing.Size(56, 13)
        Me.lblStatementLast.TabIndex = 6
        Me.lblStatementLast.Text = "Last letter:"
        '
        'lblLastLetter
        '
        Me.lblLastLetter.AutoSize = True
        Me.lblLastLetter.Location = New System.Drawing.Point(74, 109)
        Me.lblLastLetter.Name = "lblLastLetter"
        Me.lblLastLetter.Size = New System.Drawing.Size(0, 13)
        Me.lblLastLetter.TabIndex = 7
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(174, 109)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(81, 24)
        Me.btnData.TabIndex = 8
        Me.btnData.Text = "Display Data"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 158)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.lblLastLetter)
        Me.Controls.Add(Me.lblStatementLast)
        Me.Controls.Add(Me.lblMiddleLetter)
        Me.Controls.Add(Me.lblStatementMid)
        Me.Controls.Add(Me.lblFirstLetter)
        Me.Controls.Add(Me.lblStatementFirst)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.lblEnterText)
        Me.Name = "Form1"
        Me.Text = "String Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterText As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents lblStatementFirst As System.Windows.Forms.Label
    Friend WithEvents lblFirstLetter As System.Windows.Forms.Label
    Friend WithEvents lblStatementMid As System.Windows.Forms.Label
    Friend WithEvents lblMiddleLetter As System.Windows.Forms.Label
    Friend WithEvents lblStatementLast As System.Windows.Forms.Label
    Friend WithEvents lblLastLetter As System.Windows.Forms.Label
    Friend WithEvents btnData As System.Windows.Forms.Button

End Class
