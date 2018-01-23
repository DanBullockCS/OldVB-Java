<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotMachine
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
        Me.lblBackToMenu = New System.Windows.Forms.Label()
        Me.picSlot3 = New System.Windows.Forms.PictureBox()
        Me.picSlot2 = New System.Windows.Forms.PictureBox()
        Me.picSlot1 = New System.Windows.Forms.PictureBox()
        Me.picSpin = New System.Windows.Forms.PictureBox()
        Me.lblTokens = New System.Windows.Forms.Label()
        Me.lblStatementTokens = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblNumberOfSpins = New System.Windows.Forms.Label()
        CType(Me.picSlot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBackToMenu
        '
        Me.lblBackToMenu.AutoSize = True
        Me.lblBackToMenu.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!)
        Me.lblBackToMenu.Location = New System.Drawing.Point(376, 9)
        Me.lblBackToMenu.Name = "lblBackToMenu"
        Me.lblBackToMenu.Size = New System.Drawing.Size(196, 23)
        Me.lblBackToMenu.TabIndex = 1
        Me.lblBackToMenu.Text = "Back to Main Menu"
        '
        'picSlot3
        '
        Me.picSlot3.BackColor = System.Drawing.Color.Transparent
        Me.picSlot3.Location = New System.Drawing.Point(355, 190)
        Me.picSlot3.Name = "picSlot3"
        Me.picSlot3.Size = New System.Drawing.Size(85, 104)
        Me.picSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSlot3.TabIndex = 2
        Me.picSlot3.TabStop = False
        '
        'picSlot2
        '
        Me.picSlot2.BackColor = System.Drawing.Color.Transparent
        Me.picSlot2.Location = New System.Drawing.Point(250, 190)
        Me.picSlot2.Name = "picSlot2"
        Me.picSlot2.Size = New System.Drawing.Size(85, 104)
        Me.picSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSlot2.TabIndex = 3
        Me.picSlot2.TabStop = False
        '
        'picSlot1
        '
        Me.picSlot1.BackColor = System.Drawing.Color.Transparent
        Me.picSlot1.Location = New System.Drawing.Point(146, 190)
        Me.picSlot1.Name = "picSlot1"
        Me.picSlot1.Size = New System.Drawing.Size(85, 104)
        Me.picSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSlot1.TabIndex = 4
        Me.picSlot1.TabStop = False
        '
        'picSpin
        '
        Me.picSpin.BackColor = System.Drawing.Color.Transparent
        Me.picSpin.Location = New System.Drawing.Point(411, 400)
        Me.picSpin.Name = "picSpin"
        Me.picSpin.Size = New System.Drawing.Size(50, 51)
        Me.picSpin.TabIndex = 5
        Me.picSpin.TabStop = False
        '
        'lblTokens
        '
        Me.lblTokens.AutoSize = True
        Me.lblTokens.BackColor = System.Drawing.Color.Transparent
        Me.lblTokens.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.lblTokens.ForeColor = System.Drawing.Color.Red
        Me.lblTokens.Location = New System.Drawing.Point(218, 310)
        Me.lblTokens.Name = "lblTokens"
        Me.lblTokens.Size = New System.Drawing.Size(0, 20)
        Me.lblTokens.TabIndex = 6
        '
        'lblStatementTokens
        '
        Me.lblStatementTokens.AutoSize = True
        Me.lblStatementTokens.BackColor = System.Drawing.Color.Transparent
        Me.lblStatementTokens.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.lblStatementTokens.ForeColor = System.Drawing.Color.Red
        Me.lblStatementTokens.Location = New System.Drawing.Point(142, 310)
        Me.lblStatementTokens.Name = "lblStatementTokens"
        Me.lblStatementTokens.Size = New System.Drawing.Size(76, 20)
        Me.lblStatementTokens.TabIndex = 7
        Me.lblStatementTokens.Text = "Tokens:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.0!)
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(123, 365)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(203, 20)
        Me.lblMessage.TabIndex = 8
        Me.lblMessage.Text = "Press the spin button!"
        '
        'lblNumberOfSpins
        '
        Me.lblNumberOfSpins.BackColor = System.Drawing.Color.White
        Me.lblNumberOfSpins.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 7.5!)
        Me.lblNumberOfSpins.ForeColor = System.Drawing.Color.Red
        Me.lblNumberOfSpins.Location = New System.Drawing.Point(270, 310)
        Me.lblNumberOfSpins.Name = "lblNumberOfSpins"
        Me.lblNumberOfSpins.Size = New System.Drawing.Size(121, 34)
        Me.lblNumberOfSpins.TabIndex = 9
        Me.lblNumberOfSpins.Text = "Number of spins:"
        '
        'SlotMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = Global.Arcade.My.Resources.Resources.slot_machine
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(584, 523)
        Me.Controls.Add(Me.lblNumberOfSpins)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblStatementTokens)
        Me.Controls.Add(Me.lblTokens)
        Me.Controls.Add(Me.picSpin)
        Me.Controls.Add(Me.picSlot1)
        Me.Controls.Add(Me.picSlot2)
        Me.Controls.Add(Me.picSlot3)
        Me.Controls.Add(Me.lblBackToMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SlotMachine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SlotMachine"
        CType(Me.picSlot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBackToMenu As System.Windows.Forms.Label
    Friend WithEvents picSlot3 As System.Windows.Forms.PictureBox
    Friend WithEvents picSlot2 As System.Windows.Forms.PictureBox
    Friend WithEvents picSlot1 As System.Windows.Forms.PictureBox
    Friend WithEvents picSpin As System.Windows.Forms.PictureBox
    Friend WithEvents lblTokens As System.Windows.Forms.Label
    Friend WithEvents lblStatementTokens As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfSpins As System.Windows.Forms.Label
End Class
