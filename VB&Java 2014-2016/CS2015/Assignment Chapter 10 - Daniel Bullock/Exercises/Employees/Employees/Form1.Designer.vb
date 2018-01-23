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
        Me.grpAddEmployee = New System.Windows.Forms.GroupBox()
        Me.btnEmployeeNumAndNames = New System.Windows.Forms.Button()
        Me.btnEmployeeNumOnly = New System.Windows.Forms.Button()
        Me.lblEnterEmployeeNumber = New System.Windows.Forms.Label()
        Me.txtEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.grpUpdateEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.btnLastName = New System.Windows.Forms.Button()
        Me.btnFirstName = New System.Windows.Forms.Button()
        Me.btnOvertimeHours = New System.Windows.Forms.Button()
        Me.btnRegularHours = New System.Windows.Forms.Button()
        Me.btnHourlyRate = New System.Windows.Forms.Button()
        Me.btnDisplayInfo = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.btnPaycheck = New System.Windows.Forms.Button()
        Me.grpAddEmployee.SuspendLayout()
        Me.grpUpdateEmployeeInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAddEmployee
        '
        Me.grpAddEmployee.Controls.Add(Me.btnEmployeeNumAndNames)
        Me.grpAddEmployee.Controls.Add(Me.btnEmployeeNumOnly)
        Me.grpAddEmployee.Location = New System.Drawing.Point(26, 24)
        Me.grpAddEmployee.Name = "grpAddEmployee"
        Me.grpAddEmployee.Size = New System.Drawing.Size(435, 65)
        Me.grpAddEmployee.TabIndex = 0
        Me.grpAddEmployee.TabStop = False
        Me.grpAddEmployee.Text = "Add New Employee"
        '
        'btnEmployeeNumAndNames
        '
        Me.btnEmployeeNumAndNames.Location = New System.Drawing.Point(253, 24)
        Me.btnEmployeeNumAndNames.Name = "btnEmployeeNumAndNames"
        Me.btnEmployeeNumAndNames.Size = New System.Drawing.Size(138, 23)
        Me.btnEmployeeNumAndNames.TabIndex = 1
        Me.btnEmployeeNumAndNames.Tag = "Employee#andnames"
        Me.btnEmployeeNumAndNames.Text = "Employee # and names"
        Me.btnEmployeeNumAndNames.UseVisualStyleBackColor = True
        '
        'btnEmployeeNumOnly
        '
        Me.btnEmployeeNumOnly.Location = New System.Drawing.Point(41, 24)
        Me.btnEmployeeNumOnly.Name = "btnEmployeeNumOnly"
        Me.btnEmployeeNumOnly.Size = New System.Drawing.Size(138, 23)
        Me.btnEmployeeNumOnly.TabIndex = 0
        Me.btnEmployeeNumOnly.Tag = "Employee#only"
        Me.btnEmployeeNumOnly.Text = "Employee # only"
        Me.btnEmployeeNumOnly.UseVisualStyleBackColor = True
        '
        'lblEnterEmployeeNumber
        '
        Me.lblEnterEmployeeNumber.AutoSize = True
        Me.lblEnterEmployeeNumber.Location = New System.Drawing.Point(93, 109)
        Me.lblEnterEmployeeNumber.Name = "lblEnterEmployeeNumber"
        Me.lblEnterEmployeeNumber.Size = New System.Drawing.Size(124, 13)
        Me.lblEnterEmployeeNumber.TabIndex = 1
        Me.lblEnterEmployeeNumber.Text = "Enter Employee Number:"
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(230, 106)
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(135, 20)
        Me.txtEmployeeNumber.TabIndex = 2
        '
        'grpUpdateEmployeeInfo
        '
        Me.grpUpdateEmployeeInfo.Controls.Add(Me.btnLastName)
        Me.grpUpdateEmployeeInfo.Controls.Add(Me.btnFirstName)
        Me.grpUpdateEmployeeInfo.Controls.Add(Me.btnOvertimeHours)
        Me.grpUpdateEmployeeInfo.Controls.Add(Me.btnRegularHours)
        Me.grpUpdateEmployeeInfo.Controls.Add(Me.btnHourlyRate)
        Me.grpUpdateEmployeeInfo.Location = New System.Drawing.Point(26, 143)
        Me.grpUpdateEmployeeInfo.Name = "grpUpdateEmployeeInfo"
        Me.grpUpdateEmployeeInfo.Size = New System.Drawing.Size(249, 201)
        Me.grpUpdateEmployeeInfo.TabIndex = 1
        Me.grpUpdateEmployeeInfo.TabStop = False
        Me.grpUpdateEmployeeInfo.Text = "Update Employee Information"
        '
        'btnLastName
        '
        Me.btnLastName.Location = New System.Drawing.Point(6, 121)
        Me.btnLastName.Name = "btnLastName"
        Me.btnLastName.Size = New System.Drawing.Size(90, 23)
        Me.btnLastName.TabIndex = 10
        Me.btnLastName.Tag = "Lastname"
        Me.btnLastName.Text = "Last Name"
        Me.btnLastName.UseVisualStyleBackColor = True
        '
        'btnFirstName
        '
        Me.btnFirstName.Location = New System.Drawing.Point(6, 55)
        Me.btnFirstName.Name = "btnFirstName"
        Me.btnFirstName.Size = New System.Drawing.Size(90, 23)
        Me.btnFirstName.TabIndex = 9
        Me.btnFirstName.Tag = "Firstname"
        Me.btnFirstName.Text = "First Name"
        Me.btnFirstName.UseVisualStyleBackColor = True
        '
        'btnOvertimeHours
        '
        Me.btnOvertimeHours.Location = New System.Drawing.Point(132, 155)
        Me.btnOvertimeHours.Name = "btnOvertimeHours"
        Me.btnOvertimeHours.Size = New System.Drawing.Size(101, 23)
        Me.btnOvertimeHours.TabIndex = 8
        Me.btnOvertimeHours.Tag = "Overtime"
        Me.btnOvertimeHours.Text = "Overtime Hours"
        Me.btnOvertimeHours.UseVisualStyleBackColor = True
        '
        'btnRegularHours
        '
        Me.btnRegularHours.Location = New System.Drawing.Point(132, 88)
        Me.btnRegularHours.Name = "btnRegularHours"
        Me.btnRegularHours.Size = New System.Drawing.Size(101, 23)
        Me.btnRegularHours.TabIndex = 7
        Me.btnRegularHours.Tag = "Regularhours"
        Me.btnRegularHours.Text = "Regular Hours"
        Me.btnRegularHours.UseVisualStyleBackColor = True
        '
        'btnHourlyRate
        '
        Me.btnHourlyRate.Location = New System.Drawing.Point(132, 19)
        Me.btnHourlyRate.Name = "btnHourlyRate"
        Me.btnHourlyRate.Size = New System.Drawing.Size(101, 23)
        Me.btnHourlyRate.TabIndex = 6
        Me.btnHourlyRate.Tag = "Hourlyrate"
        Me.btnHourlyRate.Text = "Hourly Rate"
        Me.btnHourlyRate.UseVisualStyleBackColor = True
        '
        'btnDisplayInfo
        '
        Me.btnDisplayInfo.Location = New System.Drawing.Point(348, 143)
        Me.btnDisplayInfo.Name = "btnDisplayInfo"
        Me.btnDisplayInfo.Size = New System.Drawing.Size(80, 23)
        Me.btnDisplayInfo.TabIndex = 2
        Me.btnDisplayInfo.Tag = "Displayinfo"
        Me.btnDisplayInfo.Text = "Display Info"
        Me.btnDisplayInfo.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(335, 198)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 3
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(365, 337)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(0, 13)
        Me.lblMoney.TabIndex = 4
        '
        'btnPaycheck
        '
        Me.btnPaycheck.Location = New System.Drawing.Point(348, 298)
        Me.btnPaycheck.Name = "btnPaycheck"
        Me.btnPaycheck.Size = New System.Drawing.Size(80, 23)
        Me.btnPaycheck.TabIndex = 5
        Me.btnPaycheck.Tag = "Paycheck"
        Me.btnPaycheck.Text = "Paycheck"
        Me.btnPaycheck.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 373)
        Me.Controls.Add(Me.btnPaycheck)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnDisplayInfo)
        Me.Controls.Add(Me.grpUpdateEmployeeInfo)
        Me.Controls.Add(Me.txtEmployeeNumber)
        Me.Controls.Add(Me.lblEnterEmployeeNumber)
        Me.Controls.Add(Me.grpAddEmployee)
        Me.Name = "Form1"
        Me.Text = "Employees"
        Me.grpAddEmployee.ResumeLayout(False)
        Me.grpUpdateEmployeeInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpAddEmployee As System.Windows.Forms.GroupBox
    Friend WithEvents btnEmployeeNumAndNames As System.Windows.Forms.Button
    Friend WithEvents btnEmployeeNumOnly As System.Windows.Forms.Button
    Friend WithEvents lblEnterEmployeeNumber As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeNumber As System.Windows.Forms.TextBox
    Friend WithEvents grpUpdateEmployeeInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnLastName As System.Windows.Forms.Button
    Friend WithEvents btnFirstName As System.Windows.Forms.Button
    Friend WithEvents btnOvertimeHours As System.Windows.Forms.Button
    Friend WithEvents btnRegularHours As System.Windows.Forms.Button
    Friend WithEvents btnHourlyRate As System.Windows.Forms.Button
    Friend WithEvents btnDisplayInfo As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents btnPaycheck As System.Windows.Forms.Button

End Class
