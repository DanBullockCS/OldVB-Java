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
        Me.lblEnterNumberOfCopies = New System.Windows.Forms.Label()
        Me.txtboxCopies = New System.Windows.Forms.TextBox()
        Me.lblPricePerCopy = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblPricePerCopyAnswer = New System.Windows.Forms.Label()
        Me.lblTotalPriceAnswer = New System.Windows.Forms.Label()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterNumberOfCopies
        '
        Me.lblEnterNumberOfCopies.AutoSize = True
        Me.lblEnterNumberOfCopies.Location = New System.Drawing.Point(21, 24)
        Me.lblEnterNumberOfCopies.Name = "lblEnterNumberOfCopies"
        Me.lblEnterNumberOfCopies.Size = New System.Drawing.Size(137, 13)
        Me.lblEnterNumberOfCopies.TabIndex = 0
        Me.lblEnterNumberOfCopies.Text = "Enter the number of copies:"
        '
        'txtboxCopies
        '
        Me.txtboxCopies.Location = New System.Drawing.Point(164, 21)
        Me.txtboxCopies.Name = "txtboxCopies"
        Me.txtboxCopies.Size = New System.Drawing.Size(40, 20)
        Me.txtboxCopies.TabIndex = 1
        '
        'lblPricePerCopy
        '
        Me.lblPricePerCopy.AutoSize = True
        Me.lblPricePerCopy.Location = New System.Drawing.Point(19, 64)
        Me.lblPricePerCopy.Name = "lblPricePerCopy"
        Me.lblPricePerCopy.Size = New System.Drawing.Size(94, 13)
        Me.lblPricePerCopy.TabIndex = 2
        Me.lblPricePerCopy.Text = "Price per copy is $"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(19, 108)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(94, 13)
        Me.lblTotalPrice.TabIndex = 3
        Me.lblTotalPrice.Text = "The total price is $"
        '
        'lblPricePerCopyAnswer
        '
        Me.lblPricePerCopyAnswer.AutoSize = True
        Me.lblPricePerCopyAnswer.Location = New System.Drawing.Point(119, 64)
        Me.lblPricePerCopyAnswer.Name = "lblPricePerCopyAnswer"
        Me.lblPricePerCopyAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblPricePerCopyAnswer.TabIndex = 4
        '
        'lblTotalPriceAnswer
        '
        Me.lblTotalPriceAnswer.AutoSize = True
        Me.lblTotalPriceAnswer.Location = New System.Drawing.Point(119, 108)
        Me.lblTotalPriceAnswer.Name = "lblTotalPriceAnswer"
        Me.lblTotalPriceAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalPriceAnswer.TabIndex = 5
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(180, 108)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(75, 20)
        Me.btnPrice.TabIndex = 6
        Me.btnPrice.Text = "Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 140)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.lblTotalPriceAnswer)
        Me.Controls.Add(Me.lblPricePerCopyAnswer)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblPricePerCopy)
        Me.Controls.Add(Me.txtboxCopies)
        Me.Controls.Add(Me.lblEnterNumberOfCopies)
        Me.Name = "Form1"
        Me.Text = "Printing Prices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterNumberOfCopies As System.Windows.Forms.Label
    Friend WithEvents txtboxCopies As System.Windows.Forms.TextBox
    Friend WithEvents lblPricePerCopy As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblPricePerCopyAnswer As System.Windows.Forms.Label
    Friend WithEvents lblTotalPriceAnswer As System.Windows.Forms.Label
    Friend WithEvents btnPrice As System.Windows.Forms.Button

End Class
