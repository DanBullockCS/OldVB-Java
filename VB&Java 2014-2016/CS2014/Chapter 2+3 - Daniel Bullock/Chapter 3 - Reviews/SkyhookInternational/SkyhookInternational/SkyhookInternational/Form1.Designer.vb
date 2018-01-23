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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnShip = New System.Windows.Forms.Button()
        Me.txtboxShips = New System.Windows.Forms.TextBox()
        Me.lblBoxes = New System.Windows.Forms.Label()
        Me.lblEnvelopes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(24, 22)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(146, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Number of skyhooks ordered:"
        '
        'btnShip
        '
        Me.btnShip.Location = New System.Drawing.Point(27, 51)
        Me.btnShip.Name = "btnShip"
        Me.btnShip.Size = New System.Drawing.Size(68, 25)
        Me.btnShip.TabIndex = 1
        Me.btnShip.Text = "Ship"
        Me.btnShip.UseVisualStyleBackColor = True
        '
        'txtboxShips
        '
        Me.txtboxShips.Location = New System.Drawing.Point(176, 19)
        Me.txtboxShips.Name = "txtboxShips"
        Me.txtboxShips.Size = New System.Drawing.Size(45, 20)
        Me.txtboxShips.TabIndex = 2
        '
        'lblBoxes
        '
        Me.lblBoxes.AutoSize = True
        Me.lblBoxes.Location = New System.Drawing.Point(78, 90)
        Me.lblBoxes.Name = "lblBoxes"
        Me.lblBoxes.Size = New System.Drawing.Size(0, 13)
        Me.lblBoxes.TabIndex = 3
        '
        'lblEnvelopes
        '
        Me.lblEnvelopes.AutoSize = True
        Me.lblEnvelopes.Location = New System.Drawing.Point(78, 115)
        Me.lblEnvelopes.Name = "lblEnvelopes"
        Me.lblEnvelopes.Size = New System.Drawing.Size(0, 13)
        Me.lblEnvelopes.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(255, 137)
        Me.Controls.Add(Me.lblEnvelopes)
        Me.Controls.Add(Me.lblBoxes)
        Me.Controls.Add(Me.txtboxShips)
        Me.Controls.Add(Me.btnShip)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "Form1"
        Me.Text = "Skyhook International"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnShip As System.Windows.Forms.Button
    Friend WithEvents txtboxShips As System.Windows.Forms.TextBox
    Friend WithEvents lblBoxes As System.Windows.Forms.Label
    Friend WithEvents lblEnvelopes As System.Windows.Forms.Label

End Class
