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
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.lblPetInfo = New System.Windows.Forms.Label()
        Me.picPetPhoto = New System.Windows.Forms.PictureBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtPetName = New System.Windows.Forms.TextBox()
        Me.linklblPetStore = New System.Windows.Forms.LinkLabel()
        CType(Me.picPetPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(402, 12)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnGetInfo.TabIndex = 0
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'lblPetInfo
        '
        Me.lblPetInfo.Location = New System.Drawing.Point(12, 65)
        Me.lblPetInfo.Name = "lblPetInfo"
        Me.lblPetInfo.Size = New System.Drawing.Size(268, 133)
        Me.lblPetInfo.TabIndex = 1
        '
        'picPetPhoto
        '
        Me.picPetPhoto.Location = New System.Drawing.Point(313, 65)
        Me.picPetPhoto.Name = "picPetPhoto"
        Me.picPetPhoto.Size = New System.Drawing.Size(148, 133)
        Me.picPetPhoto.TabIndex = 2
        Me.picPetPhoto.TabStop = False
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(84, 17)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(106, 13)
        Me.lblPrompt.TabIndex = 3
        Me.lblPrompt.Text = "Enter the type of pet:"
        '
        'txtPetName
        '
        Me.txtPetName.Location = New System.Drawing.Point(224, 15)
        Me.txtPetName.Name = "txtPetName"
        Me.txtPetName.Size = New System.Drawing.Size(122, 20)
        Me.txtPetName.TabIndex = 4
        '
        'linklblPetStore
        '
        Me.linklblPetStore.AutoSize = True
        Me.linklblPetStore.Location = New System.Drawing.Point(174, 213)
        Me.linklblPetStore.Name = "linklblPetStore"
        Me.linklblPetStore.Size = New System.Drawing.Size(145, 13)
        Me.linklblPetStore.TabIndex = 5
        Me.linklblPetStore.TabStop = True
        Me.linklblPetStore.Text = "http://www.lvp.com/petstore"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 235)
        Me.Controls.Add(Me.linklblPetStore)
        Me.Controls.Add(Me.txtPetName)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.picPetPhoto)
        Me.Controls.Add(Me.lblPetInfo)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Name = "Form1"
        Me.Text = "Pet Store"
        CType(Me.picPetPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetInfo As System.Windows.Forms.Button
    Friend WithEvents lblPetInfo As System.Windows.Forms.Label
    Friend WithEvents picPetPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPetName As System.Windows.Forms.TextBox
    Friend WithEvents linklblPetStore As System.Windows.Forms.LinkLabel

End Class
