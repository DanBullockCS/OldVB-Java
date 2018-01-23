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
        Me.components = New System.ComponentModel.Container()
        Me.picMouseCursor = New System.Windows.Forms.PictureBox()
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.PicVirus = New System.Windows.Forms.PictureBox()
        Me.tmrVirus = New System.Windows.Forms.Timer(Me.components)
        Me.lblSecurityLevelStatement = New System.Windows.Forms.Label()
        Me.lblSecurityLevelNumber = New System.Windows.Forms.Label()
        Me.tmrNorton = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeStatement = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PicNorton = New System.Windows.Forms.PictureBox()
        CType(Me.picMouseCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVirus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNorton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMouseCursor
        '
        Me.picMouseCursor.BackColor = System.Drawing.Color.Transparent
        Me.picMouseCursor.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Mouse_Cursor_copy
        Me.picMouseCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMouseCursor.Location = New System.Drawing.Point(464, 245)
        Me.picMouseCursor.Name = "picMouseCursor"
        Me.picMouseCursor.Size = New System.Drawing.Size(71, 60)
        Me.picMouseCursor.TabIndex = 0
        Me.picMouseCursor.TabStop = False
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 1
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 1
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 1
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 1
        '
        'PicVirus
        '
        Me.PicVirus.BackColor = System.Drawing.Color.Transparent
        Me.PicVirus.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Computer_Virus_Image
        Me.PicVirus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicVirus.Location = New System.Drawing.Point(954, 551)
        Me.PicVirus.Name = "PicVirus"
        Me.PicVirus.Size = New System.Drawing.Size(84, 84)
        Me.PicVirus.TabIndex = 1
        Me.PicVirus.TabStop = False
        '
        'tmrVirus
        '
        Me.tmrVirus.Enabled = True
        Me.tmrVirus.Interval = 15
        '
        'lblSecurityLevelStatement
        '
        Me.lblSecurityLevelStatement.AutoSize = True
        Me.lblSecurityLevelStatement.BackColor = System.Drawing.Color.Transparent
        Me.lblSecurityLevelStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecurityLevelStatement.ForeColor = System.Drawing.Color.Red
        Me.lblSecurityLevelStatement.Location = New System.Drawing.Point(0, 485)
        Me.lblSecurityLevelStatement.Name = "lblSecurityLevelStatement"
        Me.lblSecurityLevelStatement.Size = New System.Drawing.Size(199, 31)
        Me.lblSecurityLevelStatement.TabIndex = 2
        Me.lblSecurityLevelStatement.Text = "Security Level"
        '
        'lblSecurityLevelNumber
        '
        Me.lblSecurityLevelNumber.AutoSize = True
        Me.lblSecurityLevelNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSecurityLevelNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecurityLevelNumber.ForeColor = System.Drawing.Color.Red
        Me.lblSecurityLevelNumber.Location = New System.Drawing.Point(82, 522)
        Me.lblSecurityLevelNumber.Name = "lblSecurityLevelNumber"
        Me.lblSecurityLevelNumber.Size = New System.Drawing.Size(0, 31)
        Me.lblSecurityLevelNumber.TabIndex = 3
        '
        'tmrNorton
        '
        Me.tmrNorton.Enabled = True
        Me.tmrNorton.Interval = 1000
        '
        'lblTimeStatement
        '
        Me.lblTimeStatement.AutoSize = True
        Me.lblTimeStatement.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeStatement.ForeColor = System.Drawing.Color.Lime
        Me.lblTimeStatement.Location = New System.Drawing.Point(12, 9)
        Me.lblTimeStatement.Name = "lblTimeStatement"
        Me.lblTimeStatement.Size = New System.Drawing.Size(78, 31)
        Me.lblTimeStatement.TabIndex = 4
        Me.lblTimeStatement.Text = "Time"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Lime
        Me.lblTime.Location = New System.Drawing.Point(39, 40)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 31)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "15"
        '
        'PicNorton
        '
        Me.PicNorton.BackColor = System.Drawing.Color.Transparent
        Me.PicNorton.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Norton
        Me.PicNorton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicNorton.Location = New System.Drawing.Point(88, 208)
        Me.PicNorton.Name = "PicNorton"
        Me.PicNorton.Size = New System.Drawing.Size(112, 106)
        Me.PicNorton.TabIndex = 6
        Me.PicNorton.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.PicNorton)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTimeStatement)
        Me.Controls.Add(Me.lblSecurityLevelNumber)
        Me.Controls.Add(Me.lblSecurityLevelStatement)
        Me.Controls.Add(Me.PicVirus)
        Me.Controls.Add(Me.picMouseCursor)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graphics Assignment 4"
        CType(Me.picMouseCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVirus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNorton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMouseCursor As System.Windows.Forms.PictureBox
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrDown As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrRight As System.Windows.Forms.Timer
    Friend WithEvents PicVirus As System.Windows.Forms.PictureBox
    Friend WithEvents tmrVirus As System.Windows.Forms.Timer
    Friend WithEvents lblSecurityLevelStatement As System.Windows.Forms.Label
    Friend WithEvents lblSecurityLevelNumber As System.Windows.Forms.Label
    Friend WithEvents tmrNorton As System.Windows.Forms.Timer
    Friend WithEvents lblTimeStatement As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents PicNorton As System.Windows.Forms.PictureBox

End Class
