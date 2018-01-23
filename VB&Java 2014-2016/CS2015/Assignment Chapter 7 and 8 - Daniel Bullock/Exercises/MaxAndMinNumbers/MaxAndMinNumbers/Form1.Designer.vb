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
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.lblMaxOrMinNum = New System.Windows.Forms.Label()
        Me.btnNumbers = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.Location = New System.Drawing.Point(12, 13)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(157, 212)
        Me.lstNumbers.TabIndex = 0
        '
        'lblMaxOrMinNum
        '
        Me.lblMaxOrMinNum.AutoSize = True
        Me.lblMaxOrMinNum.Location = New System.Drawing.Point(186, 151)
        Me.lblMaxOrMinNum.Name = "lblMaxOrMinNum"
        Me.lblMaxOrMinNum.Size = New System.Drawing.Size(0, 13)
        Me.lblMaxOrMinNum.TabIndex = 2
        '
        'btnNumbers
        '
        Me.btnNumbers.Location = New System.Drawing.Point(200, 27)
        Me.btnNumbers.Name = "btnNumbers"
        Me.btnNumbers.Size = New System.Drawing.Size(75, 23)
        Me.btnNumbers.TabIndex = 3
        Me.btnNumbers.Text = "Numbers"
        Me.btnNumbers.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(200, 56)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(75, 23)
        Me.btnMax.TabIndex = 4
        Me.btnMax.Text = "Max"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Location = New System.Drawing.Point(200, 85)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(75, 23)
        Me.btnMin.TabIndex = 5
        Me.btnMin.Text = "Min"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 241)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnNumbers)
        Me.Controls.Add(Me.lblMaxOrMinNum)
        Me.Controls.Add(Me.lstNumbers)
        Me.Name = "Form1"
        Me.Text = "Max And Min Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstNumbers As System.Windows.Forms.ListBox
    Friend WithEvents lblMaxOrMinNum As System.Windows.Forms.Label
    Friend WithEvents btnNumbers As System.Windows.Forms.Button
    Friend WithEvents btnMax As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button

End Class
