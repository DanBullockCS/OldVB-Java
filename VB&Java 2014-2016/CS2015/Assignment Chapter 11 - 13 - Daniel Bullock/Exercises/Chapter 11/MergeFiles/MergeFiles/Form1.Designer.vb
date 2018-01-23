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
        Me.lblEnterFile1 = New System.Windows.Forms.Label()
        Me.btnMerge = New System.Windows.Forms.Button()
        Me.txtFile1 = New System.Windows.Forms.TextBox()
        Me.txtFile2 = New System.Windows.Forms.TextBox()
        Me.lblEnterFile2 = New System.Windows.Forms.Label()
        Me.txtFileReader = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblEnterFile1
        '
        Me.lblEnterFile1.AutoSize = True
        Me.lblEnterFile1.Location = New System.Drawing.Point(25, 23)
        Me.lblEnterFile1.Name = "lblEnterFile1"
        Me.lblEnterFile1.Size = New System.Drawing.Size(119, 13)
        Me.lblEnterFile1.TabIndex = 0
        Me.lblEnterFile1.Text = "Enter the name of file 1:"
        '
        'btnMerge
        '
        Me.btnMerge.Location = New System.Drawing.Point(108, 99)
        Me.btnMerge.Name = "btnMerge"
        Me.btnMerge.Size = New System.Drawing.Size(75, 23)
        Me.btnMerge.TabIndex = 1
        Me.btnMerge.Text = "Merge"
        Me.btnMerge.UseVisualStyleBackColor = True
        '
        'txtFile1
        '
        Me.txtFile1.Location = New System.Drawing.Point(159, 20)
        Me.txtFile1.Name = "txtFile1"
        Me.txtFile1.Size = New System.Drawing.Size(120, 20)
        Me.txtFile1.TabIndex = 2
        '
        'txtFile2
        '
        Me.txtFile2.Location = New System.Drawing.Point(159, 73)
        Me.txtFile2.Name = "txtFile2"
        Me.txtFile2.Size = New System.Drawing.Size(120, 20)
        Me.txtFile2.TabIndex = 3
        '
        'lblEnterFile2
        '
        Me.lblEnterFile2.AutoSize = True
        Me.lblEnterFile2.Location = New System.Drawing.Point(25, 76)
        Me.lblEnterFile2.Name = "lblEnterFile2"
        Me.lblEnterFile2.Size = New System.Drawing.Size(119, 13)
        Me.lblEnterFile2.TabIndex = 4
        Me.lblEnterFile2.Text = "Enter the name of file 2:"
        '
        'txtFileReader
        '
        Me.txtFileReader.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtFileReader.Location = New System.Drawing.Point(0, 143)
        Me.txtFileReader.Multiline = True
        Me.txtFileReader.Name = "txtFileReader"
        Me.txtFileReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileReader.Size = New System.Drawing.Size(308, 142)
        Me.txtFileReader.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 285)
        Me.Controls.Add(Me.txtFileReader)
        Me.Controls.Add(Me.lblEnterFile2)
        Me.Controls.Add(Me.txtFile2)
        Me.Controls.Add(Me.txtFile1)
        Me.Controls.Add(Me.btnMerge)
        Me.Controls.Add(Me.lblEnterFile1)
        Me.Name = "Form1"
        Me.Text = "Merge Files"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterFile1 As System.Windows.Forms.Label
    Friend WithEvents btnMerge As System.Windows.Forms.Button
    Friend WithEvents txtFile1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFile2 As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterFile2 As System.Windows.Forms.Label
    Friend WithEvents txtFileReader As System.Windows.Forms.TextBox

End Class
