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
        CType(Me.picMouseCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMouseCursor
        '
        Me.picMouseCursor.BackColor = System.Drawing.Color.Transparent
        Me.picMouseCursor.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Mouse_Cursor
        Me.picMouseCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMouseCursor.Location = New System.Drawing.Point(333, 204)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Graphics_Assignment_1.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.picMouseCursor)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Graphics Assignment 1"
        CType(Me.picMouseCursor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picMouseCursor As System.Windows.Forms.PictureBox
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrDown As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrRight As System.Windows.Forms.Timer

End Class
