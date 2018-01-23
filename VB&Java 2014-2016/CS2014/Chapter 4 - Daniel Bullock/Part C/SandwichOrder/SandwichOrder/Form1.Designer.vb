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
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.grpboxSize = New System.Windows.Forms.GroupBox()
        Me.radbtnLarge = New System.Windows.Forms.RadioButton()
        Me.radbtnSmall = New System.Windows.Forms.RadioButton()
        Me.grpboxFixings = New System.Windows.Forms.GroupBox()
        Me.chkMayonaise = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.lblPriceEquals = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.grpboxSize.SuspendLayout()
        Me.grpboxFixings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(189, 225)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(85, 25)
        Me.btnPlaceOrder.TabIndex = 0
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'grpboxSize
        '
        Me.grpboxSize.Controls.Add(Me.radbtnLarge)
        Me.grpboxSize.Controls.Add(Me.radbtnSmall)
        Me.grpboxSize.Location = New System.Drawing.Point(25, 12)
        Me.grpboxSize.Name = "grpboxSize"
        Me.grpboxSize.Size = New System.Drawing.Size(177, 56)
        Me.grpboxSize.TabIndex = 1
        Me.grpboxSize.TabStop = False
        Me.grpboxSize.Text = "Sandwich size"
        '
        'radbtnLarge
        '
        Me.radbtnLarge.AutoSize = True
        Me.radbtnLarge.Location = New System.Drawing.Point(108, 19)
        Me.radbtnLarge.Name = "radbtnLarge"
        Me.radbtnLarge.Size = New System.Drawing.Size(52, 17)
        Me.radbtnLarge.TabIndex = 6
        Me.radbtnLarge.TabStop = True
        Me.radbtnLarge.Text = "Large"
        Me.radbtnLarge.UseVisualStyleBackColor = True
        '
        'radbtnSmall
        '
        Me.radbtnSmall.AutoSize = True
        Me.radbtnSmall.Location = New System.Drawing.Point(23, 19)
        Me.radbtnSmall.Name = "radbtnSmall"
        Me.radbtnSmall.Size = New System.Drawing.Size(50, 17)
        Me.radbtnSmall.TabIndex = 5
        Me.radbtnSmall.TabStop = True
        Me.radbtnSmall.Text = "Small"
        Me.radbtnSmall.UseVisualStyleBackColor = True
        '
        'grpboxFixings
        '
        Me.grpboxFixings.Controls.Add(Me.chkMayonaise)
        Me.grpboxFixings.Controls.Add(Me.chkMustard)
        Me.grpboxFixings.Controls.Add(Me.chkCheese)
        Me.grpboxFixings.Controls.Add(Me.chkTomato)
        Me.grpboxFixings.Controls.Add(Me.chkOnion)
        Me.grpboxFixings.Controls.Add(Me.chkLettuce)
        Me.grpboxFixings.Location = New System.Drawing.Point(25, 91)
        Me.grpboxFixings.Name = "grpboxFixings"
        Me.grpboxFixings.Size = New System.Drawing.Size(258, 115)
        Me.grpboxFixings.TabIndex = 2
        Me.grpboxFixings.TabStop = False
        Me.grpboxFixings.Text = "Fixings"
        '
        'chkMayonaise
        '
        Me.chkMayonaise.AutoSize = True
        Me.chkMayonaise.Location = New System.Drawing.Point(177, 81)
        Me.chkMayonaise.Name = "chkMayonaise"
        Me.chkMayonaise.Size = New System.Drawing.Size(77, 17)
        Me.chkMayonaise.TabIndex = 6
        Me.chkMayonaise.Text = "Mayonaise"
        Me.chkMayonaise.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(177, 39)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(64, 17)
        Me.chkMustard.TabIndex = 5
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(96, 81)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 4
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(98, 39)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 3
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(11, 81)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(54, 17)
        Me.chkOnion.TabIndex = 2
        Me.chkOnion.Text = "Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(11, 39)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'lblPriceEquals
        '
        Me.lblPriceEquals.AutoSize = True
        Me.lblPriceEquals.Location = New System.Drawing.Point(33, 231)
        Me.lblPriceEquals.Name = "lblPriceEquals"
        Me.lblPriceEquals.Size = New System.Drawing.Size(67, 13)
        Me.lblPriceEquals.TabIndex = 3
        Me.lblPriceEquals.Text = "Total Price ="
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(106, 231)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalPrice.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 268)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblPriceEquals)
        Me.Controls.Add(Me.grpboxFixings)
        Me.Controls.Add(Me.grpboxSize)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Name = "Form1"
        Me.Text = "Sandwich Order"
        Me.grpboxSize.ResumeLayout(False)
        Me.grpboxSize.PerformLayout()
        Me.grpboxFixings.ResumeLayout(False)
        Me.grpboxFixings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents grpboxSize As System.Windows.Forms.GroupBox
    Friend WithEvents radbtnLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnSmall As System.Windows.Forms.RadioButton
    Friend WithEvents grpboxFixings As System.Windows.Forms.GroupBox
    Friend WithEvents chkMayonaise As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnion As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents lblPriceEquals As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label

End Class
