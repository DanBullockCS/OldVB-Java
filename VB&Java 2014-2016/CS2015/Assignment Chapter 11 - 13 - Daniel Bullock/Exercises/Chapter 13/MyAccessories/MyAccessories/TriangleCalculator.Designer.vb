<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TriangleCalculator
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
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.btnHeight = New System.Windows.Forms.Button()
        Me.picTriangle = New System.Windows.Forms.PictureBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnType = New System.Windows.Forms.Button()
        Me.btnPerimeter = New System.Windows.Forms.Button()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.txtSideC = New System.Windows.Forms.TextBox()
        Me.txtSideB = New System.Windows.Forms.TextBox()
        Me.txtSideA = New System.Windows.Forms.TextBox()
        Me.lblSideCPrompt = New System.Windows.Forms.Label()
        Me.lblSideBPrompt = New System.Windows.Forms.Label()
        Me.lblSideAPrompt = New System.Windows.Forms.Label()
        CType(Me.picTriangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(137, 216)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(0, 13)
        Me.lblHeight.TabIndex = 29
        '
        'btnHeight
        '
        Me.btnHeight.Location = New System.Drawing.Point(27, 211)
        Me.btnHeight.Name = "btnHeight"
        Me.btnHeight.Size = New System.Drawing.Size(75, 23)
        Me.btnHeight.TabIndex = 28
        Me.btnHeight.Tag = "Height"
        Me.btnHeight.Text = "Height"
        Me.btnHeight.UseVisualStyleBackColor = True
        '
        'picTriangle
        '
        Me.picTriangle.Image = Global.MyAccessories.My.Resources.Resources.triangle
        Me.picTriangle.Location = New System.Drawing.Point(140, 34)
        Me.picTriangle.Name = "picTriangle"
        Me.picTriangle.Size = New System.Drawing.Size(120, 61)
        Me.picTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTriangle.TabIndex = 27
        Me.picTriangle.TabStop = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(137, 187)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(0, 13)
        Me.lblType.TabIndex = 26
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Location = New System.Drawing.Point(137, 158)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(0, 13)
        Me.lblPerimeter.TabIndex = 25
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(137, 129)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(0, 13)
        Me.lblArea.TabIndex = 24
        '
        'btnType
        '
        Me.btnType.Location = New System.Drawing.Point(27, 182)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(75, 23)
        Me.btnType.TabIndex = 23
        Me.btnType.Tag = "Type"
        Me.btnType.Text = "Type"
        Me.btnType.UseVisualStyleBackColor = True
        '
        'btnPerimeter
        '
        Me.btnPerimeter.Location = New System.Drawing.Point(27, 153)
        Me.btnPerimeter.Name = "btnPerimeter"
        Me.btnPerimeter.Size = New System.Drawing.Size(75, 23)
        Me.btnPerimeter.TabIndex = 22
        Me.btnPerimeter.Tag = "Perimeter"
        Me.btnPerimeter.Text = "Perimeter"
        Me.btnPerimeter.UseVisualStyleBackColor = True
        '
        'btnArea
        '
        Me.btnArea.Location = New System.Drawing.Point(27, 124)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(75, 23)
        Me.btnArea.TabIndex = 21
        Me.btnArea.Tag = "Area"
        Me.btnArea.Text = "Area"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'txtSideC
        '
        Me.txtSideC.Location = New System.Drawing.Point(70, 83)
        Me.txtSideC.Name = "txtSideC"
        Me.txtSideC.Size = New System.Drawing.Size(50, 20)
        Me.txtSideC.TabIndex = 20
        '
        'txtSideB
        '
        Me.txtSideB.Location = New System.Drawing.Point(70, 55)
        Me.txtSideB.Name = "txtSideB"
        Me.txtSideB.Size = New System.Drawing.Size(50, 20)
        Me.txtSideB.TabIndex = 19
        '
        'txtSideA
        '
        Me.txtSideA.Location = New System.Drawing.Point(70, 28)
        Me.txtSideA.Name = "txtSideA"
        Me.txtSideA.Size = New System.Drawing.Size(50, 20)
        Me.txtSideA.TabIndex = 18
        '
        'lblSideCPrompt
        '
        Me.lblSideCPrompt.AutoSize = True
        Me.lblSideCPrompt.Location = New System.Drawing.Point(24, 86)
        Me.lblSideCPrompt.Name = "lblSideCPrompt"
        Me.lblSideCPrompt.Size = New System.Drawing.Size(40, 13)
        Me.lblSideCPrompt.TabIndex = 17
        Me.lblSideCPrompt.Text = "Side c:"
        '
        'lblSideBPrompt
        '
        Me.lblSideBPrompt.AutoSize = True
        Me.lblSideBPrompt.Location = New System.Drawing.Point(24, 58)
        Me.lblSideBPrompt.Name = "lblSideBPrompt"
        Me.lblSideBPrompt.Size = New System.Drawing.Size(40, 13)
        Me.lblSideBPrompt.TabIndex = 16
        Me.lblSideBPrompt.Text = "Side b:"
        '
        'lblSideAPrompt
        '
        Me.lblSideAPrompt.AutoSize = True
        Me.lblSideAPrompt.Location = New System.Drawing.Point(24, 31)
        Me.lblSideAPrompt.Name = "lblSideAPrompt"
        Me.lblSideAPrompt.Size = New System.Drawing.Size(40, 13)
        Me.lblSideAPrompt.TabIndex = 15
        Me.lblSideAPrompt.Text = "Side a:"
        '
        'TriangleCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.btnHeight)
        Me.Controls.Add(Me.picTriangle)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.btnType)
        Me.Controls.Add(Me.btnPerimeter)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.txtSideC)
        Me.Controls.Add(Me.txtSideB)
        Me.Controls.Add(Me.txtSideA)
        Me.Controls.Add(Me.lblSideCPrompt)
        Me.Controls.Add(Me.lblSideBPrompt)
        Me.Controls.Add(Me.lblSideAPrompt)
        Me.Name = "TriangleCalculator"
        Me.Text = "TriangleCalculator"
        CType(Me.picTriangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents btnHeight As System.Windows.Forms.Button
    Friend WithEvents picTriangle As System.Windows.Forms.PictureBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblPerimeter As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents btnType As System.Windows.Forms.Button
    Friend WithEvents btnPerimeter As System.Windows.Forms.Button
    Friend WithEvents btnArea As System.Windows.Forms.Button
    Friend WithEvents txtSideC As System.Windows.Forms.TextBox
    Friend WithEvents txtSideB As System.Windows.Forms.TextBox
    Friend WithEvents txtSideA As System.Windows.Forms.TextBox
    Friend WithEvents lblSideCPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSideBPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSideAPrompt As System.Windows.Forms.Label
End Class
