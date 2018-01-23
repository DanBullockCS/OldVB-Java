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
        Me.PictureBoxRed = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPink = New System.Windows.Forms.PictureBox()
        Me.PictureBoxOrange = New System.Windows.Forms.PictureBox()
        Me.PictureBoxGreen = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxRed
        '
        Me.PictureBoxRed.Image = Global.ChangeImage.My.Resources.Resources.red
        Me.PictureBoxRed.InitialImage = Nothing
        Me.PictureBoxRed.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxRed.Name = "PictureBoxRed"
        Me.PictureBoxRed.Size = New System.Drawing.Size(82, 69)
        Me.PictureBoxRed.TabIndex = 0
        Me.PictureBoxRed.TabStop = False
        '
        'PictureBoxPink
        '
        Me.PictureBoxPink.Image = Global.ChangeImage.My.Resources.Resources.pink
        Me.PictureBoxPink.Location = New System.Drawing.Point(147, 12)
        Me.PictureBoxPink.Name = "PictureBoxPink"
        Me.PictureBoxPink.Size = New System.Drawing.Size(82, 69)
        Me.PictureBoxPink.TabIndex = 1
        Me.PictureBoxPink.TabStop = False
        '
        'PictureBoxOrange
        '
        Me.PictureBoxOrange.Image = Global.ChangeImage.My.Resources.Resources.orange
        Me.PictureBoxOrange.Location = New System.Drawing.Point(12, 106)
        Me.PictureBoxOrange.Name = "PictureBoxOrange"
        Me.PictureBoxOrange.Size = New System.Drawing.Size(82, 69)
        Me.PictureBoxOrange.TabIndex = 2
        Me.PictureBoxOrange.TabStop = False
        '
        'PictureBoxGreen
        '
        Me.PictureBoxGreen.Image = Global.ChangeImage.My.Resources.Resources.green
        Me.PictureBoxGreen.Location = New System.Drawing.Point(150, 106)
        Me.PictureBoxGreen.Name = "PictureBoxGreen"
        Me.PictureBoxGreen.Size = New System.Drawing.Size(82, 69)
        Me.PictureBoxGreen.TabIndex = 3
        Me.PictureBoxGreen.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 187)
        Me.Controls.Add(Me.PictureBoxGreen)
        Me.Controls.Add(Me.PictureBoxOrange)
        Me.Controls.Add(Me.PictureBoxPink)
        Me.Controls.Add(Me.PictureBoxRed)
        Me.Name = "Form1"
        Me.Text = "Change Image"
        CType(Me.PictureBoxRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxGreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBoxRed As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxPink As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxOrange As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxGreen As System.Windows.Forms.PictureBox

End Class
