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
        Me.txtboxKilo = New System.Windows.Forms.TextBox()
        Me.lblEnterTheData = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtboxCentiLength = New System.Windows.Forms.TextBox()
        Me.txtboxCentiWidth = New System.Windows.Forms.TextBox()
        Me.txtboxCentiHeight = New System.Windows.Forms.TextBox()
        Me.lblKilograms = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblAnswerSize = New System.Windows.Forms.Label()
        Me.lblAnswerWeight = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtboxKilo
        '
        Me.txtboxKilo.Location = New System.Drawing.Point(175, 36)
        Me.txtboxKilo.Name = "txtboxKilo"
        Me.txtboxKilo.Size = New System.Drawing.Size(48, 20)
        Me.txtboxKilo.TabIndex = 0
        '
        'lblEnterTheData
        '
        Me.lblEnterTheData.AutoSize = True
        Me.lblEnterTheData.Location = New System.Drawing.Point(35, 9)
        Me.lblEnterTheData.Name = "lblEnterTheData"
        Me.lblEnterTheData.Size = New System.Drawing.Size(129, 13)
        Me.lblEnterTheData.TabIndex = 1
        Me.lblEnterTheData.Text = "Enter the package's data:"
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(132, 208)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(113, 25)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Check Package"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtboxCentiLength
        '
        Me.txtboxCentiLength.Location = New System.Drawing.Point(175, 62)
        Me.txtboxCentiLength.Name = "txtboxCentiLength"
        Me.txtboxCentiLength.Size = New System.Drawing.Size(48, 20)
        Me.txtboxCentiLength.TabIndex = 3
        '
        'txtboxCentiWidth
        '
        Me.txtboxCentiWidth.Location = New System.Drawing.Point(175, 88)
        Me.txtboxCentiWidth.Name = "txtboxCentiWidth"
        Me.txtboxCentiWidth.Size = New System.Drawing.Size(48, 20)
        Me.txtboxCentiWidth.TabIndex = 4
        '
        'txtboxCentiHeight
        '
        Me.txtboxCentiHeight.Location = New System.Drawing.Point(175, 114)
        Me.txtboxCentiHeight.Name = "txtboxCentiHeight"
        Me.txtboxCentiHeight.Size = New System.Drawing.Size(48, 20)
        Me.txtboxCentiHeight.TabIndex = 5
        '
        'lblKilograms
        '
        Me.lblKilograms.AutoSize = True
        Me.lblKilograms.Location = New System.Drawing.Point(35, 39)
        Me.lblKilograms.Name = "lblKilograms"
        Me.lblKilograms.Size = New System.Drawing.Size(99, 13)
        Me.lblKilograms.TabIndex = 6
        Me.lblKilograms.Text = "weight in kilograms:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(35, 65)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(104, 13)
        Me.lblLength.TabIndex = 7
        Me.lblLength.Text = "length in centimeters"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(35, 91)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(100, 13)
        Me.lblWidth.TabIndex = 8
        Me.lblWidth.Text = "width in centimeters"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(35, 117)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(104, 13)
        Me.lblHeight.TabIndex = 9
        Me.lblHeight.Text = "height in centimeters"
        '
        'lblAnswerSize
        '
        Me.lblAnswerSize.AutoSize = True
        Me.lblAnswerSize.Location = New System.Drawing.Point(35, 168)
        Me.lblAnswerSize.Name = "lblAnswerSize"
        Me.lblAnswerSize.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswerSize.TabIndex = 10
        '
        'lblAnswerWeight
        '
        Me.lblAnswerWeight.AutoSize = True
        Me.lblAnswerWeight.Location = New System.Drawing.Point(35, 197)
        Me.lblAnswerWeight.Name = "lblAnswerWeight"
        Me.lblAnswerWeight.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswerWeight.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 245)
        Me.Controls.Add(Me.lblAnswerWeight)
        Me.Controls.Add(Me.lblAnswerSize)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblKilograms)
        Me.Controls.Add(Me.txtboxCentiHeight)
        Me.Controls.Add(Me.txtboxCentiWidth)
        Me.Controls.Add(Me.txtboxCentiLength)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblEnterTheData)
        Me.Controls.Add(Me.txtboxKilo)
        Me.Name = "Form1"
        Me.Text = "Package Check"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxKilo As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterTheData As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents txtboxCentiLength As System.Windows.Forms.TextBox
    Friend WithEvents txtboxCentiWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtboxCentiHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblKilograms As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblAnswerSize As System.Windows.Forms.Label
    Friend WithEvents lblAnswerWeight As System.Windows.Forms.Label

End Class
