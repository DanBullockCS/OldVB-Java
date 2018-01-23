<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblAnswer1 = New System.Windows.Forms.Label()
        Me.lblAnswer2 = New System.Windows.Forms.Label()
        Me.lblAnswer3 = New System.Windows.Forms.Label()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.lblStatementSecurityLevel = New System.Windows.Forms.Label()
        Me.lblSecurityLevelRemaining = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.picMonitor = New System.Windows.Forms.PictureBox()
        Me.tmrMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.picMonitorWithMsg = New System.Windows.Forms.PictureBox()
        Me.tmrMonitor2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMonitorWithMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.Red
        Me.lblQuestion.Location = New System.Drawing.Point(60, 198)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(453, 24)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Press the begin button and answer 3 questions!"
        '
        'lblAnswer1
        '
        Me.lblAnswer1.AutoSize = True
        Me.lblAnswer1.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer1.ForeColor = System.Drawing.Color.Red
        Me.lblAnswer1.Location = New System.Drawing.Point(60, 283)
        Me.lblAnswer1.Name = "lblAnswer1"
        Me.lblAnswer1.Size = New System.Drawing.Size(0, 24)
        Me.lblAnswer1.TabIndex = 1
        '
        'lblAnswer2
        '
        Me.lblAnswer2.AutoSize = True
        Me.lblAnswer2.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer2.ForeColor = System.Drawing.Color.Red
        Me.lblAnswer2.Location = New System.Drawing.Point(60, 348)
        Me.lblAnswer2.Name = "lblAnswer2"
        Me.lblAnswer2.Size = New System.Drawing.Size(0, 24)
        Me.lblAnswer2.TabIndex = 2
        '
        'lblAnswer3
        '
        Me.lblAnswer3.AutoSize = True
        Me.lblAnswer3.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer3.ForeColor = System.Drawing.Color.Red
        Me.lblAnswer3.Location = New System.Drawing.Point(60, 421)
        Me.lblAnswer3.Name = "lblAnswer3"
        Me.lblAnswer3.Size = New System.Drawing.Size(0, 24)
        Me.lblAnswer3.TabIndex = 3
        '
        'btnBegin
        '
        Me.btnBegin.BackColor = System.Drawing.Color.Lime
        Me.btnBegin.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.ForeColor = System.Drawing.Color.White
        Me.btnBegin.Location = New System.Drawing.Point(694, 74)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(128, 86)
        Me.btnBegin.TabIndex = 4
        Me.btnBegin.Text = "Begin"
        Me.btnBegin.UseVisualStyleBackColor = False
        '
        'lblStatementSecurityLevel
        '
        Me.lblStatementSecurityLevel.AutoSize = True
        Me.lblStatementSecurityLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblStatementSecurityLevel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatementSecurityLevel.ForeColor = System.Drawing.Color.Red
        Me.lblStatementSecurityLevel.Location = New System.Drawing.Point(574, 457)
        Me.lblStatementSecurityLevel.Name = "lblStatementSecurityLevel"
        Me.lblStatementSecurityLevel.Size = New System.Drawing.Size(248, 24)
        Me.lblStatementSecurityLevel.TabIndex = 5
        Me.lblStatementSecurityLevel.Text = "Security Level Remaining"
        '
        'lblSecurityLevelRemaining
        '
        Me.lblSecurityLevelRemaining.AutoSize = True
        Me.lblSecurityLevelRemaining.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecurityLevelRemaining.ForeColor = System.Drawing.Color.Red
        Me.lblSecurityLevelRemaining.Location = New System.Drawing.Point(690, 498)
        Me.lblSecurityLevelRemaining.Name = "lblSecurityLevelRemaining"
        Me.lblSecurityLevelRemaining.Size = New System.Drawing.Size(0, 24)
        Me.lblSecurityLevelRemaining.TabIndex = 6
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.BackColor = System.Drawing.Color.Transparent
        Me.lblHelp.Location = New System.Drawing.Point(762, 43)
        Me.lblHelp.MaximumSize = New System.Drawing.Size(50, 50)
        Me.lblHelp.MinimumSize = New System.Drawing.Size(50, 10)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(50, 13)
        Me.lblHelp.TabIndex = 7
        '
        'picMonitor
        '
        Me.picMonitor.BackColor = System.Drawing.Color.Transparent
        Me.picMonitor.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Computer_Monitor
        Me.picMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMonitor.Location = New System.Drawing.Point(619, 311)
        Me.picMonitor.Name = "picMonitor"
        Me.picMonitor.Size = New System.Drawing.Size(160, 122)
        Me.picMonitor.TabIndex = 8
        Me.picMonitor.TabStop = False
        '
        'tmrMonitor
        '
        Me.tmrMonitor.Enabled = True
        Me.tmrMonitor.Interval = 1
        '
        'picMonitorWithMsg
        '
        Me.picMonitorWithMsg.BackColor = System.Drawing.Color.Transparent
        Me.picMonitorWithMsg.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Computer_Monitor_With_Msg
        Me.picMonitorWithMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMonitorWithMsg.Location = New System.Drawing.Point(619, 311)
        Me.picMonitorWithMsg.Name = "picMonitorWithMsg"
        Me.picMonitorWithMsg.Size = New System.Drawing.Size(160, 122)
        Me.picMonitorWithMsg.TabIndex = 9
        Me.picMonitorWithMsg.TabStop = False
        '
        'tmrMonitor2
        '
        Me.tmrMonitor2.Enabled = True
        Me.tmrMonitor2.Interval = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Norton_Form_2_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 562)
        Me.Controls.Add(Me.picMonitorWithMsg)
        Me.Controls.Add(Me.picMonitor)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblSecurityLevelRemaining)
        Me.Controls.Add(Me.lblStatementSecurityLevel)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.lblAnswer3)
        Me.Controls.Add(Me.lblAnswer2)
        Me.Controls.Add(Me.lblAnswer1)
        Me.Controls.Add(Me.lblQuestion)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz!"
        CType(Me.picMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMonitorWithMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblAnswer1 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer2 As System.Windows.Forms.Label
    Friend WithEvents lblAnswer3 As System.Windows.Forms.Label
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents lblStatementSecurityLevel As System.Windows.Forms.Label
    Friend WithEvents lblSecurityLevelRemaining As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents picMonitor As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMonitor As System.Windows.Forms.Timer
    Friend WithEvents picMonitorWithMsg As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMonitor2 As System.Windows.Forms.Timer
End Class
