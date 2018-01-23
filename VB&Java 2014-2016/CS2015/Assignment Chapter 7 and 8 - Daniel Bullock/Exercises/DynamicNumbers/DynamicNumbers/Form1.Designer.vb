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
        Me.lstArray = New System.Windows.Forms.ListBox()
        Me.btnCreateArray = New System.Windows.Forms.Button()
        Me.lblEnterSize = New System.Windows.Forms.Label()
        Me.txtEnterSize = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstArray
        '
        Me.lstArray.FormattingEnabled = True
        Me.lstArray.Location = New System.Drawing.Point(27, 90)
        Me.lstArray.Name = "lstArray"
        Me.lstArray.Size = New System.Drawing.Size(179, 173)
        Me.lstArray.TabIndex = 0
        '
        'btnCreateArray
        '
        Me.btnCreateArray.Location = New System.Drawing.Point(62, 50)
        Me.btnCreateArray.Name = "btnCreateArray"
        Me.btnCreateArray.Size = New System.Drawing.Size(97, 24)
        Me.btnCreateArray.TabIndex = 1
        Me.btnCreateArray.Text = "Create Array"
        Me.btnCreateArray.UseVisualStyleBackColor = True
        '
        'lblEnterSize
        '
        Me.lblEnterSize.AutoSize = True
        Me.lblEnterSize.Location = New System.Drawing.Point(24, 21)
        Me.lblEnterSize.Name = "lblEnterSize"
        Me.lblEnterSize.Size = New System.Drawing.Size(112, 13)
        Me.lblEnterSize.TabIndex = 2
        Me.lblEnterSize.Text = "Enter size of the array:"
        '
        'txtEnterSize
        '
        Me.txtEnterSize.Location = New System.Drawing.Point(142, 18)
        Me.txtEnterSize.Name = "txtEnterSize"
        Me.txtEnterSize.Size = New System.Drawing.Size(44, 20)
        Me.txtEnterSize.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 288)
        Me.Controls.Add(Me.txtEnterSize)
        Me.Controls.Add(Me.lblEnterSize)
        Me.Controls.Add(Me.btnCreateArray)
        Me.Controls.Add(Me.lstArray)
        Me.Name = "Form1"
        Me.Text = "Dynamic Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstArray As System.Windows.Forms.ListBox
    Friend WithEvents btnCreateArray As System.Windows.Forms.Button
    Friend WithEvents lblEnterSize As System.Windows.Forms.Label
    Friend WithEvents txtEnterSize As System.Windows.Forms.TextBox

End Class
