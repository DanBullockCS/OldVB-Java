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
        CType(Me.picMouseCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVirus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMouseCursor
        '
        Me.picMouseCursor.BackColor = System.Drawing.Color.Transparent
        Me.picMouseCursor.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Mouse_Cursor_copy
        Me.picMouseCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMouseCursor.Location = New System.Drawing.Point(436, 241)
        Me.picMouseCursor.Name = "picMouseCursor"
        Me.picMouseCursor.Size = New System.Drawing.Size(62, 54)
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
        Me.PicVirus.Location = New System.Drawing.Point(824, -31)
        Me.PicVirus.Name = "PicVirus"
        Me.PicVirus.Size = New System.Drawing.Size(86, 84)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.lblSecurityLevelNumber)
        Me.Controls.Add(Me.lblSecurityLevelStatement)
        Me.Controls.Add(Me.PicVirus)
        Me.Controls.Add(Me.picMouseCursor)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "Form1"
        Me.Text = "Graphics Assignment 2"
        CType(Me.picMouseCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVirus, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
