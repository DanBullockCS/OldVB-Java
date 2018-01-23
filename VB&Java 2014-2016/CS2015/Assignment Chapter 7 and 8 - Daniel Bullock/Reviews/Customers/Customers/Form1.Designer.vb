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
        Me.btnCustomerInfo = New System.Windows.Forms.Button()
        Me.lblHighestAccount = New System.Windows.Forms.Label()
        Me.lblAverageAccount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCustomerInfo
        '
        Me.btnCustomerInfo.Location = New System.Drawing.Point(61, 12)
        Me.btnCustomerInfo.Name = "btnCustomerInfo"
        Me.btnCustomerInfo.Size = New System.Drawing.Size(156, 23)
        Me.btnCustomerInfo.TabIndex = 0
        Me.btnCustomerInfo.Text = "Enter Customer Information"
        Me.btnCustomerInfo.UseVisualStyleBackColor = True
        '
        'lblHighestAccount
        '
        Me.lblHighestAccount.AutoSize = True
        Me.lblHighestAccount.Location = New System.Drawing.Point(35, 66)
        Me.lblHighestAccount.Name = "lblHighestAccount"
        Me.lblHighestAccount.Size = New System.Drawing.Size(0, 13)
        Me.lblHighestAccount.TabIndex = 1
        '
        'lblAverageAccount
        '
        Me.lblAverageAccount.AutoSize = True
        Me.lblAverageAccount.Location = New System.Drawing.Point(35, 124)
        Me.lblAverageAccount.Name = "lblAverageAccount"
        Me.lblAverageAccount.Size = New System.Drawing.Size(0, 13)
        Me.lblAverageAccount.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 171)
        Me.Controls.Add(Me.lblAverageAccount)
        Me.Controls.Add(Me.lblHighestAccount)
        Me.Controls.Add(Me.btnCustomerInfo)
        Me.Name = "Form1"
        Me.Text = "Customers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCustomerInfo As System.Windows.Forms.Button
    Friend WithEvents lblHighestAccount As System.Windows.Forms.Label
    Friend WithEvents lblAverageAccount As System.Windows.Forms.Label

End Class
