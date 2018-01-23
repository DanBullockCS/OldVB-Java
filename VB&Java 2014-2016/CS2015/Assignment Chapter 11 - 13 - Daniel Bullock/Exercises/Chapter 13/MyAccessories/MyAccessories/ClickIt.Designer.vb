<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClickIt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClickIt))
        Me.picShape5 = New System.Windows.Forms.PictureBox()
        Me.picShape4 = New System.Windows.Forms.PictureBox()
        Me.picShape3 = New System.Windows.Forms.PictureBox()
        Me.picShape2 = New System.Windows.Forms.PictureBox()
        Me.picShape1 = New System.Windows.Forms.PictureBox()
        Me.picShape0 = New System.Windows.Forms.PictureBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.tmrGameLength = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShowShape = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picShape5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picShape5
        '
        Me.picShape5.Image = CType(resources.GetObject("picShape5.Image"), System.Drawing.Image)
        Me.picShape5.Location = New System.Drawing.Point(342, 18)
        Me.picShape5.Margin = New System.Windows.Forms.Padding(2)
        Me.picShape5.Name = "picShape5"
        Me.picShape5.Size = New System.Drawing.Size(48, 48)
        Me.picShape5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picShape5.TabIndex = 13
        Me.picShape5.TabStop = False
        Me.picShape5.Tag = "5"
        '
        'picShape4
        '
        Me.picShape4.Image = CType(resources.GetObject("picShape4.Image"), System.Drawing.Image)
        Me.picShape4.Location = New System.Drawing.Point(276, 18)
        Me.picShape4.Margin = New System.Windows.Forms.Padding(2)
        Me.picShape4.Name = "picShape4"
        Me.picShape4.Size = New System.Drawing.Size(48, 48)
        Me.picShape4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picShape4.TabIndex = 12
        Me.picShape4.TabStop = False
        Me.picShape4.Tag = "4"
        '
        'picShape3
        '
        Me.picShape3.Image = CType(resources.GetObject("picShape3.Image"), System.Drawing.Image)
        Me.picShape3.Location = New System.Drawing.Point(210, 18)
        Me.picShape3.Margin = New System.Windows.Forms.Padding(2)
        Me.picShape3.Name = "picShape3"
        Me.picShape3.Size = New System.Drawing.Size(48, 48)
        Me.picShape3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picShape3.TabIndex = 11
        Me.picShape3.TabStop = False
        Me.picShape3.Tag = "3"
        '
        'picShape2
        '
        Me.picShape2.Image = CType(resources.GetObject("picShape2.Image"), System.Drawing.Image)
        Me.picShape2.Location = New System.Drawing.Point(144, 18)
        Me.picShape2.Margin = New System.Windows.Forms.Padding(2)
        Me.picShape2.Name = "picShape2"
        Me.picShape2.Size = New System.Drawing.Size(48, 48)
        Me.picShape2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picShape2.TabIndex = 10
        Me.picShape2.TabStop = False
        Me.picShape2.Tag = "2"
        '
        'picShape1
        '
        Me.picShape1.Image = CType(resources.GetObject("picShape1.Image"), System.Drawing.Image)
        Me.picShape1.Location = New System.Drawing.Point(78, 18)
        Me.picShape1.Margin = New System.Windows.Forms.Padding(2)
        Me.picShape1.Name = "picShape1"
        Me.picShape1.Size = New System.Drawing.Size(48, 48)
        Me.picShape1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picShape1.TabIndex = 9
        Me.picShape1.TabStop = False
        Me.picShape1.Tag = "1"
        '
        'picShape0
        '
        Me.picShape0.Image = CType(resources.GetObject("picShape0.Image"), System.Drawing.Image)
        Me.picShape0.Location = New System.Drawing.Point(12, 18)
        Me.picShape0.Margin = New System.Windows.Forms.Padding(2)
        Me.picShape0.Name = "picShape0"
        Me.picShape0.Size = New System.Drawing.Size(48, 48)
        Me.picShape0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picShape0.TabIndex = 8
        Me.picShape0.TabStop = False
        Me.picShape0.Tag = "0"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(179, 84)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(34, 19)
        Me.btnGo.TabIndex = 7
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'tmrGameLength
        '
        Me.tmrGameLength.Interval = 60000
        '
        'tmrShowShape
        '
        Me.tmrShowShape.Interval = 1000
        '
        'ClickIt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 120)
        Me.Controls.Add(Me.picShape5)
        Me.Controls.Add(Me.picShape4)
        Me.Controls.Add(Me.picShape3)
        Me.Controls.Add(Me.picShape2)
        Me.Controls.Add(Me.picShape1)
        Me.Controls.Add(Me.picShape0)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "ClickIt"
        Me.Text = "ClickIt"
        CType(Me.picShape5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picShape5 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape4 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape3 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape2 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape1 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape0 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents tmrGameLength As System.Windows.Forms.Timer
    Friend WithEvents tmrShowShape As System.Windows.Forms.Timer
End Class
