<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.picFolder1 = New System.Windows.Forms.PictureBox()
        Me.picRecycleBin = New System.Windows.Forms.PictureBox()
        Me.DragTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatementSecurityLevel = New System.Windows.Forms.Label()
        Me.lblLife = New System.Windows.Forms.Label()
        Me.MoveFolder = New System.Windows.Forms.Timer(Me.components)
        Me.picWindow2 = New System.Windows.Forms.PictureBox()
        Me.picDino = New System.Windows.Forms.PictureBox()
        Me.picWindow1 = New System.Windows.Forms.PictureBox()
        Me.picColors = New System.Windows.Forms.PictureBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.tmrColor = New System.Windows.Forms.Timer(Me.components)
        Me.lblNextLevel = New System.Windows.Forms.Label()
        CType(Me.picFolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRecycleBin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWindow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFolder1
        '
        Me.picFolder1.BackColor = System.Drawing.Color.Transparent
        Me.picFolder1.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Folder
        Me.picFolder1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFolder1.Location = New System.Drawing.Point(23, 383)
        Me.picFolder1.Name = "picFolder1"
        Me.picFolder1.Size = New System.Drawing.Size(56, 60)
        Me.picFolder1.TabIndex = 0
        Me.picFolder1.TabStop = False
        '
        'picRecycleBin
        '
        Me.picRecycleBin.BackColor = System.Drawing.Color.Transparent
        Me.picRecycleBin.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Recycle_Bin_Empty
        Me.picRecycleBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRecycleBin.Location = New System.Drawing.Point(612, 341)
        Me.picRecycleBin.Name = "picRecycleBin"
        Me.picRecycleBin.Size = New System.Drawing.Size(99, 102)
        Me.picRecycleBin.TabIndex = 1
        Me.picRecycleBin.TabStop = False
        '
        'DragTimer
        '
        '
        'lblStatementSecurityLevel
        '
        Me.lblStatementSecurityLevel.AutoSize = True
        Me.lblStatementSecurityLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblStatementSecurityLevel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatementSecurityLevel.ForeColor = System.Drawing.Color.Red
        Me.lblStatementSecurityLevel.Location = New System.Drawing.Point(12, 9)
        Me.lblStatementSecurityLevel.Name = "lblStatementSecurityLevel"
        Me.lblStatementSecurityLevel.Size = New System.Drawing.Size(144, 24)
        Me.lblStatementSecurityLevel.TabIndex = 2
        Me.lblStatementSecurityLevel.Text = "Security Level"
        '
        'lblLife
        '
        Me.lblLife.AutoSize = True
        Me.lblLife.BackColor = System.Drawing.Color.Transparent
        Me.lblLife.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLife.ForeColor = System.Drawing.Color.Red
        Me.lblLife.Location = New System.Drawing.Point(79, 41)
        Me.lblLife.Name = "lblLife"
        Me.lblLife.Size = New System.Drawing.Size(0, 24)
        Me.lblLife.TabIndex = 3
        '
        'MoveFolder
        '
        Me.MoveFolder.Interval = 1
        '
        'picWindow2
        '
        Me.picWindow2.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.VLC_Media_Player
        Me.picWindow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWindow2.Location = New System.Drawing.Point(535, 12)
        Me.picWindow2.Name = "picWindow2"
        Me.picWindow2.Size = New System.Drawing.Size(187, 153)
        Me.picWindow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWindow2.TabIndex = 4
        Me.picWindow2.TabStop = False
        '
        'picDino
        '
        Me.picDino.Image = Global.Graphics_Assignment_1.My.Resources.Resources.Dino_soooar
        Me.picDino.Location = New System.Drawing.Point(556, 33)
        Me.picDino.Name = "picDino"
        Me.picDino.Size = New System.Drawing.Size(143, 111)
        Me.picDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDino.TabIndex = 5
        Me.picDino.TabStop = False
        '
        'picWindow1
        '
        Me.picWindow1.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.VLC_Media_Player
        Me.picWindow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWindow1.Location = New System.Drawing.Point(336, 12)
        Me.picWindow1.Name = "picWindow1"
        Me.picWindow1.Size = New System.Drawing.Size(187, 153)
        Me.picWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWindow1.TabIndex = 6
        Me.picWindow1.TabStop = False
        '
        'picColors
        '
        Me.picColors.Image = Global.Graphics_Assignment_1.My.Resources.Resources.Colors
        Me.picColors.Location = New System.Drawing.Point(362, 33)
        Me.picColors.Name = "picColors"
        Me.picColors.Size = New System.Drawing.Size(136, 111)
        Me.picColors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picColors.TabIndex = 7
        Me.picColors.TabStop = False
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Lime
        Me.lblMsg.Location = New System.Drawing.Point(12, 65)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(188, 60)
        Me.lblMsg.TabIndex = 8
        Me.lblMsg.Text = "Drag the folder into " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the recycle bin for a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "50/50 chance for 2 points"
        '
        'tmrColor
        '
        Me.tmrColor.Enabled = True
        '
        'lblNextLevel
        '
        Me.lblNextLevel.AutoSize = True
        Me.lblNextLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblNextLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextLevel.ForeColor = System.Drawing.Color.Red
        Me.lblNextLevel.Location = New System.Drawing.Point(569, 168)
        Me.lblNextLevel.Name = "lblNextLevel"
        Me.lblNextLevel.Size = New System.Drawing.Size(142, 31)
        Me.lblNextLevel.TabIndex = 9
        Me.lblNextLevel.Text = "Next Level"
        '
        'Form3
        '
        Me.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.WindowsXp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 462)
        Me.Controls.Add(Me.lblNextLevel)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.picColors)
        Me.Controls.Add(Me.picWindow1)
        Me.Controls.Add(Me.picDino)
        Me.Controls.Add(Me.picWindow2)
        Me.Controls.Add(Me.lblLife)
        Me.Controls.Add(Me.lblStatementSecurityLevel)
        Me.Controls.Add(Me.picRecycleBin)
        Me.Controls.Add(Me.picFolder1)
        Me.DoubleBuffered = True
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drag and drop"
        CType(Me.picFolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRecycleBin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWindow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picRecyclingBin As System.Windows.Forms.PictureBox
    Friend WithEvents picFolder As System.Windows.Forms.PictureBox
    Friend WithEvents picFolder1 As System.Windows.Forms.PictureBox
    Friend WithEvents picRecycleBin As System.Windows.Forms.PictureBox
    Friend WithEvents DragTimer As System.Windows.Forms.Timer
    Friend WithEvents lblStatementSecurityLevel As System.Windows.Forms.Label
    Friend WithEvents lblLife As System.Windows.Forms.Label
    Friend WithEvents MoveFolder As System.Windows.Forms.Timer
    Friend WithEvents picWindow2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDino As System.Windows.Forms.PictureBox
    Friend WithEvents picWindow1 As System.Windows.Forms.PictureBox
    Friend WithEvents picColors As System.Windows.Forms.PictureBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents tmrColor As System.Windows.Forms.Timer
    Friend WithEvents lblNextLevel As System.Windows.Forms.Label
End Class
