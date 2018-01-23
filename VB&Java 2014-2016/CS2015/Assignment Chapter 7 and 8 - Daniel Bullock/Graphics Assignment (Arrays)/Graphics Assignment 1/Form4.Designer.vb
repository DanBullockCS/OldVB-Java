<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.picSpace = New System.Windows.Forms.PictureBox()
        Me.tmrSpaceTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSpace
        '
        Me.picSpace.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.SpaceStars
        Me.picSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSpace.Location = New System.Drawing.Point(-1, -2)
        Me.picSpace.Name = "picSpace"
        Me.picSpace.Size = New System.Drawing.Size(732, 465)
        Me.picSpace.TabIndex = 0
        Me.picSpace.TabStop = False
        '
        'tmrSpaceTime
        '
        Me.tmrSpaceTime.Enabled = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 462)
        Me.Controls.Add(Me.picSpace)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Space?!??!?"
        CType(Me.picSpace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picSpace As System.Windows.Forms.PictureBox
    Friend WithEvents tmrSpaceTime As System.Windows.Forms.Timer
End Class
