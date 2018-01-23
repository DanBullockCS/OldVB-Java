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
        Me.txtboxInches = New System.Windows.Forms.TextBox()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtboxInches
        '
        Me.txtboxInches.Location = New System.Drawing.Point(225, 21)
        Me.txtboxInches.Name = "txtboxInches"
        Me.txtboxInches.Size = New System.Drawing.Size(48, 20)
        Me.txtboxInches.TabIndex = 0
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Location = New System.Drawing.Point(25, 21)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(176, 13)
        Me.lblInches.TabIndex = 1
        Me.lblInches.Text = "Enter the siza of the pizza in inches:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(26, 54)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(148, 13)
        Me.lblTotalCost.TabIndex = 2
        Me.lblTotalCost.Text = "The total cost of the pizza is $"
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.SystemColors.Control
        Me.btnCost.Location = New System.Drawing.Point(102, 92)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(78, 23)
        Me.btnCost.TabIndex = 3
        Me.btnCost.Text = "Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(180, 54)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 127)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.txtboxInches)
        Me.Name = "Form1"
        Me.Text = "Pizza Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxInches As System.Windows.Forms.TextBox
    Friend WithEvents lblInches As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents btnCost As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
