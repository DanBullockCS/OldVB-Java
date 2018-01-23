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
        Me.txtEnterNumber = New System.Windows.Forms.TextBox()
        Me.lblEnterANumber = New System.Windows.Forms.Label()
        Me.btnCountNumerals = New System.Windows.Forms.Button()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtEnterNumber
        '
        Me.txtEnterNumber.Location = New System.Drawing.Point(100, 9)
        Me.txtEnterNumber.Name = "txtEnterNumber"
        Me.txtEnterNumber.Size = New System.Drawing.Size(170, 20)
        Me.txtEnterNumber.TabIndex = 0
        '
        'lblEnterANumber
        '
        Me.lblEnterANumber.AutoSize = True
        Me.lblEnterANumber.Location = New System.Drawing.Point(12, 12)
        Me.lblEnterANumber.Name = "lblEnterANumber"
        Me.lblEnterANumber.Size = New System.Drawing.Size(82, 13)
        Me.lblEnterANumber.TabIndex = 1
        Me.lblEnterANumber.Text = "Enter a number:"
        '
        'btnCountNumerals
        '
        Me.btnCountNumerals.Location = New System.Drawing.Point(141, 38)
        Me.btnCountNumerals.Name = "btnCountNumerals"
        Me.btnCountNumerals.Size = New System.Drawing.Size(129, 23)
        Me.btnCountNumerals.TabIndex = 2
        Me.btnCountNumerals.Text = "Count Numerals"
        Me.btnCountNumerals.UseVisualStyleBackColor = True
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.Location = New System.Drawing.Point(12, 38)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(109, 134)
        Me.lstNumbers.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 180)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.btnCountNumerals)
        Me.Controls.Add(Me.lblEnterANumber)
        Me.Controls.Add(Me.txtEnterNumber)
        Me.Name = "Form1"
        Me.Text = "Number Occurances"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEnterNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterANumber As System.Windows.Forms.Label
    Friend WithEvents btnCountNumerals As System.Windows.Forms.Button
    Friend WithEvents lstNumbers As System.Windows.Forms.ListBox

End Class
