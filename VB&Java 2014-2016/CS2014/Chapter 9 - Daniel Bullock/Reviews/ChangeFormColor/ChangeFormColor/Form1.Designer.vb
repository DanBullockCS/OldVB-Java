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
        Me.btnHoneydew = New System.Windows.Forms.Button()
        Me.btnThistle = New System.Windows.Forms.Button()
        Me.btnDarkKhaki = New System.Windows.Forms.Button()
        Me.btnTurquoise = New System.Windows.Forms.Button()
        Me.btnSalmon = New System.Windows.Forms.Button()
        Me.btnSkyBlue = New System.Windows.Forms.Button()
        Me.btnChooseColor = New System.Windows.Forms.Button()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'btnHoneydew
        '
        Me.btnHoneydew.BackColor = System.Drawing.Color.Blue
        Me.btnHoneydew.ForeColor = System.Drawing.Color.White
        Me.btnHoneydew.Location = New System.Drawing.Point(25, 23)
        Me.btnHoneydew.Name = "btnHoneydew"
        Me.btnHoneydew.Size = New System.Drawing.Size(79, 24)
        Me.btnHoneydew.TabIndex = 0
        Me.btnHoneydew.Text = "Honeydew"
        Me.btnHoneydew.UseVisualStyleBackColor = False
        '
        'btnThistle
        '
        Me.btnThistle.BackColor = System.Drawing.Color.Blue
        Me.btnThistle.ForeColor = System.Drawing.Color.White
        Me.btnThistle.Location = New System.Drawing.Point(133, 23)
        Me.btnThistle.Name = "btnThistle"
        Me.btnThistle.Size = New System.Drawing.Size(79, 24)
        Me.btnThistle.TabIndex = 1
        Me.btnThistle.Text = "Thistle"
        Me.btnThistle.UseVisualStyleBackColor = False
        '
        'btnDarkKhaki
        '
        Me.btnDarkKhaki.BackColor = System.Drawing.Color.Blue
        Me.btnDarkKhaki.ForeColor = System.Drawing.Color.White
        Me.btnDarkKhaki.Location = New System.Drawing.Point(133, 81)
        Me.btnDarkKhaki.Name = "btnDarkKhaki"
        Me.btnDarkKhaki.Size = New System.Drawing.Size(79, 24)
        Me.btnDarkKhaki.TabIndex = 2
        Me.btnDarkKhaki.Text = "DarkKhaki"
        Me.btnDarkKhaki.UseVisualStyleBackColor = False
        '
        'btnTurquoise
        '
        Me.btnTurquoise.BackColor = System.Drawing.Color.Blue
        Me.btnTurquoise.ForeColor = System.Drawing.Color.White
        Me.btnTurquoise.Location = New System.Drawing.Point(25, 81)
        Me.btnTurquoise.Name = "btnTurquoise"
        Me.btnTurquoise.Size = New System.Drawing.Size(79, 24)
        Me.btnTurquoise.TabIndex = 3
        Me.btnTurquoise.Text = "Turquoise"
        Me.btnTurquoise.UseVisualStyleBackColor = False
        '
        'btnSalmon
        '
        Me.btnSalmon.BackColor = System.Drawing.Color.Blue
        Me.btnSalmon.ForeColor = System.Drawing.Color.White
        Me.btnSalmon.Location = New System.Drawing.Point(239, 81)
        Me.btnSalmon.Name = "btnSalmon"
        Me.btnSalmon.Size = New System.Drawing.Size(79, 24)
        Me.btnSalmon.TabIndex = 4
        Me.btnSalmon.Text = "Salmon"
        Me.btnSalmon.UseVisualStyleBackColor = False
        '
        'btnSkyBlue
        '
        Me.btnSkyBlue.BackColor = System.Drawing.Color.Blue
        Me.btnSkyBlue.ForeColor = System.Drawing.Color.White
        Me.btnSkyBlue.Location = New System.Drawing.Point(239, 23)
        Me.btnSkyBlue.Name = "btnSkyBlue"
        Me.btnSkyBlue.Size = New System.Drawing.Size(79, 24)
        Me.btnSkyBlue.TabIndex = 5
        Me.btnSkyBlue.Text = "SkyBlue"
        Me.btnSkyBlue.UseVisualStyleBackColor = False
        '
        'btnChooseColor
        '
        Me.btnChooseColor.BackColor = System.Drawing.Color.Blue
        Me.btnChooseColor.ForeColor = System.Drawing.Color.White
        Me.btnChooseColor.Location = New System.Drawing.Point(124, 149)
        Me.btnChooseColor.Name = "btnChooseColor"
        Me.btnChooseColor.Size = New System.Drawing.Size(97, 24)
        Me.btnChooseColor.TabIndex = 6
        Me.btnChooseColor.Text = "Choose Color"
        Me.btnChooseColor.UseVisualStyleBackColor = False
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Location = New System.Drawing.Point(160, 118)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(18, 13)
        Me.lblOr.TabIndex = 7
        Me.lblOr.Text = "Or"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(339, 185)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.btnChooseColor)
        Me.Controls.Add(Me.btnSkyBlue)
        Me.Controls.Add(Me.btnSalmon)
        Me.Controls.Add(Me.btnTurquoise)
        Me.Controls.Add(Me.btnDarkKhaki)
        Me.Controls.Add(Me.btnThistle)
        Me.Controls.Add(Me.btnHoneydew)
        Me.Name = "Form1"
        Me.Text = "Change Form Color"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHoneydew As System.Windows.Forms.Button
    Friend WithEvents btnThistle As System.Windows.Forms.Button
    Friend WithEvents btnDarkKhaki As System.Windows.Forms.Button
    Friend WithEvents btnTurquoise As System.Windows.Forms.Button
    Friend WithEvents btnSalmon As System.Windows.Forms.Button
    Friend WithEvents btnSkyBlue As System.Windows.Forms.Button
    Friend WithEvents btnChooseColor As System.Windows.Forms.Button
    Friend WithEvents lblOr As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

End Class
