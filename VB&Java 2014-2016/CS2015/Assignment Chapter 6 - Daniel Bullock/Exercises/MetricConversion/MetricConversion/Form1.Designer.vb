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
        Me.lblEnterNumber = New System.Windows.Forms.Label()
        Me.txtEnteredNumber = New System.Windows.Forms.TextBox()
        Me.lblConvert = New System.Windows.Forms.Label()
        Me.btnItoC = New System.Windows.Forms.Button()
        Me.btnFtoC = New System.Windows.Forms.Button()
        Me.btnYtoM = New System.Windows.Forms.Button()
        Me.btnCtoF = New System.Windows.Forms.Button()
        Me.btnCtoI = New System.Windows.Forms.Button()
        Me.btnMtoK = New System.Windows.Forms.Button()
        Me.btnMtoY = New System.Windows.Forms.Button()
        Me.btnKtoM = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblEnterNumber
        '
        Me.lblEnterNumber.AutoSize = True
        Me.lblEnterNumber.Location = New System.Drawing.Point(86, 19)
        Me.lblEnterNumber.Name = "lblEnterNumber"
        Me.lblEnterNumber.Size = New System.Drawing.Size(82, 13)
        Me.lblEnterNumber.TabIndex = 0
        Me.lblEnterNumber.Text = "Enter a number:"
        '
        'txtEnteredNumber
        '
        Me.txtEnteredNumber.Location = New System.Drawing.Point(184, 16)
        Me.txtEnteredNumber.Name = "txtEnteredNumber"
        Me.txtEnteredNumber.Size = New System.Drawing.Size(86, 20)
        Me.txtEnteredNumber.TabIndex = 1
        '
        'lblConvert
        '
        Me.lblConvert.AutoSize = True
        Me.lblConvert.Location = New System.Drawing.Point(12, 59)
        Me.lblConvert.Name = "lblConvert"
        Me.lblConvert.Size = New System.Drawing.Size(47, 13)
        Me.lblConvert.TabIndex = 2
        Me.lblConvert.Text = "Convert:"
        '
        'btnItoC
        '
        Me.btnItoC.Location = New System.Drawing.Point(28, 75)
        Me.btnItoC.Name = "btnItoC"
        Me.btnItoC.Size = New System.Drawing.Size(122, 22)
        Me.btnItoC.TabIndex = 3
        Me.btnItoC.Text = "Inches to Centimeters"
        Me.btnItoC.UseVisualStyleBackColor = True
        '
        'btnFtoC
        '
        Me.btnFtoC.Location = New System.Drawing.Point(28, 123)
        Me.btnFtoC.Name = "btnFtoC"
        Me.btnFtoC.Size = New System.Drawing.Size(122, 22)
        Me.btnFtoC.TabIndex = 4
        Me.btnFtoC.Text = "Feet to Centimeters"
        Me.btnFtoC.UseVisualStyleBackColor = True
        '
        'btnYtoM
        '
        Me.btnYtoM.Location = New System.Drawing.Point(28, 171)
        Me.btnYtoM.Name = "btnYtoM"
        Me.btnYtoM.Size = New System.Drawing.Size(122, 22)
        Me.btnYtoM.TabIndex = 5
        Me.btnYtoM.Text = "Yards to Meters"
        Me.btnYtoM.UseVisualStyleBackColor = True
        '
        'btnCtoF
        '
        Me.btnCtoF.Location = New System.Drawing.Point(184, 123)
        Me.btnCtoF.Name = "btnCtoF"
        Me.btnCtoF.Size = New System.Drawing.Size(122, 22)
        Me.btnCtoF.TabIndex = 6
        Me.btnCtoF.Text = "Centimeters to Feet"
        Me.btnCtoF.UseVisualStyleBackColor = True
        '
        'btnCtoI
        '
        Me.btnCtoI.Location = New System.Drawing.Point(184, 75)
        Me.btnCtoI.Name = "btnCtoI"
        Me.btnCtoI.Size = New System.Drawing.Size(122, 22)
        Me.btnCtoI.TabIndex = 7
        Me.btnCtoI.Text = "Centimeters to Inches"
        Me.btnCtoI.UseVisualStyleBackColor = True
        '
        'btnMtoK
        '
        Me.btnMtoK.Location = New System.Drawing.Point(28, 221)
        Me.btnMtoK.Name = "btnMtoK"
        Me.btnMtoK.Size = New System.Drawing.Size(122, 22)
        Me.btnMtoK.TabIndex = 8
        Me.btnMtoK.Text = "Miles to Kilometers"
        Me.btnMtoK.UseVisualStyleBackColor = True
        '
        'btnMtoY
        '
        Me.btnMtoY.Location = New System.Drawing.Point(184, 171)
        Me.btnMtoY.Name = "btnMtoY"
        Me.btnMtoY.Size = New System.Drawing.Size(122, 22)
        Me.btnMtoY.TabIndex = 9
        Me.btnMtoY.Text = "Meters to Yards"
        Me.btnMtoY.UseVisualStyleBackColor = True
        '
        'btnKtoM
        '
        Me.btnKtoM.Location = New System.Drawing.Point(184, 221)
        Me.btnKtoM.Name = "btnKtoM"
        Me.btnKtoM.Size = New System.Drawing.Size(122, 22)
        Me.btnKtoM.TabIndex = 10
        Me.btnKtoM.Text = "Kilometers to Miles"
        Me.btnKtoM.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(95, 263)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 285)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnKtoM)
        Me.Controls.Add(Me.btnMtoY)
        Me.Controls.Add(Me.btnMtoK)
        Me.Controls.Add(Me.btnCtoI)
        Me.Controls.Add(Me.btnCtoF)
        Me.Controls.Add(Me.btnYtoM)
        Me.Controls.Add(Me.btnFtoC)
        Me.Controls.Add(Me.btnItoC)
        Me.Controls.Add(Me.lblConvert)
        Me.Controls.Add(Me.txtEnteredNumber)
        Me.Controls.Add(Me.lblEnterNumber)
        Me.Name = "Form1"
        Me.Text = "Metric Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterNumber As System.Windows.Forms.Label
    Friend WithEvents txtEnteredNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblConvert As System.Windows.Forms.Label
    Friend WithEvents btnItoC As System.Windows.Forms.Button
    Friend WithEvents btnFtoC As System.Windows.Forms.Button
    Friend WithEvents btnYtoM As System.Windows.Forms.Button
    Friend WithEvents btnCtoF As System.Windows.Forms.Button
    Friend WithEvents btnCtoI As System.Windows.Forms.Button
    Friend WithEvents btnMtoK As System.Windows.Forms.Button
    Friend WithEvents btnMtoY As System.Windows.Forms.Button
    Friend WithEvents btnKtoM As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
