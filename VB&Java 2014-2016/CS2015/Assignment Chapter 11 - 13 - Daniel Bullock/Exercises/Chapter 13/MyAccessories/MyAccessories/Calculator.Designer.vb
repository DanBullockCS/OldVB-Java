<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(18, 13)
        Me.txtDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(140, 20)
        Me.txtDisplay.TabIndex = 0
        Me.txtDisplay.Text = "0"
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(18, 51)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(40, 19)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(63, 51)
        Me.btnOff.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(40, 19)
        Me.btnOff.TabIndex = 2
        Me.btnOff.Text = "Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(18, 91)
        Me.btn7.Margin = New System.Windows.Forms.Padding(2)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(24, 19)
        Me.btn7.TabIndex = 3
        Me.btn7.Tag = "7"
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(46, 91)
        Me.btn8.Margin = New System.Windows.Forms.Padding(2)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(24, 19)
        Me.btn8.TabIndex = 4
        Me.btn8.Tag = "8"
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(75, 91)
        Me.btn9.Margin = New System.Windows.Forms.Padding(2)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(24, 19)
        Me.btn9.TabIndex = 5
        Me.btn9.Tag = "9"
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(18, 115)
        Me.btn4.Margin = New System.Windows.Forms.Padding(2)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(24, 19)
        Me.btn4.TabIndex = 6
        Me.btn4.Tag = "4"
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(46, 115)
        Me.btn5.Margin = New System.Windows.Forms.Padding(2)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(24, 19)
        Me.btn5.TabIndex = 7
        Me.btn5.Tag = "5"
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(75, 115)
        Me.btn6.Margin = New System.Windows.Forms.Padding(2)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(24, 19)
        Me.btn6.TabIndex = 8
        Me.btn6.Tag = "6"
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(18, 138)
        Me.btn1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(24, 19)
        Me.btn1.TabIndex = 9
        Me.btn1.Tag = "1"
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(46, 138)
        Me.btn2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(24, 19)
        Me.btn2.TabIndex = 10
        Me.btn2.Tag = "2"
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(75, 138)
        Me.btn3.Margin = New System.Windows.Forms.Padding(2)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(24, 19)
        Me.btn3.TabIndex = 11
        Me.btn3.Tag = "3"
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(18, 162)
        Me.btn0.Margin = New System.Windows.Forms.Padding(2)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(24, 19)
        Me.btn0.TabIndex = 12
        Me.btn0.Tag = "0"
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(46, 162)
        Me.btnDot.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(24, 19)
        Me.btnDot.TabIndex = 13
        Me.btnDot.Tag = "."
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(75, 162)
        Me.btnEqual.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(46, 19)
        Me.btnEqual.TabIndex = 14
        Me.btnEqual.Tag = "="
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(134, 51)
        Me.btnDivide.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(24, 19)
        Me.btnDivide.TabIndex = 15
        Me.btnDivide.Tag = "/"
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(134, 75)
        Me.btnTimes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(24, 19)
        Me.btnTimes.TabIndex = 16
        Me.btnTimes.Tag = "x"
        Me.btnTimes.Text = "x"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(134, 98)
        Me.btnMinus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(24, 19)
        Me.btnMinus.TabIndex = 17
        Me.btnMinus.Tag = "-"
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(134, 122)
        Me.btnPlus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(24, 58)
        Me.btnPlus.TabIndex = 18
        Me.btnPlus.Tag = "+"
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 197)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtDisplay)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Calculator"
        Me.Text = "Calculator II"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnDot As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnTimes As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button

End Class
