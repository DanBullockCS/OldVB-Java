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
        Me.picRooster = New System.Windows.Forms.PictureBox()
        CType(Me.picRooster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picRooster
        '
        Me.picRooster.Image = Global.Wake_Up.My.Resources.Resources.rooster
        Me.picRooster.Location = New System.Drawing.Point(22, 12)
        Me.picRooster.Name = "picRooster"
        Me.picRooster.Size = New System.Drawing.Size(120, 150)
        Me.picRooster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRooster.TabIndex = 0
        Me.picRooster.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(211, 170)
        Me.Controls.Add(Me.picRooster)
        Me.Name = "Form1"
        Me.Text = "Wake Up"
        CType(Me.picRooster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRooster As System.Windows.Forms.PictureBox

End Class
