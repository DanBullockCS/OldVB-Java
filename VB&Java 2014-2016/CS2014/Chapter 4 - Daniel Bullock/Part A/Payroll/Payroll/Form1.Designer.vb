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
        Me.btnPay = New System.Windows.Forms.Button()
        Me.txtboxHoursWorked = New System.Windows.Forms.TextBox()
        Me.txtboxHourlyRate = New System.Windows.Forms.TextBox()
        Me.lblWorked = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblGrossWages = New System.Windows.Forms.Label()
        Me.grpboxTaxes = New System.Windows.Forms.GroupBox()
        Me.radbtnNo = New System.Windows.Forms.RadioButton()
        Me.radbtnYes = New System.Windows.Forms.RadioButton()
        Me.lblNoTaxDeductions = New System.Windows.Forms.Label()
        Me.grpboxTaxes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(165, 184)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 24)
        Me.btnPay.TabIndex = 0
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'txtboxHoursWorked
        '
        Me.txtboxHoursWorked.Location = New System.Drawing.Point(145, 25)
        Me.txtboxHoursWorked.Name = "txtboxHoursWorked"
        Me.txtboxHoursWorked.Size = New System.Drawing.Size(45, 20)
        Me.txtboxHoursWorked.TabIndex = 1
        '
        'txtboxHourlyRate
        '
        Me.txtboxHourlyRate.Location = New System.Drawing.Point(118, 60)
        Me.txtboxHourlyRate.Name = "txtboxHourlyRate"
        Me.txtboxHourlyRate.Size = New System.Drawing.Size(45, 20)
        Me.txtboxHourlyRate.TabIndex = 2
        '
        'lblWorked
        '
        Me.lblWorked.AutoSize = True
        Me.lblWorked.Location = New System.Drawing.Point(26, 28)
        Me.lblWorked.Name = "lblWorked"
        Me.lblWorked.Size = New System.Drawing.Size(102, 13)
        Me.lblWorked.TabIndex = 3
        Me.lblWorked.Text = "Enter hours worked:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(26, 63)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(87, 13)
        Me.lblRate.TabIndex = 4
        Me.lblRate.Text = "Enter hourly rate:"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(12, 160)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(86, 13)
        Me.lblGross.TabIndex = 5
        Me.lblGross.Text = "Gross wages = $"
        '
        'lblGrossWages
        '
        Me.lblGrossWages.AutoSize = True
        Me.lblGrossWages.Location = New System.Drawing.Point(101, 160)
        Me.lblGrossWages.Name = "lblGrossWages"
        Me.lblGrossWages.Size = New System.Drawing.Size(0, 13)
        Me.lblGrossWages.TabIndex = 6
        '
        'grpboxTaxes
        '
        Me.grpboxTaxes.Controls.Add(Me.radbtnNo)
        Me.grpboxTaxes.Controls.Add(Me.radbtnYes)
        Me.grpboxTaxes.Location = New System.Drawing.Point(21, 94)
        Me.grpboxTaxes.Name = "grpboxTaxes"
        Me.grpboxTaxes.Size = New System.Drawing.Size(142, 54)
        Me.grpboxTaxes.TabIndex = 7
        Me.grpboxTaxes.TabStop = False
        Me.grpboxTaxes.Text = "Exempt from taxes?"
        '
        'radbtnNo
        '
        Me.radbtnNo.AutoSize = True
        Me.radbtnNo.Location = New System.Drawing.Point(82, 19)
        Me.radbtnNo.Name = "radbtnNo"
        Me.radbtnNo.Size = New System.Drawing.Size(39, 17)
        Me.radbtnNo.TabIndex = 1
        Me.radbtnNo.TabStop = True
        Me.radbtnNo.Text = "No"
        Me.radbtnNo.UseVisualStyleBackColor = True
        '
        'radbtnYes
        '
        Me.radbtnYes.AutoSize = True
        Me.radbtnYes.Location = New System.Drawing.Point(14, 19)
        Me.radbtnYes.Name = "radbtnYes"
        Me.radbtnYes.Size = New System.Drawing.Size(43, 17)
        Me.radbtnYes.TabIndex = 0
        Me.radbtnYes.TabStop = True
        Me.radbtnYes.Text = "Yes"
        Me.radbtnYes.UseVisualStyleBackColor = True
        '
        'lblNoTaxDeductions
        '
        Me.lblNoTaxDeductions.AutoSize = True
        Me.lblNoTaxDeductions.Location = New System.Drawing.Point(18, 198)
        Me.lblNoTaxDeductions.Name = "lblNoTaxDeductions"
        Me.lblNoTaxDeductions.Size = New System.Drawing.Size(0, 13)
        Me.lblNoTaxDeductions.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 220)
        Me.Controls.Add(Me.lblNoTaxDeductions)
        Me.Controls.Add(Me.grpboxTaxes)
        Me.Controls.Add(Me.lblGrossWages)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblWorked)
        Me.Controls.Add(Me.txtboxHourlyRate)
        Me.Controls.Add(Me.txtboxHoursWorked)
        Me.Controls.Add(Me.btnPay)
        Me.Name = "Form1"
        Me.Text = "Payroll"
        Me.grpboxTaxes.ResumeLayout(False)
        Me.grpboxTaxes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents txtboxHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents txtboxHourlyRate As System.Windows.Forms.TextBox
    Friend WithEvents lblWorked As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents lblGrossWages As System.Windows.Forms.Label
    Friend WithEvents grpboxTaxes As System.Windows.Forms.GroupBox
    Friend WithEvents radbtnNo As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblNoTaxDeductions As System.Windows.Forms.Label

End Class
