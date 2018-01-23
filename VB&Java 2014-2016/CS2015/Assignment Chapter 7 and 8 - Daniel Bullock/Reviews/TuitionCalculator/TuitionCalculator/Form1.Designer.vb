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
        Me.lblCourseLevelList = New System.Windows.Forms.Label()
        Me.lblTuition = New System.Windows.Forms.Label()
        Me.lstCourseLevels = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCreditHours = New System.Windows.Forms.Label()
        Me.cboCreditHours = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCourseLevelList
        '
        Me.lblCourseLevelList.AutoSize = True
        Me.lblCourseLevelList.Location = New System.Drawing.Point(23, 19)
        Me.lblCourseLevelList.Name = "lblCourseLevelList"
        Me.lblCourseLevelList.Size = New System.Drawing.Size(72, 13)
        Me.lblCourseLevelList.TabIndex = 5
        Me.lblCourseLevelList.Text = "Course Level:"
        '
        'lblTuition
        '
        Me.lblTuition.Location = New System.Drawing.Point(35, 121)
        Me.lblTuition.Name = "lblTuition"
        Me.lblTuition.Size = New System.Drawing.Size(296, 51)
        Me.lblTuition.TabIndex = 4
        '
        'lstCourseLevels
        '
        Me.lstCourseLevels.FormattingEnabled = True
        Me.lstCourseLevels.Items.AddRange(New Object() {"Undergraduate", "Graduate", "Thesis and Dissertation"})
        Me.lstCourseLevels.Location = New System.Drawing.Point(26, 35)
        Me.lstCourseLevels.Name = "lstCourseLevels"
        Me.lstCourseLevels.Size = New System.Drawing.Size(185, 56)
        Me.lstCourseLevels.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(250, 69)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(81, 22)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCreditHours
        '
        Me.lblCreditHours.AutoSize = True
        Me.lblCreditHours.Location = New System.Drawing.Point(247, 19)
        Me.lblCreditHours.Name = "lblCreditHours"
        Me.lblCreditHours.Size = New System.Drawing.Size(68, 13)
        Me.lblCreditHours.TabIndex = 6
        Me.lblCreditHours.Text = "Credit Hours:"
        '
        'cboCreditHours
        '
        Me.cboCreditHours.FormattingEnabled = True
        Me.cboCreditHours.Location = New System.Drawing.Point(250, 35)
        Me.cboCreditHours.Name = "cboCreditHours"
        Me.cboCreditHours.Size = New System.Drawing.Size(46, 21)
        Me.cboCreditHours.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 190)
        Me.Controls.Add(Me.cboCreditHours)
        Me.Controls.Add(Me.lblCreditHours)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstCourseLevels)
        Me.Controls.Add(Me.lblTuition)
        Me.Controls.Add(Me.lblCourseLevelList)
        Me.Name = "Form1"
        Me.Text = "Tuition Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCourseLevelList As System.Windows.Forms.Label
    Friend WithEvents lblTuition As System.Windows.Forms.Label
    Friend WithEvents lstCourseLevels As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblCreditHours As System.Windows.Forms.Label
    Friend WithEvents cboCreditHours As System.Windows.Forms.ComboBox

End Class
