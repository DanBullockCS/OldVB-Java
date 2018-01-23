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
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lstRolls = New System.Windows.Forms.ListBox()
        Me.lblNumOfRolls = New System.Windows.Forms.Label()
        Me.txtRolls = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(155, 20)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(59, 23)
        Me.btnRoll.TabIndex = 0
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lstRolls
        '
        Me.lstRolls.FormattingEnabled = True
        Me.lstRolls.Location = New System.Drawing.Point(15, 61)
        Me.lstRolls.Name = "lstRolls"
        Me.lstRolls.Size = New System.Drawing.Size(117, 147)
        Me.lstRolls.TabIndex = 1
        '
        'lblNumOfRolls
        '
        Me.lblNumOfRolls.AutoSize = True
        Me.lblNumOfRolls.Location = New System.Drawing.Point(12, 25)
        Me.lblNumOfRolls.Name = "lblNumOfRolls"
        Me.lblNumOfRolls.Size = New System.Drawing.Size(80, 13)
        Me.lblNumOfRolls.TabIndex = 2
        Me.lblNumOfRolls.Text = "Number of rolls:"
        '
        'txtRolls
        '
        Me.txtRolls.Location = New System.Drawing.Point(99, 22)
        Me.txtRolls.Name = "txtRolls"
        Me.txtRolls.Size = New System.Drawing.Size(33, 20)
        Me.txtRolls.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 228)
        Me.Controls.Add(Me.txtRolls)
        Me.Controls.Add(Me.lblNumOfRolls)
        Me.Controls.Add(Me.lstRolls)
        Me.Controls.Add(Me.btnRoll)
        Me.Name = "Form1"
        Me.Text = "Dice Rolls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents lstRolls As System.Windows.Forms.ListBox
    Friend WithEvents lblNumOfRolls As System.Windows.Forms.Label
    Friend WithEvents txtRolls As System.Windows.Forms.TextBox

End Class
