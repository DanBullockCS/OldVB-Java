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
        Me.tmrSpaceTime = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBYE = New System.Windows.Forms.Label()
        Me.picSpace = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrSpaceTime
        '
        Me.tmrSpaceTime.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.SPACES
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(280, 203)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 161)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblBYE
        '
        Me.lblBYE.AutoSize = True
        Me.lblBYE.BackColor = System.Drawing.Color.Black
        Me.lblBYE.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBYE.ForeColor = System.Drawing.Color.Yellow
        Me.lblBYE.Image = Global.Graphics_Assignment_1.My.Resources.Resources.SpaceStars
        Me.lblBYE.Location = New System.Drawing.Point(149, 46)
        Me.lblBYE.Name = "lblBYE"
        Me.lblBYE.Size = New System.Drawing.Size(413, 74)
        Me.lblBYE.TabIndex = 1
        Me.lblBYE.Text = "Click on the spaceship" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " to fly into space"
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBYE)
        Me.Controls.Add(Me.picSpace)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Space?!??!?"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picSpace As System.Windows.Forms.PictureBox
    Friend WithEvents tmrSpaceTime As System.Windows.Forms.Timer
    Friend WithEvents lblBYE As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
